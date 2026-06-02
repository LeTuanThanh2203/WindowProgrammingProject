namespace Project_Group6
{
    partial class f_Request
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
            cbo_ConfirmationName = new ComboBox();
            lbl_ConfirmationName = new Label();
            cbo_Quantity = new ComboBox();
            lbl_Quantity = new Label();
            btn_Add = new Button();
            dataGridView1 = new DataGridView();
            txtConfirmationNameData = new DataGridViewTextBoxColumn();
            txtQueueNumberData = new DataGridViewTextBoxColumn();
            txtQuantityData = new DataGridViewTextBoxColumn();
            txtStatusData = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbo_ConfirmationName
            // 
            cbo_ConfirmationName.FormattingEnabled = true;
            cbo_ConfirmationName.Location = new Point(207, 99);
            cbo_ConfirmationName.Name = "cbo_ConfirmationName";
            cbo_ConfirmationName.Size = new Size(419, 28);
            cbo_ConfirmationName.TabIndex = 66;
            // 
            // lbl_ConfirmationName
            // 
            lbl_ConfirmationName.AutoSize = true;
            lbl_ConfirmationName.Location = new Point(49, 99);
            lbl_ConfirmationName.Name = "lbl_ConfirmationName";
            lbl_ConfirmationName.Size = new Size(140, 20);
            lbl_ConfirmationName.TabIndex = 65;
            lbl_ConfirmationName.Text = "Confirmation Name";
            // 
            // cbo_Quantity
            // 
            cbo_Quantity.FormattingEnabled = true;
            cbo_Quantity.Location = new Point(207, 157);
            cbo_Quantity.Name = "cbo_Quantity";
            cbo_Quantity.Size = new Size(419, 28);
            cbo_Quantity.TabIndex = 68;
            // 
            // lbl_Quantity
            // 
            lbl_Quantity.AutoSize = true;
            lbl_Quantity.Location = new Point(49, 165);
            lbl_Quantity.Name = "lbl_Quantity";
            lbl_Quantity.Size = new Size(65, 20);
            lbl_Quantity.TabIndex = 67;
            lbl_Quantity.Text = "Quantity";
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(669, 153);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(127, 44);
            btn_Add.TabIndex = 69;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtConfirmationNameData, txtQueueNumberData, txtQuantityData, txtStatusData });
            dataGridView1.Location = new Point(55, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(793, 309);
            dataGridView1.TabIndex = 70;
            // 
            // txtConfirmationNameData
            // 
            txtConfirmationNameData.HeaderText = "Confirmation Name";
            txtConfirmationNameData.MinimumWidth = 6;
            txtConfirmationNameData.Name = "txtConfirmationNameData";
            txtConfirmationNameData.ReadOnly = true;
            txtConfirmationNameData.Width = 125;
            // 
            // txtQueueNumberData
            // 
            txtQueueNumberData.HeaderText = "Queue Number";
            txtQueueNumberData.MinimumWidth = 6;
            txtQueueNumberData.Name = "txtQueueNumberData";
            txtQueueNumberData.ReadOnly = true;
            txtQueueNumberData.Width = 125;
            // 
            // txtQuantityData
            // 
            txtQuantityData.HeaderText = "Quantity";
            txtQuantityData.MinimumWidth = 6;
            txtQuantityData.Name = "txtQuantityData";
            txtQuantityData.ReadOnly = true;
            txtQuantityData.Width = 125;
            // 
            // txtStatusData
            // 
            txtStatusData.HeaderText = "Status";
            txtStatusData.MinimumWidth = 6;
            txtStatusData.Name = "txtStatusData";
            txtStatusData.ReadOnly = true;
            txtStatusData.Width = 125;
            // 
            // f_Request
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 654);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Add);
            Controls.Add(cbo_Quantity);
            Controls.Add(lbl_Quantity);
            Controls.Add(cbo_ConfirmationName);
            Controls.Add(lbl_ConfirmationName);
            Name = "f_Request";
            Text = "f_Request";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbo_ConfirmationName;
        private Label lbl_ConfirmationName;
        private ComboBox cbo_Quantity;
        private Label lbl_Quantity;
        private Button btn_Add;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn txtConfirmationNameData;
        private DataGridViewTextBoxColumn txtQueueNumberData;
        private DataGridViewTextBoxColumn txtQuantityData;
        private DataGridViewTextBoxColumn txtStatusData;
    }
}