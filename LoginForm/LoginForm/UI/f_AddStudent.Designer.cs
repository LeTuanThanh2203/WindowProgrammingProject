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
            lblValidateID = new Label();
            lblValidateFirstName = new Label();
            lblValidateLastName = new Label();
            lblValidatePhone = new Label();
            lblValidateEmail = new Label();
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
            pnlRight.Controls.Add(lblValidateID);
            pnlRight.Controls.Add(lblValidateFirstName);
            pnlRight.Controls.Add(lblValidateLastName);
            pnlRight.Controls.Add(lblValidatePhone);
            pnlRight.Controls.Add(lblValidateEmail);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(300, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(0);
            pnlRight.Size = new Size(740, 488);
            pnlRight.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.ForeColor = Color.FromArgb(80, 80, 90);
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.Location = new Point(200, 20);
            txtID.MaxLength = 20;
            txtID.Name = "txtID";
            txtID.Size = new Size(500, 38);
            txtID.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.5F);
            lblFirstName.ForeColor = Color.FromArgb(80, 80, 90);
            lblFirstName.Location = new Point(36, 96);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(78, 21);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10F);
            txtFirstName.Location = new Point(200, 92);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(236, 38);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.5F);
            lblLastName.ForeColor = Color.FromArgb(80, 80, 90);
            lblLastName.Location = new Point(464, 96);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(73, 21);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10F);
            txtLastName.Location = new Point(554, 92);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(146, 38);
            txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F);
            label4.ForeColor = Color.FromArgb(80, 80, 90);
            label4.Location = new Point(36, 168);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "Date of Birth";
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(200, 164);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(236, 38);
            dtpDob.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F);
            label5.ForeColor = Color.FromArgb(80, 80, 90);
            label5.Location = new Point(464, 168);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 8;
            label5.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 10F);
            cboGender.Location = new Point(536, 164);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(164, 38);
            cboGender.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.ForeColor = Color.FromArgb(80, 80, 90);
            label6.Location = new Point(36, 240);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 10;
            label6.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(200, 236);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 38);
            txtPhone.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F);
            label7.ForeColor = Color.FromArgb(80, 80, 90);
            label7.Location = new Point(36, 312);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 12;
            label7.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(200, 308);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(500, 38);
            txtAddress.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.5F);
            label9.ForeColor = Color.FromArgb(80, 80, 90);
            label9.Location = new Point(36, 384);
            label9.Name = "label9";
            label9.Size = new Size(40, 21);
            label9.TabIndex = 14;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(200, 380);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(500, 38);
            txtEmail.TabIndex = 15;
            // 
            // lblValidateID
            // 
            lblValidateID.AutoSize = true;
            lblValidateID.Font = new Font("Segoe UI", 8.5F);
            lblValidateID.ForeColor = Color.Red;
            lblValidateID.Location = new Point(200, 62);
            lblValidateID.Name = "lblValidateID";
            lblValidateID.Size = new Size(0, 19);
            lblValidateID.TabIndex = 20;
            lblValidateID.Text = "";
            // 
            // lblValidateFirstName
            // 
            lblValidateFirstName.AutoSize = true;
            lblValidateFirstName.Font = new Font("Segoe UI", 8.5F);
            lblValidateFirstName.ForeColor = Color.Red;
            lblValidateFirstName.Location = new Point(200, 134);
            lblValidateFirstName.Name = "lblValidateFirstName";
            lblValidateFirstName.Size = new Size(0, 19);
            lblValidateFirstName.TabIndex = 21;
            lblValidateFirstName.Text = "";
            // 
            // lblValidateLastName
            // 
            lblValidateLastName.AutoSize = true;
            lblValidateLastName.Font = new Font("Segoe UI", 8.5F);
            lblValidateLastName.ForeColor = Color.Red;
            lblValidateLastName.Location = new Point(554, 134);
            lblValidateLastName.Name = "lblValidateLastName";
            lblValidateLastName.Size = new Size(0, 19);
            lblValidateLastName.TabIndex = 22;
            lblValidateLastName.Text = "";
            // 
            // lblValidatePhone
            // 
            lblValidatePhone.AutoSize = true;
            lblValidatePhone.Font = new Font("Segoe UI", 8.5F);
            lblValidatePhone.ForeColor = Color.Red;
            lblValidatePhone.Location = new Point(200, 278);
            lblValidatePhone.Name = "lblValidatePhone";
            lblValidatePhone.Size = new Size(0, 19);
            lblValidatePhone.TabIndex = 23;
            lblValidatePhone.Text = "";
            // 
            // lblValidateEmail
            // 
            lblValidateEmail.AutoSize = true;
            lblValidateEmail.Font = new Font("Segoe UI", 8.5F);
            lblValidateEmail.ForeColor = Color.Red;
            lblValidateEmail.Location = new Point(200, 422);
            lblValidateEmail.Name = "lblValidateEmail";
            lblValidateEmail.Size = new Size(0, 19);
            lblValidateEmail.TabIndex = 24;
            lblValidateEmail.Text = "";
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
        private System.Windows.Forms.Label lblValidateID, lblValidateFirstName,
                                             lblValidateLastName, lblValidatePhone, lblValidateEmail;
        private System.Windows.Forms.TextBox txtID, txtFirstName, txtLastName,
                                                  txtPhone, txtAddress, txtEmail;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnAdd, btnScan, btnClear, btnQuit;
    }
}