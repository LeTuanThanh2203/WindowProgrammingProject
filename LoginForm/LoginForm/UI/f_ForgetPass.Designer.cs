namespace LoginForm
{
    partial class f_ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ForgetPass));
            pnLeft = new Panel();
            lbl_Title = new Label();
            lbl_Time = new Label();
            lbl_Password = new Label();
            txt_ReenterPass = new TextBox();
            lbl_Username = new Label();
            lbl_ReenterPass = new Label();

            bt_Cancel = new Button();
            bt_OTP = new Button();
            bt_ChangePassword = new Button();
            txt_OTP = new TextBox();
            txt_UserName = new TextBox();
            lbl_OTP = new Label();
            txt_Password = new TextBox();
            cb_isShowPassword = new CheckBox();
            pnRight = new Panel();
            panel2 = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnButtonContainer = new Panel();
            lbl_CheckUsername = new Label();
            lbl_CheckPassword = new Label();
            lbl_CheckReenterPass = new Label();
            pnLeft.SuspendLayout();
            pnRight.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnLeft
            // 
            pnLeft.Controls.Add(lbl_Title);
            pnLeft.Controls.Add(lbl_Time);
            pnLeft.Controls.Add(lbl_Password);
            pnLeft.Controls.Add(txt_ReenterPass);
            pnLeft.Controls.Add(lbl_Username);
            pnLeft.Controls.Add(lbl_ReenterPass);
            pnLeft.Controls.Add(bt_Cancel);
            pnLeft.Controls.Add(bt_OTP);
            pnLeft.Controls.Add(bt_ChangePassword);
            pnLeft.Controls.Add(txt_OTP);
            pnLeft.Controls.Add(txt_UserName);
            pnLeft.Controls.Add(lbl_OTP);
            pnLeft.Controls.Add(txt_Password);
            pnLeft.Controls.Add(cb_isShowPassword);
            pnLeft.Controls.Add(lbl_CheckUsername);
            pnLeft.Controls.Add(lbl_CheckPassword);
            pnLeft.Controls.Add(lbl_CheckReenterPass);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(799, 759);
            pnLeft.TabIndex = 34;
            pnLeft.MouseDown += pnlTop_MouseDown;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold);
            lbl_Title.ForeColor = Color.Black;
            lbl_Title.Location = new Point(190, 21);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(482, 81);
            lbl_Title.TabIndex = 19;
            lbl_Title.Text = "Forget Password";
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Time.Location = new Point(644, 364);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(0, 28);
            lbl_Time.TabIndex = 32;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 16.2F);
            lbl_Password.Location = new Point(73, 373);
            lbl_Password.Margin = new Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(132, 38);
            lbl_Password.TabIndex = 20;
            lbl_Password.Text = "Password";
            // 
            // txt_ReenterPass
            // 
            txt_ReenterPass.Location = new Point(73, 535);
            txt_ReenterPass.Margin = new Padding(4, 3, 4, 3);
            txt_ReenterPass.Name = "txt_ReenterPass";
            txt_ReenterPass.Size = new Size(705, 27);
            txt_ReenterPass.TabIndex = 31;
            txt_ReenterPass.UseSystemPasswordChar = true;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 16.2F);
            lbl_Username.Location = new Point(68, 146);
            lbl_Username.Margin = new Padding(4, 0, 4, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(142, 38);
            lbl_Username.TabIndex = 21;
            lbl_Username.Text = "Username";
            // 
            // lbl_ReenterPass
            // 
            lbl_ReenterPass.AutoSize = true;
            lbl_ReenterPass.Font = new Font("Segoe UI", 16.2F);
            lbl_ReenterPass.Location = new Point(73, 490);
            lbl_ReenterPass.Margin = new Padding(4, 0, 4, 0);
            lbl_ReenterPass.Name = "lbl_ReenterPass";
            lbl_ReenterPass.Size = new Size(239, 38);
            lbl_ReenterPass.TabIndex = 30;
            lbl_ReenterPass.Text = "Confirm Password";
            // 
            // bt_Cancel
            // 
            bt_Cancel.BackColor = Color.FromArgb(238, 0, 0);
            bt_Cancel.FlatAppearance.BorderColor = SystemColors.Control;
            bt_Cancel.FlatStyle = FlatStyle.Flat;
            bt_Cancel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt_Cancel.ForeColor = Color.White;
            bt_Cancel.Location = new Point(118, 645);
            bt_Cancel.Margin = new Padding(4, 3, 4, 3);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(252, 58);
            bt_Cancel.TabIndex = 22;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += bt_Cancel_Click;
            // 
            // bt_OTP
            // 
            bt_OTP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_OTP.Location = new Point(644, 312);
            bt_OTP.Name = "bt_OTP";
            bt_OTP.Size = new Size(126, 34);
            bt_OTP.TabIndex = 29;
            bt_OTP.Text = "Send";
            bt_OTP.UseVisualStyleBackColor = true;
            bt_OTP.Click += bt_OTP_Click;
            // 
            // bt_ChangePassword
            // 
            bt_ChangePassword.BackColor = Color.FromArgb(10, 61, 120);
            bt_ChangePassword.FlatAppearance.BorderColor = SystemColors.Control;
            bt_ChangePassword.FlatStyle = FlatStyle.Flat;
            bt_ChangePassword.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt_ChangePassword.ForeColor = Color.White;
            bt_ChangePassword.Location = new Point(420, 645);
            bt_ChangePassword.Margin = new Padding(4, 3, 4, 3);
            bt_ChangePassword.Name = "bt_ChangePassword";
            bt_ChangePassword.Size = new Size(252, 58);
            bt_ChangePassword.TabIndex = 23;
            bt_ChangePassword.Text = "Change";
            bt_ChangePassword.UseVisualStyleBackColor = false;
            bt_ChangePassword.Click += bt_ChangePassword_Click;
            // 
            // txt_OTP
            // 
            txt_OTP.Location = new Point(73, 315);
            txt_OTP.Margin = new Padding(4, 3, 4, 3);
            txt_OTP.Name = "txt_OTP";
            txt_OTP.Size = new Size(564, 27);
            txt_OTP.TabIndex = 28;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(73, 187);
            txt_UserName.Margin = new Padding(4, 3, 4, 3);
            txt_UserName.Multiline = true;
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(705, 40);
            txt_UserName.TabIndex = 24;
            // 
            // lbl_OTP
            // 
            lbl_OTP.AutoSize = true;
            lbl_OTP.Font = new Font("Segoe UI", 16.2F);
            lbl_OTP.Location = new Point(73, 263);
            lbl_OTP.Margin = new Padding(4, 0, 4, 0);
            lbl_OTP.Name = "lbl_OTP";
            lbl_OTP.Size = new Size(138, 38);
            lbl_OTP.TabIndex = 27;
            lbl_OTP.Text = "Send OTP";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(73, 424);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(705, 27);
            txt_Password.TabIndex = 25;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // cb_isShowPassword
            // 
            cb_isShowPassword.AutoSize = true;
            cb_isShowPassword.Font = new Font("Segoe UI", 10.2F);
            cb_isShowPassword.Location = new Point(73, 600);
            cb_isShowPassword.Margin = new Padding(4, 3, 4, 3);
            cb_isShowPassword.Name = "cb_isShowPassword";
            cb_isShowPassword.Size = new Size(148, 27);
            cb_isShowPassword.TabIndex = 26;
            cb_isShowPassword.Text = "Show Password";
            cb_isShowPassword.UseVisualStyleBackColor = true;
            cb_isShowPassword.CheckedChanged += cb_isShowPassword_CheckedChanged;
            // 
            // pnRight
            // 
            pnRight.BackColor = Color.DeepSkyBlue;
            pnRight.BackgroundImage = (Image)resources.GetObject("pnRight.BackgroundImage");
            pnRight.BackgroundImageLayout = ImageLayout.Stretch;
            pnRight.Controls.Add(panel2);
            pnRight.Controls.Add(pnButtonContainer);
            pnRight.Dock = DockStyle.Right;
            pnRight.Location = new Point(805, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(581, 759);
            pnRight.TabIndex = 35;
            pnRight.MouseDown += pnlTop_MouseDown;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnMaximize);
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(408, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(161, 50);
            panel2.TabIndex = 36;
            panel2.MouseDown += pnlTop_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(6, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 50);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(56, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(56, 50);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "❐";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(112, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 50);
            btnClose.TabIndex = 35;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnButtonContainer
            // 
            pnButtonContainer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnButtonContainer.BackColor = Color.Transparent;
            pnButtonContainer.Location = new Point(1364, 0);
            pnButtonContainer.Name = "pnButtonContainer";
            pnButtonContainer.Size = new Size(173, 42);
            pnButtonContainer.TabIndex = 14;
            // 
            // lbl_CheckUsername
            // 
            lbl_CheckUsername.AutoSize = true;
            lbl_CheckUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckUsername.ForeColor = Color.Gray;
            lbl_CheckUsername.Location = new Point(73, 230);
            lbl_CheckUsername.Name = "lbl_CheckUsername";
            lbl_CheckUsername.Size = new Size(0, 28);
            lbl_CheckUsername.TabIndex = 37;
            // 
            // lbl_CheckPassword
            // 
            lbl_CheckPassword.AutoSize = true;
            lbl_CheckPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckPassword.ForeColor = Color.Gray;
            lbl_CheckPassword.Location = new Point(73, 454);
            lbl_CheckPassword.Name = "lbl_CheckPassword";
            lbl_CheckPassword.Size = new Size(0, 28);
            lbl_CheckPassword.TabIndex = 38;
            // 
            // lbl_CheckReenterPass
            // 
            lbl_CheckReenterPass.AutoSize = true;
            lbl_CheckReenterPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CheckReenterPass.ForeColor = Color.Gray;
            lbl_CheckReenterPass.Location = new Point(73, 565);
            lbl_CheckReenterPass.Name = "lbl_CheckReenterPass";
            lbl_CheckReenterPass.Size = new Size(0, 28);
            lbl_CheckReenterPass.TabIndex = 39;
            //
            // f_ForgetPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 759);
            Controls.Add(pnRight);
            Controls.Add(pnLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "f_ForgetPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f_ForgetPass";
            Load += f_ForgetPass_Load;
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            pnRight.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnLeft;
        private Label lbl_Title;
        private Label lbl_Time;
        private Label lbl_Password;
        private TextBox txt_ReenterPass;
        private Label lbl_Username;
        private Label lbl_ReenterPass;
        private Button bt_Cancel;
        private Button bt_OTP;
        private Button bt_ChangePassword;
        private TextBox txt_OTP;
        private TextBox txt_UserName;
        private Label lbl_OTP;
        private TextBox txt_Password;
        private CheckBox cb_isShowPassword;
        private Panel pnRight;
        private Panel panel2;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Panel pnButtonContainer;
        private Label lbl_CheckUsername;
        private Label lbl_CheckPassword;
        private Label lbl_CheckReenterPass;
    }
}