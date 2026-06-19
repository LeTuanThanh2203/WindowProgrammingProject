namespace Project_Group6
{
    partial class f_ScoreView
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
            grpScores = new GroupBox();
            lblSortCaption = new Label();
            lblFilterCaption = new Label();
            cboOverviewFilter = new ComboBox();
            txtSearch = new TextBox();
            dgvScore = new DataGridView();
            grpProfile = new GroupBox();
            picStudent = new PictureBox();
            lblCaptionID = new Label();
            lblID = new Label();
            lblCaptionFirstname = new Label();
            lblFirstname = new Label();
            lblCaptionLastname = new Label();
            lblLastname = new Label();
            lblCaptionDob = new Label();
            lblDob = new Label();
            lblCaptionGender = new Label();
            lblGender = new Label();
            lblCaptionPhone = new Label();
            lblPhone = new Label();
            lblCaptionAddress = new Label();
            lblAddress = new Label();
            lblCaptionEmail = new Label();
            lblEmail = new Label();
            pnFunction = new Panel();
            lblTotalScore = new Label();
            lblOverview = new Label();
            btnClose = new Button();
            cboSort = new ComboBox();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScore).BeginInit();
            grpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            pnFunction.SuspendLayout();
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
            pnlHeader.Padding = new Padding(24, 0, 0, 0);
            pnlHeader.Size = new Size(1200, 80);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Scores";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "University Academic Management System";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(grpScores);
            pnlBody.Controls.Add(grpProfile);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(24, 20, 24, 12);
            pnlBody.Size = new Size(1200, 650);
            pnlBody.TabIndex = 1;
            // 
            // grpScores
            // 
            grpScores.BackColor = Color.White;
            grpScores.Controls.Add(lblSortCaption);
            grpScores.Controls.Add(cboSort);
            grpScores.Controls.Add(lblFilterCaption);
            grpScores.Controls.Add(cboOverviewFilter);
            grpScores.Controls.Add(txtSearch);
            grpScores.Controls.Add(dgvScore);
            grpScores.Dock = DockStyle.Fill;
            grpScores.Font = new Font("Segoe UI Semibold", 9.5F);
            grpScores.ForeColor = Color.FromArgb(10, 61, 120);
            grpScores.Location = new Point(324, 20);
            grpScores.Name = "grpScores";
            grpScores.Padding = new Padding(16);
            grpScores.Size = new Size(852, 618);
            grpScores.TabIndex = 0;
            grpScores.TabStop = false;
            grpScores.Text = "Score Details";
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
            // lblFilterCaption
            // 
            lblFilterCaption.AutoSize = true;
            lblFilterCaption.Font = new Font("Segoe UI", 9.5F);
            lblFilterCaption.ForeColor = Color.FromArgb(80, 80, 90);
            lblFilterCaption.Location = new Point(250, 32);
            lblFilterCaption.Name = "lblFilterCaption";
            lblFilterCaption.Size = new Size(48, 21);
            lblFilterCaption.TabIndex = 2;
            lblFilterCaption.Text = "Filter:";
            // 
            // cboOverviewFilter
            // 
            cboOverviewFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOverviewFilter.Font = new Font("Segoe UI", 9.5F);
            cboOverviewFilter.FormattingEnabled = true;
            cboOverviewFilter.Location = new Point(305, 28);
            cboOverviewFilter.Name = "cboOverviewFilter";
            cboOverviewFilter.Size = new Size(150, 29);
            cboOverviewFilter.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(475, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by course or semester";
            txtSearch.Size = new Size(357, 29);
            txtSearch.TabIndex = 4;
            // 
            // dgvScore
            // 
            dgvScore.AllowUserToAddRows = false;
            dgvScore.AllowUserToDeleteRows = false;
            dgvScore.AllowUserToResizeColumns = false;
            dgvScore.AllowUserToResizeRows = false;
            dgvScore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvScore.BackgroundColor = SystemColors.Control;
            dgvScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScore.Location = new Point(16, 74);
            dgvScore.Name = "dgvScore";
            dgvScore.ReadOnly = true;
            dgvScore.RowHeadersVisible = false;
            dgvScore.RowHeadersWidth = 51;
            dgvScore.Size = new Size(820, 528);
            dgvScore.TabIndex = 0;
            // 
            // grpProfile
            // 
            grpProfile.BackColor = Color.White;
            grpProfile.Controls.Add(picStudent);
            grpProfile.Controls.Add(lblCaptionID);
            grpProfile.Controls.Add(lblID);
            grpProfile.Controls.Add(lblCaptionFirstname);
            grpProfile.Controls.Add(lblFirstname);
            grpProfile.Controls.Add(lblCaptionLastname);
            grpProfile.Controls.Add(lblLastname);
            grpProfile.Controls.Add(lblCaptionDob);
            grpProfile.Controls.Add(lblDob);
            grpProfile.Controls.Add(lblCaptionGender);
            grpProfile.Controls.Add(lblGender);
            grpProfile.Controls.Add(lblCaptionPhone);
            grpProfile.Controls.Add(lblPhone);
            grpProfile.Controls.Add(lblCaptionAddress);
            grpProfile.Controls.Add(lblAddress);
            grpProfile.Controls.Add(lblCaptionEmail);
            grpProfile.Controls.Add(lblEmail);
            grpProfile.Dock = DockStyle.Left;
            grpProfile.Font = new Font("Segoe UI Semibold", 9.5F);
            grpProfile.ForeColor = Color.FromArgb(10, 61, 120);
            grpProfile.Location = new Point(24, 20);
            grpProfile.Margin = new Padding(0, 0, 16, 0);
            grpProfile.Name = "grpProfile";
            grpProfile.Padding = new Padding(16);
            grpProfile.Size = new Size(300, 618);
            grpProfile.TabIndex = 1;
            grpProfile.TabStop = false;
            grpProfile.Text = "Student Information";
            // 
            // picStudent
            // 
            picStudent.Location = new Point(70, 32);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(160, 180);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabIndex = 0;
            picStudent.TabStop = false;
            // 
            // lblCaptionID
            // 
            lblCaptionID.AutoSize = true;
            lblCaptionID.Font = new Font("Segoe UI", 9.5F);
            lblCaptionID.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionID.Location = new Point(16, 236);
            lblCaptionID.Name = "lblCaptionID";
            lblCaptionID.Size = new Size(28, 21);
            lblCaptionID.TabIndex = 1;
            lblCaptionID.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 10F);
            lblID.ForeColor = Color.FromArgb(10, 61, 120);
            lblID.Location = new Point(120, 236);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 23);
            lblID.TabIndex = 2;
            // 
            // lblCaptionFirstname
            // 
            lblCaptionFirstname.AutoSize = true;
            lblCaptionFirstname.Font = new Font("Segoe UI", 9.5F);
            lblCaptionFirstname.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionFirstname.Location = new Point(16, 270);
            lblCaptionFirstname.Name = "lblCaptionFirstname";
            lblCaptionFirstname.Size = new Size(89, 21);
            lblCaptionFirstname.TabIndex = 3;
            lblCaptionFirstname.Text = "First Name:";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI Semibold", 10F);
            lblFirstname.ForeColor = Color.FromArgb(10, 61, 120);
            lblFirstname.Location = new Point(120, 270);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(0, 23);
            lblFirstname.TabIndex = 4;
            // 
            // lblCaptionLastname
            // 
            lblCaptionLastname.AutoSize = true;
            lblCaptionLastname.Font = new Font("Segoe UI", 9.5F);
            lblCaptionLastname.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionLastname.Location = new Point(16, 304);
            lblCaptionLastname.Name = "lblCaptionLastname";
            lblCaptionLastname.Size = new Size(87, 21);
            lblCaptionLastname.TabIndex = 5;
            lblCaptionLastname.Text = "Last Name:";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI Semibold", 10F);
            lblLastname.ForeColor = Color.FromArgb(10, 61, 120);
            lblLastname.Location = new Point(120, 304);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(0, 23);
            lblLastname.TabIndex = 6;
            // 
            // lblCaptionDob
            // 
            lblCaptionDob.AutoSize = true;
            lblCaptionDob.Font = new Font("Segoe UI", 9.5F);
            lblCaptionDob.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionDob.Location = new Point(16, 338);
            lblCaptionDob.Name = "lblCaptionDob";
            lblCaptionDob.Size = new Size(100, 21);
            lblCaptionDob.TabIndex = 7;
            lblCaptionDob.Text = "Date of Birth:";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI Semibold", 10F);
            lblDob.ForeColor = Color.FromArgb(10, 61, 120);
            lblDob.Location = new Point(120, 338);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(0, 23);
            lblDob.TabIndex = 8;
            // 
            // lblCaptionGender
            // 
            lblCaptionGender.AutoSize = true;
            lblCaptionGender.Font = new Font("Segoe UI", 9.5F);
            lblCaptionGender.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionGender.Location = new Point(16, 372);
            lblCaptionGender.Name = "lblCaptionGender";
            lblCaptionGender.Size = new Size(64, 21);
            lblCaptionGender.TabIndex = 9;
            lblCaptionGender.Text = "Gender:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 10F);
            lblGender.ForeColor = Color.FromArgb(10, 61, 120);
            lblGender.Location = new Point(120, 372);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(0, 23);
            lblGender.TabIndex = 10;
            // 
            // lblCaptionPhone
            // 
            lblCaptionPhone.AutoSize = true;
            lblCaptionPhone.Font = new Font("Segoe UI", 9.5F);
            lblCaptionPhone.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionPhone.Location = new Point(16, 406);
            lblCaptionPhone.Name = "lblCaptionPhone";
            lblCaptionPhone.Size = new Size(57, 21);
            lblCaptionPhone.TabIndex = 11;
            lblCaptionPhone.Text = "Phone:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10F);
            lblPhone.ForeColor = Color.FromArgb(10, 61, 120);
            lblPhone.Location = new Point(120, 406);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(0, 23);
            lblPhone.TabIndex = 12;
            // 
            // lblCaptionAddress
            // 
            lblCaptionAddress.AutoSize = true;
            lblCaptionAddress.Font = new Font("Segoe UI", 9.5F);
            lblCaptionAddress.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionAddress.Location = new Point(16, 440);
            lblCaptionAddress.Name = "lblCaptionAddress";
            lblCaptionAddress.Size = new Size(69, 21);
            lblCaptionAddress.TabIndex = 13;
            lblCaptionAddress.Text = "Address:";
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI Semibold", 10F);
            lblAddress.ForeColor = Color.FromArgb(10, 61, 120);
            lblAddress.Location = new Point(120, 440);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(160, 48);
            lblAddress.TabIndex = 14;
            // 
            // lblCaptionEmail
            // 
            lblCaptionEmail.AutoSize = true;
            lblCaptionEmail.Font = new Font("Segoe UI", 9.5F);
            lblCaptionEmail.ForeColor = Color.FromArgb(80, 80, 90);
            lblCaptionEmail.Location = new Point(16, 504);
            lblCaptionEmail.Name = "lblCaptionEmail";
            lblCaptionEmail.Size = new Size(51, 21);
            lblCaptionEmail.TabIndex = 15;
            lblCaptionEmail.Text = "Email:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F);
            lblEmail.ForeColor = Color.FromArgb(10, 61, 120);
            lblEmail.Location = new Point(120, 504);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 23);
            lblEmail.TabIndex = 16;
            // 
            // pnFunction
            // 
            pnFunction.BackColor = Color.FromArgb(245, 247, 250);
            pnFunction.Controls.Add(lblTotalScore);
            pnFunction.Controls.Add(lblOverview);
            pnFunction.Controls.Add(btnClose);
            pnFunction.Dock = DockStyle.Bottom;
            pnFunction.Location = new Point(0, 730);
            pnFunction.Name = "pnFunction";
            pnFunction.Padding = new Padding(24, 12, 24, 12);
            pnFunction.Size = new Size(1200, 70);
            pnFunction.TabIndex = 0;
            // 
            // lblTotalScore
            // 
            lblTotalScore.AutoSize = true;
            lblTotalScore.Font = new Font("Segoe UI Semibold", 11F);
            lblTotalScore.ForeColor = Color.FromArgb(10, 61, 120);
            lblTotalScore.Location = new Point(24, 22);
            lblTotalScore.Name = "lblTotalScore";
            lblTotalScore.Size = new Size(79, 25);
            lblTotalScore.TabIndex = 0;
            lblTotalScore.Text = "Total: --";
            // 
            // lblOverview
            // 
            lblOverview.AutoSize = true;
            lblOverview.Font = new Font("Segoe UI Semibold", 11F);
            lblOverview.ForeColor = Color.FromArgb(80, 80, 90);
            lblOverview.Location = new Point(220, 22);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(119, 25);
            lblOverview.TabIndex = 1;
            lblOverview.Text = "Overview: --";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.ForeColor = Color.FromArgb(60, 70, 85);
            btnClose.Location = new Point(1050, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 42);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
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
            // 
            // f_ScoreView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1200, 800);
            Controls.Add(pnlBody);
            Controls.Add(pnFunction);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_ScoreView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Scores — Academic Management";
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpScores.ResumeLayout(false);
            grpScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScore).EndInit();
            grpProfile.ResumeLayout(false);
            grpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            pnFunction.ResumeLayout(false);
            pnFunction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────────
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel pnlBody;

        private GroupBox grpProfile;
        private PictureBox picStudent;
        private Label lblCaptionID;
        private Label lblID;
        private Label lblCaptionFirstname;
        private Label lblFirstname;
        private Label lblCaptionLastname;
        private Label lblLastname;
        private Label lblCaptionDob;
        private Label lblDob;
        private Label lblCaptionGender;
        private Label lblGender;
        private Label lblCaptionPhone;
        private Label lblPhone;
        private Label lblCaptionAddress;
        private Label lblAddress;
        private Label lblCaptionEmail;
        private Label lblEmail;

        private GroupBox grpScores;
        private Label lblSortCaption;
        private Label lblFilterCaption;
        private ComboBox cboOverviewFilter;
        private TextBox txtSearch;
        private DataGridView dgvScore;

        private Panel pnFunction;
        private Label lblTotalScore;
        private Label lblOverview;
        private Button btnClose;
        private ComboBox cboSort;
    }
}