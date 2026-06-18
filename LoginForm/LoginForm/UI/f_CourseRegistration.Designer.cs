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

            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).BeginInit();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpAvailable.SuspendLayout();
            grpRegistered.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Padding = new Padding(24, 0, 0, 0);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            //
            // lblTitle
            //
            lblTitle.AutoSize = false;
            lblTitle.Text = "Course Registration";
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Size = new Size(420, 30);
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "University Academic Management System";
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Size = new Size(420, 20);
            //
            // pnlBody
            //
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(grpAvailable);
            pnlBody.Controls.Add(grpRegistered);
            //
            // grpAvailable
            //
            grpAvailable.Text = "Available Courses";
            grpAvailable.Font = new Font("Segoe UI Semibold", 9.5F);
            grpAvailable.ForeColor = Color.FromArgb(10, 61, 120);
            grpAvailable.BackColor = Color.White;
            grpAvailable.Location = new Point(24, 20);
            grpAvailable.Size = new Size(1252, 350);
            grpAvailable.Padding = new Padding(16, 16, 16, 16);
            grpAvailable.Controls.Add(txtUnRegistereSearch);
            grpAvailable.Controls.Add(dgvUnRegistereCourse);
            //
            // txtUnRegistereSearch
            //
            txtUnRegistereSearch.Font = new Font("Segoe UI", 9.5F);
            txtUnRegistereSearch.Location = new Point(20, 32);
            txtUnRegistereSearch.Name = "txtUnRegistereSearch";
            txtUnRegistereSearch.PlaceholderText = "Search available courses...";
            txtUnRegistereSearch.Size = new Size(1212, 27);
            txtUnRegistereSearch.TabIndex = 0;
            //
            // dgvUnRegistereCourse
            //
            dgvUnRegistereCourse.AllowUserToAddRows = false;
            dgvUnRegistereCourse.AllowUserToDeleteRows = false;
            dgvUnRegistereCourse.AllowUserToResizeColumns = false;
            dgvUnRegistereCourse.AllowUserToResizeRows = false;
            dgvUnRegistereCourse.BackgroundColor = Color.White;
            dgvUnRegistereCourse.BorderStyle = BorderStyle.None;
            dgvUnRegistereCourse.GridColor = Color.FromArgb(225, 228, 232);
            dgvUnRegistereCourse.EnableHeadersVisualStyles = false;
            dgvUnRegistereCourse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 61, 120);
            dgvUnRegistereCourse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUnRegistereCourse.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F);
            dgvUnRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnRegistereCourse.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dgvUnRegistereCourse.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvUnRegistereCourse.RowTemplate.Height = 32;
            dgvUnRegistereCourse.Columns.AddRange(new DataGridViewColumn[] {
                txtClassIDUnRegister,
                txtCourseNameUnRegister,
                txtCreditUnRegister,
                txtSemesterUnRegister,
                txtAcademicYearUnRegister,
                txtCapacityUnRegister,
                txtCurrentStudentsUnRegister,
                txtRoomUnRegister,
                txtScheduleUnRegister,
                btnRegister });
            dgvUnRegistereCourse.Location = new Point(20, 68);
            dgvUnRegistereCourse.Name = "dgvUnRegistereCourse";
            dgvUnRegistereCourse.ReadOnly = true;
            dgvUnRegistereCourse.RowHeadersVisible = false;
            dgvUnRegistereCourse.RowHeadersWidth = 51;
            dgvUnRegistereCourse.Size = new Size(1212, 260);
            dgvUnRegistereCourse.TabIndex = 1;
            //
            // txtClassIDUnRegister
            //
            txtClassIDUnRegister.HeaderText = "Class ID";
            txtClassIDUnRegister.MinimumWidth = 6;
            txtClassIDUnRegister.Name = "txtClassIDUnRegister";
            txtClassIDUnRegister.ReadOnly = true;
            txtClassIDUnRegister.Width = 90;
            //
            // txtCourseNameUnRegister
            //
            txtCourseNameUnRegister.HeaderText = "Course Name";
            txtCourseNameUnRegister.MinimumWidth = 6;
            txtCourseNameUnRegister.Name = "txtCourseNameUnRegister";
            txtCourseNameUnRegister.ReadOnly = true;
            txtCourseNameUnRegister.Width = 180;
            //
            // txtCreditUnRegister
            //
            txtCreditUnRegister.HeaderText = "Credits";
            txtCreditUnRegister.MinimumWidth = 6;
            txtCreditUnRegister.Name = "txtCreditUnRegister";
            txtCreditUnRegister.ReadOnly = true;
            txtCreditUnRegister.Width = 70;
            //
            // txtSemesterUnRegister
            //
            txtSemesterUnRegister.HeaderText = "Semester";
            txtSemesterUnRegister.MinimumWidth = 6;
            txtSemesterUnRegister.Name = "txtSemesterUnRegister";
            txtSemesterUnRegister.ReadOnly = true;
            txtSemesterUnRegister.Width = 90;
            //
            // txtAcademicYearUnRegister
            //
            txtAcademicYearUnRegister.HeaderText = "Academic Year";
            txtAcademicYearUnRegister.MinimumWidth = 6;
            txtAcademicYearUnRegister.Name = "txtAcademicYearUnRegister";
            txtAcademicYearUnRegister.ReadOnly = true;
            txtAcademicYearUnRegister.Width = 110;
            //
            // txtCapacityUnRegister
            //
            txtCapacityUnRegister.HeaderText = "Capacity";
            txtCapacityUnRegister.MinimumWidth = 6;
            txtCapacityUnRegister.Name = "txtCapacityUnRegister";
            txtCapacityUnRegister.ReadOnly = true;
            txtCapacityUnRegister.Width = 80;
            //
            // txtCurrentStudentsUnRegister
            //
            txtCurrentStudentsUnRegister.HeaderText = "Enrolled";
            txtCurrentStudentsUnRegister.MinimumWidth = 6;
            txtCurrentStudentsUnRegister.Name = "txtCurrentStudentsUnRegister";
            txtCurrentStudentsUnRegister.ReadOnly = true;
            txtCurrentStudentsUnRegister.Width = 80;
            //
            // txtRoomUnRegister
            //
            txtRoomUnRegister.HeaderText = "Room";
            txtRoomUnRegister.MinimumWidth = 6;
            txtRoomUnRegister.Name = "txtRoomUnRegister";
            txtRoomUnRegister.ReadOnly = true;
            txtRoomUnRegister.Width = 80;
            //
            // txtScheduleUnRegister
            //
            txtScheduleUnRegister.HeaderText = "Schedule";
            txtScheduleUnRegister.MinimumWidth = 6;
            txtScheduleUnRegister.Name = "txtScheduleUnRegister";
            txtScheduleUnRegister.ReadOnly = true;
            txtScheduleUnRegister.Width = 150;
            //
            // btnRegister
            //
            btnRegister.HeaderText = "Action";
            btnRegister.MinimumWidth = 6;
            btnRegister.Name = "btnRegister";
            btnRegister.Text = "Register";
            btnRegister.UseColumnTextForButtonValue = true;
            btnRegister.ReadOnly = true;
            btnRegister.Width = 110;
            //
            // grpRegistered
            //
            grpRegistered.Text = "My Registered Courses";
            grpRegistered.Font = new Font("Segoe UI Semibold", 9.5F);
            grpRegistered.ForeColor = Color.FromArgb(10, 61, 120);
            grpRegistered.BackColor = Color.White;
            grpRegistered.Location = new Point(24, 390);
            grpRegistered.Size = new Size(1252, 350);
            grpRegistered.Padding = new Padding(16, 16, 16, 16);
            grpRegistered.Controls.Add(txtRegistereSearch);
            grpRegistered.Controls.Add(dgvRegistereCourse);
            //
            // txtRegistereSearch
            //
            txtRegistereSearch.Font = new Font("Segoe UI", 9.5F);
            txtRegistereSearch.Location = new Point(20, 32);
            txtRegistereSearch.Name = "txtRegistereSearch";
            txtRegistereSearch.PlaceholderText = "Search registered courses...";
            txtRegistereSearch.Size = new Size(1212, 27);
            txtRegistereSearch.TabIndex = 0;
            //
            // dgvRegistereCourse
            //
            dgvRegistereCourse.AllowUserToAddRows = false;
            dgvRegistereCourse.AllowUserToDeleteRows = false;
            dgvRegistereCourse.AllowUserToResizeColumns = false;
            dgvRegistereCourse.AllowUserToResizeRows = false;
            dgvRegistereCourse.BackgroundColor = Color.White;
            dgvRegistereCourse.BorderStyle = BorderStyle.None;
            dgvRegistereCourse.GridColor = Color.FromArgb(225, 228, 232);
            dgvRegistereCourse.EnableHeadersVisualStyles = false;
            dgvRegistereCourse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 61, 120);
            dgvRegistereCourse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRegistereCourse.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F);
            dgvRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistereCourse.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dgvRegistereCourse.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvRegistereCourse.RowTemplate.Height = 32;
            dgvRegistereCourse.Columns.AddRange(new DataGridViewColumn[] {
                txtClassIDRegister,
                txtCourseNameRegister,
                txtCreditRegister,
                txtSemesterRegister,
                txtAcademicYearRegister,
                txtRoomRegister,
                txtScheduleRegister,
                txtRegisterDateRegister,
                btnUnRegister });
            dgvRegistereCourse.Location = new Point(20, 68);
            dgvRegistereCourse.Name = "dgvRegistereCourse";
            dgvRegistereCourse.ReadOnly = true;
            dgvRegistereCourse.RowHeadersVisible = false;
            dgvRegistereCourse.RowHeadersWidth = 51;
            dgvRegistereCourse.Size = new Size(1212, 260);
            dgvRegistereCourse.TabIndex = 1;
            //
            // txtClassIDRegister
            //
            txtClassIDRegister.HeaderText = "Class ID";
            txtClassIDRegister.MinimumWidth = 6;
            txtClassIDRegister.Name = "txtClassIDRegister";
            txtClassIDRegister.ReadOnly = true;
            txtClassIDRegister.Width = 90;
            //
            // txtCourseNameRegister
            //
            txtCourseNameRegister.HeaderText = "Course Name";
            txtCourseNameRegister.MinimumWidth = 6;
            txtCourseNameRegister.Name = "txtCourseNameRegister";
            txtCourseNameRegister.ReadOnly = true;
            txtCourseNameRegister.Width = 180;
            //
            // txtCreditRegister
            //
            txtCreditRegister.HeaderText = "Credits";
            txtCreditRegister.MinimumWidth = 6;
            txtCreditRegister.Name = "txtCreditRegister";
            txtCreditRegister.ReadOnly = true;
            txtCreditRegister.Width = 70;
            //
            // txtSemesterRegister
            //
            txtSemesterRegister.HeaderText = "Semester";
            txtSemesterRegister.MinimumWidth = 6;
            txtSemesterRegister.Name = "txtSemesterRegister";
            txtSemesterRegister.ReadOnly = true;
            txtSemesterRegister.Width = 90;
            //
            // txtAcademicYearRegister
            //
            txtAcademicYearRegister.HeaderText = "Academic Year";
            txtAcademicYearRegister.MinimumWidth = 6;
            txtAcademicYearRegister.Name = "txtAcademicYearRegister";
            txtAcademicYearRegister.ReadOnly = true;
            txtAcademicYearRegister.Width = 110;
            //
            // txtRoomRegister
            //
            txtRoomRegister.HeaderText = "Room";
            txtRoomRegister.MinimumWidth = 6;
            txtRoomRegister.Name = "txtRoomRegister";
            txtRoomRegister.ReadOnly = true;
            txtRoomRegister.Width = 80;
            //
            // txtScheduleRegister
            //
            txtScheduleRegister.HeaderText = "Schedule";
            txtScheduleRegister.MinimumWidth = 6;
            txtScheduleRegister.Name = "txtScheduleRegister";
            txtScheduleRegister.ReadOnly = true;
            txtScheduleRegister.Width = 150;
            //
            // txtRegisterDateRegister
            //
            txtRegisterDateRegister.HeaderText = "Registered On";
            txtRegisterDateRegister.MinimumWidth = 6;
            txtRegisterDateRegister.Name = "txtRegisterDateRegister";
            txtRegisterDateRegister.ReadOnly = true;
            txtRegisterDateRegister.Width = 120;
            //
            // btnUnRegister
            //
            btnUnRegister.HeaderText = "Action";
            btnUnRegister.MinimumWidth = 6;
            btnUnRegister.Name = "btnUnRegister";
            btnUnRegister.Text = "Unregister";
            btnUnRegister.UseColumnTextForButtonValue = true;
            btnUnRegister.ReadOnly = true;
            btnUnRegister.Width = 110;
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
            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpAvailable.ResumeLayout(false);
            grpRegistered.ResumeLayout(false);
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