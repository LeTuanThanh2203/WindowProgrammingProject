using Microsoft.Data.SqlClient;
using Project_Group6;
using Project_Group6.Models;
using Project_Group6.UI;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using ValidationLibrary;

namespace LoginForm
{
    public partial class f_Assign : Form
    {
        private HR hr = new HR();
        private Assign assign = new Assign();
        private PaginationHelper _pager;
        private DataTable dtAssign;

        // ── Add-mode state ───────────────────────────────────────────
        private bool _isAddMode = false;
        private bool _hrLoaded = false;

        // ── HR-ID suggestion box ─────────────────────────────────────
        private ListBox hrIdSuggestionBox = new ListBox();
        private System.Windows.Forms.Timer hideTimer = new System.Windows.Forms.Timer();
        private List<string> hrList = new List<string>();

        // ── Address autocomplete ─────────────────────────────────────
        private ListBox addressSuggestionBox = new ListBox();
        private System.Windows.Forms.Timer addressDebounceTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer addressHideTimer = new System.Windows.Forms.Timer();
        private static readonly HttpClient httpClient = new HttpClient();

        static f_Assign()
        {
            httpClient.DefaultRequestHeaders.Add(
                "User-Agent", "StudentManagementSystem/1.0 (winforms-app)");
        }

        public f_Assign()
        {
            InitializeComponent();
        }

        // ════════════════════════════════════════════════════════════
        // FORM LOAD
        // ════════════════════════════════════════════════════════════
        private void f_Assign_Load(object sender, EventArgs e)
        {
            _pager = new PaginationHelper(
                pageTable =>
                {
                    dgvAssign.DataSource = pageTable;
                    UIStyleHelper.StyleDataGridView(dgvAssign);
                },
                lblPageInfo, lblTotal,
                btnFirst, btnPrev, btnNext, btnLast,
                cboPageSize);

            cboHR_Gender.Items.Clear();
            cboHR_Gender.Items.Add("Male");
            cboHR_Gender.Items.Add("Female");
            if (cboHR_Gender.Items.Count > 0)
                cboHR_Gender.SelectedIndex = 0;

            dtpHR_Dob.MaxDate = DateTime.Today;

            LoadHRCombo();
            LoadCourseCombo();
            LoadData();

            cboHR.SelectedIndexChanged += cboHR_SelectedIndexChanged;

            // ── UX extensions ──
            LoadHRList();
            SetupHRIDSuggestionBox();
            SetupAddressSuggestionBox();
            SetupRealtimeValidation();
        }

        // ════════════════════════════════════════════════════════════
        // COMBO / DATA LOADERS
        // ════════════════════════════════════════════════════════════
        private void LoadHRCombo()
        {
            cboHR.DataSource = hr.GetHRsForCombo();
            cboHR.DisplayMember = "HRDisplay";
            cboHR.ValueMember = "ID";
        }

        private void LoadCourseCombo()
        {
            cboCourse.DataSource = assign.GetCoursesForCombo();
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseID";
        }

        private void LoadData()
        {
            try { _pager.SetData(assign.GetAssignList()); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /// <summary>Populates hrList used by the HR-ID suggestion box.</summary>
        private void LoadHRList()
        {
            hrList.Clear();
            DataTable table = hr.GetAllHRs();
            foreach (DataRow row in table.Rows)
                hrList.Add($"{row["ID"]} - {row["FirstName"]} {row["LastName"]}");
        }

        // ════════════════════════════════════════════════════════════
        // COMBO → LOAD FIELDS
        // ════════════════════════════════════════════════════════════
        private void cboHR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHR.SelectedValue == null) return;
            if (cboHR.SelectedValue is DataRowView || cboHR.SelectedIndex < 0) return;
            LoadHRToFields(cboHR.SelectedValue.ToString());
        }

        private void LoadHRToFields(string id)
        {
            if (string.IsNullOrEmpty(id)) return;
            HR selectedHr = hr.GetHRByID(id);
            if (selectedHr == null) return;

            _hrLoaded = true;
            ExitAddMode();

            txtHR_ID.Text = selectedHr.ID;
            txtHR_ID.Enabled = false;

            txtHR_FirstName.Text = selectedHr.FirstName;
            txtHR_LastName.Text = selectedHr.LastName;
            dtpHR_Dob.Value = selectedHr.Dob == DateTime.MinValue ? DateTime.Today : selectedHr.Dob;

            if (!string.IsNullOrEmpty(selectedHr.Gender) && cboHR_Gender.Items.Contains(selectedHr.Gender))
                cboHR_Gender.SelectedItem = selectedHr.Gender;
            else
                cboHR_Gender.SelectedIndex = -1;

            txtHR_Phone.Text = selectedHr.Phone;
            txtHR_Email.Text = selectedHr.Email;

            // Set bằng code (dữ liệu đã có sẵn từ DB) -> không kích hoạt
            // việc gọi API gợi ý địa chỉ. Chỉ khi user tự gõ mới check.
            txtHR_Address.TextChanged -= txtAddress_TextChanged;
            txtHR_Address.Text = selectedHr.Address;
            txtHR_Address.TextChanged += txtAddress_TextChanged;
            addressSuggestionBox.Visible = false;
            addressSuggestionBox.Items.Clear();

            if (selectedHr.Picture != null && selectedHr.Picture.Length > 0)
            {
                try
                {
                    using var ms = new MemoryStream(selectedHr.Picture);
                    picHR_Photo.Image = Image.FromStream(ms);
                }
                catch { picHR_Photo.Image = null; }
            }
            else
            {
                picHR_Photo.Image = null;
            }

            ClearValidationLabels();
        }

        private byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            try
            {
                using var ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            catch { return null; }
        }

        // ════════════════════════════════════════════════════════════
        // ADD MODE  (toggle Add ↔ Save)
        // ════════════════════════════════════════════════════════════
        private void btnHR_Add_Click(object sender, EventArgs e)
        {
            if (!_isAddMode)
            {
                btnHR_Clear_Click(null, null);
                _isAddMode = true;

                txtHR_ID.Enabled = true;
                txtHR_ID.Focus();

                btnHR_Add.Text = "💾  Save";
                btnHR_Add.BackColor = Color.FromArgb(33, 115, 70);
            }
            else
            {
                SaveNewHR();
            }
        }

        private void SaveNewHR()
        {
            string id = txtHR_ID.Text.Trim();
            string fname = txtHR_FirstName.Text.Trim();
            string lname = txtHR_LastName.Text.Trim();
            string phone = txtHR_Phone.Text.Trim();
            string email = txtHR_Email.Text.Trim();
            string address = txtHR_Address.Text.Trim();
            string gender = cboHR_Gender.SelectedItem?.ToString() ?? "Male";
            DateTime dob = dtpHR_Dob.Value.Date;

            // ── Validation ──
            if (string.IsNullOrEmpty(id))
            { MessageBox.Show("Please enter the HR ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_ID.Focus(); return; }

            if (!ValidateData.IsValidMSSV(id))
            { MessageBox.Show("HR ID must contain letters and numbers only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_ID.Focus(); return; }

            if (string.IsNullOrEmpty(fname))
            { MessageBox.Show("Please enter the First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_FirstName.Focus(); return; }

            if (!ValidateData.IsValidName(fname))
            { MessageBox.Show("First Name must not contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_FirstName.Focus(); return; }

            if (string.IsNullOrEmpty(lname))
            { MessageBox.Show("Please enter the Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_LastName.Focus(); return; }

            if (!ValidateData.IsValidName(lname))
            { MessageBox.Show("Last Name must not contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_LastName.Focus(); return; }

            if (string.IsNullOrEmpty(phone))
            { MessageBox.Show("Please enter the phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_Phone.Focus(); return; }

            if (!ValidateData.IsValidPhone(phone))
            { MessageBox.Show("Phone number must contain digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_Phone.Focus(); return; }

            if (string.IsNullOrEmpty(email))
            { MessageBox.Show("Please enter the email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_Email.Focus(); return; }

            if (!ValidateData.IsValidEmail(email))
            { MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_Email.Focus(); return; }

            if (string.IsNullOrEmpty(address))
            { MessageBox.Show("Please enter the address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_Address.Focus(); return; }

            if (!ValidateData.IsValidBirthDay(dob))
            { MessageBox.Show("Invalid date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (hr.GetHRByID(id) != null)
            { MessageBox.Show("An HR with this ID already exists in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); txtHR_ID.Focus(); return; }

            byte[] photoBytes = ImageToByteArray(picHR_Photo.Image);
            HR newHr = new HR(id, fname, lname, dob, gender, phone, email, address, photoBytes);

            if (newHr.AddHR())
            {
                bool accountCreated = CreateHRAccount(id, email);

                if (accountCreated)
                {
                    MessageBox.Show(
                        "HR added and login account created successfully!\nLogin credentials have been sent to: " + email,
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "HR added successfully, but login account creation failed.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ExitAddMode();
                LoadHRList();
                LoadHRCombo();
                cboHR.SelectedValue = id;
            }
            else
            {
                MessageBox.Show("Failed to add HR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitAddMode()
        {
            _isAddMode = false;
            btnHR_Add.Text = "Add";
            btnHR_Add.BackColor = Color.FromArgb(10, 61, 120);
        }

        // ════════════════════════════════════════════════════════════
        // CREATE LOGIN ACCOUNT FOR HR
        // ════════════════════════════════════════════════════════════
        private bool CreateHRAccount(string id, string email)
        {
            try
            {
                string randomPassword = GenerateRandomPassword(10);
                string hashedPassword = PasswordHasher.HashPassword(randomPassword);

                using var db = new My_DB();
                db.openConnection();

                var checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM DataLoginForm WHERE UserName = @user", db.getConnection);
                checkCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = id;
                if ((int)checkCmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("A login account with this ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                var insertCmd = new SqlCommand(@"
                    INSERT INTO DataLoginForm
                        (UserName, Password, Email, RoleName, IsApproved, IsLocked, LoginAttempts)
                    VALUES
                        (@user, @pass, @mail, @role, 1, 0, 0)",
                    db.getConnection);
                insertCmd.Parameters.Add("@user", SqlDbType.VarChar).Value = id;
                insertCmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = hashedPassword;
                insertCmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
                insertCmd.Parameters.Add("@role", SqlDbType.VarChar).Value = "HR";
                insertCmd.ExecuteNonQuery();

                OTP mailer = new OTP();
                string subject = "Your HR Account Information";
                string body = $@"
Hello,

Your HR account has been created successfully.

Username : {id}
Password : {randomPassword}

Please log in and change your password immediately.

Regards,
Academic Management System";

                return mailer.SendEmail(email, subject, body);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating HR account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private string GenerateRandomPassword(int length)
        {
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string special = "!@#$%^&*";
            const string all = upper + lower + digits + special;

            var rng = new Random();
            char[] pwd = new char[length];
            pwd[0] = upper[rng.Next(upper.Length)];
            pwd[1] = lower[rng.Next(lower.Length)];
            pwd[2] = digits[rng.Next(digits.Length)];
            pwd[3] = special[rng.Next(special.Length)];
            for (int i = 4; i < length; i++)
                pwd[i] = all[rng.Next(all.Length)];

            return new string(pwd.OrderBy(_ => rng.Next()).ToArray());
        }

        // ════════════════════════════════════════════════════════════
        // HR-ID SUGGESTION BOX
        // ════════════════════════════════════════════════════════════
        private void SetupHRIDSuggestionBox()
        {
            hrIdSuggestionBox.Visible = false;
            hrIdSuggestionBox.Size = new Size(txtHR_ID.Width, 120);
            hrIdSuggestionBox.Font = new Font("Segoe UI", 9.5F);
            hrIdSuggestionBox.Location = new Point(txtHR_ID.Left, txtHR_ID.Bottom + 1);
            hrIdSuggestionBox.BorderStyle = BorderStyle.FixedSingle;
            hrIdSuggestionBox.BackColor = Color.White;

            pnlHR.Controls.Add(hrIdSuggestionBox);
            hrIdSuggestionBox.BringToFront();

            txtHR_ID.TextChanged += txtHRID_TextChanged;
            txtHR_ID.Leave += txtHRID_Leave;
            hrIdSuggestionBox.Click += (s, e) => SelectHRIDSuggestion();
            hrIdSuggestionBox.KeyDown += hrIdSuggestionBox_KeyDown;

            hideTimer.Interval = 200;
            hideTimer.Tick += HideTimer_Tick;
        }

        private void txtHRID_TextChanged(object sender, EventArgs e)
        {
            // Only show suggestions in Add mode and when no HR has been loaded yet
            if (!_isAddMode || _hrLoaded)
            {
                hrIdSuggestionBox.Visible = false;
                return;
            }

            string keyword = txtHR_ID.Text.Trim();
            hrIdSuggestionBox.Items.Clear();

            if (string.IsNullOrEmpty(keyword)) { hrIdSuggestionBox.Visible = false; return; }

            var filtered = hrList.Where(item =>
            {
                string idPart = item.Contains(" - ") ? item[..item.IndexOf(" - ")].Trim() : item.Trim();
                return idPart.StartsWith(keyword, StringComparison.OrdinalIgnoreCase);
            }).ToList();

            if (filtered.Count == 0) { hrIdSuggestionBox.Visible = false; return; }

            foreach (var item in filtered)
                hrIdSuggestionBox.Items.Add(item);

            hrIdSuggestionBox.Visible = true;
            hrIdSuggestionBox.BringToFront();
        }

        private void txtHRID_Leave(object sender, EventArgs e) => hideTimer.Start();

        private void HideTimer_Tick(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!hrIdSuggestionBox.Focused)
            { hrIdSuggestionBox.Visible = false; hrIdSuggestionBox.Items.Clear(); }
        }

        private void hrIdSuggestionBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SelectHRIDSuggestion(); e.Handled = true; }
            else if (e.KeyCode == Keys.Escape) { hrIdSuggestionBox.Visible = false; txtHR_ID.Focus(); e.Handled = true; }
        }

        /// <summary>
        /// Người dùng CLICK CHỌN trực tiếp một HR ID có sẵn trong danh sách gợi ý.
        /// Đây là hành động xác nhận "tôi muốn làm việc với HR đã tồn tại", nên phải
        /// tự động load dữ liệu HR đó vào form (LoadHRToFields sẽ tự thoát Add-mode,
        /// disable ô ID...). Nếu người dùng KHÔNG chọn từ list mà chỉ tự gõ tiếp,
        /// flow này không được gọi -> vẫn giữ nguyên Add-mode (nút vẫn là "Save"
        /// cho việc tạo HR mới) như yêu cầu.
        /// </summary>
        private void SelectHRIDSuggestion()
        {
            if (hrIdSuggestionBox.SelectedItem == null) return;
            string selected = hrIdSuggestionBox.SelectedItem.ToString();
            string id = selected.Contains(" - ")
                ? selected[..selected.IndexOf(" - ")].Trim()
                : selected.Trim();

            txtHR_ID.TextChanged -= txtHRID_TextChanged;
            txtHR_ID.Text = id;
            txtHR_ID.TextChanged += txtHRID_TextChanged;

            hrIdSuggestionBox.Visible = false;
            hrIdSuggestionBox.Items.Clear();

            // Chọn từ list = chọn HR đã tồn tại -> tự chuyển khỏi Add-mode và
            // load toàn bộ thông tin HR đó lên form.
            LoadHRToFields(id);

            txtHR_ID.Focus();
            txtHR_ID.SelectionStart = txtHR_ID.Text.Length;
        }

        // ════════════════════════════════════════════════════════════
        // ADDRESS AUTOCOMPLETE  (Nominatim / Vietnam)
        // ════════════════════════════════════════════════════════════
        private void SetupAddressSuggestionBox()
        {
            addressSuggestionBox.Visible = false;
            addressSuggestionBox.Size = new Size(txtHR_Address.Width, 150);
            addressSuggestionBox.Font = new Font("Segoe UI", 9.5F);
            addressSuggestionBox.Location = new Point(txtHR_Address.Left, txtHR_Address.Bottom + 1);
            addressSuggestionBox.BorderStyle = BorderStyle.FixedSingle;
            addressSuggestionBox.BackColor = Color.White;

            pnlHR.Controls.Add(addressSuggestionBox);
            addressSuggestionBox.BringToFront();

            txtHR_Address.TextChanged += txtAddress_TextChanged;
            txtHR_Address.Leave += txtAddress_Leave;
            txtHR_Address.KeyDown += txtAddress_KeyDown;
            addressSuggestionBox.Click += (s, e) => SelectAddressSuggestion();
            addressSuggestionBox.KeyDown += addressSuggestionBox_KeyDown;

            addressDebounceTimer.Interval = 500;
            addressDebounceTimer.Tick += AddressDebounceTimer_Tick;

            addressHideTimer.Interval = 200;
            addressHideTimer.Tick += AddressHideTimer_Tick;
        }

        // Chỉ chạy khi NGƯỜI DÙNG TỰ GÕ vào ô Address. Mọi nơi set Text bằng code
        // (LoadHRToFields khi load dữ liệu có sẵn, btnHR_Clear_Click khi xóa form)
        // đều unsubscribe/resubscribe quanh việc set Text, nên sẽ KHÔNG rơi vào đây
        // -> không gọi API gợi ý khi dữ liệu đã có sẵn, đúng yêu cầu.
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            addressDebounceTimer.Stop();
            addressDebounceTimer.Start();
        }

        private void txtAddress_Leave(object sender, EventArgs e) => addressHideTimer.Start();

        private void AddressHideTimer_Tick(object sender, EventArgs e)
        {
            addressHideTimer.Stop();
            if (!addressSuggestionBox.Focused && !txtHR_Address.Focused)
                addressSuggestionBox.Visible = false;
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && addressSuggestionBox.Visible && addressSuggestionBox.Items.Count > 0)
            {
                addressSuggestionBox.Focus();
                addressSuggestionBox.SelectedIndex = 0;
                e.Handled = true;
            }
        }

        private void addressSuggestionBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { SelectAddressSuggestion(); e.Handled = true; }
            else if (e.KeyCode == Keys.Escape) { addressSuggestionBox.Visible = false; txtHR_Address.Focus(); e.Handled = true; }
        }

        private void SelectAddressSuggestion()
        {
            if (addressSuggestionBox.SelectedItem == null) return;
            txtHR_Address.TextChanged -= txtAddress_TextChanged;
            txtHR_Address.Text = addressSuggestionBox.SelectedItem.ToString();
            txtHR_Address.TextChanged += txtAddress_TextChanged;
            addressSuggestionBox.Visible = false;
            txtHR_Address.Focus();
            txtHR_Address.SelectionStart = txtHR_Address.Text.Length;
        }

        private async void AddressDebounceTimer_Tick(object sender, EventArgs e)
        {
            addressDebounceTimer.Stop();
            string keyword = txtHR_Address.Text.Trim();
            if (keyword.Length < 3) { addressSuggestionBox.Visible = false; addressSuggestionBox.Items.Clear(); return; }

            try
            {
                string url = $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(keyword)}&format=json&limit=5&countrycodes=vn";
                var response = await httpClient.GetAsync(url);
                if (!response.IsSuccessStatusCode) return;

                string json = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement;

                addressSuggestionBox.Items.Clear();
                if (root.ValueKind == JsonValueKind.Array && root.GetArrayLength() > 0)
                {
                    foreach (var item in root.EnumerateArray())
                        if (item.TryGetProperty("display_name", out var prop))
                            addressSuggestionBox.Items.Add(prop.GetString());

                    addressSuggestionBox.Visible = true;
                    addressSuggestionBox.BringToFront();
                }
                else
                {
                    addressSuggestionBox.Visible = false;
                }
            }
            catch { /* fail silently — no network should not interrupt the user */ }
        }

        // ════════════════════════════════════════════════════════════
        // REAL-TIME VALIDATION
        // ════════════════════════════════════════════════════════════
        private void SetupRealtimeValidation()
        {
            txtHR_FirstName.TextChanged += (s, e) => ValidateField(
                txtHR_FirstName.Text.Trim(), lblValidateFirstName,
                v => string.IsNullOrEmpty(v) ? "First name is required"
                   : !ValidateData.IsValidName(v) ? "First name cannot contain numbers"
                   : null);

            txtHR_LastName.TextChanged += (s, e) => ValidateField(
                txtHR_LastName.Text.Trim(), lblValidateLastName,
                v => string.IsNullOrEmpty(v) ? "Last name is required"
                   : !ValidateData.IsValidName(v) ? "Last name cannot contain numbers"
                   : null);

            txtHR_Phone.TextChanged += (s, e) => ValidateField(
                txtHR_Phone.Text.Trim(), lblValidatePhone,
                v => string.IsNullOrEmpty(v) ? "Phone is required"
                   : !ValidateData.IsValidPhone(v) ? "Phone must contain digits only"
                   : null);

            txtHR_Email.TextChanged += (s, e) => ValidateField(
                txtHR_Email.Text.Trim(), lblValidateEmail,
                v => string.IsNullOrEmpty(v) ? "Email is required"
                   : !ValidateData.IsValidEmail(v) ? "Invalid email address"
                   : null);
        }

        private void ValidateField(string value, Label lbl, Func<string, string> getError)
        {
            string error = getError(value);
            if (error == null)
            {
                lbl.Text = "✓ Valid";
                lbl.ForeColor = Color.FromArgb(33, 115, 70);
            }
            else
            {
                lbl.Text = error;
                lbl.ForeColor = Color.FromArgb(200, 40, 40);
            }
        }

        private void ClearValidationLabels()
        {
            foreach (var lbl in new[] { lblValidateFirstName, lblValidateLastName, lblValidatePhone, lblValidateEmail })
            {
                lbl.Text = "";
                lbl.ForeColor = Color.Transparent;
            }
        }

        // ════════════════════════════════════════════════════════════
        // EDIT HR
        // ════════════════════════════════════════════════════════════
        private void btnHR_Edit_Click(object sender, EventArgs e)
        {
            string id = txtHR_ID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            { MessageBox.Show("Please select or enter the HR ID to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string fname = txtHR_FirstName.Text.Trim();
            string lname = txtHR_LastName.Text.Trim();
            string phone = txtHR_Phone.Text.Trim();
            string email = txtHR_Email.Text.Trim();
            string address = txtHR_Address.Text.Trim();
            string gender = cboHR_Gender.SelectedItem?.ToString() ?? "";
            DateTime dob = dtpHR_Dob.Value.Date;

            if (string.IsNullOrEmpty(fname))
            { MessageBox.Show("Please enter the First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_FirstName.Focus(); return; }
            if (string.IsNullOrEmpty(lname))
            { MessageBox.Show("Please enter the Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtHR_LastName.Focus(); return; }

            HR existingHr = hr.GetHRByID(id);
            if (existingHr == null)
            { MessageBox.Show("No HR found with this ID to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            byte[] photoBytes = picHR_Photo.Image != null ? ImageToByteArray(picHR_Photo.Image) : existingHr.Picture;
            HR updatedHr = new HR(id, fname, lname, dob, gender, phone, email, address, photoBytes);

            if (updatedHr.EditHR())
            {
                MessageBox.Show("HR updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHRList();
                LoadHRCombo();
                LoadHRToFields(id);
            }
            else
            {
                MessageBox.Show("Failed to update HR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ════════════════════════════════════════════════════════════
        // DELETE HR
        // ════════════════════════════════════════════════════════════
        private void btnHR_Delete_Click(object sender, EventArgs e)
        {
            string id = txtHR_ID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            { MessageBox.Show("Please select or enter the HR ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (hr.GetHRByID(id) == null)
            { MessageBox.Show("No HR found with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete HR with ID: {id}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (HR.DeleteHR(id))
                {
                    MessageBox.Show("HR deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHRList();
                    LoadHRCombo();
                    btnHR_Clear_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to delete HR (the HR may currently be assigned to a course).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ════════════════════════════════════════════════════════════
        // CLEAR
        // ════════════════════════════════════════════════════════════
        private void btnHR_Clear_Click(object sender, EventArgs e)
        {
            _hrLoaded = false;
            ExitAddMode();

            txtHR_ID.Text = "";
            txtHR_ID.Enabled = true;
            txtHR_FirstName.Text = "";
            txtHR_LastName.Text = "";
            dtpHR_Dob.Value = DateTime.Today;
            if (cboHR_Gender.Items.Count > 0) cboHR_Gender.SelectedIndex = 0;
            txtHR_Phone.Text = "";
            txtHR_Email.Text = "";

            // Set bằng code -> không kích hoạt gọi API gợi ý address
            txtHR_Address.TextChanged -= txtAddress_TextChanged;
            txtHR_Address.Text = "";
            txtHR_Address.TextChanged += txtAddress_TextChanged;

            picHR_Photo.Image = null;

            ClearValidationLabels();

            hrIdSuggestionBox.Visible = false;
            hrIdSuggestionBox.Items.Clear();
            addressSuggestionBox.Visible = false;
            addressSuggestionBox.Items.Clear();
        }

        // ════════════════════════════════════════════════════════════
        // UPLOAD PHOTO
        // ════════════════════════════════════════════════════════════
        private void btnHR_Upload_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp" };
            if (ofd.ShowDialog() == DialogResult.OK)
                picHR_Photo.Image = Image.FromFile(ofd.FileName);
        }

        // ════════════════════════════════════════════════════════════
        // ASSIGN / DELETE ASSIGNMENT
        // ════════════════════════════════════════════════════════════
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cboHR.SelectedValue == null) { MessageBox.Show("Please select a valid HR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); cboHR.Focus(); return; }
            if (cboCourse.SelectedValue == null) { MessageBox.Show("Please select a valid course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); cboCourse.Focus(); return; }

            string hrid = cboHR.SelectedValue.ToString();
            string courseid = cboCourse.SelectedValue.ToString();

            if (assign.CountAssignedCourses(hrid) >= 5) { MessageBox.Show("This HR has already reached the maximum of 5 assigned courses.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (assign.IsAssigned(hrid, courseid)) { MessageBox.Show("This course has already been assigned to the selected HR.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (assign.InsertAssign(hrid, courseid))
            { MessageBox.Show("Course assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadData(); }
            else
            { MessageBox.Show("Failed to assign course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAssign.CurrentRow == null) { MessageBox.Show("Please select an assignment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string hrid = dgvAssign.CurrentRow.Cells["ID"].Value.ToString();
            string courseid = dgvAssign.CurrentRow.Cells["CourseID"].Value.ToString();

            if (assign.DeleteAssign(hrid, courseid))
            { MessageBox.Show("Assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadData(); }
            else
            { MessageBox.Show("Failed to delete assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // ════════════════════════════════════════════════════════════
        // SEARCH BARS (toolbar)
        // ════════════════════════════════════════════════════════════
        private void txtSearchHR_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchHR.Text.Trim();
            if (string.IsNullOrEmpty(keyword)) { LoadHRCombo(); return; }
            cboHR.DataSource = assign.SearchHRForCombo(keyword);
            cboHR.DisplayMember = "HRDisplay";
            cboHR.ValueMember = "ID";
        }

        private void txtSearchCourse_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchCourse.Text.Trim();
            if (string.IsNullOrEmpty(keyword)) { LoadCourseCombo(); return; }
            cboCourse.DataSource = assign.SearchCourseForCombo(keyword);
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseID";
        }

        // ════════════════════════════════════════════════════════════
        // GRID CLICK → LOAD FIELDS
        // ════════════════════════════════════════════════════════════
        private void dgvAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssign.CurrentRow == null) return;
            try
            {
                if (dgvAssign.CurrentRow.Cells["ID"].Value != null)
                {
                    string hrId = dgvAssign.CurrentRow.Cells["ID"].Value.ToString();
                    LoadHRToFields(hrId);
                    cboHR.SelectedValue = hrId;
                }
            }
            catch { }
        }
    }
}