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
            txtUnRegistereSearch = new TextBox();
            dgvUnRegistereCourse = new DataGridView();
            txtCourseCodeUnRegister = new DataGridViewTextBoxColumn();
            txtCourseNameUnRegister = new DataGridViewTextBoxColumn();
            txtCreditHourUnRegister = new DataGridViewTextBoxColumn();
            txtPrerequisiteCourseUnRegister = new DataGridViewTextBoxColumn();
            txtSemesterUnRegister = new DataGridViewTextBoxColumn();
            txtWeekUnRegister = new DataGridViewTextBoxColumn();
            btnRegister = new DataGridViewButtonColumn();
            txtRegistereSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblAcademicYear = new Label();
            dgvRegistereCourse = new DataGridView();
            txtCourseCodeRegister = new DataGridViewTextBoxColumn();
            txtCourseNameRegister = new DataGridViewTextBoxColumn();
            txtCreditHourRegister = new DataGridViewTextBoxColumn();
            txtPrerequisiteCourseRegister = new DataGridViewTextBoxColumn();
            txtSemesterRegister = new DataGridViewTextBoxColumn();
            txtWeekRegister = new DataGridViewTextBoxColumn();
            btnUnRegister = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).BeginInit();
            SuspendLayout();
            // 
            // txtUnRegistereSearch
            // 
            txtUnRegistereSearch.Location = new Point(12, 128);
            txtUnRegistereSearch.Name = "txtUnRegistereSearch";
            txtUnRegistereSearch.PlaceholderText = "Search";
            txtUnRegistereSearch.Size = new Size(1086, 27);
            txtUnRegistereSearch.TabIndex = 7;
            // 
            // dgvUnRegistereCourse
            // 
            dgvUnRegistereCourse.AllowUserToAddRows = false;
            dgvUnRegistereCourse.AllowUserToDeleteRows = false;
            dgvUnRegistereCourse.AllowUserToResizeColumns = false;
            dgvUnRegistereCourse.AllowUserToResizeRows = false;
            dgvUnRegistereCourse.BackgroundColor = SystemColors.Control;
            dgvUnRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnRegistereCourse.Columns.AddRange(new DataGridViewColumn[] { txtCourseCodeUnRegister, txtCourseNameUnRegister, txtCreditHourUnRegister, txtPrerequisiteCourseUnRegister, txtSemesterUnRegister, txtWeekUnRegister, btnRegister });
            dgvUnRegistereCourse.Location = new Point(12, 162);
            dgvUnRegistereCourse.Name = "dgvUnRegistereCourse";
            dgvUnRegistereCourse.ReadOnly = true;
            dgvUnRegistereCourse.RowHeadersVisible = false;
            dgvUnRegistereCourse.RowHeadersWidth = 51;
            dgvUnRegistereCourse.Size = new Size(1086, 318);
            dgvUnRegistereCourse.TabIndex = 6;
            // 
            // txtCourseCodeUnRegister
            // 
            txtCourseCodeUnRegister.Frozen = true;
            txtCourseCodeUnRegister.HeaderText = "Course Code";
            txtCourseCodeUnRegister.MinimumWidth = 6;
            txtCourseCodeUnRegister.Name = "txtCourseCodeUnRegister";
            txtCourseCodeUnRegister.ReadOnly = true;
            txtCourseCodeUnRegister.Width = 125;
            // 
            // txtCourseNameUnRegister
            // 
            txtCourseNameUnRegister.Frozen = true;
            txtCourseNameUnRegister.HeaderText = "Course Name";
            txtCourseNameUnRegister.MinimumWidth = 6;
            txtCourseNameUnRegister.Name = "txtCourseNameUnRegister";
            txtCourseNameUnRegister.ReadOnly = true;
            txtCourseNameUnRegister.Width = 225;
            // 
            // txtCreditHourUnRegister
            // 
            txtCreditHourUnRegister.Frozen = true;
            txtCreditHourUnRegister.HeaderText = "Credit Hour";
            txtCreditHourUnRegister.MinimumWidth = 6;
            txtCreditHourUnRegister.Name = "txtCreditHourUnRegister";
            txtCreditHourUnRegister.ReadOnly = true;
            txtCreditHourUnRegister.Width = 125;
            // 
            // txtPrerequisiteCourseUnRegister
            // 
            txtPrerequisiteCourseUnRegister.Frozen = true;
            txtPrerequisiteCourseUnRegister.HeaderText = "Prerequisite Course";
            txtPrerequisiteCourseUnRegister.MinimumWidth = 6;
            txtPrerequisiteCourseUnRegister.Name = "txtPrerequisiteCourseUnRegister";
            txtPrerequisiteCourseUnRegister.ReadOnly = true;
            txtPrerequisiteCourseUnRegister.Width = 225;
            // 
            // txtSemesterUnRegister
            // 
            txtSemesterUnRegister.Frozen = true;
            txtSemesterUnRegister.HeaderText = "Semester";
            txtSemesterUnRegister.MinimumWidth = 6;
            txtSemesterUnRegister.Name = "txtSemesterUnRegister";
            txtSemesterUnRegister.ReadOnly = true;
            txtSemesterUnRegister.Width = 175;
            // 
            // txtWeekUnRegister
            // 
            txtWeekUnRegister.Frozen = true;
            txtWeekUnRegister.HeaderText = "Week";
            txtWeekUnRegister.MinimumWidth = 6;
            txtWeekUnRegister.Name = "txtWeekUnRegister";
            txtWeekUnRegister.ReadOnly = true;
            txtWeekUnRegister.Width = 80;
            // 
            // btnRegister
            // 
            btnRegister.Frozen = true;
            btnRegister.HeaderText = "Register";
            btnRegister.MinimumWidth = 6;
            btnRegister.Name = "btnRegister";
            btnRegister.ReadOnly = true;
            btnRegister.Width = 125;
            // 
            // txtRegistereSearch
            // 
            txtRegistereSearch.Location = new Point(12, 600);
            txtRegistereSearch.Name = "txtRegistereSearch";
            txtRegistereSearch.PlaceholderText = "Search";
            txtRegistereSearch.Size = new Size(1086, 27);
            txtRegistereSearch.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(480, 62);
            label1.TabIndex = 11;
            label1.Text = "Courses Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 512);
            label2.Name = "label2";
            label2.Size = new Size(446, 62);
            label2.TabIndex = 12;
            label2.Text = "Registered Courses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(81, 38);
            label3.TabIndex = 14;
            label3.Text = "Year:";
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcademicYear.Location = new Point(99, 77);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(0, 38);
            lblAcademicYear.TabIndex = 15;
            // 
            // dgvRegistereCourse
            // 
            dgvRegistereCourse.AllowUserToAddRows = false;
            dgvRegistereCourse.AllowUserToDeleteRows = false;
            dgvRegistereCourse.AllowUserToResizeColumns = false;
            dgvRegistereCourse.AllowUserToResizeRows = false;
            dgvRegistereCourse.BackgroundColor = SystemColors.Control;
            dgvRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistereCourse.Columns.AddRange(new DataGridViewColumn[] { txtCourseCodeRegister, txtCourseNameRegister, txtCreditHourRegister, txtPrerequisiteCourseRegister, txtSemesterRegister, txtWeekRegister, btnUnRegister });
            dgvRegistereCourse.Location = new Point(12, 633);
            dgvRegistereCourse.Name = "dgvRegistereCourse";
            dgvRegistereCourse.ReadOnly = true;
            dgvRegistereCourse.RowHeadersVisible = false;
            dgvRegistereCourse.RowHeadersWidth = 51;
            dgvRegistereCourse.Size = new Size(1086, 318);
            dgvRegistereCourse.TabIndex = 16;
            // 
            // txtCourseCodeRegister
            // 
            txtCourseCodeRegister.Frozen = true;
            txtCourseCodeRegister.HeaderText = "Course Code";
            txtCourseCodeRegister.MinimumWidth = 6;
            txtCourseCodeRegister.Name = "txtCourseCodeRegister";
            txtCourseCodeRegister.ReadOnly = true;
            txtCourseCodeRegister.Width = 125;
            // 
            // txtCourseNameRegister
            // 
            txtCourseNameRegister.Frozen = true;
            txtCourseNameRegister.HeaderText = "Course Name";
            txtCourseNameRegister.MinimumWidth = 6;
            txtCourseNameRegister.Name = "txtCourseNameRegister";
            txtCourseNameRegister.ReadOnly = true;
            txtCourseNameRegister.Width = 225;
            // 
            // txtCreditHourRegister
            // 
            txtCreditHourRegister.Frozen = true;
            txtCreditHourRegister.HeaderText = "Credit Hour";
            txtCreditHourRegister.MinimumWidth = 6;
            txtCreditHourRegister.Name = "txtCreditHourRegister";
            txtCreditHourRegister.ReadOnly = true;
            txtCreditHourRegister.Width = 125;
            // 
            // txtPrerequisiteCourseRegister
            // 
            txtPrerequisiteCourseRegister.Frozen = true;
            txtPrerequisiteCourseRegister.HeaderText = "Prerequisite Course";
            txtPrerequisiteCourseRegister.MinimumWidth = 6;
            txtPrerequisiteCourseRegister.Name = "txtPrerequisiteCourseRegister";
            txtPrerequisiteCourseRegister.ReadOnly = true;
            txtPrerequisiteCourseRegister.Width = 225;
            // 
            // txtSemesterRegister
            // 
            txtSemesterRegister.Frozen = true;
            txtSemesterRegister.HeaderText = "Semester";
            txtSemesterRegister.MinimumWidth = 6;
            txtSemesterRegister.Name = "txtSemesterRegister";
            txtSemesterRegister.ReadOnly = true;
            txtSemesterRegister.Width = 175;
            // 
            // txtWeekRegister
            // 
            txtWeekRegister.Frozen = true;
            txtWeekRegister.HeaderText = "Week";
            txtWeekRegister.MinimumWidth = 6;
            txtWeekRegister.Name = "txtWeekRegister";
            txtWeekRegister.ReadOnly = true;
            txtWeekRegister.Width = 80;
            // 
            // btnUnRegister
            // 
            btnUnRegister.Frozen = true;
            btnUnRegister.HeaderText = "UnRegister";
            btnUnRegister.MinimumWidth = 6;
            btnUnRegister.Name = "btnUnRegister";
            btnUnRegister.ReadOnly = true;
            btnUnRegister.Width = 125;
            // 
            // f_CourseRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 1012);
            Controls.Add(dgvRegistereCourse);
            Controls.Add(lblAcademicYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRegistereSearch);
            Controls.Add(txtUnRegistereSearch);
            Controls.Add(dgvUnRegistereCourse);
            Name = "f_CourseRegistration";
            Text = "f_CourseRegistration";
            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboGender;
        private TextBox txtUnRegistereSearch;
        private DataGridView dgvUnRegistereCourse;
        private TextBox txtRegistereSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblAcademicYear;
        private DataGridView dgvRegistereCourse;
        private DataGridViewTextBoxColumn txtCourseCodeUnRegister;
        private DataGridViewTextBoxColumn txtCourseNameUnRegister;
        private DataGridViewTextBoxColumn txtCreditHourUnRegister;
        private DataGridViewTextBoxColumn txtPrerequisiteCourseUnRegister;
        private DataGridViewTextBoxColumn txtSemesterUnRegister;
        private DataGridViewTextBoxColumn txtWeekUnRegister;
        private DataGridViewButtonColumn btnRegister;
        private DataGridViewTextBoxColumn txtCourseCodeRegister;
        private DataGridViewTextBoxColumn txtCourseNameRegister;
        private DataGridViewTextBoxColumn txtCreditHourRegister;
        private DataGridViewTextBoxColumn txtPrerequisiteCourseRegister;
        private DataGridViewTextBoxColumn txtSemesterRegister;
        private DataGridViewTextBoxColumn txtWeekRegister;
        private DataGridViewButtonColumn btnUnRegister;
    }
}