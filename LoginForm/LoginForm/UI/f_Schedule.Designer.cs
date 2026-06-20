namespace LoginForm
{
    partial class f_Schedule
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlToolbar = new Panel();
            btnPrintSchedule = new Button();
            btnNextWeek = new Button();
            btnCurrentWeek = new Button();
            btnPrevWeek = new Button();
            cboWeek = new ComboBox();
            lblWeek = new Label();
            cboSemester = new ComboBox();
            lblSemester = new Label();
            cboYear = new ComboBox();
            lblYear = new Label();
            pnlWeekInfo = new Panel();
            lblWeekRange = new Label();
            pnlGridContainer = new Panel();
            tlpGrid = new TableLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlWeekInfo.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1314, 107);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.LightGray;
            lblSubtitle.Location = new Point(25, 64);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(421, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and print your weekly academic schedule and lectures";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(21, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(433, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "STUDENT WEEKLY SCHEDULE";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(235, 240, 245);
            pnlToolbar.Controls.Add(btnPrintSchedule);
            pnlToolbar.Controls.Add(btnNextWeek);
            pnlToolbar.Controls.Add(btnCurrentWeek);
            pnlToolbar.Controls.Add(btnPrevWeek);
            pnlToolbar.Controls.Add(cboWeek);
            pnlToolbar.Controls.Add(lblWeek);
            pnlToolbar.Controls.Add(cboSemester);
            pnlToolbar.Controls.Add(lblSemester);
            pnlToolbar.Controls.Add(cboYear);
            pnlToolbar.Controls.Add(lblYear);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 107);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1314, 87);
            pnlToolbar.TabIndex = 1;
            // 
            // btnPrintSchedule
            // 
            btnPrintSchedule.BackColor = Color.FromArgb(10, 61, 120);
            btnPrintSchedule.Cursor = Cursors.Hand;
            btnPrintSchedule.FlatAppearance.BorderSize = 0;
            btnPrintSchedule.FlatStyle = FlatStyle.Flat;
            btnPrintSchedule.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnPrintSchedule.ForeColor = Color.White;
            btnPrintSchedule.Location = new Point(1046, 20);
            btnPrintSchedule.Margin = new Padding(3, 4, 3, 4);
            btnPrintSchedule.Name = "btnPrintSchedule";
            btnPrintSchedule.Size = new Size(206, 47);
            btnPrintSchedule.TabIndex = 9;
            btnPrintSchedule.Text = "🖨  Print Schedule";
            btnPrintSchedule.UseVisualStyleBackColor = false;
            // 
            // btnNextWeek
            // 
            btnNextWeek.BackColor = Color.FromArgb(10, 61, 120);
            btnNextWeek.Cursor = Cursors.Hand;
            btnNextWeek.FlatAppearance.BorderSize = 0;
            btnNextWeek.FlatStyle = FlatStyle.Flat;
            btnNextWeek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNextWeek.ForeColor = Color.White;
            btnNextWeek.Location = new Point(983, 20);
            btnNextWeek.Margin = new Padding(3, 4, 3, 4);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(46, 47);
            btnNextWeek.TabIndex = 8;
            btnNextWeek.Text = "▶";
            btnNextWeek.UseVisualStyleBackColor = false;
            // 
            // btnCurrentWeek
            // 
            btnCurrentWeek.BackColor = Color.FromArgb(10, 61, 120);
            btnCurrentWeek.Cursor = Cursors.Hand;
            btnCurrentWeek.FlatAppearance.BorderSize = 0;
            btnCurrentWeek.FlatStyle = FlatStyle.Flat;
            btnCurrentWeek.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCurrentWeek.ForeColor = Color.White;
            btnCurrentWeek.Location = new Point(869, 20);
            btnCurrentWeek.Margin = new Padding(3, 4, 3, 4);
            btnCurrentWeek.Name = "btnCurrentWeek";
            btnCurrentWeek.Size = new Size(109, 47);
            btnCurrentWeek.TabIndex = 7;
            btnCurrentWeek.Text = "Current";
            btnCurrentWeek.UseVisualStyleBackColor = false;
            // 
            // btnPrevWeek
            // 
            btnPrevWeek.BackColor = Color.FromArgb(10, 61, 120);
            btnPrevWeek.Cursor = Cursors.Hand;
            btnPrevWeek.FlatAppearance.BorderSize = 0;
            btnPrevWeek.FlatStyle = FlatStyle.Flat;
            btnPrevWeek.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrevWeek.ForeColor = Color.White;
            btnPrevWeek.Location = new Point(817, 20);
            btnPrevWeek.Margin = new Padding(3, 4, 3, 4);
            btnPrevWeek.Name = "btnPrevWeek";
            btnPrevWeek.Size = new Size(46, 47);
            btnPrevWeek.TabIndex = 6;
            btnPrevWeek.Text = "◀";
            btnPrevWeek.UseVisualStyleBackColor = false;
            // 
            // cboWeek
            // 
            cboWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWeek.FlatStyle = FlatStyle.Flat;
            cboWeek.Font = new Font("Segoe UI", 9.5F);
            cboWeek.FormattingEnabled = true;
            cboWeek.Location = new Point(571, 27);
            cboWeek.Margin = new Padding(3, 4, 3, 4);
            cboWeek.Name = "cboWeek";
            cboWeek.Size = new Size(228, 29);
            cboWeek.TabIndex = 5;
            // 
            // lblWeek
            // 
            lblWeek.AutoSize = true;
            lblWeek.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblWeek.ForeColor = Color.FromArgb(10, 61, 120);
            lblWeek.Location = new Point(514, 29);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(58, 23);
            lblWeek.TabIndex = 4;
            lblWeek.Text = "Week:";
            // 
            // cboSemester
            // 
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.FlatStyle = FlatStyle.Flat;
            cboSemester.Font = new Font("Segoe UI", 9.5F);
            cboSemester.FormattingEnabled = true;
            cboSemester.Location = new Point(371, 27);
            cboSemester.Margin = new Padding(3, 4, 3, 4);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(125, 29);
            cboSemester.TabIndex = 3;
            // 
            // lblSemester
            // 
            lblSemester.AutoSize = true;
            lblSemester.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSemester.ForeColor = Color.FromArgb(10, 61, 120);
            lblSemester.Location = new Point(291, 29);
            lblSemester.Name = "lblSemester";
            lblSemester.Size = new Size(85, 23);
            lblSemester.TabIndex = 2;
            lblSemester.Text = "Semester:";
            // 
            // cboYear
            // 
            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYear.FlatStyle = FlatStyle.Flat;
            cboYear.Font = new Font("Segoe UI", 9.5F);
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(149, 27);
            cboYear.Margin = new Padding(3, 4, 3, 4);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(125, 29);
            cboYear.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(10, 61, 120);
            lblYear.Location = new Point(23, 29);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(126, 23);
            lblYear.TabIndex = 0;
            lblYear.Text = "Academic Year:";
            // 
            // pnlWeekInfo
            // 
            pnlWeekInfo.BackColor = Color.FromArgb(245, 248, 252);
            pnlWeekInfo.Controls.Add(lblWeekRange);
            pnlWeekInfo.Dock = DockStyle.Top;
            pnlWeekInfo.Location = new Point(0, 194);
            pnlWeekInfo.Margin = new Padding(3, 4, 3, 4);
            pnlWeekInfo.Name = "pnlWeekInfo";
            pnlWeekInfo.Padding = new Padding(5, 0, 0, 0);
            pnlWeekInfo.Size = new Size(1314, 48);
            pnlWeekInfo.TabIndex = 3;
            // 
            // lblWeekRange
            // 
            lblWeekRange.Dock = DockStyle.Fill;
            lblWeekRange.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblWeekRange.ForeColor = Color.FromArgb(10, 61, 120);
            lblWeekRange.Location = new Point(5, 0);
            lblWeekRange.Name = "lblWeekRange";
            lblWeekRange.Size = new Size(1309, 48);
            lblWeekRange.TabIndex = 0;
            lblWeekRange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.AutoScroll = true;
            pnlGridContainer.BackColor = Color.White;
            pnlGridContainer.Controls.Add(tlpGrid);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 242);
            pnlGridContainer.Margin = new Padding(3, 4, 3, 4);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(17, 20, 17, 20);
            pnlGridContainer.Size = new Size(1314, 825);
            pnlGridContainer.TabIndex = 2;
            // 
            // tlpGrid
            // 
            tlpGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpGrid.ColumnCount = 4;
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpGrid.Dock = DockStyle.Top;
            tlpGrid.Location = new Point(17, 20);
            tlpGrid.Margin = new Padding(3, 4, 3, 4);
            tlpGrid.Name = "tlpGrid";
            tlpGrid.RowCount = 8;
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tlpGrid.Size = new Size(1259, 1467);
            tlpGrid.TabIndex = 0;
            // 
            // f_Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 1067);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlWeekInfo);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "f_Schedule";
            Text = "Schedule";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlWeekInfo.ResumeLayout(false);
            pnlGridContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.ComboBox cboWeek;
        private System.Windows.Forms.Button btnPrevWeek;
        private System.Windows.Forms.Button btnCurrentWeek;
        private System.Windows.Forms.Button btnNextWeek;
        private System.Windows.Forms.Button btnPrintSchedule;
        private System.Windows.Forms.Panel pnlWeekInfo;
        private System.Windows.Forms.Label lblWeekRange;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.TableLayoutPanel tlpGrid;
    }
}
