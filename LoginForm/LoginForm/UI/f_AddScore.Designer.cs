namespace LoginForm

{
    partial class f_AddScore
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
            txtMSSV = new TextBox();
            cboCourse = new ComboBox();
            txtQT = new TextBox();
            txtCK = new TextBox();
            txtTK = new TextBox();
            MSSV = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvStudent = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(946, 87);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(359, 27);
            txtMSSV.TabIndex = 1;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(946, 170);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(359, 28);
            cboCourse.TabIndex = 2;
            // 
            // txtQT
            // 
            txtQT.Location = new Point(946, 238);
            txtQT.Name = "txtQT";
            txtQT.Size = new Size(359, 27);
            txtQT.TabIndex = 3;
            txtQT.TextChanged += txtQT_TextChanged;
            // 
            // txtCK
            // 
            txtCK.Location = new Point(946, 309);
            txtCK.Name = "txtCK";
            txtCK.Size = new Size(359, 27);
            txtCK.TabIndex = 4;
            txtCK.TextChanged += txtCK_TextChanged;
            // 
            // txtTK
            // 
            txtTK.Location = new Point(946, 376);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(359, 27);
            txtTK.TabIndex = 5;
            // 
            // MSSV
            // 
            MSSV.AutoSize = true;
            MSSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSSV.Location = new Point(838, 98);
            MSSV.Name = "MSSV";
            MSSV.Size = new Size(25, 20);
            MSSV.TabIndex = 7;
            MSSV.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(835, 173);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 8;
            label1.Text = "Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(832, 241);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 9;
            label2.Text = "Process Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(832, 309);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "Final Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(832, 379);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 11;
            label4.Text = "Total Grade";
            // 
            // dgvStudent
            // 
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(2, 3);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(787, 590);
            dgvStudent.TabIndex = 12;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1178, 446);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 44);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // f_AddScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 605);
            Controls.Add(btnAdd);
            Controls.Add(dgvStudent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MSSV);
            Controls.Add(txtTK);
            Controls.Add(txtCK);
            Controls.Add(txtQT);
            Controls.Add(cboCourse);
            Controls.Add(txtMSSV);
            Name = "f_AddScore";
            Text = "Add Score";
            Load += f_AddScore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMSSV;
        private ComboBox cboCourse;
        private TextBox txtQT;
        private TextBox txtCK;
        private TextBox txtTK;
        private Label MSSV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvStudent;
        private Button btnAdd;
    }
}