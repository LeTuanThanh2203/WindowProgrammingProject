namespace LoginForm
{
    partial class f_CourseRegistration
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();
            grpAvailable = new GroupBox();
            txtUnRegistereSearch = new TextBox();
            dgvUnRegistereCourse = new DataGridView();
            txtClassIDUnRegister = new DataGridViewTextBoxColumn();
            txtCourseNameUnRegister = new DataGridViewTextBoxColumn();
            txtCreditUnRegister = new DataGridViewTextBoxColumn();
            txtSemesterUnRegister = new DataGridViewTextBoxColumn();
            txtAcademicYearUnRegister = new DataGridViewTextBoxColumn();
            txtCapacityUnRegister = new DataGridViewTextBoxColumn();
            txtCurrentStudentsUnRegister = new DataGridViewTextBoxColumn();
            txtRoomUnRegister = new DataGridViewTextBoxColumn();
            txtScheduleUnRegister = new DataGridViewTextBoxColumn();
            btnRegister = new DataGridViewButtonColumn();
            grpRegistered = new GroupBox();
            txtRegistereSearch = new TextBox();
            dgvRegistereCourse = new DataGridView();
            txtClassIDRegister = new DataGridViewTextBoxColumn();
            txtCourseNameRegister = new DataGridViewTextBoxColumn();
            txtCreditRegister = new DataGridViewTextBoxColumn();
            txtSemesterRegister = new DataGridViewTextBoxColumn();
            txtAcademicYearRegister = new DataGridViewTextBoxColumn();
            txtRoomRegister = new DataGridViewTextBoxColumn();
            txtScheduleRegister = new DataGridViewTextBoxColumn();
            txtRegisterDateRegister = new DataGridViewTextBoxColumn();
            btnUnRegister = new DataGridViewButtonColumn();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).BeginInit();
            grpRegistered.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).BeginInit();
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
            pnlHeader.Padding = new Padding(24, 0, 0, 0);
            pnlHeader.Size = new Size(1300, 80);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Course Registration";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(420, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "University Academic Management System";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(grpAvailable);
            pnlBody.Controls.Add(grpRegistered);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1300, 770);
            pnlBody.TabIndex = 0;
            // 
            // grpAvailable
            // 
            grpAvailable.BackColor = Color.White;
            grpAvailable.Controls.Add(txtUnRegistereSearch);
            grpAvailable.Controls.Add(dgvUnRegistereCourse);
            grpAvailable.Font = new Font("Segoe UI Semibold", 9.5F);
            grpAvailable.ForeColor = Color.FromArgb(10, 61, 120);
            grpAvailable.Location = new Point(24, 20);
            grpAvailable.Name = "grpAvailable";
            grpAvailable.Padding = new Padding(16);
            grpAvailable.Size = new Size(1252, 350);
            grpAvailable.TabIndex = 0;
            grpAvailable.TabStop = false;
            grpAvailable.Text = "Available Courses";
            // 
            // txtUnRegistereSearch
            // 
            txtUnRegistereSearch.Font = new Font("Segoe UI", 9.5F);
            txtUnRegistereSearch.Location = new Point(20, 32);
            txtUnRegistereSearch.Name = "txtUnRegistereSearch";
            txtUnRegistereSearch.PlaceholderText = "Search available courses...";
            txtUnRegistereSearch.Size = new Size(1212, 29);
            txtUnRegistereSearch.TabIndex = 0;
            // 
            // dgvUnRegistereCourse
            // 
            dgvUnRegistereCourse.AllowUserToAddRows = false;
            dgvUnRegistereCourse.AllowUserToDeleteRows = false;
            dgvUnRegistereCourse.AllowUserToResizeColumns = false;
            dgvUnRegistereCourse.AllowUserToResizeRows = false;
            dgvUnRegistereCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUnRegistereCourse.BackgroundColor = Color.White;
            dgvUnRegistereCourse.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUnRegistereCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUnRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnRegistereCourse.Columns.AddRange(new DataGridViewColumn[] { txtClassIDUnRegister, txtCourseNameUnRegister, txtCreditUnRegister, txtSemesterUnRegister, txtAcademicYearUnRegister, txtCapacityUnRegister, txtCurrentStudentsUnRegister, txtRoomUnRegister, txtScheduleUnRegister, btnRegister });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUnRegistereCourse.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUnRegistereCourse.EnableHeadersVisualStyles = false;
            dgvUnRegistereCourse.GridColor = Color.FromArgb(225, 228, 232);
            dgvUnRegistereCourse.Location = new Point(20, 68);
            dgvUnRegistereCourse.Name = "dgvUnRegistereCourse";
            dgvUnRegistereCourse.ReadOnly = true;
            dgvUnRegistereCourse.RowHeadersVisible = false;
            dgvUnRegistereCourse.RowHeadersWidth = 51;
            dgvUnRegistereCourse.RowTemplate.Height = 32;
            dgvUnRegistereCourse.Size = new Size(1212, 260);
            dgvUnRegistereCourse.TabIndex = 1;
            // 
            // txtClassIDUnRegister
            // 
            txtClassIDUnRegister.HeaderText = "Class ID";
            txtClassIDUnRegister.MinimumWidth = 6;
            txtClassIDUnRegister.Name = "txtClassIDUnRegister";
            txtClassIDUnRegister.ReadOnly = true;
            txtClassIDUnRegister.Width = 95;
            // 
            // txtCourseNameUnRegister
            // 
            txtCourseNameUnRegister.HeaderText = "Course Name";
            txtCourseNameUnRegister.MinimumWidth = 6;
            txtCourseNameUnRegister.Name = "txtCourseNameUnRegister";
            txtCourseNameUnRegister.ReadOnly = true;
            txtCourseNameUnRegister.Width = 137;
            // 
            // txtCreditUnRegister
            // 
            txtCreditUnRegister.HeaderText = "Credits";
            txtCreditUnRegister.MinimumWidth = 6;
            txtCreditUnRegister.Name = "txtCreditUnRegister";
            txtCreditUnRegister.ReadOnly = true;
            txtCreditUnRegister.Width = 91;
            // 
            // txtSemesterUnRegister
            // 
            txtSemesterUnRegister.HeaderText = "Semester";
            txtSemesterUnRegister.MinimumWidth = 6;
            txtSemesterUnRegister.Name = "txtSemesterUnRegister";
            txtSemesterUnRegister.ReadOnly = true;
            txtSemesterUnRegister.Width = 108;
            // 
            // txtAcademicYearUnRegister
            // 
            txtAcademicYearUnRegister.HeaderText = "Academic Year";
            txtAcademicYearUnRegister.MinimumWidth = 6;
            txtAcademicYearUnRegister.Name = "txtAcademicYearUnRegister";
            txtAcademicYearUnRegister.ReadOnly = true;
            txtAcademicYearUnRegister.Width = 146;
            // 
            // txtCapacityUnRegister
            // 
            txtCapacityUnRegister.HeaderText = "Capacity";
            txtCapacityUnRegister.MinimumWidth = 6;
            txtCapacityUnRegister.Name = "txtCapacityUnRegister";
            txtCapacityUnRegister.ReadOnly = true;
            txtCapacityUnRegister.Width = 101;
            // 
            // txtCurrentStudentsUnRegister
            // 
            txtCurrentStudentsUnRegister.HeaderText = "Enrolled";
            txtCurrentStudentsUnRegister.MinimumWidth = 6;
            txtCurrentStudentsUnRegister.Name = "txtCurrentStudentsUnRegister";
            txtCurrentStudentsUnRegister.ReadOnly = true;
            txtCurrentStudentsUnRegister.Width = 99;
            // 
            // txtRoomUnRegister
            // 
            txtRoomUnRegister.HeaderText = "Room";
            txtRoomUnRegister.MinimumWidth = 6;
            txtRoomUnRegister.Name = "txtRoomUnRegister";
            txtRoomUnRegister.ReadOnly = true;
            txtRoomUnRegister.Width = 83;
            // 
            // txtScheduleUnRegister
            // 
            txtScheduleUnRegister.HeaderText = "Schedule";
            txtScheduleUnRegister.MinimumWidth = 6;
            txtScheduleUnRegister.Name = "txtScheduleUnRegister";
            txtScheduleUnRegister.ReadOnly = true;
            txtScheduleUnRegister.Width = 106;
            // 
            // btnRegister
            // 
            btnRegister.HeaderText = "Action";
            btnRegister.MinimumWidth = 6;
            btnRegister.Name = "btnRegister";
            btnRegister.ReadOnly = true;
            btnRegister.Text = "Register";
            btnRegister.UseColumnTextForButtonValue = true;
            btnRegister.Width = 64;
            // 
            // grpRegistered
            // 
            grpRegistered.BackColor = Color.White;
            grpRegistered.Controls.Add(txtRegistereSearch);
            grpRegistered.Controls.Add(dgvRegistereCourse);
            grpRegistered.Font = new Font("Segoe UI Semibold", 9.5F);
            grpRegistered.ForeColor = Color.FromArgb(10, 61, 120);
            grpRegistered.Location = new Point(24, 390);
            grpRegistered.Name = "grpRegistered";
            grpRegistered.Padding = new Padding(16);
            grpRegistered.Size = new Size(1252, 350);
            grpRegistered.TabIndex = 1;
            grpRegistered.TabStop = false;
            grpRegistered.Text = "My Registered Courses";
            // 
            // txtRegistereSearch
            // 
            txtRegistereSearch.Font = new Font("Segoe UI", 9.5F);
            txtRegistereSearch.Location = new Point(20, 32);
            txtRegistereSearch.Name = "txtRegistereSearch";
            txtRegistereSearch.PlaceholderText = "Search registered courses...";
            txtRegistereSearch.Size = new Size(1212, 29);
            txtRegistereSearch.TabIndex = 0;
            // 
            // dgvRegistereCourse
            // 
            dgvRegistereCourse.AllowUserToAddRows = false;
            dgvRegistereCourse.AllowUserToDeleteRows = false;
            dgvRegistereCourse.AllowUserToResizeColumns = false;
            dgvRegistereCourse.AllowUserToResizeRows = false;
            dgvRegistereCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRegistereCourse.BackgroundColor = Color.White;
            dgvRegistereCourse.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRegistereCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistereCourse.Columns.AddRange(new DataGridViewColumn[] { txtClassIDRegister, txtCourseNameRegister, txtCreditRegister, txtSemesterRegister, txtAcademicYearRegister, txtRoomRegister, txtScheduleRegister, txtRegisterDateRegister, btnUnRegister });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRegistereCourse.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRegistereCourse.EnableHeadersVisualStyles = false;
            dgvRegistereCourse.GridColor = Color.FromArgb(225, 228, 232);
            dgvRegistereCourse.Location = new Point(20, 68);
            dgvRegistereCourse.Name = "dgvRegistereCourse";
            dgvRegistereCourse.ReadOnly = true;
            dgvRegistereCourse.RowHeadersVisible = false;
            dgvRegistereCourse.RowHeadersWidth = 51;
            dgvRegistereCourse.RowTemplate.Height = 32;
            dgvRegistereCourse.Size = new Size(1212, 260);
            dgvRegistereCourse.TabIndex = 1;
            // 
            // txtClassIDRegister
            // 
            txtClassIDRegister.HeaderText = "Class ID";
            txtClassIDRegister.MinimumWidth = 6;
            txtClassIDRegister.Name = "txtClassIDRegister";
            txtClassIDRegister.ReadOnly = true;
            txtClassIDRegister.Width = 88;
            // 
            // txtCourseNameRegister
            // 
            txtCourseNameRegister.HeaderText = "Course Name";
            txtCourseNameRegister.MinimumWidth = 6;
            txtCourseNameRegister.Name = "txtCourseNameRegister";
            txtCourseNameRegister.ReadOnly = true;
            txtCourseNameRegister.Width = 126;
            // 
            // txtCreditRegister
            // 
            txtCreditRegister.HeaderText = "Credits";
            txtCreditRegister.MinimumWidth = 6;
            txtCreditRegister.Name = "txtCreditRegister";
            txtCreditRegister.ReadOnly = true;
            txtCreditRegister.Width = 91;
            // 
            // txtSemesterRegister
            // 
            txtSemesterRegister.HeaderText = "Semester";
            txtSemesterRegister.MinimumWidth = 6;
            txtSemesterRegister.Name = "txtSemesterRegister";
            txtSemesterRegister.ReadOnly = true;
            txtSemesterRegister.Width = 108;
            // 
            // txtAcademicYearRegister
            // 
            txtAcademicYearRegister.HeaderText = "Academic Year";
            txtAcademicYearRegister.MinimumWidth = 6;
            txtAcademicYearRegister.Name = "txtAcademicYearRegister";
            txtAcademicYearRegister.ReadOnly = true;
            txtAcademicYearRegister.Width = 134;
            // 
            // txtRoomRegister
            // 
            txtRoomRegister.HeaderText = "Room";
            txtRoomRegister.MinimumWidth = 6;
            txtRoomRegister.Name = "txtRoomRegister";
            txtRoomRegister.ReadOnly = true;
            txtRoomRegister.Width = 83;
            // 
            // txtScheduleRegister
            // 
            txtScheduleRegister.HeaderText = "Schedule";
            txtScheduleRegister.MinimumWidth = 6;
            txtScheduleRegister.Name = "txtScheduleRegister";
            txtScheduleRegister.ReadOnly = true;
            txtScheduleRegister.Width = 106;
            // 
            // txtRegisterDateRegister
            // 
            txtRegisterDateRegister.HeaderText = "Registered On";
            txtRegisterDateRegister.MinimumWidth = 6;
            txtRegisterDateRegister.Name = "txtRegisterDateRegister";
            txtRegisterDateRegister.ReadOnly = true;
            txtRegisterDateRegister.Width = 132;
            // 
            // btnUnRegister
            // 
            btnUnRegister.HeaderText = "Action";
            btnUnRegister.MinimumWidth = 6;
            btnUnRegister.Name = "btnUnRegister";
            btnUnRegister.ReadOnly = true;
            btnUnRegister.Text = "Unregister";
            btnUnRegister.UseColumnTextForButtonValue = true;
            btnUnRegister.Width = 64;
            // 
            // f_CourseRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1300, 850);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "f_CourseRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Registration";
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpAvailable.ResumeLayout(false);
            grpAvailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).EndInit();
            grpRegistered.ResumeLayout(false);
            grpRegistered.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBody;

        private GroupBox grpAvailable;
        private TextBox txtUnRegistereSearch;
        private DataGridView dgvUnRegistereCourse;
        private DataGridViewTextBoxColumn txtClassIDUnRegister;
        private DataGridViewTextBoxColumn txtCourseNameUnRegister;
        private DataGridViewTextBoxColumn txtCreditUnRegister;
        private DataGridViewTextBoxColumn txtSemesterUnRegister;
        private DataGridViewTextBoxColumn txtAcademicYearUnRegister;
        private DataGridViewTextBoxColumn txtCapacityUnRegister;
        private DataGridViewTextBoxColumn txtCurrentStudentsUnRegister;
        private DataGridViewTextBoxColumn txtRoomUnRegister;
        private DataGridViewTextBoxColumn txtScheduleUnRegister;
        private DataGridViewButtonColumn btnRegister;

        private GroupBox grpRegistered;
        private TextBox txtRegistereSearch;
        private DataGridView dgvRegistereCourse;
        private DataGridViewTextBoxColumn txtClassIDRegister;
        private DataGridViewTextBoxColumn txtCourseNameRegister;
        private DataGridViewTextBoxColumn txtCreditRegister;
        private DataGridViewTextBoxColumn txtSemesterRegister;
        private DataGridViewTextBoxColumn txtAcademicYearRegister;
        private DataGridViewTextBoxColumn txtRoomRegister;
        private DataGridViewTextBoxColumn txtScheduleRegister;
        private DataGridViewTextBoxColumn txtRegisterDateRegister;
        private DataGridViewButtonColumn btnUnRegister;
    }
}