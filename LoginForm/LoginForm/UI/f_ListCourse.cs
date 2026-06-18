using LoginForm;
using Project_Group6.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_ListCourse : Form
    {
        private readonly Course _course = new();
        private bool _isLoaded = false;

        public f_ListCourse()
        {
            InitializeComponent();
            this.Load += f_ManageCourse_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            btnRefresh.Click += btnRefresh_Click;
            btnAdd.Click += btnAddCourse_Click;
            btnEdit.Click += btnEditDelete_Click;
            dgvCourse.CellDoubleClick += dgvCourse_CellDoubleClick;
        }

        // ================= LOAD =================
        private void f_ManageCourse_Load(object sender, EventArgs e)
        {
            cboSort.Items.AddRange(new[]
            {
                "Default",
                "Name A → Z",
                "Name Z → A",
                "Credits Asc",
                "Credits Desc"
            });
            cboSort.SelectedIndex = 0;

            _isLoaded = true;
            LoadCourse();
        }

        // ================= LOAD COURSE =================
        private void LoadCourse()
        {
            string keyword = txtSearch.Text.Trim();

            DataTable dt = string.IsNullOrEmpty(keyword)
                ? _course.GetCourse()
                : _course.SearchCourse(keyword);

            // Apply sort
            DataView dv = dt.DefaultView;
            string sort = cboSort.SelectedItem?.ToString();
            dv.Sort = sort switch
            {
                "Name A → Z" => "CourseName ASC",
                "Name Z → A" => "CourseName DESC",
                "Credits Asc" => "Credits ASC",
                "Credits Desc" => "Credits DESC",
                _ => "CourseID ASC"
            };

            dgvCourse.DataSource = dv.ToTable();
            lblTotal.Text = $"Total Course: {_course.TotalCourse()}";
        }

        // ================= SEARCH =================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isLoaded) LoadCourse();
        }

        // ================= SORT =================
        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoaded) LoadCourse();
        }

        // ================= REFRESH =================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboSort.SelectedIndex = 0;
            LoadCourse();
        }

        // ================= OPEN ADD COURSE =================
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            new f_AddCourse().ShowDialog();
            LoadCourse();
        }

        // ================= OPEN EDIT/DELETE =================
        private void btnEditDelete_Click(object sender, EventArgs e)
        {
            new f_EditDeleteCourse().ShowDialog();
            LoadCourse();
        }

        // ================= DOUBLE CLICK ROW =================
        private void dgvCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new f_EditDeleteCourse().ShowDialog();
                LoadCourse();
            }
        }
    }
}