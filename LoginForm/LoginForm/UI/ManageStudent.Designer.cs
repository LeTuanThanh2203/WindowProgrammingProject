namespace LoginForm
{
    partial class ManageStudent
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
            picStudent = new PictureBox();
            pnFunction = new Panel();
            btnClose = new Button();
            btnRefresh = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            pnMainDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            pnFunction.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.BackgroundColor = SystemColors.Control;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(209, 46);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(1292, 414);
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
            btAdd.Location = new Point(909, 13);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(124, 40);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add ";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btnAdd_Click;
            // 
            // pnMainDataGridView
            // 
            pnMainDataGridView.Controls.Add(picStudent);
            pnMainDataGridView.Controls.Add(dgvStudent);
            pnMainDataGridView.Dock = DockStyle.Top;
            pnMainDataGridView.Location = new Point(0, 0);
            pnMainDataGridView.Name = "pnMainDataGridView";
            pnMainDataGridView.Size = new Size(1504, 460);
            pnMainDataGridView.TabIndex = 2;
            // 
            // picStudent
            // 
            picStudent.Location = new Point(4, 2);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(200, 250);
            picStudent.TabIndex = 1;
            picStudent.TabStop = false;
            // 
            // pnFunction
            // 
            pnFunction.Controls.Add(btnClose);
            pnFunction.Controls.Add(btnRefresh);
            pnFunction.Controls.Add(btAdd);
            pnFunction.Dock = DockStyle.Bottom;
            pnFunction.Location = new Point(0, 466);
            pnFunction.Name = "pnFunction";
            pnFunction.Size = new Size(1504, 157);
            pnFunction.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1203, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(124, 40);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1059, 13);
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
            // ManageStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1504, 623);
            Controls.Add(pnFunction);
            Controls.Add(pnMainDataGridView);
            Name = "ManageStudent";
            Text = "Student Management";
            Load += ManageStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            pnMainDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            pnFunction.ResumeLayout(false);
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
    }
}