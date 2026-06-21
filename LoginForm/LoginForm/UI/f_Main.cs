using Project_Group6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;   // Dùng để gọi hàm WinAPI cho việc di chuyển form không có border
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;

namespace LoginForm
{
    public partial class f_Main : Form
    {
        private Form currentForm;
        private f_ChatBotAI chatBotControl;
        private bool isAIChatOpen = false;
        private System.Windows.Forms.Timer slideTimer;
        private int targetWidth = 0;

        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public f_Main()
        {
            InitializeComponent();
            pnSidebar.SendToBack();
            pnTop.SendToBack();
            pnBody.BringToFront();
            
            // Đưa pnTop lên trên cùng để các nút close/min/max đè lên pnBody và các form con
            pnTop.BringToFront();
            btnAI.BringToFront();

            // Thiết lập màu hover của nút toggle trong logo panel
            btnToggleSidebar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 255, 255, 255);
            btnToggleSidebar.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 255, 255, 255);

            // Thiết lập màu hover cho nút quản lý menu
            btnMenuManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 230, 230);
            btnMenuManagement.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);

            // Khởi tạo bảng MenuConfig nếu chưa tồn tại
            MenuConfigDbHelper.InitializeMenuConfigTable();

            // Khởi tạo AI Chatbot
            InitializeAIChatbot();
        }

        private System.Windows.Forms.ToolTip sidebarToolTip;

        private void f_Main_Load(
            object sender,
            EventArgs e)
        {
            Permission();
            SetupToolTips();

            lblUser.Text += Globals.Username;
            lblRole.Text += Globals.Role;
        }

        private void SetupToolTips()
        {
            sidebarToolTip = new System.Windows.Forms.ToolTip();
            sidebarToolTip.ShowAlways = true;
            sidebarToolTip.InitialDelay = 100;
            sidebarToolTip.ReshowDelay = 100;
            sidebarToolTip.AutoPopDelay = 5000;

            sidebarToolTip.SetToolTip(btnOverview, "Dashboard");
            sidebarToolTip.SetToolTip(btnStudent, "Student");
            sidebarToolTip.SetToolTip(btnApprove, "Approve");
            sidebarToolTip.SetToolTip(btnCourse, "Courses");
            sidebarToolTip.SetToolTip(btnCourseRegistation, "Courses Registation");
            sidebarToolTip.SetToolTip(btnScore, "Score");
            sidebarToolTip.SetToolTip(btnInformation, "Information");
            sidebarToolTip.SetToolTip(btnClass, "Class");
            sidebarToolTip.SetToolTip(btnConfirmationRequest, "Confirmation Request");
            sidebarToolTip.SetToolTip(btnAssign, "Assign");
            sidebarToolTip.SetToolTip(btnContact, "Contact");
            sidebarToolTip.SetToolTip(btnExport, "Export");
            sidebarToolTip.SetToolTip(btnMenuManagement, "Menu Manage");
            sidebarToolTip.SetToolTip(btnLogout, "Logout");
            sidebarToolTip.SetToolTip(btnToggleSidebar, "Toggle Sidebar");
            sidebarToolTip.SetToolTip(btnSchedule, "Schedule");
        }

        public void RefreshMenu()
        {
            Permission();
        }

        private void Permission()
        {
            // Ẩn tất cả trước
            btnOverview.Visible = false;
            btnStudent.Visible = false;
            btnCourse.Visible = false;
            btnCourseRegistation.Visible = false;
            btnApprove.Visible = false;
            btnScore.Visible = false;
            btnInformation.Visible = false;
            btnClass.Visible = false;
            btnConfirmationRequest.Visible = false;
            btnAssign.Visible = false;
            btnContact.Visible = false;
            btnExport.Visible = false;
            btnMenuManagement.Visible = false;
            btnSchedule.Visible = false;

            LoadDynamicMenu();
        }

        private void LoadDynamicMenu()
        {
            string role = Globals.Role;
            string roleColumn = role switch
            {
                "Admin" => "AllowAdmin",
                "HR" => "AllowManager",
                _ => "AllowUser"
            };

            // Truy vấn lấy danh sách nút được sắp xếp theo thứ tự hiển thị tăng dần
            string query = $@"
                SELECT ButtonName, DisplayName 
                FROM MenuConfig 
                WHERE {roleColumn} = 1 
                ORDER BY DisplayOrder ASC";

            using (My_DB db = new My_DB())
            {
                try
                {
                    db.openConnection();
                    using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string btnName = reader["ButtonName"].ToString();
                                string displayName = reader["DisplayName"].ToString();

                                // Bảo mật: Chỉ Admin mới được hiển thị nút Quản lý menu
                                if (btnName == "btnMenuManagement" && role != "Admin")
                                {
                                    continue;
                                }

                                Control[] found = pnMenu.Controls.Find(btnName, true);
                                if (found.Length > 0 && found[0] is IconButton btn)
                                {
                                    btn.Visible = true;
                                    btn.BringToFront();

                                    // Cập nhật tên hiển thị từ Database
                                    btn.Text = isSidebarCollapsed ? "" : displayName;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dynamic menu: " + ex.Message, "Menu Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }

            // Mở mặc định form Dashboard nếu được phép
            if (role == "Admin" || role == "HR")
            {
                Control[] foundOverview = pnMenu.Controls.Find("btnOverview", true);
                if (foundOverview.Length > 0 && foundOverview[0].Visible)
                {
                    OpenForm(new f_Dashboard());
                }
            }
        }

        private void OpenForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Clear();
            pnBody.Controls.Add(childForm);
            childForm.Show();
            
            // Đảm bảo pnTop chứa các nút điều khiển luôn đè lên form con
            pnTop.BringToFront();
            btnAI.BringToFront();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenForm(new f_ListStudent());
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            OpenForm(new f_Approve());
        }

        private void btnCourseReg_Click(object sender, EventArgs e)
        {
            OpenForm(new f_CourseRegistration());
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            OpenForm(new f_Dashboard());
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            OpenForm(new f_ListCourse());
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            OpenForm(new f_EditScore());
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            OpenForm(new f_ClassList());
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            OpenForm(new f_StudentInformation());
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            OpenForm(new f_Assign());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            OpenForm(new f_ContactManage());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            OpenForm(new f_ReportExport());
        }

        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            OpenForm(new f_MenuManagement(this));
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenForm(new f_Schedule());
        }

        private void ExecuteCommand(string command)
        {
            command = command.Trim().ToLower();

            switch (command)
            {
                case "add_student":
                    f_ListStudent list = new f_ListStudent();
                    OpenForm(list);
                    list.OpenAddStudent();
                    break;

                case "edit_student":
                    f_ListStudent edit = new f_ListStudent();
                    OpenForm(edit);
                    edit.OpenEditStudent();
                    break;

                case "approve_account":
                    OpenForm(new f_Approve());
                    break;

                case "overview":
                    OpenForm(new f_Dashboard());
                    break;

                case "list_students":
                    OpenForm(new f_ListStudent());
                    break;

                case "list_courses":
                    OpenForm(new f_ListCourse());
                    break;

                case "course_registration":
                    OpenForm(new f_CourseRegistration());
                    break;

                case "score":
                    OpenForm(new f_EditScore());
                    break;

                case "class_list":
                    OpenForm(new f_ClassList());
                    break;

                case "schedule":
                    OpenForm(new f_Schedule());
                    break;

                case "information":
                    OpenForm(new f_StudentInformation());
                    break;

                case "assign":
                    OpenForm(new f_Assign());
                    break;

                case "contact":
                    OpenForm(new f_ContactManage());
                    break;

                case "export":
                    OpenForm(new f_ReportExport());
                    break;

                case "exit":
                    Application.Exit();
                    break;

                case "help":
                    MessageBox.Show(
                        "Available commands:\n" +
                        "- add_student\n" +
                        "- edit_student\n" +
                        "- approve_account\n" +
                        "- overview\n" +
                        "- list_students\n" +
                        "- list_courses\n" +
                        "- course_registration\n" +
                        "- score\n" +
                        "- class_list\n" +
                        "- schedule\n" +
                        "- information\n" +
                        "- assign\n" +
                        "- contact\n" +
                        "- export\n" +
                        "- help\n" +
                        "- exit");
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnConfirmationRequest_Click(object sender, EventArgs e)
        {
            OpenForm(new f_Request());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Globals.ClearSession();
                f_LoginForm login = new f_LoginForm();
                login.Show();
                this.Close();
            }
        }

        private bool isSidebarCollapsed = false;

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            isSidebarCollapsed = !isSidebarCollapsed;

            if (isSidebarCollapsed)
            {
                // Thu nhỏ sidebar
                pnSidebar.Width = 70;
                pictureBox1.Visible = false;

                // Cập nhật các nút hiển thị chỉ có icon và căn giữa thành hình vuông
                UpdateSidebarButtons(true);

                lblUser.Visible = false;
                lblRole.Visible = false;

                // Căn giữa nút toggle trong Logo panel
                btnToggleSidebar.Location = new Point(15, 52);
                btnToggleSidebar.IconChar = IconChar.Bars;
            }
            else
            {
                // Mở rộng sidebar
                pnSidebar.Width = 305;
                pictureBox1.Visible = true;

                // Cập nhật lại text và căn trái cho các nút
                UpdateSidebarButtons(false);

                lblUser.Visible = true;
                lblRole.Visible = true;

                // Trả nút toggle về vị trí cũ trong Logo panel
                btnToggleSidebar.Location = new Point(265, 10);
                btnToggleSidebar.IconChar = IconChar.ChevronLeft;
            }
        }

        private void UpdateSidebarButtons(bool collapse)
        {
            ContentAlignment align = collapse ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;

            UpdateButtonState(btnOverview, collapse ? "" : "Dashboard", align, collapse);
            UpdateButtonState(btnStudent, collapse ? "" : "Student", align, collapse);
            UpdateButtonState(btnApprove, collapse ? "" : "Approve", align, collapse);
            UpdateButtonState(btnCourse, collapse ? "" : "Courses", align, collapse);
            UpdateButtonState(btnCourseRegistation, collapse ? "" : "Courses Registation", align, collapse);
            UpdateButtonState(btnScore, collapse ? "" : "Score", align, collapse);
            UpdateButtonState(btnInformation, collapse ? "" : "Information", align, collapse);
            UpdateButtonState(btnClass, collapse ? "" : "Class", align, collapse);
            UpdateButtonState(btnConfirmationRequest, collapse ? "" : "Confirmation Request", align, collapse);
            UpdateButtonState(btnAssign, collapse ? "" : "Assign ", align, collapse);
            UpdateButtonState(btnContact, collapse ? "" : "Contact", align, collapse);
            UpdateButtonState(btnExport, collapse ? "" : "Export", align, collapse);
            UpdateButtonState(btnMenuManagement, collapse ? "" : "Menu Manage", align, collapse);
            UpdateButtonState(btnLogout, collapse ? "" : "  Logout", align, collapse);
        }

        private void UpdateButtonState(IconButton btn, string text, ContentAlignment align, bool collapse)
        {
            btn.Text = text;
            btn.ImageAlign = align;
            if (collapse)
            {
                btn.Padding = new Padding(0);
                btn.Height = (btn == btnLogout) ? 46 : 70; // 70x70 là hình vuông cho menu, 46x46 cho logout
            }
            else
            {
                btn.Padding = new Padding(12, 0, 0, 0);
                btn.Height = (btn == btnLogout) ? 40 : 76;
            }
        }

        #region AI Chatbot

        private void InitializeAIChatbot()
        {
            chatBotControl = new f_ChatBotAI();
            chatBotControl.Dock = DockStyle.Fill;
            chatBotControl.CloseRequested += (s, ev) => ToggleAIChat();
            chatBotControl.CommandReceived += (s, cmd) =>
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => ExecuteCommand(cmd)));
                else
                    ExecuteCommand(cmd);
            };
            pnAIChat.Controls.Add(chatBotControl);

            // Timer cho slide animation
            slideTimer = new System.Windows.Forms.Timer();
            slideTimer.Interval = 12;
            slideTimer.Tick += SlideTimer_Tick;
        }

        private void btnAI_Click(object sender, EventArgs e)
        {
            ToggleAIChat();
        }

        private void ToggleAIChat()
        {
            if (isAIChatOpen)
            {
                // Closing: remove right padding of pnBody so child form expands to full width
                pnBody.Padding = new Padding(0);
                
                // Slide panel out to right
                targetWidth = 0;
                slideTimer.Start();
                
                // Show the AI chatbot button again
                btnAI.Visible = true;
                btnAI.BringToFront();
            }
            else
            {
                // Opening: add right padding of 390px to pnBody so child form shrinks to make space
                pnBody.Padding = new Padding(0, 0, 390, 0);
                
                // Slide panel in from right
                pnAIChat.Visible = true;
                pnAIChat.BringToFront();
                
                // Hide the AI chatbot button while chat is open
                btnAI.Visible = false;
                
                // Keep the window top control buttons visible on top
                pnTop.BringToFront();
                
                targetWidth = 390;
                slideTimer.Start();
            }
            // Toggle state flag
            isAIChatOpen = !isAIChatOpen;
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            int currentOverlap = this.ClientSize.Width - pnAIChat.Left;
            int step = 30;

            if (targetWidth > 0)
            {
                // Mở: di chuyển panel sang trái
                if (currentOverlap < targetWidth)
                {
                    pnAIChat.Left -= step;
                    if (this.ClientSize.Width - pnAIChat.Left >= targetWidth)
                    {
                        pnAIChat.Left = this.ClientSize.Width - targetWidth;
                        slideTimer.Stop();
                    }
                }
                else
                {
                    slideTimer.Stop();
                }
            }
            else
            {
                // Đóng: di chuyển panel sang phải
                if (pnAIChat.Left < this.ClientSize.Width)
                {
                    pnAIChat.Left += step;
                    if (pnAIChat.Left >= this.ClientSize.Width)
                    {
                        pnAIChat.Left = this.ClientSize.Width;
                        pnAIChat.Visible = false;
                        slideTimer.Stop();
                    }
                }
                else
                {
                    pnAIChat.Visible = false;
                    slideTimer.Stop();
                }
            }
        }

        #endregion
    }
}
