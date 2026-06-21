namespace LoginForm
{
    partial class f_EditScore
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
            label1 = new Label();
            cboClass = new ComboBox();
            label2 = new Label();
            cboAcademicYear = new ComboBox();
            label3 = new Label();
            cboSemester = new ComboBox();
            pnlGrid = new Panel();
            dgvStudent = new DataGridView();
            pnlBottom = new Panel();
            btnAdd = new Button();
            btnReset = new Button();
            btnExport = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
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
            pnlHeader.Size = new Size(1250, 80);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Score Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(420, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "University Academic Management System";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(label1);
            pnlToolbar.Controls.Add(cboClass);
            pnlToolbar.Controls.Add(label2);
            pnlToolbar.Controls.Add(cboAcademicYear);
            pnlToolbar.Controls.Add(label3);
            pnlToolbar.Controls.Add(cboSemester);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 80);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(16, 12, 16, 8);
            pnlToolbar.Size = new Size(1250, 56);
            pnlToolbar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.5F);
            label1.ForeColor = Color.FromArgb(80, 80, 90);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 0;
            label1.Text = "Class:";
            // 
            // cboClass
            // 
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.Font = new Font("Segoe UI", 9.5F);
            cboClass.Location = new Point(70, 14);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(320, 29);
            cboClass.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.5F);
            label2.ForeColor = Color.FromArgb(80, 80, 90);
            label2.Location = new Point(410, 18);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 2;
            label2.Text = "Year:";
            // 
            // cboAcademicYear
            // 
            cboAcademicYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicYear.Font = new Font("Segoe UI", 9.5F);
            cboAcademicYear.Location = new Point(460, 14);
            cboAcademicYear.Name = "cboAcademicYear";
            cboAcademicYear.Size = new Size(120, 29);
            cboAcademicYear.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.5F);
            label3.ForeColor = Color.FromArgb(80, 80, 90);
            label3.Location = new Point(600, 18);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 4;
            label3.Text = "Semester:";
            // 
            // cboSemester
            // 
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.Font = new Font("Segoe UI", 9.5F);
            cboSemester.Location = new Point(680, 14);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(120, 29);
            cboSemester.TabIndex = 5;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(dgvStudent);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(0, 136);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(16, 12, 16, 8);
            pnlGrid.Size = new Size(1250, 496);
            pnlGrid.TabIndex = 0;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToResizeColumns = false;
            dgvStudent.AllowUserToResizeRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudent.ColumnHeadersHeight = 29;
            dgvStudent.Dock = DockStyle.Fill;
            dgvStudent.Location = new Point(16, 12);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(1218, 476);
            dgvStudent.TabIndex = 0;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnAdd);
            pnlBottom.Controls.Add(btnReset);
            pnlBottom.Controls.Add(btnExport);
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 632);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(1250, 68);
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
            btnAdd.Location = new Point(24, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "💾  Save Changes";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.5F);
            btnReset.ForeColor = Color.FromArgb(60, 70, 85);
            btnReset.Location = new Point(182, 7);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 42);
            btnReset.TabIndex = 1;
            btnReset.Text = "↺  Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.White;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9.5F);
            btnExport.ForeColor = Color.FromArgb(60, 70, 85);
            btnExport.Location = new Point(302, 7);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(110, 42);
            btnExport.TabIndex = 2;
            btnExport.Text = "⭳  Export";
            btnExport.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(444, 15);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(122, 21);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total Students: 0";
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
            pnlPagination.Location = new Point(846, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 44);
            pnlPagination.TabIndex = 4;
            // 
            // cboPageSize
            // 
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPageSize.Font = new Font("Segoe UI", 9.5F);
            cboPageSize.Location = new Point(10, 7);
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
            btnFirst.Location = new Point(80, 5);
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
            btnPrev.Location = new Point(120, 5);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◀";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Font = new Font("Segoe UI", 9.5F);
            lblPageInfo.Location = new Point(162, 9);
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
            btnNext.Location = new Point(290, 5);
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
            btnLast.Location = new Point(330, 5);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 32);
            btnLast.TabIndex = 5;
            btnLast.Text = "▶|";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // f_EditScore
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 700);
            Controls.Add(pnlGrid);
            Controls.Add(pnlBottom);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_EditScore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score Management Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAcademicYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSemester;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvStudent;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
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