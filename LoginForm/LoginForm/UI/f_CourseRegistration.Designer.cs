namespace LoginForm
{
    partial class f_CourseRegistration
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
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvUnRegistereCourse = new DataGridView();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dgvRegistereCourse = new DataGridView();
            btnSelectedRegist = new Button();
            btnSelectedALLRegist = new Button();
            btnSelectedALLUnRegist = new Button();
            btnSelectedUnRegist = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).BeginInit();
            SuspendLayout();
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(5, 7);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(101, 28);
            cboSort.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(112, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(295, 27);
            txtSearch.TabIndex = 7;
            // 
            // dgvUnRegistereCourse
            // 
            dgvUnRegistereCourse.BackgroundColor = SystemColors.Control;
            dgvUnRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnRegistereCourse.Location = new Point(0, 77);
            dgvUnRegistereCourse.Name = "dgvUnRegistereCourse";
            dgvUnRegistereCourse.ReadOnly = true;
            dgvUnRegistereCourse.RowHeadersVisible = false;
            dgvUnRegistereCourse.RowHeadersWidth = 51;
            dgvUnRegistereCourse.Size = new Size(407, 636);
            dgvUnRegistereCourse.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(649, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 28);
            comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(756, 7);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 10;
            // 
            // dgvRegistereCourse
            // 
            dgvRegistereCourse.BackgroundColor = SystemColors.Control;
            dgvRegistereCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistereCourse.Location = new Point(644, 77);
            dgvRegistereCourse.Name = "dgvRegistereCourse";
            dgvRegistereCourse.ReadOnly = true;
            dgvRegistereCourse.RowHeadersVisible = false;
            dgvRegistereCourse.RowHeadersWidth = 51;
            dgvRegistereCourse.Size = new Size(407, 636);
            dgvRegistereCourse.TabIndex = 9;
            // 
            // btnSelectedRegist
            // 
            btnSelectedRegist.Location = new Point(445, 102);
            btnSelectedRegist.Name = "btnSelectedRegist";
            btnSelectedRegist.Size = new Size(162, 58);
            btnSelectedRegist.TabIndex = 12;
            btnSelectedRegist.Text = "Select ==>";
            btnSelectedRegist.UseVisualStyleBackColor = true;
            // 
            // btnSelectedALLRegist
            // 
            btnSelectedALLRegist.Location = new Point(445, 189);
            btnSelectedALLRegist.Name = "btnSelectedALLRegist";
            btnSelectedALLRegist.Size = new Size(162, 58);
            btnSelectedALLRegist.TabIndex = 13;
            btnSelectedALLRegist.Text = "Select All==>";
            btnSelectedALLRegist.UseVisualStyleBackColor = true;
            // 
            // btnSelectedALLUnRegist
            // 
            btnSelectedALLUnRegist.Location = new Point(445, 461);
            btnSelectedALLUnRegist.Name = "btnSelectedALLUnRegist";
            btnSelectedALLUnRegist.Size = new Size(162, 58);
            btnSelectedALLUnRegist.TabIndex = 15;
            btnSelectedALLUnRegist.Text = "<== Select All";
            btnSelectedALLUnRegist.UseVisualStyleBackColor = true;
            // 
            // btnSelectedUnRegist
            // 
            btnSelectedUnRegist.Location = new Point(445, 374);
            btnSelectedUnRegist.Name = "btnSelectedUnRegist";
            btnSelectedUnRegist.Size = new Size(162, 58);
            btnSelectedUnRegist.TabIndex = 14;
            btnSelectedUnRegist.Text = "<== Select";
            btnSelectedUnRegist.UseVisualStyleBackColor = true;
            // 
            // f_CourseRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 744);
            Controls.Add(btnSelectedALLUnRegist);
            Controls.Add(btnSelectedUnRegist);
            Controls.Add(btnSelectedALLRegist);
            Controls.Add(btnSelectedRegist);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dgvRegistereCourse);
            Controls.Add(cboSort);
            Controls.Add(txtSearch);
            Controls.Add(dgvUnRegistereCourse);
            Name = "f_CourseRegistration";
            Text = "f_CourseRegistration";
            ((System.ComponentModel.ISupportInitialize)dgvUnRegistereCourse).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistereCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboGender;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private DataGridView dgvUnRegistereCourse;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dgvRegistereCourse;
        private Button btnSelectedRegist;
        private Button btnSelectedALLRegist;
        private Button btnSelectedALLUnRegist;
        private Button btnSelectedUnRegist;
    }
}