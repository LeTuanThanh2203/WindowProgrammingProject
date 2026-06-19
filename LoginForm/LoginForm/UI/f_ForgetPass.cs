using Microsoft.Data.SqlClient;
using Project_Group6;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_ForgetPass : Form
    {
        OTP otpManager = new OTP();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
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

                // [BUG5] Re-enable nút OTP khi timer hết
                bt_OTP.Enabled = true;
            }
        }
        private void f_ForgetPass_Load(
    object sender,
    EventArgs e)
        {
            timer.Interval = 1000;

            timer.Tick += Timer_Tick;

            txt_UserName.TextChanged +=
                txt_UserName_TextChanged;

            txt_Password.TextChanged +=
                txt_Password_TextChanged;

            txt_ReenterPass.TextChanged +=
                txt_ReenterPass_TextChanged;

            // [BUG4] Dispose timer khi form đóng
            this.FormClosing += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();
            };
        }
        private void txt_UserName_TextChanged(
    object sender,
    EventArgs e)
        {
            string username =
                txt_UserName.Text.Trim();

            // EMPTY
            if (username == "")
            {
                lbl_CheckUsername.Text =
                    "Username is required";

                lbl_CheckUsername.ForeColor =
                    Color.Red;

                return;
            }

            using (My_DB db = new My_DB())
            {
                string query =
                    "SELECT COUNT(*) FROM DataLoginForm WHERE UserName=@user";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@user",
                    username);

                db.openConnection();

                int count =
                    (int)cmd.ExecuteScalar();

                db.closeConnection();

                if (count > 0)
                {
                    lbl_CheckUsername.Text =
                        "Username found";

                    lbl_CheckUsername.ForeColor =
                        Color.Green;
                }
                else
                {
                    lbl_CheckUsername.Text =
                        "Username does not exist";

                    lbl_CheckUsername.ForeColor =
                        Color.Red;
                }
            }
        }
        private void txt_Password_TextChanged(
    object sender,
    EventArgs e)
        {
            string password =
                txt_Password.Text;

            if (password.Length < 8)
            {
                lbl_CheckPassword.Text =
                    "At least 8 characters";

                lbl_CheckPassword.ForeColor =
                    Color.Red;

                return;
            }

            bool hasUpper =
                Regex.IsMatch(password, @"[A-Z]");

            bool hasLower =
                Regex.IsMatch(password, @"[a-z]");

            bool hasNumber =
                Regex.IsMatch(password, @"[0-9]");

            bool hasSpecial =
                Regex.IsMatch(password,
                @"[\W_]");

            if (hasUpper &&
                hasLower &&
                hasNumber &&
                hasSpecial)
            {
                lbl_CheckPassword.Text =
                    "Strong password";

                lbl_CheckPassword.ForeColor =
                    Color.Green;
            }
            else
            {
                lbl_CheckPassword.Text =
                    "Weak password";

                lbl_CheckPassword.ForeColor =
                    Color.Orange;
            }

            // Also re-validate confirm password
            if (txt_ReenterPass.Text.Length > 0)
            {
                txt_ReenterPass_TextChanged(
                    txt_ReenterPass, EventArgs.Empty);
            }
        }
        private void txt_ReenterPass_TextChanged(
    object sender,
    EventArgs e)
        {
            string reenter =
                txt_ReenterPass.Text;

            if (reenter == "")
            {
                lbl_CheckReenterPass.Text =
                    "Please confirm password";

                lbl_CheckReenterPass.ForeColor =
                    Color.Red;

                return;
            }

            if (reenter == txt_Password.Text)
            {
                lbl_CheckReenterPass.Text =
                    "Passwords match";

                lbl_CheckReenterPass.ForeColor =
                    Color.Green;
            }
            else
            {
                lbl_CheckReenterPass.Text =
                    "Passwords do not match";

                lbl_CheckReenterPass.ForeColor =
                    Color.Red;
            }
        }
        private void bt_OTP_Click(
    object sender,
    EventArgs e)
        {
            // Lấy email
            string email =
                otpManager.GetEmailByUsername(
                    txt_UserName.Text.Trim());

            // Không tồn tại username
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show(
                    "Username does not exist!");

                return;
            }

            // [BUG5] Disable ngay để chống spam bấm nhiều lần
            bt_OTP.Enabled = false;

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
                    otpManager.SendOTP(email);

                if (sent)
                {
                    MessageBox.Show(
                        "OTP Sent!");

                    timer.Start();
                    // bt_OTP giữ disable, sẽ enable lại khi timer hết (Timer_Tick)
                }
                else
                {
                    MessageBox.Show(
                        "Send Failed!");

                    // [BUG5] Gửi thất bại -> enable lại để user thử lại
                    bt_OTP.Enabled = true;
                }
            }
            else
            {
                // [BUG5] User chọn No -> enable lại
                bt_OTP.Enabled = true;
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
            // Reset các label thông báo lỗi về trạng thái rỗng trước khi kiểm tra
            lbl_CheckUsername.Text = "";
            lbl_CheckPassword.Text = "";
            lbl_CheckReenterPass.Text = "";

            bool isValid = true;

            // 1. Check username
            string username = txt_UserName.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                lbl_CheckUsername.Text = "Username is required";
                lbl_CheckUsername.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                // Check username tồn tại trong DB
                using (My_DB checkDb = new My_DB())
                {
                    string checkQuery = "SELECT COUNT(*) FROM DataLoginForm WHERE UserName=@user";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, checkDb.getConnection);
                    checkCmd.Parameters.AddWithValue("@user", username);

                    checkDb.openConnection();
                    int userCount = (int)checkCmd.ExecuteScalar();
                    checkDb.closeConnection();

                    if (userCount == 0)
                    {
                        lbl_CheckUsername.Text = "Username does not exist";
                        lbl_CheckUsername.ForeColor = Color.Red;
                        isValid = false;
                    }
                }
            }

            // 2. Check password
            string password = txt_Password.Text;
            if (password.Length == 0)
            {
                lbl_CheckPassword.Text = "Password is required";
                lbl_CheckPassword.ForeColor = Color.Red;
                isValid = false;
            }
            else if (password.Length < 8)
            {
                lbl_CheckPassword.Text = "At least 8 characters";
                lbl_CheckPassword.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                // Check độ mạnh yếu
                bool hasUpper = Regex.IsMatch(password, @"[A-Z]");
                bool hasLower = Regex.IsMatch(password, @"[a-z]");
                bool hasNumber = Regex.IsMatch(password, @"[0-9]");
                bool hasSpecial = Regex.IsMatch(password, @"[\W_]");

                if (!(hasUpper && hasLower && hasNumber && hasSpecial))
                {
                    lbl_CheckPassword.Text = "Weak password";
                    lbl_CheckPassword.ForeColor = Color.Orange;
                    // Vẫn cho phép nếu chỉ là cảnh báo, hoặc coi là invalid tùy quy chuẩn. Ở đây coi như invalid để bắt buộc mật khẩu mạnh.
                    isValid = false;
                }
            }

            // 3. Check Re-enter Password
            string reenterPass = txt_ReenterPass.Text;
            if (reenterPass == "")
            {
                lbl_CheckReenterPass.Text = "Please confirm password";
                lbl_CheckReenterPass.ForeColor = Color.Red;
                isValid = false;
            }
            else if (password != reenterPass)
            {
                lbl_CheckReenterPass.Text = "Passwords do not match";
                lbl_CheckReenterPass.ForeColor = Color.Red;
                isValid = false;
            }

            // Nếu thông tin nhập vào (User/Pass/Re-pass) không hợp lệ thì dừng lại
            if (!isValid)
            {
                return;
            }

            // 4. Check OTP rỗng
            string otpText = txt_OTP.Text.Trim();
            if (string.IsNullOrWhiteSpace(otpText))
            {
                MessageBox.Show("Vui lòng nhập OTP!");
                return;
            }

            // 5. Verify OTP
            bool verify = otpManager.VerifyOTP(otpText);
            if (!verify)
            {
                MessageBox.Show("OTP Wrong or Expired!");
                return;
            }

            // --- Thực hiện đổi mật khẩu ---
            using (My_DB db = new My_DB())
            {
                string hashedPassword = PasswordHasher.HashPassword(password);
                SqlCommand command = new SqlCommand(
                    @"UPDATE DataLoginForm
                      SET Password=@pass
                      WHERE UserName=@user",
                    db.getConnection
                );

                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPassword;
                command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;

                db.openConnection();
                int result = command.ExecuteNonQuery();
                db.closeConnection();

                if (result > 0)
                {
                    MessageBox.Show("Password Changed successfully!");
                    f_LoginForm login = new f_LoginForm();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Change Failed!");
                }
            }
        }
        private void bt_Cancel_Click(
    object sender,
    EventArgs e)
        {
            // [BUG4] Stop timer trước khi đóng form
            timer.Stop();

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
