namespace LoginForm
{
    partial class f_Main
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
            pnSidebar = new Panel();
            btnOverview = new Button();
            pnMenu = new Panel();
            lblRole = new Label();
            lblUser = new Label();
            btnApprove = new Button();
            btnStudent = new Button();
            pnLogo = new Panel();
            pnBody = new Panel();
            pnSidebar.SuspendLayout();
            pnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnSidebar
            // 
            pnSidebar.Controls.Add(btnOverview);
            pnSidebar.Controls.Add(pnMenu);
            pnSidebar.Controls.Add(pnLogo);
            pnSidebar.Dock = DockStyle.Left;
            pnSidebar.Location = new Point(0, 0);
            pnSidebar.Name = "pnSidebar";
            pnSidebar.Size = new Size(311, 775);
            pnSidebar.TabIndex = 0;
            // 
            // btnOverview
            // 
            btnOverview.BackColor = Color.Transparent;
            btnOverview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOverview.ForeColor = Color.Black;
            btnOverview.Location = new Point(6, 190);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(298, 81);
            btnOverview.TabIndex = 0;
            btnOverview.Text = "Overview";
            btnOverview.UseVisualStyleBackColor = false;
            btnOverview.Click += btnOverview_Click;
            // 
            // pnMenu
            // 
            pnMenu.Controls.Add(lblRole);
            pnMenu.Controls.Add(lblUser);
            pnMenu.Controls.Add(btnApprove);
            pnMenu.Controls.Add(btnStudent);
            pnMenu.Location = new Point(3, 190);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(304, 582);
            pnMenu.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(11, 522);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(62, 28);
            lblRole.TabIndex = 1;
            lblRole.Text = "Role: ";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(11, 494);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 28);
            lblUser.TabIndex = 0;
            lblUser.Text = "User: ";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Transparent;
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.ForeColor = Color.Black;
            btnApprove.Location = new Point(0, 174);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(301, 81);
            btnApprove.TabIndex = 3;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.Black;
            btnStudent.Location = new Point(0, 87);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(301, 81);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // pnLogo
            // 
            pnLogo.Location = new Point(3, 3);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(301, 181);
            pnLogo.TabIndex = 0;
            // 
            // pnBody
            // 
            pnBody.Dock = DockStyle.Right;
            pnBody.Location = new Point(313, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1169, 775);
            pnBody.TabIndex = 1;
            // 
            // f_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 775);
            Controls.Add(pnBody);
            Controls.Add(pnSidebar);
            Name = "f_Main";
            Text = "f_Main";
            Load += f_Main_Load;
            pnSidebar.ResumeLayout(false);
            pnMenu.ResumeLayout(false);
            pnMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnSidebar;
        private Button btnOverview;
        private Panel pnMenu;
        private Panel pnLogo;
        private Panel pnBody;
        private Button btnApprove;
        private Button btnStudent;
        private Label lblRole;
        private Label lblUser;
    }
}