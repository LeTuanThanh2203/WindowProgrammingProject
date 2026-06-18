namespace Project_Group6
{
    partial class f_StudentInformation
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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_StudentInformation));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();
            tblMain = new TableLayoutPanel();
            grpProfile = new GroupBox();
            picStudent = new PictureBox();
            lblIDInfo = new Label();
            lblFirstnameInfo = new Label();
            lblLastnameInfo = new Label();
            lblDobInfo = new Label();
            lblGenderInfo = new Label();
            lblPhoneInfo = new Label();
            lblAddressInfo = new Label();
            lblEmailInfo = new Label();
            lblID = new Label();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblDob = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            grpChart = new GroupBox();
            chartScore = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pnlChartFilters = new Panel();
            cboAcademicYear = new ComboBox();
            cboSemester = new ComboBox();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            tblMain.SuspendLayout();
            grpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            grpChart.SuspendLayout();
            pnlChartFilters.SuspendLayout();
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
            pnlHeader.Size = new Size(1201, 80);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Academic Profile";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(550, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View your personal profile details and academic performance chart";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(tblMain);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20, 16, 20, 16);
            pnlBody.Size = new Size(1201, 780);
            pnlBody.TabIndex = 0;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(grpProfile, 0, 0);
            tblMain.Controls.Add(grpChart, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(20, 16);
            tblMain.Name = "tblMain";
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1161, 748);
            tblMain.TabIndex = 0;
            // 
            // grpProfile
            // 
            grpProfile.BackColor = Color.White;
            grpProfile.Controls.Add(picStudent);
            grpProfile.Controls.Add(lblIDInfo);
            grpProfile.Controls.Add(lblFirstnameInfo);
            grpProfile.Controls.Add(lblLastnameInfo);
            grpProfile.Controls.Add(lblDobInfo);
            grpProfile.Controls.Add(lblGenderInfo);
            grpProfile.Controls.Add(lblPhoneInfo);
            grpProfile.Controls.Add(lblAddressInfo);
            grpProfile.Controls.Add(lblEmailInfo);
            grpProfile.Controls.Add(lblID);
            grpProfile.Controls.Add(lblFirstname);
            grpProfile.Controls.Add(lblLastname);
            grpProfile.Controls.Add(lblDob);
            grpProfile.Controls.Add(lblGender);
            grpProfile.Controls.Add(lblPhone);
            grpProfile.Controls.Add(lblAddress);
            grpProfile.Controls.Add(lblEmail);
            grpProfile.Dock = DockStyle.Fill;
            grpProfile.Font = new Font("Segoe UI Semibold", 10F);
            grpProfile.ForeColor = Color.FromArgb(10, 61, 120);
            grpProfile.Location = new Point(3, 3);
            grpProfile.Name = "grpProfile";
            grpProfile.Padding = new Padding(16);
            grpProfile.Size = new Size(314, 742);
            grpProfile.TabIndex = 0;
            grpProfile.TabStop = false;
            grpProfile.Text = "Personal Profile Details";
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Location = new Point(50, 32);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(180, 206);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabIndex = 0;
            picStudent.TabStop = false;
            // 
            // lblIDInfo
            // 
            lblIDInfo.Text = "Student ID:";
            lblIDInfo.Location = new Point(16, 260);
            lblIDInfo.AutoSize = true;
            lblIDInfo.Font = new Font("Segoe UI", 9.5F);
            lblIDInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblIDInfo.Name = "lblIDInfo";
            lblIDInfo.Size = new Size(100, 23);
            lblIDInfo.TabIndex = 1;
            // 
            // lblFirstnameInfo
            // 
            lblFirstnameInfo.Text = "First Name:";
            lblFirstnameInfo.Location = new Point(16, 295);
            lblFirstnameInfo.AutoSize = true;
            lblFirstnameInfo.Font = new Font("Segoe UI", 9.5F);
            lblFirstnameInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblFirstnameInfo.Name = "lblFirstnameInfo";
            lblFirstnameInfo.Size = new Size(100, 23);
            lblFirstnameInfo.TabIndex = 2;
            // 
            // lblLastnameInfo
            // 
            lblLastnameInfo.Text = "Last Name:";
            lblLastnameInfo.Location = new Point(16, 330);
            lblLastnameInfo.AutoSize = true;
            lblLastnameInfo.Font = new Font("Segoe UI", 9.5F);
            lblLastnameInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblLastnameInfo.Name = "lblLastnameInfo";
            lblLastnameInfo.Size = new Size(100, 23);
            lblLastnameInfo.TabIndex = 3;
            // 
            // lblDobInfo
            // 
            lblDobInfo.Text = "Date of Birth:";
            lblDobInfo.Location = new Point(16, 365);
            lblDobInfo.AutoSize = true;
            lblDobInfo.Font = new Font("Segoe UI", 9.5F);
            lblDobInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblDobInfo.Name = "lblDobInfo";
            lblDobInfo.Size = new Size(100, 23);
            lblDobInfo.TabIndex = 4;
            // 
            // lblGenderInfo
            // 
            lblGenderInfo.Text = "Gender:";
            lblGenderInfo.Location = new Point(16, 400);
            lblGenderInfo.AutoSize = true;
            lblGenderInfo.Font = new Font("Segoe UI", 9.5F);
            lblGenderInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblGenderInfo.Name = "lblGenderInfo";
            lblGenderInfo.Size = new Size(100, 23);
            lblGenderInfo.TabIndex = 5;
            // 
            // lblPhoneInfo
            // 
            lblPhoneInfo.Text = "Phone:";
            lblPhoneInfo.Location = new Point(16, 435);
            lblPhoneInfo.AutoSize = true;
            lblPhoneInfo.Font = new Font("Segoe UI", 9.5F);
            lblPhoneInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblPhoneInfo.Name = "lblPhoneInfo";
            lblPhoneInfo.Size = new Size(100, 23);
            lblPhoneInfo.TabIndex = 6;
            // 
            // lblAddressInfo
            // 
            lblAddressInfo.Text = "Address:";
            lblAddressInfo.Location = new Point(16, 470);
            lblAddressInfo.AutoSize = true;
            lblAddressInfo.Font = new Font("Segoe UI", 9.5F);
            lblAddressInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblAddressInfo.Name = "lblAddressInfo";
            lblAddressInfo.Size = new Size(100, 23);
            lblAddressInfo.TabIndex = 7;
            // 
            // lblEmailInfo
            // 
            lblEmailInfo.Text = "Email:";
            lblEmailInfo.Location = new Point(16, 505);
            lblEmailInfo.AutoSize = true;
            lblEmailInfo.Font = new Font("Segoe UI", 9.5F);
            lblEmailInfo.ForeColor = Color.FromArgb(80, 80, 90);
            lblEmailInfo.Name = "lblEmailInfo";
            lblEmailInfo.Size = new Size(100, 23);
            lblEmailInfo.TabIndex = 8;
            // 
            // lblID
            // 
            lblID.Location = new Point(120, 260);
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 9.5F);
            lblID.ForeColor = Color.FromArgb(10, 61, 120);
            lblID.Name = "lblID";
            lblID.Size = new Size(100, 23);
            lblID.TabIndex = 9;
            // 
            // lblFirstname
            // 
            lblFirstname.Location = new Point(120, 295);
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI Semibold", 9.5F);
            lblFirstname.ForeColor = Color.FromArgb(10, 61, 120);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(100, 23);
            lblFirstname.TabIndex = 10;
            // 
            // lblLastname
            // 
            lblLastname.Location = new Point(120, 330);
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI Semibold", 9.5F);
            lblLastname.ForeColor = Color.FromArgb(10, 61, 120);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(100, 23);
            lblLastname.TabIndex = 11;
            // 
            // lblDob
            // 
            lblDob.Location = new Point(120, 365);
            lblDob.AutoSize = true;
            lblDob.Font = new Font("Segoe UI Semibold", 9.5F);
            lblDob.ForeColor = Color.FromArgb(10, 61, 120);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(100, 23);
            lblDob.TabIndex = 12;
            // 
            // lblGender
            // 
            lblGender.Location = new Point(120, 400);
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 9.5F);
            lblGender.ForeColor = Color.FromArgb(10, 61, 120);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 13;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(120, 435);
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 9.5F);
            lblPhone.ForeColor = Color.FromArgb(10, 61, 120);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 14;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(120, 470);
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 9.5F);
            lblAddress.ForeColor = Color.FromArgb(10, 61, 120);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(120, 505);
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.5F);
            lblEmail.ForeColor = Color.FromArgb(10, 61, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 16;
            // 
            // grpChart
            // 
            grpChart.BackColor = Color.White;
            grpChart.Controls.Add(chartScore);
            grpChart.Controls.Add(pnlChartFilters);
            grpChart.Dock = DockStyle.Fill;
            grpChart.Font = new Font("Segoe UI Semibold", 10F);
            grpChart.ForeColor = Color.FromArgb(10, 61, 120);
            grpChart.Location = new Point(336, 0);
            grpChart.Margin = new Padding(16, 0, 0, 0);
            grpChart.Name = "grpChart";
            grpChart.Padding = new Padding(16);
            grpChart.Size = new Size(825, 748);
            grpChart.TabIndex = 1;
            grpChart.TabStop = false;
            grpChart.Text = "Academic Performance Chart";
            // 
            // chartScore
            // 
            chartScore.AutoUpdateEnabled = true;
            chartScore.ChartTheme = null;
            chartScore.Dock = DockStyle.Fill;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = true;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            chartScore.Legend = skDefaultLegend1;
            chartScore.Location = new Point(16, 91);
            chartScore.MatchAxesScreenDataRatio = false;
            chartScore.Name = "chartScore";
            chartScore.Size = new Size(793, 641);
            chartScore.TabIndex = 0;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = true;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            chartScore.Tooltip = skDefaultTooltip1;
            chartScore.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            chartScore.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // pnlChartFilters
            // 
            pnlChartFilters.Controls.Add(cboAcademicYear);
            pnlChartFilters.Controls.Add(cboSemester);
            pnlChartFilters.Dock = DockStyle.Top;
            pnlChartFilters.Location = new Point(16, 39);
            pnlChartFilters.Name = "pnlChartFilters";
            pnlChartFilters.Size = new Size(793, 52);
            pnlChartFilters.TabIndex = 1;
            // 
            // cboAcademicYear
            // 
            cboAcademicYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicYear.Font = new Font("Segoe UI", 9.5F);
            cboAcademicYear.Location = new Point(8, 10);
            cboAcademicYear.Name = "cboAcademicYear";
            cboAcademicYear.Size = new Size(200, 29);
            cboAcademicYear.TabIndex = 0;
            cboAcademicYear.SelectedIndexChanged += Filter_Changed;
            // 
            // cboSemester
            // 
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.Font = new Font("Segoe UI", 9.5F);
            cboSemester.Location = new Point(224, 10);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(160, 29);
            cboSemester.TabIndex = 1;
            cboSemester.SelectedIndexChanged += Filter_Changed;
            // 
            // f_StudentInformation
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 860);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_StudentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Student Academic Profile";
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            grpProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            grpChart.ResumeLayout(false);
            pnlChartFilters.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TableLayoutPanel tblMain;

        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Label lblIDInfo;
        private System.Windows.Forms.Label lblFirstnameInfo;
        private System.Windows.Forms.Label lblLastnameInfo;
        private System.Windows.Forms.Label lblDobInfo;
        private System.Windows.Forms.Label lblGenderInfo;
        private System.Windows.Forms.Label lblPhoneInfo;
        private System.Windows.Forms.Label lblAddressInfo;
        private System.Windows.Forms.Label lblEmailInfo;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.GroupBox grpChart;
        private System.Windows.Forms.Panel pnlChartFilters;
        private System.Windows.Forms.ComboBox cboAcademicYear;
        private System.Windows.Forms.ComboBox cboSemester;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart chartScore;
    }
}