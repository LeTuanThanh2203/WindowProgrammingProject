namespace LoginForm
{
    partial class f_AddStudent
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
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();

            pnlBody = new System.Windows.Forms.Panel();
            pnlLeft = new System.Windows.Forms.Panel();
            pnlRight = new System.Windows.Forms.Panel();

            lblPhotoHint = new System.Windows.Forms.Label();
            picStudent = new System.Windows.Forms.PictureBox();
            btnChooseImage = new System.Windows.Forms.Button();

            label1 = new System.Windows.Forms.Label();   // Student ID
            txtID = new System.Windows.Forms.TextBox();
            lblFirstName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblLastName = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();   // Date of Birth
            dtpDob = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();   // Gender
            cboGender = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();   // Phone
            txtPhone = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();   // Address
            txtAddress = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();   // Email
            txtEmail = new System.Windows.Forms.TextBox();

            pnlButtons = new System.Windows.Forms.Panel();
            btnAdd = new System.Windows.Forms.Button();
            btnScan = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnQuit = new System.Windows.Forms.Button();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            pnlRight.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // ──────────────────────────────────────────────────
            // pnlHeader  (top bar, height 88)
            // ──────────────────────────────────────────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Size = new System.Drawing.Size(1040, 88);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.TabIndex = 2;

            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(28, 14);
            lblTitle.Text = "Add New Student";
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new System.Drawing.Point(30, 54);
            lblSubtitle.Text = "University Academic Management System";
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;

            // ──────────────────────────────────────────────────
            // pnlButtons  (bottom bar, height 84)
            // ──────────────────────────────────────────────────
            pnlButtons.BackColor = System.Drawing.Color.White;
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnScan);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnQuit);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlButtons.Size = new System.Drawing.Size(1040, 84);
            pnlButtons.Padding = new System.Windows.Forms.Padding(28, 16, 28, 16);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.TabIndex = 0;

            StylePrimaryBtn(btnAdd, "✚  Add Student", 28);
            StyleAIBtn(btnScan, "⚡  AI Scan", 204);
            StyleSecondaryBtn(btnClear, "↺  Clear", 370);
            StyleSecondaryBtn(btnQuit, "✕  Close", 516);

            btnAdd.Click += btnAdd_Click;
            btnClear.Click += btnClear_Click;
            btnQuit.Click += btnQuit_Click;

            // ──────────────────────────────────────────────────
            // pnlBody  (fills remaining area)
            // ──────────────────────────────────────────────────
            pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBody.Name = "pnlBody";
            pnlBody.TabIndex = 1;

            // ──────────────────────────────────────────────────
            // pnlLeft  (photo panel, fixed 300 px wide)
            // ──────────────────────────────────────────────────
            pnlLeft.BackColor = System.Drawing.Color.White;
            pnlLeft.Controls.Add(lblPhotoHint);
            pnlLeft.Controls.Add(picStudent);
            pnlLeft.Controls.Add(btnChooseImage);
            pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            pnlLeft.Width = 300;
            pnlLeft.Name = "pnlLeft";
            pnlLeft.TabIndex = 0;

            lblPhotoHint.AutoSize = true;
            lblPhotoHint.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            lblPhotoHint.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            lblPhotoHint.Location = new System.Drawing.Point(36, 28);
            lblPhotoHint.Text = "Student Photo";
            lblPhotoHint.Name = "lblPhotoHint";
            lblPhotoHint.TabIndex = 0;

            picStudent.BackColor = System.Drawing.Color.FromArgb(235, 240, 248);
            picStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            picStudent.Location = new System.Drawing.Point(36, 58);
            picStudent.Size = new System.Drawing.Size(224, 270);
            picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picStudent.Name = "picStudent";
            picStudent.TabIndex = 1;
            picStudent.TabStop = false;
            picStudent.Click += btnChooseImage_Click;

            btnChooseImage.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btnChooseImage.ForeColor = System.Drawing.Color.White;
            btnChooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            btnChooseImage.Location = new System.Drawing.Point(36, 342);
            btnChooseImage.Size = new System.Drawing.Size(224, 46);
            btnChooseImage.Text = "📷  Upload Photo";
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.TabIndex = 2;
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;

            // ──────────────────────────────────────────────────
            // pnlRight  (form fields, fills remaining width)
            // ──────────────────────────────────────────────────
            pnlRight.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRight.Padding = new System.Windows.Forms.Padding(36, 28, 36, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.TabIndex = 1;
            pnlRight.Controls.AddRange(new System.Windows.Forms.Control[] {
                label1, txtID,
                lblFirstName, txtFirstName,
                lblLastName,  txtLastName,
                label4, dtpDob,
                label5, cboGender,
                label6, txtPhone,
                label7, txtAddress,
                label9, txtEmail
            });

            // ── Layout constants ────────────────────────────
            const int LBL_X = 36;         // label left edge (inside pnlRight)
            const int CTL_X = 200;        // control left edge
            const int ROW_H = 72;         // row height (label + input + gap)
            const int LBL_DY = 4;          // label y-offset within row
            const int CTL_H = 38;         // input height
            const int FULL_W = 680;        // full-width input
            const int HALF_W = 318;        // half-width input
            const int GAP = 28;         // gap between half-width pairs
            int y = 20;

            // Row 0 — Student ID (full width)
            SetupField(label1, "Student ID", LBL_X, y + LBL_DY);
            txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtID.Location = new System.Drawing.Point(CTL_X, y);
            txtID.Size = new System.Drawing.Size(FULL_W, CTL_H);
            txtID.MaxLength = 20;
            txtID.Name = "txtID"; txtID.TabIndex = 1;
            y += ROW_H;

            // Row 1 — First Name | Last Name (half + half)
            SetupField(lblFirstName, "First Name", LBL_X, y + LBL_DY);
            txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtFirstName.Location = new System.Drawing.Point(CTL_X, y);
            txtFirstName.Size = new System.Drawing.Size(HALF_W, CTL_H);
            txtFirstName.Name = "txtFirstName"; txtFirstName.TabIndex = 3;

            SetupField(lblLastName, "Last Name", CTL_X + HALF_W + GAP, y + LBL_DY);
            txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtLastName.Location = new System.Drawing.Point(CTL_X + HALF_W + GAP + 90, y);
            txtLastName.Size = new System.Drawing.Size(HALF_W - 90, CTL_H);
            txtLastName.Name = "txtLastName"; txtLastName.TabIndex = 5;
            // (lblLastName overlaps; use a fixed x for it)
            lblLastName.Location = new System.Drawing.Point(CTL_X + HALF_W + GAP, y + LBL_DY);
            y += ROW_H;

            // Row 2 — Date of Birth | Gender (half + half)
            SetupField(label4, "Date of Birth", LBL_X, y + LBL_DY);
            dtpDob.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDob.Location = new System.Drawing.Point(CTL_X, y);
            dtpDob.Size = new System.Drawing.Size(HALF_W, CTL_H);
            dtpDob.Name = "dtpDob"; dtpDob.TabIndex = 7;

            SetupField(label5, "Gender", CTL_X + HALF_W + GAP, y + LBL_DY);
            cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            cboGender.Location = new System.Drawing.Point(CTL_X + HALF_W + GAP + 72, y);
            cboGender.Size = new System.Drawing.Size(HALF_W - 72, CTL_H);
            cboGender.Name = "cboGender"; cboGender.TabIndex = 9;
            label5.Location = new System.Drawing.Point(CTL_X + HALF_W + GAP, y + LBL_DY);
            y += ROW_H;

            // Row 3 — Phone | (half, left only — spacious)
            SetupField(label6, "Phone", LBL_X, y + LBL_DY);
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtPhone.Location = new System.Drawing.Point(CTL_X, y);
            txtPhone.Size = new System.Drawing.Size(HALF_W, CTL_H);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone"; txtPhone.TabIndex = 11;
            y += ROW_H;

            // Row 4 — Address (full width)
            SetupField(label7, "Address", LBL_X, y + LBL_DY);
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtAddress.Location = new System.Drawing.Point(CTL_X, y);
            txtAddress.Size = new System.Drawing.Size(FULL_W, CTL_H);
            txtAddress.Name = "txtAddress"; txtAddress.TabIndex = 13;
            y += ROW_H;

            // Row 5 — Email (full width)
            SetupField(label9, "Email", LBL_X, y + LBL_DY);
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtEmail.Location = new System.Drawing.Point(CTL_X, y);
            txtEmail.Size = new System.Drawing.Size(FULL_W, CTL_H);
            txtEmail.Name = "txtEmail"; txtEmail.TabIndex = 15;

            // ──────────────────────────────────────────────────
            // f_AddStudent  (form)
            // ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            ClientSize = new System.Drawing.Size(1040, 660);
            Controls.Add(pnlBody);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "f_AddStudent";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add New Student — Academic Management";
            Load += StudentAdd_Load;

            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ──────────────────────────────────────────────────
        // Helper methods (called inside InitializeComponent)
        // ──────────────────────────────────────────────────
        private void SetupField(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
        }

        private void StylePrimaryBtn(System.Windows.Forms.Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left, 16);
            btn.Size = new System.Drawing.Size(160, 48);
            btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            btn.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
        }

        private void StyleAIBtn(System.Windows.Forms.Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left, 16);
            btn.Size = new System.Drawing.Size(150, 48);
            btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            btn.BackColor = System.Drawing.Color.FromArgb(50, 130, 100);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
            btn.Click += btnAI_Click;
        }

        private void StyleSecondaryBtn(System.Windows.Forms.Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left, 16);
            btn.Size = new System.Drawing.Size(130, 48);
            btn.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            btn.BackColor = System.Drawing.Color.White;
            btn.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btn.FlatAppearance.BorderSize = 1;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        // ── Control declarations ───────────────────────────
        private System.Windows.Forms.Panel pnlHeader, pnlBody, pnlLeft, pnlRight, pnlButtons;
        private System.Windows.Forms.Label lblTitle, lblSubtitle, lblPhotoHint;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label label1, lblFirstName, lblLastName,
                                             label4, label5, label6, label7, label9;
        private System.Windows.Forms.TextBox txtID, txtFirstName, txtLastName,
                                                  txtPhone, txtAddress, txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnAdd, btnScan, btnClear, btnQuit;
    }
}