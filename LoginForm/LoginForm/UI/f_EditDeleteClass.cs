using Project_Group6.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_EditDeleteClass : Form
    {
        private bool _isLoaded = false;
        private readonly Class _class = new();
        private readonly Course _course = new();

        public f_EditDeleteClass()
        {
            InitializeComponent();
            this.Load += f_EditDeleteClass_Load;
            this.Shown += f_EditDeleteClass_Shown;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnQuit.Click += btnQuit_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            dgvCourse.CellClick += dgvCourse_CellClick;
            cbo_CourseName.SelectedIndexChanged += cbo_CourseName_SelectedIndexChanged;
        }

        // ================= LOAD =================
        private void f_EditDeleteClass_Load(object sender, EventArgs e)
        {
            cboSort.Items.AddRange(new[]
            {
                "CourseID A-Z", "CourseID Z-A",
                "Year Asc",     "Year Desc"
            });
            cboSort.SelectedIndex = 0;

            LoadCourseName();
            LoadSemester();

            _isLoaded = true;
        }

        private void f_EditDeleteClass_Shown(object sender, EventArgs e) => LoadData();

        // ================= LOAD COURSE =================
        private void LoadCourseName()
        {
            DataTable dt = _course.GetCoursesForCombo();

            cbo_CourseName.DataSource = dt;
            cbo_CourseName.DisplayMember = "CourseDisplay";
            cbo_CourseName.ValueMember = "CourseID";   // VARCHAR(20)
            cbo_CourseName.SelectedIndex = -1;
        }

        // ================= LOAD SEMESTER =================
        private void LoadSemester()
        {
            cboSemester.Items.Clear();
            cboSemester.Items.Add("Semester 1");
            cboSemester.Items.Add("Semester 2");
            cboSemester.Items.Add("Summer");
            cboSemester.SelectedIndex = 0;
        }

        // ================= HELPERS =================
        // Semester lưu dạng NVARCHAR(20) theo schema
        private string SemesterValue() =>
            cboSemester.SelectedItem?.ToString() switch
            {
                "Semester 1" => "HK1",
                "Semester 2" => "HK2",
                "Summer" => "Summer",
                _ => "HK1"
            };

        // DB value → combobox text
        private void SetSemesterCombo(string semester)
        {
            cboSemester.SelectedItem = semester switch
            {
                "HK1" => "Semester 1",
                "HK2" => "Semester 2",
                "Summer" => "Summer",
                // fallback: cố gắng match trực tiếp
                _ => semester
            };
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            string keyword = txtSearch.Text.Trim();

            DataTable dt = string.IsNullOrEmpty(keyword)
                ? _class.GetAllClassrooms()       // JOIN Course, trả về CourseName
                : _class.SearchClassrooms(keyword);

            DataView dv = dt.DefaultView;
            string sort = cboSort.SelectedItem?.ToString();

            dv.Sort = sort switch
            {
                "CourseID A-Z" => "CourseID ASC",
                "CourseID Z-A" => "CourseID DESC",
                "Year Asc" => "AcademicYear ASC",
                "Year Desc" => "AcademicYear DESC",
                _ => "ClassID ASC"
            };

            dgvCourse.DataSource = dv.ToTable();
            FormatGrid();
            ClearForm();
        }

        // ================= FORMAT GRID =================
        private void FormatGrid()
        {
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.RowTemplate.Height = 35;
            dgvCourse.BackgroundColor = System.Drawing.Color.White;
            dgvCourse.BorderStyle = BorderStyle.None;
        }

        // ================= CLICK GRID =================
        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCourse.Rows[e.RowIndex];

            lbl_ClassIDAuto.Text = row.Cells["ClassID"].Value?.ToString();
            lbl_AcademicYearAuto.Text = row.Cells["AcademicYear"].Value?.ToString();

            txt_Capacity.Text = row.Cells["Capacity"].Value?.ToString() ?? "0";
            txt_Room.Text = row.Cells["Room"].Value?.ToString() ?? "";
            txt_Schedule.Text = row.Cells["Schedule"].Value?.ToString() ?? "";

            // Semester dạng NVARCHAR — map về combobox
            SetSemesterCombo(row.Cells["Semester"].Value?.ToString() ?? "");

            // CourseID → bind combobox
            string courseID = row.Cells["CourseID"].Value?.ToString().Trim() ?? "";
            cbo_CourseName.SelectedValue = courseID;
        }

        // ================= AUTO CLASS ID (chỉ khi chưa chọn từ grid) =================
        private void cbo_CourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_ClassIDAuto.Text)) return;

            if (cbo_CourseName.SelectedValue == null
             || cbo_CourseName.SelectedValue == DBNull.Value)
                return;

            string courseID = cbo_CourseName.SelectedValue.ToString().Trim();
            string year = lbl_AcademicYearAuto.Text.Contains('-')
                ? lbl_AcademicYearAuto.Text.Split('-')[0].Trim()
                : DateTime.Now.Year.ToString();

            lbl_ClassIDAuto.Text = $"{courseID}-{year}-{SemesterValue()}";
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_ClassIDAuto.Text))
            {
                MessageBox.Show("Please select a class from the list.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txt_Capacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Capacity must be a positive number.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Capacity.Focus();
                return;
            }

            var updated = new Class
            {
                ClassID = lbl_ClassIDAuto.Text.Trim(),
                CourseID = cbo_CourseName.SelectedValue?.ToString().Trim() ?? "",
                Semester = SemesterValue(),
                AcademicYear = lbl_AcademicYearAuto.Text.Trim(),
                Capacity = capacity,
                Room = string.IsNullOrWhiteSpace(txt_Room.Text)
                               ? null : txt_Room.Text.Trim(),
                Schedule = string.IsNullOrWhiteSpace(txt_Schedule.Text)
                               ? null : txt_Schedule.Text.Trim()
            };

            bool ok = updated.EditClassroom();

            MessageBox.Show(
                ok ? "Updated successfully!" : "Update failed!",
                "Update", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) LoadData();
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_ClassIDAuto.Text))
            {
                MessageBox.Show("Please select a class from the list.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string classID = lbl_ClassIDAuto.Text.Trim();

            if (MessageBox.Show(
                    $"Delete class \"{classID}\"?\nThis cannot be undone.",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            bool ok = Class.DeleteClassroom(classID);

            MessageBox.Show(
                ok ? "Deleted successfully!" : "Delete failed!",
                "Delete", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) LoadData();
        }

        // ================= SEARCH / SORT =================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isLoaded) LoadData();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoaded) LoadData();
        }

        // ================= REFRESH =================
        private void btnRefresh_Click(object sender, EventArgs e)
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
            txt_Capacity.Clear();
            txt_Room.Clear();
            txt_Schedule.Clear();
            cbo_CourseName.SelectedIndex = -1;
            cboSemester.SelectedIndex = 0;
        }

        private void btnQuit_Click(object sender, EventArgs e) => this.Close();
    }
}