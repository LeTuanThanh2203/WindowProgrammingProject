using System.Xml.Linq;

namespace LoginForm
{
    public partial class f_RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_RegisterForm));
            cb_isShowPassword = new CheckBox();
            txt_Password = new TextBox();
            txt_UserName = new TextBox();
            lbl_Username = new Label();
            lbl_Password = new Label();
            txt_Email = new TextBox();
            lbl_Email = new Label();
            bt_OTP = new Button();
            txt_OTP = new TextBox();
            lbl_OTP = new Label();
            lbl_Title = new Label();
            btn_Register = new Button();
            bt_Cancel = new Button();
            pnLeft = new Panel();
            lbl_Time = new Label();
            lbl_CheckEmail = new Label();
            lbl_CheckPassword = new Label();
            lbl_CheckUsername = new Label();
            pnOTP = new Panel();
            pnRight = new Panel();
            btnClose = new Button();
            pnButtonContainer = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnLeft.SuspendLayout();
            pnOTP.SuspendLayout();
            pnRight.SuspendLayout();
            pnButtonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // cb_isShowPassword
            // 
            cb_isShowPassword.AutoSize = true;
            cb_isShowPassword.Font = new Font("Segoe UI", 10.2F);
            cb_isShowPassword.Location = new Point(604, 570);
            cb_isShowPassword.Margin = new Padding(4, 3, 4, 3);
            cb_isShowPassword.Name = "cb_isShowPassword";
            cb_isShowPassword.Size = new Size(148, 27);
            cb_isShowPassword.TabIndex = 16;
            cb_isShowPassword.Text = "Show Password";
            cb_isShowPassword.UseVisualStyleBackColor = true;
            cb_isShowPassword.CheckedChanged += cb_isShowPassword_CheckedChanged;
            // 
            // txt_Password
            // 
            txt_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_Password.Location = new Point(47, 536);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(705, 27);
            txt_Password.TabIndex = 15;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            txt_UserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_UserName.Location = new Point(47, 187);
            txt_UserName.Margin = new Padding(4, 3, 4, 3);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(705, 27);
            txt_UserName.TabIndex = 14;
            // 
            // lbl_Username
            // 
            lbl_Username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 16.2F);
            lbl_Username.ForeColor = Color.Black;
            lbl_Username.Location = new Point(52, 146);
            lbl_Username.Margin = new Padding(4, 0, 4, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(142, 38);
            lbl_Username.TabIndex = 11;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 16.2F);
            lbl_Password.Location = new Point(52, 495);
            lbl_Password.Margin = new Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(132, 38);
            lbl_Password.TabIndex = 10;
            lbl_Password.Text = "Password";
            // 
            // txt_Email
            // 
            txt_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_Email.Location = new Point(47, 304);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(705, 27);
            txt_Email.TabIndex = 18;
            // 
            // lbl_Email
            // 
            lbl_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 16.2F);
            lbl_Email.Location = new Point(52, 263);
            lbl_Email.Margin = new Padding(4, 0, 4, 0);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(83, 38);
            lbl_Email.TabIndex = 17;
            lbl_Email.Text = "Email";
            // 
            // bt_OTP
            // 
            bt_OTP.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bt_OTP.Location = new Point(579, 0);
            bt_OTP.Name = "bt_OTP";
            bt_OTP.Size = new Size(126, 33);
            bt_OTP.TabIndex = 35;
            bt_OTP.Text = "Send";
            bt_OTP.UseVisualStyleBackColor = true;
            bt_OTP.Click += bt_OTP_Click;
            // 
            // txt_OTP
            // 
            txt_OTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txt_OTP.Location = new Point(0, 2);
            txt_OTP.Margin = new Padding(4, 3, 4, 3);
            txt_OTP.Name = "txt_OTP";
            txt_OTP.Size = new Size(564, 27);
            txt_OTP.TabIndex = 34;
            // 
            // lbl_OTP
            // 
            lbl_OTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_OTP.AutoSize = true;
            lbl_OTP.Font = new Font("Segoe UI", 16.2F);
            lbl_OTP.Location = new Point(52, 375);
            lbl_OTP.Margin = new Padding(4, 0, 4, 0);
            lbl_OTP.Name = "lbl_OTP";
            lbl_OTP.Size = new Size(138, 38);
            lbl_OTP.TabIndex = 33;
            lbl_OTP.Text = "Send OTP";
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.Black;
            lbl_Title.Location = new Point(311, 50);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(242, 81);
            lbl_Title.TabIndex = 37;
            lbl_Title.Text = "Sign up";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Register
            // 
            btn_Register.Anchor = AnchorStyles.Top;
            btn_Register.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Register.BackColor = Color.FromArgb(0, 68, 147);
            btn_Register.BackgroundImageLayout = ImageLayout.None;
            btn_Register.Cursor = Cursors.Hand;
            btn_Register.FlatAppearance.BorderSize = 0;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Register.ForeColor = Color.White;
            btn_Register.Location = new Point(451, 640);
            btn_Register.Margin = new Padding(4, 3, 4, 3);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(252, 58);
            btn_Register.TabIndex = 38;
            btn_Register.Text = "Sign up";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += bt_Register_Click;
            // 
            // bt_Cancel
            // 
            bt_Cancel.Anchor = AnchorStyles.Top;
            bt_Cancel.AutoSize = true;
            bt_Cancel.BackColor = Color.FromArgb(238, 0, 0);
            bt_Cancel.Cursor = Cursors.Hand;
            bt_Cancel.FlatStyle = FlatStyle.Flat;
            bt_Cancel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Cancel.ForeColor = Color.White;
            bt_Cancel.Location = new Point(153, 640);
            bt_Cancel.Margin = new Padding(4, 3, 4, 3);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(252, 58);
            bt_Cancel.TabIndex = 39;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += bt_Cancel_Click;
            // 
            // pnLeft
            // 
            pnLeft.Controls.Add(lbl_Time);
            pnLeft.Controls.Add(lbl_CheckEmail);
            pnLeft.Controls.Add(bt_Cancel);
            pnLeft.Controls.Add(lbl_CheckPassword);
            pnLeft.Controls.Add(btn_Register);
            pnLeft.Controls.Add(lbl_CheckUsername);
            pnLeft.Controls.Add(pnOTP);
            pnLeft.Controls.Add(lbl_Title);
            pnLeft.Controls.Add(txt_Email);
            pnLeft.Controls.Add(lbl_Username);
            pnLeft.Controls.Add(cb_isShowPassword);
            pnLeft.Controls.Add(lbl_OTP);
            pnLeft.Controls.Add(txt_Password);
            pnLeft.Controls.Add(lbl_Password);
            pnLeft.Controls.Add(txt_UserName);
            pnLeft.Controls.Add(lbl_Email);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(901, 817);
            pnLeft.TabIndex = 40;
            pnLeft.MouseDown += pnlTop_MouseDown;
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Time.Location = new Point(488, 452);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(0, 28);
            lbl_Time.TabIndex = 43;
            // 
            // lbl_CheckEmail
            // 
            lbl_CheckEmail.AutoSize = true;
            lbl_CheckEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckEmail.Location = new Point(52, 332);
            lbl_CheckEmail.Name = "lbl_CheckEmail";
            lbl_CheckEmail.Size = new Size(0, 28);
            lbl_CheckEmail.TabIndex = 42;
            // 
            // lbl_CheckPassword
            // 
            lbl_CheckPassword.AutoSize = true;
            lbl_CheckPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckPassword.Location = new Point(52, 566);
            lbl_CheckPassword.Name = "lbl_CheckPassword";
            lbl_CheckPassword.Size = new Size(0, 28);
            lbl_CheckPassword.TabIndex = 41;
            // 
            // lbl_CheckUsername
            // 
            lbl_CheckUsername.AutoSize = true;
            lbl_CheckUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckUsername.Location = new Point(52, 217);
            lbl_CheckUsername.Name = "lbl_CheckUsername";
            lbl_CheckUsername.Size = new Size(0, 28);
            lbl_CheckUsername.TabIndex = 39;
            // 
            // pnOTP
            // 
            pnOTP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnOTP.Controls.Add(txt_OTP);
            pnOTP.Controls.Add(bt_OTP);
            pnOTP.Location = new Point(47, 416);
            pnOTP.Name = "pnOTP";
            pnOTP.Size = new Size(705, 33);
            pnOTP.TabIndex = 38;
            // 
            // pnRight
            // 
            pnRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnRight.BackgroundImage = (Image)resources.GetObject("pnRight.BackgroundImage");
            pnRight.BackgroundImageLayout = ImageLayout.Stretch;
            pnRight.Controls.Add(btnClose);
            pnRight.Controls.Add(pnButtonContainer);
            pnRight.Location = new Point(907, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(610, 817);
            pnRight.TabIndex = 41;
            pnRight.MouseDown += pnlTop_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(558, 3);
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
            pnButtonContainer.Location = new Point(419, 0);
            pnButtonContainer.Name = "pnButtonContainer";
            pnButtonContainer.Size = new Size(191, 45);
            pnButtonContainer.TabIndex = 16;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(74, 0);
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
            btnMinimize.Location = new Point(9, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 39);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // f_RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 817);
            Controls.Add(pnRight);
            Controls.Add(pnLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "f_RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            Load += f_Register_Load;
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            pnOTP.ResumeLayout(false);
            pnOTP.PerformLayout();
            pnRight.ResumeLayout(false);
            pnButtonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CheckBox cb_isShowPassword;
        private TextBox txt_Password;
        private TextBox txt_UserName;
        private Button bt_Register;
        private Button bt_Cancel;
        private Button btn_Register;
        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txt_Email;
        private Label lbl_Email;
        private Button bt_OTP;
        private TextBox txt_OTP;
        private Label lbl_OTP;
        private Label lbl_Title;
        private Panel pnLeft;
        private Panel pnRight;
        private Button btnClose;
        private Panel pnButtonContainer;
        private Button btnMaximize;
        private Button btnMinimize;
        private Panel pnOTP;
        private Label lbl_CheckUsername;
        private Label lbl_CheckEmail;
        private Label lbl_CheckPassword;
        private Label lbl_Time;
    }
}
