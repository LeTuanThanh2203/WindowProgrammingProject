namespace LoginForm
{
    partial class f_Assign
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
            pnlToolbar = new Panel();
            btnDelete = new Button();
            txtSearchHR = new TextBox();
            cboHR = new ComboBox();
            cboCourse = new ComboBox();
            btnAssign = new Button();
            pnlGrid = new Panel();
            dgvAssign = new DataGridView();
            pnlBottom = new Panel();
            lblTotal = new Label();
            pnlPagination = new Panel();
            cboPageSize = new ComboBox();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            txtSearchCourse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssign).BeginInit();
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
            pnlHeader.Size = new Size(1455, 80);
            pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(283, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Management";
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
            pnlToolbar.Controls.Add(label2);
            pnlToolbar.Controls.Add(label1);
            pnlToolbar.Controls.Add(txtSearchCourse);
            pnlToolbar.Controls.Add(btnDelete);
            pnlToolbar.Controls.Add(txtSearchHR);
            pnlToolbar.Controls.Add(cboHR);
            pnlToolbar.Controls.Add(cboCourse);
            pnlToolbar.Controls.Add(btnAssign);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(16, 12, 16, 8);
            pnlToolbar.Size = new Size(1455, 119);
            pnlToolbar.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.ForeColor = Color.FromArgb(60, 70, 85);
            btnDelete.Location = new Point(872, 56);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 42);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchHR
            // 
            txtSearchHR.BorderStyle = BorderStyle.FixedSingle;
            txtSearchHR.Font = new Font("Segoe UI", 9.5F);
            txtSearchHR.Location = new Point(175, 16);
            txtSearchHR.Name = "txtSearchHR";
            txtSearchHR.PlaceholderText = "Search by ID HR";
            txtSearchHR.Size = new Size(399, 29);
            txtSearchHR.TabIndex = 0;
            txtSearchHR.TextChanged += txtSearchHR_TextChanged;
            // 
            // cboHR
            // 
            cboHR.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHR.Font = new Font("Segoe UI", 9.5F);
            cboHR.Location = new Point(585, 16);
            cboHR.Name = "cboHR";
            cboHR.Size = new Size(245, 29);
            cboHR.TabIndex = 1;
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.Font = new Font("Segoe UI", 9.5F);
            cboCourse.Location = new Point(585, 56);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(245, 29);
            cboCourse.TabIndex = 2;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(10, 61, 120);
            btnAssign.Cursor = Cursors.Hand;
            btnAssign.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI Semibold", 9.5F);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(872, 6);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(120, 42);
            btnAssign.TabIndex = 3;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(dgvAssign);
            pnlGrid.Dock = DockStyle.Top;
            pnlGrid.Location = new Point(0, 199);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(16, 12, 16, 8);
            pnlGrid.Size = new Size(1455, 527);
            pnlGrid.TabIndex = 6;
            // 
            // dgvAssign
            // 
            dgvAssign.AllowUserToResizeColumns = false;
            dgvAssign.AllowUserToResizeRows = false;
            dgvAssign.ColumnHeadersHeight = 29;
            dgvAssign.Dock = DockStyle.Fill;
            dgvAssign.Location = new Point(16, 12);
            dgvAssign.Name = "dgvAssign";
            dgvAssign.RowHeadersWidth = 51;
            dgvAssign.Size = new Size(1423, 507);
            dgvAssign.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 732);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(1455, 70);
            pnlBottom.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(618, 12);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Records: 0";
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
            pnlPagination.Location = new Point(1051, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 46);
            pnlPagination.TabIndex = 5;
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
            // txtSearchCourse
            // 
            txtSearchCourse.BorderStyle = BorderStyle.FixedSingle;
            txtSearchCourse.Font = new Font("Segoe UI", 9.5F);
            txtSearchCourse.Location = new Point(175, 57);
            txtSearchCourse.Name = "txtSearchCourse";
            txtSearchCourse.PlaceholderText = "Search by ID Course";
            txtSearchCourse.Size = new Size(399, 29);
            txtSearchCourse.TabIndex = 5;
            txtSearchCourse.TextChanged += txtSearchCourse_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 61, 120);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 6;
            label1.Text = "Choose HR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 61, 120);
            label2.Location = new Point(21, 54);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 7;
            label2.Text = "Choose Course";
            // 
            // f_Assign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 802);
            Controls.Add(pnlBottom);
            Controls.Add(pnlGrid);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Name = "f_Assign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f_Assign";
            Load += f_Assign_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAssign).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlToolbar;
        private ComboBox cboHR;
        private ComboBox cboCourse;
        private Button btnAssign;
        private Panel pnlGrid;
        private DataGridView dgvAssign;
        private Button btnDelete;
        private Panel pnlBottom;
        private Label lblTotal;
        private Panel pnlPagination;
        private ComboBox cboPageSize;
        private Button btnFirst;
        private Button btnPrev;
        private Label lblPageInfo;
        private Button btnNext;
        private Button btnLast;
        private TextBox txtSearchHR;
        private Label label1;
        private TextBox txtSearchCourse;
        private Label label2;
    }
}