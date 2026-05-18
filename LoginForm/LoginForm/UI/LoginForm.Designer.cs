namespace LoginForm
{
    public partial class LoginForm
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
            lbl_Title = new Label();
            lbl_Password = new Label();
            lbl_Username = new Label();
            bt_Cancel = new Button();
            bt_Login = new Button();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            cb_isShowPassword = new CheckBox();
            linklbl_Register = new LinkLabel();
            cb_RememberMe = new CheckBox();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.Maroon;
            lbl_Title.Location = new Point(353, 85);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(367, 54);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "ACCOUNT LOGIN";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(111, 337);
            lbl_Password.Margin = new Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(178, 32);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "PASSWORD";
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(111, 211);
            lbl_Username.Margin = new Padding(4, 0, 4, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(173, 32);
            lbl_Username.TabIndex = 4;
            lbl_Username.Text = "USERNAME";
            // 
            // bt_Cancel
            // 
            bt_Cancel.BackColor = Color.Red;
            bt_Cancel.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Cancel.Location = new Point(353, 460);
            bt_Cancel.Margin = new Padding(4, 3, 4, 3);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(252, 58);
            bt_Cancel.TabIndex = 5;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += bt_Cancel_Click;
            // 
            // bt_Login
            // 
            bt_Login.BackColor = Color.Lime;
            bt_Login.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Login.Location = new Point(808, 460);
            bt_Login.Margin = new Padding(4, 3, 4, 3);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(252, 58);
            bt_Login.TabIndex = 6;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = false;
            bt_Login.Click += bt_Login_Click;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(353, 210);
            txt_UserName.Margin = new Padding(4, 3, 4, 3);
            txt_UserName.Multiline = true;
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(705, 61);
            txt_UserName.TabIndex = 7;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(353, 337);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(705, 28);
            txt_Password.TabIndex = 8;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // cb_isShowPassword
            // 
            cb_isShowPassword.AutoSize = true;
            cb_isShowPassword.Font = new Font("Dubai", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_isShowPassword.Location = new Point(353, 389);
            cb_isShowPassword.Margin = new Padding(4, 3, 4, 3);
            cb_isShowPassword.Name = "cb_isShowPassword";
            cb_isShowPassword.Size = new Size(116, 26);
            cb_isShowPassword.TabIndex = 9;
            cb_isShowPassword.Text = "Show Password";
            cb_isShowPassword.UseVisualStyleBackColor = true;
            cb_isShowPassword.CheckedChanged += cb_isShowPassword_CheckedChanged;
            // 
            // linklbl_Register
            // 
            linklbl_Register.AutoSize = true;
            linklbl_Register.Font = new Font("Microsoft PhagsPa", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linklbl_Register.Location = new Point(111, 592);
            linklbl_Register.Margin = new Padding(4, 0, 4, 0);
            linklbl_Register.Name = "linklbl_Register";
            linklbl_Register.Size = new Size(141, 44);
            linklbl_Register.TabIndex = 10;
            linklbl_Register.TabStop = true;
            linklbl_Register.Text = "Register";
            linklbl_Register.LinkClicked += linklbl_Register_LinkClicked;
            // 
            // cb_RememberMe
            // 
            cb_RememberMe.AutoSize = true;
            cb_RememberMe.Font = new Font("Dubai", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_RememberMe.Location = new Point(942, 389);
            cb_RememberMe.Margin = new Padding(4, 3, 4, 3);
            cb_RememberMe.Name = "cb_RememberMe";
            cb_RememberMe.Size = new Size(110, 26);
            cb_RememberMe.TabIndex = 11;
            cb_RememberMe.Text = "Remember Me";
            cb_RememberMe.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 696);
            Controls.Add(cb_RememberMe);
            Controls.Add(linklbl_Register);
            Controls.Add(cb_isShowPassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(bt_Login);
            Controls.Add(bt_Cancel);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Title);
            Font = new Font("Lucida Calligraphy", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Label lbl_Password;
        private Label lbl_Username;
        private Button bt_Cancel;
        private Button bt_Login;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private CheckBox cb_isShowPassword;
        private LinkLabel linklbl_Register;
        private CheckBox cb_RememberMe;
    }
}
