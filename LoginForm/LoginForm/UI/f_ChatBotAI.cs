using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    /// <summary>
    /// AI Chatbot UserControl — giao diện chat bubble đẹp,
    /// tích hợp AIChatService cho hội thoại AI.
    /// </summary>
    public partial class f_ChatBotAI : UserControl
    {
        private readonly AIChatService chatService;
        private bool isSending = false;

        /// <summary>
        /// Event khi user bấm nút đóng chat
        /// </summary>
        public event EventHandler CloseRequested;

        /// <summary>
        /// Event khi AI trả về command cần thực hiện
        /// </summary>
        public event EventHandler<string> CommandReceived;

        public f_ChatBotAI()
        {
            InitializeComponent();
            chatService = new AIChatService();
            InitializeSettingsUI();
            InitializeSuggestionChips();

            // Welcome message
            AddBubble("🤖 Xin chào! Tôi là trợ lý AI của hệ thống.\n\n" +
                       "Tôi có thể giúp bạn:\n" +
                       "📊 Phân tích điểm & học tập\n" +
                       "📚 Tư vấn đăng ký môn học\n" +
                       "📈 Thống kê cho giảng viên\n" +
                       "⚡ Thực hiện các thao tác nhanh\n\n" +
                       "Hãy hỏi tôi bất cứ điều gì!", isUser: false);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _ = SendMessage();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                _ = SendMessage();
            }
        }

        private async Task SendMessage()
        {
            if (isSending) return;

            string message = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(message)) return;

            isSending = true;
            txtInput.Text = "";
            txtInput.Enabled = false;
            btnSend.Enabled = false;

            // Hiển thị tin nhắn user
            AddBubble(message, isUser: true);

            // Hiển thị typing indicator
            lblTyping.Text = "🤖 AI đang suy nghĩ...";
            lblTyping.Visible = true;

            try
            {
                string response = await chatService.SendMessageAsync(message);

                lblTyping.Visible = false;

                // Kiểm tra nếu là command
                if (AIChatService.TryParseCommand(response, out string command))
                {
                    AddBubble($"⚡ Đang thực hiện: {command}...", isUser: false);
                    CommandReceived?.Invoke(this, command);
                }
                else
                {
                    AddBubble(response, isUser: false);
                }
            }
            catch (Exception ex)
            {
                lblTyping.Visible = false;
                AddBubble($"❌ Lỗi: {ex.Message}", isUser: false);
            }
            finally
            {
                isSending = false;
                txtInput.Enabled = true;
                btnSend.Enabled = true;
                txtInput.Focus();
            }
        }

        private void InitializeSuggestionChips()
        {
            string role = Globals.Role ?? "User";

            // Suggestions phổ biến cho tất cả role
            var chips = new System.Collections.Generic.List<(string Icon, string Label, string Query)>
            {
                ("📊", "Điểm TB", "Cho tôi xem điểm trung bình của các môn học"),
                ("📚", "Lịch học", "Cho tôi xem lịch học hiện tại"),
                ("⚡", "Lệnh", "Bạn có thể thực hiện những lệnh gì?"),
            };

            // Thêm chip dành riêng cho Admin/Manager
            if (role == "Admin" || role == "Manager")
            {
                chips.Insert(0, ("👥", "SV mới", "Thêm sinh viên mới vào hệ thống"));
                chips.Add(("📋", "Duyệt TK", "Mở trang duyệt tài khoản"));
            }

            pnSuggestions.Controls.Clear();
            foreach (var (icon, label, query) in chips)
            {
                pnSuggestions.Controls.Add(CreateChip(icon, label, query));
            }
        }

        private Button CreateChip(string icon, string label, string query)
        {
            var chip = new Button();
            chip.Text = $"{icon} {label}";
            chip.AutoSize = false;
            chip.Height = 26;
            chip.Font = new Font("Segoe UI", 8.5F);
            chip.FlatStyle = FlatStyle.Flat;
            chip.FlatAppearance.BorderSize = 1;
            chip.FlatAppearance.BorderColor = Color.FromArgb(10, 61, 120);
            chip.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 61, 120);
            chip.BackColor = Color.White;
            chip.ForeColor = Color.FromArgb(10, 61, 120);
            chip.Cursor = Cursors.Hand;
            chip.Margin = new Padding(0, 0, 5, 0);
            chip.Padding = new Padding(6, 0, 6, 0);
            chip.TextAlign = ContentAlignment.MiddleCenter;
            chip.UseVisualStyleBackColor = false;

            // Auto width based on text
            using (var g = chip.CreateGraphics())
            {
                var textSize = g.MeasureString(chip.Text, chip.Font);
                chip.Width = (int)textSize.Width + 20;
            }

            chip.Click += (s, e) =>
            {
                txtInput.Text = query;
                txtInput.Focus();
                txtInput.SelectionStart = txtInput.Text.Length;
            };

            // Hover color effect
            chip.MouseEnter += (s, e) => chip.ForeColor = Color.White;
            chip.MouseLeave += (s, e) => chip.ForeColor = Color.FromArgb(10, 61, 120);

            return chip;
        }

        /// <summary>
        /// Thêm bubble chat vào flow layout
        /// </summary>
        private void AddBubble(string text, bool isUser)
        {
            // Panel wrapper cho bubble
            Panel bubbleWrapper = new Panel();
            bubbleWrapper.AutoSize = false;
            bubbleWrapper.Width = flowChatMessages.ClientSize.Width - 30;
            bubbleWrapper.Padding = new Padding(0);
            bubbleWrapper.Margin = new Padding(3, 4, 3, 4);

            // Tạo bubble panel với rounded corners
            Panel bubble = new Panel();
            bubble.AutoSize = false;
            bubble.BackColor = isUser
                ? Color.FromArgb(10, 61, 120)   // Blue cho user
                : Color.White;                     // White cho AI

            int maxBubbleWidth = (int)(bubbleWrapper.Width * 0.82);

            // Label cho text
            Label lblText = new Label();
            lblText.Text = text;
            lblText.Font = new Font("Segoe UI", 10F);
            lblText.ForeColor = isUser ? Color.White : Color.FromArgb(30, 30, 30);
            lblText.MaximumSize = new Size(maxBubbleWidth - 24, 0);
            lblText.AutoSize = true;
            lblText.Padding = new Padding(12, 10, 12, 10);
            lblText.Location = new Point(0, 0);

            bubble.Controls.Add(lblText);

            // Tính kích thước bubble
            Size textSize = lblText.PreferredSize;
            bubble.Size = new Size(
                Math.Min(textSize.Width, maxBubbleWidth),
                textSize.Height
            );

            // Vị trí: phải cho user, trái cho AI
            if (isUser)
            {
                bubble.Location = new Point(bubbleWrapper.Width - bubble.Width - 5, 0);
            }
            else
            {
                bubble.Location = new Point(5, 0);
            }

            bubbleWrapper.Height = bubble.Height + 4;
            bubbleWrapper.Controls.Add(bubble);

            // Rounded corners cho bubble
            bubble.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = CreateRoundedRectangle(
                    new Rectangle(0, 0, bubble.Width - 1, bubble.Height - 1), 12))
                {
                    bubble.Region = new Region(path);
                    using (Pen pen = new Pen(
                        isUser ? Color.FromArgb(8, 50, 100) : Color.FromArgb(220, 225, 230), 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            };

            // Shadow effect cho AI bubble
            if (!isUser)
            {
                bubble.Margin = new Padding(0, 0, 3, 3);
            }

            // Thêm vào flow
            if (flowChatMessages.InvokeRequired)
            {
                flowChatMessages.Invoke(new Action(() =>
                {
                    flowChatMessages.Controls.Add(bubbleWrapper);
                    ScrollToBottom();
                }));
            }
            else
            {
                flowChatMessages.Controls.Add(bubbleWrapper);
                ScrollToBottom();
            }
        }

        private void ScrollToBottom()
        {
            flowChatMessages.ScrollControlIntoView(
                flowChatMessages.Controls[flowChatMessages.Controls.Count - 1]);
        }

        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void btnCloseChat_Click(object sender, EventArgs e)
        {
            CloseRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnClearChat_Click(object sender, EventArgs e)
        {
            flowChatMessages.Controls.Clear();
            chatService.ClearHistory();

            AddBubble("🗑 Đã xóa lịch sử chat.\n\n" +
                       "Hãy hỏi tôi bất cứ điều gì!", isUser: false);
        }

        #region Programmatic API Settings UI

        private Button btnSettings;
        private Panel pnSettings;
        private TextBox txtBaseUrl;
        private TextBox txtApiKey;
        private TextBox txtModel;
        private Button btnSaveSettings;
        private Button btnCancelSettings;
        private Button btnTestConnection;
        private Label lblTestResult;

        private void InitializeSettingsUI()
        {
            // 1. Tạo btnSettings trên pnHeader
            btnSettings = new Button();
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSettings.BackColor = Color.Transparent;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 12F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(245, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(40, 40);
            btnSettings.Text = "⚙";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            pnHeader.Controls.Add(btnSettings);

            // 2. Tạo pnSettings
            pnSettings = new Panel();
            pnSettings.BackColor = Color.FromArgb(245, 247, 250);
            pnSettings.Dock = DockStyle.Fill;
            pnSettings.Location = new Point(0, 50);
            pnSettings.Size = new Size(380, 580);
            pnSettings.Visible = false;

            // Title
            Label lblTitleSettings = new Label();
            lblTitleSettings.Text = "Cấu hình API";
            lblTitleSettings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitleSettings.ForeColor = Color.FromArgb(10, 61, 120);
            lblTitleSettings.Location = new Point(20, 20);
            lblTitleSettings.Size = new Size(340, 30);
            pnSettings.Controls.Add(lblTitleSettings);

            // Base URL Label
            Label lblBaseUrl = new Label();
            lblBaseUrl.Text = "Base URL:";
            lblBaseUrl.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblBaseUrl.Location = new Point(20, 60);
            lblBaseUrl.Size = new Size(340, 20);
            pnSettings.Controls.Add(lblBaseUrl);

            // Base URL TextBox
            txtBaseUrl = new TextBox();
            txtBaseUrl.Font = new Font("Segoe UI", 10.5F);
            txtBaseUrl.Location = new Point(20, 85);
            txtBaseUrl.Size = new Size(340, 30);
            pnSettings.Controls.Add(txtBaseUrl);

            // API Key Label
            Label lblApiKey = new Label();
            lblApiKey.Text = "API Key:";
            lblApiKey.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblApiKey.Location = new Point(20, 130);
            lblApiKey.Size = new Size(340, 20);
            pnSettings.Controls.Add(lblApiKey);

            // API Key TextBox
            txtApiKey = new TextBox();
            txtApiKey.Font = new Font("Segoe UI", 10.5F);
            txtApiKey.Location = new Point(20, 155);
            txtApiKey.Size = new Size(340, 30);
            pnSettings.Controls.Add(txtApiKey);

            // Model Label
            Label lblModel = new Label();
            lblModel.Text = "Model Name:";
            lblModel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblModel.Location = new Point(20, 200);
            lblModel.Size = new Size(340, 20);
            pnSettings.Controls.Add(lblModel);

            // Model TextBox
            txtModel = new TextBox();
            txtModel.Font = new Font("Segoe UI", 10.5F);
            txtModel.Location = new Point(20, 225);
            txtModel.Size = new Size(340, 30);
            pnSettings.Controls.Add(txtModel);

            // Guidance Label
            Label lblGuidance = new Label();
            lblGuidance.Text = "💡 Model đề xuất: deepseek-ai/deepseek-v4-pro\nAPI miễn phí: github.com/alistaitsacle/free-llm-api-keys";
            lblGuidance.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblGuidance.ForeColor = Color.FromArgb(100, 100, 100);
            lblGuidance.Location = new Point(20, 268);
            lblGuidance.Size = new Size(340, 42);
            pnSettings.Controls.Add(lblGuidance);

            // Test Connection Button
            // Y = 268 + 42 + 10 = 320
            btnTestConnection = new Button();
            btnTestConnection.BackColor = Color.FromArgb(40, 167, 69);
            btnTestConnection.Cursor = Cursors.Hand;
            btnTestConnection.FlatAppearance.BorderSize = 0;
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(20, 320);
            btnTestConnection.Size = new Size(340, 38);
            btnTestConnection.Text = "🔌 Kiểm tra kết nối";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            pnSettings.Controls.Add(btnTestConnection);

            // Test Result Label
            // Y = 320 + 38 + 5 = 363
            lblTestResult = new Label();
            lblTestResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTestResult.Location = new Point(20, 363);
            lblTestResult.Size = new Size(340, 36);
            lblTestResult.TextAlign = ContentAlignment.MiddleCenter;
            lblTestResult.Visible = false;
            pnSettings.Controls.Add(lblTestResult);

            // Save Button
            // Y = 363 + 36 + 10 = 409
            btnSaveSettings = new Button();
            btnSaveSettings.BackColor = Color.FromArgb(10, 61, 120);
            btnSaveSettings.Cursor = Cursors.Hand;
            btnSaveSettings.FlatAppearance.BorderSize = 0;
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSaveSettings.ForeColor = Color.White;
            btnSaveSettings.Location = new Point(20, 409);
            btnSaveSettings.Size = new Size(160, 40);
            btnSaveSettings.Text = "Lưu cấu hình";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSaveSettings_Click;
            pnSettings.Controls.Add(btnSaveSettings);

            // Cancel Button
            btnCancelSettings = new Button();
            btnCancelSettings.BackColor = Color.FromArgb(120, 120, 120);
            btnCancelSettings.Cursor = Cursors.Hand;
            btnCancelSettings.FlatAppearance.BorderSize = 0;
            btnCancelSettings.FlatStyle = FlatStyle.Flat;
            btnCancelSettings.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCancelSettings.ForeColor = Color.White;
            btnCancelSettings.Location = new Point(190, 409);
            btnCancelSettings.Size = new Size(170, 40);
            btnCancelSettings.Text = "Hủy bỏ";
            btnCancelSettings.UseVisualStyleBackColor = false;
            btnCancelSettings.Click += btnCancelSettings_Click;
            pnSettings.Controls.Add(btnCancelSettings);

            // Thêm pnSettings vào Controls
            this.Controls.Add(pnSettings);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (pnSettings.Visible)
            {
                pnSettings.Visible = false;
            }
            else
            {
                // Load data
                txtBaseUrl.Text = chatService.Settings.BaseUrl;
                txtApiKey.Text = chatService.Settings.ApiKey;
                txtModel.Text = chatService.Settings.ModelName;

                pnSettings.Visible = true;
                pnSettings.BringToFront();
            }
        }

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại trong field (chưa cần save)
            string apiKey = txtApiKey.Text.Trim();
            string baseUrl = txtBaseUrl.Text.Trim();
            string model = txtModel.Text.Trim();

            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(baseUrl) || string.IsNullOrEmpty(model))
            {
                lblTestResult.ForeColor = Color.FromArgb(200, 100, 0);
                lblTestResult.Text = "⚠️ Vui lòng điền đầy đủ API Key, Base URL và Model";
                lblTestResult.Visible = true;
                return;
            }

            // Trạng thái đang kiểm tra
            btnTestConnection.Enabled = false;
            btnTestConnection.Text = "⏳ Đang kiểm tra...";
            lblTestResult.ForeColor = Color.FromArgb(80, 80, 200);
            lblTestResult.Text = "Đang gửi yêu cầu tới server...";
            lblTestResult.Visible = true;

            var (ok, ms, error) = await chatService.TestConnectionAsync(apiKey, baseUrl, model);

            btnTestConnection.Enabled = true;
            btnTestConnection.Text = "🔌 Kiểm tra kết nối";

            if (ok)
            {
                lblTestResult.ForeColor = Color.FromArgb(30, 150, 50);
                lblTestResult.Text = $"✅ Kết nối thành công! Phản hồi: {ms}ms";
            }
            else
            {
                lblTestResult.ForeColor = Color.FromArgb(200, 30, 30);
                lblTestResult.Text = $"❌ Thất bại: {error}";
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            chatService.SaveSettings(txtApiKey.Text.Trim(), txtBaseUrl.Text.Trim(), txtModel.Text.Trim());
            pnSettings.Visible = false;
            AddBubble("⚙️ Đã lưu cấu hình API mới!", isUser: false);
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            pnSettings.Visible = false;
        }

        #endregion
    }
}
