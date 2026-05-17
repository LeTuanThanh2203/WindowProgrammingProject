using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ValidationLibrary;

namespace LoginForm
{
    public partial class AddStudent : Form
    {
        // Biến toàn cục để chứa ảnh dạng byte[]
        byte[] studentImage = null;
        public AddStudent()
        {
            InitializeComponent();
        }
        private void StudentAdd_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

            cboGender.SelectedIndex = 0;

            picStudent.SizeMode =
                PictureBoxSizeMode.StretchImage;
        }
        private void btnQuit_Click(
    object sender,
    EventArgs e)
        {
            LoginForm login =
        new LoginForm();

            login.Show();

            this.Hide();
        }
        private void btnClear_Click(
    object sender,
    EventArgs e)
        {
            txtMSSV.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtHometown.Clear();
            txtEmail.Clear();

            cboGender.SelectedIndex = 0;

            picStudent.Image = null;
        }
        // =======================
        // CHOOSE IMAGE
        // =======================
        private void btnChooseImage_Click(
     object sender,
     EventArgs e)
        {
            OpenFileDialog ofd =
                new OpenFileDialog();

            ofd.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Đọc file thành byte[]
                studentImage =
                    File.ReadAllBytes(ofd.FileName);

                // Hiển thị ảnh
                MemoryStream ms =
                    new MemoryStream(studentImage);

                picStudent.Image =
                    Image.FromStream(ms);

                MessageBox.Show(
                    "Image loaded: "
                    + studentImage.Length);
            }
        }
        private void btnAdd_Click(
    object sender,
    EventArgs e)
        {
            ValidateInput();
            // Tạo đối tượng Student và gán giá trị
            Student student = new Student();
            student.MSSV = txtMSSV.Text.Trim();
            student.Fname = txtFname.Text.Trim();
            student.Lname = txtLname.Text.Trim();
            student.Dob = dtpDob.Value.Date;
            student.Gender = cboGender.Text;
            student.Phone = txtPhone.Text.Trim();
            student.Address = txtAddress.Text.Trim();
            student.Hometown = txtHometown.Text.Trim();
            student.Email = txtEmail.Text.Trim();
            // Gán ảnh byte[]
            student.Picture = studentImage;

            // Gọi method Add()
            bool result = student.AddStudent();
            MessageBox.Show(student.Picture.Length.ToString());

            if (result)
                MessageBox.Show("Add student successful!");
            else
                MessageBox.Show("Add student failed!");
        }


        //Validate input trước khi thêm sinh viên
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

            if (ValidateData.IsEmpty(txtHometown.Text))
            {
                MessageBox.Show("Hometown cannot be empty!");
                txtHometown.Focus();
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
