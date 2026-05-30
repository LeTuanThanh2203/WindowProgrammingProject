using LoginForm;
using Project_Group6.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_ListCourse : Form
    {
        Course course = new Course();

        public f_ListCourse()
        {
            InitializeComponent();
        }

        // LOAD FORM
        private void f_ManageCourse_Load(
            object sender,
            EventArgs e)
        {
            LoadCourse();
        }

        // LOAD COURSE
        private void LoadCourse()
        {
            dgvCourse.DataSource =
                course.GetCourse();

            lblTotal.Text =
                "Total Course: "
                + course.TotalCourse();

            dgvCourse.AllowUserToAddRows =
                false;

            dgvCourse.ReadOnly = true;

            dgvCourse.MultiSelect = false;

            dgvCourse.SelectionMode =
                DataGridViewSelectionMode
                .FullRowSelect;

            dgvCourse.RowTemplate.Height =
                35;

            dgvCourse.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode
                .Fill;

            dgvCourse.BorderStyle =
                BorderStyle.None;

            dgvCourse.BackgroundColor =
                Color.White;
        }

        // SEARCH
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            string keyword =
                txtSearch.Text.Trim();

            if (keyword == "")
            {
                LoadCourse();
            }
            else
            {
                dgvCourse.DataSource =
                    course.SearchCourse(
                        keyword);
            }
        }

        // REFRESH
        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            LoadCourse();
        }

        // OPEN ADD COURSE FORM
        private void btnAddCourse_Click(
            object sender,
            EventArgs e)
        {
            f_AddCourse form =
                new f_AddCourse();

            form.ShowDialog();

            LoadCourse();
        }

        // OPEN EDIT DELETE FORM
        private void btnEditDelete_Click(
            object sender,
            EventArgs e)
        {
            f_EditDeleteCourse form =
                new f_EditDeleteCourse();

            form.ShowDialog();

            LoadCourse();
        }

        // DOUBLE CLICK
        private void dgvCourse_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                f_EditDeleteCourse form =
                    new f_EditDeleteCourse();

                form.ShowDialog();

                LoadCourse();
            }
        }
    }
}