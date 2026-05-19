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
            txt_OTP = new TextBox();
            lbl_OTP = new Label();
            cb_isShowPassword = new CheckBox();
            txt_Password = new TextBox();
            txt_UserName = new TextBox();
            bt_ChangePassword = new Button();
            bt_Cancel = new Button();
            lbl_Username = new Label();
            lbl_Password = new Label();
            lbl_Title = new Label();
            bt_OTP = new Button();
            txt_ReenterPass = new TextBox();
            lbl_ReenterPass = new Label();
            lbl_Time = new Label();
            SuspendLayout();
            // 
            // txt_OTP
            // 
            txt_OTP.Location = new Point(116, 352);
            txt_OTP.Margin = new Padding(4, 3, 4, 3);
            txt_OTP.Name = "txt_OTP";
            txt_OTP.Size = new Size(564, 27);
            txt_OTP.TabIndex = 28;
            // 
            // lbl_OTP
            // 
            lbl_OTP.AutoSize = true;
            lbl_OTP.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_OTP.Location = new Point(116, 300);
            lbl_OTP.Margin = new Padding(4, 0, 4, 0);
            lbl_OTP.Name = "lbl_OTP";
            lbl_OTP.Size = new Size(157, 32);
            lbl_OTP.TabIndex = 27;
            lbl_OTP.Text = "SEND OTP";
            // 
            // cb_isShowPassword
            // 
            cb_isShowPassword.AutoSize = true;
            cb_isShowPassword.Font = new Font("Dubai", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_isShowPassword.Location = new Point(116, 619);
            cb_isShowPassword.Margin = new Padding(4, 3, 4, 3);
            cb_isShowPassword.Name = "cb_isShowPassword";
            cb_isShowPassword.Size = new Size(116, 26);
            cb_isShowPassword.TabIndex = 26;
            cb_isShowPassword.Text = "Show Password";
            cb_isShowPassword.UseVisualStyleBackColor = true;
            cb_isShowPassword.CheckedChanged += cb_isShowPassword_CheckedChanged;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(116, 461);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(705, 27);
            txt_Password.TabIndex = 25;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(116, 224);
            txt_UserName.Margin = new Padding(4, 3, 4, 3);
            txt_UserName.Multiline = true;
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(705, 40);
            txt_UserName.TabIndex = 24;
            // 
            // bt_ChangePassword
            // 
            bt_ChangePassword.BackColor = Color.Lime;
            bt_ChangePassword.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_ChangePassword.Location = new Point(569, 676);
            bt_ChangePassword.Margin = new Padding(4, 3, 4, 3);
            bt_ChangePassword.Name = "bt_ChangePassword";
            bt_ChangePassword.Size = new Size(252, 58);
            bt_ChangePassword.TabIndex = 23;
            bt_ChangePassword.Text = "Change";
            bt_ChangePassword.UseVisualStyleBackColor = false;
            bt_ChangePassword.Click += bt_ChangePassword_Click;
            // 
            // bt_Cancel
            // 
            bt_Cancel.BackColor = Color.Red;
            bt_Cancel.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Cancel.Location = new Point(116, 676);
            bt_Cancel.Margin = new Padding(4, 3, 4, 3);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(252, 58);
            bt_Cancel.TabIndex = 22;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += bt_Cancel_Click;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(116, 172);
            lbl_Username.Margin = new Padding(4, 0, 4, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(181, 32);
            lbl_Username.TabIndex = 21;
            lbl_Username.Text = "USER NAME";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(116, 410);
            lbl_Password.Margin = new Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(178, 32);
            lbl_Password.TabIndex = 20;
            lbl_Password.Text = "PASSWORD";
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.Maroon;
            lbl_Title.Location = new Point(233, 58);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(447, 54);
            lbl_Title.TabIndex = 19;
            lbl_Title.Text = "ACCOUNT REGISTER";
            // 
            // bt_OTP
            // 
            bt_OTP.Location = new Point(695, 352);
            bt_OTP.Name = "bt_OTP";
            bt_OTP.Size = new Size(126, 27);
            bt_OTP.TabIndex = 29;
            bt_OTP.Text = "Send";
            bt_OTP.UseVisualStyleBackColor = true;
            bt_OTP.Click += bt_OTP_Click;
            // 
            // txt_ReenterPass
            // 
            txt_ReenterPass.Location = new Point(116, 566);
            txt_ReenterPass.Margin = new Padding(4, 3, 4, 3);
            txt_ReenterPass.Name = "txt_ReenterPass";
            txt_ReenterPass.Size = new Size(705, 27);
            txt_ReenterPass.TabIndex = 31;
            txt_ReenterPass.UseSystemPasswordChar = true;
            // 
            // lbl_ReenterPass
            // 
            lbl_ReenterPass.AutoSize = true;
            lbl_ReenterPass.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ReenterPass.Location = new Point(116, 515);
            lbl_ReenterPass.Margin = new Padding(4, 0, 4, 0);
            lbl_ReenterPass.Name = "lbl_ReenterPass";
            lbl_ReenterPass.Size = new Size(319, 32);
            lbl_ReenterPass.TabIndex = 30;
            lbl_ReenterPass.Text = "REENTER PASSWORD";
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Location = new Point(626, 329);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(0, 20);
            lbl_Time.TabIndex = 32;
            // 
            // f_ForgetPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 773);
            Controls.Add(lbl_Time);
            Controls.Add(txt_ReenterPass);
            Controls.Add(lbl_ReenterPass);
            Controls.Add(bt_OTP);
            Controls.Add(txt_OTP);
            Controls.Add(lbl_OTP);
            Controls.Add(cb_isShowPassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(bt_ChangePassword);
            Controls.Add(bt_Cancel);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Title);
            Name = "f_ForgetPass";
            Text = "f_ForgetPass";
            Load += f_ForgetPass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_OTP;
        private Label lbl_OTP;
        private CheckBox cb_isShowPassword;
        private TextBox txt_Password;
        private TextBox txt_UserName;
        private Button bt_ChangePassword;
        private Button bt_Cancel;
        private Label lbl_Username;
        private Label lbl_Password;
        private Label lbl_Title;
        private Button bt_OTP;
        private TextBox txt_ReenterPass;
        private Label lbl_ReenterPass;
        private Label lbl_Time;
    }
}