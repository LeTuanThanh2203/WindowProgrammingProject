namespace LoginForm
{
    public partial class f_LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_LoginForm));
            lbl_Password = new Label();
            lbl_Username = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            linklbl_Register = new LinkLabel();
            pnRight = new Panel();
            btnClose = new Button();
            pnButtonContainer = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnWelcome = new Panel();
            pnWelcomeText = new Panel();
            lblWelcomeText2 = new Label();
            lblWelcomeText = new Label();
            lblRegisterAnswer = new Label();
            pnWelcomeTitle = new Panel();
            lblWelcome = new Label();
            cb_isShowPassword = new CheckBox();
            cb_RememberMe = new CheckBox();
            bt_Login = new Button();
            linklbl_ForgotPassword = new LinkLabel();
            lbl_Title = new Label();
            pnLeft = new Panel();
            bt_Cancel = new Button();
            bindingSource1 = new BindingSource(components);
            pnRight.SuspendLayout();
            pnButtonContainer.SuspendLayout();
            pnWelcome.SuspendLayout();
            pnWelcomeText.SuspendLayout();
            pnWelcomeTitle.SuspendLayout();
            pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Password
            // 
            lbl_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(13, 322);
            lbl_Password.Margin = new Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(132, 38);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            lbl_Username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(13, 229);
            lbl_Username.Margin = new Padding(4, 0, 4, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(142, 38);
            lbl_Username.TabIndex = 4;
            lbl_Username.Text = "Username";
            // 
            // txt_UserName
            // 
            txt_UserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_UserName.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_UserName.Location = new Point(13, 273);
            txt_UserName.Margin = new Padding(4, 3, 4, 3);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(683, 33);
            txt_UserName.TabIndex = 7;
            // 
            // txt_Password
            // 
            txt_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Password.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Password.Location = new Point(13, 389);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(683, 33);
            txt_Password.TabIndex = 8;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // linklbl_Register
            // 
            linklbl_Register.Anchor = AnchorStyles.None;
            linklbl_Register.AutoSize = true;
            linklbl_Register.Cursor = Cursors.Hand;
            linklbl_Register.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_Register.LinkBehavior = LinkBehavior.HoverUnderline;
            linklbl_Register.LinkColor = Color.Navy;
            linklbl_Register.Location = new Point(467, 147);
            linklbl_Register.Margin = new Padding(4, 0, 4, 0);
            linklbl_Register.Name = "linklbl_Register";
            linklbl_Register.Size = new Size(103, 38);
            linklbl_Register.TabIndex = 10;
            linklbl_Register.TabStop = true;
            linklbl_Register.Text = "Signup";
            linklbl_Register.LinkClicked += linklbl_Register_LinkClicked;
            // 
            // pnRight
            // 
            pnRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnRight.BackColor = Color.DeepSkyBlue;
            pnRight.BackgroundImage = (Image)resources.GetObject("pnRight.BackgroundImage");
            pnRight.BackgroundImageLayout = ImageLayout.Stretch;
            pnRight.Controls.Add(btnClose);
            pnRight.Controls.Add(pnButtonContainer);
            pnRight.Controls.Add(pnWelcome);
            pnRight.Location = new Point(696, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(726, 853);
            pnRight.TabIndex = 13;
            pnRight.MouseDown += pnlTop_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(674, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 39);
            btnClose.TabIndex = 13;
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
            pnButtonContainer.Location = new Point(553, 0);
            pnButtonContainer.Name = "pnButtonContainer";
            pnButtonContainer.Size = new Size(173, 42);
            pnButtonContainer.TabIndex = 14;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(59, 0);
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
            btnMinimize.Location = new Point(3, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 39);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnWelcome
            // 
            pnWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnWelcome.Controls.Add(pnWelcomeText);
            pnWelcome.Controls.Add(pnWelcomeTitle);
            pnWelcome.Location = new Point(35, 217);
            pnWelcome.Name = "pnWelcome";
            pnWelcome.Size = new Size(679, 293);
            pnWelcome.TabIndex = 14;
            // 
            // pnWelcomeText
            // 
            pnWelcomeText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnWelcomeText.Controls.Add(lblWelcomeText2);
            pnWelcomeText.Controls.Add(lblWelcomeText);
            pnWelcomeText.Controls.Add(lblRegisterAnswer);
            pnWelcomeText.Controls.Add(linklbl_Register);
            pnWelcomeText.Location = new Point(3, 72);
            pnWelcomeText.Name = "pnWelcomeText";
            pnWelcomeText.Size = new Size(662, 213);
            pnWelcomeText.TabIndex = 15;
            // 
            // lblWelcomeText2
            // 
            lblWelcomeText2.Anchor = AnchorStyles.None;
            lblWelcomeText2.BackColor = Color.Transparent;
            lblWelcomeText2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeText2.ForeColor = Color.White;
            lblWelcomeText2.Location = new Point(157, 75);
            lblWelcomeText2.Name = "lblWelcomeText2";
            lblWelcomeText2.Size = new Size(362, 72);
            lblWelcomeText2.TabIndex = 15;
            lblWelcomeText2.Text = "It's great to see you again\r\n\r\n   ";
            // 
            // lblWelcomeText
            // 
            lblWelcomeText.Anchor = AnchorStyles.None;
            lblWelcomeText.BackColor = Color.Transparent;
            lblWelcomeText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeText.ForeColor = Color.White;
            lblWelcomeText.Location = new Point(79, 22);
            lblWelcomeText.Name = "lblWelcomeText";
            lblWelcomeText.Size = new Size(502, 110);
            lblWelcomeText.TabIndex = 14;
            lblWelcomeText.Text = "We are so happy to have you here\r\n\r\n\r\n   ";
            // 
            // lblRegisterAnswer
            // 
            lblRegisterAnswer.Anchor = AnchorStyles.None;
            lblRegisterAnswer.AutoSize = true;
            lblRegisterAnswer.BackColor = Color.DeepSkyBlue;
            lblRegisterAnswer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegisterAnswer.ForeColor = Color.White;
            lblRegisterAnswer.Location = new Point(79, 147);
            lblRegisterAnswer.Name = "lblRegisterAnswer";
            lblRegisterAnswer.Size = new Size(395, 38);
            lblRegisterAnswer.TabIndex = 12;
            lblRegisterAnswer.Text = "Already have an account yet ? ";
            // 
            // pnWelcomeTitle
            // 
            pnWelcomeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnWelcomeTitle.Controls.Add(lblWelcome);
            pnWelcomeTitle.Location = new Point(0, 1);
            pnWelcomeTitle.Name = "pnWelcomeTitle";
            pnWelcomeTitle.Size = new Size(676, 88);
            pnWelcomeTitle.TabIndex = 14;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.None;
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(211, -1);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(297, 54);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "Welcome Back";
            // 
            // cb_isShowPassword
            // 
            cb_isShowPassword.AutoSize = true;
            cb_isShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_isShowPassword.Location = new Point(13, 438);
            cb_isShowPassword.Margin = new Padding(4, 3, 4, 3);
            cb_isShowPassword.Name = "cb_isShowPassword";
            cb_isShowPassword.Size = new Size(148, 27);
            cb_isShowPassword.TabIndex = 9;
            cb_isShowPassword.Text = "Show Password";
            cb_isShowPassword.UseVisualStyleBackColor = true;
            cb_isShowPassword.CheckedChanged += cb_isShowPassword_CheckedChanged;
            // 
            // cb_RememberMe
            // 
            cb_RememberMe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cb_RememberMe.AutoSize = true;
            cb_RememberMe.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_RememberMe.Location = new Point(552, 438);
            cb_RememberMe.Margin = new Padding(4, 3, 4, 3);
            cb_RememberMe.Name = "cb_RememberMe";
            cb_RememberMe.Size = new Size(144, 27);
            cb_RememberMe.TabIndex = 11;
            cb_RememberMe.Text = "Remember Me";
            cb_RememberMe.UseVisualStyleBackColor = true;
            // 
            // bt_Login
            // 
            bt_Login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bt_Login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Login.BackColor = Color.FromArgb(0, 123, 255);
            bt_Login.BackgroundImageLayout = ImageLayout.None;
            bt_Login.Cursor = Cursors.Hand;
            bt_Login.FlatAppearance.BorderSize = 0;
            bt_Login.FlatStyle = FlatStyle.Flat;
            bt_Login.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Login.Location = new Point(109, 517);
            bt_Login.Margin = new Padding(4, 3, 4, 3);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(521, 67);
            bt_Login.TabIndex = 6;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = false;
            bt_Login.Click += bt_Login_Click;
            // 
            // linklbl_ForgotPassword
            // 
            linklbl_ForgotPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linklbl_ForgotPassword.AutoSize = true;
            linklbl_ForgotPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_ForgotPassword.LinkBehavior = LinkBehavior.HoverUnderline;
            linklbl_ForgotPassword.LinkColor = Color.MidnightBlue;
            linklbl_ForgotPassword.Location = new Point(268, 688);
            linklbl_ForgotPassword.Margin = new Padding(4, 0, 4, 0);
            linklbl_ForgotPassword.Name = "linklbl_ForgotPassword";
            linklbl_ForgotPassword.Size = new Size(193, 31);
            linklbl_ForgotPassword.TabIndex = 12;
            linklbl_ForgotPassword.TabStop = true;
            linklbl_ForgotPassword.Text = "Forgot Password?";
            linklbl_ForgotPassword.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.Black;
            lbl_Title.Location = new Point(259, 44);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(222, 81);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Sign in";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            pnLeft.Controls.Add(lbl_Title);
            pnLeft.Controls.Add(bt_Login);
            pnLeft.Controls.Add(linklbl_ForgotPassword);
            pnLeft.Controls.Add(cb_RememberMe);
            pnLeft.Controls.Add(cb_isShowPassword);
            pnLeft.Controls.Add(txt_Password);
            pnLeft.Controls.Add(bt_Cancel);
            pnLeft.Controls.Add(txt_UserName);
            pnLeft.Controls.Add(lbl_Password);
            pnLeft.Controls.Add(lbl_Username);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(713, 853);
            pnLeft.TabIndex = 14;
            pnLeft.MouseDown += pnlTop_MouseDown;
            // 
            // bt_Cancel
            // 
            bt_Cancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bt_Cancel.AutoSize = true;
            bt_Cancel.BackColor = Color.Transparent;
            bt_Cancel.Cursor = Cursors.Hand;
            bt_Cancel.FlatStyle = FlatStyle.Flat;
            bt_Cancel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Cancel.Location = new Point(109, 602);
            bt_Cancel.Margin = new Padding(4, 3, 4, 3);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(521, 63);
            bt_Cancel.TabIndex = 5;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += bt_Cancel_Click;
            // 
            // f_LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1422, 853);
            Controls.Add(pnLeft);
            Controls.Add(pnRight);
            Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "f_LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            pnRight.ResumeLayout(false);
            pnButtonContainer.ResumeLayout(false);
            pnWelcome.ResumeLayout(false);
            pnWelcomeText.ResumeLayout(false);
            pnWelcomeText.PerformLayout();
            pnWelcomeTitle.ResumeLayout(false);
            pnWelcomeTitle.PerformLayout();
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_Password;
        private Label lbl_Username;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private LinkLabel linklbl_Register;
        private Panel pnRight;
        private Label lblRegisterAnswer;
        private Panel pnWelcome;
        private Label lblWelcome;
        private Panel pnWelcomeTitle;
        private Panel pnWelcomeText;
        private Label lblWelcomeText;
        private LinkLabel linklbl_ForgotPassword;
        private CheckBox cb_isShowPassword;
        private CheckBox cb_RememberMe;
        private Label lbl_Title;
        private Button bt_Login;
        private Panel pnLeft;
        private BindingSource bindingSource1;
        private Label lblWelcomeText2;
        private Button bt_Cancel;
        private Button btnClose;
        private Panel pnButtonContainer;
        private Button btnMaximize;
        private Button btnMinimize;
    }
}
