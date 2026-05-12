using System.Xml.Linq;

namespace LoginForm
{
    public partial class RegisterForm
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
            cb_isShowPassword = new CheckBox();
            txt_Password = new TextBox();
            txt_UserName = new TextBox();
            bt_Register = new Button();
            bt_Cancel = new Button();
            lbl_Username = new Label();
            lbl_Password = new Label();
            txt_Email = new TextBox();
            lbl_Email = new Label();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.Maroon;
            lbl_Title.Location = new Point(354, 83);
            lbl_Title.Margin = new Padding(4, 0, 4, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(447, 54);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "ACCOUNT REGISTER";
            // 
            // cb_isShowPassword
            // 
            cb_isShowPassword.AutoSize = true;
            cb_isShowPassword.Font = new Font("Dubai", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_isShowPassword.Location = new Point(237, 539);
            cb_isShowPassword.Margin = new Padding(4, 3, 4, 3);
            cb_isShowPassword.Name = "cb_isShowPassword";
            cb_isShowPassword.Size = new Size(116, 26);
            cb_isShowPassword.TabIndex = 16;
            cb_isShowPassword.Text = "Show Password";
            cb_isShowPassword.UseVisualStyleBackColor = true;
            cb_isShowPassword.CheckedChanged += cb_isShowPassword_CheckedChanged;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(237, 486);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(705, 27);
            txt_Password.TabIndex = 15;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(237, 249);
            txt_UserName.Margin = new Padding(4, 3, 4, 3);
            txt_UserName.Multiline = true;
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(705, 61);
            txt_UserName.TabIndex = 14;
            // 
            // bt_Register
            // 
            bt_Register.BackColor = Color.Lime;
            bt_Register.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Register.Location = new Point(690, 594);
            bt_Register.Margin = new Padding(4, 3, 4, 3);
            bt_Register.Name = "bt_Register";
            bt_Register.Size = new Size(252, 58);
            bt_Register.TabIndex = 13;
            bt_Register.Text = "Register";
            bt_Register.UseVisualStyleBackColor = false;
            bt_Register.Click += bt_Register_Click;
            // 
            // bt_Cancel
            // 
            bt_Cancel.BackColor = Color.Red;
            bt_Cancel.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Cancel.Location = new Point(237, 594);
            bt_Cancel.Margin = new Padding(4, 3, 4, 3);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(252, 58);
            bt_Cancel.TabIndex = 12;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += bt_Cancel_Click;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(237, 197);
            lbl_Username.Margin = new Padding(4, 0, 4, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(181, 32);
            lbl_Username.TabIndex = 11;
            lbl_Username.Text = "USER NAME";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(237, 435);
            lbl_Password.Margin = new Padding(4, 0, 4, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(178, 32);
            lbl_Password.TabIndex = 10;
            lbl_Password.Text = "PASSWORD";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(237, 377);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(705, 27);
            txt_Email.TabIndex = 18;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Email.Location = new Point(237, 325);
            lbl_Email.Margin = new Padding(4, 0, 4, 0);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(147, 32);
            lbl_Email.TabIndex = 17;
            lbl_Email.Text = "Your Email";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 696);
            Controls.Add(txt_Email);
            Controls.Add(lbl_Email);
            Controls.Add(cb_isShowPassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(bt_Register);
            Controls.Add(bt_Cancel);
            Controls.Add(lbl_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Title);
            Name = "RegisterForm";
            Text = "Register Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Title;
        private CheckBox cb_isShowPassword;
        private TextBox txt_Password;
        private TextBox txt_UserName;
        private Button bt_Register;
        private Button bt_Cancel;
        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txt_Email;
        private Label lbl_Email;
    }
}
