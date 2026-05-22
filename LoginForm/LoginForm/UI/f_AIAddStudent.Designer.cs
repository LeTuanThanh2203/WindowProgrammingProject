namespace Project_Group6.UI
{
    partial class f_AIAddStudent
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
            btnCapture = new Button();
            btnStartCamera = new Button();
            cboCamera = new ComboBox();
            picCamera = new PictureBox();
            picCard = new PictureBox();
            btnUpload = new Button();
            btnCancel = new Button();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard).BeginInit();
            SuspendLayout();
            // 
            // btnCapture
            // 
            btnCapture.Location = new Point(703, 379);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(108, 44);
            btnCapture.TabIndex = 37;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // btnStartCamera
            // 
            btnStartCamera.Location = new Point(550, 379);
            btnStartCamera.Name = "btnStartCamera";
            btnStartCamera.Size = new Size(108, 44);
            btnStartCamera.TabIndex = 36;
            btnStartCamera.Text = "Start Camera";
            btnStartCamera.UseVisualStyleBackColor = true;
            btnStartCamera.Click += btnStartCamera_Click;
            // 
            // cboCamera
            // 
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new Point(612, 131);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new Size(137, 28);
            cboCamera.TabIndex = 35;
            // 
            // picCamera
            // 
            picCamera.Location = new Point(485, 176);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(378, 197);
            picCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            picCamera.TabIndex = 34;
            picCamera.TabStop = false;
            // 
            // picCard
            // 
            picCard.Location = new Point(75, 176);
            picCard.Name = "picCard";
            picCard.Size = new Size(378, 197);
            picCard.SizeMode = PictureBoxSizeMode.StretchImage;
            picCard.TabIndex = 33;
            picCard.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(220, 379);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(108, 44);
            btnUpload.TabIndex = 32;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(755, 454);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 44);
            btnCancel.TabIndex = 31;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(641, 454);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(108, 44);
            btnConfirm.TabIndex = 38;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // f_AIAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 510);
            Controls.Add(btnConfirm);
            Controls.Add(btnCapture);
            Controls.Add(btnStartCamera);
            Controls.Add(cboCamera);
            Controls.Add(picCamera);
            Controls.Add(picCard);
            Controls.Add(btnUpload);
            Controls.Add(btnCancel);
            Name = "f_AIAddStudent";
            Text = "Camera";
            FormClosing += f_AIScan_FormClosing;
            Load += f_AIScan_Load;
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCapture;
        private Button btnStartCamera;
        private ComboBox cboCamera;
        private PictureBox picCamera;
        private PictureBox picCard;
        private Button btnUpload;
        private Button btnCancel;
        private Button btnConfirm;
    }
}