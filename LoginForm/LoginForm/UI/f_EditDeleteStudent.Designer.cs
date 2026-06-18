namespace Project_Group6.UI
{
    partial class f_EditDeleteStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Left – list panel
            panel1 = new Panel();
            pnlSearch = new Panel();
            cboGender = new ComboBox();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvStudents = new DataGridView();

            // Right – edit panel
            panel2 = new Panel();
            pnlFormHeader = new Panel();
            lblFormTitle = new Label();

            // Photo
            lblPhotoHint = new Label();
            picStudent = new PictureBox();
            btnChooseImage = new Button();

            // Fields (match logic code names exactly)
            label1 = new Label(); // ID
            txtID = new TextBox();
            label2 = new Label(); // Last name
            txtFirstName = new TextBox();
            label3 = new Label(); // First name
            txtLastName = new TextBox();
            label4 = new Label(); // DOB
            dtpDob = new DateTimePicker();
            label5 = new Label(); // Gender
            cboGenderChoose = new ComboBox();
            label6 = new Label(); // Phone
            txtPhone = new TextBox();
            label7 = new Label(); // Address
            txtAddress = new TextBox();
            label9 = new Label(); // Email
            txtEmail = new TextBox();

            // Buttons
            pnlButtons = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();

            // ── Begin init ────────────────────────────────────────────
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // ══ LEFT PANEL ════════════════════════════════════════════
            panel1.Dock = DockStyle.Left;
            panel1.Width = 700;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.AddRange(new Control[] { pnlSearch, dgvStudents });

            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Height = 52;
            pnlSearch.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlSearch.Padding = new Padding(8, 10, 8, 8);
            pnlSearch.Controls.AddRange(new Control[] { cboSort, cboGender, txtSearch });

            cboSort.Location = new System.Drawing.Point(8, 12);
            cboSort.Size = new System.Drawing.Size(120, 28);
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;

            cboGender.Location = new System.Drawing.Point(136, 12);
            cboGender.Size = new System.Drawing.Size(100, 28);
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboGender.SelectedIndexChanged += cboGender_SelectedIndexChanged;

            txtSearch.Location = new System.Drawing.Point(244, 12);
            txtSearch.Size = new System.Drawing.Size(444, 28);
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSearch.PlaceholderText = "Search by ID, name, email, phone...";
            txtSearch.TextChanged += txtSearch_TextChanged;

            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.MultiSelect = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.BackgroundColor = System.Drawing.Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvStudents.RowTemplate.Height = 36;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 249, 253);
            dgvStudents.CellClick += dgvStudents_CellClick;

            // ══ RIGHT PANEL ═══════════════════════════════════════════
            panel2.Dock = DockStyle.Fill;
            panel2.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // Header strip
            pnlFormHeader.Dock = DockStyle.Top;
            pnlFormHeader.Height = 52;
            pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            pnlFormHeader.Controls.Add(lblFormTitle);

            lblFormTitle.Text = "Edit / Delete Student";
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            lblFormTitle.ForeColor = System.Drawing.Color.White;
            lblFormTitle.Location = new System.Drawing.Point(20, 14);
            lblFormTitle.AutoSize = true;

            // Photo section on the right panel
            lblPhotoHint.Text = "Student Photo";
            lblPhotoHint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            lblPhotoHint.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            lblPhotoHint.Location = new System.Drawing.Point(20, 66);
            lblPhotoHint.AutoSize = true;

            picStudent.Location = new System.Drawing.Point(20, 92);
            picStudent.Size = new System.Drawing.Size(130, 160);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.BackColor = System.Drawing.Color.FromArgb(235, 240, 248);

            btnChooseImage.Text = "Edit Photo";
            btnChooseImage.Location = new System.Drawing.Point(20, 262);
            btnChooseImage.Size = new System.Drawing.Size(130, 36);
            btnChooseImage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnChooseImage.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btnChooseImage.ForeColor = System.Drawing.Color.White;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.Click += btnEditImage_Click;

            // Fields – column right of photo
            int lblX = 170, fldX = 320, rowH = 48, startY = 66;

            SetupField(label1, "Student ID:", lblX, startY + rowH * 0);
            txtID.Location = new System.Drawing.Point(fldX, startY + rowH * 0 - 2);
            txtID.Size = new System.Drawing.Size(220, 27);
            txtID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtID.ReadOnly = true;  // ID is not editable per logic
            txtID.BackColor = System.Drawing.Color.FromArgb(235, 240, 248);

            SetupField(label2, "Last Name:", lblX, startY + rowH * 1);
            txtFirstName.Location = new System.Drawing.Point(fldX, startY + rowH * 1 - 2);
            txtFirstName.Size = new System.Drawing.Size(220, 27);
            txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtFirstName.Name = "txtFirstName";

            SetupField(label3, "First Name:", lblX, startY + rowH * 2);
            txtLastName.Location = new System.Drawing.Point(fldX, startY + rowH * 2 - 2);
            txtLastName.Size = new System.Drawing.Size(220, 27);
            txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtLastName.Name = "txtLastName";

            SetupField(label4, "Date of Birth:", lblX, startY + rowH * 3);
            dtpDob.Location = new System.Drawing.Point(fldX, startY + rowH * 3 - 2);
            dtpDob.Size = new System.Drawing.Size(180, 27);
            dtpDob.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpDob.Format = DateTimePickerFormat.Short;

            SetupField(label5, "Gender:", lblX, startY + rowH * 4);
            cboGenderChoose.Location = new System.Drawing.Point(fldX, startY + rowH * 4 - 2);
            cboGenderChoose.Size = new System.Drawing.Size(120, 28);
            cboGenderChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenderChoose.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            SetupField(label6, "Phone:", lblX, startY + rowH * 5);
            txtPhone.Location = new System.Drawing.Point(fldX, startY + rowH * 5 - 2);
            txtPhone.Size = new System.Drawing.Size(220, 27);
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            SetupField(label7, "Address:", lblX, startY + rowH * 6);
            txtAddress.Location = new System.Drawing.Point(fldX, startY + rowH * 6 - 2);
            txtAddress.Size = new System.Drawing.Size(220, 27);
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            SetupField(label9, "Email:", lblX, startY + rowH * 7);
            txtEmail.Location = new System.Drawing.Point(fldX, startY + rowH * 7 - 2);
            txtEmail.Size = new System.Drawing.Size(220, 27);
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            panel2.Controls.AddRange(new Control[]
            {
                pnlFormHeader,
                lblPhotoHint, picStudent, btnChooseImage,
                label1, txtID,
                label2, txtFirstName, label3, txtLastName,
                label4, dtpDob,
                label5, cboGenderChoose, label6, txtPhone,
                label7, txtAddress, label9, txtEmail,
                pnlButtons
            });

            // ── Button panel ──────────────────────────────────────────
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Height = 68;
            pnlButtons.BackColor = System.Drawing.Color.White;
            pnlButtons.Controls.AddRange(new Control[] { btnUpdate, btnDelete, btnQuit });

            StylePrimaryBtn(btnUpdate, "Save Changes", 16);
            StyleDangerBtn(btnDelete, "Delete", 162);
            StyleSecondaryBtn(btnQuit, "Cancel", 292);
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnQuit.Click += btnCancel_Click;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1280, 720);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Students — Academic Management";
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            Load += ManageStudent_Load;
            Shown += f_ListStudent_Shown;

            Controls.AddRange(new Control[] { panel2, panel1 });

            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetupField(Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y + 5);
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
        }

        private void StylePrimaryBtn(Button btn, string text, int left)
        {
            btn.Text = text; btn.Location = new System.Drawing.Point(left, 13);
            btn.Size = new System.Drawing.Size(130, 42);
            btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btn.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat; btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleDangerBtn(Button btn, string text, int left)
        {
            btn.Text = text; btn.Location = new System.Drawing.Point(left, 13);
            btn.Size = new System.Drawing.Size(112, 42);
            btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btn.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat; btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleSecondaryBtn(Button btn, string text, int left)
        {
            btn.Text = text; btn.Location = new System.Drawing.Point(left, 13);
            btn.Size = new System.Drawing.Size(110, 42);
            btn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btn.BackColor = System.Drawing.Color.White;
            btn.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btn.FlatAppearance.BorderSize = 1; btn.Cursor = Cursors.Hand;
        }

        #endregion

        private Panel panel1, pnlSearch;
        private Panel panel2, pnlFormHeader, pnlButtons;
        private Label lblFormTitle;
        private ComboBox cboGender, cboSort;
        private TextBox txtSearch;
        private DataGridView dgvStudents;

        private Label lblPhotoHint;
        private PictureBox picStudent;
        private Button btnChooseImage;

        private Label label1, label2, label3, label4, label5, label6, label7, label9;
        private TextBox txtID, txtFirstName, txtLastName, txtPhone, txtAddress, txtEmail;
        private DateTimePicker dtpDob;
        private ComboBox cboGenderChoose;

        private Button btnUpdate, btnDelete, btnQuit;

        // Legacy aliases (kept for designer compatibility — not used in logic)
        private TextBox txtMSSV => txtID;
        private TextBox txtHomeTown = new TextBox(); // hidden, not added to Controls
        private Label label8 = new Label();       // hidden
        private Label label10 = new Label();       // hidden
    }
}