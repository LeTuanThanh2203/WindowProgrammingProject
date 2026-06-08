namespace Project_Group6
{
    partial class f_ClassList
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
            pnBottom = new Panel();
            btnEdit = new Button();
            btnAdd = new Button();
            btnRefresh = new Button();
            lblTotal = new Label();
            cboSort = new ComboBox();
            cboGender = new ComboBox();
            txtSearch = new TextBox();
            panel2 = new Panel();
            dgvClassList = new DataGridView();
            pnMain = new Panel();
            panel1 = new Panel();
            pnBottom.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClassList).BeginInit();
            pnMain.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnBottom
            // 
            pnBottom.Controls.Add(btnEdit);
            pnBottom.Controls.Add(btnAdd);
            pnBottom.Controls.Add(btnRefresh);
            pnBottom.Controls.Add(lblTotal);
            pnBottom.Dock = DockStyle.Bottom;
            pnBottom.Location = new Point(0, 762);
            pnBottom.Name = "pnBottom";
            pnBottom.Size = new Size(1231, 82);
            pnBottom.TabIndex = 16;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.Location = new Point(439, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 40);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.Location = new Point(228, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 40);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top;
            btnRefresh.Location = new Point(649, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(124, 40);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(36, 25);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 20);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total Class:";
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Location = new Point(54, 21);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(101, 28);
            cboSort.TabIndex = 8;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(152, 21);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(97, 28);
            cboGender.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(255, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(1210, 27);
            txtSearch.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(cboSort);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1231, 57);
            panel2.TabIndex = 15;
            // 
            // dgvClassList
            // 
            dgvClassList.AllowUserToAddRows = false;
            dgvClassList.AllowUserToDeleteRows = false;
            dgvClassList.AllowUserToResizeColumns = false;
            dgvClassList.AllowUserToResizeRows = false;
            dgvClassList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClassList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClassList.BackgroundColor = SystemColors.Control;
            dgvClassList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassList.Location = new Point(33, 3);
            dgvClassList.Name = "dgvClassList";
            dgvClassList.ReadOnly = true;
            dgvClassList.RowHeadersVisible = false;
            dgvClassList.RowHeadersWidth = 51;
            dgvClassList.Size = new Size(1183, 695);
            dgvClassList.TabIndex = 6;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(cboGender);
            pnMain.Controls.Add(txtSearch);
            pnMain.Controls.Add(panel2);
            pnMain.Controls.Add(panel1);
            pnMain.Controls.Add(pnBottom);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1231, 844);
            pnMain.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvClassList);
            panel1.Location = new Point(3, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 701);
            panel1.TabIndex = 14;
            // 
            // f_ClassList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 844);
            Controls.Add(pnMain);
            Name = "f_ClassList";
            Text = "f_ClassList";
            pnBottom.ResumeLayout(false);
            pnBottom.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClassList).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBottom;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefresh;
        private Label lblTotal;
        private ComboBox cboSort;
        private ComboBox cboGender;
        private TextBox txtSearch;
        private Panel panel2;
        private DataGridView dgvClassList;
        private Panel pnMain;
        private Panel panel1;
    }
}