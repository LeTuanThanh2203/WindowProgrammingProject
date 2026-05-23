namespace LoginForm
{
    partial class f_AddCourse
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
            txt_Overview = new TextBox();
            lbl_Overview = new Label();
            txt_TheoryPeriod = new TextBox();
            lbl_Period = new Label();
            cbo_PrerequisiteCourse = new ComboBox();
            lbl_PrerequisiteCourse = new Label();
            txt_NameCourse = new TextBox();
            txt_IDCourse = new TextBox();
            label2 = new Label();
            lbl_IDCourse = new Label();
            btnQuit = new Button();
            btnClear = new Button();
            btn_AddCourse = new Button();
            txt_CreditHour = new TextBox();
            label3 = new Label();
            lbl_Theory = new Label();
            lbl_Practical = new Label();
            txt_PracticalPeriod = new TextBox();
            SuspendLayout();
            // 
            // txt_Overview
            // 
            txt_Overview.Location = new Point(170, 230);
            txt_Overview.Multiline = true;
            txt_Overview.Name = "txt_Overview";
            txt_Overview.Size = new Size(419, 107);
            txt_Overview.TabIndex = 28;
            // 
            // lbl_Overview
            // 
            lbl_Overview.AutoSize = true;
            lbl_Overview.Location = new Point(25, 233);
            lbl_Overview.Name = "lbl_Overview";
            lbl_Overview.Size = new Size(73, 20);
            lbl_Overview.TabIndex = 27;
            lbl_Overview.Text = "Overview:";
            // 
            // txt_TheoryPeriod
            // 
            txt_TheoryPeriod.Location = new Point(170, 189);
            txt_TheoryPeriod.Name = "txt_TheoryPeriod";
            txt_TheoryPeriod.Size = new Size(69, 27);
            txt_TheoryPeriod.TabIndex = 26;
            // 
            // lbl_Period
            // 
            lbl_Period.AutoSize = true;
            lbl_Period.Location = new Point(25, 192);
            lbl_Period.Name = "lbl_Period";
            lbl_Period.Size = new Size(54, 20);
            lbl_Period.TabIndex = 25;
            lbl_Period.Text = "Period:";
            // 
            // cbo_PrerequisiteCourse
            // 
            cbo_PrerequisiteCourse.FormattingEnabled = true;
            cbo_PrerequisiteCourse.Location = new Point(170, 151);
            cbo_PrerequisiteCourse.Name = "cbo_PrerequisiteCourse";
            cbo_PrerequisiteCourse.Size = new Size(419, 28);
            cbo_PrerequisiteCourse.TabIndex = 23;
            // 
            // lbl_PrerequisiteCourse
            // 
            lbl_PrerequisiteCourse.AutoSize = true;
            lbl_PrerequisiteCourse.Location = new Point(25, 151);
            lbl_PrerequisiteCourse.Name = "lbl_PrerequisiteCourse";
            lbl_PrerequisiteCourse.Size = new Size(139, 20);
            lbl_PrerequisiteCourse.TabIndex = 22;
            lbl_PrerequisiteCourse.Text = "Prerequisite Course:";
            // 
            // txt_NameCourse
            // 
            txt_NameCourse.Location = new Point(170, 108);
            txt_NameCourse.Name = "txt_NameCourse";
            txt_NameCourse.Size = new Size(225, 27);
            txt_NameCourse.TabIndex = 21;
            // 
            // txt_IDCourse
            // 
            txt_IDCourse.Location = new Point(170, 65);
            txt_IDCourse.Name = "txt_IDCourse";
            txt_IDCourse.Size = new Size(225, 27);
            txt_IDCourse.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 108);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 19;
            label2.Text = "Name Course:";
            // 
            // lbl_IDCourse
            // 
            lbl_IDCourse.AutoSize = true;
            lbl_IDCourse.Location = new Point(25, 68);
            lbl_IDCourse.Name = "lbl_IDCourse";
            lbl_IDCourse.Size = new Size(76, 20);
            lbl_IDCourse.TabIndex = 18;
            lbl_IDCourse.Text = "ID Course:";
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(539, 371);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(136, 44);
            btnQuit.TabIndex = 33;
            btnQuit.Text = "Cancel";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += bt_Cancel_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(351, 371);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 44);
            btnClear.TabIndex = 32;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn_AddCourse
            // 
            btn_AddCourse.Location = new Point(170, 371);
            btn_AddCourse.Name = "btn_AddCourse";
            btn_AddCourse.Size = new Size(127, 44);
            btn_AddCourse.TabIndex = 31;
            btn_AddCourse.Text = "Add Course";
            btn_AddCourse.UseVisualStyleBackColor = true;
            btn_AddCourse.Click += btn_AddCourse_Click;
            // 
            // txt_CreditHour
            // 
            txt_CreditHour.Location = new Point(510, 111);
            txt_CreditHour.Name = "txt_CreditHour";
            txt_CreditHour.Size = new Size(79, 27);
            txt_CreditHour.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 114);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 34;
            label3.Text = "Credit Hour:";
            // 
            // lbl_Theory
            // 
            lbl_Theory.AutoSize = true;
            lbl_Theory.Location = new Point(245, 192);
            lbl_Theory.Name = "lbl_Theory";
            lbl_Theory.Size = new Size(54, 20);
            lbl_Theory.TabIndex = 36;
            lbl_Theory.Text = "Theory";
            // 
            // lbl_Practical
            // 
            lbl_Practical.AutoSize = true;
            lbl_Practical.Location = new Point(453, 192);
            lbl_Practical.Name = "lbl_Practical";
            lbl_Practical.Size = new Size(65, 20);
            lbl_Practical.TabIndex = 38;
            lbl_Practical.Text = "Practical";
            // 
            // txt_PracticalPeriod
            // 
            txt_PracticalPeriod.Location = new Point(378, 189);
            txt_PracticalPeriod.Name = "txt_PracticalPeriod";
            txt_PracticalPeriod.Size = new Size(69, 27);
            txt_PracticalPeriod.TabIndex = 37;
            // 
            // f_AddCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 450);
            Controls.Add(lbl_Practical);
            Controls.Add(txt_PracticalPeriod);
            Controls.Add(lbl_Theory);
            Controls.Add(txt_CreditHour);
            Controls.Add(label3);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btn_AddCourse);
            Controls.Add(txt_Overview);
            Controls.Add(lbl_Overview);
            Controls.Add(txt_TheoryPeriod);
            Controls.Add(lbl_Period);
            Controls.Add(cbo_PrerequisiteCourse);
            Controls.Add(lbl_PrerequisiteCourse);
            Controls.Add(txt_NameCourse);
            Controls.Add(txt_IDCourse);
            Controls.Add(label2);
            Controls.Add(lbl_IDCourse);
            Name = "f_AddCourse";
            Text = "f_AddCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Overview;
        private Label lbl_Overview;
        private TextBox txt_TheoryPeriod;
        private Label lbl_Period;
        private ComboBox cbo_PrerequisiteCourse;
        private Label lbl_PrerequisiteCourse;
        private TextBox txt_NameCourse;
        private TextBox txt_IDCourse;
        private Label label2;
        private Label lbl_IDCourse;
        private Button btnQuit;
        private Button btnClear;
        private Button btn_AddCourse;
        private TextBox txt_CreditHour;
        private Label label3;
        private Label lbl_Theory;
        private Label lbl_Practical;
        private TextBox txt_PracticalPeriod;
    }
}