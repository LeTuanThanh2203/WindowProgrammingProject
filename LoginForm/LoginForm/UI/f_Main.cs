using Project_Group6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;   // Dùng để gọi hàm WinAPI cho việc di chuyển form không có border
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace LoginForm
{
    public partial class f_Main : Form
    {
        private Form currentForm;

        [DllImport("user32.DLL")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public f_Main()
        {
            InitializeComponent();
        }

        private void f_Main_Load(
            object sender,
            EventArgs e)
        {
            Permission();

            lblUser.Text +=
                Globals.Username;

            lblRole.Text +=
                Globals.Role;
        }

        private void Permission()
        {
            // Ẩn tất cả trước
            btnOverview.Visible = false;

            btnStudent.Visible = false;

            btnStudent.Visible = false;

            btnCourse.Visible = false;

            btnCourseReg.Visible = false;

            btnApprove.Visible = false;

            btnAddScore.Visible = false;

            // ADMIN
            if (Globals.Role == "Admin")
            {
                btnOverview.Visible = true;

                btnStudent.Visible = true;

                btnStudent.Visible = true;

                btnCourse.Visible = true;

                btnAddScore.Visible = true;

                btnApprove.Visible = true ;
                OpenForm(new f_Dashboard());
            }

            // MANAGER
            else if (Globals.Role == "Manager")
            {
                btnOverview.Visible = true;

                btnStudent.Visible = true;

                btnCourse.Visible = true;

                btnAddScore.Visible = true;
                OpenForm(new f_Dashboard());
            }

            // USER
            else if (Globals.Role == "User")
            {
                btnCourseReg.Visible = true;
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

            childForm.FormBorderStyle =
                FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            pnBody.Controls.Clear();

            pnBody.Controls.Add(childForm);

            childForm.Show();
        }

        private void btnStudent_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new f_ListStudent());
        }

        private void btnApprove_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new f_Approve());
        }
        private void btnCourseReg_Click(object sender, EventArgs e)
        {
            OpenForm(new f_CourseRegistration());
        }

        private void btnOverview_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new f_Dashboard());
        }
        private void btnCourse_Click(
        object sender,
        EventArgs e)
        {
            OpenForm(new f_ListCourse());
        }
        private void btnAddScore_Click(
       object sender,
       EventArgs e)
        {
            OpenForm(new f_AddScore());
        }

        private async void btnAskAI_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                // UI loading
                progressAI.Visible = true;

                progressAI.Style =
                    ProgressBarStyle.Marquee;

                lblAIStatus.Text =
                    "AI is thinking...";

                btnAskAI.Enabled = false;

                AIService ai =
                    new AIService();

                string command =
                    await ai.AskAI(
                        txtAI.Text);

                ExecuteCommand(command);

                lblAIStatus.Text =
                    "Done";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                progressAI.Visible = false;

                btnAskAI.Enabled = true;
            }
        }


        private void ExecuteCommand(
    string command)
        {
            command = command.Trim()
                .ToLower();

            switch (command)
            {
                case "add_student":

                    f_ListStudent list =
                        new f_ListStudent();

                    OpenForm(list);

                    list.OpenAddStudent();

                    break;

                case "edit_student":

                    f_ListStudent edit =
                        new f_ListStudent();

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
    }

}
