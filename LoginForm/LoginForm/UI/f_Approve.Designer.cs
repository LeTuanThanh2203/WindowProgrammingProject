namespace LoginForm
{
    partial class f_Approve
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
            dataGridView_AcceptUser = new DataGridView();
            RegisterID = new DataGridViewTextBoxColumn();
            RegisterName = new DataGridViewTextBoxColumn();
            RegisterRole = new DataGridViewComboBoxColumn();
            RegisterCancel = new DataGridViewButtonColumn();
            RegisterAcp = new DataGridViewButtonColumn();
            bt_ApplyAcc = new Button();
            bt_UnlockAcc = new Button();
            bt_Quit = new Button();
            dataGridView_UnlockAcc = new DataGridView();
            txt_ID = new DataGridViewTextBoxColumn();
            txt_Name = new DataGridViewTextBoxColumn();
            txt_Role = new DataGridViewTextBoxColumn();
            bt_Unlock = new DataGridViewButtonColumn();
            bt_Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AcceptUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_UnlockAcc).BeginInit();
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
            dataGridView_AcceptUser.Size = new Size(684, 226);
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
            // bt_Quit
            // 
            bt_Quit.Location = new Point(12, 414);
            bt_Quit.Name = "bt_Quit";
            bt_Quit.Size = new Size(91, 33);
            bt_Quit.TabIndex = 3;
            bt_Quit.Text = "Quit";
            bt_Quit.UseVisualStyleBackColor = true;
            bt_Quit.Click += bt_Quit_Click;
            // 
            // dataGridView_UnlockAcc
            // 
            dataGridView_UnlockAcc.BackgroundColor = Color.White;
            dataGridView_UnlockAcc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_UnlockAcc.Columns.AddRange(new DataGridViewColumn[] { txt_ID, txt_Name, txt_Role, bt_Unlock, bt_Delete });
            dataGridView_UnlockAcc.Location = new Point(114, 12);
            dataGridView_UnlockAcc.Name = "dataGridView_UnlockAcc";
            dataGridView_UnlockAcc.RowHeadersWidth = 51;
            dataGridView_UnlockAcc.Size = new Size(684, 226);
            dataGridView_UnlockAcc.TabIndex = 4; dataGridView_UnlockAcc.CellContentClick +=
    dataGridView_UnlockAcc_CellContentClick;
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
            // Approve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_UnlockAcc);
            Controls.Add(bt_Quit);
            Controls.Add(bt_UnlockAcc);
            Controls.Add(bt_ApplyAcc);
            Controls.Add(dataGridView_AcceptUser);
            Name = "Approve";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_AcceptUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_UnlockAcc).EndInit();
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
        private Button bt_Quit;
        private DataGridView dataGridView_UnlockAcc;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_Name;
        private DataGridViewTextBoxColumn txt_Role;
        private DataGridViewButtonColumn bt_Unlock;
        private DataGridViewButtonColumn bt_Delete;
    }
}