namespace LoginForm
{
    partial class f_EditDeleteCourse
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
            btnRefresh = new Button();
            btnQuit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lbl_Practical = new Label();
            txt_PracticalPeriod = new TextBox();
            lbl_Theory = new Label();
            txt_CreditHour = new TextBox();
            label3 = new Label();
            txt_Overview = new TextBox();
            lbl_Overview = new Label();
            txt_TheoryPeriod = new TextBox();
            lbl_Period = new Label();
            cbo_PrerequisiteCourse = new ComboBox();
            lbl_PrerequisiteCourse = new Label();
            txt_NameCourse = new TextBox();
            txt_IDCourse = new TextBox();
            label2 = new Label();
            lbl_IDCourse = new Label();
            txt_CourseCode = new TextBox();
            lbl_CourseCode = new Label();
            cbo_Semester = new ComboBox();
            lbl_Semester = new Label();
            txt_Week = new TextBox();
            lbl_Week = new Label();
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
            panel1.Size = new Size(677, 702);
            panel1.TabIndex = 49;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(3, 4);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(121, 28);
            cboSort.TabIndex = 8;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(130, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(543, 27);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            dgvCourse.Size = new Size(670, 661);
            dgvCourse.TabIndex = 6;
            dgvCourse.CellClick += dgvCourse_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_Week);
            panel2.Controls.Add(lbl_Week);
            panel2.Controls.Add(cbo_Semester);
            panel2.Controls.Add(lbl_Semester);
            panel2.Controls.Add(txt_CourseCode);
            panel2.Controls.Add(lbl_CourseCode);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnQuit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(lbl_Practical);
            panel2.Controls.Add(txt_PracticalPeriod);
            panel2.Controls.Add(lbl_Theory);
            panel2.Controls.Add(txt_CreditHour);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_Overview);
            panel2.Controls.Add(lbl_Overview);
            panel2.Controls.Add(txt_TheoryPeriod);
            panel2.Controls.Add(lbl_Period);
            panel2.Controls.Add(cbo_PrerequisiteCourse);
            panel2.Controls.Add(lbl_PrerequisiteCourse);
            panel2.Controls.Add(txt_NameCourse);
            panel2.Controls.Add(txt_IDCourse);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbl_IDCourse);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(679, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(591, 702);
            panel2.TabIndex = 68;
    
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(303, 629);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 44);
            btnRefresh.TabIndex = 57;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(442, 629);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(126, 44);
            btnQuit.TabIndex = 56;
            btnQuit.Text = "Cancel";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(158, 629);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 44);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(23, 629);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 44);
            btnUpdate.TabIndex = 54;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbl_Practical
            // 
            lbl_Practical.AutoSize = true;
            lbl_Practical.Location = new Point(489, 382);
            lbl_Practical.Name = "lbl_Practical";
            lbl_Practical.Size = new Size(65, 20);
            lbl_Practical.TabIndex = 53;
            lbl_Practical.Text = "Practical";
            // 
            // txt_PracticalPeriod
            // 
            txt_PracticalPeriod.Location = new Point(426, 375);
            txt_PracticalPeriod.Name = "txt_PracticalPeriod";
            txt_PracticalPeriod.Size = new Size(57, 27);
            txt_PracticalPeriod.TabIndex = 52;
            // 
            // lbl_Theory
            // 
            lbl_Theory.AutoSize = true;
            lbl_Theory.Location = new Point(354, 382);
            lbl_Theory.Name = "lbl_Theory";
            lbl_Theory.Size = new Size(54, 20);
            lbl_Theory.TabIndex = 51;
            lbl_Theory.Text = "Theory";
            // 
            // txt_CreditHour
            // 
            txt_CreditHour.Location = new Point(118, 379);
            txt_CreditHour.Name = "txt_CreditHour";
            txt_CreditHour.Size = new Size(83, 27);
            txt_CreditHour.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 382);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 49;
            label3.Text = "Credit Hour:";
            // 
            // txt_Overview
            // 
            txt_Overview.Location = new Point(23, 449);
            txt_Overview.Multiline = true;
            txt_Overview.Name = "txt_Overview";
            txt_Overview.Size = new Size(531, 126);
            txt_Overview.TabIndex = 48;
            // 
            // lbl_Overview
            // 
            lbl_Overview.AutoSize = true;
            lbl_Overview.Location = new Point(23, 426);
            lbl_Overview.Name = "lbl_Overview";
            lbl_Overview.Size = new Size(73, 20);
            lbl_Overview.TabIndex = 47;
            lbl_Overview.Text = "Overview:";
            // 
            // txt_TheoryPeriod
            // 
            txt_TheoryPeriod.Location = new Point(291, 379);
            txt_TheoryPeriod.Name = "txt_TheoryPeriod";
            txt_TheoryPeriod.Size = new Size(57, 27);
            txt_TheoryPeriod.TabIndex = 46;
            // 
            // lbl_Period
            // 
            lbl_Period.AutoSize = true;
            lbl_Period.Location = new Point(218, 382);
            lbl_Period.Name = "lbl_Period";
            lbl_Period.Size = new Size(54, 20);
            lbl_Period.TabIndex = 45;
            lbl_Period.Text = "Period:";
            // 
            // cbo_PrerequisiteCourse
            // 
            cbo_PrerequisiteCourse.FormattingEnabled = true;
            cbo_PrerequisiteCourse.Location = new Point(23, 332);
            cbo_PrerequisiteCourse.Name = "cbo_PrerequisiteCourse";
            cbo_PrerequisiteCourse.Size = new Size(531, 28);
            cbo_PrerequisiteCourse.TabIndex = 44;
            // 
            // lbl_PrerequisiteCourse
            // 
            lbl_PrerequisiteCourse.AutoSize = true;
            lbl_PrerequisiteCourse.Location = new Point(23, 309);
            lbl_PrerequisiteCourse.Name = "lbl_PrerequisiteCourse";
            lbl_PrerequisiteCourse.Size = new Size(139, 20);
            lbl_PrerequisiteCourse.TabIndex = 43;
            lbl_PrerequisiteCourse.Text = "Prerequisite Course:";
            // 
            // txt_NameCourse
            // 
            txt_NameCourse.Location = new Point(132, 151);
            txt_NameCourse.Name = "txt_NameCourse";
            txt_NameCourse.Size = new Size(380, 27);
            txt_NameCourse.TabIndex = 42;
            // 
            // txt_IDCourse
            // 
            txt_IDCourse.Location = new Point(130, 55);
            txt_IDCourse.Name = "txt_IDCourse";
            txt_IDCourse.Size = new Size(382, 27);
            txt_IDCourse.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 154);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 40;
            label2.Text = "Name Course:";
            // 
            // lbl_IDCourse
            // 
            lbl_IDCourse.AutoSize = true;
            lbl_IDCourse.Location = new Point(29, 58);
            lbl_IDCourse.Name = "lbl_IDCourse";
            lbl_IDCourse.Size = new Size(76, 20);
            lbl_IDCourse.TabIndex = 39;
            lbl_IDCourse.Text = "ID Course:";
            // 
            // txt_CourseCode
            // 
            txt_CourseCode.Location = new Point(130, 103);
            txt_CourseCode.Name = "txt_CourseCode";
            txt_CourseCode.Size = new Size(382, 27);
            txt_CourseCode.TabIndex = 59;
      
            // 
            // lbl_CourseCode
            // 
            lbl_CourseCode.AutoSize = true;
            lbl_CourseCode.Location = new Point(27, 106);
            lbl_CourseCode.Name = "lbl_CourseCode";
            lbl_CourseCode.Size = new Size(96, 20);
            lbl_CourseCode.TabIndex = 58;
            lbl_CourseCode.Text = "Course Code:";
            // 
            // cbo_Semester
            // 
            cbo_Semester.FormattingEnabled = true;
            cbo_Semester.Location = new Point(130, 200);
            cbo_Semester.Name = "cbo_Semester";
            cbo_Semester.Size = new Size(382, 28);
            cbo_Semester.TabIndex = 61;
            // 
            // lbl_Semester
            // 
            lbl_Semester.AutoSize = true;
            lbl_Semester.Location = new Point(27, 200);
            lbl_Semester.Name = "lbl_Semester";
            lbl_Semester.Size = new Size(73, 20);
            lbl_Semester.TabIndex = 60;
            lbl_Semester.Text = "Semester:";
            // 
            // txt_Week
            // 
            txt_Week.Location = new Point(130, 253);
            txt_Week.Name = "txt_Week";
            txt_Week.Size = new Size(382, 27);
            txt_Week.TabIndex = 63;
            // 
            // lbl_Week
            // 
            lbl_Week.AutoSize = true;
            lbl_Week.Location = new Point(24, 256);
            lbl_Week.Name = "lbl_Week";
            lbl_Week.Size = new Size(48, 20);
            lbl_Week.TabIndex = 62;
            lbl_Week.Text = "Week:";
            // 
            // f_EditDeleteCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 702);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "f_EditDeleteCourse";
            Text = "f_EditDeleteCourse";
            Load += f_EditDeleteCourse_Load;
            Shown += f_EditDeleteCourse_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboGender;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private DataGridView dgvCourse;
        private Panel panel2;
        private Label lbl_Practical;
        private TextBox txt_PracticalPeriod;
        private Label lbl_Theory;
        private TextBox txt_CreditHour;
        private Label label3;
        private TextBox txt_Overview;
        private Label lbl_Overview;
        private TextBox txt_TheoryPeriod;
        private Label lbl_Period;
        private ComboBox cbo_PrerequisiteCourse;
        private Label lbl_PrerequisiteCourse;
        private TextBox txt_NameCourse;
        private TextBox txt_IDCourse;
        private Label label2;
        private Label lbl_IDCourse;
        private Button btnQuit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRefresh;
        private TextBox txt_CourseCode;
        private Label lbl_CourseCode;
        private ComboBox cbo_Semester;
        private Label lbl_Semester;
        private TextBox txt_Week;
        private Label lbl_Week;
    }
}