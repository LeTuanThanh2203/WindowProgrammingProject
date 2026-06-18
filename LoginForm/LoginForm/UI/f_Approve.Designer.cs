namespace LoginForm
{
    partial class f_Approve
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
            pnlSidebar = new Panel();
            bt_ApplyAcc = new Button();
            bt_UnlockAcc = new Button();
            btn_ConfirmationRequest = new Button();
            pnlGrid = new Panel();
            dataGridView_AcceptUser = new DataGridView();
            RegisterID = new DataGridViewTextBoxColumn();
            RegisterName = new DataGridViewTextBoxColumn();
            RegisterRole = new DataGridViewComboBoxColumn();
            RegisterCancel = new DataGridViewButtonColumn();
            RegisterAcp = new DataGridViewButtonColumn();
            dataGridView_UnlockAcc = new DataGridView();
            txt_ID = new DataGridViewTextBoxColumn();
            txt_Name = new DataGridViewTextBoxColumn();
            txt_Role = new DataGridViewTextBoxColumn();
            bt_Unlock = new DataGridViewButtonColumn();
            bt_Delete = new DataGridViewButtonColumn();
            dataGridView_ConfirmationRequest = new DataGridView();
            txt_ = new DataGridViewTextBoxColumn();
            txt_ConfirmationName = new DataGridViewTextBoxColumn();
            txt_Quantity = new DataGridViewTextBoxColumn();
            btn_AcpRequest = new DataGridViewButtonColumn();
            btn_DeleteRequest = new DataGridViewButtonColumn();
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
            pnlSidebar.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AcceptUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_UnlockAcc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ConfirmationRequest).BeginInit();
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
            pnlHeader.Size = new Size(1130, 80);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Access & Request Approval";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 210, 240);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(600, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage user registrations, locked accounts, and document requests";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(bt_ApplyAcc);
            pnlSidebar.Controls.Add(bt_UnlockAcc);
            pnlSidebar.Controls.Add(btn_ConfirmationRequest);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 80);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(16, 20, 16, 20);
            pnlSidebar.Size = new Size(240, 553);
            pnlSidebar.TabIndex = 2;
            // 
            // bt_ApplyAcc
            // 
            bt_ApplyAcc.Location = new Point(16, 20);
            bt_ApplyAcc.Name = "bt_ApplyAcc";
            bt_ApplyAcc.Size = new Size(208, 48);
            bt_ApplyAcc.TabIndex = 0;
            bt_ApplyAcc.Text = "✓  Apply Account";
            bt_ApplyAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            bt_ApplyAcc.BackColor = System.Drawing.Color.White;
            bt_ApplyAcc.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            bt_ApplyAcc.FlatStyle = FlatStyle.Flat;
            bt_ApplyAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 224, 230);
            bt_ApplyAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            bt_ApplyAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            bt_ApplyAcc.Click += bt_ApplyAcc_Click;
            // 
            // bt_UnlockAcc
            // 
            bt_UnlockAcc.Location = new Point(16, 80);
            bt_UnlockAcc.Name = "bt_UnlockAcc";
            bt_UnlockAcc.Size = new Size(208, 48);
            bt_UnlockAcc.TabIndex = 1;
            bt_UnlockAcc.Text = "🔓  Unlock Account";
            bt_UnlockAcc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            bt_UnlockAcc.BackColor = System.Drawing.Color.White;
            bt_UnlockAcc.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            bt_UnlockAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_UnlockAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 224, 230);
            bt_UnlockAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            bt_UnlockAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            bt_UnlockAcc.Click += bt_UnlockAcc_Click;
            // 
            // btn_ConfirmationRequest
            // 
            btn_ConfirmationRequest.Location = new Point(16, 140);
            btn_ConfirmationRequest.Name = "btn_ConfirmationRequest";
            btn_ConfirmationRequest.Size = new Size(208, 48);
            btn_ConfirmationRequest.TabIndex = 2;
            btn_ConfirmationRequest.Text = "📝  Document Requests";
            btn_ConfirmationRequest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            btn_ConfirmationRequest.BackColor = System.Drawing.Color.White;
            btn_ConfirmationRequest.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btn_ConfirmationRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ConfirmationRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 224, 230);
            btn_ConfirmationRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_ConfirmationRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_ConfirmationRequest.Click += btn_ConfirmationRequest_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(245, 247, 250);
            pnlGrid.Controls.Add(dataGridView_AcceptUser);
            pnlGrid.Controls.Add(dataGridView_UnlockAcc);
            pnlGrid.Controls.Add(dataGridView_ConfirmationRequest);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(240, 80);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(16);
            pnlGrid.Size = new Size(890, 475);
            pnlGrid.TabIndex = 0;
            // 
            // dataGridView_AcceptUser
            // 
            dataGridView_AcceptUser.AllowUserToResizeColumns = false;
            dataGridView_AcceptUser.AllowUserToResizeRows = false;
            dataGridView_AcceptUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_AcceptUser.ColumnHeadersHeight = 29;
            dataGridView_AcceptUser.Columns.AddRange(new DataGridViewColumn[] { RegisterID, RegisterName, RegisterRole, RegisterCancel, RegisterAcp });
            dataGridView_AcceptUser.Dock = DockStyle.Fill;
            dataGridView_AcceptUser.Location = new Point(16, 16);
            dataGridView_AcceptUser.Name = "dataGridView_AcceptUser";
            dataGridView_AcceptUser.RowHeadersWidth = 51;
            dataGridView_AcceptUser.Size = new Size(858, 443);
            dataGridView_AcceptUser.TabIndex = 0;
            dataGridView_AcceptUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RegisterID
            // 
            RegisterID.HeaderText = "ID";
            RegisterID.MinimumWidth = 6;
            RegisterID.Name = "RegisterID";
            RegisterID.ReadOnly = true;
            RegisterID.Width = 54;
            // 
            // RegisterName
            // 
            RegisterName.HeaderText = "Name";
            RegisterName.MinimumWidth = 6;
            RegisterName.Name = "RegisterName";
            RegisterName.ReadOnly = true;
            RegisterName.Width = 81;
            // 
            // RegisterRole
            // 
            RegisterRole.HeaderText = "Role";
            RegisterRole.MinimumWidth = 6;
            RegisterRole.Name = "RegisterRole";
            RegisterRole.Width = 47;
            // 
            // RegisterCancel
            // 
            RegisterCancel.HeaderText = "Reject";
            RegisterCancel.MinimumWidth = 6;
            RegisterCancel.Name = "RegisterCancel";
            RegisterCancel.Text = "Reject";
            RegisterCancel.UseColumnTextForButtonValue = true;
            RegisterCancel.Width = 58;
            // 
            // RegisterAcp
            // 
            RegisterAcp.HeaderText = "Approve";
            RegisterAcp.MinimumWidth = 6;
            RegisterAcp.Name = "RegisterAcp";
            RegisterAcp.Text = "Approve";
            RegisterAcp.UseColumnTextForButtonValue = true;
            RegisterAcp.Width = 75;
            // 
            // dataGridView_UnlockAcc
            // 
            dataGridView_UnlockAcc.ColumnHeadersHeight = 29;
            dataGridView_UnlockAcc.Columns.AddRange(new DataGridViewColumn[] { txt_ID, txt_Name, txt_Role, bt_Unlock, bt_Delete });
            dataGridView_UnlockAcc.Dock = DockStyle.Fill;
            dataGridView_UnlockAcc.Location = new Point(16, 16);
            dataGridView_UnlockAcc.Name = "dataGridView_UnlockAcc";
            dataGridView_UnlockAcc.RowHeadersWidth = 51;
            dataGridView_UnlockAcc.Size = new Size(858, 443);
            dataGridView_UnlockAcc.TabIndex = 1;
            dataGridView_UnlockAcc.CellContentClick += dataGridView_UnlockAcc_CellContentClick;
            // 
            // txt_ID
            // 
            txt_ID.HeaderText = "ID";
            txt_ID.MinimumWidth = 6;
            txt_ID.Name = "txt_ID";
            txt_ID.ReadOnly = true;
            txt_ID.Width = 125;
            // 
            // txt_Name
            // 
            txt_Name.HeaderText = "Name";
            txt_Name.MinimumWidth = 6;
            txt_Name.Name = "txt_Name";
            txt_Name.ReadOnly = true;
            txt_Name.Width = 125;
            // 
            // txt_Role
            // 
            txt_Role.HeaderText = "Role";
            txt_Role.MinimumWidth = 6;
            txt_Role.Name = "txt_Role";
            txt_Role.ReadOnly = true;
            txt_Role.Width = 125;
            // 
            // bt_Unlock
            // 
            bt_Unlock.HeaderText = "Unlock";
            bt_Unlock.MinimumWidth = 6;
            bt_Unlock.Name = "bt_Unlock";
            bt_Unlock.Text = "Unlock";
            bt_Unlock.UseColumnTextForButtonValue = true;
            bt_Unlock.Width = 125;
            // 
            // bt_Delete
            // 
            bt_Delete.HeaderText = "Delete";
            bt_Delete.MinimumWidth = 6;
            bt_Delete.Name = "bt_Delete";
            bt_Delete.Text = "Delete";
            bt_Delete.UseColumnTextForButtonValue = true;
            bt_Delete.Width = 125;
            // 
            // dataGridView_ConfirmationRequest
            // 
            dataGridView_ConfirmationRequest.ColumnHeadersHeight = 29;
            dataGridView_ConfirmationRequest.Columns.AddRange(new DataGridViewColumn[] { txt_, txt_ConfirmationName, txt_Quantity, btn_AcpRequest, btn_DeleteRequest });
            dataGridView_ConfirmationRequest.Dock = DockStyle.Fill;
            dataGridView_ConfirmationRequest.Location = new Point(16, 16);
            dataGridView_ConfirmationRequest.Name = "dataGridView_ConfirmationRequest";
            dataGridView_ConfirmationRequest.RowHeadersWidth = 51;
            dataGridView_ConfirmationRequest.Size = new Size(858, 443);
            dataGridView_ConfirmationRequest.TabIndex = 2;
            dataGridView_ConfirmationRequest.CellContentClick += dataGridView_ConfirmationRequest_CellContentClick;
            // 
            // txt_
            // 
            txt_.HeaderText = "MSSV";
            txt_.MinimumWidth = 6;
            txt_.Name = "txt_";
            txt_.ReadOnly = true;
            txt_.Width = 125;
            // 
            // txt_ConfirmationName
            // 
            txt_ConfirmationName.HeaderText = "Document Name";
            txt_ConfirmationName.MinimumWidth = 6;
            txt_ConfirmationName.Name = "txt_ConfirmationName";
            txt_ConfirmationName.ReadOnly = true;
            txt_ConfirmationName.Width = 125;
            // 
            // txt_Quantity
            // 
            txt_Quantity.HeaderText = "Quantity";
            txt_Quantity.MinimumWidth = 6;
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.ReadOnly = true;
            txt_Quantity.Width = 125;
            // 
            // btn_AcpRequest
            // 
            btn_AcpRequest.HeaderText = "Approve";
            btn_AcpRequest.MinimumWidth = 6;
            btn_AcpRequest.Name = "btn_AcpRequest";
            btn_AcpRequest.Text = "Approve";
            btn_AcpRequest.UseColumnTextForButtonValue = true;
            btn_AcpRequest.Width = 125;
            // 
            // btn_DeleteRequest
            // 
            btn_DeleteRequest.HeaderText = "Delete";
            btn_DeleteRequest.MinimumWidth = 6;
            btn_DeleteRequest.Name = "btn_DeleteRequest";
            btn_DeleteRequest.Text = "Delete";
            btn_DeleteRequest.UseColumnTextForButtonValue = true;
            btn_DeleteRequest.Width = 125;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(lblTotal);
            pnlBottom.Controls.Add(pnlPagination);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(240, 555);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(24, 12, 24, 12);
            pnlBottom.Size = new Size(890, 78);
            pnlBottom.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.ForeColor = Color.FromArgb(80, 80, 90);
            lblTotal.Location = new Point(24, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 21);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Records: 0";
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
            pnlPagination.Location = new Point(486, 12);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(380, 54);
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
            btnFirst.Location = new Point(80, 17);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(36, 32);
            btnFirst.TabIndex = 1;
            btnFirst.Text = "|◀";
            btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnFirst.BackColor = System.Drawing.Color.White;
            btnFirst.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(120, 17);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 32);
            btnPrev.TabIndex = 2;
            btnPrev.Text = "◀";
            btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnPrev.BackColor = System.Drawing.Color.White;
            btnPrev.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
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
            btnNext.Location = new Point(290, 17);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 32);
            btnNext.TabIndex = 4;
            btnNext.Text = "▶";
            btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnNext.BackColor = System.Drawing.Color.White;
            btnNext.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(330, 17);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 32);
            btnLast.TabIndex = 5;
            btnLast.Text = "▶|";
            btnLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnLast.BackColor = System.Drawing.Color.White;
            btnLast.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85);
            btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 205, 215);
            btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // f_Approve
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 633);
            Controls.Add(pnlGrid);
            Controls.Add(pnlBottom);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F);
            Name = "f_Approve";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Access & Request Approval Dashboard";
            pnlHeader.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AcceptUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_UnlockAcc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ConfirmationRequest).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlPagination.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button bt_ApplyAcc;
        private System.Windows.Forms.Button bt_UnlockAcc;
        private System.Windows.Forms.Button btn_ConfirmationRequest;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dataGridView_AcceptUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterName;
        private System.Windows.Forms.DataGridViewComboBoxColumn RegisterRole;
        private System.Windows.Forms.DataGridViewButtonColumn RegisterCancel;
        private System.Windows.Forms.DataGridViewButtonColumn RegisterAcp;

        private System.Windows.Forms.DataGridView dataGridView_UnlockAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Role;
        private System.Windows.Forms.DataGridViewButtonColumn bt_Unlock;
        private System.Windows.Forms.DataGridViewButtonColumn bt_Delete;

        private System.Windows.Forms.DataGridView dataGridView_ConfirmationRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_ConfirmationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn btn_AcpRequest;
        private System.Windows.Forms.DataGridViewButtonColumn btn_DeleteRequest;

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