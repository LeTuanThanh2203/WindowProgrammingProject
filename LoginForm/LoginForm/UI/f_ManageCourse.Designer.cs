namespace LoginForm
{
    partial class f_ManageCourse
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
            cboGender = new ComboBox();
            cboSort = new ComboBox();
            txtSearch = new TextBox();
            dgvCourse = new DataGridView();
            pnMain = new Panel();
            btnEdit = new Button();
            lblTotal = new Label();
            btnRefresh = new Button();
            btnAdd = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            pnMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(152, 21);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(97, 28);
            cboGender.TabIndex = 9;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(36, 21);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(101, 28);
            cboSort.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(255, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(713, 27);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvCourse
            // 
            dgvCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.BackgroundColor = SystemColors.Control;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(9, 3);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.ReadOnly = true;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.Size = new Size(1059, 569);
            dgvCourse.TabIndex = 6;
            dgvCourse.CellDoubleClick += dgvCourse_CellDoubleClick;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(btnEdit);
            pnMain.Controls.Add(lblTotal);
            pnMain.Controls.Add(btnRefresh);
            pnMain.Controls.Add(btnAdd);
            pnMain.Controls.Add(cboSort);
            pnMain.Controls.Add(cboGender);
            pnMain.Controls.Add(txtSearch);
            pnMain.Controls.Add(panel3);
            pnMain.Controls.Add(panel2);
            pnMain.Controls.Add(panel1);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1083, 718);
            pnMain.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.Location = new Point(434, 651);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 40);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEditDelete_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(36, 651);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total Student:";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top;
            btnRefresh.Location = new Point(564, 651);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(124, 40);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.Location = new Point(302, 651);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 40);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddCourse_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 636);
            panel3.Name = "panel3";
            panel3.Size = new Size(1083, 82);
            panel3.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1083, 49);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvCourse);
            panel1.Location = new Point(3, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 575);
            panel1.TabIndex = 14;
            // 
            // f_ManageCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 718);
            Controls.Add(pnMain);
            Name = "f_ManageCourse";
            Text = "f_ManageCourse";
            Load += f_ManageCourse_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboGender;
        private ComboBox cboSort;
        private TextBox txtSearch;
        private DataGridView dgvCourse;
        private Panel pnMain;
        private Button btnEdit;
        private Label lblTotal;
        private Button btnRefresh;
        private Button btnAdd;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}