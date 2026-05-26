using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
using Project_Group6.UI;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValidationLibrary;

namespace LoginForm
{
    public partial class f_AddStudent : Form
    {
        byte[] studentImage = null;
        byte[] aiScanImage;
        DataTable studentTable = new DataTable();
        List<string> studentList = new List<string>();
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

            LoadHometown();
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
            suggestionBox.Size = new Size(txtMSSV.Width, 120);
            suggestionBox.Font = txtMSSV.Font;
            suggestionBox.Location = new Point(txtMSSV.Left, txtMSSV.Bottom);

            // KHÔNG CHO CHỌN
            suggestionBox.SelectionMode = SelectionMode.None;
            // Bỏ border cho đẹp hơn
            suggestionBox.BorderStyle = BorderStyle.FixedSingle;

            txtMSSV.Parent.Controls.Add(suggestionBox);
            suggestionBox.BringToFront();

            txtMSSV.TextChanged += txtMSSV_TextChanged;
            txtMSSV.Leave += txtMSSV_Leave;
            hideTimer.Interval = 200;
            hideTimer.Tick += HideTimer_Tick;
        }

        // =======================
        // LOAD STUDENT IDs
        // =======================
        private void LoadStudentID()
        {
            Student student = new Student();

            SqlCommand command = new SqlCommand(@"
                SELECT 
                    MSSV,
                    MSSV + ' - ' + FirstName + ' ' + LastName AS StudentDisplay
                FROM Student
                ORDER BY MSSV");

            DataTable table = student.getStudents(command);

            studentList.Clear();

            foreach (DataRow row in table.Rows)
            {
                studentList.Add(row["StudentDisplay"].ToString());
            }
        }

        // =======================
        // TEXTBOX MSSV - GỢI Ý
        // =======================
        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtMSSV.Text.Trim();

            if (keyword == "")
            {
                suggestionBox.Visible = false;
                suggestionBox.Items.Clear();
                return;
            }

            var filtered = studentList
            .Where(item =>
            {
                string mssvPart = item.Contains(" - ")
                    ? item.Substring(0, item.IndexOf(" - ")).Trim()
                    : item.Trim();
                return mssvPart.StartsWith(
                    keyword,
                    StringComparison.OrdinalIgnoreCase); // ← StartsWith thay vì IndexOf
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

        // =======================
        // CHỌN GỢI Ý
        // =======================

        private void txtMSSV_Leave(object sender, EventArgs e)
        {
            hideTimer.Start();
        }

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
        // LOAD HOMETOWN
        // =======================
        private void LoadHometown()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProvinceName");

            DataRow noneRow = table.NewRow();
            noneRow["ProvinceName"] = "-- Select Hometown --";
            table.Rows.Add(noneRow);

            string[] provinces =
            {
                "An Giang", "Ba Ria - Vung Tau", "Bac Giang", "Bac Kan",
                "Bac Lieu", "Bac Ninh", "Ben Tre", "Binh Duong",
                "Binh Dinh", "Binh Phuoc", "Binh Thuan", "Ca Mau",
                "Can Tho", "Cao Bang", "Da Nang", "Dak Lak",
                "Dak Nong", "Dien Bien", "Dong Nai", "Dong Thap",
                "Gia Lai", "Ha Giang", "Ha Nam", "Ha Noi",
                "Ha Tinh", "Hai Duong", "Hai Phong", "Hau Giang",
                "Hoa Binh", "Hung Yen", "Khanh Hoa", "Kien Giang",
                "Kon Tum", "Lai Chau", "Lam Dong", "Lang Son",
                "Lao Cai", "Long An", "Nam Dinh", "Nghe An",
                "Ninh Binh", "Ninh Thuan", "Phu Tho", "Phu Yen",
                "Quang Binh", "Quang Nam", "Quang Ngai", "Quang Ninh",
                "Quang Tri", "Soc Trang", "Son La", "Tay Ninh",
                "Thai Binh", "Thai Nguyen", "Thanh Hoa", "Thua Thien Hue",
                "Tien Giang", "Ho Chi Minh", "Tra Vinh", "Tuyen Quang",
                "Vinh Long", "Vinh Phuc", "Yen Bai"
            };

            foreach (string province in provinces)
            {
                DataRow row = table.NewRow();
                row["ProvinceName"] = province;
                table.Rows.Add(row);
            }

            cboHometown.DataSource = table;
            cboHometown.DisplayMember = "ProvinceName";
            cboHometown.ValueMember = "ProvinceName";
            cboHometown.SelectedIndex = 0;
        }

        // =======================
        // BUTTONS
        // =======================
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMSSV.Text = "";
            txtFname.Clear();
            txtLname.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            cboHometown.SelectedIndex = 0;
            txtEmail.Clear();
            cboGender.SelectedIndex = 0;
            picStudent.Image = null;
            studentImage = null;

            suggestionBox.Visible = false;
            suggestionBox.Items.Clear();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                studentImage = File.ReadAllBytes(ofd.FileName);

                MemoryStream ms = new MemoryStream(studentImage);
                picStudent.Image = Image.FromStream(ms);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            Student student = new Student();
            student.MSSV = txtMSSV.Text.Trim();
            student.Fname = txtFname.Text.Trim();
            student.Lname = txtLname.Text.Trim();
            student.Dob = dtpDob.Value.Date;
            student.Gender = cboGender.Text;
            student.Phone = txtPhone.Text.Trim();
            student.Address = txtAddress.Text.Trim();
            student.Hometown = cboHometown.Text;
            student.Email = txtEmail.Text.Trim();
            student.Picture = studentImage;

            bool result = student.AddStudent();

            if (result)
                MessageBox.Show("Add student successful!");
            else
                MessageBox.Show("Add student failed!");
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            f_AIAddStudent aiForm = new f_AIAddStudent();
            DialogResult result = aiForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtMSSV.Text = aiForm.MSSV;
                txtFname.Text = aiForm.Fname;
                txtLname.Text = aiForm.Lname;
                txtPhone.Text = aiForm.Phone;
                txtAddress.Text = aiForm.Address;
                cboHometown.Text = aiForm.Hometown;
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
            // ---- CHECK RỖNG ----
            if (ValidateData.IsEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Student ID cannot be empty!");
                txtMSSV.Focus();
                return false;
            }
            if (ValidateData.IsEmpty(txtFname.Text))
            {
                MessageBox.Show("First name cannot be empty!");
                txtFname.Focus();
                return false;
            }
            if (ValidateData.IsEmpty(txtLname.Text))
            {
                MessageBox.Show("Last name cannot be empty!");
                txtLname.Focus();
                return false;
            }
            if (ValidateData.IsEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone number cannot be empty!");
                txtPhone.Focus();
                return false;
            }
            if (ValidateData.IsEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address cannot be empty!");
                txtAddress.Focus();
                return false;
            }
            if (cboHometown.SelectedIndex == 0)
            {
                MessageBox.Show("Please select hometown!");
                cboHometown.Focus();
                return false;
            }
            if (ValidateData.IsEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email cannot be empty!");
                txtEmail.Focus();
                return false;
            }
            if (cboGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender!");
                cboGender.Focus();
                return false;
            }
            if (picStudent.Image == null)
            {
                MessageBox.Show("Please select a student image!");
                return false;
            }

            // ---- FORMAT CHECK ----
            if (!ValidateData.IsValidMSSV(txtMSSV.Text))
            {
                MessageBox.Show("Student ID can only contain letters and numbers!");
                txtMSSV.Focus();
                return false;
            }
            if (!ValidateData.IsValidName(txtFname.Text))
            {
                MessageBox.Show("First name cannot contain numbers!");
                txtFname.Focus();
                return false;
            }
            if (!ValidateData.IsValidName(txtLname.Text))
            {
                MessageBox.Show("Last name cannot contain numbers!");
                txtLname.Focus();
                return false;
            }
            if (!ValidateData.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone number must contain digits only!");
                txtPhone.Focus();
                return false;
            }
            if (!ValidateData.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email address!");
                txtEmail.Focus();
                return false;
            }

            // ---- LOGIC CHECK ----
            if (!ValidateData.IsValidBirthDay(dtpDob.Value))
            {
                MessageBox.Show("Invalid date of birth!");
                return false;
            }

            return true;
        }
    }
}