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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();

            panel1 = new Panel();
            label1 = new Label();
            cboClass = new ComboBox();
            label2 = new Label();
            cboAcademicYear = new ComboBox();
            label3 = new Label();
            cboSemester = new ComboBox();

            panel2 = new Panel();
            label4 = new Label();
            btnAdd = new Button();
            btnReset = new Button();
            btnExport = new Button();
            dgvStudent = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Padding = new Padding(24, 0, 0, 0);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            //
            // lblTitle
            //
            lblTitle.AutoSize = false;
            lblTitle.Text = "Score Management";
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Size = new Size(420, 30);
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "University Academic Management System";
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Size = new Size(420, 20);
            //
            // pnlBody
            //
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(panel1);
            pnlBody.Controls.Add(panel2);
            //
            // panel1 (Filters card)
            //
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(24, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 108);
            panel1.TabIndex = 0;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboClass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboAcademicYear);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboSemester);
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 80, 90);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 25;
            label1.Text = "Class:";
            //
            // cboClass
            //
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.FormattingEnabled = true;
            cboClass.Font = new Font("Segoe UI", 9.5F);
            cboClass.Location = new Point(87, 14);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(389, 28);
            cboClass.TabIndex = 24;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(80, 80, 90);
            label2.Location = new Point(20, 62);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 26;
            label2.Text = "Year:";
            //
            // cboAcademicYear
            //
            cboAcademicYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAcademicYear.FormattingEnabled = true;
            cboAcademicYear.Font = new Font("Segoe UI", 9.5F);
            cboAcademicYear.Location = new Point(87, 58);
            cboAcademicYear.Name = "cboAcademicYear";
            cboAcademicYear.Size = new Size(141, 28);
            cboAcademicYear.TabIndex = 27;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(80, 80, 90);
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
            cboSemester.Font = new Font("Segoe UI", 9.5F);
            cboSemester.Location = new Point(335, 58);
            cboSemester.Name = "cboSemester";
            cboSemester.Size = new Size(141, 28);
            cboSemester.TabIndex = 28;
            //
            // panel2 (Student list card)
            //
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(24, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 454);
            panel2.TabIndex = 31;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(dgvStudent);
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(10, 61, 120);
            label4.Location = new Point(20, 16);
            label4.Name = "label4";
            label4.TabIndex = 32;
            label4.Text = "Student List";
            //
            // btnAdd
            //
            btnAdd.Text = "Save Changes";
            btnAdd.Location = new Point(808, 17);
            btnAdd.Size = new Size(118, 29);
            btnAdd.Font = new Font("Segoe UI Semibold", 9.5F);
            btnAdd.BackColor = Color.FromArgb(10, 61, 120);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Name = "btnAdd";
            btnAdd.TabIndex = 22;
            btnAdd.UseVisualStyleBackColor = false;
            //
            // btnReset
            //
            btnReset.Text = "RESET";
            btnReset.Location = new Point(936, 17);
            btnReset.Size = new Size(118, 29);
            btnReset.Font = new Font("Segoe UI", 9.5F);
            btnReset.BackColor = Color.White;
            btnReset.ForeColor = Color.FromArgb(60, 70, 85);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnReset.FlatAppearance.BorderSize = 1;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Name = "btnReset";
            btnReset.TabIndex = 29;
            btnReset.UseVisualStyleBackColor = true;
            //
            // btnExport
            //
            btnExport.Text = "Export";
            btnExport.Location = new Point(1064, 17);
            btnExport.Size = new Size(118, 29);
            btnExport.Font = new Font("Segoe UI", 9.5F);
            btnExport.BackColor = Color.White;
            btnExport.ForeColor = Color.FromArgb(60, 70, 85);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnExport.FlatAppearance.BorderSize = 1;
            btnExport.Cursor = Cursors.Hand;
            btnExport.Name = "btnExport";
            btnExport.TabIndex = 28;
            btnExport.UseVisualStyleBackColor = true;
            //
            // dgvStudent
            //
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AllowUserToResizeColumns = false;
            dgvStudent.AllowUserToResizeRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudent.BackgroundColor = Color.White;
            dgvStudent.BorderStyle = BorderStyle.None;
            dgvStudent.GridColor = Color.FromArgb(225, 228, 232);
            dgvStudent.EnableHeadersVisualStyles = false;
            dgvStudent.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 61, 120);
            dgvStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudent.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F);
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dgvStudent.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvStudent.RowTemplate.Height = 32;
            dgvStudent.Location = new Point(20, 60);
            dgvStudent.MultiSelect = false;
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(1162, 374);
            dgvStudent.TabIndex = 23;
            dgvStudent.DataBindingComplete += dgvStudent_DataBindingComplete;
            //
            // f_EditScore
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1250, 700);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            Name = "f_EditScore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Score";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlBody;

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