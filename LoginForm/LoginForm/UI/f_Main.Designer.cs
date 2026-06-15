using FontAwesome.Sharp;

namespace LoginForm
{
    partial class f_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            pnSidebar = new Panel();
            pnMenu = new Panel();
            btnConfirmationRequest = new IconButton();
            btnClass = new IconButton();
            btnInformation = new IconButton();
            lblUser = new Label();
            btnScore = new IconButton();
            lblRole = new Label();
            btnCourseRegistation = new IconButton();
            btnCourse = new IconButton();
            btnApprove = new IconButton();
            btnStudent = new IconButton();
            btnOverview = new IconButton();
            progressAI = new ProgressBar();
            lblAIStatus = new Label();
            label1 = new Label();
            btnAskAI = new Button();
            txtAI = new TextBox();
            pnLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnBody = new Panel();
            pnTop = new Panel();
            btnClose = new Button();
            pnButtonContainer = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnSidebar.SuspendLayout();
            pnMenu.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnTop.SuspendLayout();
            pnButtonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnSidebar
            // 
            pnSidebar.Controls.Add(pnMenu);
            pnSidebar.Controls.Add(pnLogo);
            pnSidebar.Dock = DockStyle.Left;
            pnSidebar.Location = new Point(0, 0);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(311, 978);
            pnSidebar.TabIndex = 0;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.Transparent;
            pnMenu.BackgroundImageLayout = ImageLayout.None;
            pnMenu.BorderStyle = BorderStyle.Fixed3D;
            pnMenu.Controls.Add(btnConfirmationRequest);
            pnMenu.Controls.Add(btnClass);
            pnMenu.Controls.Add(btnInformation);
            pnMenu.Controls.Add(lblUser);
            pnMenu.Controls.Add(btnScore);
            pnMenu.Controls.Add(lblRole);
            pnMenu.Controls.Add(btnCourseRegistation);
            pnMenu.Controls.Add(btnCourse);
            pnMenu.Controls.Add(btnApprove);
            pnMenu.Controls.Add(btnStudent);
            pnMenu.Controls.Add(btnOverview);
            pnMenu.Controls.Add(progressAI);
            pnMenu.Controls.Add(lblAIStatus);
            pnMenu.Controls.Add(label1);
            pnMenu.Controls.Add(btnAskAI);
            pnMenu.Controls.Add(txtAI);
            pnMenu.Location = new Point(3, 150);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(304, 825);
            pnMenu.TabIndex = 1;
            pnMenu.MouseDown += pnlTop_MouseDown;
            // 
            // btnConfirmationRequest
            // 
            btnConfirmationRequest.BackColor = Color.Transparent;
            btnConfirmationRequest.Dock = DockStyle.Top;
            btnConfirmationRequest.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmationRequest.IconChar = IconChar.MortarBoard;
            btnConfirmationRequest.IconColor = Color.Black;
            btnConfirmationRequest.IconFont = IconFont.Auto;
            btnConfirmationRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmationRequest.Location = new Point(0, 608);
            btnConfirmationRequest.Name = "btnConfirmationRequest";
            btnConfirmationRequest.Size = new Size(300, 76);
            btnConfirmationRequest.TabIndex = 12;
            btnConfirmationRequest.Text = "Confirmation Request";
            btnConfirmationRequest.UseVisualStyleBackColor = false;
            btnConfirmationRequest.Click += btnConfirmationRequest_Click;
            // 
            // btnClass
            // 
            btnClass.BackColor = Color.Transparent;
            btnClass.Dock = DockStyle.Top;
            btnClass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClass.IconChar = IconChar.MortarBoard;
            btnClass.IconColor = Color.Black;
            btnClass.IconFont = IconFont.Auto;
            btnClass.ImageAlign = ContentAlignment.MiddleLeft;
            btnClass.Location = new Point(0, 532);
            btnClass.Name = "btnClass";
            btnClass.Size = new Size(300, 76);
            btnClass.TabIndex = 11;
            btnClass.Text = "Class";
            btnClass.UseVisualStyleBackColor = false;
            btnClass.Click += btnClass_Click;
            // 
            // btnInformation
            // 
            btnInformation.BackColor = Color.Transparent;
            btnInformation.Dock = DockStyle.Top;
            btnInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInformation.IconChar = IconChar.MortarBoard;
            btnInformation.IconColor = Color.Black;
            btnInformation.IconFont = IconFont.Auto;
            btnInformation.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformation.Location = new Point(0, 456);
            btnInformation.Name = "btnInformation";
            btnInformation.Size = new Size(300, 76);
            btnInformation.TabIndex = 10;
            btnInformation.Text = "Information";
            btnInformation.UseVisualStyleBackColor = false;
            btnInformation.Click += btnInformation_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Bottom;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(0, 765);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 28);
            lblUser.TabIndex = 0;
            lblUser.Text = "User: ";
            // 
            // btnScore
            // 
            btnScore.BackColor = Color.Transparent;
            btnScore.Dock = DockStyle.Top;
            btnScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnScore.IconChar = IconChar.MortarBoard;
            btnScore.IconColor = Color.Black;
            btnScore.IconFont = IconFont.Auto;
            btnScore.ImageAlign = ContentAlignment.MiddleLeft;
            btnScore.Location = new Point(0, 380);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(300, 76);
            btnScore.TabIndex = 9;
            btnScore.Text = "Score";
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btnScore_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Bottom;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(0, 793);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(62, 28);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role: ";
            // 
            // btnCourseRegistation
            // 
            btnCourseRegistation.BackColor = Color.Transparent;
            btnCourseRegistation.Dock = DockStyle.Top;
            btnCourseRegistation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCourseRegistation.IconChar = IconChar.ClipboardList;
            btnCourseRegistation.IconColor = Color.Black;
            btnCourseRegistation.IconFont = IconFont.Auto;
            btnCourseRegistation.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourseRegistation.Location = new Point(0, 304);
            btnCourseRegistation.Name = "btnCourseRegistation";
            btnCourseRegistation.Size = new Size(300, 76);
            btnCourseRegistation.TabIndex = 8;
            btnCourseRegistation.Text = "Courses Registation";
            btnCourseRegistation.UseVisualStyleBackColor = false;
            btnCourseRegistation.Click += btnCourseReg_Click;
            // 
            // btnCourse
            // 
            btnCourse.BackColor = Color.Transparent;
            btnCourse.Dock = DockStyle.Top;
            btnCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCourse.IconChar = IconChar.BookOpen;
            btnCourse.IconColor = Color.Black;
            btnCourse.IconFont = IconFont.Auto;
            btnCourse.ImageAlign = ContentAlignment.MiddleLeft;
            btnCourse.Location = new Point(0, 228);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(300, 76);
            btnCourse.TabIndex = 7;
            btnCourse.Text = "Courses";
            btnCourse.UseVisualStyleBackColor = false;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Transparent;
            btnApprove.Dock = DockStyle.Top;
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnApprove.IconChar = IconChar.CheckCircle;
            btnApprove.IconColor = Color.Black;
            btnApprove.IconFont = IconFont.Auto;
            btnApprove.ImageAlign = ContentAlignment.MiddleLeft;
            btnApprove.Location = new Point(0, 152);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(300, 76);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.Dock = DockStyle.Top;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStudent.IconChar = IconChar.UserGraduate;
            btnStudent.IconColor = Color.Black;
            btnStudent.IconFont = IconFont.Auto;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(0, 76);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(300, 76);
            btnStudent.TabIndex = 5;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Transparent;
            btnOverview.Dock = DockStyle.Top;
            btnOverview.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOverview.IconChar = IconChar.HomeUser;
            btnOverview.IconColor = Color.Black;
            btnOverview.IconFont = IconFont.Auto;
            btnOverview.ImageAlign = ContentAlignment.MiddleLeft;
            btnOverview.Location = new Point(0, 0);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(300, 76);
            btnOverview.TabIndex = 0;
            btnOverview.Text = "Dashboard";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // progressAI
            // 
            progressAI.Location = new Point(6, 751);
            progressAI.Name = "progressAI";
            progressAI.Size = new Size(281, 10);
            progressAI.TabIndex = 0;
            progressAI.Visible = false;
            // 
            // lblAIStatus
            // 
            lblAIStatus.AutoSize = true;
            lblAIStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAIStatus.Location = new Point(7, 455);
            lblAIStatus.Name = "lblAIStatus";
            lblAIStatus.Size = new Size(0, 20);
            lblAIStatus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 635);
            label1.Name = "label1";
            label1.Size = new Size(215, 28);
            label1.TabIndex = 4;
            label1.Text = "AI Navigation Support";
            // 
            // btnAskAI
            // 
            btnAskAI.Location = new Point(193, 767);
            btnAskAI.Name = "btnAskAI";
            btnAskAI.Size = new Size(94, 29);
            btnAskAI.TabIndex = 0;
            btnAskAI.Text = "Ask";
            btnAskAI.UseVisualStyleBackColor = true;
            btnAskAI.Click += btnAskAI_Click;
            // 
            // txtAI
            // 
            txtAI.Location = new Point(7, 665);
            txtAI.MaxLength = 50;
            txtAI.Multiline = true;
            txtAI.Name = "txtAI";
            txtAI.PlaceholderText = "What do you want to do?";
            txtAI.Size = new Size(280, 90);
            txtAI.TabIndex = 0;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.DodgerBlue;
            pnLogo.Controls.Add(pictureBox1);
            pnLogo.Location = new Point(0, 0);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(311, 144);
            pnLogo.TabIndex = 0;
            pnLogo.MouseDown += pnlTop_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnBody
            // 
            pnBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnBody.AutoScroll = true;
            pnBody.Location = new Point(311, 48);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1316, 927);
            pnBody.TabIndex = 1;
            pnBody.MouseDown += pnlTop_MouseDown;
            // 
            // pnTop
            // 
            pnTop.Controls.Add(btnClose);
            pnTop.Controls.Add(pnButtonContainer);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(311, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1316, 52);
            pnTop.TabIndex = 2;
            pnTop.MouseDown += pnlTop_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1264, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 39);
            btnClose.TabIndex = 15;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnButtonContainer
            // 
            pnButtonContainer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnButtonContainer.BackColor = Color.Transparent;
            pnButtonContainer.Controls.Add(btnMaximize);
            pnButtonContainer.Controls.Add(btnMinimize);
            pnButtonContainer.Location = new Point(1143, 0);
            pnButtonContainer.Name = "pnButtonContainer";
            pnButtonContainer.Size = new Size(173, 42);
            pnButtonContainer.TabIndex = 16;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(60, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(56, 39);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(4, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 39);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // f_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 978);
            Controls.Add(pnTop);
            Controls.Add(pnBody);
            Controls.Add(pnSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "f_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f_Main";
            Load += f_Main_Load;
            pnSidebar.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnTop.ResumeLayout(false);
            pnButtonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnSidebar;

        private Panel pnMenu;
        private Panel pnLogo;
        private Panel pnBody;

        private Label lblRole;
        private Label lblUser;
        private TextBox txtAI;
        private Button btnAskAI;
        private Label label1;
        private ProgressBar progressAI;
        private Label lblAIStatus;
        private PictureBox pictureBox1;
        private Panel pnTop;
        private Button btnClose;
        private Panel pnButtonContainer;
        private Button btnMaximize;
        private Button btnMinimize;

        private FontAwesome.Sharp.IconButton btnOverview;
        private FontAwesome.Sharp.IconButton btnStudent;
        private FontAwesome.Sharp.IconButton btnScore;
        private FontAwesome.Sharp.IconButton btnCourseRegistation;
        private FontAwesome.Sharp.IconButton btnCourse;
        private FontAwesome.Sharp.IconButton btnApprove;
        private IconButton btnInformation;
        private IconButton btnClass;
        private IconButton btnConfirmationRequest;
    }
}