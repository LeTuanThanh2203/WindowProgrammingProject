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
            txtQT = new TextBox();
            txtCK = new TextBox();
            MSSV = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            dgvStudent = new DataGridView();
            label1 = new Label();
            cboCourse = new ComboBox();
            lblID = new Label();
            lblTotal = new Label();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // txtQT
            // 
            txtQT.Location = new Point(146, 185);
            txtQT.Name = "txtQT";
            txtQT.Size = new Size(359, 27);
            txtQT.TabIndex = 3;
            txtQT.TextChanged += txtQT_TextChanged;
            // 
            // txtCK
            // 
            txtCK.Location = new Point(146, 256);
            txtCK.Name = "txtCK";
            txtCK.Size = new Size(359, 27);
            txtCK.TabIndex = 4;
            txtCK.TextChanged += txtCK_TextChanged;
            // 
            // MSSV
            // 
            MSSV.AutoSize = true;
            MSSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MSSV.Location = new Point(32, 122);
            MSSV.Name = "MSSV";
            MSSV.Size = new Size(25, 20);
            MSSV.TabIndex = 7;
            MSSV.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 188);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 9;
            label2.Text = "Process Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 256);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "Final Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 326);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 11;
            label4.Text = "Total Grade";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 390);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 44);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AllowUserToResizeColumns = false;
            dgvStudent.AllowUserToResizeRows = false;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudent.BackgroundColor = Color.White;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(525, 29);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(612, 590);
            dgvStudent.TabIndex = 23;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 25;
            label1.Text = "Course";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(146, 50);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(359, 28);
            cboCourse.TabIndex = 24;
            cboCourse.SelectedIndexChanged += cboCourse_SelectedIndexChanged;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(146, 115);
            lblID.Name = "lblID";
            lblID.Size = new Size(0, 28);
            lblID.TabIndex = 26;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(146, 318);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 28);
            lblTotal.TabIndex = 27;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(378, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 44);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete Score";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(207, 390);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(127, 44);
            btnRefresh.TabIndex = 29;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // f_EditScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 656);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(lblTotal);
            Controls.Add(lblID);
            Controls.Add(label1);
            Controls.Add(cboCourse);
            Controls.Add(dgvStudent);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MSSV);
            Controls.Add(txtCK);
            Controls.Add(txtQT);
            Name = "f_EditScore";
            Text = "Score";
            Load += f_AddScore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtQT;
        private TextBox txtCK;
        private Label MSSV;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private DataGridView dgvStudent;
        private Label label1;
        private ComboBox cboCourse;
        private Label lblID;
        private Label lblTotal;
        private Button btnDelete;
        private Button btnRefresh;
    }
}