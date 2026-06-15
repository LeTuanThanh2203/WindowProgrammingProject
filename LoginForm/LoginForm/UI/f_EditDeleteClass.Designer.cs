namespace Project_Group6
{
    partial class f_EditDeleteClass
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
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvCourse = new DataGridView();
            panel2 = new Panel();
            txt_HomeroomTeacher = new TextBox();
            btnRefresh = new Button();
            btnQuit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lbl_AcademicYearAuto = new Label();
            cbo_CourseName = new ComboBox();
            lbl_NameCourse = new Label();
            lbl_AcademicYear = new Label();
            lbl_ClassIDAuto = new Label();
            lbl_ClassID = new Label();
            lbl_HomeroomTeacher = new Label();
            txt_ClassCourse = new TextBox();
            lbl_ClassName = new Label();
            cboSemester = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboSort);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dgvCourse);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 701);
            panel1.TabIndex = 69;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(3, 4);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(121, 28);
            cboSort.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(130, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(543, 27);
            txtSearch.TabIndex = 7;
            // 
            // dgvCourse
            // 
            dgvCourse.BackgroundColor = SystemColors.Control;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(3, 38);
            dgvCourse.MultiSelect = false;
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Size = new Size(670, 660);
            dgvCourse.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(cboSemester);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_HomeroomTeacher);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnQuit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(lbl_AcademicYearAuto);
            panel2.Controls.Add(cbo_CourseName);
            panel2.Controls.Add(lbl_NameCourse);
            panel2.Controls.Add(lbl_AcademicYear);
            panel2.Controls.Add(lbl_ClassIDAuto);
            panel2.Controls.Add(lbl_ClassID);
            panel2.Controls.Add(lbl_HomeroomTeacher);
            panel2.Controls.Add(txt_ClassCourse);
            panel2.Controls.Add(lbl_ClassName);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(679, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 701);
            panel2.TabIndex = 70;
            // 
            // txt_HomeroomTeacher
            // 
            txt_HomeroomTeacher.Location = new Point(157, 381);
            txt_HomeroomTeacher.Name = "txt_HomeroomTeacher";
            txt_HomeroomTeacher.Size = new Size(419, 27);
            txt_HomeroomTeacher.TabIndex = 83;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(302, 456);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 44);
            btnRefresh.TabIndex = 82;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(441, 456);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(126, 44);
            btnQuit.TabIndex = 81;
            btnQuit.Text = "Cancel";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(157, 456);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 44);
            btnDelete.TabIndex = 80;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(22, 456);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 44);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lbl_AcademicYearAuto
            // 
            lbl_AcademicYearAuto.AutoSize = true;
            lbl_AcademicYearAuto.Location = new Point(523, 267);
            lbl_AcademicYearAuto.Name = "lbl_AcademicYearAuto";
            lbl_AcademicYearAuto.Size = new Size(0, 20);
            lbl_AcademicYearAuto.TabIndex = 78;
            // 
            // cbo_CourseName
            // 
            cbo_CourseName.FormattingEnabled = true;
            cbo_CourseName.Location = new Point(157, 156);
            cbo_CourseName.Name = "cbo_CourseName";
            cbo_CourseName.Size = new Size(419, 28);
            cbo_CourseName.TabIndex = 77;
            // 
            // lbl_NameCourse
            // 
            lbl_NameCourse.AutoSize = true;
            lbl_NameCourse.Location = new Point(12, 156);
            lbl_NameCourse.Name = "lbl_NameCourse";
            lbl_NameCourse.Size = new Size(101, 20);
            lbl_NameCourse.TabIndex = 76;
            lbl_NameCourse.Text = "Course Name:";
            // 
            // lbl_AcademicYear
            // 
            lbl_AcademicYear.AutoSize = true;
            lbl_AcademicYear.Location = new Point(394, 267);
            lbl_AcademicYear.Name = "lbl_AcademicYear";
            lbl_AcademicYear.Size = new Size(110, 20);
            lbl_AcademicYear.TabIndex = 75;
            lbl_AcademicYear.Text = "Academic Year:";
            // 
            // lbl_ClassIDAuto
            // 
            lbl_ClassIDAuto.AutoSize = true;
            lbl_ClassIDAuto.Location = new Point(157, 205);
            lbl_ClassIDAuto.Name = "lbl_ClassIDAuto";
            lbl_ClassIDAuto.Size = new Size(0, 20);
            lbl_ClassIDAuto.TabIndex = 74;
            // 
            // lbl_ClassID
            // 
            lbl_ClassID.AutoSize = true;
            lbl_ClassID.Location = new Point(12, 205);
            lbl_ClassID.Name = "lbl_ClassID";
            lbl_ClassID.Size = new Size(64, 20);
            lbl_ClassID.TabIndex = 70;
            lbl_ClassID.Text = "Class ID:";
            // 
            // lbl_HomeroomTeacher
            // 
            lbl_HomeroomTeacher.AutoSize = true;
            lbl_HomeroomTeacher.Location = new Point(12, 381);
            lbl_HomeroomTeacher.Name = "lbl_HomeroomTeacher";
            lbl_HomeroomTeacher.Size = new Size(107, 20);
            lbl_HomeroomTeacher.TabIndex = 68;
            lbl_HomeroomTeacher.Text = "Name Teacher:";
            // 
            // txt_ClassCourse
            // 
            txt_ClassCourse.Location = new Point(157, 326);
            txt_ClassCourse.Name = "txt_ClassCourse";
            txt_ClassCourse.Size = new Size(419, 27);
            txt_ClassCourse.TabIndex = 67;
            // 
            // lbl_ClassName
            // 
            lbl_ClassName.AutoSize = true;
            lbl_ClassName.Location = new Point(12, 326);
            lbl_ClassName.Name = "lbl_ClassName";
            lbl_ClassName.Size = new Size(89, 20);
            lbl_ClassName.TabIndex = 66;
            lbl_ClassName.Text = "Name Class:";
            // 
            // cboSemester
            // 
            cboSemester.FormattingEnabled = true;
            cboSemester.Location = new Point(157, 264);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(112, 28);
            cboSemester.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 264);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 84;
            label2.Text = "Semester:";
            // 
            // f_EditDeleteClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 701);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "f_EditDeleteClass";
            Text = "f_EditDeleteClass";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private DataGridView dgvCourse;
        private Panel panel2;
        private Label lbl_AcademicYearAuto;
        private ComboBox cbo_CourseName;
        private Label lbl_NameCourse;
        private Label lbl_AcademicYear;
        private Label lbl_ClassIDAuto;
        private Label lbl_ClassID;
        private Label lbl_HomeroomTeacher;
        private TextBox txt_ClassCourse;
        private Label lbl_ClassName;
        private Button btnRefresh;
        private Button btnQuit;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txt_HomeroomTeacher;
        private ComboBox cboSemester;
        private Label label2;
    }
}