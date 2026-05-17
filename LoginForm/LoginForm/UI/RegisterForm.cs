using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace LoginForm
{

    using Microsoft.Data.SqlClient;
    using ProjectMonHoc;
    using System.Data;
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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
        private void bt_Register_Click(object sender, EventArgs e)
{
    using (My_DB db = new My_DB())
    {
        string username = txt_UserName.Text.Trim();
        string password = txt_Password.Text.Trim();

        // 1. Check rỗng
        if (username == "" || password == "")
        {
            MessageBox.Show("Please enter username and password!");
            return;
        }

        // 2. Check username tồn tại
        string checkQuery = "SELECT COUNT(*) FROM DataLoginForm WHERE UserName = @user";
        SqlCommand checkCmd = new SqlCommand(checkQuery, db.getConnection);
        checkCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;

        db.openConnection();

        int count = (int)checkCmd.ExecuteScalar();

        if (count > 0)
        {
            MessageBox.Show("Username already exists!");
            return;
        }

        // 3. Insert
        string insertQuery = "INSERT INTO DataLoginForm (UserName, Password) VALUES (@user, @pass)";
        SqlCommand cmd = new SqlCommand(insertQuery, db.getConnection);

        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;

        cmd.ExecuteNonQuery();

        MessageBox.Show("Register successful!");

        LoginForm login = new LoginForm();
        login.Show();
        this.Close();


        // 4. Clear
        txt_UserName.Clear();
        txt_Password.Clear();
        txt_Email.Clear(); // có thể xóa dòng này nếu bỏ luôn textbox
    }
}
    
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}

