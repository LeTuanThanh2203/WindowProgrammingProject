using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginForm
{
    public partial class f_ForgetPass : Form
    {
        f_OTP otpManager = new f_OTP();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public f_ForgetPass()
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

            if (sec <= 0)
            {
                timer.Stop();

                lbl_Time.Text =
                    "OTP Expired!";
            }
        }
        private void f_ForgetPass_Load(
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
            string username =
                txt_UserName.Text.Trim();

            // Lấy email
            string email =
                otpManager.GetEmailByUsername(
                    username);

            // Không tồn tại username
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show(
                    "Username does not exist!");

                return;
            }

            // Hiển thị email đã mã hóa
            string maskedEmail =
                otpManager.MaskEmail(email);

            DialogResult result =
                MessageBox.Show(
                    "Send OTP to:\n"
                    + maskedEmail + " ?",
                    "Confirm",
                    MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                bool sent =
                    otpManager.SendOTP(username);

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
        private void cb_isShowPassword_CheckedChanged(
    object sender,
    EventArgs e)
        {
            bool show =
                cb_isShowPassword.Checked;

            txt_Password.UseSystemPasswordChar =
                !show;

            txt_ReenterPass.UseSystemPasswordChar =
                !show;
        }
        private void bt_ChangePassword_Click(
    object sender,
    EventArgs e)
        {
            // Check OTP
            bool verify =
                otpManager.VerifyOTP(
                    txt_OTP.Text.Trim()
                );

            if (!verify)
            {
                MessageBox.Show(
                    "OTP Wrong or Expired!");

                return;
            }

            // Check password match
            if (txt_Password.Text !=
                txt_ReenterPass.Text)
            {
                MessageBox.Show(
                    "Password Not Match!");

                return;
            }

            using (My_DB db = new My_DB())
            {
                SqlCommand command =
                    new SqlCommand(
                    @"UPDATE DataLoginForm
              SET Password=@pass
              WHERE UserName=@user",
                    db.getConnection
                );

                command.Parameters.Add(
                    "@pass",
                    SqlDbType.VarChar
                ).Value = txt_Password.Text;

                command.Parameters.Add(
                    "@user",
                    SqlDbType.VarChar
                ).Value =
                    txt_UserName.Text.Trim();

                db.openConnection();

                int result =
                    command.ExecuteNonQuery();

                db.closeConnection();

                if (result > 0)
                {
                    MessageBox.Show(
                        "Password Changed!");

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Change Failed!");
                }
            }
        }
        private void bt_Cancel_Click(
    object sender,
    EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }

}
