namespace LoginForm
{
    partial class f_ListStudent
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlToolbar = new Panel();
            txtSearch = new TextBox();
            cboSort = new ComboBox();
            cboGender = new ComboBox();
            btnRefresh = new Button();
            pnlBody = new Panel();
            pnlGrid = new Panel();
            dgvContacts = new DataGridView();
            pnLeft = new Panel();
            picContact = new PictureBox();
            lblIDInfo = new Label();
            lblFirstnameInfo = new Label();
            lblLastnameInfo = new Label();
            lblDobInfo = new Label();
            lblGenderInfo = new Label();
            lblPhoneInfo = new Label();
            lblAddressInfo = new Label();
            lblEmailInfo = new Label();
            lblID = new Label();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblDob = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            label1 = new Label();
            pnlBottom = new Panel();
            btAdd = new Button();
            btnEdit = new Button();
            btnViewScore = new Button();
            btnExport = new Button();
            lblTotal = new Label();
            pnlPagination = new Panel();
            cboPageSize = new ComboBox();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picContact).BeginInit();
            pnlBottom.SuspendLayout();
            pnlPagination.SuspendLayout();
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
            pnlHeader.Size = new Size(1455, 80);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(283, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(25, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(302, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "University Academic Management System";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(cboSort);
            pnlToolbar.Controls.Add(cboGender);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(16, 12, 16, 8);
            pnlToolbar.Size = new Size(1455, 56);
            pnlToolbar.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(16, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, name, email…";
            txtSearch.Size = new Size(320, 29);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cboSort
            // 
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.Font = new Font("Segoe UI", 9.5F);
            cboSort.Location = new Point(352, 13);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(140, 29);
            cboSort.TabIndex = 1;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 9.5F);
            cboGender.Location = new Point(508, 13);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(100, 29);
            cboGender.TabIndex = 2;
            cboGender.SelectedIndexChanged += cboGender_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.FromArgb(60, 70, 85);
            btnRefresh.Location = new Point(624, 11);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 32);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "↺  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlGrid);
            pnlBody.Controls.Add(pnLeft);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 136);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1455, 598);
            pnlBody.TabIndex = 0;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(dgvContacts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(404, 0);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(16, 12, 16, 8);
            pnlGrid.Size = new Size(1051, 598);
            pnlGrid.TabIndex = 0;
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToResizeColumns = false;
            dgvContacts.AllowUserToResizeRows = false;
            dgvContacts.ColumnHeadersHeight = 29;
            dgvContacts.Dock = DockStyle.Fill;
            dgvContacts.Location = new Point(16, 12);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.RowHeadersWidth = 51;
            dgvContacts.Size = new Size(1019, 578);
            dgvContacts.TabIndex = 0;
            dgvContacts.CellClick += dgvStudent_CellClick;
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.White;
            pnLeft.Controls.Add(picContact);
            pnLeft.Controls.Add(lblIDInfo);
            pnLeft.Controls.Add(lblFirstnameInfo);
            pnLeft.Controls.Add(lblLastnameInfo);
            pnLeft.Controls.Add(lblDobInfo);
            pnLeft.Controls.Add(lblGenderInfo);
            pnLeft.Controls.Add(lblPhoneInfo);
            pnLeft.Controls.Add(lblAddressInfo);
            pnLeft.Controls.Add(lblEmailInfo);
            pnLeft.Controls.Add(lblID);
            pnLeft.Controls.Add(lblFirstname);
            pnLeft.Controls.Add(lblLastname);
            pnLeft.Controls.Add(lblDob);
            pnLeft.Controls.Add(lblGender);
            pnLeft.Controls.Add(lblPhone);
            pnLeft.Controls.Add(lblAddress);
            pnLeft.Controls.Add(lblEmail);
            pnLeft.Controls.Add(label1);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(404, 598);
            pnLeft.TabIndex = 1;
            // 
            // picContact
            // 
            picContact.BorderStyle = BorderStyle.FixedSingle;
            picContact.Location = new Point(45, 20);
            picContact.Name = "picContact";
            picContact.Size = new Size(200, 226);
            picContact.SizeMode = PictureBoxSizeMode.StretchImage;
            picContact.TabIndex = 0;
            picContact.TabStop = false;
            // 
            // lblIDInfo
            // 
            lblIDInfo.AutoSize = true;
            lblIDInfo.Font = new Font("Segoe UI", 9.5F);
            lblIDInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblIDInfo.Location = new Point(16, 260);
            lblIDInfo.Name = "lblIDInfo";
            lblIDInfo.Size = new Size(85, 21);
            lblIDInfo.TabIndex = 14;
            lblIDInfo.Text = "Student ID:";
            // 
            // lblFirstnameInfo
            // 
            lblFirstnameInfo.AutoSize = true;
            lblFirstnameInfo.Font = new Font("Segoe UI", 9.5F);
            lblFirstnameInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblFirstnameInfo.Location = new Point(16, 294);
            lblFirstnameInfo.Name = "lblFirstnameInfo";
            lblFirstnameInfo.Size = new Size(89, 21);
            lblFirstnameInfo.TabIndex = 15;
            lblFirstnameInfo.Text = "First Name:";
            // 
            // lblLastnameInfo
            // 
            lblLastnameInfo.AutoSize = true;
            lblLastnameInfo.Font = new Font("Segoe UI", 9.5F);
            lblLastnameInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblLastnameInfo.Location = new Point(16, 328);
            lblLastnameInfo.Name = "lblLastnameInfo";
            lblLastnameInfo.Size = new Size(87, 21);
            lblLastnameInfo.TabIndex = 16;
            lblLastnameInfo.Text = "Last Name:";
            // 
            // lblDobInfo
            // 
            lblDobInfo.AutoSize = true;
            lblDobInfo.Font = new Font("Segoe UI", 9.5F);
            lblDobInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblDobInfo.Location = new Point(16, 362);
            lblDobInfo.Name = "lblDobInfo";
            lblDobInfo.Size = new Size(100, 21);
            lblDobInfo.TabIndex = 17;
            lblDobInfo.Text = "Date of Birth:";
            // 
            // lblGenderInfo
            // 
            lblGenderInfo.AutoSize = true;
            lblGenderInfo.Font = new Font("Segoe UI", 9.5F);
            lblGenderInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblGenderInfo.Location = new Point(16, 396);
            lblGenderInfo.Name = "lblGenderInfo";
            lblGenderInfo.Size = new Size(64, 21);
            lblGenderInfo.TabIndex = 18;
            lblGenderInfo.Text = "Gender:";
            // 
            // lblPhoneInfo
            // 
            lblPhoneInfo.AutoSize = true;
            lblPhoneInfo.Font = new Font("Segoe UI", 9.5F);
            lblPhoneInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblPhoneInfo.Location = new Point(16, 430);
            lblPhoneInfo.Name = "lblPhoneInfo";
            lblPhoneInfo.Size = new Size(57, 21);
            lblPhoneInfo.TabIndex = 19;
            lblPhoneInfo.Text = "Phone:";
            // 
            // lblAddressInfo
            // 
            lblAddressInfo.AutoSize = true;
            lblAddressInfo.Font = new Font("Segoe UI", 9.5F);
            lblAddressInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblAddressInfo.Location = new Point(16, 464);
            lblAddressInfo.Name = "lblAddressInfo";
            lblAddressInfo.Size = new Size(69, 21);
            lblAddressInfo.TabIndex = 20;
            lblAddressInfo.Text = "Address:";
            // 
            // lblEmailInfo
            // 
            lblEmailInfo.AutoSize = true;
            lblEmailInfo.Font = new Font("Segoe UI", 9.5F);
            lblEmailInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblEmailInfo.Location = new Point(16, 498);
            lblEmailInfo.Name = "lblEmailInfo";
            lblEmailInfo.Size = new Size(51, 21);
            lblEmailInfo.TabIndex = 21;
            lblEmailInfo.Text = "Email:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 9.5F);
            lblID.ForeColor = Color.FromArgb(10, 61, 120);
            lblID.Location = new Point(130, 260);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 21);
            lblID.TabIndex = 6;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI Semibold", 9.5F);
            lblFirstname.ForeColor = Color.FromArgb(10, 61, 120);
            lblFirstname.Location = new Point(130, 294);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(0, 21);
            lblFirstname.TabIndex = 7;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI Semibold", 9.5F);
            lblLastname.ForeColor = Color.FromArgb(10, 61, 120);
            lblLastname.Location = new Point(130, 328);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(0, 21);
            lblLastname.TabIndex = 8;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI Semibold", 9.5F);
            lblDob.ForeColor = Color.FromArgb(10, 61, 120);
            lblDob.Location = new Point(130, 362);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(0, 21);
            lblDob.TabIndex = 9;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9.5F);
            lblGender.ForeColor = Color.FromArgb(10, 61, 120);
            lblGender.Location = new Point(130, 396);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(0, 21);
            lblGender.TabIndex = 10;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9.5F);
            lblPhone.ForeColor = Color.FromArgb(10, 61, 120);
            lblPhone.Location = new Point(130, 430);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 21);
            lblPhone.TabIndex = 11;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9.5F);
            lblAddress.ForeColor = Color.FromArgb(10, 61, 120);
            lblAddress.Location = new Point(130, 464);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(0, 21);
            lblAddress.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.5F);
            lblEmail.ForeColor = Color.FromArgb(10, 61, 120);
            lblEmail.Location = new Point(130, 498);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 21);
            lblEmail.TabIndex = 13;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 17;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btAdd);
            pnlBottom.Controls.Add(btnEdit);
            pnlBottom.Controls.Add(btnViewScore);
            pnlBottom.Controls.Add(btnExport);
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 734);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(1455, 68);
            pnlBottom.TabIndex = 1;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.FromArgb(10, 61, 120);
            btAdd.Cursor = Cursors.Hand;
            btAdd.FlatAppearance.BorderSize = 0;
            btAdd.FlatStyle = FlatStyle.Flat;
            btAdd.Font = new Font("Segoe UI Semibold", 9.5F);
            btAdd.ForeColor = Color.White;
            btAdd.Location = new Point(24, 13);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(120, 42);
            btAdd.TabIndex = 0;
            btAdd.Text = "＋  Add ";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.ForeColor = Color.FromArgb(60, 70, 85);
            btnEdit.Location = new Point(154, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(134, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✎  Edit / Delete";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnViewScore
            // 
            btnViewScore.BackColor = Color.White;
            btnViewScore.Cursor = Cursors.Hand;
            btnViewScore.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnViewScore.FlatStyle = FlatStyle.Flat;
            btnViewScore.Font = new Font("Segoe UI", 9.5F);
            btnViewScore.ForeColor = Color.FromArgb(60, 70, 85);
            btnViewScore.Location = new Point(294, 13);
            btnViewScore.Name = "btnViewScore";
            btnViewScore.Size = new Size(120, 42);
            btnViewScore.TabIndex = 2;
            btnViewScore.Text = "★  View Score";
            btnViewScore.UseVisualStyleBackColor = false;
            btnViewScore.Click += btnViewScore_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9.5F);
            btnExport.ForeColor = Color.FromArgb(60, 70, 85);
            btnExport.Location = new Point(424, 13);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 42);
            btnExport.TabIndex = 3;
            btnExport.Text = "⭳  Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(530, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(122, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Students: 0";
            // 
            // pnlPagination
            // 
            pnlPagination.Controls.Add(cboPageSize);
            pnlPagination.Controls.Add(btnFirst);
            pnlPagination.Controls.Add(btnPrev);
            pnlPagination.Controls.Add(lblPageInfo);
            pnlPagination.Controls.Add(btnNext);
            pnlPagination.Controls.Add(btnLast);
            pnlPagination.Dock = DockStyle.Right;
            pnlPagination.Location = new Point(1051, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 44);
            pnlPagination.TabIndex = 5;
            // 
            // cboPageSize
            // 
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPageSize.Font = new Font("Segoe UI", 9.5F);
            cboPageSize.Location = new Point(10, 19);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(60, 29);
            cboPageSize.TabIndex = 0;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.White;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Segoe UI", 9F);
            btnFirst.ForeColor = Color.FromArgb(60, 70, 85);
            btnFirst.Location = new Point(80, 17);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(36, 32);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "|◀";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.White;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 9F);
            btnPrev.ForeColor = Color.FromArgb(60, 70, 85);
            btnPrev.Location = new Point(120, 17);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◀";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Font = new Font("Segoe UI", 9.5F);
            lblPageInfo.Location = new Point(162, 22);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(120, 20);
            lblPageInfo.TabIndex = 3;
            lblPageInfo.Text = "Page 1 of 1";
            lblPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.FromArgb(60, 70, 85);
            btnNext.Location = new Point(290, 17);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 32);
            btnNext.TabIndex = 4;
            btnNext.Text = "▶";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.White;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Segoe UI", 9F);
            btnLast.ForeColor = Color.FromArgb(60, 70, 85);
            btnLast.Location = new Point(330, 17);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 32);
            btnLast.TabIndex = 5;
            btnLast.Text = "▶|";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // f_ListStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 802);
            Controls.Add(pnlBody);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_ListStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management — Academic System";
            Load += ManageStudent_Load;
            Shown += f_ListStudent_Shown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picContact).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.Label lblIDInfo;
        private System.Windows.Forms.Label lblFirstnameInfo;
        private System.Windows.Forms.Label lblLastnameInfo;
        private System.Windows.Forms.Label lblDobInfo;
        private System.Windows.Forms.Label lblGenderInfo;
        private System.Windows.Forms.Label lblPhoneInfo;
        private System.Windows.Forms.Label lblAddressInfo;
        private System.Windows.Forms.Label lblEmailInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvContacts;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnViewScore;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}