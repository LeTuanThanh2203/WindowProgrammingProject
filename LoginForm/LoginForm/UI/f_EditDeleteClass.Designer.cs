namespace Project_Group6
{
    partial class f_EditDeleteClass
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
            // Left panel (grid + search)
            panel1 = new Panel();
            pnlSearch = new Panel();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvCourse = new DataGridView();

            // Right panel (edit form)
            panel2 = new Panel();
            pnlFormHeader = new Panel();
            lblFormTitle = new Label();

            lbl_NameCourse = new Label();
            cbo_CourseName = new ComboBox();
            lbl_ClassID = new Label();
            lbl_ClassIDAuto = new Label();
            label2 = new Label();
            cboSemester = new ComboBox();
            lbl_AcademicYear = new Label();
            lbl_AcademicYearAuto = new Label();
            lblCapacity = new Label();
            txt_Capacity = new TextBox();
            lblRoom = new Label();
            txt_Room = new TextBox();
            lblSchedule = new Label();
            txt_Schedule = new TextBox();

            pnlButtons = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnQuit = new Button();

            // ── Begin init ────────────────────────────────────────────
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            panel2.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // ══ LEFT PANEL ════════════════════════════════════════════
            panel1.Dock = DockStyle.Left;
            panel1.Width = 700;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BorderStyle = BorderStyle.None;
            panel1.Controls.AddRange(new Control[] { pnlSearch, dgvCourse });

            // Search bar row
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Height = 52;
            pnlSearch.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlSearch.Padding = new Padding(8, 10, 8, 8);
            pnlSearch.Controls.AddRange(new Control[] { cboSort, txtSearch });

            cboSort.Location = new System.Drawing.Point(8, 12);
            cboSort.Size = new System.Drawing.Size(148, 28);
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            txtSearch.Location = new System.Drawing.Point(164, 12);
            txtSearch.Size = new System.Drawing.Size(520, 28);
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSearch.PlaceholderText = "Search by Class ID, Course, Year...";

            // DataGridView
            dgvCourse.Dock = DockStyle.Fill;
            dgvCourse.ReadOnly = true;
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.MultiSelect = false;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.BackgroundColor = System.Drawing.Color.White;
            dgvCourse.BorderStyle = BorderStyle.None;
            dgvCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCourse.RowTemplate.Height = 36;
            // Header styling done in code-behind via ColumnHeadersDefaultCellStyle
            dgvCourse.EnableHeadersVisualStyles = false;
            dgvCourse.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            dgvCourse.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvCourse.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            dgvCourse.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 249, 253);

            // ══ RIGHT PANEL ═══════════════════════════════════════════
            panel2.Dock = DockStyle.Fill;
            panel2.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            panel2.Controls.AddRange(new Control[]
            {
                pnlFormHeader,
                lbl_NameCourse, cbo_CourseName,
                lbl_ClassID, lbl_ClassIDAuto,
                label2, cboSemester,
                lbl_AcademicYear, lbl_AcademicYearAuto,
                lblCapacity, txt_Capacity,
                lblRoom, txt_Room,
                lblSchedule, txt_Schedule,
                pnlButtons
            });

            // Form header strip inside panel2
            pnlFormHeader.Dock = DockStyle.Top;
            pnlFormHeader.Height = 52;
            pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            pnlFormHeader.Controls.Add(lblFormTitle);

            lblFormTitle.Text = "Edit / Delete Class";
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            lblFormTitle.ForeColor = System.Drawing.Color.White;
            lblFormTitle.Location = new System.Drawing.Point(20, 14);
            lblFormTitle.AutoSize = true;

            // Field layout
            int lblX = 20, fldX = 180, rowH = 50, startY = 68;

            SetLabel(lbl_NameCourse, "Course:", lblX, startY);
            cbo_CourseName.Location = new System.Drawing.Point(fldX, startY - 2);
            cbo_CourseName.Size = new System.Drawing.Size(380, 28);
            cbo_CourseName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_CourseName.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            SetLabel(lbl_ClassID, "Class ID:", lblX, startY + rowH);
            lbl_ClassIDAuto.Location = new System.Drawing.Point(fldX, startY + rowH);
            lbl_ClassIDAuto.Size = new System.Drawing.Size(300, 24);
            lbl_ClassIDAuto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            lbl_ClassIDAuto.ForeColor = System.Drawing.Color.FromArgb(10, 61, 120);

            SetLabel(label2, "Semester:", lblX, startY + rowH * 2);
            cboSemester.Location = new System.Drawing.Point(fldX, startY + rowH * 2 - 2);
            cboSemester.Size = new System.Drawing.Size(140, 28);
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            SetLabel(lbl_AcademicYear, "Academic Year:", fldX + 160, startY + rowH * 2);
            lbl_AcademicYearAuto.Location = new System.Drawing.Point(fldX + 300, startY + rowH * 2);
            lbl_AcademicYearAuto.Size = new System.Drawing.Size(100, 24);
            lbl_AcademicYearAuto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            lbl_AcademicYearAuto.ForeColor = System.Drawing.Color.FromArgb(10, 61, 120);

            SetLabel(lblCapacity, "Capacity:", lblX, startY + rowH * 3);
            txt_Capacity.Location = new System.Drawing.Point(fldX, startY + rowH * 3 - 2);
            txt_Capacity.Size = new System.Drawing.Size(100, 27);
            txt_Capacity.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_Capacity.MaxLength = 4;

            SetLabel(lblRoom, "Room:", lblX, startY + rowH * 4);
            txt_Room.Location = new System.Drawing.Point(fldX, startY + rowH * 4 - 2);
            txt_Room.Size = new System.Drawing.Size(200, 27);
            txt_Room.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            SetLabel(lblSchedule, "Schedule:", lblX, startY + rowH * 5);
            txt_Schedule.Location = new System.Drawing.Point(fldX, startY + rowH * 5 - 2);
            txt_Schedule.Size = new System.Drawing.Size(380, 27);
            txt_Schedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // Button panel
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Height = 68;
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlButtons.Controls.AddRange(new Control[] { btnUpdate, btnDelete, btnRefresh, btnQuit });

            StylePrimaryBtn(btnUpdate, "Update", 0);
            StyleDangerBtn(btnDelete, "Delete", 138);
            StyleSecondaryBtn(btnRefresh, "Refresh", 276);
            StyleSecondaryBtn(btnQuit, "Cancel", 400);

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1280, 720);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Classes — Academic Management";
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            Controls.AddRange(new Control[] { panel2, panel1 });

            panel1.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            panel2.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetLabel(Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y + 4);
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
        }

        private void StylePrimaryBtn(Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left + 16, 13);
            btn.Size = new System.Drawing.Size(110, 42);
            btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btn.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleDangerBtn(Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left + 16, 13);
            btn.Size = new System.Drawing.Size(110, 42);
            btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btn.BackColor = System.Drawing.Color.FromArgb(180, 30, 30);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        private void StyleSecondaryBtn(Button btn, string text, int left)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(left + 16, 13);
            btn.Size = new System.Drawing.Size(110, 42);
            btn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btn.BackColor = System.Drawing.Color.White;
            btn.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btn.FlatAppearance.BorderSize = 1;
            btn.Cursor = Cursors.Hand;
        }

        #endregion

        private Panel panel1, pnlSearch;
        private Panel panel2, pnlFormHeader, pnlButtons;
        private Label lblFormTitle;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private DataGridView dgvCourse;

        private Label lbl_NameCourse;
        private ComboBox cbo_CourseName;
        private Label lbl_ClassID, lbl_ClassIDAuto;
        private Label label2;
        private ComboBox cboSemester;
        private Label lbl_AcademicYear, lbl_AcademicYearAuto;
        private Label lblCapacity;
        private TextBox txt_Capacity;
        private Label lblRoom;
        private TextBox txt_Room;
        private Label lblSchedule;
        private TextBox txt_Schedule;

        private Button btnUpdate, btnDelete, btnRefresh, btnQuit;
    }
}