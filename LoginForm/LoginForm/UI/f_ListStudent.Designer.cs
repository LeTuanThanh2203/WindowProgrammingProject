namespace LoginForm
{
    partial class f_ListStudent
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
            dgvStudent = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Lastname = new DataGridViewTextBoxColumn();
            Firstname = new DataGridViewTextBoxColumn();
            Dob = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Hometown = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btAdd = new Button();
            pnMainDataGridView = new Panel();
            cboGender = new ComboBox();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblGender = new Label();
            lblEmail = new Label();
            lblDob = new Label();
            lblLastname = new Label();
            lblFirstname = new Label();
            lblID = new Label();
            lblEmailInfo = new Label();
            lblAddressInfo = new Label();
            lblPhoneInfo = new Label();
            lblGenderInfo = new Label();
            lblDobInfo = new Label();
            lblLastnameInfo = new Label();
            lblFirstnameInfo = new Label();
            lblIDInfo = new Label();
            picStudent = new PictureBox();
            pnFunction = new Panel();
            btnEdit = new Button();
            lblTotal = new Label();
            btnClose = new Button();
            btnRefresh = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            pnMainDataGridView.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            pnFunction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.BackgroundColor = SystemColors.Control;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(291, 43);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(935, 584);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Lastname
            // 
            Lastname.HeaderText = "Lastname";
            Lastname.MinimumWidth = 6;
            Lastname.Name = "Lastname";
            Lastname.Width = 125;
            // 
            // Firstname
            // 
            Firstname.HeaderText = "Firstname";
            Firstname.MinimumWidth = 6;
            Firstname.Name = "Firstname";
            Firstname.Width = 125;
            // 
            // Dob
            // 
            Dob.HeaderText = "Dob";
            Dob.MinimumWidth = 6;
            Dob.Name = "Dob";
            Dob.Width = 125;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Hometown
            // 
            Hometown.HeaderText = "Hometown";
            Hometown.MinimumWidth = 6;
            Hometown.Name = "Hometown";
            Hometown.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 250;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(560, 13);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(124, 40);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add ";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btnAdd_Click;
            // 
            // pnMainDataGridView
            // 
            pnMainDataGridView.Controls.Add(cboGender);
            pnMainDataGridView.Controls.Add(cboSort);
            pnMainDataGridView.Controls.Add(txtSearch);
            pnMainDataGridView.Controls.Add(dgvStudent);
            pnMainDataGridView.Controls.Add(panel1);
            pnMainDataGridView.Dock = DockStyle.Top;
            pnMainDataGridView.Location = new Point(0, 0);
            pnMainDataGridView.Name = "pnMainDataGridView";
            pnMainDataGridView.Size = new Size(1232, 630);
            pnMainDataGridView.TabIndex = 2;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(406, 12);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(97, 28);
            cboGender.TabIndex = 5;
            cboGender.SelectedIndexChanged += cboGender_SelectedIndexChanged;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(296, 11);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(101, 28);
            cboSort.TabIndex = 4;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(513, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(713, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblGender);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblDob);
            panel1.Controls.Add(lblLastname);
            panel1.Controls.Add(lblFirstname);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(lblEmailInfo);
            panel1.Controls.Add(lblAddressInfo);
            panel1.Controls.Add(lblPhoneInfo);
            panel1.Controls.Add(lblGenderInfo);
            panel1.Controls.Add(lblDobInfo);
            panel1.Controls.Add(lblLastnameInfo);
            panel1.Controls.Add(lblFirstnameInfo);
            panel1.Controls.Add(lblIDInfo);
            panel1.Controls.Add(picStudent);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 630);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 303);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 17;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(152, 480);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(0, 25);
            lblAddress.TabIndex = 16;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(152, 449);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 25);
            lblPhone.TabIndex = 15;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(152, 413);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(0, 25);
            lblGender.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(76, 517);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(190, 69);
            lblEmail.TabIndex = 14;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDob.Location = new Point(152, 380);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(0, 25);
            lblDob.TabIndex = 13;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(152, 342);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(0, 25);
            lblLastname.TabIndex = 12;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstname.Location = new Point(152, 306);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(0, 25);
            lblFirstname.TabIndex = 11;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(152, 268);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 25);
            lblID.TabIndex = 10;
            // 
            // lblEmailInfo
            // 
            lblEmailInfo.AutoSize = true;
            lblEmailInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailInfo.Location = new Point(12, 517);
            lblEmailInfo.Name = "lblEmailInfo";
            lblEmailInfo.Size = new Size(58, 25);
            lblEmailInfo.TabIndex = 9;
            lblEmailInfo.Text = "Email";
            // 
            // lblAddressInfo
            // 
            lblAddressInfo.AutoSize = true;
            lblAddressInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressInfo.Location = new Point(12, 480);
            lblAddressInfo.Name = "lblAddressInfo";
            lblAddressInfo.Size = new Size(80, 25);
            lblAddressInfo.TabIndex = 8;
            lblAddressInfo.Text = "Address";
            // 
            // lblPhoneInfo
            // 
            lblPhoneInfo.AutoSize = true;
            lblPhoneInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneInfo.Location = new Point(12, 449);
            lblPhoneInfo.Name = "lblPhoneInfo";
            lblPhoneInfo.Size = new Size(66, 25);
            lblPhoneInfo.TabIndex = 7;
            lblPhoneInfo.Text = "Phone";
            // 
            // lblGenderInfo
            // 
            lblGenderInfo.AutoSize = true;
            lblGenderInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenderInfo.Location = new Point(12, 413);
            lblGenderInfo.Name = "lblGenderInfo";
            lblGenderInfo.Size = new Size(74, 25);
            lblGenderInfo.TabIndex = 6;
            lblGenderInfo.Text = "Gender";
            // 
            // lblDobInfo
            // 
            lblDobInfo.AutoSize = true;
            lblDobInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDobInfo.Location = new Point(12, 380);
            lblDobInfo.Name = "lblDobInfo";
            lblDobInfo.Size = new Size(122, 25);
            lblDobInfo.TabIndex = 5;
            lblDobInfo.Text = "Date of birth";
            // 
            // lblLastnameInfo
            // 
            lblLastnameInfo.AutoSize = true;
            lblLastnameInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastnameInfo.Location = new Point(12, 342);
            lblLastnameInfo.Name = "lblLastnameInfo";
            lblLastnameInfo.Size = new Size(93, 25);
            lblLastnameInfo.TabIndex = 4;
            lblLastnameInfo.Text = "Lastname";
            // 
            // lblFirstnameInfo
            // 
            lblFirstnameInfo.AutoSize = true;
            lblFirstnameInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstnameInfo.Location = new Point(12, 306);
            lblFirstnameInfo.Name = "lblFirstnameInfo";
            lblFirstnameInfo.Size = new Size(95, 25);
            lblFirstnameInfo.TabIndex = 3;
            lblFirstnameInfo.Text = "Firstname";
            // 
            // lblIDInfo
            // 
            lblIDInfo.AutoSize = true;
            lblIDInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDInfo.Location = new Point(12, 268);
            lblIDInfo.Name = "lblIDInfo";
            lblIDInfo.Size = new Size(31, 25);
            lblIDInfo.TabIndex = 2;
            lblIDInfo.Text = "ID";
            // 
            // picStudent
            // 
            picStudent.Location = new Point(26, 21);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(200, 226);
            picStudent.TabIndex = 1;
            picStudent.TabStop = false;
            // 
            // pnFunction
            // 
            pnFunction.Controls.Add(btnEdit);
            pnFunction.Controls.Add(lblTotal);
            pnFunction.Controls.Add(btnClose);
            pnFunction.Controls.Add(btnRefresh);
            pnFunction.Controls.Add(btAdd);
            pnFunction.Dock = DockStyle.Bottom;
            pnFunction.Location = new Point(0, 636);
            pnFunction.Name = "pnFunction";
            pnFunction.Size = new Size(1232, 157);
            pnFunction.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(692, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(294, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Student:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(966, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(822, 13);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(124, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // f_ListStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 793);
            Controls.Add(pnFunction);
            Controls.Add(pnMainDataGridView);
            Name = "f_ListStudent";
            Text = "Student Management";
            Load += ManageStudent_Load;
            Shown += f_ListStudent_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            pnMainDataGridView.ResumeLayout(false);
            pnMainDataGridView.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            pnFunction.ResumeLayout(false);
            pnFunction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudent;
        private Button btAdd;
        private Panel pnMainDataGridView;
        private Panel pnFunction;
        private PictureBox picStudent;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Dob;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Hometown;
        private DataGridViewTextBoxColumn Email;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnClose;
        private Button btnRefresh;
        private Panel panel1;
        private Label lblIDInfo;
        private Label lblFirstnameInfo;
        private Label lblDobInfo;
        private Label lblLastnameInfo;
        private Label lblAddressInfo;
        private Label lblPhoneInfo;
        private Label lblGenderInfo;
        private Label lblEmailInfo;
        private Label lblAddress;
        private Label lblPhone;
        private Label lblGender;
        private Label lblEmail;
        private Label lblDob;
        private Label lblLastname;
        private Label lblFirstname;
        private Label lblID;
        private Label label1;
        private ComboBox cboGender;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private Label lblTotal;
        private Button btnEdit;
    }
}