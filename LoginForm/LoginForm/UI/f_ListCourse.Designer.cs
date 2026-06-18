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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            pnlPagination = new Panel();
            cboPageSize = new ComboBox();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            pnlBottom.SuspendLayout();
            pnlPagination.SuspendLayout();
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
            pnlHeader.Size = new Size(1083, 80);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Course Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(25, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(302, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "University Academic Management System";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(cboSort);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(16, 12, 16, 8);
            pnlToolbar.Size = new Size(1083, 56);
            pnlToolbar.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(16, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, name, description…";
            txtSearch.Size = new Size(320, 29);
            txtSearch.TabIndex = 0;
            // 
            // cboSort
            // 
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.FlatStyle = FlatStyle.Flat;
            cboSort.Font = new Font("Segoe UI", 9.5F);
            cboSort.Location = new Point(352, 13);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(160, 29);
            cboSort.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.FromArgb(60, 70, 85);
            btnRefresh.Location = new Point(528, 11);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 32);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "↺  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(dgvCourse);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 136);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(16, 12, 16, 8);
            pnlGrid.Size = new Size(1083, 556);
            pnlGrid.TabIndex = 0;
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.AllowUserToDeleteRows = false;
            dgvCourse.AllowUserToResizeColumns = false;
            dgvCourse.AllowUserToResizeRows = false;
            dgvCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCourse.BackgroundColor = Color.White;
            dgvCourse.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.EnableHeadersVisualStyles = false;
            dgvCourse.Font = new Font("Segoe UI", 9.5F);
            dgvCourse.GridColor = Color.FromArgb(230, 232, 236);
            dgvCourse.Location = new Point(16, 12);
            dgvCourse.MultiSelect = false;
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.RowTemplate.Height = 36;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Size = new Size(1043, 533);
            dgvCourse.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnAdd);
            pnlBottom.Controls.Add(btnEdit);
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 692);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(1083, 68);
            pnlBottom.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(10, 61, 120);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.5F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "＋  Add Course";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9.5F);
            btnEdit.ForeColor = Color.FromArgb(60, 70, 85);
            btnEdit.Location = new Point(168, 14);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 42);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✎  Edit / Delete";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(320, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(111, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total Course: 0";
            // 
            // pnlPagination
            // 
            pnlPagination.Controls.Add(cboPageSize);
            pnlPagination.Controls.Add(btnFirst);
            pnlPagination.Controls.Add(btnPrev);
            pnlPagination.Controls.Add(lblPageInfo);
            pnlPagination.Controls.Add(btnNext);
            pnlPagination.Controls.Add(btnLast);
            pnlPagination.Dock = DockStyle.Right;
            pnlPagination.Location = new Point(679, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 44);
            pnlPagination.TabIndex = 3;
            // 
            // cboPageSize
            // 
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPageSize.Font = new Font("Segoe UI", 9.5F);
            cboPageSize.Location = new Point(10, 19);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(60, 29);
            cboPageSize.TabIndex = 0;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.White;
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Segoe UI", 9F);
            btnFirst.ForeColor = Color.FromArgb(60, 70, 85);
            btnFirst.Location = new Point(80, 17);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(36, 32);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "|◀";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.White;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 9F);
            btnPrev.ForeColor = Color.FromArgb(60, 70, 85);
            btnPrev.Location = new Point(120, 17);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◀";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Font = new Font("Segoe UI", 9.5F);
            lblPageInfo.Location = new Point(162, 22);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(120, 20);
            lblPageInfo.TabIndex = 3;
            lblPageInfo.Text = "Page 1 of 1";
            lblPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.FromArgb(60, 70, 85);
            btnNext.Location = new Point(290, 17);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 32);
            btnNext.TabIndex = 4;
            btnNext.Text = "▶";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.White;
            btnLast.Cursor = Cursors.Hand;
            btnLast.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Segoe UI", 9F);
            btnLast.ForeColor = Color.FromArgb(60, 70, 85);
            btnLast.Location = new Point(330, 17);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 32);
            btnLast.TabIndex = 5;
            btnLast.Text = "▶|";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // f_ListCourse
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1083, 760);
            Controls.Add(pnlGrid);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            MinimumSize = new Size(900, 600);
            Name = "f_ListCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Management — Academic System";
            pnlHeader.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
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

        private Panel pnlPagination;
        private ComboBox cboPageSize;
        private Button btnFirst;
        private Button btnPrev;
        private Label lblPageInfo;
        private Button btnNext;
        private Button btnLast;
    }
}