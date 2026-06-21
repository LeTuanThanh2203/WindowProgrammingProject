using System.Xml.Linq;

namespace LoginForm
{
    public partial class f_RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_RegisterForm));
            lbl_Title = new Label();
            lbl_SectionAccount = new Label();
            lbl_SectionProfile = new Label();
            pnStep1 = new Panel();
            lbl_Step1 = new Label();
            pnStep2 = new Panel();
            lbl_Step2 = new Label();
            pnStep3 = new Panel();
            lbl_Step3 = new Label();
            lbl_StepLbl1 = new Label();
            lbl_StepLbl2 = new Label();
            lbl_StepLbl3 = new Label();
            pnLine1 = new Panel();
            pnLine2 = new Panel();
            lbl_Username = new Label();
            txt_UserName = new TextBox();
            lbl_CheckUsername = new Label();
            lbl_Role = new Label();
            cbo_Role = new ComboBox();
            lbl_Password = new Label();
            txt_Password = new TextBox();
            pnStrengthBar = new Panel();
            pnStrengthFill = new Panel();
            lbl_CheckPassword = new Label();
            cb_isShowPassword = new CheckBox();
            lbl_Email = new Label();
            txt_Email = new TextBox();
            lbl_CheckEmail = new Label();
            lbl_OTP = new Label();
            pnOTP = new Panel();
            txt_OTP = new TextBox();
            bt_OTP = new Button();
            lbl_Time = new Label();
            pnDivider = new Panel();
            lbl_FirstName = new Label();
            txt_FirstName = new TextBox();
            lbl_CheckFirstName = new Label();   // THÊM MỚI
            lbl_LastName = new Label();
            txt_LastName = new TextBox();
            lbl_CheckLastName = new Label();    // THÊM MỚI
            lbl_Gender = new Label();
            cbo_Gender = new ComboBox();
            lbl_Photo = new Label();
            pic_Image = new PictureBox();
            btn_ChooseImage = new Button();
            lbl_PhotoHint = new Label();
            bt_Cancel = new Button();
            btn_Register = new Button();
            pnLeft = new Panel();
            pnRight = new Panel();
            btnClose = new Button();
            pnButtonContainer = new Panel();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnStep1.SuspendLayout();
            pnStep2.SuspendLayout();
            pnStep3.SuspendLayout();
            pnStrengthBar.SuspendLayout();
            pnOTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Image).BeginInit();
            pnLeft.SuspendLayout();
            pnRight.SuspendLayout();
            pnButtonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lbl_Title.ForeColor = Color.FromArgb(26, 26, 46);
            lbl_Title.Location = new Point(306, 14);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(164, 54);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Sign up";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SectionAccount
            // 
            lbl_SectionAccount.AutoSize = true;
            lbl_SectionAccount.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lbl_SectionAccount.ForeColor = Color.FromArgb(138, 146, 160);
            lbl_SectionAccount.Location = new Point(50, 148);
            lbl_SectionAccount.Name = "lbl_SectionAccount";
            lbl_SectionAccount.Size = new Size(114, 19);
            lbl_SectionAccount.TabIndex = 6;
            lbl_SectionAccount.Text = "ACCOUNT INFO";
            // 
            // lbl_SectionProfile
            // 
            lbl_SectionProfile.AutoSize = true;
            lbl_SectionProfile.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lbl_SectionProfile.ForeColor = Color.FromArgb(138, 146, 160);
            lbl_SectionProfile.Location = new Point(50, 545);
            lbl_SectionProfile.Name = "lbl_SectionProfile";
            lbl_SectionProfile.Size = new Size(63, 19);
            lbl_SectionProfile.TabIndex = 7;
            lbl_SectionProfile.Text = "PROFILE";
            // 
            // pnStep1
            // 
            pnStep1.BackColor = Color.FromArgb(0, 68, 147);
            pnStep1.Controls.Add(lbl_Step1);
            pnStep1.Location = new Point(256, 88);
            pnStep1.Name = "pnStep1";
            pnStep1.Size = new Size(32, 32);
            pnStep1.TabIndex = 0;
            // 
            // lbl_Step1
            // 
            lbl_Step1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Step1.ForeColor = Color.White;
            lbl_Step1.Location = new Point(0, 0);
            lbl_Step1.Name = "lbl_Step1";
            lbl_Step1.Size = new Size(32, 32);
            lbl_Step1.TabIndex = 0;
            lbl_Step1.Text = "✓";
            lbl_Step1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnStep2
            // 
            pnStep2.BackColor = Color.FromArgb(0, 68, 147);
            pnStep2.Controls.Add(lbl_Step2);
            pnStep2.Location = new Point(368, 88);
            pnStep2.Name = "pnStep2";
            pnStep2.Size = new Size(32, 32);
            pnStep2.TabIndex = 0;
            // 
            // lbl_Step2
            // 
            lbl_Step2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Step2.ForeColor = Color.White;
            lbl_Step2.Location = new Point(0, 0);
            lbl_Step2.Name = "lbl_Step2";
            lbl_Step2.Size = new Size(32, 32);
            lbl_Step2.TabIndex = 0;
            lbl_Step2.Text = "2";
            lbl_Step2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnStep3
            // 
            pnStep3.BackColor = Color.FromArgb(220, 220, 220);
            pnStep3.Controls.Add(lbl_Step3);
            pnStep3.Location = new Point(480, 88);
            pnStep3.Name = "pnStep3";
            pnStep3.Size = new Size(32, 32);
            pnStep3.TabIndex = 0;
            // 
            // lbl_Step3
            // 
            lbl_Step3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_Step3.ForeColor = Color.FromArgb(150, 150, 150);
            lbl_Step3.Location = new Point(0, 0);
            lbl_Step3.Name = "lbl_Step3";
            lbl_Step3.Size = new Size(32, 32);
            lbl_Step3.TabIndex = 0;
            lbl_Step3.Text = "3";
            lbl_Step3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_StepLbl1
            // 
            lbl_StepLbl1.AutoSize = true;
            lbl_StepLbl1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lbl_StepLbl1.ForeColor = Color.FromArgb(0, 68, 147);
            lbl_StepLbl1.Location = new Point(252, 126);
            lbl_StepLbl1.Name = "lbl_StepLbl1";
            lbl_StepLbl1.Size = new Size(63, 19);
            lbl_StepLbl1.TabIndex = 3;
            lbl_StepLbl1.Text = "Account";
            // 
            // lbl_StepLbl2
            // 
            lbl_StepLbl2.AutoSize = true;
            lbl_StepLbl2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lbl_StepLbl2.ForeColor = Color.FromArgb(0, 68, 147);
            lbl_StepLbl2.Location = new Point(366, 126);
            lbl_StepLbl2.Name = "lbl_StepLbl2";
            lbl_StepLbl2.Size = new Size(54, 19);
            lbl_StepLbl2.TabIndex = 4;
            lbl_StepLbl2.Text = "Profile";
            // 
            // lbl_StepLbl3
            // 
            lbl_StepLbl3.AutoSize = true;
            lbl_StepLbl3.Font = new Font("Segoe UI", 8F);
            lbl_StepLbl3.ForeColor = Color.FromArgb(160, 160, 160);
            lbl_StepLbl3.Location = new Point(482, 126);
            lbl_StepLbl3.Name = "lbl_StepLbl3";
            lbl_StepLbl3.Size = new Size(42, 19);
            lbl_StepLbl3.TabIndex = 5;
            lbl_StepLbl3.Text = "Done";
            // 
            // pnLine1
            // 
            pnLine1.BackColor = Color.FromArgb(0, 68, 147);
            pnLine1.Location = new Point(288, 102);
            pnLine1.Name = "pnLine1";
            pnLine1.Size = new Size(80, 2);
            pnLine1.TabIndex = 1;
            // 
            // pnLine2
            // 
            pnLine2.BackColor = Color.FromArgb(210, 215, 220);
            pnLine2.Location = new Point(400, 102);
            pnLine2.Name = "pnLine2";
            pnLine2.Size = new Size(80, 2);
            pnLine2.TabIndex = 2;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_Username.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_Username.Location = new Point(50, 174);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(87, 21);
            lbl_Username.TabIndex = 8;
            lbl_Username.Text = "Username";
            // 
            // txt_UserName
            // 
            txt_UserName.BackColor = Color.White;
            txt_UserName.BorderStyle = BorderStyle.FixedSingle;
            txt_UserName.Font = new Font("Segoe UI", 10F);
            txt_UserName.Location = new Point(50, 196);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(360, 30);
            txt_UserName.TabIndex = 1;
            // 
            // lbl_CheckUsername
            // 
            lbl_CheckUsername.AutoSize = true;
            lbl_CheckUsername.Font = new Font("Segoe UI", 8.5F);
            lbl_CheckUsername.Location = new Point(50, 228);
            lbl_CheckUsername.Name = "lbl_CheckUsername";
            lbl_CheckUsername.Size = new Size(0, 20);
            lbl_CheckUsername.TabIndex = 99;
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_Role.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_Role.Location = new Point(430, 174);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new Size(106, 21);
            lbl_Role.TabIndex = 100;
            lbl_Role.Text = "Desired Role";
            // 
            // cbo_Role
            // 
            cbo_Role.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Role.FlatStyle = FlatStyle.Flat;
            cbo_Role.Font = new Font("Segoe UI", 10F);
            cbo_Role.Location = new Point(430, 196);
            cbo_Role.Name = "cbo_Role";
            cbo_Role.Size = new Size(230, 31);
            cbo_Role.TabIndex = 2;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_Password.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_Password.Location = new Point(50, 252);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(82, 21);
            lbl_Password.TabIndex = 101;
            lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.White;
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Font = new Font("Segoe UI", 10F);
            txt_Password.Location = new Point(50, 274);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(610, 30);
            txt_Password.TabIndex = 3;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // pnStrengthBar
            // 
            pnStrengthBar.BackColor = Color.FromArgb(224, 227, 232);
            pnStrengthBar.Controls.Add(pnStrengthFill);
            pnStrengthBar.Location = new Point(50, 306);
            pnStrengthBar.Name = "pnStrengthBar";
            pnStrengthBar.Size = new Size(610, 4);
            pnStrengthBar.TabIndex = 99;
            // 
            // pnStrengthFill
            // 
            pnStrengthFill.BackColor = Color.Gray;
            pnStrengthFill.Location = new Point(0, 0);
            pnStrengthFill.Name = "pnStrengthFill";
            pnStrengthFill.Size = new Size(0, 4);
            pnStrengthFill.TabIndex = 99;
            // 
            // lbl_CheckPassword
            // 
            lbl_CheckPassword.AutoSize = true;
            lbl_CheckPassword.Font = new Font("Segoe UI", 8.5F);
            lbl_CheckPassword.Location = new Point(50, 312);
            lbl_CheckPassword.Name = "lbl_CheckPassword";
            lbl_CheckPassword.Size = new Size(0, 20);
            lbl_CheckPassword.TabIndex = 99;
            // 
            // cb_isShowPassword
            // 
            cb_isShowPassword.AutoSize = true;
            cb_isShowPassword.Font = new Font("Segoe UI", 9F);
            cb_isShowPassword.ForeColor = Color.FromArgb(100, 108, 120);
            cb_isShowPassword.Location = new Point(50, 334);
            cb_isShowPassword.Name = "cb_isShowPassword";
            cb_isShowPassword.Size = new Size(132, 24);
            cb_isShowPassword.TabIndex = 4;
            cb_isShowPassword.Text = "Show Password";
            cb_isShowPassword.UseVisualStyleBackColor = true;
            cb_isShowPassword.CheckedChanged += cb_isShowPassword_CheckedChanged;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_Email.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_Email.Location = new Point(50, 368);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(53, 21);
            lbl_Email.TabIndex = 102;
            lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.White;
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("Segoe UI", 10F);
            txt_Email.Location = new Point(50, 390);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(610, 30);
            txt_Email.TabIndex = 5;
            // 
            // lbl_CheckEmail
            // 
            lbl_CheckEmail.AutoSize = true;
            lbl_CheckEmail.Font = new Font("Segoe UI", 8.5F);
            lbl_CheckEmail.Location = new Point(50, 422);
            lbl_CheckEmail.Name = "lbl_CheckEmail";
            lbl_CheckEmail.Size = new Size(0, 20);
            lbl_CheckEmail.TabIndex = 99;
            // 
            // lbl_OTP
            // 
            lbl_OTP.AutoSize = true;
            lbl_OTP.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_OTP.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_OTP.Location = new Point(50, 446);
            lbl_OTP.Name = "lbl_OTP";
            lbl_OTP.Size = new Size(83, 21);
            lbl_OTP.TabIndex = 103;
            lbl_OTP.Text = "OTP Code";
            // 
            // pnOTP
            // 
            pnOTP.Controls.Add(txt_OTP);
            pnOTP.Controls.Add(bt_OTP);
            pnOTP.Location = new Point(50, 468);
            pnOTP.Name = "pnOTP";
            pnOTP.Size = new Size(610, 40);
            pnOTP.TabIndex = 99;
            // 
            // txt_OTP
            // 
            txt_OTP.BackColor = Color.White;
            txt_OTP.BorderStyle = BorderStyle.FixedSingle;
            txt_OTP.Font = new Font("Segoe UI", 11F);
            txt_OTP.Location = new Point(2, 2);
            txt_OTP.Name = "txt_OTP";
            txt_OTP.Size = new Size(460, 32);
            txt_OTP.TabIndex = 6;
            txt_OTP.TextAlign = HorizontalAlignment.Center;
            // 
            // bt_OTP
            // 
            bt_OTP.BackColor = Color.FromArgb(0, 68, 147);
            bt_OTP.Cursor = Cursors.Hand;
            bt_OTP.FlatAppearance.BorderSize = 0;
            bt_OTP.FlatStyle = FlatStyle.Flat;
            bt_OTP.Font = new Font("Segoe UI Semibold", 9.5F);
            bt_OTP.ForeColor = Color.White;
            bt_OTP.Location = new Point(470, 0);
            bt_OTP.Name = "bt_OTP";
            bt_OTP.Size = new Size(140, 33);
            bt_OTP.TabIndex = 7;
            bt_OTP.Text = "⊳  Send OTP";
            bt_OTP.UseVisualStyleBackColor = false;
            bt_OTP.Click += bt_OTP_Click;
            // 
            // lbl_Time
            // 
            lbl_Time.AutoSize = true;
            lbl_Time.Font = new Font("Segoe UI", 8.5F);
            lbl_Time.ForeColor = Color.FromArgb(120, 128, 140);
            lbl_Time.Location = new Point(50, 504);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(0, 20);
            lbl_Time.TabIndex = 99;
            // 
            // pnDivider
            // 
            pnDivider.BackColor = Color.FromArgb(220, 224, 230);
            pnDivider.Location = new Point(50, 530);
            pnDivider.Name = "pnDivider";
            pnDivider.Size = new Size(820, 1);
            pnDivider.TabIndex = 99;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_FirstName.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_FirstName.Location = new Point(50, 572);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(92, 21);
            lbl_FirstName.TabIndex = 104;
            lbl_FirstName.Text = "First Name";
            // 
            // txt_FirstName
            // 
            txt_FirstName.BackColor = Color.White;
            txt_FirstName.BorderStyle = BorderStyle.FixedSingle;
            txt_FirstName.Font = new Font("Segoe UI", 10F);
            txt_FirstName.Location = new Point(50, 594);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(290, 30);
            txt_FirstName.TabIndex = 8;
            // 
            // lbl_CheckFirstName  ← THÊM MỚI
            // 
            lbl_CheckFirstName.AutoSize = true;
            lbl_CheckFirstName.Font = new Font("Segoe UI", 8.5F);
            lbl_CheckFirstName.Location = new Point(50, 626);
            lbl_CheckFirstName.Name = "lbl_CheckFirstName";
            lbl_CheckFirstName.Size = new Size(0, 20);
            lbl_CheckFirstName.TabIndex = 99;
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_LastName.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_LastName.Location = new Point(360, 572);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(90, 21);
            lbl_LastName.TabIndex = 105;
            lbl_LastName.Text = "Last Name";
            // 
            // txt_LastName
            // 
            txt_LastName.BackColor = Color.White;
            txt_LastName.BorderStyle = BorderStyle.FixedSingle;
            txt_LastName.Font = new Font("Segoe UI", 10F);
            txt_LastName.Location = new Point(360, 594);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(300, 30);
            txt_LastName.TabIndex = 9;
            // 
            // lbl_CheckLastName  ← THÊM MỚI
            // 
            lbl_CheckLastName.AutoSize = true;
            lbl_CheckLastName.Font = new Font("Segoe UI", 8.5F);
            lbl_CheckLastName.Location = new Point(360, 626);
            lbl_CheckLastName.Name = "lbl_CheckLastName";
            lbl_CheckLastName.Size = new Size(0, 20);
            lbl_CheckLastName.TabIndex = 99;
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_Gender.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_Gender.Location = new Point(50, 656);   // dịch xuống 14px để nhường chỗ cho lbl_Check
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(65, 21);
            lbl_Gender.TabIndex = 106;
            lbl_Gender.Text = "Gender";
            // 
            // cbo_Gender
            // 
            cbo_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Gender.FlatStyle = FlatStyle.Flat;
            cbo_Gender.Font = new Font("Segoe UI", 10F);
            cbo_Gender.Location = new Point(50, 678);   // dịch xuống tương ứng
            cbo_Gender.Name = "cbo_Gender";
            cbo_Gender.Size = new Size(200, 31);
            cbo_Gender.TabIndex = 10;
            // 
            // lbl_Photo
            // 
            lbl_Photo.AutoSize = true;
            lbl_Photo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lbl_Photo.ForeColor = Color.FromArgb(70, 78, 92);
            lbl_Photo.Location = new Point(360, 656);
            lbl_Photo.Name = "lbl_Photo";
            lbl_Photo.Size = new Size(111, 21);
            lbl_Photo.TabIndex = 107;
            lbl_Photo.Text = "Profile Photo";
            // 
            // pic_Image
            // 
            pic_Image.BackColor = Color.FromArgb(235, 240, 248);
            pic_Image.BorderStyle = BorderStyle.FixedSingle;
            pic_Image.Location = new Point(360, 678);
            pic_Image.Name = "pic_Image";
            pic_Image.Size = new Size(70, 70);
            pic_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Image.TabIndex = 99;
            pic_Image.TabStop = false;
            // 
            // btn_ChooseImage
            // 
            btn_ChooseImage.BackColor = Color.FromArgb(240, 243, 248);
            btn_ChooseImage.Cursor = Cursors.Hand;
            btn_ChooseImage.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btn_ChooseImage.FlatStyle = FlatStyle.Flat;
            btn_ChooseImage.Font = new Font("Segoe UI Semibold", 9F);
            btn_ChooseImage.ForeColor = Color.FromArgb(60, 70, 85);
            btn_ChooseImage.Location = new Point(442, 678);
            btn_ChooseImage.Name = "btn_ChooseImage";
            btn_ChooseImage.Size = new Size(160, 32);
            btn_ChooseImage.TabIndex = 11;
            btn_ChooseImage.Text = "⇪  Choose Photo";
            btn_ChooseImage.UseVisualStyleBackColor = false;
            btn_ChooseImage.Click += btn_ChooseImage_Click;
            // 
            // lbl_PhotoHint
            // 
            lbl_PhotoHint.AutoSize = true;
            lbl_PhotoHint.Font = new Font("Segoe UI", 8F);
            lbl_PhotoHint.ForeColor = Color.FromArgb(160, 160, 160);
            lbl_PhotoHint.Location = new Point(442, 716);
            lbl_PhotoHint.Name = "lbl_PhotoHint";
            lbl_PhotoHint.Size = new Size(168, 19);
            lbl_PhotoHint.TabIndex = 108;
            lbl_PhotoHint.Text = "JPG, PNG, GIF · max 2 MB";
            // 
            // bt_Cancel
            // 
            bt_Cancel.BackColor = Color.FromArgb(238, 0, 0);
            bt_Cancel.Cursor = Cursors.Hand;
            bt_Cancel.FlatAppearance.BorderSize = 0;
            bt_Cancel.FlatStyle = FlatStyle.Flat;
            bt_Cancel.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            bt_Cancel.ForeColor = Color.White;
            bt_Cancel.Location = new Point(170, 778);
            bt_Cancel.Name = "bt_Cancel";
            bt_Cancel.Size = new Size(220, 46);
            bt_Cancel.TabIndex = 12;
            bt_Cancel.Text = "Cancel";
            bt_Cancel.UseVisualStyleBackColor = false;
            bt_Cancel.Click += bt_Cancel_Click;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.FromArgb(0, 68, 147);
            btn_Register.Cursor = Cursors.Hand;
            btn_Register.FlatAppearance.BorderSize = 0;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btn_Register.ForeColor = Color.White;
            btn_Register.Location = new Point(410, 778);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(220, 46);
            btn_Register.TabIndex = 13;
            btn_Register.Text = "Sign up";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += bt_Register_Click;
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.FromArgb(244, 245, 247);
            pnLeft.Controls.Add(lbl_Title);
            pnLeft.Controls.Add(pnStep1);
            pnLeft.Controls.Add(pnStep2);
            pnLeft.Controls.Add(pnStep3);
            pnLeft.Controls.Add(pnLine1);
            pnLeft.Controls.Add(pnLine2);
            pnLeft.Controls.Add(lbl_StepLbl1);
            pnLeft.Controls.Add(lbl_StepLbl2);
            pnLeft.Controls.Add(lbl_StepLbl3);
            pnLeft.Controls.Add(lbl_SectionAccount);
            pnLeft.Controls.Add(lbl_SectionProfile);
            pnLeft.Controls.Add(lbl_Username);
            pnLeft.Controls.Add(txt_UserName);
            pnLeft.Controls.Add(lbl_CheckUsername);
            pnLeft.Controls.Add(lbl_Role);
            pnLeft.Controls.Add(cbo_Role);
            pnLeft.Controls.Add(lbl_Password);
            pnLeft.Controls.Add(txt_Password);
            pnLeft.Controls.Add(pnStrengthBar);
            pnLeft.Controls.Add(lbl_CheckPassword);
            pnLeft.Controls.Add(cb_isShowPassword);
            pnLeft.Controls.Add(lbl_Email);
            pnLeft.Controls.Add(txt_Email);
            pnLeft.Controls.Add(lbl_CheckEmail);
            pnLeft.Controls.Add(lbl_OTP);
            pnLeft.Controls.Add(pnOTP);
            pnLeft.Controls.Add(lbl_Time);
            pnLeft.Controls.Add(pnDivider);
            pnLeft.Controls.Add(lbl_FirstName);
            pnLeft.Controls.Add(txt_FirstName);
            pnLeft.Controls.Add(lbl_CheckFirstName);   // THÊM MỚI
            pnLeft.Controls.Add(lbl_LastName);
            pnLeft.Controls.Add(txt_LastName);
            pnLeft.Controls.Add(lbl_CheckLastName);    // THÊM MỚI
            pnLeft.Controls.Add(lbl_Gender);
            pnLeft.Controls.Add(cbo_Gender);
            pnLeft.Controls.Add(lbl_Photo);
            pnLeft.Controls.Add(pic_Image);
            pnLeft.Controls.Add(btn_ChooseImage);
            pnLeft.Controls.Add(lbl_PhotoHint);
            pnLeft.Controls.Add(bt_Cancel);
            pnLeft.Controls.Add(btn_Register);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(880, 848);
            pnLeft.TabIndex = 40;
            pnLeft.MouseDown += pnlTop_MouseDown;
            // 
            // pnRight
            // 
            pnRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnRight.BackgroundImage = (Image)resources.GetObject("pnRight.BackgroundImage");
            pnRight.BackgroundImageLayout = ImageLayout.Stretch;
            pnRight.Controls.Add(btnClose);
            pnRight.Controls.Add(pnButtonContainer);
            pnRight.Location = new Point(880, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(638, 848);
            pnRight.TabIndex = 41;
            pnRight.MouseDown += pnlTop_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(589, 3);
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
            pnButtonContainer.Location = new Point(448, 0);
            pnButtonContainer.Name = "pnButtonContainer";
            pnButtonContainer.Size = new Size(140, 45);
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
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1518, 848);
            Controls.Add(pnRight);
            Controls.Add(pnLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "f_RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Form";
            Load += f_Register_Load;
            pnStep1.ResumeLayout(false);
            pnStep2.ResumeLayout(false);
            pnStep3.ResumeLayout(false);
            pnStrengthBar.ResumeLayout(false);
            pnOTP.ResumeLayout(false);
            pnOTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Image).EndInit();
            pnLeft.ResumeLayout(false);
            pnLeft.PerformLayout();
            pnRight.ResumeLayout(false);
            pnButtonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────────────────
        private Label lbl_Title;
        private Label lbl_SectionAccount;
        private Label lbl_SectionProfile;

        // Steps
        private Panel pnStep1, pnStep2, pnStep3;
        private Label lbl_Step1, lbl_Step2, lbl_Step3;
        private Label lbl_StepLbl1, lbl_StepLbl2, lbl_StepLbl3;
        private Panel pnLine1, pnLine2;

        // Account
        private Label lbl_Username;
        private TextBox txt_UserName;
        private Label lbl_CheckUsername;
        private Label lbl_Role;
        private ComboBox cbo_Role;
        private Label lbl_Password;
        private TextBox txt_Password;
        private Panel pnStrengthBar;
        private Panel pnStrengthFill;
        private Label lbl_CheckPassword;
        private CheckBox cb_isShowPassword;
        private Label lbl_Email;
        private TextBox txt_Email;
        private Label lbl_CheckEmail;
        private Label lbl_OTP;
        private Panel pnOTP;
        private TextBox txt_OTP;
        private Button bt_OTP;
        private Label lbl_Time;
        private Panel pnDivider;

        // Profile
        private Label lbl_FirstName;
        private TextBox txt_FirstName;
        private Label lbl_CheckFirstName;   // THÊM MỚI
        private Label lbl_LastName;
        private TextBox txt_LastName;
        private Label lbl_CheckLastName;    // THÊM MỚI
        private Label lbl_Gender;
        private ComboBox cbo_Gender;
        private Label lbl_Photo;
        private PictureBox pic_Image;
        private Button btn_ChooseImage;
        private Label lbl_PhotoHint;

        // Buttons & shell
        private Button bt_Cancel;
        private Button btn_Register;
        private Panel pnLeft;
        private Panel pnRight;
        private Button btnClose;
        private Panel pnButtonContainer;
        private Button btnMaximize;
        private Button btnMinimize;
    }
}