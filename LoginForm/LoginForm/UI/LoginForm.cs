using Microsoft.Win32;
using System.Configuration;
namespace LoginForm
{
    using Microsoft.Data.SqlClient;
    using ProjectMonHoc;
    using System.Data;

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cb_isShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_isShowPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = false; // hiện chữ
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;  // ẩn lại thành ****
            }
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {

            My_DB db = new My_DB();
            string query = @"
                SELECT *
                FROM DataLoginForm
                WHERE UserName = @user
                AND Password = @pass";

            SqlCommand command =
                new SqlCommand(query, db.getConnection);

            command.Parameters.Add("@user",
                SqlDbType.VarChar).Value =
                txt_UserName.Text.Trim();

            command.Parameters.Add("@pass",
                SqlDbType.VarChar).Value =
                txt_Password.Text.Trim();
            db.openConnection();
            SqlDataReader reader =
                command.ExecuteReader();

            // TÌM THẤY ACCOUNT
            if (reader.Read())
            {
                // LẤY ROLE
                string role =
                    reader["RoleName"].ToString();

                // LẤY TRẠNG THÁI DUYỆT
                bool isApproved =
                    Convert.ToBoolean(
                        reader["IsApproved"]);

                // CHECK ĐÃ DUYỆT CHƯA
                if (isApproved == false)
                {
                    MessageBox.Show(
                        "Account is waiting for approval!");

                    return;
                }

                MessageBox.Show(
                    "Login successful!");

                // PHÂN QUYỀN
                if (role == "Admin")
                {
                    Approve approveForm = new Approve();

                    approveForm.Show();
                }
                else if (role == "Manager")
                {
                    AddStudent addStudent = new AddStudent();

                    addStudent.Show();
                }
                else
                {
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Your account or password is wrong!",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txt_Password.Clear();
                txt_Password.Focus();
            }

            reader.Close();

            db.closeConnection();
        }
        
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linklbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
