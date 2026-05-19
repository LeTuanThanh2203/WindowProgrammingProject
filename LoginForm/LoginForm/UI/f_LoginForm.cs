using Microsoft.Win32;
using System.Configuration;
namespace LoginForm
{
    using Microsoft.Data.SqlClient;
    using Microsoft.VisualBasic.ApplicationServices;
    using Project_Group6;
    using ProjectMonHoc;
    using System.Data;

    public partial class f_LoginForm : Form
    {
        public f_LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(
        object sender,
        EventArgs e)
        {
            txt_UserName.Text =
                Project_Group6.Properties
                .Settings.Default.Username;
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
            if (txt_UserName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter username!");

                txt_UserName.Focus();

                return;
            }

            if (txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password!");

                txt_Password.Focus();

                return;
            }
            using (My_DB db = new My_DB())
            {

                string username = txt_UserName.Text.Trim();
                string password = txt_Password.Text.Trim();

                string query = @"
            SELECT *
            FROM DataLoginForm
            WHERE UserName = @user";

                SqlCommand command =
                    new SqlCommand(query, db.getConnection);

                command.Parameters.Add("@user",
                    SqlDbType.VarChar).Value = username;

                db.openConnection();

                SqlDataReader reader =
                    command.ExecuteReader();

                // TÌM USER
                if (reader.Read())
                {
                    bool isLocked = false;

                    if (reader["IsLocked"] != DBNull.Value)
                    {
                        isLocked =
                            Convert.ToBoolean(reader["IsLocked"]);
                    }

                    int attempts = 0;

                    if (reader["LoginAttempts"] != DBNull.Value)
                    {
                        attempts =
                            Convert.ToInt32(reader["LoginAttempts"]);
                    }

                    bool isApproved = false;

                    if (reader["IsApproved"] != DBNull.Value)
                    {
                        isApproved =
                            Convert.ToBoolean(reader["IsApproved"]);
                    }

                    // CHECK KHÓA
                    if (isLocked)
                    {
                        MessageBox.Show(
                            "Account has been locked!");

                        reader.Close();
                        db.closeConnection();
                        return;
                    }

                    string dbPassword =
                        reader["Password"].ToString();

                    // PASSWORD ĐÚNG
                    if (dbPassword == password)
                    {
                        string role =
                            reader["RoleName"].ToString();

                        // LƯU THÔNG TIN NGƯỜI DÙNG VÀO SESSION
                        int userId =
                        Convert.ToInt32(reader["ID"]);

                        Globals.SetSession(
                        userId,
                        username,
                        role);

                        // RESET SỐ LẦN SAI
                        reader.Close();

                        SqlCommand resetCmd =
                            new SqlCommand(
                                @"UPDATE DataLoginForm
                SET LoginAttempts = 0
                WHERE UserName = @user",
                                db.getConnection);

                        resetCmd.Parameters.AddWithValue(
                            "@user", username);

                        resetCmd.ExecuteNonQuery();

                        // CHECK DUYỆT
                        if (isApproved == false)
                        {
                            MessageBox.Show(
                                "Account is waiting for approval!");
                            return;
                        }
                        f_Main mainForm =
                        new f_Main();

                        mainForm.Show();

                        this.Hide();

                        //// PHÂN QUYỀN
                        //if (role == "Admin")
                        //{
                        //    //f_Approve approveForm =
                        //    //    new f_Approve();

                        //    //approveForm.Show();
                        //    f_Main mainForm = new f_Main();

                        //}
                        //else if (role == "Manager")
                        //{

                        //    f_ListStudent manageStudent = new f_ListStudent();
                        //    manageStudent.Show();
                        //}
                        //else if (role == "User")
                        //{

                        //}

                        //this.Hide();
                    }
                    else
                    {
                        reader.Close();

                        attempts++;

                        // KHÓA NẾU >= 3
                        if (attempts >= 3)
                        {
                            SqlCommand lockCmd =
                                new SqlCommand(
                                    @"UPDATE DataLoginForm
                SET LoginAttempts = @attempts,
                    IsLocked = 1
                WHERE UserName = @user",
                                    db.getConnection);

                            lockCmd.Parameters.AddWithValue(
                                "@attempts", attempts);

                            lockCmd.Parameters.AddWithValue(
                                "@user", username);

                            lockCmd.ExecuteNonQuery();

                            MessageBox.Show(
                                "Account has been locked!");
                        }
                        else
                        {
                            SqlCommand updateCmd =
                                new SqlCommand(
                                    @"UPDATE DataLoginForm
                SET LoginAttempts = @attempts
                WHERE UserName = @user",
                                    db.getConnection);

                            updateCmd.Parameters.AddWithValue(
                                "@attempts", attempts);

                            updateCmd.Parameters.AddWithValue(
                                "@user", username);

                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show(
                                $"Wrong password! Attempt {attempts}/3");
                        }

                        txt_Password.Clear();
                        txt_Password.Focus();
                    }

                    // NHỚ TÀI KHOẢN
                    if (cb_RememberMe.Checked)
                    {
                        Project_Group6.Properties
                            .Settings.Default.Username =
                            txt_UserName.Text;

                        Project_Group6.Properties
                            .Settings.Default.Save();
                    }
                    else
                    {
                        Project_Group6.Properties
                            .Settings.Default.Username = "";

                        Project_Group6.Properties
                            .Settings.Default.Save();
                    }


                }
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linklbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_RegisterForm registerForm = new f_RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f_ForgetPass forgetPass = new f_ForgetPass();
            forgetPass.Show();
            this.Hide();
        }
    }
}
