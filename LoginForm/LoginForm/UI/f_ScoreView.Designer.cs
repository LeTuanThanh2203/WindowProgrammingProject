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
            // ── Controls ──────────────────────────────────────────────
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();

            pnlBody = new Panel();

            // Profile card (left)
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

            // Score card (right)
            grpScores = new GroupBox();
            lblSortCaption = new Label();
            cboSort = new ComboBox();
            lblFilterCaption = new Label();
            cboOverviewFilter = new ComboBox();
            txtSearch = new TextBox();
            dgvScore = new DataGridView();

            // Footer
            pnFunction = new Panel();
            lblTotalScore = new Label();
            lblOverview = new Label();
            btnClose = new Button();

            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            grpScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScore).BeginInit();
            pnFunction.SuspendLayout();
            SuspendLayout();

            // ── Header panel ──────────────────────────────────────────
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Padding = new Padding(24, 0, 0, 0);
            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            lblTitle.AutoSize = false;
            lblTitle.Text = "Student Scores";
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Size = new Size(400, 30);

            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "University Academic Management System";
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Size = new Size(400, 20);

            // ── Body panel ────────────────────────────────────────────
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Padding = new Padding(24, 20, 24, 12);
            pnlBody.Controls.AddRange(new Control[] { grpScores, grpProfile });

            // ── Profile card ──────────────────────────────────────────
            grpProfile.Text = "Student Information";
            grpProfile.Font = new Font("Segoe UI Semibold", 9.5F);
            grpProfile.ForeColor = Color.FromArgb(10, 61, 120);
            grpProfile.BackColor = Color.White;
            grpProfile.Dock = DockStyle.Left;
            grpProfile.Width = 300;
            grpProfile.Margin = new Padding(0, 0, 16, 0);
            grpProfile.Padding = new Padding(16, 16, 16, 16);
            grpProfile.Controls.AddRange(new Control[]
            {
                picStudent,
                lblCaptionID, lblID,
                lblCaptionFirstname, lblFirstname,
                lblCaptionLastname, lblLastname,
                lblCaptionDob, lblDob,
                lblCaptionGender, lblGender,
                lblCaptionPhone, lblPhone,
                lblCaptionAddress, lblAddress,
                lblCaptionEmail, lblEmail
            });

            picStudent.Location = new Point(70, 32);
            picStudent.Size = new Size(160, 180);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabStop = false;

            SetCaption(lblCaptionID, "ID:", 232);
            SetValueAuto(lblID, 232);

            SetCaption(lblCaptionFirstname, "Firstname:", 274);
            SetValueAuto(lblFirstname, 274);

            SetCaption(lblCaptionLastname, "Lastname:", 316);
            SetValueAuto(lblLastname, 316);

            SetCaption(lblCaptionDob, "Date of birth:", 358);
            SetValueAuto(lblDob, 358);

            SetCaption(lblCaptionGender, "Gender:", 400);
            SetValueAuto(lblGender, 400);

            SetCaption(lblCaptionPhone, "Phone:", 442);
            SetValueAuto(lblPhone, 442);

            SetCaption(lblCaptionAddress, "Address:", 484);
            SetValueWrap(lblAddress, 484, 44);

            SetCaption(lblCaptionEmail, "Email:", 536);
            SetValueWrap(lblEmail, 536, 44);

            // ── Score card ────────────────────────────────────────────
            grpScores.Text = "Score Details";
            grpScores.Font = new Font("Segoe UI Semibold", 9.5F);
            grpScores.ForeColor = Color.FromArgb(10, 61, 120);
            grpScores.BackColor = Color.White;
            grpScores.Dock = DockStyle.Fill;
            grpScores.Padding = new Padding(16, 16, 16, 16);
            grpScores.Controls.AddRange(new Control[]
            {
                lblSortCaption, cboSort,
                lblFilterCaption, cboOverviewFilter,
                txtSearch, dgvScore
            });

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

            lblFilterCaption.AutoSize = true;
            lblFilterCaption.Text = "Filter:";
            lblFilterCaption.Font = new Font("Segoe UI", 9.5F);
            lblFilterCaption.ForeColor = Color.FromArgb(80, 80, 90);
            lblFilterCaption.Location = new Point(250, 32);

            cboOverviewFilter.FormattingEnabled = true;
            cboOverviewFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOverviewFilter.Font = new Font("Segoe UI", 9.5F);
            cboOverviewFilter.Location = new Point(305, 28);
            cboOverviewFilter.Size = new Size(150, 28);

            txtSearch.PlaceholderText = "Search by course or semester";
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(475, 28);
            txtSearch.Size = new Size(380, 27);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            dgvScore.AllowUserToAddRows = false;
            dgvScore.AllowUserToDeleteRows = false;
            dgvScore.AllowUserToResizeColumns = false;
            dgvScore.AllowUserToResizeRows = false;
            dgvScore.BackgroundColor = SystemColors.Control;
            dgvScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScore.ReadOnly = true;
            dgvScore.RowHeadersVisible = false;
            dgvScore.RowHeadersWidth = 51;
            dgvScore.Location = new Point(16, 74);
            dgvScore.Size = new Size(884, 560);
            dgvScore.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvScore.TabIndex = 0;

            // ── Footer panel ──────────────────────────────────────────
            pnFunction.BackColor = Color.FromArgb(245, 247, 250);
            pnFunction.Dock = DockStyle.Bottom;
            pnFunction.Height = 70;
            pnFunction.Padding = new Padding(24, 12, 24, 12);
            pnFunction.Controls.AddRange(new Control[] { lblTotalScore, lblOverview, btnClose });

            lblTotalScore.AutoSize = true;
            lblTotalScore.Text = "Total: --";
            lblTotalScore.Font = new Font("Segoe UI Semibold", 11F);
            lblTotalScore.ForeColor = Color.FromArgb(10, 61, 120);
            lblTotalScore.Location = new Point(24, 22);

            lblOverview.AutoSize = true;
            lblOverview.Text = "Overview: --";
            lblOverview.Font = new Font("Segoe UI Semibold", 11F);
            lblOverview.ForeColor = Color.FromArgb(80, 80, 90);
            lblOverview.Location = new Point(220, 22);

            StyleSecondaryBtn(btnClose, "Close", 1056, 14);
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Font = new Font("Segoe UI", 9.5F);
            BackColor = Color.FromArgb(245, 247, 250);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "f_ScoreView";
            Text = "Student Scores — Academic Management";

            Controls.AddRange(new Control[] { pnFunction, pnlBody, pnlHeader });

            pnlHeader.ResumeLayout(false);
            grpProfile.ResumeLayout(false);
            grpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            grpScores.ResumeLayout(false);
            grpScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvScore).EndInit();
            pnlBody.ResumeLayout(false);
            pnFunction.ResumeLayout(false);
            pnFunction.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Helpers ───────────────────────────────────────────────────
        private void SetCaption(Label lbl, string text, int y)
        {
            lbl.Text = text;
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9.5F);
            lbl.ForeColor = Color.FromArgb(80, 80, 90);
            lbl.Location = new Point(16, y);
        }

        private void SetValueAuto(Label lbl, int y)
        {
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 10F);
            lbl.ForeColor = Color.FromArgb(10, 61, 120);
            lbl.Location = new Point(120, y);
        }

        private void SetValueWrap(Label lbl, int y, int height)
        {
            lbl.AutoSize = false;
            lbl.Font = new Font("Segoe UI Semibold", 10F);
            lbl.ForeColor = Color.FromArgb(10, 61, 120);
            lbl.Location = new Point(120, y);
            lbl.Size = new Size(160, height);
        }

        private void StyleSecondaryBtn(Button btn, string text, int left, int top)
        {
            btn.Text = text;
            btn.Location = new Point(left, top);
            btn.Size = new Size(120, 42);
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
        private ComboBox cboSort;
        private Label lblFilterCaption;
        private ComboBox cboOverviewFilter;
        private TextBox txtSearch;
        private DataGridView dgvScore;

        private Panel pnFunction;
        private Label lblTotalScore;
        private Label lblOverview;
        private Button btnClose;
    }
}