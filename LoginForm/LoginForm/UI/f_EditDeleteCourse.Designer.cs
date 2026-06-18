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
            // ── Controls ──────────────────────────────────────────────
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();

            pnlBody = new Panel();

            // Course list (left card)
            grpCourseList = new GroupBox();
            lblSortCaption = new Label();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvCourse = new DataGridView();

            // Course details (right card)
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

            // Footer buttons
            pnlButtons = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnQuit = new Button();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpCourseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            grpCourseDetails.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // ── Header ────────────────────────────────────────────────
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            lblTitle.Text = "Manage Courses";
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.AutoSize = true;

            lblSubtitle.Text = "University Academic Management System";
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.AutoSize = true;

            // ── Body ──────────────────────────────────────────────────
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Padding = new Padding(20, 16, 20, 12);
            pnlBody.Controls.AddRange(new Control[] { grpCourseDetails, grpCourseList });

            // ── Course list card ──────────────────────────────────────
            grpCourseList.Text = "Course List";
            grpCourseList.Font = new Font("Segoe UI Semibold", 9.5F);
            grpCourseList.ForeColor = Color.FromArgb(10, 61, 120);
            grpCourseList.BackColor = Color.White;
            grpCourseList.Dock = DockStyle.Left;
            grpCourseList.Width = 640;
            grpCourseList.Margin = new Padding(0, 0, 16, 0);
            grpCourseList.Padding = new Padding(16, 16, 16, 16);
            grpCourseList.Controls.AddRange(new Control[] { lblSortCaption, cboSort, txtSearch, dgvCourse });

            lblSortCaption.AutoSize = true;
            lblSortCaption.Text = "Sort by:";
            lblSortCaption.Font = new Font("Segoe UI", 9.5F);
            lblSortCaption.ForeColor = Color.FromArgb(80, 80, 90);
            lblSortCaption.Location = new Point(16, 32);

            cboSort.FormattingEnabled = true;
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.Font = new Font("Segoe UI", 9.5F);
            cboSort.Location = new Point(80, 28);
            cboSort.Size = new Size(150, 28);
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;

            txtSearch.PlaceholderText = "Search courses";
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(250, 28);
            txtSearch.Size = new Size(370, 27);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.TextChanged += txtSearch_TextChanged;

            dgvCourse.BackgroundColor = SystemColors.Control;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.MultiSelect = false;
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Location = new Point(16, 74);
            dgvCourse.Size = new Size(600, 560);
            dgvCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCourse.CellClick += dgvCourse_CellClick;

            // ── Course details card ───────────────────────────────────
            grpCourseDetails.Text = "Course Details";
            grpCourseDetails.Font = new Font("Segoe UI Semibold", 9.5F);
            grpCourseDetails.ForeColor = Color.FromArgb(10, 61, 120);
            grpCourseDetails.BackColor = Color.White;
            grpCourseDetails.Dock = DockStyle.Fill;
            grpCourseDetails.Padding = new Padding(16, 16, 16, 16);
            grpCourseDetails.Controls.AddRange(new Control[]
            {
                lbl_IDCourse, txt_IDCourse,
                lbl_NameCourse, txt_NameCourse,
                lbl_Credits, txt_Credits,
                lbl_Theory, txt_TheoryPeriod,
                lbl_Practical, txt_PracticalPeriod,
                lbl_TotalPeriod, txt_TotalPeriod,
                chk_IsRequired,
                lbl_PrerequisiteCourse, cbo_PrerequisiteCourse,
                lbl_Description, txt_Description
            });

            int lblX = 20, fldX = 150, rowH = 46, startY = 28;

            // Row 0 — Course ID
            SetupField(lbl_IDCourse, "Course ID:", lblX, startY + rowH * 0);
            txt_IDCourse.Location = new Point(fldX, startY + rowH * 0 - 2);
            txt_IDCourse.Size = new Size(220, 27);
            txt_IDCourse.Font = new Font("Segoe UI", 9.5F);

            // Row 1 — Course Name
            SetupField(lbl_NameCourse, "Course Name:", lblX, startY + rowH * 1);
            txt_NameCourse.Location = new Point(fldX, startY + rowH * 1 - 2);
            txt_NameCourse.Size = new Size(380, 27);
            txt_NameCourse.Font = new Font("Segoe UI", 9.5F);
            txt_NameCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Row 2 — Credits / Theory / Practical
            SetupField(lbl_Credits, "Credits:", lblX, startY + rowH * 2);
            txt_Credits.Location = new Point(fldX, startY + rowH * 2 - 2);
            txt_Credits.Size = new Size(60, 27);
            txt_Credits.Font = new Font("Segoe UI", 9.5F);

            SetupField(lbl_Theory, "Theory:", lblX + 210, startY + rowH * 2);
            txt_TheoryPeriod.Location = new Point(fldX + 280, startY + rowH * 2 - 2);
            txt_TheoryPeriod.Size = new Size(50, 27);
            txt_TheoryPeriod.Font = new Font("Segoe UI", 9.5F);
            txt_TheoryPeriod.TextChanged += Period_TextChanged;

            SetupField(lbl_Practical, "Practical:", lblX + 350, startY + rowH * 2);
            txt_PracticalPeriod.Location = new Point(fldX + 430, startY + rowH * 2 - 2);
            txt_PracticalPeriod.Size = new Size(50, 27);
            txt_PracticalPeriod.Font = new Font("Segoe UI", 9.5F);
            txt_PracticalPeriod.TextChanged += Period_TextChanged;

            // Row 3 — Total Periods (auto-calculated, read-only) / Is Required
            SetupField(lbl_TotalPeriod, "Total Periods:", lblX, startY + rowH * 3);
            txt_TotalPeriod.Location = new Point(fldX, startY + rowH * 3 - 2);
            txt_TotalPeriod.Size = new Size(80, 27);
            txt_TotalPeriod.Font = new Font("Segoe UI", 9.5F);
            txt_TotalPeriod.ReadOnly = true;
            txt_TotalPeriod.BackColor = Color.FromArgb(238, 240, 244);

            chk_IsRequired.Text = "Required course";
            chk_IsRequired.Font = new Font("Segoe UI", 9.5F);
            chk_IsRequired.ForeColor = Color.FromArgb(80, 80, 90);
            chk_IsRequired.AutoSize = true;
            chk_IsRequired.Location = new Point(lblX + 210, startY + rowH * 3 + 3);

            // Row 4 — Prerequisite
            SetupField(lbl_PrerequisiteCourse, "Prerequisite Course:", lblX, startY + rowH * 4);
            cbo_PrerequisiteCourse.FormattingEnabled = true;
            cbo_PrerequisiteCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_PrerequisiteCourse.Font = new Font("Segoe UI", 9.5F);
            cbo_PrerequisiteCourse.Location = new Point(lblX, startY + rowH * 4 + 22);
            cbo_PrerequisiteCourse.Size = new Size(460, 28);
            cbo_PrerequisiteCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Row 5 — Description
            SetupField(lbl_Description, "Description:", lblX, startY + rowH * 4 + 60);
            txt_Description.Multiline = true;
            txt_Description.Font = new Font("Segoe UI", 9.5F);
            txt_Description.Location = new Point(lblX, startY + rowH * 4 + 84);
            txt_Description.Size = new Size(460, 140);
            txt_Description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // ── Footer panel ──────────────────────────────────────────
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Height = 68;
            pnlButtons.BackColor = Color.White;
            pnlButtons.Padding = new Padding(24, 12, 24, 12);
            pnlButtons.Controls.AddRange(new Control[] { btnUpdate, btnDelete, btnRefresh, btnQuit });

            StylePrimaryBtn(btnUpdate, "Update", 0);
            btnUpdate.Click += btnUpdate_Click;

            StyleDangerBtn(btnDelete, "Delete", 148);
            btnDelete.Click += btnDelete_Click;

            StyleSecondaryBtn(btnRefresh, "Refresh", 296);
            btnRefresh.Click += btnRefresh_Click;

            StyleSecondaryBtn(btnQuit, "Cancel", 420);
            btnQuit.Click += btnQuit_Click;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 760);
            Font = new Font("Segoe UI", 9.5F);
            BackColor = Color.FromArgb(245, 247, 250);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "f_EditDeleteCourse";
            Text = "Manage Courses — Academic Management";
            Load += f_EditDeleteCourse_Load;
            Shown += f_EditDeleteCourse_Shown;

            Controls.AddRange(new Control[] { pnlButtons, pnlBody, pnlHeader });

            pnlHeader.ResumeLayout(false);
            grpCourseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            grpCourseDetails.ResumeLayout(false);
            grpCourseDetails.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Helpers ───────────────────────────────────────────────────
        private void SetupField(Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new Point(x, y + 5);
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9.5F);
            lbl.ForeColor = Color.FromArgb(80, 80, 90);
        }

        private void StylePrimaryBtn(Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new Point(left, 10);
            btn.Size = new Size(130, 42);
            btn.Font = new Font("Segoe UI Semibold", 9.5F);
            btn.BackColor = Color.FromArgb(10, 61, 120);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleDangerBtn(Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new Point(left, 10);
            btn.Size = new Size(130, 42);
            btn.Font = new Font("Segoe UI Semibold", 9.5F);
            btn.BackColor = Color.FromArgb(192, 57, 57);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleSecondaryBtn(Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new Point(left, 10);
            btn.Size = new Size(110, 42);
            btn.Font = new Font("Segoe UI", 9.5F);
            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(60, 70, 85);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btn.FlatAppearance.BorderSize = 1;
            btn.Cursor = Cursors.Hand;
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