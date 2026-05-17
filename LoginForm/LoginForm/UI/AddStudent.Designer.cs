using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace LoginForm
{
    partial class AddStudent
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
            label1 = new Label();
            label2 = new Label();
            txtMSSV = new TextBox();
            txtFname = new TextBox();
            label3 = new Label();
            txtLname = new TextBox();
            dtpDob = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            cboGender = new ComboBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtHometown = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            picStudent = new PictureBox();
            btnChooseImage = new Button();
            label10 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 65);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 105);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(108, 62);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(143, 27);
            txtMSSV.TabIndex = 2;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(108, 102);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(185, 27);
            txtFname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 105);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "First name:";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(417, 102);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(106, 27);
            txtLname.TabIndex = 5;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(629, 102);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(149, 27);
            dtpDob.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 105);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 7;
            label4.Text = "Date of birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 148);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(109, 145);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(68, 28);
            cboGender.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 148);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 10;
            label6.Text = "Number phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(326, 145);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(185, 27);
            txtPhone.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 189);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 12;
            label7.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(109, 186);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(404, 27);
            txtAddress.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 230);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 14;
            label8.Text = "Hometown:";
            // 
            // txtHometown
            // 
            txtHometown.Location = new Point(109, 227);
            txtHometown.Name = "txtHometown";
            txtHometown.Size = new Size(404, 27);
            txtHometown.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 269);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 16;
            label9.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 266);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 27);
            txtEmail.TabIndex = 17;
            // 
            // picStudent
            // 
            picStudent.Location = new Point(603, 168);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(126, 150);
            picStudent.TabIndex = 18;
            picStudent.TabStop = false;
            picStudent.Click += btnChooseImage_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(576, 324);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(177, 34);
            btnChooseImage.TabIndex = 19;
            btnChooseImage.Text = "Upload";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(642, 145);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 20;
            label10.Text = "Image";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(146, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 44);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(327, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 44);
            btnClear.TabIndex = 22;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(515, 380);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(136, 44);
            btnQuit.TabIndex = 23;
            btnQuit.Text = "Cancel";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label10);
            Controls.Add(btnChooseImage);
            Controls.Add(picStudent);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(txtHometown);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(cboGender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpDob);
            Controls.Add(txtLname);
            Controls.Add(label3);
            Controls.Add(txtFname);
            Controls.Add(txtMSSV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStudent";
            Text = "Add Student";
            Load += StudentAdd_Load;
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMSSV;
        private TextBox txtFname;
        private Label label3;
        private TextBox txtLname;
        private DateTimePicker dtpDob;
        private Label label4;
        private Label label5;
        private ComboBox cboGender;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtHometown;
        private Label label9;
        private TextBox txtEmail;
        private PictureBox picStudent;
        private Button btnChooseImage;
        private Label label10;
        private Button btnAdd;
        private Button btnClear;
        private Button btnQuit;

    }
}