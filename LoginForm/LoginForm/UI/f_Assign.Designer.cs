namespace LoginForm
{
    partial class f_Assign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlHR = new Panel();
            lblHR_Title = new Label();
            lblHR_ID = new Label();
            txtHR_ID = new TextBox();
            lblHR_FirstName = new Label();
            txtHR_FirstName = new TextBox();
            lblHR_LastName = new Label();
            txtHR_LastName = new TextBox();
            lblHR_Dob = new Label();
            dtpHR_Dob = new DateTimePicker();
            lblHR_Gender = new Label();
            cboHR_Gender = new ComboBox();
            lblHR_Phone = new Label();
            txtHR_Phone = new TextBox();
            lblHR_Email = new Label();
            txtHR_Email = new TextBox();
            lblHR_Address = new Label();
            txtHR_Address = new TextBox();
            picHR_Photo = new PictureBox();
            btnHR_Upload = new Button();
            btnHR_Add = new Button();
            btnHR_Edit = new Button();
            btnHR_Delete = new Button();
            btnHR_Clear = new Button();
            pnlRight = new Panel();
            pnlGrid = new Panel();
            dgvAssign = new DataGridView();
            pnlToolbar = new Panel();
            btnAssign = new Button();
            btnDelete = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSearchCourse = new TextBox();
            txtSearchHR = new TextBox();
            cboHR = new ComboBox();
            cboCourse = new ComboBox();
            pnlBottom = new Panel();
            lblTotal = new Label();
            pnlPagination = new Panel();
            cboPageSize = new ComboBox();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            pnlHeader.SuspendLayout();
            pnlHR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHR_Photo).BeginInit();
            pnlRight.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssign).BeginInit();
            pnlToolbar.SuspendLayout();
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
            pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(281, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Assign Course For HR";
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
            // pnlHR
            // 
            pnlHR.BackColor = Color.White;
            pnlHR.Controls.Add(lblHR_Title);
            pnlHR.Controls.Add(lblHR_ID);
            pnlHR.Controls.Add(txtHR_ID);
            pnlHR.Controls.Add(lblHR_FirstName);
            pnlHR.Controls.Add(txtHR_FirstName);
            pnlHR.Controls.Add(lblHR_LastName);
            pnlHR.Controls.Add(txtHR_LastName);
            pnlHR.Controls.Add(lblHR_Dob);
            pnlHR.Controls.Add(dtpHR_Dob);
            pnlHR.Controls.Add(lblHR_Gender);
            pnlHR.Controls.Add(cboHR_Gender);
            pnlHR.Controls.Add(lblHR_Phone);
            pnlHR.Controls.Add(txtHR_Phone);
            pnlHR.Controls.Add(lblHR_Email);
            pnlHR.Controls.Add(txtHR_Email);
            pnlHR.Controls.Add(lblHR_Address);
            pnlHR.Controls.Add(txtHR_Address);
            pnlHR.Controls.Add(picHR_Photo);
            pnlHR.Controls.Add(btnHR_Upload);
            pnlHR.Controls.Add(btnHR_Add);
            pnlHR.Controls.Add(btnHR_Edit);
            pnlHR.Controls.Add(btnHR_Delete);
            pnlHR.Controls.Add(btnHR_Clear);
            pnlHR.Dock = DockStyle.Left;
            pnlHR.Location = new Point(0, 80);
            pnlHR.Name = "pnlHR";
            pnlHR.Size = new Size(440, 722);
            pnlHR.TabIndex = 8;
            // 
            // lblHR_Title
            // 
            lblHR_Title.AutoSize = true;
            lblHR_Title.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblHR_Title.ForeColor = Color.FromArgb(10, 61, 120);
            lblHR_Title.Location = new Point(16, 12);
            lblHR_Title.Name = "lblHR_Title";
            lblHR_Title.Size = new Size(183, 32);
            lblHR_Title.TabIndex = 0;
            lblHR_Title.Text = "HR Information";
            // 
            // lblHR_ID
            // 
            lblHR_ID.AutoSize = true;
            lblHR_ID.Font = new Font("Segoe UI", 9.5F);
            lblHR_ID.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_ID.Location = new Point(16, 50);
            lblHR_ID.Name = "lblHR_ID";
            lblHR_ID.Size = new Size(50, 21);
            lblHR_ID.TabIndex = 1;
            lblHR_ID.Text = "HR ID";
            // 
            // txtHR_ID
            // 
            txtHR_ID.BorderStyle = BorderStyle.FixedSingle;
            txtHR_ID.Font = new Font("Segoe UI", 9.5F);
            txtHR_ID.Location = new Point(16, 75);
            txtHR_ID.Name = "txtHR_ID";
            txtHR_ID.Size = new Size(260, 29);
            txtHR_ID.TabIndex = 2;
            // 
            // lblHR_FirstName
            // 
            lblHR_FirstName.AutoSize = true;
            lblHR_FirstName.Font = new Font("Segoe UI", 9.5F);
            lblHR_FirstName.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_FirstName.Location = new Point(16, 110);
            lblHR_FirstName.Name = "lblHR_FirstName";
            lblHR_FirstName.Size = new Size(86, 21);
            lblHR_FirstName.TabIndex = 3;
            lblHR_FirstName.Text = "First Name";
            // 
            // txtHR_FirstName
            // 
            txtHR_FirstName.BorderStyle = BorderStyle.FixedSingle;
            txtHR_FirstName.Font = new Font("Segoe UI", 9.5F);
            txtHR_FirstName.Location = new Point(16, 135);
            txtHR_FirstName.Name = "txtHR_FirstName";
            txtHR_FirstName.Size = new Size(260, 29);
            txtHR_FirstName.TabIndex = 4;
            // 
            // lblHR_LastName
            // 
            lblHR_LastName.AutoSize = true;
            lblHR_LastName.Font = new Font("Segoe UI", 9.5F);
            lblHR_LastName.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_LastName.Location = new Point(16, 170);
            lblHR_LastName.Name = "lblHR_LastName";
            lblHR_LastName.Size = new Size(84, 21);
            lblHR_LastName.TabIndex = 5;
            lblHR_LastName.Text = "Last Name";
            // 
            // txtHR_LastName
            // 
            txtHR_LastName.BorderStyle = BorderStyle.FixedSingle;
            txtHR_LastName.Font = new Font("Segoe UI", 9.5F);
            txtHR_LastName.Location = new Point(16, 195);
            txtHR_LastName.Name = "txtHR_LastName";
            txtHR_LastName.Size = new Size(260, 29);
            txtHR_LastName.TabIndex = 6;
            // 
            // lblHR_Dob
            // 
            lblHR_Dob.AutoSize = true;
            lblHR_Dob.Font = new Font("Segoe UI", 9.5F);
            lblHR_Dob.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_Dob.Location = new Point(16, 250);
            lblHR_Dob.Name = "lblHR_Dob";
            lblHR_Dob.Size = new Size(97, 21);
            lblHR_Dob.TabIndex = 7;
            lblHR_Dob.Text = "Date of Birth";
            // 
            // dtpHR_Dob
            // 
            dtpHR_Dob.Font = new Font("Segoe UI", 9.5F);
            dtpHR_Dob.Format = DateTimePickerFormat.Short;
            dtpHR_Dob.Location = new Point(16, 275);
            dtpHR_Dob.Name = "dtpHR_Dob";
            dtpHR_Dob.Size = new Size(414, 29);
            dtpHR_Dob.TabIndex = 8;
            // 
            // lblHR_Gender
            // 
            lblHR_Gender.AutoSize = true;
            lblHR_Gender.Font = new Font("Segoe UI", 9.5F);
            lblHR_Gender.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_Gender.Location = new Point(16, 310);
            lblHR_Gender.Name = "lblHR_Gender";
            lblHR_Gender.Size = new Size(61, 21);
            lblHR_Gender.TabIndex = 9;
            lblHR_Gender.Text = "Gender";
            // 
            // cboHR_Gender
            // 
            cboHR_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHR_Gender.Font = new Font("Segoe UI", 9.5F);
            cboHR_Gender.FormattingEnabled = true;
            cboHR_Gender.Location = new Point(16, 335);
            cboHR_Gender.Name = "cboHR_Gender";
            cboHR_Gender.Size = new Size(414, 29);
            cboHR_Gender.TabIndex = 10;
            // 
            // lblHR_Phone
            // 
            lblHR_Phone.AutoSize = true;
            lblHR_Phone.Font = new Font("Segoe UI", 9.5F);
            lblHR_Phone.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_Phone.Location = new Point(16, 370);
            lblHR_Phone.Name = "lblHR_Phone";
            lblHR_Phone.Size = new Size(54, 21);
            lblHR_Phone.TabIndex = 11;
            lblHR_Phone.Text = "Phone";
            // 
            // txtHR_Phone
            // 
            txtHR_Phone.BorderStyle = BorderStyle.FixedSingle;
            txtHR_Phone.Font = new Font("Segoe UI", 9.5F);
            txtHR_Phone.Location = new Point(16, 395);
            txtHR_Phone.Name = "txtHR_Phone";
            txtHR_Phone.Size = new Size(414, 29);
            txtHR_Phone.TabIndex = 12;
            // 
            // lblHR_Email
            // 
            lblHR_Email.AutoSize = true;
            lblHR_Email.Font = new Font("Segoe UI", 9.5F);
            lblHR_Email.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_Email.Location = new Point(16, 430);
            lblHR_Email.Name = "lblHR_Email";
            lblHR_Email.Size = new Size(48, 21);
            lblHR_Email.TabIndex = 13;
            lblHR_Email.Text = "Email";
            // 
            // txtHR_Email
            // 
            txtHR_Email.BorderStyle = BorderStyle.FixedSingle;
            txtHR_Email.Font = new Font("Segoe UI", 9.5F);
            txtHR_Email.Location = new Point(16, 455);
            txtHR_Email.Name = "txtHR_Email";
            txtHR_Email.Size = new Size(414, 29);
            txtHR_Email.TabIndex = 14;
            // 
            // lblHR_Address
            // 
            lblHR_Address.AutoSize = true;
            lblHR_Address.Font = new Font("Segoe UI", 9.5F);
            lblHR_Address.ForeColor = Color.FromArgb(80, 80, 90);
            lblHR_Address.Location = new Point(16, 490);
            lblHR_Address.Name = "lblHR_Address";
            lblHR_Address.Size = new Size(66, 21);
            lblHR_Address.TabIndex = 15;
            lblHR_Address.Text = "Address";
            // 
            // txtHR_Address
            // 
            txtHR_Address.BorderStyle = BorderStyle.FixedSingle;
            txtHR_Address.Font = new Font("Segoe UI", 9.5F);
            txtHR_Address.Location = new Point(16, 515);
            txtHR_Address.Name = "txtHR_Address";
            txtHR_Address.Size = new Size(414, 29);
            txtHR_Address.TabIndex = 16;
            // 
            // picHR_Photo
            // 
            picHR_Photo.BackColor = Color.FromArgb(235, 240, 248);
            picHR_Photo.BorderStyle = BorderStyle.FixedSingle;
            picHR_Photo.Location = new Point(300, 50);
            picHR_Photo.Name = "picHR_Photo";
            picHR_Photo.Size = new Size(130, 150);
            picHR_Photo.SizeMode = PictureBoxSizeMode.StretchImage;
            picHR_Photo.TabIndex = 17;
            picHR_Photo.TabStop = false;
            // 
            // btnHR_Upload
            // 
            btnHR_Upload.BackColor = Color.FromArgb(240, 240, 240);
            btnHR_Upload.FlatStyle = FlatStyle.Flat;
            btnHR_Upload.Font = new Font("Segoe UI", 9F);
            btnHR_Upload.Location = new Point(300, 206);
            btnHR_Upload.Name = "btnHR_Upload";
            btnHR_Upload.Size = new Size(130, 32);
            btnHR_Upload.TabIndex = 18;
            btnHR_Upload.Text = "Upload Photo";
            btnHR_Upload.UseVisualStyleBackColor = false;
            btnHR_Upload.Click += btnHR_Upload_Click;
            // 
            // btnHR_Add
            // 
            btnHR_Add.BackColor = Color.FromArgb(10, 61, 120);
            btnHR_Add.Cursor = Cursors.Hand;
            btnHR_Add.FlatAppearance.BorderSize = 0;
            btnHR_Add.FlatStyle = FlatStyle.Flat;
            btnHR_Add.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHR_Add.ForeColor = Color.White;
            btnHR_Add.Location = new Point(16, 580);
            btnHR_Add.Name = "btnHR_Add";
            btnHR_Add.Size = new Size(95, 40);
            btnHR_Add.TabIndex = 19;
            btnHR_Add.Text = "Add";
            btnHR_Add.UseVisualStyleBackColor = false;
            btnHR_Add.Click += btnHR_Add_Click;
            // 
            // btnHR_Edit
            // 
            btnHR_Edit.BackColor = Color.FromArgb(50, 130, 100);
            btnHR_Edit.Cursor = Cursors.Hand;
            btnHR_Edit.FlatAppearance.BorderSize = 0;
            btnHR_Edit.FlatStyle = FlatStyle.Flat;
            btnHR_Edit.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHR_Edit.ForeColor = Color.White;
            btnHR_Edit.Location = new Point(121, 580);
            btnHR_Edit.Name = "btnHR_Edit";
            btnHR_Edit.Size = new Size(95, 40);
            btnHR_Edit.TabIndex = 20;
            btnHR_Edit.Text = "Edit";
            btnHR_Edit.UseVisualStyleBackColor = false;
            btnHR_Edit.Click += btnHR_Edit_Click;
            // 
            // btnHR_Delete
            // 
            btnHR_Delete.BackColor = Color.FromArgb(220, 50, 50);
            btnHR_Delete.Cursor = Cursors.Hand;
            btnHR_Delete.FlatAppearance.BorderSize = 0;
            btnHR_Delete.FlatStyle = FlatStyle.Flat;
            btnHR_Delete.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHR_Delete.ForeColor = Color.White;
            btnHR_Delete.Location = new Point(226, 580);
            btnHR_Delete.Name = "btnHR_Delete";
            btnHR_Delete.Size = new Size(95, 40);
            btnHR_Delete.TabIndex = 21;
            btnHR_Delete.Text = "Delete";
            btnHR_Delete.UseVisualStyleBackColor = false;
            btnHR_Delete.Click += btnHR_Delete_Click;
            // 
            // btnHR_Clear
            // 
            btnHR_Clear.BackColor = Color.Gray;
            btnHR_Clear.Cursor = Cursors.Hand;
            btnHR_Clear.FlatAppearance.BorderSize = 0;
            btnHR_Clear.FlatStyle = FlatStyle.Flat;
            btnHR_Clear.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHR_Clear.ForeColor = Color.White;
            btnHR_Clear.Location = new Point(331, 580);
            btnHR_Clear.Name = "btnHR_Clear";
            btnHR_Clear.Size = new Size(99, 40);
            btnHR_Clear.TabIndex = 22;
            btnHR_Clear.Text = "Clear";
            btnHR_Clear.UseVisualStyleBackColor = false;
            btnHR_Clear.Click += btnHR_Clear_Click;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(pnlGrid);
            pnlRight.Controls.Add(pnlToolbar);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(440, 80);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1015, 722);
            pnlRight.TabIndex = 9;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(dgvAssign);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 120);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(16, 12, 16, 8);
            pnlGrid.Size = new Size(1015, 602);
            pnlGrid.TabIndex = 6;
            // 
            // dgvAssign
            // 
            dgvAssign.AllowUserToResizeColumns = false;
            dgvAssign.AllowUserToResizeRows = false;
            dgvAssign.ColumnHeadersHeight = 29;
            dgvAssign.Dock = DockStyle.Fill;
            dgvAssign.Location = new Point(16, 12);
            dgvAssign.Name = "dgvAssign";
            dgvAssign.RowHeadersWidth = 51;
            dgvAssign.Size = new Size(983, 582);
            dgvAssign.TabIndex = 0;
            dgvAssign.CellClick += dgvAssign_CellClick;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(btnAssign);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Controls.Add(label2);
            pnlToolbar.Controls.Add(label1);
            pnlToolbar.Controls.Add(txtSearchCourse);
            pnlToolbar.Controls.Add(txtSearchHR);
            pnlToolbar.Controls.Add(cboHR);
            pnlToolbar.Controls.Add(cboCourse);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 0);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(16, 12, 16, 8);
            pnlToolbar.Size = new Size(1015, 120);
            pnlToolbar.TabIndex = 5;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(10, 61, 120);
            btnAssign.Cursor = Cursors.Hand;
            btnAssign.FlatAppearance.BorderSize = 0;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI Semibold", 9F);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(726, 7);
            btnAssign.Margin = new Padding(3, 4, 3, 4);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(120, 42);
            btnAssign.TabIndex = 9;
            btnAssign.Text = "✎  Assign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 50, 50);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(726, 56);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 42);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "🗑  Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 61, 120);
            label2.Location = new Point(21, 54);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 7;
            label2.Text = "Choose Course";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 61, 120);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 6;
            label1.Text = "Choose HR";
            // 
            // txtSearchCourse
            // 
            txtSearchCourse.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCourse.Font = new Font("Segoe UI", 9.5F);
            txtSearchCourse.Location = new Point(175, 57);
            txtSearchCourse.Name = "txtSearchCourse";
            txtSearchCourse.PlaceholderText = "Search by ID Course";
            txtSearchCourse.Size = new Size(380, 29);
            txtSearchCourse.TabIndex = 5;
            txtSearchCourse.TextChanged += txtSearchCourse_TextChanged;
            // 
            // txtSearchHR
            // 
            txtSearchHR.BorderStyle = BorderStyle.FixedSingle;
            txtSearchHR.Font = new Font("Segoe UI", 9.5F);
            txtSearchHR.Location = new Point(175, 16);
            txtSearchHR.Name = "txtSearchHR";
            txtSearchHR.PlaceholderText = "Search by ID HR";
            txtSearchHR.Size = new Size(380, 29);
            txtSearchHR.TabIndex = 0;
            txtSearchHR.TextChanged += txtSearchHR_TextChanged;
            // 
            // cboHR
            // 
            cboHR.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHR.Font = new Font("Segoe UI", 9.5F);
            cboHR.Location = new Point(561, 16);
            cboHR.Name = "cboHR";
            cboHR.Size = new Size(158, 29);
            cboHR.TabIndex = 1;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 9.5F);
            cboCourse.Location = new Point(561, 56);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(158, 29);
            cboCourse.TabIndex = 2;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(440, 732);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(1015, 70);
            pnlBottom.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(618, 12);
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
            pnlPagination.Location = new Point(611, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 46);
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
            // f_Assign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 802);
            Controls.Add(pnlBottom);
            Controls.Add(pnlRight);
            Controls.Add(pnlHR);
            Controls.Add(pnlHeader);
            Name = "f_Assign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Assign";
            Load += f_Assign_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlHR.ResumeLayout(false);
            pnlHR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHR_Photo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssign).EndInit();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlHR;
        private Label lblHR_Title;
        private Label lblHR_ID;
        private TextBox txtHR_ID;
        private Label lblHR_FirstName;
        private TextBox txtHR_FirstName;
        private Label lblHR_LastName;
        private TextBox txtHR_LastName;
        private Label lblHR_Dob;
        private DateTimePicker dtpHR_Dob;
        private Label lblHR_Gender;
        private ComboBox cboHR_Gender;
        private Label lblHR_Phone;
        private TextBox txtHR_Phone;
        private Label lblHR_Email;
        private TextBox txtHR_Email;
        private Label lblHR_Address;
        private TextBox txtHR_Address;
        private PictureBox picHR_Photo;
        private Button btnHR_Upload;
        private Button btnHR_Add;
        private Button btnHR_Edit;
        private Button btnHR_Delete;
        private Button btnHR_Clear;
        private Panel pnlRight;
        private Panel pnlToolbar;
        private ComboBox cboHR;
        private ComboBox cboCourse;
        private Panel pnlGrid;
        private DataGridView dgvAssign;
        private Panel pnlBottom;
        private Label lblTotal;
        private Panel pnlPagination;
        private ComboBox cboPageSize;
        private Button btnFirst;
        private Button btnPrev;
        private Label lblPageInfo;
        private Button btnNext;
        private Button btnLast;
        private TextBox txtSearchHR;
        private Label label1;
        private TextBox txtSearchCourse;
        private Label label2;
        private Button btnDelete;
        private Button btnAssign;
    }
}