namespace LoginForm
{
    partial class f_ListCourse
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

            pnlToolbar = new Panel();
            txtSearch = new TextBox();
            cboSort = new ComboBox();
            btnRefresh = new Button();

            pnlGrid = new Panel();
            dgvCourse = new DataGridView();

            pnlBottom = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            lblTotal = new Label();

            // ── Suspend ───────────────────────────────────────────────
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGrid.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();

            // ── Header ────────────────────────────────────────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            lblTitle.AutoSize = false;
            lblTitle.Text = "Course Management";
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

            // ── Toolbar ───────────────────────────────────────────────
            pnlToolbar.BackColor = System.Drawing.Color.White;
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Height = 56;
            pnlToolbar.Padding = new Padding(16, 12, 16, 8);
            pnlToolbar.Controls.AddRange(new Control[] { txtSearch, cboSort, btnRefresh });

            // txtSearch
            txtSearch.Location = new System.Drawing.Point(16, 14);
            txtSearch.Size = new System.Drawing.Size(320, 27);
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSearch.PlaceholderText = "Search by ID, name, description…";
            txtSearch.BorderStyle = BorderStyle.FixedSingle;

            // cboSort
            cboSort.Location = new System.Drawing.Point(352, 13);
            cboSort.Size = new System.Drawing.Size(160, 28);
            cboSort.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.FlatStyle = FlatStyle.Flat;

            // btnRefresh
            btnRefresh.Location = new System.Drawing.Point(528, 11);
            btnRefresh.Size = new System.Drawing.Size(100, 32);
            btnRefresh.Text = "↺  Refresh";
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnRefresh.BackColor = System.Drawing.Color.White;
            btnRefresh.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnRefresh.FlatAppearance.BorderSize = 1;
            btnRefresh.Cursor = Cursors.Hand;

            // ── Grid panel ────────────────────────────────────────────
            pnlGrid.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Padding = new Padding(16, 12, 16, 8);
            pnlGrid.Controls.Add(dgvCourse);

            // dgvCourse
            dgvCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                             | AnchorStyles.Left | AnchorStyles.Right;
            dgvCourse.Location = new System.Drawing.Point(16, 12);
            dgvCourse.Size = new System.Drawing.Size(1040, 540);
            dgvCourse.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.AllowUserToDeleteRows = false;
            dgvCourse.AllowUserToResizeColumns = true;
            dgvCourse.AllowUserToResizeRows = false;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.BackgroundColor = System.Drawing.Color.White;
            dgvCourse.BorderStyle = BorderStyle.None;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.MultiSelect = false;
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowTemplate.Height = 36;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.GridColor = System.Drawing.Color.FromArgb(230, 232, 236);
            dgvCourse.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Semibold", 9F);
            dgvCourse.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(10, 61, 120);
            dgvCourse.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            dgvCourse.EnableHeadersVisualStyles = false;

            // ── Bottom panel ──────────────────────────────────────────
            pnlBottom.BackColor = System.Drawing.Color.White;
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Height = 68;
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Controls.AddRange(new Control[] { btnAdd, btnEdit, lblTotal });

            // btnAdd
            btnAdd.Location = new System.Drawing.Point(24, 14);
            btnAdd.Size = new System.Drawing.Size(130, 42);
            btnAdd.Text = "＋  Add Course";
            btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btnAdd.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;

            // btnEdit
            btnEdit.Location = new System.Drawing.Point(168, 14);
            btnEdit.Size = new System.Drawing.Size(130, 42);
            btnEdit.Text = "✎  Edit / Delete";
            btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btnEdit.BackColor = System.Drawing.Color.White;
            btnEdit.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnEdit.FlatAppearance.BorderSize = 1;
            btnEdit.Cursor = Cursors.Hand;

            // lblTotal
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(320, 22);
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(80, 80, 90);
            lblTotal.Text = "Total Course: 0";

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1083, 760);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            MinimumSize = new System.Drawing.Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Management — Academic System";
            BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            Controls.AddRange(new Control[] { pnlGrid, pnlBottom, pnlToolbar, pnlHeader });

            pnlHeader.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ── Field declarations ────────────────────────────────────────
        private Panel pnlHeader, pnlToolbar, pnlGrid, pnlBottom;
        private Label lblTitle, lblSubtitle;
        private TextBox txtSearch;
        private ComboBox cboSort;
        private Button btnRefresh;
        private DataGridView dgvCourse;
        private Button btnAdd;
        private Button btnEdit;
        private Label lblTotal;
    }
}