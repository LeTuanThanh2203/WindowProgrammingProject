using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using Project_Group6.Models;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_EditDeleteClass : Form
    {
        private bool isLoaded = false;

        Class _class = new Class();
        Course _course = new Course();

        public f_EditDeleteClass()
        {
            InitializeComponent();

            // GẮN EVENTS
            this.Load += f_EditDeleteClass_Load;
            this.Shown += f_EditDeleteClass_Shown;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnQuit.Click += btnQuit_Click;
            txtSearch.TextChanged
                                += txtSearch_TextChanged;
            cboSort.SelectedIndexChanged
                                += cboSort_SelectedIndexChanged;
            dgvCourse.CellClick += dgvCourse_CellClick;
            cbo_CourseName.SelectedIndexChanged
                                += cbo_CourseName_SelectedIndexChanged;
        }

        // ================= LOAD FORM =================
        private void f_EditDeleteClass_Load(
            object sender,
            EventArgs e)
        {
            cboSort.Items.AddRange(new[]
            {
                "Name A-Z",
                "Name Z-A",
                "Year Asc",
                "Year Desc"
            });
            cboSort.SelectedIndex = 0;

            LoadCourseName();

            isLoaded = true;
        }

        private void f_EditDeleteClass_Shown(
            object sender,
            EventArgs e)
        {
            LoadData();
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            string keyword =
                txtSearch.Text.Trim();

            DataTable dt =
                _class.SearchClassrooms(keyword);

            DataView dv = dt.DefaultView;

            string sort =
                cboSort.SelectedItem?.ToString();

            if (sort == "Name A-Z")
                dv.Sort = "ClassName ASC";
            else if (sort == "Name Z-A")
                dv.Sort = "ClassName DESC";
            else if (sort == "Year Asc")
                dv.Sort = "AcademicYear ASC";
            else if (sort == "Year Desc")
                dv.Sort = "AcademicYear DESC";

            dgvCourse.DataSource = dv.ToTable();

            FormatGrid();
            ClearForm();
        }

        // ================= FORMAT GRID =================
        private void FormatGrid()
        {
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.RowTemplate.Height = 35;
            dgvCourse.BackgroundColor =
                System.Drawing.Color.White;
            dgvCourse.BorderStyle =
                BorderStyle.None;
        }

        // ================= LOAD COURSE COMBOBOX =================
        private void LoadCourseName()
        {
            DataTable dt = _course.GetCoursesForCombo();

            cbo_CourseName.DataSource = dt;
            cbo_CourseName.DisplayMember = "CourseDisplay";
            cbo_CourseName.ValueMember = "CourseID";
            cbo_CourseName.SelectedIndex = -1;
        }

        // ================= CLICK GRID → FILL FORM =================
        private void dgvCourse_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row =
                dgvCourse.Rows[e.RowIndex];

            // ClassID
            lbl_ClassIDAuto.Text =
                row.Cells["ClassID"].Value?.ToString();

            // AcademicYear
            lbl_AcademicYearAuto.Text =
                row.Cells["AcademicYear"].Value?.ToString();

            // ClassName
            txt_ClassCourse.Text =
                row.Cells["ClassName"].Value?.ToString();

            // HomeroomTeacher → txt
            txt_HomeroomTeacher.Text =
                row.Cells["HomeroomTeacher"].Value?.ToString() ?? "";

            // CourseName → tìm CourseCode từ ClassID
            // ClassID dạng: "CS101-2024" → CourseCode = "CS101"
            string classID =
                lbl_ClassIDAuto.Text ?? "";

            string courseCode = classID.Contains("-")
                ? classID.Substring(
                    0, classID.LastIndexOf("-")).Trim()
                : classID.Trim();

            DataTable dt =
                cbo_CourseName.DataSource as DataTable;

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string display =
                        dr["CourseDisplay"].ToString();

                    string code = display.Contains(" - ")
                        ? display.Split(" - ")[0].Trim()
                        : display.Trim();

                    if (code == courseCode)
                    {
                        cbo_CourseName.SelectedValue =
                            dr["CourseID"];
                        break;
                    }
                }
            }
        }

        // ================= SINH CLASS ID KHI ĐỔI COURSE =================
        private void cbo_CourseName_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cbo_CourseName.SelectedItem == null)
                return;

            string display = cbo_CourseName.Text;
            string courseCode = display.Contains(" - ")
                ? display.Split(" - ")[0].Trim()
                : display.Trim();

            string year =
                lbl_AcademicYearAuto.Text.Contains(" - ")
                ? lbl_AcademicYearAuto.Text
                    .Split(" - ")[0].Trim()
                : DateTime.Now.Year.ToString();

            // Chỉ sinh ClassID khi chưa có (chưa chọn từ grid)
            if (string.IsNullOrEmpty(lbl_ClassIDAuto.Text))
                lbl_ClassIDAuto.Text =
                    $"{courseCode}-{year}";
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_ClassIDAuto.Text))
            {
                MessageBox.Show(
                    "Please select a class from the list.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_ClassCourse.Text))
            {
                MessageBox.Show(
                    "Please enter Class Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_ClassCourse.Focus();
                return;
            }

            var updated = new Class
            {
                ClassID = lbl_ClassIDAuto.Text.Trim(),
                ClassName = txt_ClassCourse.Text.Trim(),
                AcademicYear = lbl_AcademicYearAuto.Text.Trim(),
                NumberOfStudent = 0,
                HomeroomTeacher =
                    string.IsNullOrWhiteSpace(
                        txt_HomeroomTeacher.Text)
                    ? null
                    : txt_HomeroomTeacher.Text.Trim()
            };

            bool ok = updated.EditClassroom();

            MessageBox.Show(
                ok ? "Updated successfully!"
                   : "Update failed!",
                "Update",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information
                   : MessageBoxIcon.Error);

            if (ok) LoadData();
        }

        // ================= DELETE =================
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_ClassIDAuto.Text))
            {
                MessageBox.Show(
                    "Please select a class from the list.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string classID = lbl_ClassIDAuto.Text.Trim();
            string className = txt_ClassCourse.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete class \"{className}\"?\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            bool ok = Class.DeleteClassroom(classID);

            MessageBox.Show(
                ok ? "Deleted successfully!"
                   : "Delete failed!",
                "Delete",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information
                   : MessageBoxIcon.Error);

            if (ok) LoadData();
        }

        // ================= SEARCH =================
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            if (isLoaded) LoadData();
        }

        // ================= SORT =================
        private void cboSort_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (isLoaded) LoadData();
        }

        // ================= REFRESH =================
        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();
            cboSort.SelectedIndex = 0;
            LoadData();
        }

        // ================= CLEAR FORM =================
        private void ClearForm()
        {
            lbl_ClassIDAuto.Text = "";
            lbl_AcademicYearAuto.Text = "";
            txt_ClassCourse.Clear();
            txt_HomeroomTeacher.Clear();
            cbo_CourseName.SelectedIndex = -1;
        }

        // ================= CANCEL =================
        private void btnQuit_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}