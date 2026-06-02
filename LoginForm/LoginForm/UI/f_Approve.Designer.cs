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
            dataGridView_AcceptUser = new DataGridView();
            RegisterID = new DataGridViewTextBoxColumn();
            RegisterName = new DataGridViewTextBoxColumn();
            RegisterRole = new DataGridViewComboBoxColumn();
            RegisterCancel = new DataGridViewButtonColumn();
            RegisterAcp = new DataGridViewButtonColumn();
            bt_ApplyAcc = new Button();
            bt_UnlockAcc = new Button();
            dataGridView_UnlockAcc = new DataGridView();
            txt_ID = new DataGridViewTextBoxColumn();
            txt_Name = new DataGridViewTextBoxColumn();
            txt_Role = new DataGridViewTextBoxColumn();
            bt_Unlock = new DataGridViewButtonColumn();
            bt_Delete = new DataGridViewButtonColumn();
            dataGridView_ConfirmationRequest = new DataGridView();
            btn_ConfirmationRequest = new Button();
            txt_ = new DataGridViewTextBoxColumn();
            txt_ConfirmationName = new DataGridViewTextBoxColumn();
            txt_Quantity = new DataGridViewTextBoxColumn();
            btn_AcpRequest = new DataGridViewButtonColumn();
            btn_DeleteRequest = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AcceptUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_UnlockAcc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ConfirmationRequest).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_AcceptUser
            // 
            dataGridView_AcceptUser.BackgroundColor = Color.White;
            dataGridView_AcceptUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AcceptUser.Columns.AddRange(new DataGridViewColumn[] { RegisterID, RegisterName, RegisterRole, RegisterCancel, RegisterAcp });
            dataGridView_AcceptUser.Location = new Point(114, 12);
            dataGridView_AcceptUser.Name = "dataGridView_AcceptUser";
            dataGridView_AcceptUser.RowHeadersWidth = 51;
            dataGridView_AcceptUser.Size = new Size(699, 258);
            dataGridView_AcceptUser.TabIndex = 0;
            dataGridView_AcceptUser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RegisterID
            // 
            RegisterID.HeaderText = "ID";
            RegisterID.MinimumWidth = 6;
            RegisterID.Name = "RegisterID";
            RegisterID.ReadOnly = true;
            RegisterID.Width = 125;
            // 
            // RegisterName
            // 
            RegisterName.HeaderText = "Name";
            RegisterName.MinimumWidth = 6;
            RegisterName.Name = "RegisterName";
            RegisterName.ReadOnly = true;
            RegisterName.Width = 125;
            // 
            // RegisterRole
            // 
            RegisterRole.HeaderText = "Role";
            RegisterRole.MinimumWidth = 6;
            RegisterRole.Name = "RegisterRole";
            RegisterRole.Width = 125;
            // 
            // RegisterCancel
            // 
            RegisterCancel.HeaderText = "Cancel";
            RegisterCancel.MinimumWidth = 6;
            RegisterCancel.Name = "RegisterCancel";
            RegisterCancel.Text = "Cn";
            RegisterCancel.UseColumnTextForButtonValue = true;
            RegisterCancel.Width = 125;
            // 
            // RegisterAcp
            // 
            RegisterAcp.HeaderText = "Accept";
            RegisterAcp.MinimumWidth = 6;
            RegisterAcp.Name = "RegisterAcp";
            RegisterAcp.Text = "Acp";
            RegisterAcp.UseColumnTextForButtonValue = true;
            RegisterAcp.Width = 125;
            // 
            // bt_ApplyAcc
            // 
            bt_ApplyAcc.Location = new Point(12, 12);
            bt_ApplyAcc.Name = "bt_ApplyAcc";
            bt_ApplyAcc.Size = new Size(91, 94);
            bt_ApplyAcc.TabIndex = 1;
            bt_ApplyAcc.Text = "Apply Account";
            bt_ApplyAcc.UseVisualStyleBackColor = true;
            bt_ApplyAcc.Click += bt_ApplyAcc_Click;
            // 
            // bt_UnlockAcc
            // 
            bt_UnlockAcc.Location = new Point(12, 125);
            bt_UnlockAcc.Name = "bt_UnlockAcc";
            bt_UnlockAcc.Size = new Size(91, 94);
            bt_UnlockAcc.TabIndex = 2;
            bt_UnlockAcc.Text = "Unlock Account";
            bt_UnlockAcc.UseVisualStyleBackColor = true;
            bt_UnlockAcc.Click += bt_UnlockAcc_Click;
            // 
            // dataGridView_UnlockAcc
            // 
            dataGridView_UnlockAcc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_UnlockAcc.BackgroundColor = Color.White;
            dataGridView_UnlockAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_UnlockAcc.Columns.AddRange(new DataGridViewColumn[] { txt_ID, txt_Name, txt_Role, bt_Unlock, bt_Delete });
            dataGridView_UnlockAcc.Location = new Point(109, 12);
            dataGridView_UnlockAcc.Name = "dataGridView_UnlockAcc";
            dataGridView_UnlockAcc.RowHeadersWidth = 51;
            dataGridView_UnlockAcc.Size = new Size(704, 258);
            dataGridView_UnlockAcc.TabIndex = 4;
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
            bt_Unlock.HeaderText = "Unlock Account";
            bt_Unlock.MinimumWidth = 6;
            bt_Unlock.Name = "bt_Unlock";
            bt_Unlock.Text = "Unlock";
            bt_Unlock.Width = 125;
            // 
            // bt_Delete
            // 
            bt_Delete.HeaderText = "Delete Account";
            bt_Delete.MinimumWidth = 6;
            bt_Delete.Name = "bt_Delete";
            bt_Delete.Text = "Delete";
            bt_Delete.Width = 125;
            // 
            // dataGridView_ConfirmationRequest
            // 
            dataGridView_ConfirmationRequest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_ConfirmationRequest.BackgroundColor = Color.White;
            dataGridView_ConfirmationRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ConfirmationRequest.Columns.AddRange(new DataGridViewColumn[] { txt_, txt_ConfirmationName, txt_Quantity, btn_AcpRequest, btn_DeleteRequest });
            dataGridView_ConfirmationRequest.Location = new Point(109, 12);
            dataGridView_ConfirmationRequest.Name = "dataGridView_ConfirmationRequest";
            dataGridView_ConfirmationRequest.RowHeadersWidth = 51;
            dataGridView_ConfirmationRequest.Size = new Size(704, 258);
            dataGridView_ConfirmationRequest.TabIndex = 5;
            dataGridView_ConfirmationRequest.CellContentClick += dataGridView_ConfirmationRequest_CellContentClick;
            // 
            // btn_ConfirmationRequest
            // 
            btn_ConfirmationRequest.Location = new Point(12, 268);
            btn_ConfirmationRequest.Name = "btn_ConfirmationRequest";
            btn_ConfirmationRequest.Size = new Size(91, 88);
            btn_ConfirmationRequest.TabIndex = 6;
            btn_ConfirmationRequest.Text = "Confirmation Request";
            btn_ConfirmationRequest.UseVisualStyleBackColor = true;
            btn_ConfirmationRequest.Click += btn_ConfirmationRequest_Click;
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
            txt_ConfirmationName.HeaderText = "Name";
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
            btn_AcpRequest.HeaderText = "Accept";
            btn_AcpRequest.MinimumWidth = 6;
            btn_AcpRequest.Name = "btn_AcpRequest";
            btn_AcpRequest.Text = "Accept";
            btn_AcpRequest.Width = 125;
            // 
            // btn_DeleteRequest
            // 
            btn_DeleteRequest.HeaderText = "Delete";
            btn_DeleteRequest.MinimumWidth = 6;
            btn_DeleteRequest.Name = "btn_DeleteRequest";
            btn_DeleteRequest.Text = "Delete";
            btn_DeleteRequest.Width = 125;
            // 
            // f_Approve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1130, 633);
            Controls.Add(btn_ConfirmationRequest);
            Controls.Add(dataGridView_ConfirmationRequest);
            Controls.Add(dataGridView_UnlockAcc);
            Controls.Add(bt_UnlockAcc);
            Controls.Add(bt_ApplyAcc);
            Controls.Add(dataGridView_AcceptUser);
            Name = "f_Approve";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_AcceptUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_UnlockAcc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ConfirmationRequest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_AcceptUser;
        private DataGridViewTextBoxColumn RegisterID;
        private DataGridViewTextBoxColumn RegisterName;
        private DataGridViewComboBoxColumn RegisterRole;
        private DataGridViewButtonColumn RegisterCancel;
        private DataGridViewButtonColumn RegisterAcp;
        private Button bt_ApplyAcc;
        private Button bt_UnlockAcc;
        private DataGridView dataGridView_UnlockAcc;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_Name;
        private DataGridViewTextBoxColumn txt_Role;
        private DataGridViewButtonColumn bt_Unlock;
        private DataGridViewButtonColumn bt_Delete;
        private DataGridView dataGridView_ConfirmationRequest;
        private Button btn_ConfirmationRequest;
        private DataGridViewTextBoxColumn txt_;
        private DataGridViewTextBoxColumn txt_ConfirmationName;
        private DataGridViewTextBoxColumn txt_Quantity;
        private DataGridViewButtonColumn btn_AcpRequest;
        private DataGridViewButtonColumn btn_DeleteRequest;
    }
}