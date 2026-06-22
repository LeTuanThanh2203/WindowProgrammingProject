using LoginForm;
using Project_Group6.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Regex = System.Text.RegularExpressions.Regex;
using RegexOptions = System.Text.RegularExpressions.RegexOptions;

namespace LoginForm
{
    public partial class f_ContactManage : Form
    {
        private Contact contact = new Contact();
        private Group group = new Group();
        private PaginationHelper _pager;

        // Regex dùng chung cho validate tên: chữ cái Unicode (có dấu), khoảng trắng, gạch ngang, nháy đơn
        private static readonly Regex NameRegex = new Regex(@"^[\p{L}\s'\-]+$", RegexOptions.Compiled);

        // Regex dùng cho validate số điện thoại: chỉ chữ số, cho phép dấu + ở đầu, khoảng trắng, dấu gạch ngang/chấm để ngăn cách
        private static readonly Regex PhoneRegex = new Regex(@"^\+?[0-9][0-9\s\-\.]{7,14}$", RegexOptions.Compiled);

        public f_ContactManage()
        {
            InitializeComponent();

            this.Load += f_ContactManage_Load;
            dgvContacts.CellClick += dgvContacts_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // Wire Delete button (btnViewScore có text "Delete" trong designer)
            btnDelete.Click += btnDelete_Click;

            // Wire validate real-time cho First Name / Last Name / Phone
            txtFname.TextChanged += txtFname_TextChanged;
            txtLname.TextChanged += txtLname_TextChanged;
            txtPhone.TextChanged += txtPhone_TextChanged;
        }

        // ================= LOAD FORM =================

        private void f_ContactManage_Load(object sender, EventArgs e)
        {
            _pager = new PaginationHelper(
                pageTable =>
                {
                    dgvContacts.DataSource = pageTable;
                    UIStyleHelper.StyleDataGridView(dgvContacts);
                    // Ẩn cột kỹ thuật / dữ liệu nhị phân
                    HideColumns("Picture", "Dob", "Group_ID");
                },
                lblPageInfo, lblTotal,
                btnFirst, btnPrev, btnNext, btnLast,
                cboPageSize);

            LoadGroups();
            LoadData();
            InitGenderCombo();
        }

        // ================= LOAD DATA =================

        private void LoadData()
        {
            try
            {
                _pager.ResetPage();
                _pager.SetData(contact.GetContacts());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideColumns(params string[] names)
        {
            foreach (var n in names)
                if (dgvContacts.Columns.Contains(n))
                    dgvContacts.Columns[n].Visible = false;
        }

        // ================= INIT COMBOS =================

        private void InitGenderCombo()
        {
            cboGender.Items.Clear();
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.SelectedIndex = 0;
        }

        // ================= LOAD GROUPS =================

        private void LoadGroups()
        {
            cboGroup.SelectedIndexChanged -= cboGroup_SelectedIndexChanged;
            cboContactGroup.SelectedIndexChanged -= cboContactGroup_SelectedIndexChanged;

            DataTable dt = group.GetGroups();

            // ---------------------------------------------------------------
            // ROOT-CAUSE FIX: dùng BindingSource RIÊNG BIỆT cho từng ComboBox.
            // Nếu cả hai ComboBox dùng chung DataTable (dù là .Copy()),
            // WinForms BindingContext của Form có thể chia sẻ CurrencyManager
            // → khi set SelectedIndex trên cboGroup, nó kéo cboContactGroup
            //   về cùng index → cboContactGroup.SelectedValue luôn trả về
            //   group đầu tiên ("Công việc") bất kể user chọn gì.
            // BindingSource tạo ra CurrencyManager hoàn toàn độc lập.
            // ---------------------------------------------------------------

            // === cboContactGroup: lưu selection CŨ TRƯỚC khi đụng vào cboGroup ===
            object prevSelected = cboContactGroup.SelectedValue;

            // === cboGroup (filter toolbar): thêm "(All Groups)" ở đầu ===
            DataTable dtFilter = dt.Copy();
            DataRow allRow = dtFilter.NewRow();
            allRow["ID"]   = -1;
            allRow["Name"] = "(All Groups)";
            dtFilter.Rows.InsertAt(allRow, 0);

            var bsGroup = new System.Windows.Forms.BindingSource { DataSource = dtFilter };
            cboGroup.DataSource    = bsGroup;
            cboGroup.DisplayMember = "Name";
            cboGroup.ValueMember   = "ID";
            cboGroup.SelectedIndex = 0;  // "(All Groups)"

            // === cboContactGroup (form input): BindingSource độc lập ===
            DataTable dt2 = dt.Copy();
            var bsContact = new System.Windows.Forms.BindingSource { DataSource = dt2 };
            cboContactGroup.DataSource    = bsContact;
            cboContactGroup.DisplayMember = "Name";
            cboContactGroup.ValueMember   = "ID";

            // Khôi phục selection cũ (ví dụ: sau khi thêm nhóm mới)
            if (prevSelected != null)
                cboContactGroup.SelectedValue = prevSelected;

            cboGroup.SelectedIndexChanged      += cboGroup_SelectedIndexChanged;
            cboContactGroup.SelectedIndexChanged += cboContactGroup_SelectedIndexChanged;
        }

        // ================= FILTER BY GROUP =================

        private void cboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroup.SelectedValue == null) return;
            txtSearch.Clear();

            int gid = Convert.ToInt32(cboGroup.SelectedValue);
            if (gid == -1)
                _pager.SetData(contact.GetContacts());        // "(All Groups)" → load all
            else
                _pager.SetData(contact.GetContactsByGroup(gid));
        }

        // cboContactGroup (combo trong form nhập) - không filter grid
        private void cboContactGroup_SelectedIndexChanged(object sender, EventArgs e) { }

        // ================= SEARCH =================

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(kw)) { LoadData(); return; }
            _pager.SetData(contact.SearchContacts(kw));
        }

        // ================= REAL-TIME VALIDATION (First/Last Name & Phone) =====

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            if (txtFname.Text.Trim() == "") { lblValidateFirstName.Text = ""; return; }
            ValidateNameField(txtFname, lblValidateFirstName, "First name");
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            if (txtLname.Text.Trim() == "") { lblValidateLastName.Text = ""; return; }
            ValidateNameField(txtLname, lblValidateLastName, "Last name");
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim() == "") { lblValidatePhone.Text = ""; return; }
            ValidatePhoneField(txtPhone, lblValidatePhone);
        }

        /// <summary>
        /// Hiển thị kết quả check ngay dưới ô nhập, giống style SetCheck của f_ForgetPass /
        /// f_RegisterForm: đỏ khi lỗi, xanh + dấu ✓ khi hợp lệ.
        /// </summary>
        private void SetCheck(Label lbl, bool ok, string msg)
        {
            lbl.Text = msg;
            lbl.ForeColor = ok ? Color.FromArgb(59, 109, 17) : Color.Red;
        }

        /// <summary>
        /// Validate tên: bắt buộc nhập, 2-50 ký tự, chỉ chữ cái (có dấu)/khoảng trắng/-/',
        /// không có khoảng trắng liên tiếp, không bắt đầu/kết thúc bằng - hoặc '.
        /// </summary>
        private bool ValidateNameField(TextBox tb, Label lbl, string fieldName)
        {
            string value = tb.Text.Trim();

            if (value == "")
            {
                SetCheck(lbl, false, $"{fieldName} is required.");
                return false;
            }
            if (value.Length < 2)
            {
                SetCheck(lbl, false, "At least 2 characters.");
                return false;
            }
            if (value.Length > 50)
            {
                SetCheck(lbl, false, "Maximum 50 characters.");
                return false;
            }
            if (!NameRegex.IsMatch(value))
            {
                SetCheck(lbl, false, "Only letters, spaces, - and ' are allowed (no numbers/symbols).");
                return false;
            }
            if (Regex.IsMatch(value, @"\s{2,}"))
            {
                SetCheck(lbl, false, "No consecutive spaces.");
                return false;
            }
            if (value.StartsWith("-") || value.StartsWith("'") ||
                value.EndsWith("-") || value.EndsWith("'"))
            {
                SetCheck(lbl, false, "Cannot start or end with - or '.");
                return false;
            }

            SetCheck(lbl, true, "✓  Valid");
            return true;
        }

        /// <summary>
        /// Validate số điện thoại: bắt buộc nhập, chỉ chữ số (cho phép + ở đầu, khoảng trắng, - , .),
        /// không cho phép chữ cái, độ dài hợp lý 8-15 ký tự.
        /// </summary>
        private bool ValidatePhoneField(TextBox tb, Label lbl)
        {
            string value = tb.Text.Trim();

            if (value == "")
            {
                SetCheck(lbl, false, "Phone is required.");
                return false;
            }
            if (Regex.IsMatch(value, @"[a-zA-Z\p{L}]"))
            {
                SetCheck(lbl, false, "Phone number cannot contain letters.");
                return false;
            }
            if (!PhoneRegex.IsMatch(value))
            {
                SetCheck(lbl, false, "Invalid phone number (8-15 digits).");
                return false;
            }

            SetCheck(lbl, true, "✓  Valid");
            return true;
        }

        // ================= VALIDATE =================

        private bool ValidateInput()
        {
            lblValidateFirstName.Text = "";
            lblValidateLastName.Text = "";
            lblValidatePhone.Text = "";
            bool ok = true;

            // First Name: bắt buộc + đúng định dạng (chỉ chữ cái)
            if (string.IsNullOrWhiteSpace(txtFname.Text))
            { lblValidateFirstName.Text = "First name is required."; ok = false; }
            else if (!ValidateNameField(txtFname, lblValidateFirstName, "First name"))
            { ok = false; }

            // Last Name: bắt buộc + đúng định dạng (chỉ chữ cái)
            if (string.IsNullOrWhiteSpace(txtLname.Text))
            { lblValidateLastName.Text = "Last name is required."; ok = false; }
            else if (!ValidateNameField(txtLname, lblValidateLastName, "Last name"))
            { ok = false; }

            // Phone: bắt buộc + chỉ chữ số (không chữ cái)
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            { lblValidatePhone.Text = "Phone is required."; ok = false; }
            else if (!ValidatePhoneField(txtPhone, lblValidatePhone))
            { ok = false; }

            if (cboContactGroup.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn hoặc tạo nhóm trước.", "Thiếu nhóm",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ok = false;
            }

            return ok;
        }

        // ================= CLEAR FORM =================

        private void ClearForm()
        {
            txtFname.Clear(); txtLname.Clear();
            txtPhone.Clear(); txtEmail.Clear(); txtAddress.Clear();
            dtpDob.Value = DateTime.Today;
            cboGender.SelectedIndex = 0;
            picContact.Image = null;
            lblValidateFirstName.Text = "";
            lblValidateLastName.Text = "";
            lblValidatePhone.Text = "";
        }

        // ================= IMAGE HELPER =================

        private byte[] GetImageBytes()
        {
            if (picContact.Image == null) return null;
            using (var ms = new MemoryStream())
            {
                picContact.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // ================= ADD CONTACT =================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                bool ok = contact.AddContact(
                    txtFname.Text.Trim(), txtLname.Text.Trim(),
                    dtpDob.Value,
                    cboGender.SelectedItem?.ToString(),
                    txtPhone.Text.Trim(), txtEmail.Text.Trim(),
                    txtAddress.Text.Trim(),
                    GetImageBytes(),
                    Convert.ToInt32(cboContactGroup.SelectedValue));

                if (ok)
                {
                    MessageBox.Show("Thêm liên hệ thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();

                    // Reset filter về "(All Groups)" để user thấy contact vừa thêm
                    cboGroup.SelectedIndexChanged -= cboGroup_SelectedIndexChanged;
                    cboGroup.SelectedIndex = 0;  // index 0 = "(All Groups)"
                    cboGroup.SelectedIndexChanged += cboGroup_SelectedIndexChanged;

                    LoadData();  // load all contacts
                }
                else
                    MessageBox.Show("Thêm liên hệ thất bại!", "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= EDIT CONTACT =================

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa.", "Chưa chọn",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (!ValidateInput()) return;

            if (MessageBox.Show("Bạn có chắc muốn cập nhật liên hệ này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgvContacts.CurrentRow.Cells["ID"].Value);
                bool ok = contact.UpdateContact(id,
                    txtFname.Text.Trim(), txtLname.Text.Trim(),
                    dtpDob.Value,
                    cboGender.SelectedItem?.ToString(),
                    txtPhone.Text.Trim(), txtEmail.Text.Trim(),
                    txtAddress.Text.Trim(),
                    GetImageBytes(),
                    Convert.ToInt32(cboContactGroup.SelectedValue));

                if (ok)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();

                    // Reset filter về "(All Groups)" để user thấy contact vừa cập nhật
                    cboGroup.SelectedIndexChanged -= cboGroup_SelectedIndexChanged;
                    cboGroup.SelectedIndex = 0;  // index 0 = "(All Groups)"
                    cboGroup.SelectedIndexChanged += cboGroup_SelectedIndexChanged;

                    LoadData();  // load all contacts
                }
                else
                    MessageBox.Show("Cập nhật thất bại!", "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= DELETE CONTACT =================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa.", "Chưa chọn",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string name =
                $"{dgvContacts.CurrentRow.Cells["Fname"].Value} {dgvContacts.CurrentRow.Cells["Lname"].Value}";

            if (MessageBox.Show($"Xóa liên hệ \"{name}\"?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgvContacts.CurrentRow.Cells["ID"].Value);
                if (contact.DeleteContact(id))
                {
                    MessageBox.Show("Xóa thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
                else
                    MessageBox.Show("Xóa thất bại!", "Thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= GRID CLICK =================

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvContacts.Rows[e.RowIndex];

            txtFname.Text = row.Cells["Fname"].Value?.ToString();
            txtLname.Text = row.Cells["Lname"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();

            // Populate DateTimePicker
            if (row.Cells["Dob"].Value != null && row.Cells["Dob"].Value != DBNull.Value)
                dtpDob.Value = Convert.ToDateTime(row.Cells["Dob"].Value);
            else
                dtpDob.Value = DateTime.Today;

            // Populate Gender
            string gender = row.Cells["Gender"].Value?.ToString();
            if (!string.IsNullOrEmpty(gender) && cboGender.Items.Contains(gender))
                cboGender.SelectedItem = gender;

            // Populate Group (không kích event filter cboGroup toolbar)
            if (row.Cells["Group_ID"].Value != null && row.Cells["Group_ID"].Value != DBNull.Value)
            {
                cboContactGroup.SelectedIndexChanged -= cboContactGroup_SelectedIndexChanged;
                cboContactGroup.SelectedValue = row.Cells["Group_ID"].Value;
                cboContactGroup.SelectedIndexChanged += cboContactGroup_SelectedIndexChanged;
            }

            // Populate ảnh
            if (row.Cells["Picture"].Value != null && row.Cells["Picture"].Value != DBNull.Value)
            {
                byte[] img = (byte[])row.Cells["Picture"].Value;
                using (var ms = new MemoryStream(img))
                    picContact.Image = Image.FromStream(ms);
            }
            else
                picContact.Image = null;
        }

        // ================= CHOOSE IMAGE =================

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Chọn ảnh đại diện";
                if (ofd.ShowDialog() == DialogResult.OK)
                    picContact.Image = Image.FromFile(ofd.FileName);
            }
        }

        // ================= GROUP MANAGEMENT =================

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string name = txtGroupName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên nhóm.", "Thiếu tên",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (group.AddGroup(name))
            {
                MessageBox.Show($"Đã tạo nhóm \"{name}\".", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGroupName.Clear();
                LoadGroups();
            }
            else
                MessageBox.Show("Tạo nhóm thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (cboGroup.SelectedValue == null) return;
            string gname = cboGroup.Text;
            if (MessageBox.Show($"Xóa nhóm \"{gname}\"? Các liên hệ thuộc nhóm này sẽ không hiện.",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            int gid = Convert.ToInt32(cboGroup.SelectedValue);
            if (group.DeleteGroup(gid))
            {
                MessageBox.Show("Xóa nhóm thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGroups();
                LoadData();
            }
            else
                MessageBox.Show("Xóa nhóm thất bại! Có thể nhóm còn liên hệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ================= EXPORT CSV =================

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV file|*.csv";
                sfd.FileName = $"Contacts_{DateTime.Now:yyyyMMdd_HHmm}.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        foreach (DataGridViewColumn col in dgvContacts.Columns)
                        {
                            if (!col.Visible) continue;
                            sw.Write($"\"{col.HeaderText}\",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgvContacts.Rows)
                        {
                            if (row.IsNewRow) continue;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (!dgvContacts.Columns[cell.ColumnIndex].Visible) continue;
                                string val = cell.Value?.ToString()?.Replace("\"", "\"\"") ?? "";
                                sw.Write($"\"{val}\",");
                            }
                            sw.WriteLine();
                        }
                    }
                    MessageBox.Show("Xuất CSV thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}