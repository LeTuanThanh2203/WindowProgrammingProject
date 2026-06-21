namespace LoginForm
{
    partial class f_EditDeleteHR
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pnlSearch = new Panel();
            cboSort = new ComboBox();
            cboGender = new ComboBox();
            txtSearch = new TextBox();
            dgvHR = new DataGridView();
            panel2 = new Panel();
            pnlFormHeader = new Panel();
            lblFormTitle = new Label();
            lblPhotoHint = new Label();
            picHR = new PictureBox();
            btnChooseImage = new Button();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            dtpDob = new DateTimePicker();
            label5 = new Label();
            cboGenderChoose = new ComboBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            pnlButtons = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHR).BeginInit();
            panel2.SuspendLayout();
            pnlFormHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHR).BeginInit();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvHR);
            panel1.Controls.Add(pnlSearch);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 720);
            panel1.TabIndex = 1;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(245, 247, 250);
            pnlSearch.Controls.Add(cboSort);
            pnlSearch.Controls.Add(cboGender);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(8, 10, 8, 8);
            pnlSearch.Size = new Size(700, 52);
            pnlSearch.TabIndex = 0;
            // 
            // cboSort
            // 
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.Font = new Font("Segoe UI", 9.5F);
            cboSort.Location = new Point(8, 12);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(120, 29);
            cboSort.TabIndex = 0;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 9.5F);
            cboGender.Location = new Point(136, 12);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(100, 29);
            cboGender.TabIndex = 1;
            cboGender.SelectedIndexChanged += cboGender_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(244, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, name, email, phone...";
            txtSearch.Size = new Size(444, 29);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvHR
            // 
            dgvHR.AllowUserToAddRows = false;
            dgvHR.AllowUserToResizeColumns = false;
            dgvHR.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(246, 249, 253);
            dgvHR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHR.BackgroundColor = Color.White;
            dgvHR.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHR.Dock = DockStyle.Fill;
            dgvHR.EnableHeadersVisualStyles = false;
            dgvHR.Font = new Font("Segoe UI", 9F);
            dgvHR.Location = new Point(0, 52);
            dgvHR.MultiSelect = false;
            dgvHR.Name = "dgvHR";
            dgvHR.ReadOnly = true;
            dgvHR.RowHeadersVisible = false;
            dgvHR.RowHeadersWidth = 51;
            dgvHR.RowTemplate.Height = 36;
            dgvHR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHR.Size = new Size(700, 668);
            dgvHR.TabIndex = 1;
            dgvHR.CellClick += dgvHR_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 247, 250);
            panel2.Controls.Add(pnlFormHeader);
            panel2.Controls.Add(lblPhotoHint);
            panel2.Controls.Add(picHR);
            panel2.Controls.Add(btnChooseImage);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpDob);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cboGenderChoose);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(pnlButtons);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(700, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 720);
            panel2.TabIndex = 0;
            // 
            // pnlFormHeader
            // 
            pnlFormHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlFormHeader.Controls.Add(lblFormTitle);
            pnlFormHeader.Dock = DockStyle.Top;
            pnlFormHeader.Location = new Point(0, 0);
            pnlFormHeader.Name = "pnlFormHeader";
            pnlFormHeader.Size = new Size(580, 52);
            pnlFormHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 13F);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(20, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(174, 30);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Edit / Delete HR";
            // 
            // lblPhotoHint
            // 
            lblPhotoHint.AutoSize = true;
            lblPhotoHint.Font = new Font("Segoe UI Semibold", 9.5F);
            lblPhotoHint.ForeColor = Color.FromArgb(80, 80, 90);
            lblPhotoHint.Location = new Point(20, 66);
            lblPhotoHint.Name = "lblPhotoHint";
            lblPhotoHint.Size = new Size(78, 21);
            lblPhotoHint.TabIndex = 1;
            lblPhotoHint.Text = "HR Photo";
            // 
            // picHR
            // 
            picHR.BackColor = Color.FromArgb(235, 240, 248);
            picHR.BorderStyle = BorderStyle.FixedSingle;
            picHR.Location = new Point(20, 92);
            picHR.Name = "picHR";
            picHR.Size = new Size(130, 160);
            picHR.SizeMode = PictureBoxSizeMode.StretchImage;
            picHR.TabIndex = 2;
            picHR.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.FromArgb(10, 61, 120);
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Segoe UI", 9.5F);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.Location = new Point(20, 262);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(130, 36);
            btnChooseImage.TabIndex = 3;
            btnChooseImage.Text = "Edit Photo";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnEditImage_Click;
            // 
            // label1
            // 
            label1.Text = "HR ID:";
            label1.Location = new Point(180, 71);
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F);
            label1.ForeColor = Color.FromArgb(80, 80, 90);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(235, 240, 248);
            txtID.Font = new Font("Segoe UI", 9.5F);
            txtID.Location = new Point(320, 66);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(220, 29);
            txtID.TabIndex = 5;
            // 
            // label2
            // 
            label2.Text = "First Name:";
            label2.Location = new Point(180, 115);
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.ForeColor = Color.FromArgb(80, 80, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.5F);
            txtFirstName.Location = new Point(320, 110);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 29);
            txtFirstName.TabIndex = 7;
            // 
            // label3
            // 
            label3.Text = "Last Name:";
            label3.Location = new Point(180, 159);
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F);
            label3.ForeColor = Color.FromArgb(80, 80, 90);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.5F);
            txtLastName.Location = new Point(320, 154);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(220, 29);
            txtLastName.TabIndex = 9;
            // 
            // label4
            // 
            label4.Text = "Date of Birth:";
            label4.Location = new Point(180, 203);
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F);
            label4.ForeColor = Color.FromArgb(80, 80, 90);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 10;
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Segoe UI", 9.5F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(320, 198);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(180, 29);
            dtpDob.TabIndex = 11;
            // 
            // label5
            // 
            label5.Text = "Gender:";
            label5.Location = new Point(180, 247);
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F);
            label5.ForeColor = Color.FromArgb(80, 80, 90);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 12;
            // 
            // cboGenderChoose
            // 
            cboGenderChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenderChoose.Font = new Font("Segoe UI", 9.5F);
            cboGenderChoose.Location = new Point(320, 242);
            cboGenderChoose.Name = "cboGenderChoose";
            cboGenderChoose.Size = new Size(120, 29);
            cboGenderChoose.TabIndex = 13;
            // 
            // label6
            // 
            label6.Text = "Phone:";
            label6.Location = new Point(180, 291);
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.ForeColor = Color.FromArgb(80, 80, 90);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9.5F);
            txtPhone.Location = new Point(320, 286);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 29);
            txtPhone.TabIndex = 15;
            // 
            // label7
            // 
            label7.Text = "Address:";
            label7.Location = new Point(180, 335);
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F);
            label7.ForeColor = Color.FromArgb(80, 80, 90);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.5F);
            txtAddress.Location = new Point(320, 330);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(220, 29);
            txtAddress.TabIndex = 17;
            // 
            // label9
            // 
            label9.Text = "Email:";
            label9.Location = new Point(180, 379);
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.5F);
            label9.ForeColor = Color.FromArgb(80, 80, 90);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(320, 374);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 29);
            txtEmail.TabIndex = 19;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnQuit);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 652);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(580, 68);
            pnlButtons.TabIndex = 20;
            // 
            // btnUpdate
            // 
            btnUpdate.Text = "Update";
            btnUpdate.Location = new Point(24, 13);
            btnUpdate.Size = new Size(130, 42);
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.5F);
            btnUpdate.BackColor = Color.FromArgb(10, 61, 120);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.TabIndex = 0;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Text = "Delete";
            btnDelete.Location = new Point(178, 13);
            btnDelete.Size = new Size(112, 42);
            btnDelete.Font = new Font("Segoe UI Semibold", 9.5F);
            btnDelete.BackColor = Color.FromArgb(180, 30, 30);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Name = "btnDelete";
            btnDelete.TabIndex = 1;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuit
            // 
            btnQuit.Text = "Cancel";
            btnQuit.Location = new Point(310, 13);
            btnQuit.Size = new Size(110, 42);
            btnQuit.Font = new Font("Segoe UI", 9.5F);
            btnQuit.BackColor = Color.White;
            btnQuit.ForeColor = Color.FromArgb(60, 70, 85);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnQuit.FlatAppearance.BorderSize = 1;
            btnQuit.Cursor = Cursors.Hand;
            btnQuit.Name = "btnQuit";
            btnQuit.TabIndex = 2;
            btnQuit.Click += btnCancel_Click;
            // 
            // f_EditDeleteHR
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_EditDeleteHR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage HRs — Academic Management";
            Load += ManageHR_Load;
            Shown += f_ListHR_Shown;
            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHR).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlFormHeader.ResumeLayout(false);
            pnlFormHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHR).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel panel1, pnlSearch;
        private Panel panel2, pnlFormHeader, pnlButtons;
        private Label lblFormTitle;
        private ComboBox cboGender, cboSort;
        private TextBox txtSearch;
        private DataGridView dgvHR;

        private Label lblPhotoHint;
        private PictureBox picHR;
        private Button btnChooseImage;

        private Label label1, label2, label3, label4, label5, label6, label7, label9;
        private TextBox txtID, txtFirstName, txtLastName, txtPhone, txtAddress, txtEmail;
        private DateTimePicker dtpDob;
        private ComboBox cboGenderChoose;

        private Button btnUpdate, btnDelete, btnQuit;
    }
}
