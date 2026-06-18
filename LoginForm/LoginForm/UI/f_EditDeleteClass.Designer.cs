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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();
            grpClassDetails = new GroupBox();
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
            grpClassList = new GroupBox();
            lblSortCaption = new Label();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvClass = new DataGridView();
            pnlButtons = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnQuit = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpClassDetails.SuspendLayout();
            grpClassList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
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
            lblTitle.Size = new Size(211, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Classes";
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
            pnlBody.Controls.Add(grpClassDetails);
            pnlBody.Controls.Add(grpClassList);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20, 16, 20, 12);
            pnlBody.Size = new Size(1300, 612);
            pnlBody.TabIndex = 0;
            // 
            // grpClassDetails
            // 
            grpClassDetails.BackColor = Color.White;
            grpClassDetails.Controls.Add(lbl_NameCourse);
            grpClassDetails.Controls.Add(cbo_CourseName);
            grpClassDetails.Controls.Add(lbl_ClassID);
            grpClassDetails.Controls.Add(lbl_ClassIDAuto);
            grpClassDetails.Controls.Add(label2);
            grpClassDetails.Controls.Add(cboSemester);
            grpClassDetails.Controls.Add(lbl_AcademicYear);
            grpClassDetails.Controls.Add(lbl_AcademicYearAuto);
            grpClassDetails.Controls.Add(lblCapacity);
            grpClassDetails.Controls.Add(txt_Capacity);
            grpClassDetails.Controls.Add(lblRoom);
            grpClassDetails.Controls.Add(txt_Room);
            grpClassDetails.Controls.Add(lblSchedule);
            grpClassDetails.Controls.Add(txt_Schedule);
            grpClassDetails.Dock = DockStyle.Fill;
            grpClassDetails.Font = new Font("Segoe UI Semibold", 9.5F);
            grpClassDetails.ForeColor = Color.FromArgb(10, 61, 120);
            grpClassDetails.Location = new Point(660, 16);
            grpClassDetails.Name = "grpClassDetails";
            grpClassDetails.Padding = new Padding(16);
            grpClassDetails.Size = new Size(620, 584);
            grpClassDetails.TabIndex = 0;
            grpClassDetails.TabStop = false;
            grpClassDetails.Text = "Class Details";
            // 
            // lbl_NameCourse
            // 
            lbl_NameCourse.Text = "Course:";
            lbl_NameCourse.Location = new Point(20, 32);
            lbl_NameCourse.AutoSize = true;
            lbl_NameCourse.Font = new Font("Segoe UI", 9.5F);
            lbl_NameCourse.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_NameCourse.Name = "lbl_NameCourse";
            lbl_NameCourse.Size = new Size(100, 23);
            lbl_NameCourse.TabIndex = 0;
            // 
            // cbo_CourseName
            // 
            cbo_CourseName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_CourseName.Font = new Font("Segoe UI", 9.5F);
            cbo_CourseName.Location = new Point(160, 32);
            cbo_CourseName.Name = "cbo_CourseName";
            cbo_CourseName.Size = new Size(420, 29);
            cbo_CourseName.TabIndex = 1;
            cbo_CourseName.SelectedIndexChanged += cbo_CourseName_SelectedIndexChanged;
            // 
            // lbl_ClassID
            // 
            lbl_ClassID.Text = "Class ID:";
            lbl_ClassID.Location = new Point(20, 76);
            lbl_ClassID.AutoSize = true;
            lbl_ClassID.Font = new Font("Segoe UI", 9.5F);
            lbl_ClassID.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_ClassID.Name = "lbl_ClassID";
            lbl_ClassID.Size = new Size(100, 23);
            lbl_ClassID.TabIndex = 2;
            // 
            // lbl_ClassIDAuto
            // 
            lbl_ClassIDAuto.Font = new Font("Segoe UI Semibold", 10F);
            lbl_ClassIDAuto.ForeColor = Color.FromArgb(10, 61, 120);
            lbl_ClassIDAuto.Location = new Point(160, 76);
            lbl_ClassIDAuto.Name = "lbl_ClassIDAuto";
            lbl_ClassIDAuto.Size = new Size(300, 24);
            lbl_ClassIDAuto.TabIndex = 3;
            // 
            // label2
            // 
            label2.Text = "Semester:";
            label2.Location = new Point(20, 120);
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F);
            label2.ForeColor = Color.FromArgb(80, 80, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            // 
            // cboSemester
            // 
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.Font = new Font("Segoe UI", 9.5F);
            cboSemester.Location = new Point(160, 120);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(120, 29);
            cboSemester.TabIndex = 5;
            // 
            // lbl_AcademicYear
            // 
            lbl_AcademicYear.Text = "Academic Year:";
            lbl_AcademicYear.Location = new Point(320, 120);
            lbl_AcademicYear.AutoSize = true;
            lbl_AcademicYear.Font = new Font("Segoe UI", 9.5F);
            lbl_AcademicYear.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_AcademicYear.Name = "lbl_AcademicYear";
            lbl_AcademicYear.Size = new Size(100, 23);
            lbl_AcademicYear.TabIndex = 6;
            // 
            // lbl_AcademicYearAuto
            // 
            lbl_AcademicYearAuto.Font = new Font("Segoe UI Semibold", 10F);
            lbl_AcademicYearAuto.ForeColor = Color.FromArgb(10, 61, 120);
            lbl_AcademicYearAuto.Location = new Point(440, 120);
            lbl_AcademicYearAuto.Name = "lbl_AcademicYearAuto";
            lbl_AcademicYearAuto.Size = new Size(120, 24);
            lbl_AcademicYearAuto.TabIndex = 7;
            // 
            // lblCapacity
            // 
            lblCapacity.Text = "Capacity:";
            lblCapacity.Location = new Point(20, 164);
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9.5F);
            lblCapacity.ForeColor = Color.FromArgb(80, 80, 90);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(100, 23);
            lblCapacity.TabIndex = 8;
            // 
            // txt_Capacity
            // 
            txt_Capacity.Font = new Font("Segoe UI", 9.5F);
            txt_Capacity.Location = new Point(160, 164);
            txt_Capacity.Name = "txt_Capacity";
            txt_Capacity.Size = new Size(120, 29);
            txt_Capacity.TabIndex = 9;
            // 
            // lblRoom
            // 
            lblRoom.Text = "Room:";
            lblRoom.Location = new Point(20, 208);
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 9.5F);
            lblRoom.ForeColor = Color.FromArgb(80, 80, 90);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(100, 23);
            lblRoom.TabIndex = 10;
            // 
            // txt_Room
            // 
            txt_Room.Font = new Font("Segoe UI", 9.5F);
            txt_Room.Location = new Point(160, 208);
            txt_Room.Name = "txt_Room";
            txt_Room.Size = new Size(420, 29);
            txt_Room.TabIndex = 11;
            // 
            // lblSchedule
            // 
            lblSchedule.Text = "Schedule:";
            lblSchedule.Location = new Point(20, 252);
            lblSchedule.AutoSize = true;
            lblSchedule.Font = new Font("Segoe UI", 9.5F);
            lblSchedule.ForeColor = Color.FromArgb(80, 80, 90);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(100, 23);
            lblSchedule.TabIndex = 12;
            // 
            // txt_Schedule
            // 
            txt_Schedule.Font = new Font("Segoe UI", 9.5F);
            txt_Schedule.Location = new Point(160, 252);
            txt_Schedule.Name = "txt_Schedule";
            txt_Schedule.Size = new Size(420, 29);
            txt_Schedule.TabIndex = 13;
            // 
            // grpClassList
            // 
            grpClassList.BackColor = Color.White;
            grpClassList.Controls.Add(lblSortCaption);
            grpClassList.Controls.Add(cboSort);
            grpClassList.Controls.Add(txtSearch);
            grpClassList.Controls.Add(dgvClass);
            grpClassList.Dock = DockStyle.Left;
            grpClassList.Font = new Font("Segoe UI Semibold", 9.5F);
            grpClassList.ForeColor = Color.FromArgb(10, 61, 120);
            grpClassList.Location = new Point(20, 16);
            grpClassList.Margin = new Padding(0, 0, 16, 0);
            grpClassList.Name = "grpClassList";
            grpClassList.Padding = new Padding(16);
            grpClassList.Size = new Size(640, 584);
            grpClassList.TabIndex = 1;
            grpClassList.TabStop = false;
            grpClassList.Text = "Class List";
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
            txtSearch.PlaceholderText = "Search classes";
            txtSearch.Size = new Size(370, 29);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvClass
            // 
            dgvClass.AllowUserToResizeColumns = false;
            dgvClass.AllowUserToResizeRows = false;
            dgvClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClass.ColumnHeadersHeight = 29;
            dgvClass.Location = new Point(16, 74);
            dgvClass.Name = "dgvClass";
            dgvClass.RowHeadersWidth = 51;
            dgvClass.Size = new Size(600, 984);
            dgvClass.TabIndex = 3;
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
            pnlButtons.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Text = "Update Class";
            btnUpdate.Location = new Point(24, 10);
            btnUpdate.Size = new Size(130, 42);
            btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btnUpdate.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.TabIndex = 0;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Text = "Delete Class";
            btnDelete.Location = new Point(178, 10);
            btnDelete.Size = new Size(130, 42);
            btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 57);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.Name = "btnDelete";
            btnDelete.TabIndex = 1;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Text = "Reset";
            btnRefresh.Location = new Point(332, 10);
            btnRefresh.Size = new Size(110, 42);
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnRefresh.BackColor = System.Drawing.Color.White;
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnRefresh.FlatAppearance.BorderSize = 1;
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.TabIndex = 2;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnQuit
            // 
            btnQuit.Text = "Cancel";
            btnQuit.Location = new Point(466, 10);
            btnQuit.Size = new Size(110, 42);
            btnQuit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnQuit.BackColor = System.Drawing.Color.White;
            btnQuit.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnQuit.FlatAppearance.BorderSize = 1;
            btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnQuit.Name = "btnQuit";
            btnQuit.TabIndex = 3;
            btnQuit.Click += btnQuit_Click;
            // 
            // f_EditDeleteClass
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1300, 760);
            Controls.Add(pnlBody);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_EditDeleteClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Classes — Academic Management";
            Load += f_EditDeleteClass_Load;
            Shown += f_EditDeleteClass_Shown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            grpClassDetails.ResumeLayout(false);
            grpClassDetails.PerformLayout();
            grpClassList.ResumeLayout(false);
            grpClassList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox grpClassList;
        private System.Windows.Forms.Label lblSortCaption;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvClass;

        private System.Windows.Forms.GroupBox grpClassDetails;
        private System.Windows.Forms.Label lbl_NameCourse;
        private System.Windows.Forms.ComboBox cbo_CourseName;
        private System.Windows.Forms.Label lbl_ClassID;
        private System.Windows.Forms.Label lbl_ClassIDAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.Label lbl_AcademicYear;
        private System.Windows.Forms.Label lbl_AcademicYearAuto;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.TextBox txt_Room;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.TextBox txt_Schedule;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuit;
    }
}