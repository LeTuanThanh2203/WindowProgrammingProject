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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();
            pnlRight = new Panel();
            label1 = new Label();
            txtID = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            dtpDob = new DateTimePicker();
            label5 = new Label();
            cboGender = new ComboBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            pnlLeft = new Panel();
            lblPhotoHint = new Label();
            picStudent = new PictureBox();
            btnChooseImage = new Button();
            pnlButtons = new Panel();
            btnAdd = new Button();
            btnScan = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1040, 88);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(28, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(259, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Student";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(30, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(329, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "University Academic Management System";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(pnlRight);
            pnlBody.Controls.Add(pnlLeft);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 88);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1040, 488);
            pnlBody.TabIndex = 1;
            // 
            // pnlRight
            // 
            pnlRight.AutoScroll = true;
            pnlRight.BackColor = Color.FromArgb(245, 247, 250);
            pnlRight.Controls.Add(label1);
            pnlRight.Controls.Add(txtID);
            pnlRight.Controls.Add(lblFirstName);
            pnlRight.Controls.Add(txtFirstName);
            pnlRight.Controls.Add(lblLastName);
            pnlRight.Controls.Add(txtLastName);
            pnlRight.Controls.Add(label4);
            pnlRight.Controls.Add(dtpDob);
            pnlRight.Controls.Add(label5);
            pnlRight.Controls.Add(cboGender);
            pnlRight.Controls.Add(label6);
            pnlRight.Controls.Add(txtPhone);
            pnlRight.Controls.Add(label7);
            pnlRight.Controls.Add(txtAddress);
            pnlRight.Controls.Add(label9);
            pnlRight.Controls.Add(txtEmail);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(300, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(36, 28, 36, 0);
            pnlRight.Size = new Size(740, 488);
            pnlRight.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(0, 0);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 30);
            txtID.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.Location = new Point(0, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(0, 0);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 30);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.Location = new Point(0, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(0, 0);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 30);
            txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 6;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(0, 0);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(200, 30);
            dtpDob.TabIndex = 7;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 8;
            // 
            // cboGender
            // 
            cboGender.Location = new Point(0, 0);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(121, 31);
            cboGender.TabIndex = 9;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(0, 0);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 30);
            txtPhone.TabIndex = 11;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(0, 0);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 30);
            txtAddress.TabIndex = 13;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 30);
            txtEmail.TabIndex = 15;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(lblPhotoHint);
            pnlLeft.Controls.Add(picStudent);
            pnlLeft.Controls.Add(btnChooseImage);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(300, 488);
            pnlLeft.TabIndex = 0;
            // 
            // lblPhotoHint
            // 
            lblPhotoHint.AutoSize = true;
            lblPhotoHint.Font = new Font("Segoe UI Semibold", 10.5F);
            lblPhotoHint.ForeColor = Color.FromArgb(80, 80, 90);
            lblPhotoHint.Location = new Point(36, 28);
            lblPhotoHint.Name = "lblPhotoHint";
            lblPhotoHint.Size = new Size(133, 25);
            lblPhotoHint.TabIndex = 0;
            lblPhotoHint.Text = "Student Photo";
            // 
            // picStudent
            // 
            picStudent.BackColor = Color.FromArgb(235, 240, 248);
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Cursor = Cursors.Hand;
            picStudent.Location = new Point(36, 58);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(224, 270);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabIndex = 1;
            picStudent.TabStop = false;
            picStudent.Click += btnChooseImage_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.FromArgb(10, 61, 120);
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Segoe UI", 10.5F);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.Location = new Point(36, 342);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(224, 46);
            btnChooseImage.TabIndex = 2;
            btnChooseImage.Text = "📷  Upload Photo";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnScan);
            pnlButtons.Controls.Add(btnClear);
            pnlButtons.Controls.Add(btnQuit);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 576);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(28, 16, 28, 16);
            pnlButtons.Size = new Size(1040, 84);
            pnlButtons.TabIndex = 0;
            // 
            // 
            // btnAdd
            // 
            btnAdd.Text = "Add Student";
            btnAdd.Location = new Point(28, 16);
            btnAdd.Size = new Size(160, 48);
            btnAdd.Font = new Font("Segoe UI Semibold", 10.5F);
            btnAdd.BackColor = Color.FromArgb(10, 61, 120);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Name = "btnAdd";
            btnAdd.TabIndex = 0;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnScan
            // 
            btnScan.Text = "Scan student by AI";
            btnScan.Location = new Point(204, 16);
            btnScan.Size = new Size(150, 48);
            btnScan.Font = new Font("Segoe UI Semibold", 10.5F);
            btnScan.BackColor = Color.FromArgb(50, 130, 100);
            btnScan.ForeColor = Color.White;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.Cursor = Cursors.Hand;
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnAI_Click;
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(150, 48);
            btnScan.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Text = "Clear";
            btnClear.Location = new Point(370, 16);
            btnClear.Size = new Size(130, 48);
            btnClear.Font = new Font("Segoe UI", 10.5F);
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.FromArgb(60, 70, 85);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Name = "btnClear";
            btnClear.TabIndex = 2;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Text = "Cancel";
            btnQuit.Location = new Point(516, 16);
            btnQuit.Size = new Size(130, 48);
            btnQuit.Font = new Font("Segoe UI", 10.5F);
            btnQuit.BackColor = Color.White;
            btnQuit.ForeColor = Color.FromArgb(60, 70, 85);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnQuit.FlatAppearance.BorderSize = 1;
            btnQuit.Cursor = Cursors.Hand;
            btnQuit.Name = "btnQuit";
            btnQuit.TabIndex = 3;
            btnQuit.Click += btnQuit_Click;
            // 
            // f_AddStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1040, 660);
            Controls.Add(pnlBody);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "f_AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Student — Academic Management";
            Load += StudentAdd_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
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