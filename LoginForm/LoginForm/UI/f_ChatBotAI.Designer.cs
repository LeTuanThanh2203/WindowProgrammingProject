namespace LoginForm
{
    partial class f_ChatBotAI
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            btnClearChat = new System.Windows.Forms.Button();
            btnCloseChat = new System.Windows.Forms.Button();
            pnChatArea = new System.Windows.Forms.Panel();
            flowChatMessages = new System.Windows.Forms.FlowLayoutPanel();
            pnSuggestions = new System.Windows.Forms.FlowLayoutPanel();
            pnInput = new System.Windows.Forms.Panel();
            txtInput = new System.Windows.Forms.TextBox();
            btnSend = new System.Windows.Forms.Button();
            lblTyping = new System.Windows.Forms.Label();
            pnHeader.SuspendLayout();
            pnChatArea.SuspendLayout();
            pnInput.SuspendLayout();
            SuspendLayout();

            // 
            // pnHeader
            // 
            pnHeader.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            pnHeader.Controls.Add(lblTitle);
            pnHeader.Controls.Add(btnClearChat);
            pnHeader.Controls.Add(btnCloseChat);
            pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnHeader.Location = new System.Drawing.Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new System.Drawing.Size(380, 50);
            pnHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(160, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🤖 AI Assistant";

            // 
            // btnClearChat
            // 
            btnClearChat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnClearChat.BackColor = System.Drawing.Color.Transparent;
            btnClearChat.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClearChat.FlatAppearance.BorderSize = 0;
            btnClearChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
            btnClearChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearChat.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnClearChat.ForeColor = System.Drawing.Color.White;
            btnClearChat.Location = new System.Drawing.Point(290, 5);
            btnClearChat.Name = "btnClearChat";
            btnClearChat.Size = new System.Drawing.Size(40, 40);
            btnClearChat.TabIndex = 1;
            btnClearChat.Text = "🗑";
            btnClearChat.UseVisualStyleBackColor = false;
            btnClearChat.Click += btnClearChat_Click;

            // 
            // btnCloseChat
            // 
            btnCloseChat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCloseChat.BackColor = System.Drawing.Color.Transparent;
            btnCloseChat.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCloseChat.FlatAppearance.BorderSize = 0;
            btnCloseChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnCloseChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCloseChat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnCloseChat.ForeColor = System.Drawing.Color.White;
            btnCloseChat.Location = new System.Drawing.Point(335, 5);
            btnCloseChat.Name = "btnCloseChat";
            btnCloseChat.Size = new System.Drawing.Size(40, 40);
            btnCloseChat.TabIndex = 2;
            btnCloseChat.Text = "✕";
            btnCloseChat.UseVisualStyleBackColor = false;
            btnCloseChat.Click += btnCloseChat_Click;

            // 
            // pnChatArea
            // 
            pnChatArea.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            pnChatArea.Controls.Add(flowChatMessages);
            pnChatArea.Dock = System.Windows.Forms.DockStyle.Fill;
            pnChatArea.Location = new System.Drawing.Point(0, 50);
            pnChatArea.Name = "pnChatArea";
            pnChatArea.Padding = new System.Windows.Forms.Padding(5);
            pnChatArea.Size = new System.Drawing.Size(380, 500);
            pnChatArea.TabIndex = 1;

            // 
            // flowChatMessages
            // 
            flowChatMessages.AutoScroll = true;
            flowChatMessages.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            flowChatMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            flowChatMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowChatMessages.Location = new System.Drawing.Point(5, 5);
            flowChatMessages.Name = "flowChatMessages";
            flowChatMessages.Padding = new System.Windows.Forms.Padding(5);
            flowChatMessages.Size = new System.Drawing.Size(370, 490);
            flowChatMessages.TabIndex = 0;
            flowChatMessages.WrapContents = false;

            // 
            // pnSuggestions
            // 
            pnSuggestions.AutoSize = false;
            pnSuggestions.BackColor = System.Drawing.Color.FromArgb(240, 242, 248);
            pnSuggestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnSuggestions.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            pnSuggestions.Location = new System.Drawing.Point(0, 510);
            pnSuggestions.Name = "pnSuggestions";
            pnSuggestions.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            pnSuggestions.Size = new System.Drawing.Size(380, 40);
            pnSuggestions.TabIndex = 3;
            pnSuggestions.WrapContents = false;

            // 
            // pnInput
            // 
            pnInput.BackColor = System.Drawing.Color.White;
            pnInput.Controls.Add(txtInput);
            pnInput.Controls.Add(btnSend);
            pnInput.Controls.Add(lblTyping);
            pnInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnInput.Location = new System.Drawing.Point(0, 550);
            pnInput.Name = "pnInput";
            pnInput.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            pnInput.Size = new System.Drawing.Size(380, 80);
            pnInput.TabIndex = 2;

            // 
            // lblTyping
            // 
            lblTyping.Dock = System.Windows.Forms.DockStyle.Top;
            lblTyping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblTyping.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            lblTyping.Location = new System.Drawing.Point(10, 5);
            lblTyping.Name = "lblTyping";
            lblTyping.Size = new System.Drawing.Size(360, 20);
            lblTyping.TabIndex = 2;
            lblTyping.Text = "";
            lblTyping.Visible = false;

            // 
            // txtInput
            // 
            txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            txtInput.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtInput.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtInput.Location = new System.Drawing.Point(10, 28);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.PlaceholderText = "Nhập tin nhắn...";
            txtInput.Size = new System.Drawing.Size(305, 42);
            txtInput.TabIndex = 0;
            txtInput.KeyDown += txtInput_KeyDown;

            // 
            // btnSend
            // 
            btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom;
            btnSend.BackColor = System.Drawing.Color.FromArgb(10, 61, 120);
            btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSend.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnSend.ForeColor = System.Drawing.Color.White;
            btnSend.Location = new System.Drawing.Point(320, 28);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(50, 42);
            btnSend.TabIndex = 1;
            btnSend.Text = "➤";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;

            // 
            // f_ChatBotAI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(pnChatArea);
            Controls.Add(pnSuggestions);
            Controls.Add(pnInput);
            Controls.Add(pnHeader);
            Name = "f_ChatBotAI";
            Size = new System.Drawing.Size(380, 630);
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnChatArea.ResumeLayout(false);
            pnInput.ResumeLayout(false);
            pnInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClearChat;
        private System.Windows.Forms.Button btnCloseChat;
        private System.Windows.Forms.Panel pnChatArea;
        private System.Windows.Forms.FlowLayoutPanel flowChatMessages;
        private System.Windows.Forms.FlowLayoutPanel pnSuggestions;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblTyping;
    }
}
