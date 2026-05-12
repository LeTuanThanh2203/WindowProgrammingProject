using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
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
            // VALIDATE MSSV
            if (!ValidateData.IsNumber(
                txtMSSV.Text))
            {
                MessageBox.Show(
                    "MSSV must be number!");

                return;
            }

            // VALIDATE EMAIL
            if (!ValidateData.IsValidEmail(
                txtEmail.Text))
            {
                MessageBox.Show(
                    "Invalid email format!");

                return;
            }

            // VALIDATE DATE
            if (!ValidateData.IsValidBirthDay(
                dtpDob.Value))
            {
                MessageBox.Show(
                    "Date of birth is invalid!");

                return;
            }

            string connStr =
            @"Data Source=.\SQLEXPRESS;
    Initial Catalog=DataUser;
    Integrated Security=True;
    TrustServerCertificate=True";

            using (SqlConnection conn =
                new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
        INSERT INTO Student
        (
            MSSV,
            FirstName,
            LastName,
            Dob,
            Gender,
            Phone,
            Address,
            HomeTown,
            Email
        )
        VALUES
        (
            @mssv,
            @fname,
            @lname,
            @dob,
            @gender,
            @phone,
            @address,
            @hometown,
            @email
        )";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                cmd.Parameters.Add("@mssv",
                    SqlDbType.VarChar).Value =
                    txtMSSV.Text.Trim();

                cmd.Parameters.Add("@fname",
                    SqlDbType.NVarChar).Value =
                    txtFname.Text.Trim();

                cmd.Parameters.Add("@lname",
                    SqlDbType.NVarChar).Value =
                    txtLname.Text.Trim();

                cmd.Parameters.Add("@dob",
                    SqlDbType.Date).Value =
                    dtpDob.Value.Date;

                cmd.Parameters.Add("@gender",
                    SqlDbType.NVarChar).Value =
                    cboGender.Text;

                cmd.Parameters.Add("@phone",
                    SqlDbType.VarChar).Value =
                    txtPhone.Text.Trim();

                cmd.Parameters.Add("@address",
                    SqlDbType.NVarChar).Value =
                    txtAddress.Text.Trim();

                cmd.Parameters.Add("@hometown",
                    SqlDbType.NVarChar).Value =
                    txtHometown.Text.Trim();

                cmd.Parameters.Add("@email",
                    SqlDbType.VarChar).Value =
                    txtEmail.Text.Trim();

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Add student successful!");
            }
        }
    }
}
