namespace LoginForm
{
    partial class f_AddCourse
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Controls ──────────────────────────────────────────────
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();

            pnlBody = new Panel();
            grpCourseInfo = new GroupBox();

            lbl_CourseID = new Label();
            txt_CourseID = new TextBox();

            lbl_CourseName = new Label();
            txt_NameCourse = new TextBox();

            lbl_Credits = new Label();
            txt_Credits = new TextBox();

            lbl_TotalPeriods = new Label();
            txt_TotalPeriods = new TextBox();

            lbl_TheoryPeriods = new Label();
            txt_TheoryPeriods = new TextBox();

            lbl_PracticePeriods = new Label();
            txt_PracticePeriods = new TextBox();

            lbl_Prerequisite = new Label();
            cbo_Prerequisite = new ComboBox();

            lbl_IsRequired = new Label();
            chk_IsRequired = new CheckBox();

            lbl_Description = new Label();
            txt_Description = new TextBox();

            pnlButtons = new Panel();
            btn_AddCourse = new Button();
            btnClear = new Button();
            bt_Cancel = new Button();

            // ── Suspend ───────────────────────────────────────────────
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpCourseInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // ── Header ────────────────────────────────────────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Padding = new Padding(24, 0, 0, 0);
            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            lblTitle.AutoSize = false;
            lblTitle.Text = "Add New Course";
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(24, 14);
            lblTitle.Size = new System.Drawing.Size(400, 30);

            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "University Academic Management System";
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new System.Drawing.Point(26, 46);
            lblSubtitle.Size = new System.Drawing.Size(400, 20);

            // ── Body ──────────────────────────────────────────────────
            pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Padding = new Padding(24, 20, 24, 12);
            pnlBody.Controls.Add(grpCourseInfo);

            // ── GroupBox ──────────────────────────────────────────────
            grpCourseInfo.Text = "Course Information";
            grpCourseInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            grpCourseInfo.ForeColor = System.Drawing.Color.FromArgb(10, 61, 120);
            grpCourseInfo.BackColor = System.Drawing.Color.White;
            grpCourseInfo.Location = new System.Drawing.Point(24, 20);
            grpCourseInfo.Size = new System.Drawing.Size(640, 420);
            grpCourseInfo.Padding = new Padding(16);

            grpCourseInfo.Controls.AddRange(new Control[]
            {
                lbl_CourseID,    txt_CourseID,
                lbl_CourseName,  txt_NameCourse,
                lbl_Credits,     txt_Credits,
                lbl_TotalPeriods,    txt_TotalPeriods,
                lbl_TheoryPeriods,   txt_TheoryPeriods,
                lbl_PracticePeriods, txt_PracticePeriods,
                lbl_Prerequisite,    cbo_Prerequisite,
                lbl_IsRequired,      chk_IsRequired,
                lbl_Description,     txt_Description
            });

            const int lblX = 20;
            const int fldX = 200;
            const int rowH = 44;
            const int startY = 28;

            // Row 0 – Course ID
            lbl_CourseID.Text = "Course ID:";
            lbl_CourseID.Location = new System.Drawing.Point(20, 32);
            lbl_CourseID.AutoSize = true;
            lbl_CourseID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_CourseID.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_CourseID.Location = new System.Drawing.Point(fldX, startY + rowH * 0 - 2);
            txt_CourseID.Size = new System.Drawing.Size(200, 27);
            txt_CourseID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_CourseID.MaxLength = 20;

            // Row 1 – Course Name
            lbl_CourseName.Text = "Course Name:";
            lbl_CourseName.Location = new System.Drawing.Point(20, 76);
            lbl_CourseName.AutoSize = true;
            lbl_CourseName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_CourseName.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_NameCourse.Location = new System.Drawing.Point(fldX, startY + rowH * 1 - 2);
            txt_NameCourse.Size = new System.Drawing.Size(420, 27);
            txt_NameCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_NameCourse.MaxLength = 200;

            // Row 2 – Credits
            lbl_Credits.Text = "Credits:";
            lbl_Credits.Location = new System.Drawing.Point(20, 120);
            lbl_Credits.AutoSize = true;
            lbl_Credits.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_Credits.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_Credits.Location = new System.Drawing.Point(fldX, startY + rowH * 2 - 2);
            txt_Credits.Size = new System.Drawing.Size(80, 27);
            txt_Credits.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_Credits.MaxLength = 2;

            // Row 3 – Total / Theory / Practice periods (same row)
            lbl_TotalPeriods.Text = "Total Periods:";
            lbl_TotalPeriods.Location = new System.Drawing.Point(20, 164);
            lbl_TotalPeriods.AutoSize = true;
            lbl_TotalPeriods.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_TotalPeriods.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_TotalPeriods.Location = new System.Drawing.Point(fldX, startY + rowH * 3 - 2);
            txt_TotalPeriods.Size = new System.Drawing.Size(60, 27);
            txt_TotalPeriods.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_TotalPeriods.MaxLength = 3;

            lbl_TheoryPeriods.Text = "Theory:";
            lbl_TheoryPeriods.Location = new System.Drawing.Point(272, 164);
            lbl_TheoryPeriods.AutoSize = true;
            lbl_TheoryPeriods.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_TheoryPeriods.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_TheoryPeriods.Location = new System.Drawing.Point(fldX + 140, startY + rowH * 3 - 2);
            txt_TheoryPeriods.Size = new System.Drawing.Size(60, 27);
            txt_TheoryPeriods.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_TheoryPeriods.MaxLength = 3;

            lbl_PracticePeriods.Text = "Practice:";
            lbl_PracticePeriods.Location = new System.Drawing.Point(412, 164);
            lbl_PracticePeriods.AutoSize = true;
            lbl_PracticePeriods.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_PracticePeriods.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_PracticePeriods.Location = new System.Drawing.Point(fldX + 280, startY + rowH * 3 - 2);
            txt_PracticePeriods.Size = new System.Drawing.Size(60, 27);
            txt_PracticePeriods.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_PracticePeriods.MaxLength = 3;

            // Row 4 – Prerequisite
            lbl_Prerequisite.Text = "Prerequisite:";
            lbl_Prerequisite.Location = new System.Drawing.Point(20, 208);
            lbl_Prerequisite.AutoSize = true;
            lbl_Prerequisite.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_Prerequisite.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            cbo_Prerequisite.Location = new System.Drawing.Point(fldX, startY + rowH * 4 - 3);
            cbo_Prerequisite.Size = new System.Drawing.Size(420, 28);
            cbo_Prerequisite.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Prerequisite.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // Row 5 – Is Required (checkbox)
            lbl_IsRequired.Text = "Required:";
            lbl_IsRequired.Location = new System.Drawing.Point(20, 252);
            lbl_IsRequired.AutoSize = true;
            lbl_IsRequired.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_IsRequired.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            chk_IsRequired.Location = new System.Drawing.Point(fldX, startY + rowH * 5 - 2);
            chk_IsRequired.Size = new System.Drawing.Size(20, 20);
            chk_IsRequired.FlatStyle = FlatStyle.Flat;

            // Row 6 – Description (multi-line, taller)
            lbl_Description.Text = "Description:";
            lbl_Description.Location = new System.Drawing.Point(20, 296);
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_Description.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_Description.Location = new System.Drawing.Point(fldX, startY + rowH * 6 - 2);
            txt_Description.Size = new System.Drawing.Size(420, 80);
            txt_Description.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_Description.Multiline = true;
            txt_Description.ScrollBars = ScrollBars.Vertical;
            txt_Description.MaxLength = 500;

            // ── Button panel ──────────────────────────────────────────
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Height = 68;
            pnlButtons.Padding = new Padding(24, 12, 24, 12);
            pnlButtons.Controls.AddRange(new Control[] { btn_AddCourse, btnClear, bt_Cancel });

            btn_AddCourse.Text = "Add Course";
            btn_AddCourse.Location = new System.Drawing.Point(0, 10);
            btn_AddCourse.Size = new System.Drawing.Size(130, 42);
            btn_AddCourse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btn_AddCourse.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btn_AddCourse.ForeColor = System.Drawing.Color.White;
            btn_AddCourse.FlatStyle = FlatStyle.Flat;
            btn_AddCourse.FlatAppearance.BorderSize = 0;
            btn_AddCourse.Cursor = Cursors.Hand;

            btnClear.Text = "Reset";
            btnClear.Location = new System.Drawing.Point(148, 10);
            btnClear.Size = new System.Drawing.Size(120, 42);
            btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnClear.BackColor = System.Drawing.Color.White;
            btnClear.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.Cursor = Cursors.Hand;

            bt_Cancel.Text = "Cancel";
            bt_Cancel.Location = new System.Drawing.Point(284, 10);
            bt_Cancel.Size = new System.Drawing.Size(120, 42);
            bt_Cancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            bt_Cancel.BackColor = System.Drawing.Color.White;
            bt_Cancel.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            bt_Cancel.FlatStyle = FlatStyle.Flat;
            bt_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            bt_Cancel.FlatAppearance.BorderSize = 1;
            bt_Cancel.Cursor = Cursors.Hand;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(688, 590);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Course — Academic Management";
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            Controls.AddRange(new Control[] { pnlButtons, pnlBody, pnlHeader });

            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpCourseInfo.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        // ── Field declarations ────────────────────────────────────────
        private Panel pnlHeader, pnlBody, pnlButtons;
        private Label lblTitle, lblSubtitle;
        private GroupBox grpCourseInfo;

        private Label lbl_CourseID;
        private TextBox txt_CourseID;

        private Label lbl_CourseName;
        private TextBox txt_NameCourse;

        private Label lbl_Credits;
        private TextBox txt_Credits;

        private Label lbl_TotalPeriods;
        private TextBox txt_TotalPeriods;

        private Label lbl_TheoryPeriods;
        private TextBox txt_TheoryPeriods;

        private Label lbl_PracticePeriods;
        private TextBox txt_PracticePeriods;

        private Label lbl_Prerequisite;
        private ComboBox cbo_Prerequisite;

        private Label lbl_IsRequired;
        private CheckBox chk_IsRequired;

        private Label lbl_Description;
        private TextBox txt_Description;

        private Button btn_AddCourse;
        private Button btnClear;
        private Button bt_Cancel;
    }
}