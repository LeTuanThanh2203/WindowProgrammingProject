namespace LoginForm

{
    partial class f_EditScore
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
            btnAdd = new Button();
            dgvStudent = new DataGridView();
            label1 = new Label();
            cboClass = new ComboBox();
            btnReset = new Button();
            panel1 = new Panel();
            label3 = new Label();
            cboSemester = new ComboBox();
            cboAcademicYear = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            btnExport = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(620, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 29);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Save Changes";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AllowUserToResizeColumns = false;
            dgvStudent.AllowUserToResizeRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudent.BackgroundColor = Color.Azure;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(20, 60);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(986, 386);
            dgvStudent.TabIndex = 23;
            dgvStudent.DataBindingComplete += dgvStudent_DataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 25;
            label1.Text = "Class:";
            // 
            // cboClass
            // 
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(87, 10);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(389, 28);
            cboClass.TabIndex = 24;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(754, 17);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(118, 29);
            btnReset.TabIndex = 29;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboSemester);
            panel1.Controls.Add(cboAcademicYear);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboClass);
            panel1.Location = new Point(32, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 108);
            panel1.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 62);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 29;
            label3.Text = "Semester:";
            // 
            // cboSemester
            // 
            cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemester.FormattingEnabled = true;
            cboSemester.Location = new Point(335, 59);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(141, 28);
            cboSemester.TabIndex = 28;
            // 
            // cboAcademicYear
            // 
            cboAcademicYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicYear.FormattingEnabled = true;
            cboAcademicYear.Location = new Point(87, 59);
            cboAcademicYear.Name = "cboAcademicYear";
            cboAcademicYear.Size = new Size(141, 28);
            cboAcademicYear.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 62);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 26;
            label2.Text = "Year:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(dgvStudent);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new Point(32, 188);
            panel2.Name = "panel2";
            panel2.Size = new Size(1021, 465);
            panel2.TabIndex = 31;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(888, 17);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(118, 29);
            btnExport.TabIndex = 28;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 1);
            label4.Name = "label4";
            label4.Size = new Size(216, 46);
            label4.TabIndex = 32;
            label4.Text = "List Student:";
            // 
            // f_EditScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1121, 771);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "f_EditScore";
            Text = "Score";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private DataGridView dgvStudent;
        private Label label1;
        private ComboBox cboClass;
        private Button btnReset;
        private Panel panel1;
        private Label label3;
        private ComboBox cboSemester;
        private ComboBox cboAcademicYear;
        private Label label2;
        private Panel panel2;
        private Button btnExport;
        private Label label4;
    }
}