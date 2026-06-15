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
            txtRegistereSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblAcademicYearRegister = new Label();
            dgvRegistereCourse = new DataGridView();
            lblAcademicYearUnRegister = new Label();
            label5 = new Label();
            lblSemesterRegister = new Label();
            label6 = new Label();
            lblSemesterUnRegister = new Label();
            label7 = new Label();
            txtClassIDUnRegister = new DataGridViewTextBoxColumn();
            txtClassNameUnRegister = new DataGridViewTextBoxColumn();
            txtCourseNameUnRegister = new DataGridViewTextBoxColumn();
            txtManagerNameUnRegister = new DataGridViewTextBoxColumn();
            txtCreditHourUnRegister = new DataGridViewTextBoxColumn();
            txtPrerequisiteCourseUnRegister = new DataGridViewTextBoxColumn();
            txtSemesterUnRegister = new DataGridViewTextBoxColumn();
            txtWeekUnRegister = new DataGridViewTextBoxColumn();
            btnRegister = new DataGridViewButtonColumn();
            txtClassIDRegister = new DataGridViewTextBoxColumn();
            txtClassNameRegister = new DataGridViewTextBoxColumn();
            txtCourseNameRegister = new DataGridViewTextBoxColumn();
            txtManagerNameRegister = new DataGridViewTextBoxColumn();
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
            txtUnRegistereSearch.Size = new Size(1314, 27);
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
            dgvUnRegistereCourse.Columns.AddRange(new DataGridViewColumn[] { txtClassIDUnRegister, txtClassNameUnRegister, txtCourseNameUnRegister, txtManagerNameUnRegister, txtCreditHourUnRegister, txtPrerequisiteCourseUnRegister, txtSemesterUnRegister, txtWeekUnRegister, btnRegister });
            dgvUnRegistereCourse.Location = new Point(12, 162);
            dgvUnRegistereCourse.Name = "dgvUnRegistereCourse";
            dgvUnRegistereCourse.ReadOnly = true;
            dgvUnRegistereCourse.RowHeadersVisible = false;
            dgvUnRegistereCourse.RowHeadersWidth = 51;
            dgvUnRegistereCourse.Size = new Size(1314, 318);
            dgvUnRegistereCourse.TabIndex = 6;
            // 
            // txtRegistereSearch
            // 
            txtRegistereSearch.Location = new Point(12, 600);
            txtRegistereSearch.Name = "txtRegistereSearch";
            txtRegistereSearch.PlaceholderText = "Search";
            txtRegistereSearch.Size = new Size(1314, 27);
            txtRegistereSearch.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(480, 62);
            label1.TabIndex = 11;
            label1.Text = "Courses Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 488);
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
            // lblAcademicYearRegister
            // 
            lblAcademicYearRegister.AutoSize = true;
            lblAcademicYearRegister.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcademicYearRegister.Location = new Point(99, 77);
            lblAcademicYearRegister.Name = "lblAcademicYearRegister";
            lblAcademicYearRegister.Size = new Size(0, 38);
            lblAcademicYearRegister.TabIndex = 15;
            // 
            // dgvRegistereCourse
            // 
            dgvRegistereCourse.AllowUserToAddRows = false;
            dgvRegistereCourse.AllowUserToDeleteRows = false;
            dgvRegistereCourse.AllowUserToResizeColumns = false;
            dgvRegistereCourse.AllowUserToResizeRows = false;
            dgvRegistereCourse.BackgroundColor = SystemColors.Control;
            dgvRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistereCourse.Columns.AddRange(new DataGridViewColumn[] { txtClassIDRegister, txtClassNameRegister, txtCourseNameRegister, txtManagerNameRegister, txtCreditHourRegister, txtPrerequisiteCourseRegister, txtSemesterRegister, txtWeekRegister, btnUnRegister });
            dgvRegistereCourse.Location = new Point(12, 633);
            dgvRegistereCourse.Name = "dgvRegistereCourse";
            dgvRegistereCourse.ReadOnly = true;
            dgvRegistereCourse.RowHeadersVisible = false;
            dgvRegistereCourse.RowHeadersWidth = 51;
            dgvRegistereCourse.Size = new Size(1314, 318);
            dgvRegistereCourse.TabIndex = 16;
            // 
            // lblAcademicYearUnRegister
            // 
            lblAcademicYearUnRegister.AutoSize = true;
            lblAcademicYearUnRegister.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcademicYearUnRegister.Location = new Point(99, 550);
            lblAcademicYearUnRegister.Name = "lblAcademicYearUnRegister";
            lblAcademicYearUnRegister.Size = new Size(0, 38);
            lblAcademicYearUnRegister.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 550);
            label5.Name = "label5";
            label5.Size = new Size(81, 38);
            label5.TabIndex = 17;
            label5.Text = "Year:";
            // 
            // lblSemesterRegister
            // 
            lblSemesterRegister.AutoSize = true;
            lblSemesterRegister.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemesterRegister.Location = new Point(414, 77);
            lblSemesterRegister.Name = "lblSemesterRegister";
            lblSemesterRegister.Size = new Size(0, 38);
            lblSemesterRegister.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(261, 77);
            label6.Name = "label6";
            label6.Size = new Size(147, 38);
            label6.TabIndex = 19;
            label6.Text = "Semester:";
            // 
            // lblSemesterUnRegister
            // 
            lblSemesterUnRegister.AutoSize = true;
            lblSemesterUnRegister.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSemesterUnRegister.Location = new Point(414, 550);
            lblSemesterUnRegister.Name = "lblSemesterUnRegister";
            lblSemesterUnRegister.Size = new Size(0, 38);
            lblSemesterUnRegister.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(261, 550);
            label7.Name = "label7";
            label7.Size = new Size(147, 38);
            label7.TabIndex = 21;
            label7.Text = "Semester:";
            // 
            // txtClassIDUnRegister
            // 
            txtClassIDUnRegister.Frozen = true;
            txtClassIDUnRegister.HeaderText = "ClassID";
            txtClassIDUnRegister.MinimumWidth = 6;
            txtClassIDUnRegister.Name = "txtClassIDUnRegister";
            txtClassIDUnRegister.ReadOnly = true;
            txtClassIDUnRegister.Width = 125;
            // 
            // txtClassNameUnRegister
            // 
            txtClassNameUnRegister.Frozen = true;
            txtClassNameUnRegister.HeaderText = "Class Name";
            txtClassNameUnRegister.MinimumWidth = 6;
            txtClassNameUnRegister.Name = "txtClassNameUnRegister";
            txtClassNameUnRegister.ReadOnly = true;
            txtClassNameUnRegister.Width = 180;
            // 
            // txtCourseNameUnRegister
            // 
            txtCourseNameUnRegister.Frozen = true;
            txtCourseNameUnRegister.HeaderText = "Course Name";
            txtCourseNameUnRegister.MinimumWidth = 6;
            txtCourseNameUnRegister.Name = "txtCourseNameUnRegister";
            txtCourseNameUnRegister.ReadOnly = true;
            txtCourseNameUnRegister.Width = 180;
            // 
            // txtManagerNameUnRegister
            // 
            txtManagerNameUnRegister.Frozen = true;
            txtManagerNameUnRegister.HeaderText = "Teacher Name";
            txtManagerNameUnRegister.MinimumWidth = 6;
            txtManagerNameUnRegister.Name = "txtManagerNameUnRegister";
            txtManagerNameUnRegister.ReadOnly = true;
            txtManagerNameUnRegister.Width = 180;
            // 
            // txtCreditHourUnRegister
            // 
            txtCreditHourUnRegister.Frozen = true;
            txtCreditHourUnRegister.HeaderText = "Credit Hour";
            txtCreditHourUnRegister.MinimumWidth = 6;
            txtCreditHourUnRegister.Name = "txtCreditHourUnRegister";
            txtCreditHourUnRegister.ReadOnly = true;
            txtCreditHourUnRegister.Width = 120;
            // 
            // txtPrerequisiteCourseUnRegister
            // 
            txtPrerequisiteCourseUnRegister.Frozen = true;
            txtPrerequisiteCourseUnRegister.HeaderText = "Prerequisite Course";
            txtPrerequisiteCourseUnRegister.MinimumWidth = 6;
            txtPrerequisiteCourseUnRegister.Name = "txtPrerequisiteCourseUnRegister";
            txtPrerequisiteCourseUnRegister.ReadOnly = true;
            txtPrerequisiteCourseUnRegister.Width = 180;
            // 
            // txtSemesterUnRegister
            // 
            txtSemesterUnRegister.Frozen = true;
            txtSemesterUnRegister.HeaderText = "Semester";
            txtSemesterUnRegister.MinimumWidth = 6;
            txtSemesterUnRegister.Name = "txtSemesterUnRegister";
            txtSemesterUnRegister.ReadOnly = true;
            txtSemesterUnRegister.Width = 150;
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
            btnRegister.Width = 115;
            // 
            // txtClassIDRegister
            // 
            txtClassIDRegister.Frozen = true;
            txtClassIDRegister.HeaderText = "Class ID";
            txtClassIDRegister.MinimumWidth = 6;
            txtClassIDRegister.Name = "txtClassIDRegister";
            txtClassIDRegister.ReadOnly = true;
            txtClassIDRegister.Width = 120;
            // 
            // txtClassNameRegister
            // 
            txtClassNameRegister.Frozen = true;
            txtClassNameRegister.HeaderText = "Class Name";
            txtClassNameRegister.MinimumWidth = 6;
            txtClassNameRegister.Name = "txtClassNameRegister";
            txtClassNameRegister.ReadOnly = true;
            txtClassNameRegister.Width = 180;
            // 
            // txtCourseNameRegister
            // 
            txtCourseNameRegister.Frozen = true;
            txtCourseNameRegister.HeaderText = "Course Name";
            txtCourseNameRegister.MinimumWidth = 6;
            txtCourseNameRegister.Name = "txtCourseNameRegister";
            txtCourseNameRegister.ReadOnly = true;
            txtCourseNameRegister.Width = 180;
            // 
            // txtManagerNameRegister
            // 
            txtManagerNameRegister.Frozen = true;
            txtManagerNameRegister.HeaderText = "Teacher Name";
            txtManagerNameRegister.MinimumWidth = 6;
            txtManagerNameRegister.Name = "txtManagerNameRegister";
            txtManagerNameRegister.ReadOnly = true;
            txtManagerNameRegister.Width = 180;
            // 
            // txtCreditHourRegister
            // 
            txtCreditHourRegister.Frozen = true;
            txtCreditHourRegister.HeaderText = "Credit Hour";
            txtCreditHourRegister.MinimumWidth = 6;
            txtCreditHourRegister.Name = "txtCreditHourRegister";
            txtCreditHourRegister.ReadOnly = true;
            txtCreditHourRegister.Width = 115;
            // 
            // txtPrerequisiteCourseRegister
            // 
            txtPrerequisiteCourseRegister.Frozen = true;
            txtPrerequisiteCourseRegister.HeaderText = "Prerequisite Course";
            txtPrerequisiteCourseRegister.MinimumWidth = 6;
            txtPrerequisiteCourseRegister.Name = "txtPrerequisiteCourseRegister";
            txtPrerequisiteCourseRegister.ReadOnly = true;
            txtPrerequisiteCourseRegister.Width = 180;
            // 
            // txtSemesterRegister
            // 
            txtSemesterRegister.Frozen = true;
            txtSemesterRegister.HeaderText = "Semester";
            txtSemesterRegister.MinimumWidth = 6;
            txtSemesterRegister.Name = "txtSemesterRegister";
            txtSemesterRegister.ReadOnly = true;
            txtSemesterRegister.Width = 150;
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
            ClientSize = new Size(1508, 1055);
            Controls.Add(lblSemesterUnRegister);
            Controls.Add(label7);
            Controls.Add(lblSemesterRegister);
            Controls.Add(label6);
            Controls.Add(lblAcademicYearUnRegister);
            Controls.Add(label5);
            Controls.Add(dgvRegistereCourse);
            Controls.Add(lblAcademicYearRegister);
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
        private Label lblAcademicYearRegister;
        private DataGridView dgvRegistereCourse;
        private Label lblAcademicYearUnRegister;
        private Label label5;
        private Label lblSemesterRegister;
        private Label label6;
        private Label lblSemesterUnRegister;
        private Label label7;
        private DataGridViewTextBoxColumn txtClassIDUnRegister;
        private DataGridViewTextBoxColumn txtClassNameUnRegister;
        private DataGridViewTextBoxColumn txtCourseNameUnRegister;
        private DataGridViewTextBoxColumn txtManagerNameUnRegister;
        private DataGridViewTextBoxColumn txtCreditHourUnRegister;
        private DataGridViewTextBoxColumn txtPrerequisiteCourseUnRegister;
        private DataGridViewTextBoxColumn txtSemesterUnRegister;
        private DataGridViewTextBoxColumn txtWeekUnRegister;
        private DataGridViewButtonColumn btnRegister;
        private DataGridViewTextBoxColumn txtClassIDRegister;
        private DataGridViewTextBoxColumn txtClassNameRegister;
        private DataGridViewTextBoxColumn txtCourseNameRegister;
        private DataGridViewTextBoxColumn txtManagerNameRegister;
        private DataGridViewTextBoxColumn txtCreditHourRegister;
        private DataGridViewTextBoxColumn txtPrerequisiteCourseRegister;
        private DataGridViewTextBoxColumn txtSemesterRegister;
        private DataGridViewTextBoxColumn txtWeekRegister;
        private DataGridViewButtonColumn btnUnRegister;
    }
}