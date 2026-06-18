using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Data.SqlClient;
using Project_Group6;
using Project_Group6.UI;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ValidationLibrary;

namespace LoginForm
{
    public partial class f_AddStudent : Form
    {
        private byte[] studentImage = null;
        private DataTable studentTable = new DataTable();
        private List<string> studentList = new List<string>();
        private ListBox suggestionBox = new ListBox();
        private System.Windows.Forms.Timer hideTimer = new System.Windows.Forms.Timer();

        public f_AddStudent()
        {
            InitializeComponent();
        }

        // =======================
        // LOAD
        // =======================
        private void StudentAdd_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.SelectedIndex = 0;

            LoadStudentID();
            SetupSuggestionBox();

            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // =======================
        // SETUP SUGGESTION BOX
        // =======================
        private void SetupSuggestionBox()
        {
            suggestionBox.Visible = false;
            suggestionBox.Size = new Size(txtID.Width, 120);
            suggestionBox.Font = txtID.Font;
            suggestionBox.Location = new Point(txtID.Left, txtID.Bottom);
            suggestionBox.SelectionMode = SelectionMode.None;
            suggestionBox.BorderStyle = BorderStyle.FixedSingle;

            txtID.Parent.Controls.Add(suggestionBox);
            suggestionBox.BringToFront();

            txtID.TextChanged += txtID_TextChanged;
            txtID.Leave += txtID_Leave;
            hideTimer.Interval = 200;
            hideTimer.Tick += HideTimer_Tick;
        }

        // =======================
        // LOAD STUDENT IDs
        // =======================
        private void LoadStudentID()
        {
            Student student = new Student();
            DataTable table = student.GetAllStudents();

            studentList.Clear();
            foreach (DataRow row in table.Rows)
            {
                // Schema mới: cột ID thay MSSV
                string display = $"{row["ID"]} - {row["FirstName"]} {row["LastName"]}";
                studentList.Add(display);
            }
        }

        // =======================
        // TEXTBOX ID - GỢI Ý
        // =======================
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtID.Text.Trim();
            if (keyword == "")
            {
                suggestionBox.Visible = false;
                suggestionBox.Items.Clear();
                return;
            }

            var filtered = studentList
                .Where(item =>
                {
                    string idPart = item.Contains(" - ")
                        ? item[..item.IndexOf(" - ")].Trim()
                        : item.Trim();
                    return idPart.StartsWith(keyword, StringComparison.OrdinalIgnoreCase);
                })
                .ToList();

            suggestionBox.Items.Clear();
            if (filtered.Count == 0)
            {
                suggestionBox.Visible = false;
                return;
            }

            foreach (var item in filtered)
                suggestionBox.Items.Add(item);

            suggestionBox.Visible = true;
            suggestionBox.BringToFront();
        }

        private void txtID_Leave(object sender, EventArgs e) => hideTimer.Start();

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!suggestionBox.Focused)
            {
                suggestionBox.Visible = false;
                suggestionBox.Items.Clear();
            }
        }

        // =======================
        // BUTTONS
        // =======================
        private void btnQuit_Click(object sender, EventArgs e) => this.Close();

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            cboGender.SelectedIndex = 0;
            picStudent.Image = null;
            studentImage = null;
            suggestionBox.Visible = false;
            suggestionBox.Items.Clear();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                studentImage = File.ReadAllBytes(ofd.FileName);
                picStudent.Image = Image.FromStream(new MemoryStream(studentImage));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var student = new Student
            {
                // Schema mới: ID thay MSSV, FirstName/LastName thay Fname/Lname
                // Không còn Hometown
                ID = txtID.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Dob = dtpDob.Value.Date,
                Gender = cboGender.Text,
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Picture = studentImage
            };

            bool result = student.AddStudent();

            if (result)
            {
                bool accountCreated = CreateStudentAccount(
                    username: student.ID,
                    email: student.Email);

                MessageBox.Show(accountCreated
                    ? "Add student successful!\nAccount has been sent to: " + student.Email
                    : "Add student successful!\nBut failed to create account.");
            }
            else
            {
                MessageBox.Show("Add student failed!");
            }
        }

        // =======================
        // TẠO TÀI KHOẢN TỰ ĐỘNG
        // =======================
        private bool CreateStudentAccount(string username, string email)
        {
            try
            {
                string randomPassword = GenerateRandomPassword(10);
                string hashedPassword = PasswordHasher.HashPassword(randomPassword);

                using (var db = new My_DB())
                {
                    db.openConnection();

                    var checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM DataLoginForm WHERE UserName = @user",
                        db.getConnection);
                    checkCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;

                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Account with this Student ID already exists!");
                        return false;
                    }

                    var insertCmd = new SqlCommand(@"
                        INSERT INTO DataLoginForm (UserName, Password, Email, RoleName)
                        VALUES (@user, @pass, @mail, @role)",
                        db.getConnection);
                    insertCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
                    insertCmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPassword;
                    insertCmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
                    insertCmd.Parameters.Add("@role", SqlDbType.VarChar).Value = "user";
                    insertCmd.ExecuteNonQuery();
                }

                return SendPasswordEmail(email, username, randomPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message);
                return false;
            }
        }

        // =======================
        // GỬI EMAIL MẬT KHẨU
        // =======================
        private bool SendPasswordEmail(string email, string username, string password)
        {
            try
            {
                OTP mailer = new OTP();
                string subject = "Your Student Account Information";
                string body = $@"
Hello,

Your student account has been created successfully.

Username : {username}
Password : {password}

Please log in and change your password immediately.

Regards,
Student Management System";

                return mailer.SendEmail(email, subject, body);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
                return false;
            }
        }

        // =======================
        // SINH MẬT KHẨU NGẪU NHIÊN
        // =======================
        private string GenerateRandomPassword(int length)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*";
            const string all = upper + lower + digits + special;

            Random rng = new Random();
            char[] password = new char[length];
            password[0] = upper[rng.Next(upper.Length)];
            password[1] = lower[rng.Next(lower.Length)];
            password[2] = digits[rng.Next(digits.Length)];
            password[3] = special[rng.Next(special.Length)];
            for (int i = 4; i < length; i++)
                password[i] = all[rng.Next(all.Length)];

            return new string(password.OrderBy(_ => rng.Next()).ToArray());
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            f_AIAddStudent aiForm = new f_AIAddStudent();
            if (aiForm.ShowDialog() == DialogResult.OK)
            {
                // Schema mới: dùng FirstName/LastName, không có Hometown
                txtID.Text = aiForm.MSSV;   // nếu AI form dùng MSSV vẫn map sang ID
                txtFirstName.Text = aiForm.Fname;
                txtLastName.Text = aiForm.Lname;
                txtPhone.Text = aiForm.Phone;
                txtAddress.Text = aiForm.Address;
                txtEmail.Text = aiForm.Email;
                cboGender.Text = aiForm.Gender;

                if (DateTime.TryParse(aiForm.Dob, out DateTime d))
                    dtpDob.Value = d;

                MessageBox.Show("AI data loaded");
            }
        }

        // =======================
        // VALIDATE
        // =======================
        private bool ValidateInput()
        {
            if (ValidateData.IsEmpty(txtID.Text))
            { MessageBox.Show("Student ID cannot be empty!"); txtID.Focus(); return false; }

            if (ValidateData.IsEmpty(txtFirstName.Text))
            { MessageBox.Show("First name cannot be empty!"); txtFirstName.Focus(); return false; }

            if (ValidateData.IsEmpty(txtLastName.Text))
            { MessageBox.Show("Last name cannot be empty!"); txtLastName.Focus(); return false; }

            if (ValidateData.IsEmpty(txtPhone.Text))
            { MessageBox.Show("Phone number cannot be empty!"); txtPhone.Focus(); return false; }

            if (ValidateData.IsEmpty(txtAddress.Text))
            { MessageBox.Show("Address cannot be empty!"); txtAddress.Focus(); return false; }

            if (ValidateData.IsEmpty(txtEmail.Text))
            { MessageBox.Show("Email cannot be empty!"); txtEmail.Focus(); return false; }

            if (cboGender.SelectedIndex < 0)
            { MessageBox.Show("Please select a gender!"); cboGender.Focus(); return false; }

            if (picStudent.Image == null)
            { MessageBox.Show("Please select a student image!"); return false; }

            if (!ValidateData.IsValidMSSV(txtID.Text))
            { MessageBox.Show("Student ID can only contain letters and numbers!"); txtID.Focus(); return false; }

            if (!ValidateData.IsValidName(txtFirstName.Text))
            { MessageBox.Show("First name cannot contain numbers!"); txtFirstName.Focus(); return false; }

            if (!ValidateData.IsValidName(txtLastName.Text))
            { MessageBox.Show("Last name cannot contain numbers!"); txtLastName.Focus(); return false; }

            if (!ValidateData.IsValidPhone(txtPhone.Text))
            { MessageBox.Show("Phone number must contain digits only!"); txtPhone.Focus(); return false; }

            if (!ValidateData.IsValidEmail(txtEmail.Text))
            { MessageBox.Show("Invalid email address!"); txtEmail.Focus(); return false; }

            if (!ValidateData.IsValidBirthDay(dtpDob.Value))
            { MessageBox.Show("Invalid date of birth!"); return false; }

            return true;
        }
    }
}