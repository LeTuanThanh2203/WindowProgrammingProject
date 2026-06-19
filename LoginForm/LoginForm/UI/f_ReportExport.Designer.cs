namespace LoginForm
{
    partial class f_ReportExport
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlBody = new Panel();
            pnlPreview = new Panel();
            dgvReport = new DataGridView();
            pnlConfigure = new Panel();
            lblConfigTitle = new Label();
            lblReportType = new Label();
            cboReportType = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblGender = new Label();
            cboGender = new ComboBox();
            lblClass = new Label();
            cboClass = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnFilterRefresh = new Button();
            pnlBottom = new Panel();
            btnRefresh = new Button();
            btnPreview = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            lblTotal = new Label();
            lblSumUser = new Label();
            lblSumDate = new Label();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            pnlConfigure.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1262, 80);
            pnlHeader.TabIndex = 3;
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Report Export Center";
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlPreview);
            pnlBody.Controls.Add(pnlConfigure);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(1262, 652);
            pnlBody.TabIndex = 0;
            // 
            // pnlPreview
            // 
            pnlPreview.BackColor = Color.FromArgb(245, 247, 250);
            pnlPreview.Controls.Add(dgvReport);
            pnlPreview.Dock = DockStyle.Fill;
            pnlPreview.Location = new Point(360, 0);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Padding = new Padding(16, 12, 16, 12);
            pnlPreview.Size = new Size(902, 652);
            pnlPreview.TabIndex = 1;
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(246, 249, 253);
            dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 61, 120);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReport.ColumnHeadersHeight = 36;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReport.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.EnableHeadersVisualStyles = false;
            dgvReport.GridColor = Color.FromArgb(230, 232, 236);
            dgvReport.Location = new Point(16, 12);
            dgvReport.MultiSelect = false;
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersVisible = false;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 36;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(870, 628);
            dgvReport.TabIndex = 0;
            // 
            // pnlConfigure
            // 
            pnlConfigure.BackColor = Color.White;
            pnlConfigure.Controls.Add(lblConfigTitle);
            pnlConfigure.Controls.Add(lblReportType);
            pnlConfigure.Controls.Add(cboReportType);
            pnlConfigure.Controls.Add(lblSearch);
            pnlConfigure.Controls.Add(txtSearch);
            pnlConfigure.Controls.Add(lblGender);
            pnlConfigure.Controls.Add(cboGender);
            pnlConfigure.Controls.Add(lblClass);
            pnlConfigure.Controls.Add(cboClass);
            pnlConfigure.Controls.Add(lblFrom);
            pnlConfigure.Controls.Add(dtpFrom);
            pnlConfigure.Controls.Add(lblTo);
            pnlConfigure.Controls.Add(dtpTo);
            pnlConfigure.Controls.Add(btnFilterRefresh);
            pnlConfigure.Dock = DockStyle.Left;
            pnlConfigure.Location = new Point(0, 0);
            pnlConfigure.Name = "pnlConfigure";
            pnlConfigure.Size = new Size(360, 652);
            pnlConfigure.TabIndex = 0;
            // 
            // lblConfigTitle
            // 
            lblConfigTitle.AutoSize = true;
            lblConfigTitle.Font = new Font("Segoe UI Semibold", 11F);
            lblConfigTitle.ForeColor = Color.FromArgb(10, 61, 120);
            lblConfigTitle.Location = new Point(24, 18);
            lblConfigTitle.Name = "lblConfigTitle";
            lblConfigTitle.Size = new Size(166, 25);
            lblConfigTitle.TabIndex = 12;
            lblConfigTitle.Text = "REPORT OPTIONS";
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblReportType.ForeColor = Color.FromArgb(60, 70, 85);
            lblReportType.Location = new Point(24, 58);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(104, 21);
            lblReportType.TabIndex = 0;
            lblReportType.Text = "Report Type:";
            // 
            // cboReportType
            // 
            cboReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReportType.Font = new Font("Segoe UI", 9.5F);
            cboReportType.Location = new Point(24, 82);
            cboReportType.Name = "cboReportType";
            cboReportType.Size = new Size(312, 29);
            cboReportType.TabIndex = 1;
            cboReportType.SelectedIndexChanged += cboReportType_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(60, 70, 85);
            lblSearch.Location = new Point(24, 124);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(132, 21);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Keyword:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(24, 148);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search keywords...";
            txtSearch.Size = new Size(312, 29);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(60, 70, 85);
            lblGender.Location = new Point(24, 190);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 21);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.Font = new Font("Segoe UI", 9.5F);
            cboGender.Location = new Point(24, 214);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(312, 29);
            cboGender.TabIndex = 5;
            cboGender.SelectedIndexChanged += cboGender_SelectedIndexChanged;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblClass.ForeColor = Color.FromArgb(60, 70, 85);
            lblClass.Location = new Point(24, 190);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(50, 21);
            lblClass.TabIndex = 6;
            lblClass.Text = "Class:";
            lblClass.Visible = false;
            // 
            // cboClass
            // 
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.Font = new Font("Segoe UI", 9.5F);
            cboClass.Location = new Point(24, 214);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(312, 29);
            cboClass.TabIndex = 7;
            cboClass.Visible = false;
            cboClass.SelectedIndexChanged += cboClass_SelectedIndexChanged;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblFrom.ForeColor = Color.FromArgb(60, 70, 85);
            lblFrom.Location = new Point(24, 256);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(89, 21);
            lblFrom.TabIndex = 8;
            lblFrom.Text = "DOB From:";
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            dtpFrom.Font = new Font("Segoe UI", 9.5F);
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(24, 280);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(140, 29);
            dtpFrom.TabIndex = 9;
            dtpFrom.ValueChanged += dtp_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTo.ForeColor = Color.FromArgb(60, 70, 85);
            lblTo.Location = new Point(196, 256);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(68, 21);
            lblTo.TabIndex = 10;
            lblTo.Text = "DOB To:";
            // 
            // dtpTo
            // 
            dtpTo.CustomFormat = "dd/MM/yyyy";
            dtpTo.Font = new Font("Segoe UI", 9.5F);
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(196, 280);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(140, 29);
            dtpTo.TabIndex = 11;
            dtpTo.ValueChanged += dtp_ValueChanged;
            // 
            // btnFilterRefresh
            // 
            btnFilterRefresh.BackColor = Color.White;
            btnFilterRefresh.Cursor = Cursors.Hand;
            btnFilterRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnFilterRefresh.FlatStyle = FlatStyle.Flat;
            btnFilterRefresh.Font = new Font("Segoe UI", 9.5F);
            btnFilterRefresh.ForeColor = Color.FromArgb(60, 70, 85);
            btnFilterRefresh.Location = new Point(24, 340);
            btnFilterRefresh.Name = "btnFilterRefresh";
            btnFilterRefresh.Size = new Size(312, 40);
            btnFilterRefresh.TabIndex = 13;
            btnFilterRefresh.Text = "↺  Reset Filters";
            btnFilterRefresh.UseVisualStyleBackColor = false;
            btnFilterRefresh.Click += btnRefresh_Click;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(btnRefresh);
            pnlBottom.Controls.Add(btnPreview);
            pnlBottom.Controls.Add(btnExportExcel);
            pnlBottom.Controls.Add(btnExportPdf);
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(lblSumUser);
            pnlBottom.Controls.Add(lblSumDate);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 732);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(1262, 68);
            pnlBottom.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.5F);
            btnRefresh.ForeColor = Color.FromArgb(60, 70, 85);
            btnRefresh.Location = new Point(400, 13);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 42);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPreview
            // 
            btnPreview.BackColor = Color.White;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 9.5F);
            btnPreview.ForeColor = Color.FromArgb(60, 70, 85);
            btnPreview.Location = new Point(264, 13);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(130, 42);
            btnPreview.TabIndex = 2;
            btnPreview.Text = "🔍 Preview File";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.White;
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9.5F);
            btnExportExcel.ForeColor = Color.FromArgb(60, 70, 85);
            btnExportExcel.Location = new Point(144, 13);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(114, 42);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "📊 Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(10, 61, 120);
            btnExportPdf.Cursor = Cursors.Hand;
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI Semibold", 9.5F);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(24, 13);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(114, 42);
            btnExportPdf.TabIndex = 0;
            btnExportPdf.Text = "📄 PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(530, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 21);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Records: 0";
            // 
            // lblSumUser
            // 
            lblSumUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSumUser.AutoSize = true;
            lblSumUser.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSumUser.ForeColor = Color.FromArgb(80, 80, 90);
            lblSumUser.Location = new Point(820, 22);
            lblSumUser.Name = "lblSumUser";
            lblSumUser.Size = new Size(100, 21);
            lblSumUser.TabIndex = 5;
            lblSumUser.Text = "User: Admin";
            // 
            // lblSumDate
            // 
            lblSumDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSumDate.AutoSize = true;
            lblSumDate.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSumDate.ForeColor = Color.FromArgb(80, 80, 90);
            lblSumDate.Location = new Point(1050, 22);
            lblSumDate.Name = "lblSumDate";
            lblSumDate.Size = new Size(154, 21);
            lblSumDate.TabIndex = 6;
            lblSumDate.Text = "Date: DD/MM/YYYY";
            // 
            // f_ReportExport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 800);
            Controls.Add(pnlBody);
            Controls.Add(pnlBottom);
            Controls.Add(pnlHeader);
            Name = "f_ReportExport";
            Text = "Report Export Center";
            Load += f_ReportExport_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            pnlConfigure.ResumeLayout(false);
            pnlConfigure.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlConfigure;
        private System.Windows.Forms.Label lblConfigTitle;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cboReportType;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnFilterRefresh;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSumUser;
        private System.Windows.Forms.Label lblSumDate;
    }
}