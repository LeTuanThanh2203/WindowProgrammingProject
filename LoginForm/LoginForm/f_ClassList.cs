using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_ClassList : Form
    {
        Class _class = new Class();

        public f_ClassList()
        {
            InitializeComponent();

            // GẮN EVENTS
            this.Load += f_ClassList_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cboSort.SelectedIndexChanged
                                   += cboSort_SelectedIndexChanged;
            cboGender.SelectedIndexChanged
                                   += cboGender_SelectedIndexChanged;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnRefresh.Click += btnRefresh_Click;
            dgvClassList.CellDoubleClick
                                   += dgvClassList_CellDoubleClick;
        }

        // LOAD FORM
        private void f_ClassList_Load(
            object sender,
            EventArgs e)
        {
            LoadClass();
            InitFilter();
        }

        // LOAD CLASS
        private void LoadClass()
        {
            dgvClassList.DataSource =
                _class.SearchClassrooms("");

            lblTotal.Text =
                "Total Class: "
                + _class.TotalClassrooms();

            dgvClassList.AllowUserToAddRows =
                false;

            dgvClassList.ReadOnly = true;

            dgvClassList.MultiSelect = false;

            dgvClassList.SelectionMode =
                DataGridViewSelectionMode
                .FullRowSelect;

            dgvClassList.RowTemplate.Height =
                35;

            dgvClassList.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode
                .Fill;

            dgvClassList.BorderStyle =
                BorderStyle.None;

            dgvClassList.BackgroundColor =
                Color.White;
        }

        // INIT FILTER COMBOS
        private void InitFilter()
        {
            // cboSort
            cboSort.Items.AddRange(
                new[] { "All", "ClassID", "ClassName", "AcademicYear" });
            cboSort.SelectedIndex = 0;

            // cboGender → dùng làm Academic Year filter
            cboGender.Items.Add("All Years");
            var years = _class.GetDistinctAcademicYears();
            foreach (DataRow row in years.Rows)
                cboGender.Items.Add(
                    row["AcademicYear"].ToString());
            cboGender.SelectedIndex = 0;
        }

        // SEARCH
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            string keyword =
                txtSearch.Text.Trim();

            if (keyword == "")
                LoadClass();
            else
                dgvClassList.DataSource =
                    _class.SearchClassrooms(keyword);

            UpdateTotal();
        }

        // FILTER SORT
        private void cboSort_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ApplyFilter();
        }

        // FILTER ACADEMIC YEAR
        private void cboGender_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ApplyFilter();
        }

        // APPLY FILTER + SORT
        private void ApplyFilter()
        {
            string selYear =
                cboGender.SelectedItem?.ToString();

            string sortBy =
                cboSort.SelectedItem?.ToString();

            DataTable dt =
                selYear == "All Years"
                ? _class.SearchClassrooms("")
                : _class.GetClassesByAcademicYear(selYear);

            if (sortBy != "All"
                && dt.Columns.Contains(sortBy))
                dt.DefaultView.Sort =
                    sortBy + " ASC";

            dgvClassList.DataSource = dt;
            UpdateTotal();
        }

        // UPDATE TOTAL LABEL
        private void UpdateTotal()
        {
            lblTotal.Text =
                "Total Class: "
                + dgvClassList.Rows.Count;
        }

        // REFRESH
        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();
            cboSort.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            LoadClass();
        }

        // OPEN ADD FORM
        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            f_AddClass form = new f_AddClass();
            form.ShowDialog();
            LoadClass();
        }

        // OPEN EDIT/DELETE FORM
        private void btnEdit_Click(
            object sender,
            EventArgs e)
        {
            f_EditDeleteClass form =
                new f_EditDeleteClass();

            form.ShowDialog();
            LoadClass();
        }

        // DOUBLE CLICK → EDIT/DELETE
        private void dgvClassList_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                f_EditDeleteClass form =
                    new f_EditDeleteClass();

                form.ShowDialog();
                LoadClass();
            }
        }
    }
}