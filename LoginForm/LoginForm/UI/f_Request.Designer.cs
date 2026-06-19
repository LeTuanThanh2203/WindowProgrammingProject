namespace Project_Group6
{
    partial class f_Request
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlBody = new Panel();
            grpRequestList = new GroupBox();
            dataGridView1 = new DataGridView();
            txtConfirmationNameData = new DataGridViewTextBoxColumn();
            txtQueueNumberData = new DataGridViewTextBoxColumn();
            txtQuantityData = new DataGridViewTextBoxColumn();
            txtStatusData = new DataGridViewTextBoxColumn();
            grpNewRequest = new GroupBox();
            lbl_ConfirmationName = new Label();
            cbo_ConfirmationName = new ComboBox();
            lbl_Quantity = new Label();
            cbo_Quantity = new ComboBox();
            btn_Add = new Button();
            pnlBottom = new Panel();
            lblTotal = new Label();
            pnlPagination = new Panel();
            cboPageSize = new ComboBox();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPageInfo = new Label();
            btnNext = new Button();
            btnLast = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            grpRequestList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpNewRequest.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlPagination.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(10, 61, 120);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(960, 80);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Confirmation Requests";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Request official university certifications and documents";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(grpRequestList);
            pnlBody.Controls.Add(grpNewRequest);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20, 16, 20, 12);
            pnlBody.Size = new Size(960, 506);
            pnlBody.TabIndex = 0;
            // 
            // grpRequestList
            // 
            grpRequestList.BackColor = Color.White;
            grpRequestList.Controls.Add(dataGridView1);
            grpRequestList.Dock = DockStyle.Fill;
            grpRequestList.Font = new Font("Segoe UI Semibold", 9.5F);
            grpRequestList.ForeColor = Color.FromArgb(10, 61, 120);
            grpRequestList.Location = new Point(20, 156);
            grpRequestList.Margin = new Padding(0, 16, 0, 0);
            grpRequestList.Name = "grpRequestList";
            grpRequestList.Padding = new Padding(16, 24, 16, 16);
            grpRequestList.Size = new Size(920, 338);
            grpRequestList.TabIndex = 0;
            grpRequestList.TabStop = false;
            grpRequestList.Text = "My Requests History";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtConfirmationNameData, txtQueueNumberData, txtQuantityData, txtStatusData });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(16, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(888, 276);
            dataGridView1.TabIndex = 0;
            // 
            // txtConfirmationNameData
            // 
            txtConfirmationNameData.HeaderText = "Document Name";
            txtConfirmationNameData.MinimumWidth = 6;
            txtConfirmationNameData.Name = "txtConfirmationNameData";
            txtConfirmationNameData.ReadOnly = true;
            txtConfirmationNameData.Width = 162;
            // 
            // txtQueueNumberData
            // 
            txtQueueNumberData.HeaderText = "Queue Number";
            txtQueueNumberData.MinimumWidth = 6;
            txtQueueNumberData.Name = "txtQueueNumberData";
            txtQueueNumberData.ReadOnly = true;
            txtQueueNumberData.Width = 151;
            // 
            // txtQuantityData
            // 
            txtQuantityData.HeaderText = "Quantity";
            txtQuantityData.MinimumWidth = 6;
            txtQuantityData.Name = "txtQuantityData";
            txtQuantityData.ReadOnly = true;
            txtQuantityData.Width = 101;
            // 
            // txtStatusData
            // 
            txtStatusData.HeaderText = "Status";
            txtStatusData.MinimumWidth = 6;
            txtStatusData.Name = "txtStatusData";
            txtStatusData.ReadOnly = true;
            txtStatusData.Width = 84;
            // 
            // grpNewRequest
            // 
            grpNewRequest.BackColor = Color.White;
            grpNewRequest.Controls.Add(lbl_ConfirmationName);
            grpNewRequest.Controls.Add(cbo_ConfirmationName);
            grpNewRequest.Controls.Add(lbl_Quantity);
            grpNewRequest.Controls.Add(cbo_Quantity);
            grpNewRequest.Controls.Add(btn_Add);
            grpNewRequest.Dock = DockStyle.Top;
            grpNewRequest.Font = new Font("Segoe UI Semibold", 9.5F);
            grpNewRequest.ForeColor = Color.FromArgb(10, 61, 120);
            grpNewRequest.Location = new Point(20, 16);
            grpNewRequest.Name = "grpNewRequest";
            grpNewRequest.Size = new Size(920, 140);
            grpNewRequest.TabIndex = 1;
            grpNewRequest.TabStop = false;
            grpNewRequest.Text = "New Request Details";
            // 
            // lbl_ConfirmationName
            // 
            lbl_ConfirmationName.Font = new Font("Segoe UI", 9.5F);
            lbl_ConfirmationName.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_ConfirmationName.Location = new Point(24, 38);
            lbl_ConfirmationName.Name = "lbl_ConfirmationName";
            lbl_ConfirmationName.Size = new Size(140, 20);
            lbl_ConfirmationName.TabIndex = 0;
            lbl_ConfirmationName.Text = "Document Name:";
            // 
            // cbo_ConfirmationName
            // 
            cbo_ConfirmationName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_ConfirmationName.Font = new Font("Segoe UI", 9.5F);
            cbo_ConfirmationName.Location = new Point(180, 34);
            cbo_ConfirmationName.Name = "cbo_ConfirmationName";
            cbo_ConfirmationName.Size = new Size(320, 29);
            cbo_ConfirmationName.TabIndex = 1;
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.Font = new Font("Segoe UI", 9.5F);
            lbl_Quantity.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_Quantity.Location = new Point(24, 82);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(140, 20);
            lbl_Quantity.TabIndex = 2;
            lbl_Quantity.Text = "Quantity:";
            // 
            // cbo_Quantity
            // 
            cbo_Quantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Quantity.Font = new Font("Segoe UI", 9.5F);
            cbo_Quantity.Location = new Point(180, 78);
            cbo_Quantity.Name = "cbo_Quantity";
            cbo_Quantity.Size = new Size(120, 29);
            cbo_Quantity.TabIndex = 3;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(10, 61, 120);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI Semibold", 9.5F);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(520, 33);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(150, 75);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "✚  Submit Request";
            btn_Add.UseVisualStyleBackColor = false;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 586);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(960, 68);
            pnlBottom.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(24, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 21);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Requests: 0";
            // 
            // pnlPagination
            // 
            pnlPagination.Controls.Add(cboPageSize);
            pnlPagination.Controls.Add(btnFirst);
            pnlPagination.Controls.Add(btnPrev);
            pnlPagination.Controls.Add(lblPageInfo);
            pnlPagination.Controls.Add(btnNext);
            pnlPagination.Controls.Add(btnLast);
            pnlPagination.Dock = DockStyle.Right;
            pnlPagination.Location = new Point(556, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 44);
            pnlPagination.TabIndex = 1;
            // 
            // cboPageSize
            // 
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(500, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Request official university certifications and documents";
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 250);
            pnlBody.Controls.Add(grpRequestList);
            pnlBody.Controls.Add(grpNewRequest);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 80);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20, 16, 20, 12);
            pnlBody.Size = new Size(960, 506);
            pnlBody.TabIndex = 0;
            // 
            // grpRequestList
            // 
            grpRequestList.BackColor = Color.White;
            grpRequestList.Controls.Add(dataGridView1);
            grpRequestList.Dock = DockStyle.Fill;
            grpRequestList.Font = new Font("Segoe UI Semibold", 9.5F);
            grpRequestList.ForeColor = Color.FromArgb(10, 61, 120);
            grpRequestList.Location = new Point(20, 156);
            grpRequestList.Margin = new Padding(0, 16, 0, 0);
            grpRequestList.Name = "grpRequestList";
            grpRequestList.Padding = new Padding(16, 24, 16, 16);
            grpRequestList.Size = new Size(920, 338);
            grpRequestList.TabIndex = 0;
            grpRequestList.TabStop = false;
            grpRequestList.Text = "My Requests History";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeight = 29;
            //dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtConfirmationNameData, txtQueueNumberData, txtQuantityData, txtStatusData });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(16, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(888, 276);
            dataGridView1.TabIndex = 0;
            // 
            // txtConfirmationNameData
            // 
            txtConfirmationNameData.HeaderText = "Document Name";
            txtConfirmationNameData.MinimumWidth = 6;
            txtConfirmationNameData.Name = "txtConfirmationNameData";
            txtConfirmationNameData.ReadOnly = true;
            txtConfirmationNameData.Width = 162;
            // 
            // txtQueueNumberData
            // 
            txtQueueNumberData.HeaderText = "Queue Number";
            txtQueueNumberData.MinimumWidth = 6;
            txtQueueNumberData.Name = "txtQueueNumberData";
            txtQueueNumberData.ReadOnly = true;
            txtQueueNumberData.Width = 151;
            // 
            // txtQuantityData
            // 
            txtQuantityData.HeaderText = "Quantity";
            txtQuantityData.MinimumWidth = 6;
            txtQuantityData.Name = "txtQuantityData";
            txtQuantityData.ReadOnly = true;
            txtQuantityData.Width = 101;
            // 
            // txtStatusData
            // 
            txtStatusData.HeaderText = "Status";
            txtStatusData.MinimumWidth = 6;
            txtStatusData.Name = "txtStatusData";
            txtStatusData.ReadOnly = true;
            txtStatusData.Width = 84;
            // 
            // grpNewRequest
            // 
            grpNewRequest.BackColor = Color.White;
            grpNewRequest.Controls.Add(lbl_ConfirmationName);
            grpNewRequest.Controls.Add(cbo_ConfirmationName);
            grpNewRequest.Controls.Add(lbl_Quantity);
            grpNewRequest.Controls.Add(cbo_Quantity);
            grpNewRequest.Controls.Add(btn_Add);
            grpNewRequest.Dock = DockStyle.Top;
            grpNewRequest.Font = new Font("Segoe UI Semibold", 9.5F);
            grpNewRequest.ForeColor = Color.FromArgb(10, 61, 120);
            grpNewRequest.Location = new Point(20, 16);
            grpNewRequest.Name = "grpNewRequest";
            grpNewRequest.Size = new Size(920, 140);
            grpNewRequest.TabIndex = 1;
            grpNewRequest.TabStop = false;
            grpNewRequest.Text = "New Request Details";
            // 
            // lbl_ConfirmationName
            // 
            lbl_ConfirmationName.Font = new Font("Segoe UI", 9.5F);
            lbl_ConfirmationName.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_ConfirmationName.Location = new Point(24, 38);
            lbl_ConfirmationName.Name = "lbl_ConfirmationName";
            lbl_ConfirmationName.Size = new Size(140, 20);
            lbl_ConfirmationName.TabIndex = 0;
            lbl_ConfirmationName.Text = "Document Name:";
            // 
            // cbo_ConfirmationName
            // 
            cbo_ConfirmationName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_ConfirmationName.Font = new Font("Segoe UI", 9.5F);
            cbo_ConfirmationName.Location = new Point(180, 34);
            cbo_ConfirmationName.Name = "cbo_ConfirmationName";
            cbo_ConfirmationName.Size = new Size(320, 29);
            cbo_ConfirmationName.TabIndex = 1;
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.Font = new Font("Segoe UI", 9.5F);
            lbl_Quantity.ForeColor = Color.FromArgb(80, 80, 90);
            lbl_Quantity.Location = new Point(24, 82);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(140, 20);
            lbl_Quantity.TabIndex = 2;
            lbl_Quantity.Text = "Quantity:";
            // 
            // cbo_Quantity
            // 
            cbo_Quantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Quantity.Font = new Font("Segoe UI", 9.5F);
            cbo_Quantity.Location = new Point(180, 78);
            cbo_Quantity.Name = "cbo_Quantity";
            cbo_Quantity.Size = new Size(120, 29);
            cbo_Quantity.TabIndex = 3;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(10, 61, 120);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI Semibold", 9.5F);
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(520, 33);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(150, 75);
            btn_Add.TabIndex = 4;
            btn_Add.Text = "✚  Submit Request";
            btn_Add.UseVisualStyleBackColor = false;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 586);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(960, 68);
            pnlBottom.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(24, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 21);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Requests: 0";
            // 
            // pnlPagination
            // 
            pnlPagination.Controls.Add(cboPageSize);
            pnlPagination.Controls.Add(btnFirst);
            pnlPagination.Controls.Add(btnPrev);
            pnlPagination.Controls.Add(lblPageInfo);
            pnlPagination.Controls.Add(btnNext);
            pnlPagination.Controls.Add(btnLast);
            pnlPagination.Dock = DockStyle.Right;
            pnlPagination.Location = new Point(556, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 44);
            pnlPagination.TabIndex = 1;
            // 
            // cboPageSize
            // 
            cboPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPageSize.Font = new Font("Segoe UI", 9.5F);
            cboPageSize.Location = new Point(10, 19);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(60, 29);
            cboPageSize.TabIndex = 0;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Segoe UI", 9F);
            btnFirst.BackColor = Color.White;
            btnFirst.ForeColor = Color.FromArgb(60, 70, 85);
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnFirst.Cursor = Cursors.Hand;
            btnFirst.Location = new Point(80, 17);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(36, 32);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "|◀";
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Segoe UI", 9F);
            btnPrev.BackColor = Color.White;
            btnPrev.ForeColor = Color.FromArgb(60, 70, 85);
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.Location = new Point(120, 17);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◀";
            // 
            // lblPageInfo
            // 
            lblPageInfo.Font = new Font("Segoe UI", 9.5F);
            lblPageInfo.Location = new Point(162, 22);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(120, 20);
            lblPageInfo.TabIndex = 3;
            lblPageInfo.Text = "Page 1 of 1";
            lblPageInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.BackColor = Color.White;
            btnNext.ForeColor = Color.FromArgb(60, 70, 85);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnNext.Cursor = Cursors.Hand;
            btnNext.Location = new Point(290, 17);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 32);
            btnNext.TabIndex = 4;
            btnNext.Text = "▶";
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Segoe UI", 9F);
            btnLast.BackColor = Color.White;
            btnLast.ForeColor = Color.FromArgb(60, 70, 85);
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 215);
            btnLast.Cursor = Cursors.Hand;
            btnLast.Location = new Point(330, 17);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 32);
            btnLast.TabIndex = 5;
            btnLast.Text = "▶|";
            // 
            // f_Request
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 654);
            Controls.Add(pnlBody);
            Controls.Add(pnlBottom);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_Request";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmation Request Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            grpRequestList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpNewRequest.ResumeLayout(false);
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox grpNewRequest;
        private System.Windows.Forms.Label lbl_ConfirmationName;
        private System.Windows.Forms.ComboBox cbo_ConfirmationName;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.ComboBox cbo_Quantity;
        private System.Windows.Forms.Button btn_Add;

        private System.Windows.Forms.GroupBox grpRequestList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtConfirmationNameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQueueNumberData;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantityData;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatusData;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.ComboBox cboPageSize;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPageInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}