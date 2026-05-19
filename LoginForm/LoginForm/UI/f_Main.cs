using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_Main : Form
    {
        private Form currentForm;

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

            // ADMIN
            if (Globals.Role == "Admin")
            {
                btnOverview.Visible = true;

                btnStudent.Visible = true;

                btnStudent.Visible = true;
            }

            // MANAGER
            else if (Globals.Role == "Manager")
            {
                btnOverview.Visible = true;

                btnStudent.Visible = true;
            }

            // USER
            else if (Globals.Role == "User")
            {
                MessageBox.Show(
                    "You do not have permission!");

                pnSidebar.Enabled = false;
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

        private void btnOverview_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(new f_Overview());
        }
    }
}
