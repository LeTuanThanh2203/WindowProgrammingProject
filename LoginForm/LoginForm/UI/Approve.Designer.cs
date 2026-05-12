namespace LoginForm
{
    partial class Approve
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
            AcceptUser = new DataGridView();
            RegisterID = new DataGridViewTextBoxColumn();
            RegisterName = new DataGridViewTextBoxColumn();
            RegisterRole = new DataGridViewComboBoxColumn();
            RegisterCancel = new DataGridViewButtonColumn();
            RegisterAcp = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)AcceptUser).BeginInit();
            SuspendLayout();
            // 
            // AcceptUser
            // 
            AcceptUser.BackgroundColor = Color.White;
            AcceptUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AcceptUser.Columns.AddRange(new DataGridViewColumn[] { RegisterID, RegisterName, RegisterRole, RegisterCancel, RegisterAcp });
            AcceptUser.Location = new Point(12, 12);
            AcceptUser.Name = "AcceptUser";
            AcceptUser.RowHeadersWidth = 51;
            AcceptUser.Size = new Size(684, 439);
            AcceptUser.TabIndex = 0;
            AcceptUser.CellContentClick += this.dataGridView1_CellContentClick;
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
            RegisterCancel.Width = 125;
            RegisterCancel.UseColumnTextForButtonValue = true;
            // 
            // RegisterAcp
            // 
            RegisterAcp.HeaderText = "Accept";
            RegisterAcp.MinimumWidth = 6;
            RegisterAcp.Name = "RegisterAcp";
            RegisterAcp.Text = "Acp";
            RegisterAcp.Width = 125;
            RegisterAcp.UseColumnTextForButtonValue = true;
            // 
            // Approve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AcceptUser);
            Name = "Approve";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AcceptUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AcceptUser;
        private DataGridViewTextBoxColumn RegisterID;
        private DataGridViewTextBoxColumn RegisterName;
        private DataGridViewComboBoxColumn RegisterRole;
        private DataGridViewButtonColumn RegisterCancel;
        private DataGridViewButtonColumn RegisterAcp;
    }
}