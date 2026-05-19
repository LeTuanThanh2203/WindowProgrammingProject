namespace Project_Group6.UI
{
    partial class f_EditDeleteStudent
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
            panel1 = new Panel();
            cboGender = new ComboBox();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvStudents = new DataGridView();
            btnQuit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label10 = new Label();
            btnChooseImage = new Button();
            picStudent = new PictureBox();
            txtEmail = new TextBox();
            label9 = new Label();
            txtHomeTown = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            cboGenderChoose = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dtpDob = new DateTimePicker();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtMSSV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboGender);
            panel1.Controls.Add(cboSort);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dgvStudents);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 707);
            panel1.TabIndex = 0;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(125, 4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(111, 28);
            cboGender.TabIndex = 9;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(0, 3);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(111, 28);
            cboSort.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(245, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(428, 27);
            txtSearch.TabIndex = 7;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = SystemColors.Control;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(3, 38);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(670, 669);
            dgvStudents.TabIndex = 6;
            dgvStudents.CellClick += dgvStudents_CellClick;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(473, 614);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(136, 44);
            btnQuit.TabIndex = 47;
            btnQuit.Text = "Cancel";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(308, 614);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 44);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(144, 614);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 44);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(119, 12);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 44;
            label10.Text = "Image";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(56, 206);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(177, 34);
            btnChooseImage.TabIndex = 43;
            btnChooseImage.Text = "Edit";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnEditImage_Click;
            // 
            // picStudent
            // 
            picStudent.Location = new Point(79, 38);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(126, 150);
            picStudent.TabIndex = 42;
            picStudent.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(823, 500);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 27);
            txtEmail.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(735, 503);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 40;
            label9.Text = "Email:";
            // 
            // txtHomeTown
            // 
            txtHomeTown.Location = new Point(823, 461);
            txtHomeTown.Name = "txtHomeTown";
            txtHomeTown.Size = new Size(404, 27);
            txtHomeTown.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(735, 464);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 38;
            label8.Text = "Hometown:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(823, 420);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(404, 27);
            txtAddress.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(735, 423);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 36;
            label7.Text = "Address:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(1040, 379);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(185, 27);
            txtPhone.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(927, 382);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 34;
            label6.Text = "Number phone:";
            // 
            // cboGenderChoose
            // 
            cboGenderChoose.FormattingEnabled = true;
            cboGenderChoose.Location = new Point(823, 379);
            cboGenderChoose.Name = "cboGenderChoose";
            cboGenderChoose.Size = new Size(68, 28);
            cboGenderChoose.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(735, 382);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 32;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(736, 339);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 31;
            label4.Text = "Date of birth:";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(833, 336);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(149, 27);
            dtpDob.TabIndex = 30;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(1134, 299);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(106, 27);
            txtLastName.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1054, 302);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 28;
            label3.Text = "First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(825, 299);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 27);
            txtFirstName.TabIndex = 27;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(825, 259);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(143, 27);
            txtMSSV.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(738, 302);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 25;
            label2.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(738, 262);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 24;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnQuit);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(picStudent);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnChooseImage);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(679, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 707);
            panel2.TabIndex = 48;
            // 
            // f_EditDeleteStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 707);
            Controls.Add(panel1);
            Controls.Add(txtMSSV);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(label9);
            Controls.Add(dtpDob);
            Controls.Add(txtHomeTown);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(cboGenderChoose);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtPhone);
            Controls.Add(panel2);
            Name = "f_EditDeleteStudent";
            Text = "Edit Student";
            Load += ManageStudent_Load;
            Shown += f_ListStudent_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cboGender;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private DataGridView dgvStudents;
        private Button btnQuit;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label10;
        private Button btnChooseImage;
        private PictureBox picStudent;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtHomeTown;
        private Label label8;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtPhone;
        private Label label6;
        private ComboBox cboGenderChoose;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpDob;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtMSSV;
        private Label label2;
        private Label label1;
        private Panel panel2;
    }
}