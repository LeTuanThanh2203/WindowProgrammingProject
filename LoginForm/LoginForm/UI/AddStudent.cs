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
        public AddStudent()
        {
            InitializeComponent();
        }
        private void StudentAdd_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");

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

            // Gọi method Add()
            bool result = student.AddStudent();

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
                MessageBox.Show("MSSV không được để trống!");
                txtMSSV.Focus();
                return false;
            }

            if (ValidateData.IsEmpty(txtFname.Text))
            {
                MessageBox.Show("Họ và tên đệm không được để trống!");
                txtFname.Focus();
                return false;
            }

            if (ValidateData.IsEmpty(txtLname.Text))
            {
                MessageBox.Show("Tên không được để trống!");
                txtLname.Focus();
                return false;
            }

            if (ValidateData.IsEmpty(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                txtPhone.Focus();
                return false;
            }

            if (ValidateData.IsEmpty(txtAddress.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                txtAddress.Focus();
                return false;
            }

            if (ValidateData.IsEmpty(txtHometown.Text))
            {
                MessageBox.Show("Quê quán không được để trống!");
                txtHometown.Focus();
                return false;
            }

            if (ValidateData.IsEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống!");
                txtEmail.Focus();
                return false;
            }

            if (cboGender.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                cboGender.Focus();
                return false;
            }

            if (picStudent.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh sinh viên!");
                return false;
            }

            // ---- CHECK ĐỊNH DẠNG ----
            if (!ValidateData.IsValidMSSV(txtMSSV.Text))
            {
                MessageBox.Show("MSSV chỉ được chứa chữ và số!");
                txtMSSV.Focus();
                return false;
            }

            if (!ValidateData.IsValidName(txtFname.Text))
            {
                MessageBox.Show("Họ và tên đệm không được chứa số!");
                txtFname.Focus();
                return false;
            }

            if (!ValidateData.IsValidName(txtLname.Text))
            {
                MessageBox.Show("Tên không được chứa số!");
                txtLname.Focus();
                return false;
            }

            if (!ValidateData.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("SĐT chỉ được nhập số!");
                txtPhone.Focus();
                return false;
            }

            if (!ValidateData.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!");
                txtEmail.Focus();
                return false;
            }

            // ---- CHECK LOGIC ----
            if (!ValidateData.IsValidBirthDay(dtpDob.Value))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return false;
            }

            return true;
        }

    }
}
