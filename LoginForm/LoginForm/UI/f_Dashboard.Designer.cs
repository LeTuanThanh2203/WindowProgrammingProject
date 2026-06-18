namespace LoginForm
{
    partial class f_Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            tblMainLayout = new TableLayoutPanel();
            tblCardsLayout = new TableLayoutPanel();
            pnTotalStudents = new Panel();
            picTotalStudents = new FontAwesome.Sharp.IconPictureBox();
            lblTotalStudents = new Label();
            lblTotalStudentsTitle = new Label();
            pnTotalCourses = new Panel();
            picTotalCourses = new FontAwesome.Sharp.IconPictureBox();
            lblTotalCourses = new Label();
            lblTotalCoursesTitle = new Label();
            pnTotalClasses = new Panel();
            picTotalClasses = new FontAwesome.Sharp.IconPictureBox();
            lblTotalClasses = new Label();
            lblTotalClassesTitle = new Label();
            pnTotalEnrollments = new Panel();
            picTotalEnrollments = new FontAwesome.Sharp.IconPictureBox();
            lblTotalEnrollments = new Label();
            lblTotalEnrollmentsTitle = new Label();
            tblChartsLayout = new TableLayoutPanel();
            pnEnrollmentChartContainer = new Panel();
            pnEnrollmentChart = new Panel();
            pnEnrollmentHeader = new Panel();
            lblEnrollmentTitle = new Label();
            pnGenderChartContainer = new Panel();
            pnStudentChart = new Panel();
            pnGenderHeader = new Panel();
            lblGenderTitle = new Label();
            pnGradeChartContainer = new Panel();
            pnGradeChart = new Panel();
            pnGradeHeader = new Panel();
            lblGradeTitle = new Label();
            pnTopStudentsContainer = new Panel();
            dgvTopStudents = new DataGridView();
            pnTopStudentsHeader = new Panel();
            lblTopStudentsTitle = new Label();
            pnlHeader.SuspendLayout();
            tblMainLayout.SuspendLayout();
            tblCardsLayout.SuspendLayout();
            pnTotalStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).BeginInit();
            pnTotalCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalCourses).BeginInit();
            pnTotalClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalClasses).BeginInit();
            pnTotalEnrollments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalEnrollments).BeginInit();
            tblChartsLayout.SuspendLayout();
            pnEnrollmentChartContainer.SuspendLayout();
            pnEnrollmentHeader.SuspendLayout();
            pnGenderChartContainer.SuspendLayout();
            pnGenderHeader.SuspendLayout();
            pnGradeChartContainer.SuspendLayout();
            pnGradeHeader.SuspendLayout();
            pnTopStudentsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopStudents).BeginInit();
            pnTopStudentsHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Name = "pnlHeader";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.Text = "Academic Dashboard";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 20);
            lblSubtitle.Text = "University Academic Management System";
            // 
            // tblMainLayout
            // 
            tblMainLayout.BackColor = Color.FromArgb(240, 242, 245);
            tblMainLayout.ColumnCount = 1;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMainLayout.Controls.Add(tblCardsLayout, 0, 0);
            tblMainLayout.Controls.Add(tblChartsLayout, 0, 1);
            tblMainLayout.Dock = DockStyle.Fill;
            tblMainLayout.Location = new Point(0, 0);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.Padding = new Padding(10);
            tblMainLayout.RowCount = 2;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMainLayout.Size = new Size(1462, 894);
            tblMainLayout.TabIndex = 0;
            // 
            // tblCardsLayout
            // 
            tblCardsLayout.ColumnCount = 4;
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCardsLayout.Controls.Add(pnTotalStudents, 0, 0);
            tblCardsLayout.Controls.Add(pnTotalCourses, 1, 0);
            tblCardsLayout.Controls.Add(pnTotalClasses, 2, 0);
            tblCardsLayout.Controls.Add(pnTotalEnrollments, 3, 0);
            tblCardsLayout.Dock = DockStyle.Fill;
            tblCardsLayout.Location = new Point(10, 10);
            tblCardsLayout.Margin = new Padding(0, 0, 0, 10);
            tblCardsLayout.Name = "tblCardsLayout";
            tblCardsLayout.RowCount = 1;
            tblCardsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCardsLayout.Size = new Size(1442, 120);
            tblCardsLayout.TabIndex = 0;
            // 
            // pnTotalStudents
            // 
            pnTotalStudents.BackColor = Color.FromArgb(41, 128, 185);
            pnTotalStudents.Controls.Add(picTotalStudents);
            pnTotalStudents.Controls.Add(lblTotalStudents);
            pnTotalStudents.Controls.Add(lblTotalStudentsTitle);
            pnTotalStudents.Dock = DockStyle.Fill;
            pnTotalStudents.Location = new Point(6, 6);
            pnTotalStudents.Margin = new Padding(6);
            pnTotalStudents.Name = "pnTotalStudents";
            pnTotalStudents.Size = new Size(348, 108);
            pnTotalStudents.TabIndex = 0;
            // 
            // picTotalStudents
            // 
            picTotalStudents.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picTotalStudents.BackColor = Color.Transparent;
            picTotalStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            picTotalStudents.IconColor = Color.White;
            picTotalStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTotalStudents.IconSize = 48;
            picTotalStudents.Location = new Point(282, 15);
            picTotalStudents.Name = "picTotalStudents";
            picTotalStudents.Size = new Size(48, 48);
            picTotalStudents.TabIndex = 0;
            picTotalStudents.TabStop = false;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalStudents.ForeColor = Color.White;
            lblTotalStudents.Location = new Point(15, 42);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(43, 50);
            lblTotalStudents.TabIndex = 2;
            lblTotalStudents.Text = "0";
            // 
            // lblTotalStudentsTitle
            // 
            lblTotalStudentsTitle.AutoSize = true;
            lblTotalStudentsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalStudentsTitle.ForeColor = Color.FromArgb(220, 235, 245);
            lblTotalStudentsTitle.Location = new Point(16, 16);
            lblTotalStudentsTitle.Name = "lblTotalStudentsTitle";
            lblTotalStudentsTitle.Size = new Size(150, 21);
            lblTotalStudentsTitle.TabIndex = 1;
            lblTotalStudentsTitle.Text = "TOTAL STUDENTS";
            // 
            // pnTotalCourses
            // 
            pnTotalCourses.BackColor = Color.FromArgb(142, 68, 173);
            pnTotalCourses.Controls.Add(picTotalCourses);
            pnTotalCourses.Controls.Add(lblTotalCourses);
            pnTotalCourses.Controls.Add(lblTotalCoursesTitle);
            pnTotalCourses.Dock = DockStyle.Fill;
            pnTotalCourses.Location = new Point(366, 6);
            pnTotalCourses.Margin = new Padding(6);
            pnTotalCourses.Name = "pnTotalCourses";
            pnTotalCourses.Size = new Size(348, 108);
            pnTotalCourses.TabIndex = 1;
            // 
            // picTotalCourses
            // 
            picTotalCourses.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picTotalCourses.BackColor = Color.Transparent;
            picTotalCourses.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            picTotalCourses.IconColor = Color.White;
            picTotalCourses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTotalCourses.IconSize = 48;
            picTotalCourses.Location = new Point(282, 15);
            picTotalCourses.Name = "picTotalCourses";
            picTotalCourses.Size = new Size(48, 48);
            picTotalCourses.TabIndex = 0;
            picTotalCourses.TabStop = false;
            // 
            // lblTotalCourses
            // 
            lblTotalCourses.AutoSize = true;
            lblTotalCourses.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalCourses.ForeColor = Color.White;
            lblTotalCourses.Location = new Point(15, 42);
            lblTotalCourses.Name = "lblTotalCourses";
            lblTotalCourses.Size = new Size(43, 50);
            lblTotalCourses.TabIndex = 2;
            lblTotalCourses.Text = "0";
            // 
            // lblTotalCoursesTitle
            // 
            lblTotalCoursesTitle.AutoSize = true;
            lblTotalCoursesTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCoursesTitle.ForeColor = Color.FromArgb(240, 225, 245);
            lblTotalCoursesTitle.Location = new Point(16, 16);
            lblTotalCoursesTitle.Name = "lblTotalCoursesTitle";
            lblTotalCoursesTitle.Size = new Size(137, 21);
            lblTotalCoursesTitle.TabIndex = 1;
            lblTotalCoursesTitle.Text = "TOTAL COURSES";
            // 
            // pnTotalClasses
            // 
            pnTotalClasses.BackColor = Color.FromArgb(39, 174, 96);
            pnTotalClasses.Controls.Add(picTotalClasses);
            pnTotalClasses.Controls.Add(lblTotalClasses);
            pnTotalClasses.Controls.Add(lblTotalClassesTitle);
            pnTotalClasses.Dock = DockStyle.Fill;
            pnTotalClasses.Location = new Point(726, 6);
            pnTotalClasses.Margin = new Padding(6);
            pnTotalClasses.Name = "pnTotalClasses";
            pnTotalClasses.Size = new Size(348, 108);
            pnTotalClasses.TabIndex = 2;
            // 
            // picTotalClasses
            // 
            picTotalClasses.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picTotalClasses.BackColor = Color.Transparent;
            picTotalClasses.IconChar = FontAwesome.Sharp.IconChar.School;
            picTotalClasses.IconColor = Color.White;
            picTotalClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTotalClasses.IconSize = 48;
            picTotalClasses.Location = new Point(282, 15);
            picTotalClasses.Name = "picTotalClasses";
            picTotalClasses.Size = new Size(48, 48);
            picTotalClasses.TabIndex = 0;
            picTotalClasses.TabStop = false;
            // 
            // lblTotalClasses
            // 
            lblTotalClasses.AutoSize = true;
            lblTotalClasses.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalClasses.ForeColor = Color.White;
            lblTotalClasses.Location = new Point(15, 42);
            lblTotalClasses.Name = "lblTotalClasses";
            lblTotalClasses.Size = new Size(43, 50);
            lblTotalClasses.TabIndex = 2;
            lblTotalClasses.Text = "0";
            // 
            // lblTotalClassesTitle
            // 
            lblTotalClassesTitle.AutoSize = true;
            lblTotalClassesTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalClassesTitle.ForeColor = Color.FromArgb(220, 245, 230);
            lblTotalClassesTitle.Location = new Point(16, 16);
            lblTotalClassesTitle.Name = "lblTotalClassesTitle";
            lblTotalClassesTitle.Size = new Size(132, 21);
            lblTotalClassesTitle.TabIndex = 1;
            lblTotalClassesTitle.Text = "TOTAL CLASSES";
            // 
            // pnTotalEnrollments
            // 
            pnTotalEnrollments.BackColor = Color.FromArgb(211, 84, 0);
            pnTotalEnrollments.Controls.Add(picTotalEnrollments);
            pnTotalEnrollments.Controls.Add(lblTotalEnrollments);
            pnTotalEnrollments.Controls.Add(lblTotalEnrollmentsTitle);
            pnTotalEnrollments.Dock = DockStyle.Fill;
            pnTotalEnrollments.Location = new Point(1086, 6);
            pnTotalEnrollments.Margin = new Padding(6);
            pnTotalEnrollments.Name = "pnTotalEnrollments";
            pnTotalEnrollments.Size = new Size(350, 108);
            pnTotalEnrollments.TabIndex = 3;
            // 
            // picTotalEnrollments
            // 
            picTotalEnrollments.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picTotalEnrollments.BackColor = Color.Transparent;
            picTotalEnrollments.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            picTotalEnrollments.IconColor = Color.White;
            picTotalEnrollments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTotalEnrollments.IconSize = 48;
            picTotalEnrollments.Location = new Point(284, 15);
            picTotalEnrollments.Name = "picTotalEnrollments";
            picTotalEnrollments.Size = new Size(48, 48);
            picTotalEnrollments.TabIndex = 0;
            picTotalEnrollments.TabStop = false;
            // 
            // lblTotalEnrollments
            // 
            lblTotalEnrollments.AutoSize = true;
            lblTotalEnrollments.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotalEnrollments.ForeColor = Color.White;
            lblTotalEnrollments.Location = new Point(15, 42);
            lblTotalEnrollments.Name = "lblTotalEnrollments";
            lblTotalEnrollments.Size = new Size(43, 50);
            lblTotalEnrollments.TabIndex = 2;
            lblTotalEnrollments.Text = "0";
            // 
            // lblTotalEnrollmentsTitle
            // 
            lblTotalEnrollmentsTitle.AutoSize = true;
            lblTotalEnrollmentsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalEnrollmentsTitle.ForeColor = Color.FromArgb(250, 230, 220);
            lblTotalEnrollmentsTitle.Location = new Point(16, 16);
            lblTotalEnrollmentsTitle.Name = "lblTotalEnrollmentsTitle";
            lblTotalEnrollmentsTitle.Size = new Size(181, 21);
            lblTotalEnrollmentsTitle.TabIndex = 1;
            lblTotalEnrollmentsTitle.Text = "TOTAL ENROLLMENTS";
            // 
            // tblChartsLayout
            // 
            tblChartsLayout.ColumnCount = 2;
            tblChartsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblChartsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblChartsLayout.Controls.Add(pnEnrollmentChartContainer, 0, 0);
            tblChartsLayout.Controls.Add(pnGenderChartContainer, 1, 0);
            tblChartsLayout.Controls.Add(pnGradeChartContainer, 0, 1);
            tblChartsLayout.Controls.Add(pnTopStudentsContainer, 1, 1);
            tblChartsLayout.Dock = DockStyle.Fill;
            tblChartsLayout.Location = new Point(10, 140);
            tblChartsLayout.Margin = new Padding(0);
            tblChartsLayout.Name = "tblChartsLayout";
            tblChartsLayout.RowCount = 2;
            tblChartsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblChartsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblChartsLayout.Size = new Size(1442, 744);
            tblChartsLayout.TabIndex = 1;
            // 
            // pnEnrollmentChartContainer
            // 
            pnEnrollmentChartContainer.BackColor = Color.White;
            pnEnrollmentChartContainer.Controls.Add(pnEnrollmentChart);
            pnEnrollmentChartContainer.Controls.Add(pnEnrollmentHeader);
            pnEnrollmentChartContainer.Dock = DockStyle.Fill;
            pnEnrollmentChartContainer.Location = new Point(8, 8);
            pnEnrollmentChartContainer.Margin = new Padding(8);
            pnEnrollmentChartContainer.Name = "pnEnrollmentChartContainer";
            pnEnrollmentChartContainer.Padding = new Padding(10);
            pnEnrollmentChartContainer.Size = new Size(705, 356);
            pnEnrollmentChartContainer.TabIndex = 0;
            // 
            // pnEnrollmentChart
            // 
            pnEnrollmentChart.Dock = DockStyle.Fill;
            pnEnrollmentChart.Location = new Point(10, 50);
            pnEnrollmentChart.Name = "pnEnrollmentChart";
            pnEnrollmentChart.Size = new Size(685, 296);
            pnEnrollmentChart.TabIndex = 1;
            // 
            // pnEnrollmentHeader
            // 
            pnEnrollmentHeader.Controls.Add(lblEnrollmentTitle);
            pnEnrollmentHeader.Dock = DockStyle.Top;
            pnEnrollmentHeader.Location = new Point(10, 10);
            pnEnrollmentHeader.Name = "pnEnrollmentHeader";
            pnEnrollmentHeader.Size = new Size(685, 40);
            pnEnrollmentHeader.TabIndex = 0;
            // 
            // lblEnrollmentTitle
            // 
            lblEnrollmentTitle.AutoSize = true;
            lblEnrollmentTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEnrollmentTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblEnrollmentTitle.Location = new Point(0, 5);
            lblEnrollmentTitle.Name = "lblEnrollmentTitle";
            lblEnrollmentTitle.Size = new Size(278, 28);
            lblEnrollmentTitle.TabIndex = 0;
            lblEnrollmentTitle.Text = "Student Enrollment by Year";
            // 
            // pnGenderChartContainer
            // 
            pnGenderChartContainer.BackColor = Color.White;
            pnGenderChartContainer.Controls.Add(pnStudentChart);
            pnGenderChartContainer.Controls.Add(pnGenderHeader);
            pnGenderChartContainer.Dock = DockStyle.Fill;
            pnGenderChartContainer.Location = new Point(729, 8);
            pnGenderChartContainer.Margin = new Padding(8);
            pnGenderChartContainer.Name = "pnGenderChartContainer";
            pnGenderChartContainer.Padding = new Padding(10);
            pnGenderChartContainer.Size = new Size(705, 356);
            pnGenderChartContainer.TabIndex = 1;
            // 
            // pnStudentChart
            // 
            pnStudentChart.Dock = DockStyle.Fill;
            pnStudentChart.Location = new Point(10, 50);
            pnStudentChart.Name = "pnStudentChart";
            pnStudentChart.Size = new Size(685, 296);
            pnStudentChart.TabIndex = 1;
            // 
            // pnGenderHeader
            // 
            pnGenderHeader.Controls.Add(lblGenderTitle);
            pnGenderHeader.Dock = DockStyle.Top;
            pnGenderHeader.Location = new Point(10, 10);
            pnGenderHeader.Name = "pnGenderHeader";
            pnGenderHeader.Size = new Size(685, 40);
            pnGenderHeader.TabIndex = 0;
            // 
            // lblGenderTitle
            // 
            lblGenderTitle.AutoSize = true;
            lblGenderTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGenderTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblGenderTitle.Location = new Point(0, 5);
            lblGenderTitle.Name = "lblGenderTitle";
            lblGenderTitle.Size = new Size(201, 28);
            lblGenderTitle.TabIndex = 0;
            lblGenderTitle.Text = "Gender Distribution";
            // 
            // pnGradeChartContainer
            // 
            pnGradeChartContainer.BackColor = Color.White;
            pnGradeChartContainer.Controls.Add(pnGradeChart);
            pnGradeChartContainer.Controls.Add(pnGradeHeader);
            pnGradeChartContainer.Dock = DockStyle.Fill;
            pnGradeChartContainer.Location = new Point(8, 380);
            pnGradeChartContainer.Margin = new Padding(8);
            pnGradeChartContainer.Name = "pnGradeChartContainer";
            pnGradeChartContainer.Padding = new Padding(10);
            pnGradeChartContainer.Size = new Size(705, 356);
            pnGradeChartContainer.TabIndex = 2;
            // 
            // pnGradeChart
            // 
            pnGradeChart.Dock = DockStyle.Fill;
            pnGradeChart.Location = new Point(10, 50);
            pnGradeChart.Name = "pnGradeChart";
            pnGradeChart.Size = new Size(685, 296);
            pnGradeChart.TabIndex = 1;
            // 
            // pnGradeHeader
            // 
            pnGradeHeader.Controls.Add(lblGradeTitle);
            pnGradeHeader.Dock = DockStyle.Top;
            pnGradeHeader.Location = new Point(10, 10);
            pnGradeHeader.Name = "pnGradeHeader";
            pnGradeHeader.Size = new Size(685, 40);
            pnGradeHeader.TabIndex = 0;
            // 
            // lblGradeTitle
            // 
            lblGradeTitle.AutoSize = true;
            lblGradeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGradeTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblGradeTitle.Location = new Point(0, 5);
            lblGradeTitle.Name = "lblGradeTitle";
            lblGradeTitle.Size = new Size(311, 28);
            lblGradeTitle.TabIndex = 0;
            lblGradeTitle.Text = "Academic Performance Overview";
            // 
            // pnTopStudentsContainer
            // 
            pnTopStudentsContainer.BackColor = Color.White;
            pnTopStudentsContainer.Controls.Add(dgvTopStudents);
            pnTopStudentsContainer.Controls.Add(pnTopStudentsHeader);
            pnTopStudentsContainer.Dock = DockStyle.Fill;
            pnTopStudentsContainer.Location = new Point(729, 380);
            pnTopStudentsContainer.Margin = new Padding(8);
            pnTopStudentsContainer.Name = "pnTopStudentsContainer";
            pnTopStudentsContainer.Padding = new Padding(10);
            pnTopStudentsContainer.Size = new Size(705, 356);
            pnTopStudentsContainer.TabIndex = 3;
            // 
            // dgvTopStudents
            // 
            dgvTopStudents.AllowUserToAddRows = false;
            dgvTopStudents.AllowUserToDeleteRows = false;
            dgvTopStudents.AllowUserToResizeRows = false;
            dgvTopStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopStudents.BackgroundColor = Color.White;
            dgvTopStudents.BorderStyle = BorderStyle.None;
            dgvTopStudents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTopStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTopStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTopStudents.ColumnHeadersHeight = 36;
            dgvTopStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTopStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTopStudents.Dock = DockStyle.Fill;
            dgvTopStudents.EnableHeadersVisualStyles = false;
            dgvTopStudents.GridColor = Color.FromArgb(235, 237, 240);
            dgvTopStudents.Location = new Point(10, 50);
            dgvTopStudents.MultiSelect = false;
            dgvTopStudents.Name = "dgvTopStudents";
            dgvTopStudents.ReadOnly = true;
            dgvTopStudents.RowHeadersVisible = false;
            dgvTopStudents.RowHeadersWidth = 51;
            dgvTopStudents.RowTemplate.Height = 32;
            dgvTopStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTopStudents.Size = new Size(685, 296);
            dgvTopStudents.TabIndex = 1;
            // 
            // pnTopStudentsHeader
            // 
            pnTopStudentsHeader.Controls.Add(lblTopStudentsTitle);
            pnTopStudentsHeader.Dock = DockStyle.Top;
            pnTopStudentsHeader.Location = new Point(10, 10);
            pnTopStudentsHeader.Name = "pnTopStudentsHeader";
            pnTopStudentsHeader.Size = new Size(685, 40);
            pnTopStudentsHeader.TabIndex = 0;
            // 
            // lblTopStudentsTitle
            // 
            lblTopStudentsTitle.AutoSize = true;
            lblTopStudentsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTopStudentsTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTopStudentsTitle.Location = new Point(0, 5);
            lblTopStudentsTitle.Name = "lblTopStudentsTitle";
            lblTopStudentsTitle.Size = new Size(275, 28);
            lblTopStudentsTitle.TabIndex = 0;
            lblTopStudentsTitle.Text = "Top 5 High-Performing (GPA)";
            // 
            // f_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 894);
            Controls.AddRange(new Control[] { tblMainLayout, pnlHeader });
            Name = "f_Dashboard";
            Text = "Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tblMainLayout.ResumeLayout(false);
            tblCardsLayout.ResumeLayout(false);
            pnTotalStudents.ResumeLayout(false);
            pnTotalStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).EndInit();
            pnTotalCourses.ResumeLayout(false);
            pnTotalCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalCourses).EndInit();
            pnTotalClasses.ResumeLayout(false);
            pnTotalClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalClasses).EndInit();
            pnTotalEnrollments.ResumeLayout(false);
            pnTotalEnrollments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalEnrollments).EndInit();
            tblChartsLayout.ResumeLayout(false);
            pnEnrollmentChartContainer.ResumeLayout(false);
            pnEnrollmentHeader.ResumeLayout(false);
            pnEnrollmentHeader.PerformLayout();
            pnGenderChartContainer.ResumeLayout(false);
            pnGenderHeader.ResumeLayout(false);
            pnGenderHeader.PerformLayout();
            pnGradeChartContainer.ResumeLayout(false);
            pnGradeHeader.ResumeLayout(false);
            pnGradeHeader.PerformLayout();
            pnTopStudentsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopStudents).EndInit();
            pnTopStudentsHeader.ResumeLayout(false);
            pnTopStudentsHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMainLayout;
        private System.Windows.Forms.TableLayoutPanel tblCardsLayout;
        private System.Windows.Forms.Panel pnTotalStudents;
        private FontAwesome.Sharp.IconPictureBox picTotalStudents;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblTotalStudentsTitle;
        private System.Windows.Forms.Panel pnTotalCourses;
        private FontAwesome.Sharp.IconPictureBox picTotalCourses;
        private System.Windows.Forms.Label lblTotalCourses;
        private System.Windows.Forms.Label lblTotalCoursesTitle;
        private System.Windows.Forms.Panel pnTotalClasses;
        private FontAwesome.Sharp.IconPictureBox picTotalClasses;
        private System.Windows.Forms.Label lblTotalClasses;
        private System.Windows.Forms.Label lblTotalClassesTitle;
        private System.Windows.Forms.Panel pnTotalEnrollments;
        private FontAwesome.Sharp.IconPictureBox picTotalEnrollments;
        private System.Windows.Forms.Label lblTotalEnrollments;
        private System.Windows.Forms.Label lblTotalEnrollmentsTitle;
        private System.Windows.Forms.TableLayoutPanel tblChartsLayout;
        private System.Windows.Forms.Panel pnEnrollmentChartContainer;
        private System.Windows.Forms.Panel pnEnrollmentChart;
        private System.Windows.Forms.Panel pnEnrollmentHeader;
        private System.Windows.Forms.Label lblEnrollmentTitle;
        private System.Windows.Forms.Panel pnGenderChartContainer;
        private System.Windows.Forms.Panel pnStudentChart;
        private System.Windows.Forms.Panel pnGenderHeader;
        private System.Windows.Forms.Label lblGenderTitle;
        private System.Windows.Forms.Panel pnGradeChartContainer;
        private System.Windows.Forms.Panel pnGradeChart;
        private System.Windows.Forms.Panel pnGradeHeader;
        private System.Windows.Forms.Label lblGradeTitle;
        private System.Windows.Forms.Panel pnTopStudentsContainer;
        private System.Windows.Forms.DataGridView dgvTopStudents;
        private System.Windows.Forms.Panel pnTopStudentsHeader;
        private System.Windows.Forms.Label lblTopStudentsTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
    }
}