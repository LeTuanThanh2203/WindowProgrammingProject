using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LoginForm
{
    using Microsoft.Data.SqlClient;
    using Project_Group6;
    using ProjectMonHoc;
    using System.Data;

    public partial class f_RegisterForm : Form
    {
        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        OTP otpManager = new OTP();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private byte[] userImage = null;

        private static readonly DateTime DefaultDob = new DateTime(2000, 1, 1);
        private const string DefaultPhone = "";
        private const string DefaultAddress = "";

        // Regex dùng chung cho validation tên
        // Cho phép: chữ cái Unicode (kể cả tiếng Việt có dấu), khoảng trắng, dấu gạch ngang, dấu nháy đơn
        private static readonly Regex NameRegex = new Regex(@"^[\p{L}\s'\-]+$", RegexOptions.Compiled);

        public f_RegisterForm()
        {
            InitializeComponent();
        }

        // ── Form Load ─────────────────────────────────────────────────────────
        private void f_Register_Load(object sender, EventArgs e)
        {
            // Timer
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            // Wire validation — Account
            txt_UserName.TextChanged += txt_UserName_TextChanged;
            txt_Email.TextChanged += txt_Email_TextChanged;
            txt_Password.TextChanged += txt_Password_TextChanged;

            // Wire validation — Profile (THÊM MỚI)
            txt_FirstName.TextChanged += txt_FirstName_TextChanged;
            txt_LastName.TextChanged += txt_LastName_TextChanged;

            // Role
            cbo_Role.Items.Clear();
            cbo_Role.Items.Add("Student");
            cbo_Role.Items.Add("HR");
            cbo_Role.SelectedIndex = 0;
            cbo_Role.SelectedIndexChanged += cbo_Role_SelectedIndexChanged;

            // Gender
            cbo_Gender.Items.Clear();
            cbo_Gender.Items.Add("Male");
            cbo_Gender.Items.Add("Female");
            cbo_Gender.Items.Add("Other");
            cbo_Gender.SelectedIndex = 0;

            // Rounded step circles via Paint
            MakeRoundPanel(pnStep1);
            MakeRoundPanel(pnStep2);
            MakeRoundPanel(pnStep3);

            // OTP button starts disabled
            bt_OTP.Enabled = false;

            // Focus border highlight
            WireInputFocus(txt_UserName);
            WireInputFocus(txt_Password);
            WireInputFocus(txt_Email);
            WireInputFocus(txt_OTP);
            WireInputFocus(txt_FirstName);
            WireInputFocus(txt_LastName);
        }

        // ── Rounded panel helper ──────────────────────────────────────────────
        private void MakeRoundPanel(Panel p)
        {
            p.Paint += (s, ev) =>
            {
                ev.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using var path = RoundedRect(new Rectangle(0, 0, p.Width - 1, p.Height - 1), p.Width / 2);
                ev.Graphics.FillPath(new SolidBrush(p.BackColor), path);
            };
            p.Region = RoundedRegion(p.Size, p.Width / 2);
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Region RoundedRegion(Size size, int radius)
        {
            var path = RoundedRect(new Rectangle(Point.Empty, size), radius);
            return new Region(path);
        }

        // ── Focus border highlight ────────────────────────────────────────────
        private void WireInputFocus(TextBox tb)
        {
            tb.Enter += (s, e) => tb.BackColor = Color.FromArgb(240, 246, 255);
            tb.Leave += (s, e) => tb.BackColor = Color.White;
        }

        // ── Validation helpers ────────────────────────────────────────────────
        private void SetCheck(Label lbl, TextBox tb, bool ok, string msg)
        {
            lbl.Text = msg;
            lbl.ForeColor = ok ? Color.FromArgb(59, 109, 17) : Color.FromArgb(192, 57, 43);
            tb.BackColor = ok
                ? Color.FromArgb(248, 253, 244)
                : (msg == "" ? Color.White : Color.FromArgb(253, 248, 248));
        }

        // ── Username validation ───────────────────────────────────────────────
        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();
            if (username == "")
            {
                SetCheck(lbl_CheckUsername, txt_UserName, false, "Username is required");
                return;
            }

            using (My_DB db = new My_DB())
            {
                string query = "SELECT COUNT(*) FROM DataLoginForm WHERE UserName=@user";
                var cmd = new SqlCommand(query, db.getConnection);
                cmd.Parameters.AddWithValue("@user", username);
                db.openConnection();
                int count = (int)cmd.ExecuteScalar();
                db.closeConnection();
                if (count > 0)
                {
                    SetCheck(lbl_CheckUsername, txt_UserName, false, "Username already exists");
                    return;
                }
            }

            string desiredRole = cbo_Role.Text;
            string checkIdQuery = desiredRole == "HR"
                ? "SELECT COUNT(*) FROM HR WHERE ID=@id"
                : "SELECT COUNT(*) FROM Student WHERE ID=@id";

            using (My_DB db = new My_DB())
            {
                var cmd = new SqlCommand(checkIdQuery, db.getConnection);
                cmd.Parameters.AddWithValue("@id", username);
                db.openConnection();
                int count = (int)cmd.ExecuteScalar();
                db.closeConnection();
                if (count > 0)
                    SetCheck(lbl_CheckUsername, txt_UserName, false, $"ID already registered as a {desiredRole}");
                else
                    SetCheck(lbl_CheckUsername, txt_UserName, true, "✓  Available");
            }
        }

        private void cbo_Role_SelectedIndexChanged(object sender, EventArgs e)
            => txt_UserName_TextChanged(txt_UserName, EventArgs.Empty);

        // ── Email validation ──────────────────────────────────────────────────
        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (email == "")
            {
                SetCheck(lbl_CheckEmail, txt_Email, false, "Email is required");
                bt_OTP.Enabled = false;
                return;
            }

            bool valid = Regex.IsMatch(email, pattern);
            SetCheck(lbl_CheckEmail, txt_Email,
                valid,
                valid ? "✓  Valid email" : "Invalid email format");

            // Chỉ bật nút OTP khi email hợp lệ
            bt_OTP.Enabled = valid;
            bt_OTP.BackColor = valid
                ? Color.FromArgb(0, 68, 147)
                : Color.FromArgb(180, 196, 212);
        }

        // ── Password validation + strength bar ───────────────────────────────
        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            string password = txt_Password.Text;

            if (password.Length == 0)
            {
                SetCheck(lbl_CheckPassword, txt_Password, false, "");
                UpdateStrengthBar(0);
                return;
            }

            if (password.Length < 8)
            {
                SetCheck(lbl_CheckPassword, txt_Password, false, "At least 8 characters");
                UpdateStrengthBar(1);
                return;
            }

            bool hasUpper = Regex.IsMatch(password, @"[A-Z]");
            bool hasLower = Regex.IsMatch(password, @"[a-z]");
            bool hasNumber = Regex.IsMatch(password, @"[0-9]");
            bool hasSpecial = Regex.IsMatch(password, @"[\W_]");
            int score = (hasUpper ? 1 : 0) + (hasLower ? 1 : 0)
                      + (hasNumber ? 1 : 0) + (hasSpecial ? 1 : 0);

            UpdateStrengthBar(score);

            if (score == 4)
                SetCheck(lbl_CheckPassword, txt_Password, true, "✓  Strong password");
            else
                SetCheck(lbl_CheckPassword, txt_Password, false, "Weak — add uppercase, number & symbol");
        }

        private void UpdateStrengthBar(int score)
        {
            int barWidth = (int)(pnStrengthBar.Width * score / 4.0);
            Color barColor = score switch
            {
                1 => Color.FromArgb(192, 57, 43),   // đỏ   – yếu
                2 => Color.FromArgb(211, 84, 0),    // cam  – trung bình
                3 => Color.FromArgb(243, 156, 18),  // vàng – khá
                4 => Color.FromArgb(59, 109, 17),   // xanh – mạnh
                _ => Color.Transparent
            };
            pnStrengthFill.Width = barWidth;
            pnStrengthFill.BackColor = barColor;
        }

        // ── First Name validation ─────────────────────────────────────────────
        private void txt_FirstName_TextChanged(object sender, EventArgs e)
            => ValidateName(txt_FirstName, lbl_CheckFirstName, "First name");

        // ── Last Name validation ──────────────────────────────────────────────
        private void txt_LastName_TextChanged(object sender, EventArgs e)
            => ValidateName(txt_LastName, lbl_CheckLastName, "Last name");

        // ── Name validation helper (dùng chung cho First & Last Name) ─────────
        private void ValidateName(TextBox tb, Label lbl, string fieldName)
        {
            string value = tb.Text.Trim();

            // 1. Bắt buộc nhập
            if (value == "")
            {
                SetCheck(lbl, tb, false, $"{fieldName} is required");
                return;
            }

            // 2. Tối thiểu 2 ký tự
            if (value.Length < 2)
            {
                SetCheck(lbl, tb, false, "At least 2 characters");
                return;
            }

            // 3. Tối đa 50 ký tự
            if (value.Length > 50)
            {
                SetCheck(lbl, tb, false, "Maximum 50 characters");
                return;
            }

            // 4. Chỉ cho phép chữ cái, khoảng trắng, dấu gạch ngang, dấu nháy đơn
            //    (hỗ trợ tiếng Việt có dấu, tên như O'Brien, Mary-Jane)
            if (!NameRegex.IsMatch(value))
            {
                SetCheck(lbl, tb, false, "No numbers or special characters");
                return;
            }

            // 5. Không cho phép khoảng trắng liên tiếp
            if (Regex.IsMatch(value, @"\s{2,}"))
            {
                SetCheck(lbl, tb, false, "No consecutive spaces");
                return;
            }

            // 6. Không cho phép bắt đầu hoặc kết thúc bằng khoảng trắng / dấu đặc biệt
            if (value.StartsWith("-") || value.StartsWith("'") ||
                value.EndsWith("-") || value.EndsWith("'"))
            {
                SetCheck(lbl, tb, false, "Cannot start or end with - or '");
                return;
            }

            SetCheck(lbl, tb, true, "✓  Valid");
        }

        // ── Timer tick ───────────────────────────────────────────────────────
        private void Timer_Tick(object sender, EventArgs e)
        {
            int sec = otpManager.GetRemainingSeconds();
            if (sec <= 0)
            {
                timer.Stop();
                lbl_Time.Text = "⚠  OTP expired";
                lbl_Time.ForeColor = Color.FromArgb(192, 57, 43);
            }
            else
            {
                lbl_Time.Text = $"⏱  Time remaining: {sec}s";
                lbl_Time.ForeColor = sec <= 15
                    ? Color.FromArgb(192, 57, 43)
                    : Color.FromArgb(120, 128, 140);
            }
        }

        // ── Choose image ─────────────────────────────────────────────────────
        private void btn_ChooseImage_Click(object sender, EventArgs e)
        {
            using var opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Image.Image = Image.FromFile(opf.FileName);
                using var ms = new System.IO.MemoryStream();
                pic_Image.Image.Save(ms, pic_Image.Image.RawFormat);
                userImage = ms.ToArray();
            }
        }

        // ── Send OTP ─────────────────────────────────────────────────────────
        private void bt_OTP_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Send OTP to:\n{email}?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool sent = otpManager.SendOTP(email);
                if (sent)
                {
                    MessageBox.Show("OTP sent!", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer.Start();
                    bt_OTP.Text = "Resend";
                    bt_OTP.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed to send OTP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── Show / Hide password ──────────────────────────────────────────────
        private void cb_isShowPassword_CheckedChanged(object sender, EventArgs e)
            => txt_Password.UseSystemPasswordChar = !cb_isShowPassword.Checked;

        // ── Register ─────────────────────────────────────────────────────────
        private void bt_Register_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();
            string password = txt_Password.Text.Trim();
            string email = txt_Email.Text.Trim();
            string userOTP = txt_OTP.Text.Trim();
            string id = username;
            string fname = txt_FirstName.Text.Trim();
            string lname = txt_LastName.Text.Trim();
            string gender = cbo_Gender.Text;
            string desiredRole = cbo_Role.Text;
            DateTime dob = DefaultDob;
            string phone = DefaultPhone;
            string address = DefaultAddress;

            // 1. Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(fname) ||
                string.IsNullOrWhiteSpace(lname))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra định dạng email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra định dạng First Name & Last Name
            if (!IsValidName(fname))
            {
                MessageBox.Show(
                    "First name is invalid.\nOnly letters, spaces, hyphens and apostrophes are allowed (2–50 characters).",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_FirstName.Focus();
                return;
            }

            if (!IsValidName(lname))
            {
                MessageBox.Show(
                    "Last name is invalid.\nOnly letters, spaces, hyphens and apostrophes are allowed (2–50 characters).",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_LastName.Focus();
                return;
            }

            using (My_DB db = new My_DB())
            {
                db.openConnection();

                // 4. Kiểm tra username chưa tồn tại
                using (var checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM DataLoginForm WHERE UserName=@user", db.getConnection))
                {
                    checkCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Username already exists.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        db.closeConnection(); return;
                    }
                }

                // 5. Kiểm tra ID chưa tồn tại trong bảng vai trò
                string checkIdSql = desiredRole == "Student"
                    ? "SELECT COUNT(*) FROM Student WHERE ID=@id"
                    : "SELECT COUNT(*) FROM HR WHERE ID=@id";
                using (var checkIdCmd = new SqlCommand(checkIdSql, db.getConnection))
                {
                    checkIdCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                    if ((int)checkIdCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show($"ID '{id}' is already registered as a {desiredRole}.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        db.closeConnection(); return;
                    }
                }

                db.closeConnection();
            }

            // 6. Kiểm tra OTP
            if (!otpManager.VerifyOTP(userOTP))
            {
                MessageBox.Show("Invalid or expired OTP.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 7. Lưu profile
            bool profileInserted = false;
            if (desiredRole == "Student")
            {
                var student = new Student
                {
                    ID = id,
                    FirstName = fname,
                    LastName = lname,
                    Dob = dob,
                    Gender = gender,
                    Phone = phone,
                    Email = email,
                    Address = address,
                    Picture = userImage
                };
                profileInserted = student.AddStudent();
            }
            else
            {
                var hr = new HR
                {
                    ID = id,
                    FirstName = fname,
                    LastName = lname,
                    Dob = dob,
                    Gender = gender,
                    Phone = phone,
                    Email = email,
                    Address = address,
                    Picture = userImage
                };
                profileInserted = hr.AddHR();
            }

            if (!profileInserted)
            {
                MessageBox.Show("Failed to save profile. Registration aborted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 8. Lưu tài khoản đăng nhập
            string hashedPw = PasswordHasher.HashPassword(password);
            using (My_DB db = new My_DB())
            {
                db.openConnection();
                string insertSql = @"INSERT INTO DataLoginForm
                    (UserName, Password, Email, RoleName, IsApproved, IsLocked, LoginAttempts)
                    VALUES (@user, @pass, @mail, @role, 0, 0, 0)";

                using (var cmd = new SqlCommand(insertSql, db.getConnection))
                {
                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPw;
                    cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@role", SqlDbType.VarChar).Value = desiredRole;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                            "Registration successful!\nYour account is pending approval by an Administrator.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        new f_LoginForm().Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Account registration failed: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Rollback profile
                        try
                        {
                            string delSql = desiredRole == "Student"
                                ? "DELETE FROM Student WHERE ID=@id"
                                : "DELETE FROM HR WHERE ID=@id";
                            using var delCmd = new SqlCommand(delSql, db.getConnection);
                            delCmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                            delCmd.ExecuteNonQuery();
                        }
                        catch { }
                    }
                }
                db.closeConnection();
            }
        }

        private void ClearForm()
        {
            txt_UserName.Clear();
            txt_Password.Clear();
            txt_Email.Clear();
            txt_OTP.Clear();
            txt_FirstName.Clear();
            txt_LastName.Clear();
            cbo_Gender.SelectedIndex = 0;
            pic_Image.Image = null;
            userImage = null;
            pnStrengthFill.Width = 0;
            lbl_CheckUsername.Text = "";
            lbl_CheckPassword.Text = "";
            lbl_CheckEmail.Text = "";
            lbl_CheckFirstName.Text = "";  // THÊM MỚI
            lbl_CheckLastName.Text = "";  // THÊM MỚI
            lbl_Time.Text = "";
            bt_OTP.Text = "⊳  Send OTP";
        }

        // ── Helpers ───────────────────────────────────────────────────────────
        private bool IsValidEmail(string email)
            => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        /// <summary>
        /// Kiểm tra tên hợp lệ:
        ///   - 2–50 ký tự
        ///   - Chỉ chữ cái Unicode, khoảng trắng, dấu gạch ngang, dấu nháy đơn
        ///   - Không có 2 khoảng trắng liên tiếp
        ///   - Không bắt đầu/kết thúc bằng - hoặc '
        /// </summary>
        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            string v = name.Trim();
            if (v.Length < 2 || v.Length > 50) return false;
            if (!NameRegex.IsMatch(v)) return false;
            if (Regex.IsMatch(v, @"\s{2,}")) return false;
            if (v.StartsWith("-") || v.StartsWith("'")) return false;
            if (v.EndsWith("-") || v.EndsWith("'")) return false;
            return true;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            new f_LoginForm().Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}