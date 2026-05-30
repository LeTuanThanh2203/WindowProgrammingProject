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
            pnBottom = new Panel();
            pnTop = new Panel();
            panel2 = new Panel();
            lblCourseTotal = new Label();
            lblCourseTotalTitle = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblAccountTotal = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pnContainerInfo = new Panel();
            lblStudentTotal = new Label();
            lbStudentTotalTitle = new Label();
            picStudentTotal = new PictureBox();
            pnTop.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnContainerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudentTotal).BeginInit();
            SuspendLayout();
            // 
            // pnBottom
            // 
            pnBottom.Dock = DockStyle.Bottom;
            pnBottom.Location = new Point(0, 274);
            pnBottom.Name = "pnBottom";
            pnBottom.Size = new Size(1176, 393);
            pnBottom.TabIndex = 0;
            // 
            // pnTop
            // 
            pnTop.Controls.Add(panel2);
            pnTop.Controls.Add(panel1);
            pnTop.Controls.Add(pnContainerInfo);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1176, 268);
            pnTop.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCourseTotal);
            panel2.Controls.Add(lblCourseTotalTitle);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(403, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 118);
            panel2.TabIndex = 3;
            // 
            // lblCourseTotal
            // 
            lblCourseTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCourseTotal.AutoSize = true;
            lblCourseTotal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseTotal.Location = new Point(139, 59);
            lblCourseTotal.Name = "lblCourseTotal";
            lblCourseTotal.Size = new Size(27, 31);
            lblCourseTotal.TabIndex = 2;
            lblCourseTotal.Text = "0";
            // 
            // lblCourseTotalTitle
            // 
            lblCourseTotalTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCourseTotalTitle.AutoSize = true;
            lblCourseTotalTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourseTotalTitle.Location = new Point(143, 16);
            lblCourseTotalTitle.Name = "lblCourseTotalTitle";
            lblCourseTotalTitle.Size = new Size(93, 31);
            lblCourseTotalTitle.TabIndex = 1;
            lblCourseTotalTitle.Text = "Course ";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Location = new Point(0, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAccountTotal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(786, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 118);
            panel1.TabIndex = 3;
            // 
            // lblAccountTotal
            // 
            lblAccountTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblAccountTotal.AutoSize = true;
            lblAccountTotal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountTotal.Location = new Point(139, 59);
            lblAccountTotal.Name = "lblAccountTotal";
            lblAccountTotal.Size = new Size(27, 31);
            lblAccountTotal.TabIndex = 2;
            lblAccountTotal.Text = "0";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 22);
            label2.Name = "label2";
            label2.Size = new Size(207, 31);
            label2.TabIndex = 1;
            label2.Text = "Account Approval";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnContainerInfo
            // 
            pnContainerInfo.Controls.Add(lblStudentTotal);
            pnContainerInfo.Controls.Add(lbStudentTotalTitle);
            pnContainerInfo.Controls.Add(picStudentTotal);
            pnContainerInfo.Location = new Point(31, 99);
            pnContainerInfo.Name = "pnContainerInfo";
            pnContainerInfo.Size = new Size(296, 121);
            pnContainerInfo.TabIndex = 0;
            // 
            // lblStudentTotal
            // 
            lblStudentTotal.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblStudentTotal.AutoSize = true;
            lblStudentTotal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentTotal.Location = new Point(139, 50);
            lblStudentTotal.Name = "lblStudentTotal";
            lblStudentTotal.Size = new Size(27, 31);
            lblStudentTotal.TabIndex = 2;
            lblStudentTotal.Text = "0";
            // 
            // lbStudentTotalTitle
            // 
            lbStudentTotalTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbStudentTotalTitle.AutoSize = true;
            lbStudentTotalTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStudentTotalTitle.Location = new Point(136, 19);
            lbStudentTotalTitle.Name = "lbStudentTotalTitle";
            lbStudentTotalTitle.Size = new Size(157, 31);
            lbStudentTotalTitle.TabIndex = 1;
            lbStudentTotalTitle.Text = "Student Total";
            // 
            // picStudentTotal
            // 
            picStudentTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picStudentTotal.Location = new Point(0, 3);
            picStudentTotal.Name = "picStudentTotal";
            picStudentTotal.Size = new Size(135, 115);
            picStudentTotal.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudentTotal.TabIndex = 0;
            picStudentTotal.TabStop = false;
            // 
            // f_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 667);
            Controls.Add(pnTop);
            Controls.Add(pnBottom);
            Name = "f_Dashboard";
            Text = "Dashboard";
            pnTop.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnContainerInfo.ResumeLayout(false);
            pnContainerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudentTotal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBottom;
        private Panel pnTop;
        private Panel pnContainerInfo;
        private Label lbStudentTotalTitle;
        private PictureBox picStudentTotal;
        private Label lblStudentTotal;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblCourseTotal;
        private Label lblCourseTotalTitle;
        private PictureBox pictureBox2;
        private Label lblAccountTotal;
    }
}