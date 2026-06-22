namespace LoginForm
{
    partial class f_ContactManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            pnlGroupMgr = new Panel();
            lblGroupMgrTitle = new Label();
            txtGroupName = new TextBox();
            btnAddGroup = new Button();
            pnlToolbar = new Panel();
            txtSearch = new TextBox();
            lblFilterGroup = new Label();
            cboGroup = new ComboBox();
            btnDeleteGroup = new Button();
            pnlGrid = new Panel();
            panel1 = new Panel();
            dgvContacts = new DataGridView();
            pnLeft = new Panel();
            picContact = new PictureBox();
            btnChooseImage = new Button();
            lblFirstName = new Label();
            txtFname = new TextBox();
            lblValidateFirstName = new Label();
            lblLastName = new Label();
            txtLname = new TextBox();
            lblValidateLastName = new Label();
            label4 = new Label();
            dtpDob = new DateTimePicker();
            label5 = new Label();
            cboGender = new ComboBox();
            label6 = new Label();
            txtPhone = new TextBox();
            lblValidatePhone = new Label();
            label9 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            lblContactGroup = new Label();
            cboContactGroup = new ComboBox();
            lblValidateID = new Label();
            pnlBottom = new Panel();
            btAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblTotal = new Label();
            pnlPagination = new Panel();
            cboPageSize = new ComboBox();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            pnlHeader.SuspendLayout();
            pnlGroupMgr.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGrid.SuspendLayout();
            panel1.SuspendLayout();
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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1257, 96);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(23, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Contact Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(25, 56);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(183, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage personal contacts";
            // 
            // pnlGroupMgr
            // 
            pnlGroupMgr.BackColor = Color.FromArgb(235, 240, 250);
            pnlGroupMgr.Controls.Add(lblGroupMgrTitle);
            pnlGroupMgr.Controls.Add(txtGroupName);
            pnlGroupMgr.Controls.Add(btnAddGroup);
            pnlGroupMgr.Dock = DockStyle.Top;
            pnlGroupMgr.Location = new Point(0, 96);
            pnlGroupMgr.Margin = new Padding(3, 4, 3, 4);
            pnlGroupMgr.Name = "pnlGroupMgr";
            pnlGroupMgr.Padding = new Padding(18, 11, 18, 11);
            pnlGroupMgr.Size = new Size(1257, 67);
            pnlGroupMgr.TabIndex = 1;
            // 
            // lblGroupMgrTitle
            // 
            lblGroupMgrTitle.AutoSize = true;
            lblGroupMgrTitle.Font = new Font("Segoe UI Semibold", 9.5F);
            lblGroupMgrTitle.ForeColor = Color.FromArgb(10, 61, 120);
            lblGroupMgrTitle.Location = new Point(21, 19);
            lblGroupMgrTitle.Name = "lblGroupMgrTitle";
            lblGroupMgrTitle.Size = new Size(97, 21);
            lblGroupMgrTitle.TabIndex = 0;
            lblGroupMgrTitle.Text = "New Group:";
            // 
            // txtGroupName
            // 
            txtGroupName.Font = new Font("Segoe UI", 9.5F);
            txtGroupName.Location = new Point(126, 15);
            txtGroupName.Margin = new Padding(3, 4, 3, 4);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.PlaceholderText = "Group name…";
            txtGroupName.Size = new Size(251, 29);
            txtGroupName.TabIndex = 1;
            // 
            // btnAddGroup
            // 
            btnAddGroup.BackColor = Color.FromArgb(10, 61, 120);
            btnAddGroup.Cursor = Cursors.Hand;
            btnAddGroup.FlatAppearance.BorderSize = 0;
            btnAddGroup.FlatStyle = FlatStyle.Flat;
            btnAddGroup.Font = new Font("Segoe UI Semibold", 9F);
            btnAddGroup.ForeColor = Color.White;
            btnAddGroup.Location = new Point(389, 11);
            btnAddGroup.Margin = new Padding(3, 4, 3, 4);
            btnAddGroup.Name = "btnAddGroup";
            btnAddGroup.Size = new Size(126, 43);
            btnAddGroup.TabIndex = 2;
            btnAddGroup.Text = "＋ Add Group";
            btnAddGroup.UseVisualStyleBackColor = false;
            btnAddGroup.Click += btnAddGroup_Click;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(lblFilterGroup);
            pnlToolbar.Controls.Add(cboGroup);
            pnlToolbar.Controls.Add(btnDeleteGroup);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 163);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(18, 13, 18, 8);
            pnlToolbar.Size = new Size(1257, 69);
            pnlToolbar.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(526, 17);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by name, phone, email…";
            txtSearch.Size = new Size(411, 29);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblFilterGroup
            // 
            lblFilterGroup.AutoSize = true;
            lblFilterGroup.Font = new Font("Segoe UI", 9.5F);
            lblFilterGroup.ForeColor = Color.FromArgb(80, 80, 90);
            lblFilterGroup.Location = new Point(21, 21);
            lblFilterGroup.Name = "lblFilterGroup";
            lblFilterGroup.Size = new Size(96, 21);
            lblFilterGroup.TabIndex = 0;
            lblFilterGroup.Text = "Filter Group:";
            // 
            // cboGroup
            // 
            cboGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGroup.Font = new Font("Segoe UI", 9.5F);
            cboGroup.Location = new Point(126, 16);
            cboGroup.Margin = new Padding(3, 4, 3, 4);
            cboGroup.Name = "cboGroup";
            cboGroup.Size = new Size(228, 29);
            cboGroup.TabIndex = 1;
            cboGroup.SelectedIndexChanged += cboGroup_SelectedIndexChanged;
            // 
            // btnDeleteGroup
            // 
            btnDeleteGroup.BackColor = Color.FromArgb(200, 40, 40);
            btnDeleteGroup.Cursor = Cursors.Hand;
            btnDeleteGroup.FlatAppearance.BorderSize = 0;
            btnDeleteGroup.FlatStyle = FlatStyle.Flat;
            btnDeleteGroup.Font = new Font("Segoe UI", 9F);
            btnDeleteGroup.ForeColor = Color.White;
            btnDeleteGroup.Location = new Point(366, 12);
            btnDeleteGroup.Margin = new Padding(3, 4, 3, 4);
            btnDeleteGroup.Name = "btnDeleteGroup";
            btnDeleteGroup.Size = new Size(126, 40);
            btnDeleteGroup.TabIndex = 2;
            btnDeleteGroup.Text = "🗑 Del Group";
            btnDeleteGroup.UseVisualStyleBackColor = false;
            btnDeleteGroup.Click += btnDeleteGroup_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(panel1);
            pnlGrid.Controls.Add(pnLeft);
            pnlGrid.Controls.Add(pnlBottom);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 232);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14, 13, 14, 8);
            pnlGrid.Size = new Size(1257, 781);
            pnlGrid.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvContacts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(448, 13);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 11, 11, 8);
            panel1.Size = new Size(795, 675);
            panel1.TabIndex = 1;
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToResizeColumns = false;
            dgvContacts.AllowUserToResizeRows = false;
            dgvContacts.ColumnHeadersHeight = 32;
            dgvContacts.Dock = DockStyle.Fill;
            dgvContacts.Location = new Point(11, 11);
            dgvContacts.Margin = new Padding(3, 4, 3, 4);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.RowHeadersWidth = 51;
            dgvContacts.Size = new Size(773, 656);
            dgvContacts.TabIndex = 0;
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.White;
            pnLeft.Controls.Add(picContact);
            pnLeft.Controls.Add(btnChooseImage);
            pnLeft.Controls.Add(lblFirstName);
            pnLeft.Controls.Add(txtFname);
            pnLeft.Controls.Add(lblValidateFirstName);
            pnLeft.Controls.Add(lblLastName);
            pnLeft.Controls.Add(txtLname);
            pnLeft.Controls.Add(lblValidateLastName);
            pnLeft.Controls.Add(label4);
            pnLeft.Controls.Add(dtpDob);
            pnLeft.Controls.Add(label5);
            pnLeft.Controls.Add(cboGender);
            pnLeft.Controls.Add(label6);
            pnLeft.Controls.Add(txtPhone);
            pnLeft.Controls.Add(lblValidatePhone);
            pnLeft.Controls.Add(label9);
            pnLeft.Controls.Add(txtEmail);
            pnLeft.Controls.Add(label7);
            pnLeft.Controls.Add(txtAddress);
            pnLeft.Controls.Add(lblContactGroup);
            pnLeft.Controls.Add(cboContactGroup);
            pnLeft.Controls.Add(lblValidateID);
            pnLeft.AutoScroll = true;
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(14, 13);
            pnLeft.Margin = new Padding(3, 4, 3, 4);
            pnLeft.Name = "pnLeft";
            pnLeft.Padding = new Padding(18, 16, 18, 11);
            pnLeft.Size = new Size(434, 675);
            pnLeft.TabIndex = 0;
            // 
            // picContact
            // 
            // picContact — thu nhỏ để tiết kiệm không gian dọc
            picContact.BorderStyle = BorderStyle.FixedSingle;
            picContact.Location = new Point(127, 8);
            picContact.Margin = new Padding(3, 4, 3, 4);
            picContact.Name = "picContact";
            picContact.Size = new Size(120, 120);
            picContact.SizeMode = PictureBoxSizeMode.StretchImage;
            picContact.TabIndex = 0;
            picContact.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.FromArgb(10, 61, 120);
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Segoe UI", 9.5F);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.Location = new Point(100, 136);
            btnChooseImage.Margin = new Padding(3, 4, 3, 4);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(176, 34);
            btnChooseImage.TabIndex = 1;
            btnChooseImage.Text = "📷 Upload Photo";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.5F);
            lblFirstName.ForeColor = Color.FromArgb(70, 70, 80);
            lblFirstName.Location = new Point(18, 184);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 21);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Segoe UI", 10F);
            txtFname.Location = new Point(149, 180);
            txtFname.Margin = new Padding(3, 4, 3, 4);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(251, 30);
            txtFname.TabIndex = 3;
            // 
            // lblValidateFirstName
            // 
            lblValidateFirstName.AutoSize = true;
            lblValidateFirstName.Font = new Font("Segoe UI", 8F);
            lblValidateFirstName.ForeColor = Color.Red;
            lblValidateFirstName.Location = new Point(149, 213);
            lblValidateFirstName.Name = "lblValidateFirstName";
            lblValidateFirstName.Size = new Size(0, 19);
            lblValidateFirstName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.5F);
            lblLastName.ForeColor = Color.FromArgb(70, 70, 80);
            lblLastName.Location = new Point(18, 238);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 21);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtLname
            // 
            txtLname.Font = new Font("Segoe UI", 10F);
            txtLname.Location = new Point(149, 234);
            txtLname.Margin = new Padding(3, 4, 3, 4);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(251, 30);
            txtLname.TabIndex = 6;
            // 
            // lblValidateLastName
            // 
            lblValidateLastName.AutoSize = true;
            lblValidateLastName.Font = new Font("Segoe UI", 8F);
            lblValidateLastName.ForeColor = Color.Red;
            lblValidateLastName.Location = new Point(149, 267);
            lblValidateLastName.Name = "lblValidateLastName";
            lblValidateLastName.Size = new Size(0, 19);
            lblValidateLastName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F);
            label4.ForeColor = Color.FromArgb(70, 70, 80);
            label4.Location = new Point(18, 292);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 8;
            label4.Text = "Date of Birth";
            // 
            // dtpDob
            // 
            dtpDob.Font = new Font("Segoe UI", 10F);
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(149, 288);
            dtpDob.Margin = new Padding(3, 4, 3, 4);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(251, 30);
            dtpDob.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F);
            label5.ForeColor = Color.FromArgb(70, 70, 80);
            label5.Location = new Point(18, 332);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 10;
            label5.Text = "Gender";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 10F);
            cboGender.Location = new Point(149, 328);
            cboGender.Margin = new Padding(3, 4, 3, 4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(251, 31);
            cboGender.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F);
            label6.ForeColor = Color.FromArgb(70, 70, 80);
            label6.Location = new Point(18, 373);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(149, 369);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.MaxLength = 15;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(251, 30);
            txtPhone.TabIndex = 13;
            // 
            // lblValidatePhone
            // 
            lblValidatePhone.AutoSize = true;
            lblValidatePhone.Font = new Font("Segoe UI", 8F);
            lblValidatePhone.ForeColor = Color.Red;
            lblValidatePhone.Location = new Point(149, 402);
            lblValidatePhone.Name = "lblValidatePhone";
            lblValidatePhone.Size = new Size(0, 19);
            lblValidatePhone.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.5F);
            label9.ForeColor = Color.FromArgb(70, 70, 80);
            label9.Location = new Point(18, 425);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 15;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(149, 421);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 30);
            txtEmail.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F);
            label7.ForeColor = Color.FromArgb(70, 70, 80);
            label7.Location = new Point(18, 461);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 17;
            label7.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(149, 457);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(251, 30);
            txtAddress.TabIndex = 18;
            // 
            // lblContactGroup
            // 
            lblContactGroup.AutoSize = true;
            lblContactGroup.Font = new Font("Segoe UI", 9.5F);
            lblContactGroup.ForeColor = Color.FromArgb(70, 70, 80);
            lblContactGroup.Location = new Point(18, 501);
            lblContactGroup.Name = "lblContactGroup";
            lblContactGroup.Size = new Size(54, 21);
            lblContactGroup.TabIndex = 19;
            lblContactGroup.Text = "Group";
            // 
            // cboContactGroup
            // 
            cboContactGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cboContactGroup.Font = new Font("Segoe UI", 10F);
            cboContactGroup.Location = new Point(149, 497);
            cboContactGroup.Margin = new Padding(3, 4, 3, 4);
            cboContactGroup.Name = "cboContactGroup";
            cboContactGroup.Size = new Size(251, 31);
            cboContactGroup.TabIndex = 20;
            cboContactGroup.SelectedIndexChanged += cboContactGroup_SelectedIndexChanged;
            // 
            // lblValidateID
            // 
            lblValidateID.AutoSize = true;
            lblValidateID.Font = new Font("Segoe UI", 8F);
            lblValidateID.ForeColor = Color.Red;
            lblValidateID.Location = new Point(149, 531);
            lblValidateID.Name = "lblValidateID";
            lblValidateID.Size = new Size(0, 19);
            lblValidateID.TabIndex = 21;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btAdd);
            pnlBottom.Controls.Add(btnEdit);
            pnlBottom.Controls.Add(btnDelete);
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(14, 688);
            pnlBottom.Margin = new Padding(3, 4, 3, 4);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(18, 13, 18, 13);
            pnlBottom.Size = new Size(1229, 85);
            pnlBottom.TabIndex = 2;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.FromArgb(10, 61, 120);
            btAdd.Cursor = Cursors.Hand;
            btAdd.FlatAppearance.BorderSize = 0;
            btAdd.FlatStyle = FlatStyle.Flat;
            btAdd.Font = new Font("Segoe UI Semibold", 9.5F);
            btAdd.ForeColor = Color.White;
            btAdd.Location = new Point(21, 16);
            btAdd.Margin = new Padding(3, 4, 3, 4);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(126, 53);
            btAdd.TabIndex = 0;
            btAdd.Text = "＋  Add";
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
            btnEdit.Location = new Point(158, 16);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 53);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✎  Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 50, 50);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(295, 16);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 53);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑  Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(560, 31);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Records: 0";
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
            pnlPagination.Location = new Point(800, 13);
            pnlPagination.Margin = new Padding(3, 4, 3, 4);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(411, 59);
            pnlPagination.TabIndex = 5;
            // 
            // cboPageSize
            // 
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPageSize.Font = new Font("Segoe UI", 9.5F);
            cboPageSize.Location = new Point(9, 11);
            cboPageSize.Margin = new Padding(3, 4, 3, 4);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(68, 29);
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
            btnFirst.Location = new Point(87, 8);
            btnFirst.Margin = new Padding(3, 4, 3, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(41, 43);
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
            btnPrev.Location = new Point(133, 8);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(41, 43);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◀";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Font = new Font("Segoe UI", 9.5F);
            lblPageInfo.Location = new Point(181, 13);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(114, 27);
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
            btnNext.Location = new Point(302, 8);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(41, 43);
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
            btnLast.Location = new Point(347, 8);
            btnLast.Margin = new Padding(3, 4, 3, 4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(41, 43);
            btnLast.TabIndex = 5;
            btnLast.Text = "▶|";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // f_ContactManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 1013);
            Controls.Add(pnlGrid);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlGroupMgr);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "f_ContactManage";
            Text = "Contact Management";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlGroupMgr.ResumeLayout(false);
            pnlGroupMgr.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGrid.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlGroupMgr;
        private System.Windows.Forms.Label lblGroupMgrTitle;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterGroup;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblValidateFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblValidateLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblValidatePhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblContactGroup;
        private System.Windows.Forms.ComboBox cboContactGroup;
        private System.Windows.Forms.Label lblValidateID;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
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