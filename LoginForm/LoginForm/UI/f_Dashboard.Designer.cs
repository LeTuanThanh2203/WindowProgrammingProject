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
            pnStaticStudent = new Panel();
            panel1 = new Panel();
            lblStudentStatistics = new Label();
            pnStudentChart = new Panel();
            pnTop = new Panel();
            pnOtherStudents = new Panel();
            picOtherPercent = new FontAwesome.Sharp.IconPictureBox();
            lblOtherPercent = new Label();
            lblOtherPercentTitle = new Label();
            pnMaleStudents = new Panel();
            picMalePercent = new FontAwesome.Sharp.IconPictureBox();
            lblMalePercent = new Label();
            lblMalePercentTitle = new Label();
            pnFemaleStudents = new Panel();
            picFemalePercent = new FontAwesome.Sharp.IconPictureBox();
            lblFemalePercent = new Label();
            lblFemalePercentTitle = new Label();
            pnTotalStudents = new Panel();
            picTotalStudents = new FontAwesome.Sharp.IconPictureBox();
            lblTotalStudents = new Label();
            lblTotalStudentsTitle = new Label();
            pnStaticStudentEnrollment = new Panel();
            pnStudentEnrollmentTop = new Panel();
            StudentEnrollment = new Label();
            pnEnrollmentChart = new Panel();
            pnStaticStudent.SuspendLayout();
            panel1.SuspendLayout();
            pnTop.SuspendLayout();
            pnOtherStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOtherPercent).BeginInit();
            pnMaleStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMalePercent).BeginInit();
            pnFemaleStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFemalePercent).BeginInit();
            pnTotalStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).BeginInit();
            pnStaticStudentEnrollment.SuspendLayout();
            pnStudentEnrollmentTop.SuspendLayout();
            SuspendLayout();
            // 
            // pnStaticStudent
            // 
            pnStaticStudent.Controls.Add(panel1);
            pnStaticStudent.Controls.Add(pnStudentChart);
            pnStaticStudent.Location = new Point(12, 195);
            pnStaticStudent.Name = "pnStaticStudent";
            pnStaticStudent.Size = new Size(608, 354);
            pnStaticStudent.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblStudentStatistics);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 45);
            panel1.TabIndex = 2;
            // 
            // lblStudentStatistics
            // 
            lblStudentStatistics.AutoSize = true;
            lblStudentStatistics.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentStatistics.Location = new Point(3, 10);
            lblStudentStatistics.Name = "lblStudentStatistics";
            lblStudentStatistics.Size = new Size(200, 31);
            lblStudentStatistics.TabIndex = 0;
            lblStudentStatistics.Text = "Student Statistics";
            // 
            // pnStudentChart
            // 
            pnStudentChart.Dock = DockStyle.Bottom;
            pnStudentChart.Location = new Point(0, 54);
            pnStudentChart.Name = "pnStudentChart";
            pnStudentChart.Size = new Size(608, 300);
            pnStudentChart.TabIndex = 1;
            // 
            // pnTop
            // 
            pnTop.Controls.Add(pnOtherStudents);
            pnTop.Controls.Add(pnMaleStudents);
            pnTop.Controls.Add(pnFemaleStudents);
            pnTop.Controls.Add(pnTotalStudents);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1462, 150);
            pnTop.TabIndex = 1;
            // 
            // pnOtherStudents
            // 
            pnOtherStudents.BackColor = Color.FromArgb(215, 189, 226);
            pnOtherStudents.Controls.Add(picOtherPercent);
            pnOtherStudents.Controls.Add(lblOtherPercent);
            pnOtherStudents.Controls.Add(lblOtherPercentTitle);
            pnOtherStudents.Location = new Point(1014, 9);
            pnOtherStudents.Name = "pnOtherStudents";
            pnOtherStudents.Size = new Size(291, 116);
            pnOtherStudents.TabIndex = 4;
            pnOtherStudents.MouseEnter += Panel_MouseEnter;
            pnOtherStudents.MouseLeave += Panel_MouseLeave;
            // 
            // picOtherPercent
            // 
            picOtherPercent.BackColor = Color.Transparent;
            picOtherPercent.ForeColor = SystemColors.ControlText;
            picOtherPercent.IconChar = FontAwesome.Sharp.IconChar.User;
            picOtherPercent.IconColor = SystemColors.ControlText;
            picOtherPercent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picOtherPercent.IconSize = 113;
            picOtherPercent.Location = new Point(0, 3);
            picOtherPercent.Name = "picOtherPercent";
            picOtherPercent.Size = new Size(124, 113);
            picOtherPercent.TabIndex = 5;
            picOtherPercent.TabStop = false;
            picOtherPercent.MouseEnter += Panel_MouseEnter;
            picOtherPercent.MouseLeave += Panel_MouseLeave;
            // 
            // lblOtherPercent
            // 
            lblOtherPercent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblOtherPercent.AutoSize = true;
            lblOtherPercent.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOtherPercent.Location = new Point(139, 66);
            lblOtherPercent.Name = "lblOtherPercent";
            lblOtherPercent.Size = new Size(27, 31);
            lblOtherPercent.TabIndex = 2;
            lblOtherPercent.Text = "0";
            lblOtherPercent.MouseEnter += Panel_MouseEnter;
            lblOtherPercent.MouseLeave += Panel_MouseLeave;
            // 
            // lblOtherPercentTitle
            // 
            lblOtherPercentTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOtherPercentTitle.AutoSize = true;
            lblOtherPercentTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOtherPercentTitle.Location = new Point(144, 14);
            lblOtherPercentTitle.Name = "lblOtherPercentTitle";
            lblOtherPercentTitle.Size = new Size(75, 31);
            lblOtherPercentTitle.TabIndex = 1;
            lblOtherPercentTitle.Text = "Other";
            lblOtherPercentTitle.MouseEnter += Panel_MouseEnter;
            lblOtherPercentTitle.MouseLeave += Panel_MouseLeave;
            // 
            // pnMaleStudents
            // 
            pnMaleStudents.Anchor = AnchorStyles.Left;
            pnMaleStudents.BackColor = Color.FromArgb(169, 223, 191);
            pnMaleStudents.Controls.Add(picMalePercent);
            pnMaleStudents.Controls.Add(lblMalePercent);
            pnMaleStudents.Controls.Add(lblMalePercentTitle);
            pnMaleStudents.Location = new Point(352, 7);
            pnMaleStudents.Name = "pnMaleStudents";
            pnMaleStudents.Size = new Size(279, 118);
            pnMaleStudents.TabIndex = 3;
            pnMaleStudents.MouseEnter += Panel_MouseEnter;
            pnMaleStudents.MouseLeave += Panel_MouseLeave;
            // 
            // picMalePercent
            // 
            picMalePercent.BackColor = Color.Transparent;
            picMalePercent.ForeColor = SystemColors.ControlText;
            picMalePercent.IconChar = FontAwesome.Sharp.IconChar.User;
            picMalePercent.IconColor = SystemColors.ControlText;
            picMalePercent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picMalePercent.IconSize = 117;
            picMalePercent.Location = new Point(0, 0);
            picMalePercent.Name = "picMalePercent";
            picMalePercent.Size = new Size(124, 117);
            picMalePercent.TabIndex = 3;
            picMalePercent.TabStop = false;
            picMalePercent.MouseEnter += Panel_MouseEnter;
            picMalePercent.MouseLeave += Panel_MouseLeave;
            // 
            // lblMalePercent
            // 
            lblMalePercent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblMalePercent.AutoSize = true;
            lblMalePercent.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMalePercent.Location = new Point(139, 59);
            lblMalePercent.Name = "lblMalePercent";
            lblMalePercent.Size = new Size(27, 31);
            lblMalePercent.TabIndex = 2;
            lblMalePercent.Text = "0";
            lblMalePercent.MouseEnter += Panel_MouseEnter;
            lblMalePercent.MouseLeave += Panel_MouseLeave;
            // 
            // lblMalePercentTitle
            // 
            lblMalePercentTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMalePercentTitle.AutoSize = true;
            lblMalePercentTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMalePercentTitle.Location = new Point(142, 16);
            lblMalePercentTitle.Name = "lblMalePercentTitle";
            lblMalePercentTitle.Size = new Size(67, 31);
            lblMalePercentTitle.TabIndex = 1;
            lblMalePercentTitle.Text = "Male";
            lblMalePercentTitle.MouseEnter += Panel_MouseEnter;
            lblMalePercentTitle.MouseLeave += Panel_MouseLeave;
            // 
            // pnFemaleStudents
            // 
            pnFemaleStudents.BackColor = Color.FromArgb(245, 183, 177);
            pnFemaleStudents.Controls.Add(picFemalePercent);
            pnFemaleStudents.Controls.Add(lblFemalePercent);
            pnFemaleStudents.Controls.Add(lblFemalePercentTitle);
            pnFemaleStudents.Location = new Point(682, 9);
            pnFemaleStudents.Name = "pnFemaleStudents";
            pnFemaleStudents.Size = new Size(291, 116);
            pnFemaleStudents.TabIndex = 3;
            pnFemaleStudents.MouseEnter += Panel_MouseEnter;
            pnFemaleStudents.MouseLeave += Panel_MouseLeave;
            // 
            // picFemalePercent
            // 
            picFemalePercent.BackColor = Color.Transparent;
            picFemalePercent.ForeColor = SystemColors.ControlText;
            picFemalePercent.IconChar = FontAwesome.Sharp.IconChar.User;
            picFemalePercent.IconColor = SystemColors.ControlText;
            picFemalePercent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picFemalePercent.IconSize = 113;
            picFemalePercent.Location = new Point(0, 3);
            picFemalePercent.Name = "picFemalePercent";
            picFemalePercent.Size = new Size(124, 113);
            picFemalePercent.TabIndex = 4;
            picFemalePercent.TabStop = false;
            picFemalePercent.MouseEnter += Panel_MouseEnter;
            picFemalePercent.MouseLeave += Panel_MouseLeave;
            // 
            // lblFemalePercent
            // 
            lblFemalePercent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFemalePercent.AutoSize = true;
            lblFemalePercent.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFemalePercent.Location = new Point(139, 58);
            lblFemalePercent.Name = "lblFemalePercent";
            lblFemalePercent.Size = new Size(27, 31);
            lblFemalePercent.TabIndex = 2;
            lblFemalePercent.Text = "0";
            lblFemalePercent.MouseEnter += Panel_MouseEnter;
            lblFemalePercent.MouseLeave += Panel_MouseLeave;
            // 
            // lblFemalePercentTitle
            // 
            lblFemalePercentTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFemalePercentTitle.AutoSize = true;
            lblFemalePercentTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFemalePercentTitle.Location = new Point(139, 14);
            lblFemalePercentTitle.Name = "lblFemalePercentTitle";
            lblFemalePercentTitle.Size = new Size(90, 31);
            lblFemalePercentTitle.TabIndex = 1;
            lblFemalePercentTitle.Text = "Female";
            lblFemalePercentTitle.MouseEnter += Panel_MouseEnter;
            lblFemalePercentTitle.MouseLeave += Panel_MouseLeave;
            // 
            // pnTotalStudents
            // 
            pnTotalStudents.BackColor = Color.FromArgb(174, 214, 241);
            pnTotalStudents.Controls.Add(picTotalStudents);
            pnTotalStudents.Controls.Add(lblTotalStudents);
            pnTotalStudents.Controls.Add(lblTotalStudentsTitle);
            pnTotalStudents.Location = new Point(8, 12);
            pnTotalStudents.Name = "pnTotalStudents";
            pnTotalStudents.Size = new Size(306, 113);
            pnTotalStudents.TabIndex = 0;
            pnTotalStudents.MouseEnter += Panel_MouseEnter;
            pnTotalStudents.MouseLeave += Panel_MouseLeave;
            // 
            // picTotalStudents
            // 
            picTotalStudents.BackColor = Color.Transparent;
            picTotalStudents.ForeColor = SystemColors.ControlText;
            picTotalStudents.IconChar = FontAwesome.Sharp.IconChar.Users;
            picTotalStudents.IconColor = SystemColors.ControlText;
            picTotalStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTotalStudents.IconSize = 117;
            picTotalStudents.Location = new Point(0, -4);
            picTotalStudents.Name = "picTotalStudents";
            picTotalStudents.Size = new Size(124, 117);
            picTotalStudents.TabIndex = 2;
            picTotalStudents.TabStop = false;
            picTotalStudents.MouseEnter += Panel_MouseEnter;
            picTotalStudents.MouseLeave += Panel_MouseLeave;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudents.Location = new Point(139, 57);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(27, 31);
            lblTotalStudents.TabIndex = 2;
            lblTotalStudents.Text = "0";
            lblTotalStudents.MouseEnter += Panel_MouseEnter;
            lblTotalStudents.MouseLeave += Panel_MouseLeave;
            // 
            // lblTotalStudentsTitle
            // 
            lblTotalStudentsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalStudentsTitle.AutoSize = true;
            lblTotalStudentsTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudentsTitle.Location = new Point(136, 13);
            lblTotalStudentsTitle.Name = "lblTotalStudentsTitle";
            lblTotalStudentsTitle.Size = new Size(167, 31);
            lblTotalStudentsTitle.TabIndex = 1;
            lblTotalStudentsTitle.Text = "Total Students";
            lblTotalStudentsTitle.MouseEnter += Panel_MouseEnter;
            lblTotalStudentsTitle.MouseLeave += Panel_MouseLeave;
            // 
            // pnStaticStudentEnrollment
            // 
            pnStaticStudentEnrollment.Controls.Add(pnStudentEnrollmentTop);
            pnStaticStudentEnrollment.Controls.Add(pnEnrollmentChart);
            pnStaticStudentEnrollment.Location = new Point(691, 195);
            pnStaticStudentEnrollment.Name = "pnStaticStudentEnrollment";
            pnStaticStudentEnrollment.Size = new Size(608, 354);
            pnStaticStudentEnrollment.TabIndex = 3;
            // 
            // pnStudentEnrollmentTop
            // 
            pnStudentEnrollmentTop.Controls.Add(StudentEnrollment);
            pnStudentEnrollmentTop.Dock = DockStyle.Top;
            pnStudentEnrollmentTop.Location = new Point(0, 0);
            pnStudentEnrollmentTop.Name = "pnStudentEnrollmentTop";
            pnStudentEnrollmentTop.Size = new Size(608, 45);
            pnStudentEnrollmentTop.TabIndex = 2;
            // 
            // StudentEnrollment
            // 
            StudentEnrollment.AutoSize = true;
            StudentEnrollment.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentEnrollment.Location = new Point(3, 10);
            StudentEnrollment.Name = "StudentEnrollment";
            StudentEnrollment.Size = new Size(223, 31);
            StudentEnrollment.TabIndex = 0;
            StudentEnrollment.Text = "Student Enrollment";
            // 
            // pnEnrollmentChart
            // 
            pnEnrollmentChart.Dock = DockStyle.Bottom;
            pnEnrollmentChart.Location = new Point(0, 54);
            pnEnrollmentChart.Name = "pnEnrollmentChart";
            pnEnrollmentChart.Size = new Size(608, 300);
            pnEnrollmentChart.TabIndex = 1;
            // 
            // f_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 894);
            Controls.Add(pnStaticStudentEnrollment);
            Controls.Add(pnTop);
            Controls.Add(pnStaticStudent);
            Name = "f_Dashboard";
            Text = "Dashboard";
            pnStaticStudent.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnTop.ResumeLayout(false);
            pnOtherStudents.ResumeLayout(false);
            pnOtherStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOtherPercent).EndInit();
            pnMaleStudents.ResumeLayout(false);
            pnMaleStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMalePercent).EndInit();
            pnFemaleStudents.ResumeLayout(false);
            pnFemaleStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFemalePercent).EndInit();
            pnTotalStudents.ResumeLayout(false);
            pnTotalStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTotalStudents).EndInit();
            pnStaticStudentEnrollment.ResumeLayout(false);
            pnStudentEnrollmentTop.ResumeLayout(false);
            pnStudentEnrollmentTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnStaticStudent;
        private Panel pnTop;
        private Panel pnTotalStudents;
        private Label lblTotalStudentsTitle;
        private Label lblTotalStudents;
        private Panel pnFemaleStudents;
        private Label lblStudentStatistics;
        private Label lblFemalePercentTitle;
        private Panel pnMaleStudents;
        private Label lblMalePercent;
        private Label lblMalePercentTitle;
        private Label lblFemalePercent;
        private Panel pnOtherStudents;
        private Label lblOtherPercent;
        private Label lblOtherPercentTitle;
        private Panel pnStudentChart;
        private FontAwesome.Sharp.IconPictureBox picOtherPercent;
        private FontAwesome.Sharp.IconPictureBox picMalePercent;
        private FontAwesome.Sharp.IconPictureBox picFemalePercent;
        private FontAwesome.Sharp.IconPictureBox picTotalStudents;
        private Panel panel1;
        private Panel pnStaticStudentEnrollment;
        private Panel pnStudentEnrollmentTop;
        private Label StudentEnrollment;
        private Panel pnEnrollmentChart;
    }
}