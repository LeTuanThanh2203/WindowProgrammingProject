namespace Project_Group6
{
    partial class f_ClassList
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlToolbar = new Panel();
            txtSearch = new TextBox();
            cboSort = new ComboBox();
            cboGender = new ComboBox();
            btnRefresh = new Button();
            pnlGrid = new Panel();
            dgvClassList = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvClassList).BeginInit();
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
            pnlHeader.Size = new Size(1231, 80);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Class Management";
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
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(cboSort);
            pnlToolbar.Controls.Add(cboGender);
            pnlToolbar.Controls.Add(btnRefresh);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(16, 12, 16, 8);
            pnlToolbar.Size = new Size(1231, 56);
            pnlToolbar.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(16, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Class ID, Course, Year...";
            txtSearch.Size = new Size(320, 29);
            txtSearch.TabIndex = 0;
            // 
            // cboSort
            // 
            cboSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSort.Font = new Font("Segoe UI", 9.5F);
            cboSort.Location = new Point(352, 13);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(160, 29);
            cboSort.TabIndex = 1;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 9.5F);
            cboGender.Location = new Point(528, 13);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(140, 29);
            cboGender.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.FromArgb(60, 70, 85);
            btnRefresh.Location = new Point(684, 11);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 32);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "↺  Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(dgvClassList);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 136);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(16, 12, 16, 8);
            pnlGrid.Size = new Size(1231, 640);
            pnlGrid.TabIndex = 0;
            // 
            // dgvClassList
            // 
            dgvClassList.AllowUserToResizeColumns = false;
            dgvClassList.AllowUserToResizeRows = false;
            dgvClassList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClassList.ColumnHeadersHeight = 29;
            dgvClassList.Dock = DockStyle.Fill;
            dgvClassList.Location = new Point(16, 12);
            dgvClassList.Name = "dgvClassList";
            dgvClassList.RowHeadersWidth = 51;
            dgvClassList.Size = new Size(1199, 620);
            dgvClassList.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnAdd);
            pnlBottom.Controls.Add(btnEdit);
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 776);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(1231, 68);
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
            btnAdd.Location = new Point(24, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "＋  Add Class";
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
            btnEdit.Location = new Point(168, 13);
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
            lblTotal.Location = new Point(312, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(98, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total Class: 0";
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
            pnlPagination.Location = new Point(827, 12);
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
            btnFirst.Location = new Point(80, 17);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(36, 32);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "|◀";
            btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnFirst.BackColor = System.Drawing.Color.White;
            btnFirst.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(120, 17);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◀";
            btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnPrev.BackColor = System.Drawing.Color.White;
            btnPrev.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
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
            btnNext.Location = new Point(290, 17);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 32);
            btnNext.TabIndex = 4;
            btnNext.Text = "▶";
            btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNext.BackColor = System.Drawing.Color.White;
            btnNext.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(330, 17);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 32);
            btnLast.TabIndex = 5;
            btnLast.Text = "▶|";
            btnLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnLast.BackColor = System.Drawing.Color.White;
            btnLast.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // f_ClassList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 844);
            Controls.Add(pnlGrid);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_ClassList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Management — Academic System";
            pnlHeader.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClassList).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvClassList;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}