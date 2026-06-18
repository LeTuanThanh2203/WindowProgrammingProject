namespace Project_Group6
{
    partial class f_AddClass
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
            grpClassInfo = new GroupBox();

            // Course
            lbl_NameCourse = new Label();
            cbo_CourseName = new ComboBox();

            // Class ID (auto)
            lbl_ClassID = new Label();
            lbl_ClassIDAuto = new Label();

            // Semester
            label2 = new Label();
            cboSemester = new ComboBox();

            // Academic Year (auto)
            lbl_AcademicYear = new Label();
            lbl_AcademicYearAuto = new Label();

            // Capacity
            lblCapacity = new Label();
            txt_Capacity = new TextBox();

            // Room
            lblRoom = new Label();
            txt_Room = new TextBox();

            // Schedule
            lblSchedule = new Label();
            txt_Schedule = new TextBox();

            // Buttons
            pnlButtons = new Panel();
            btn_AddCourse = new Button();
            btnClear = new Button();
            btnQuit = new Button();

            // ── Header panel ──────────────────────────────────────────
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpClassInfo.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // pnlHeader
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Padding = new Padding(24, 0, 0, 0);
            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Text = "Add New Class";
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(24, 14);
            lblTitle.Size = new System.Drawing.Size(400, 30);

            // lblSubtitle
            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "University Academic Management System";
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new System.Drawing.Point(26, 46);
            lblSubtitle.Size = new System.Drawing.Size(400, 20);

            // ── Body panel ────────────────────────────────────────────
            pnlBody.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Padding = new Padding(24, 20, 24, 12);
            pnlBody.Controls.Add(grpClassInfo);

            // ── GroupBox ──────────────────────────────────────────────
            grpClassInfo.Text = "Class Information";
            grpClassInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            grpClassInfo.ForeColor = System.Drawing.Color.FromArgb(10, 61, 120);
            grpClassInfo.BackColor = System.Drawing.Color.White;
            grpClassInfo.Location = new System.Drawing.Point(24, 20);
            grpClassInfo.Size = new System.Drawing.Size(640, 310);
            grpClassInfo.Padding = new Padding(16, 16, 16, 16);
            grpClassInfo.Controls.AddRange(new Control[]
            {
                lbl_NameCourse, cbo_CourseName,
                lbl_ClassID, lbl_ClassIDAuto,
                label2, cboSemester,
                lbl_AcademicYear, lbl_AcademicYearAuto,
                lblCapacity, txt_Capacity,
                lblRoom, txt_Room,
                lblSchedule, txt_Schedule
            });

            int fldX = 200, rowH = 44, startY = 28;

            // Row 0 – Course
            lbl_NameCourse.Text = "Course:";
            lbl_NameCourse.Location = new System.Drawing.Point(20, 32);
            lbl_NameCourse.AutoSize = true;
            lbl_NameCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_NameCourse.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            cbo_CourseName.Location = new System.Drawing.Point(fldX, startY + rowH * 0 - 3);
            cbo_CourseName.Size = new System.Drawing.Size(420, 28);
            cbo_CourseName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_CourseName.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // Row 1 – Class ID (readonly label)
            lbl_ClassID.Text = "Class ID:";
            lbl_ClassID.Location = new System.Drawing.Point(20, 76);
            lbl_ClassID.AutoSize = true;
            lbl_ClassID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_ClassID.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            lbl_ClassIDAuto.Location = new System.Drawing.Point(fldX, startY + rowH * 1);
            lbl_ClassIDAuto.Size = new System.Drawing.Size(300, 24);
            lbl_ClassIDAuto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            lbl_ClassIDAuto.ForeColor = System.Drawing.Color.FromArgb(10, 61, 120);

            // Row 2 – Semester + Academic Year side-by-side
            label2.Text = "Semester:";
            label2.Location = new System.Drawing.Point(20, 120);
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            label2.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            cboSemester.Location = new System.Drawing.Point(fldX, startY + rowH * 2 - 3);
            cboSemester.Size = new System.Drawing.Size(140, 28);
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            lbl_AcademicYear.Text = "Academic Year:";
            lbl_AcademicYear.Location = new System.Drawing.Point(360, 120);
            lbl_AcademicYear.AutoSize = true;
            lbl_AcademicYear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_AcademicYear.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            lbl_AcademicYearAuto.Location = new System.Drawing.Point(fldX + 160 + 120, startY + rowH * 2);
            lbl_AcademicYearAuto.Size = new System.Drawing.Size(120, 24);
            lbl_AcademicYearAuto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            lbl_AcademicYearAuto.ForeColor = System.Drawing.Color.FromArgb(10, 61, 120);

            // Row 3 – Capacity
            lblCapacity.Text = "Capacity:";
            lblCapacity.Location = new System.Drawing.Point(20, 164);
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblCapacity.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_Capacity.Location = new System.Drawing.Point(fldX, startY + rowH * 3 - 2);
            txt_Capacity.Size = new System.Drawing.Size(100, 27);
            txt_Capacity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_Capacity.MaxLength = 4;

            // Row 4 – Room
            lblRoom.Text = "Room:";
            lblRoom.Location = new System.Drawing.Point(20, 208);
            lblRoom.AutoSize = true;
            lblRoom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblRoom.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_Room.Location = new System.Drawing.Point(fldX, startY + rowH * 4 - 2);
            txt_Room.Size = new System.Drawing.Size(200, 27);
            txt_Room.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // Row 5 – Schedule
            lblSchedule.Text = "Schedule:";
            lblSchedule.Location = new System.Drawing.Point(20, 252);
            lblSchedule.AutoSize = true;
            lblSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSchedule.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            txt_Schedule.Location = new System.Drawing.Point(fldX, startY + rowH * 5 - 2);
            txt_Schedule.Size = new System.Drawing.Size(420, 27);
            txt_Schedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // ── Button panel ──────────────────────────────────────────
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Height = 68;
            pnlButtons.Padding = new Padding(24, 12, 24, 12);
            pnlButtons.Controls.AddRange(new Control[] { btn_AddCourse, btnClear, btnQuit });

            btn_AddCourse.Text = "Add Class";
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

            btnQuit.Text = "Cancel";
            btnQuit.Location = new System.Drawing.Point(284, 10);
            btnQuit.Size = new System.Drawing.Size(120, 42);
            btnQuit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnQuit.BackColor = System.Drawing.Color.White;
            btnQuit.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnQuit.FlatAppearance.BorderSize = 1;
            btnQuit.Cursor = Cursors.Hand;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(688, 480);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Class — Academic Management";
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            Controls.AddRange(new Control[] { pnlButtons, pnlBody, pnlHeader });

            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpClassInfo.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        // ── Field declarations ────────────────────────────────────────
        private Panel pnlHeader, pnlBody, pnlButtons;
        private Label lblTitle, lblSubtitle;
        private GroupBox grpClassInfo;
        private Label lbl_NameCourse;
        private ComboBox cbo_CourseName;
        private Label lbl_ClassID;
        private Label lbl_ClassIDAuto;
        private Label label2;
        private ComboBox cboSemester;
        private Label lbl_AcademicYear;
        private Label lbl_AcademicYearAuto;
        private Label lblCapacity;
        private TextBox txt_Capacity;
        private Label lblRoom;
        private TextBox txt_Room;
        private Label lblSchedule;
        private TextBox txt_Schedule;
        private Button btn_AddCourse;
        private Button btnClear;
        private Button btnQuit;
    }
}