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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();
            grpCourseDetails = new GroupBox();
            lbl_IDCourse = new Label();
            txt_IDCourse = new TextBox();
            lbl_NameCourse = new Label();
            txt_NameCourse = new TextBox();
            lbl_Credits = new Label();
            txt_Credits = new TextBox();
            lbl_Theory = new Label();
            txt_TheoryPeriod = new TextBox();
            lbl_Practical = new Label();
            txt_PracticalPeriod = new TextBox();
            lbl_TotalPeriod = new Label();
            txt_TotalPeriod = new TextBox();
            chk_IsRequired = new CheckBox();
            lbl_PrerequisiteCourse = new Label();
            cbo_PrerequisiteCourse = new ComboBox();
            lbl_Description = new Label();
            txt_Description = new TextBox();
            grpCourseList = new GroupBox();
            lblSortCaption = new Label();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvCourse = new DataGridView();
            pnlButtons = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnQuit = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpCourseDetails.SuspendLayout();
            grpCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            pnlButtons.SuspendLayout();
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
            pnlHeader.Size = new Size(1300, 80);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Courses";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(302, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "University Academic Management System";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(grpCourseDetails);
            pnlBody.Controls.Add(grpCourseList);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20, 16, 20, 12);
            pnlBody.Size = new Size(1300, 680);
            pnlBody.TabIndex = 1;
            // 
            // grpCourseDetails
            // 
            grpCourseDetails.BackColor = Color.White;
            grpCourseDetails.Controls.Add(lbl_IDCourse);
            grpCourseDetails.Controls.Add(txt_IDCourse);
            grpCourseDetails.Controls.Add(lbl_NameCourse);
            grpCourseDetails.Controls.Add(txt_NameCourse);
            grpCourseDetails.Controls.Add(lbl_Credits);
            grpCourseDetails.Controls.Add(txt_Credits);
            grpCourseDetails.Controls.Add(lbl_Theory);
            grpCourseDetails.Controls.Add(txt_TheoryPeriod);
            grpCourseDetails.Controls.Add(lbl_Practical);
            grpCourseDetails.Controls.Add(txt_PracticalPeriod);
            grpCourseDetails.Controls.Add(lbl_TotalPeriod);
            grpCourseDetails.Controls.Add(txt_TotalPeriod);
            grpCourseDetails.Controls.Add(chk_IsRequired);
            grpCourseDetails.Controls.Add(lbl_PrerequisiteCourse);
            grpCourseDetails.Controls.Add(cbo_PrerequisiteCourse);
            grpCourseDetails.Controls.Add(lbl_Description);
            grpCourseDetails.Controls.Add(txt_Description);
            grpCourseDetails.Dock = DockStyle.Fill;
            grpCourseDetails.Font = new Font("Segoe UI Semibold", 9.5F);
            grpCourseDetails.ForeColor = Color.FromArgb(10, 61, 120);
            grpCourseDetails.Location = new Point(660, 16);
            grpCourseDetails.Name = "grpCourseDetails";
            grpCourseDetails.Padding = new Padding(16);
            grpCourseDetails.Size = new Size(620, 652);
            grpCourseDetails.TabIndex = 0;
            grpCourseDetails.TabStop = false;
            grpCourseDetails.Text = "Course Details";
            // 
            // lbl_IDCourse
            // 
            lbl_IDCourse.Text = "Course ID:";
            lbl_IDCourse.Location = new Point(20, 33);
            lbl_IDCourse.AutoSize = true;
            lbl_IDCourse.Font = new Font("Segoe UI", 9.5F);
            lbl_IDCourse.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_IDCourse.Name = "lbl_IDCourse";
            lbl_IDCourse.Size = new Size(100, 23);
            lbl_IDCourse.TabIndex = 0;
            // 
            // txt_IDCourse
            // 
            txt_IDCourse.Font = new Font("Segoe UI", 9.5F);
            txt_IDCourse.Location = new Point(150, 28);
            txt_IDCourse.Name = "txt_IDCourse";
            txt_IDCourse.Size = new Size(220, 29);
            txt_IDCourse.TabIndex = 1;
            // 
            // lbl_NameCourse
            // 
            lbl_NameCourse.Text = "Course Name:";
            lbl_NameCourse.Location = new Point(20, 77);
            lbl_NameCourse.AutoSize = true;
            lbl_NameCourse.Font = new Font("Segoe UI", 9.5F);
            lbl_NameCourse.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_NameCourse.Name = "lbl_NameCourse";
            lbl_NameCourse.Size = new Size(100, 23);
            lbl_NameCourse.TabIndex = 2;
            // 
            // txt_NameCourse
            // 
            txt_NameCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_NameCourse.Font = new Font("Segoe UI", 9.5F);
            txt_NameCourse.Location = new Point(150, 72);
            txt_NameCourse.Name = "txt_NameCourse";
            txt_NameCourse.Size = new Size(450, 29);
            txt_NameCourse.TabIndex = 3;
            // 
            // lbl_Credits
            // 
            lbl_Credits.Text = "Credits:";
            lbl_Credits.Location = new Point(20, 121);
            lbl_Credits.AutoSize = true;
            lbl_Credits.Font = new Font("Segoe UI", 9.5F);
            lbl_Credits.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_Credits.Name = "lbl_Credits";
            lbl_Credits.Size = new Size(100, 23);
            lbl_Credits.TabIndex = 4;
            // 
            // txt_Credits
            // 
            txt_Credits.Font = new Font("Segoe UI", 9.5F);
            txt_Credits.Location = new Point(150, 116);
            txt_Credits.Name = "txt_Credits";
            txt_Credits.Size = new Size(60, 29);
            txt_Credits.TabIndex = 5;
            // 
            // lbl_Theory
            // 
            lbl_Theory.Text = "Theory:";
            lbl_Theory.Location = new Point(230, 165);
            lbl_Theory.AutoSize = true;
            lbl_Theory.Font = new Font("Segoe UI", 9.5F);
            lbl_Theory.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_Theory.Name = "lbl_Theory";
            lbl_Theory.Size = new Size(100, 23);
            lbl_Theory.TabIndex = 6;
            // 
            // txt_TheoryPeriod
            // 
            txt_TheoryPeriod.Font = new Font("Segoe UI", 9.5F);
            txt_TheoryPeriod.Location = new Point(290, 160);
            txt_TheoryPeriod.Name = "txt_TheoryPeriod";
            txt_TheoryPeriod.Size = new Size(50, 29);
            txt_TheoryPeriod.TabIndex = 7;
            txt_TheoryPeriod.TextChanged += Period_TextChanged;
            // 
            // lbl_Practical
            // 
            lbl_Practical.Text = "Practical:";
            lbl_Practical.Location = new Point(360, 165);
            lbl_Practical.AutoSize = true;
            lbl_Practical.Font = new Font("Segoe UI", 9.5F);
            lbl_Practical.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_Practical.Name = "lbl_Practical";
            lbl_Practical.Size = new Size(100, 23);
            lbl_Practical.TabIndex = 8;
            // 
            // txt_PracticalPeriod
            // 
            txt_PracticalPeriod.Font = new Font("Segoe UI", 9.5F);
            txt_PracticalPeriod.Location = new Point(430, 160);
            txt_PracticalPeriod.Name = "txt_PracticalPeriod";
            txt_PracticalPeriod.Size = new Size(50, 29);
            txt_PracticalPeriod.TabIndex = 9;
            txt_PracticalPeriod.TextChanged += Period_TextChanged;
            // 
            // lbl_TotalPeriod
            // 
            lbl_TotalPeriod.Text = "Total Periods:";
            lbl_TotalPeriod.Location = new Point(20, 165);
            lbl_TotalPeriod.AutoSize = true;
            lbl_TotalPeriod.Font = new Font("Segoe UI", 9.5F);
            lbl_TotalPeriod.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_TotalPeriod.Name = "lbl_TotalPeriod";
            lbl_TotalPeriod.Size = new Size(100, 23);
            lbl_TotalPeriod.TabIndex = 10;
            // 
            // txt_TotalPeriod
            // 
            txt_TotalPeriod.BackColor = Color.FromArgb(238, 240, 244);
            txt_TotalPeriod.Font = new Font("Segoe UI", 9.5F);
            txt_TotalPeriod.Location = new Point(150, 160);
            txt_TotalPeriod.Name = "txt_TotalPeriod";
            txt_TotalPeriod.ReadOnly = true;
            txt_TotalPeriod.Size = new Size(60, 29);
            txt_TotalPeriod.TabIndex = 11;
            // 
            // chk_IsRequired
            // 
            chk_IsRequired.AutoSize = true;
            chk_IsRequired.Font = new Font("Segoe UI", 9.5F);
            chk_IsRequired.ForeColor = Color.FromArgb(80, 80, 90);
            chk_IsRequired.Location = new Point(150, 248);
            chk_IsRequired.Name = "chk_IsRequired";
            chk_IsRequired.Size = new Size(145, 25);
            chk_IsRequired.TabIndex = 12;
            chk_IsRequired.Text = "Required course";
            // 
            // lbl_PrerequisiteCourse
            // 
            lbl_PrerequisiteCourse.Text = "Prerequisite:";
            lbl_PrerequisiteCourse.Location = new Point(20, 209);
            lbl_PrerequisiteCourse.AutoSize = true;
            lbl_PrerequisiteCourse.Font = new Font("Segoe UI", 9.5F);
            lbl_PrerequisiteCourse.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_PrerequisiteCourse.Name = "lbl_PrerequisiteCourse";
            lbl_PrerequisiteCourse.Size = new Size(100, 23);
            lbl_PrerequisiteCourse.TabIndex = 13;
            // 
            // cbo_PrerequisiteCourse
            // 
            cbo_PrerequisiteCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbo_PrerequisiteCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_PrerequisiteCourse.Font = new Font("Segoe UI", 9.5F);
            cbo_PrerequisiteCourse.FormattingEnabled = true;
            cbo_PrerequisiteCourse.Location = new Point(150, 204);
            cbo_PrerequisiteCourse.Name = "cbo_PrerequisiteCourse";
            cbo_PrerequisiteCourse.Size = new Size(450, 29);
            cbo_PrerequisiteCourse.TabIndex = 14;
            // 
            // lbl_Description
            // 
            lbl_Description.Text = "Description:";
            lbl_Description.Location = new Point(20, 297);
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new Font("Segoe UI", 9.5F);
            lbl_Description.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(100, 23);
            lbl_Description.TabIndex = 15;
            // 
            // txt_Description
            // 
            txt_Description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Description.Font = new Font("Segoe UI", 9.5F);
            txt_Description.Location = new Point(150, 292);
            txt_Description.Multiline = true;
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(450, 320);
            txt_Description.TabIndex = 16;
            // 
            // grpCourseList
            // 
            grpCourseList.BackColor = Color.White;
            grpCourseList.Controls.Add(lblSortCaption);
            grpCourseList.Controls.Add(cboSort);
            grpCourseList.Controls.Add(txtSearch);
            grpCourseList.Controls.Add(dgvCourse);
            grpCourseList.Dock = DockStyle.Left;
            grpCourseList.Font = new Font("Segoe UI Semibold", 9.5F);
            grpCourseList.ForeColor = Color.FromArgb(10, 61, 120);
            grpCourseList.Location = new Point(20, 16);
            grpCourseList.Margin = new Padding(0, 0, 16, 0);
            grpCourseList.Name = "grpCourseList";
            grpCourseList.Padding = new Padding(16);
            grpCourseList.Size = new Size(640, 652);
            grpCourseList.TabIndex = 1;
            grpCourseList.TabStop = false;
            grpCourseList.Text = "Course List";
            // 
            // lblSortCaption
            // 
            lblSortCaption.AutoSize = true;
            lblSortCaption.Font = new Font("Segoe UI", 9.5F);
            lblSortCaption.ForeColor = Color.FromArgb(80, 80, 90);
            lblSortCaption.Location = new Point(16, 32);
            lblSortCaption.Name = "lblSortCaption";
            lblSortCaption.Size = new Size(63, 21);
            lblSortCaption.TabIndex = 0;
            lblSortCaption.Text = "Sort by:";
            // 
            // cboSort
            // 
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.Font = new Font("Segoe UI", 9.5F);
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(80, 28);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(150, 29);
            cboSort.TabIndex = 1;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(250, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search courses";
            txtSearch.Size = new Size(370, 29);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToResizeColumns = false;
            dgvCourse.AllowUserToResizeRows = false;
            dgvCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCourse.BackgroundColor = SystemColors.Control;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(16, 74);
            dgvCourse.MultiSelect = false;
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Size = new Size(600, 1112);
            dgvCourse.TabIndex = 3;
            dgvCourse.CellClick += dgvCourse_CellClick;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.White;
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnRefresh);
            pnlButtons.Controls.Add(btnQuit);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 692);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(24, 12, 24, 12);
            pnlButtons.Size = new Size(1300, 68);
            pnlButtons.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Text = "Update Course";
            btnUpdate.Location = new Point(24, 10);
            btnUpdate.Size = new Size(130, 42);
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.5F);
            btnUpdate.BackColor = Color.FromArgb(10, 61, 120);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.TabIndex = 0;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Text = "Delete Course";
            btnDelete.Location = new Point(178, 10);
            btnDelete.Size = new Size(130, 42);
            btnDelete.Font = new Font("Segoe UI Semibold", 9.5F);
            btnDelete.BackColor = Color.FromArgb(192, 57, 57);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Name = "btnDelete";
            btnDelete.TabIndex = 1;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Text = "Reset";
            btnRefresh.Location = new Point(332, 10);
            btnRefresh.Size = new Size(110, 42);
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.BackColor = Color.White;
            btnRefresh.ForeColor = Color.FromArgb(60, 70, 85);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnRefresh.FlatAppearance.BorderSize = 1;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.TabIndex = 2;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnQuit
            // 
            btnQuit.Text = "Cancel";
            btnQuit.Location = new Point(466, 10);
            btnQuit.Size = new Size(110, 42);
            btnQuit.Font = new Font("Segoe UI", 9.5F);
            btnQuit.BackColor = Color.White;
            btnQuit.ForeColor = Color.FromArgb(60, 70, 85);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnQuit.FlatAppearance.BorderSize = 1;
            btnQuit.Cursor = Cursors.Hand;
            btnQuit.Name = "btnQuit";
            btnQuit.TabIndex = 3;
            btnQuit.Click += btnQuit_Click;
            // 
            // f_EditDeleteCourse
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1300, 760);
            Controls.Add(pnlButtons);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_EditDeleteCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Courses — Academic Management";
            Load += f_EditDeleteCourse_Load;
            Shown += f_EditDeleteCourse_Shown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            grpCourseDetails.ResumeLayout(false);
            grpCourseDetails.PerformLayout();
            grpCourseList.ResumeLayout(false);
            grpCourseList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        // ── Field declarations ────────────────────────────────────────
        private Panel pnlHeader, pnlBody, pnlButtons;
        private Label lblTitle, lblSubtitle;

        private GroupBox grpCourseList;
        private Label lblSortCaption;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private DataGridView dgvCourse;

        private GroupBox grpCourseDetails;
        private Label lbl_IDCourse;
        private TextBox txt_IDCourse;
        private Label lbl_NameCourse;
        private TextBox txt_NameCourse;
        private Label lbl_Credits;
        private TextBox txt_Credits;
        private Label lbl_Theory;
        private TextBox txt_TheoryPeriod;
        private Label lbl_Practical;
        private TextBox txt_PracticalPeriod;
        private Label lbl_TotalPeriod;
        private TextBox txt_TotalPeriod;
        private CheckBox chk_IsRequired;
        private Label lbl_PrerequisiteCourse;
        private ComboBox cbo_PrerequisiteCourse;
        private Label lbl_Description;
        private TextBox txt_Description;

        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnQuit;
    }
}