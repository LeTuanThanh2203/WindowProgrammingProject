using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;   // Dùng để gọi hàm WinAPI cho việc di chuyển form không có border
using System.Text;
using System.Windows.Forms;
namespace LoginForm
{

    using Microsoft.Data.SqlClient;
    using Project_Group6;
    using ProjectMonHoc;
    using System.Data;
    using System.Timers;

    public partial class f_RegisterForm : Form
    {

        [DllImport("user32.DLL")]       // Dùng để gọi hàm WinAPI cho việc di chuyển form không có border
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        OTP otpManager = new OTP();         // Tạo instance của lớp OTP để quản lý việc tạo và gửi mã OTP
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public f_RegisterForm()
        {
            InitializeComponent();
        }
        private void Timer_Tick(
    object sender,
    EventArgs e)
        {
            int sec =
                otpManager.GetRemainingSeconds();

            lbl_Time.Text =
                "Time Left: " + sec + "s";
            timer.Start();

            if (sec <= 0)
            {
                timer.Stop();

                lbl_Time.Text =
                    "OTP Expired!";
            }
        }
        private void f_Register_Load(
    object sender,
    EventArgs e)
        {
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;
        }
        private void bt_OTP_Click(
    object sender,
    EventArgs e)
        {
            // Lấy email
            string email =
                    txt_Email.Text.Trim();

            // Chưa nhập email
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show(
                    "Please enter your email!");

                return;
            }


            DialogResult result =
                MessageBox.Show(
                    "Send OTP to:\n"
                    + email + " ?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                bool sent =
                    otpManager.SendOTP(email);

                if (sent)
                {
                    MessageBox.Show(
                        "OTP Sent!");

                    timer.Start();
                }
                else
                {
                    MessageBox.Show(
                        "Send Failed!");
                }
            }
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
                string hashedPassword =
                    PasswordHasher.HashPassword(password);
                string email = txt_Email.Text.Trim();

                // 1. Check rỗng
                if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please enter username, if (string.IsNullOrWhiteSpace(username) ||\r\n    string.IsNullOrWhiteSpace(password) ||\r\n    string.IsNullOrWhiteSpace(email)) and email!");
                    return;
                }

                // 2. Check username tồn tại
                string checkQuery = "SELECT COUNT(*) FROM DataLoginForm WHERE UserName = @user";

                db.openConnection();

                SqlCommand checkCmd = new SqlCommand(checkQuery, db.getConnection);
                checkCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists!");
                    db.closeConnection(); // thiếu
                    return;
                }

                // 3. Insert
                string insertQuery = @"INSERT INTO DataLoginForm 
                               (UserName, Password, Email) 
                               VALUES (@user, @pass, @mail)";

                SqlCommand cmd = new SqlCommand(insertQuery, db.getConnection);

                cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPassword;
                cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                db.closeConnection();

                MessageBox.Show("Register successful!");

                // 4. Clear
                txt_UserName.Clear();
                txt_Password.Clear();
                txt_Email.Clear();

                // 5. Chuyển form
                f_LoginForm login = new f_LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            f_LoginForm login = new f_LoginForm();
            login.Show();
            this.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}

