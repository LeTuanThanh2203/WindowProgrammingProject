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
            btnExport = new IconButton();
            btnContact = new IconButton();
            btnAssign = new IconButton();
            btnConfirmationRequest = new IconButton();
            btnClass = new IconButton();
            btnInformation = new IconButton();
            btnScore = new IconButton();
            btnCourseRegistation = new IconButton();
            btnCourse = new IconButton();
            btnApprove = new IconButton();
            btnStudent = new IconButton();
            btnOverview = new IconButton();
            pnUserPanel = new Panel();
            lblUser = new Label();
            lblRole = new Label();
            btnLogout = new IconButton();
            pnLogo = new Panel();
            btnToggleSidebar = new IconButton();
            pictureBox1 = new PictureBox();
            pnBody = new Panel();
            pnTop = new Panel();
            btnClose = new Button();
            pnButtonContainer = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnSidebar.SuspendLayout();
            pnMenu.SuspendLayout();
            pnUserPanel.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnTop.SuspendLayout();
            pnButtonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnSidebar
            // 
            pnSidebar.Controls.Add(pnMenu);
            pnSidebar.Controls.Add(pnUserPanel);
            pnSidebar.Controls.Add(pnLogo);
            pnSidebar.Dock = DockStyle.Left;
            pnSidebar.Location = new Point(0, 0);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(305, 1005);
            pnSidebar.TabIndex = 0;
            // 
            // pnMenu
            // 
            pnMenu.AutoScroll = true;
            pnMenu.BackColor = Color.Transparent;
            pnMenu.BackgroundImageLayout = ImageLayout.None;
            pnMenu.Controls.Add(btnExport);
            pnMenu.Controls.Add(btnContact);
            pnMenu.Controls.Add(btnAssign);
            pnMenu.Controls.Add(btnConfirmationRequest);
            pnMenu.Controls.Add(btnClass);
            pnMenu.Controls.Add(btnInformation);
            pnMenu.Controls.Add(btnScore);
            pnMenu.Controls.Add(btnCourseRegistation);
            pnMenu.Controls.Add(btnCourse);
            pnMenu.Controls.Add(btnApprove);
            pnMenu.Controls.Add(btnStudent);
            pnMenu.Controls.Add(btnOverview);
            pnMenu.Dock = DockStyle.Fill;
            pnMenu.Location = new Point(0, 144);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(305, 721);
            pnMenu.TabIndex = 1;
            pnMenu.MouseDown += pnlTop_MouseDown;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.Transparent;
            btnExport.Dock = DockStyle.Top;
            btnExport.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExport.IconChar = IconChar.Print;
            btnExport.IconColor = Color.Black;
            btnExport.IconFont = IconFont.Auto;
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.Location = new Point(0, 836);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(284, 76);
            btnExport.TabIndex = 17;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnContact
            // 
            btnContact.BackColor = Color.Transparent;
            btnContact.Dock = DockStyle.Top;
            btnContact.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnContact.IconChar = IconChar.Phone;
            btnContact.IconColor = Color.Black;
            btnContact.IconFont = IconFont.Auto;
            btnContact.ImageAlign = ContentAlignment.MiddleLeft;
            btnContact.Location = new Point(0, 760);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(284, 76);
            btnContact.TabIndex = 16;
            btnContact.Text = "Contact";
            btnContact.UseVisualStyleBackColor = false;
            btnContact.Click += btnContact_Click;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.Transparent;
            btnAssign.Dock = DockStyle.Top;
            btnAssign.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAssign.IconChar = IconChar.NetworkWired;
            btnAssign.IconColor = Color.Black;
            btnAssign.IconFont = IconFont.Auto;
            btnAssign.ImageAlign = ContentAlignment.MiddleLeft;
            btnAssign.Location = new Point(0, 684);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(284, 76);
            btnAssign.TabIndex = 15;
            btnAssign.Text = "Assign ";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
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
            btnConfirmationRequest.Size = new Size(284, 76);
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
            btnClass.Size = new Size(284, 76);
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
            btnInformation.Size = new Size(284, 76);
            btnInformation.TabIndex = 10;
            btnInformation.Text = "Information";
            btnInformation.UseVisualStyleBackColor = false;
            btnInformation.Click += btnInformation_Click;
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
            btnScore.Size = new Size(284, 76);
            btnScore.TabIndex = 9;
            btnScore.Text = "Score";
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btnScore_Click;
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
            btnCourseRegistation.Size = new Size(284, 76);
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
            btnCourse.Size = new Size(284, 76);
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
            btnApprove.Size = new Size(284, 76);
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
            btnStudent.Size = new Size(284, 76);
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
            btnOverview.Size = new Size(284, 76);
            btnOverview.TabIndex = 0;
            btnOverview.Text = "Dashboard";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // pnUserPanel
            // 
            pnUserPanel.BackColor = Color.Transparent;
            pnUserPanel.Controls.Add(lblUser);
            pnUserPanel.Controls.Add(lblRole);
            pnUserPanel.Controls.Add(btnLogout);
            pnUserPanel.Dock = DockStyle.Bottom;
            pnUserPanel.Location = new Point(0, 865);
            pnUserPanel.Name = "pnUserPanel";
            pnUserPanel.Padding = new Padding(12, 10, 12, 10);
            pnUserPanel.Size = new Size(305, 140);
            pnUserPanel.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Bottom;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(12, 34);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 28);
            lblUser.TabIndex = 0;
            lblUser.Text = "User: ";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Dock = DockStyle.Bottom;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(12, 62);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(62, 28);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role: ";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(10, 61, 120);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = IconChar.SignOutAlt;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = IconFont.Auto;
            btnLogout.IconSize = 20;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 90);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(281, 40);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(10, 61, 120);
            pnLogo.Controls.Add(btnToggleSidebar);
            pnLogo.Controls.Add(pictureBox1);
            pnLogo.Dock = DockStyle.Top;
            pnLogo.Location = new Point(0, 0);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(305, 144);
            pnLogo.TabIndex = 0;
            pnLogo.MouseDown += pnlTop_MouseDown;
            // 
            // btnToggleSidebar
            // 
            btnToggleSidebar.BackColor = Color.Transparent;
            btnToggleSidebar.Cursor = Cursors.Hand;
            btnToggleSidebar.FlatAppearance.BorderSize = 0;
            btnToggleSidebar.FlatStyle = FlatStyle.Flat;
            btnToggleSidebar.IconChar = IconChar.ChevronLeft;
            btnToggleSidebar.IconColor = Color.White;
            btnToggleSidebar.IconFont = IconFont.Auto;
            btnToggleSidebar.IconSize = 24;
            btnToggleSidebar.Location = new Point(265, 10);
            btnToggleSidebar.Name = "btnToggleSidebar";
            btnToggleSidebar.Size = new Size(40, 40);
            btnToggleSidebar.TabIndex = 17;
            btnToggleSidebar.UseVisualStyleBackColor = true;
            btnToggleSidebar.Click += btnToggleSidebar_Click;
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
            pnBody.AutoScroll = true;
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(305, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1322, 1005);
            pnBody.TabIndex = 1;
            pnBody.MouseDown += pnlTop_MouseDown;
            // 
            // pnTop
            // 
            pnTop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnTop.BackColor = Color.Transparent;
            pnTop.Controls.Add(btnClose);
            pnTop.Controls.Add(pnButtonContainer);
            pnTop.Location = new Point(1472, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(155, 40);
            pnTop.TabIndex = 2;
            pnTop.MouseDown += pnlTop_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(106, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 39);
            btnClose.TabIndex = 15;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnButtonContainer
            // 
            pnButtonContainer.BackColor = Color.Transparent;
            pnButtonContainer.Controls.Add(btnMaximize);
            pnButtonContainer.Controls.Add(btnMinimize);
            pnButtonContainer.Location = new Point(0, 0);
            pnButtonContainer.Name = "pnButtonContainer";
            pnButtonContainer.Size = new Size(106, 40);
            pnButtonContainer.TabIndex = 16;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(50, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(56, 39);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(0, 0);
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
            ClientSize = new Size(1627, 1005);
            Controls.Add(pnBody);
            Controls.Add(pnTop);
            Controls.Add(pnSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "f_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f_Main";
            Load += f_Main_Load;
            pnSidebar.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            pnUserPanel.ResumeLayout(false);
            pnUserPanel.PerformLayout();
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
        private Panel pnUserPanel;
        private FontAwesome.Sharp.IconButton btnToggleSidebar;

        private Label lblRole;
        private Label lblUser;
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
        private IconButton btnLogout;
        private IconButton btnAssign;
        private IconButton btnContact;
        private IconButton btnExport;
    }
}