using System;
using System.Data;
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
            this.Load += f_EditDeleteClass_Load;
            this.Shown += f_EditDeleteClass_Shown;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnQuit.Click += btnQuit_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            dgvCourse.CellClick += dgvCourse_CellClick;
            cbo_CourseName.SelectedIndexChanged
                                         += cbo_CourseName_SelectedIndexChanged;
        }

        // ================= LOAD =================
        private void f_EditDeleteClass_Load(object sender, EventArgs e)
        {
            cboSort.Items.AddRange(new[]
            {
                "Name A-Z", "Name Z-A",
                "Year Asc", "Year Desc"
            });
            cboSort.SelectedIndex = 0;

            LoadCourseName();
            LoadSemester();

            isLoaded = true;
        }

        private void f_EditDeleteClass_Shown(object sender, EventArgs e)
            => LoadData();

        // ================= LOAD COURSE =================
        private void LoadCourseName()
        {
            DataTable dt = _course.GetCoursesForCombo();

            cbo_CourseName.DataSource = dt;
            cbo_CourseName.DisplayMember = "CourseDisplay";
            cbo_CourseName.ValueMember = "CourseCode";   // ← string
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

        // ================= HELPER: semester int =================
        private int SemesterValue()
        {
            return cboSemester.SelectedItem?.ToString() switch
            {
                "Semester 1" => 1,
                "Semester 2" => 2,
                "Summer" => 3,
                _ => 1
            };
        }

        // ================= HELPER: int → combobox text =================
        private void SetSemesterCombo(int semester)
        {
            cboSemester.SelectedItem = semester switch
            {
                1 => "Semester 1",
                2 => "Semester 2",
                3 => "Summer",
                _ => "Semester 1"
            };
        }

        // ================= LOAD DATA =================
        private void LoadData()
        {
            string keyword = txtSearch.Text.Trim();

            DataTable dt = string.IsNullOrEmpty(keyword)
                ? GetAllClassesTable()
                : _class.SearchClassrooms(keyword);

            DataView dv = dt.DefaultView;
            string sort = cboSort.SelectedItem?.ToString();

            if (sort == "Name A-Z") dv.Sort = "ClassName ASC";
            else if (sort == "Name Z-A") dv.Sort = "ClassName DESC";
            else if (sort == "Year Asc") dv.Sort = "AcademicYear ASC";
            else if (sort == "Year Desc") dv.Sort = "AcademicYear DESC";

            dgvCourse.DataSource = dv.ToTable();
            FormatGrid();
            ClearForm();
        }

        // SearchClassrooms("") trả về đúng, nhưng dùng riêng để rõ ý
        private DataTable GetAllClassesTable()
            => _class.SearchClassrooms("");

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
            dgvCourse.BorderStyle = BorderStyle.None;
        }

        // ================= CLICK GRID =================
        private void dgvCourse_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCourse.Rows[e.RowIndex];

            lbl_ClassIDAuto.Text = row.Cells["ClassID"].Value?.ToString();
            lbl_AcademicYearAuto.Text = row.Cells["AcademicYear"].Value?.ToString();
            txt_ClassCourse.Text = row.Cells["ClassName"].Value?.ToString();

            // Manager → txt_HomeroomTeacher (giữ tên control cũ)
            txt_HomeroomTeacher.Text =
                row.Cells["Manager"].Value?.ToString() ?? "";

            // Semester
            if (int.TryParse(
                    row.Cells["Semester"].Value?.ToString(),
                    out int sem))
                SetSemesterCombo(sem);

            // CourseCode → bind combobox
            string courseCode =
                row.Cells["CourseCode"].Value?.ToString().Trim() ?? "";

            cbo_CourseName.SelectedValue = courseCode;
        }

        // ================= AUTO CLASS ID =================
        private void cbo_CourseName_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Chỉ sinh ClassID khi chưa chọn từ grid
            if (!string.IsNullOrEmpty(lbl_ClassIDAuto.Text)) return;

            if (cbo_CourseName.SelectedValue == null
             || cbo_CourseName.SelectedValue == DBNull.Value)
                return;

            string courseCode = cbo_CourseName.SelectedValue
                                              .ToString().Trim();
            string year = lbl_AcademicYearAuto.Text.Contains("-")
                ? lbl_AcademicYearAuto.Text.Split('-')[0].Trim()
                : DateTime.Now.Year.ToString();

            lbl_ClassIDAuto.Text = $"{courseCode}-{year}-S{SemesterValue()}";
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lbl_ClassIDAuto.Text))
            {
                MessageBox.Show("Please select a class from the list.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ClassCourse.Text))
            {
                MessageBox.Show("Please enter Class Name.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_ClassCourse.Focus();
                return;
            }

            var updated = new Class
            {
                ClassID = lbl_ClassIDAuto.Text.Trim(),
                CourseCode = cbo_CourseName.SelectedValue?
                                               .ToString().Trim() ?? "",
                ClassName = txt_ClassCourse.Text.Trim(),
                Semester = SemesterValue(),
                AcademicYear = lbl_AcademicYearAuto.Text.Trim(),
                NumberOfStudent = 0,
                Manager = string.IsNullOrWhiteSpace(
                                    txt_HomeroomTeacher.Text)
                                  ? null
                                  : txt_HomeroomTeacher.Text.Trim()
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
                    "No Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string classID = lbl_ClassIDAuto.Text.Trim();
            string className = txt_ClassCourse.Text.Trim();

            if (MessageBox.Show(
                    $"Delete class \"{className}\"?\nThis cannot be undone.",
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
            if (isLoaded) LoadData();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded) LoadData();
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
            txt_ClassCourse.Clear();
            txt_HomeroomTeacher.Clear();
            cbo_CourseName.SelectedIndex = -1;
            cboSemester.SelectedIndex = 0;
        }

        private void btnQuit_Click(object sender, EventArgs e)
            => this.Close();
    }
}