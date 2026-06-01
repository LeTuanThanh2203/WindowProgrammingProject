using Project_Group6.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_CourseRegistration : Form
    {
        private readonly Student student = new();
        private string currentMSSV = Globals.Username;
        private string academicYear;

        public f_CourseRegistration()
        {
            InitializeComponent();
            Load += f_CourseRegistration_Load;
            txtUnRegistereSearch.TextChanged += txtUnRegistereSearch_TextChanged;
            txtRegistereSearch.TextChanged += txtRegistereSearch_TextChanged;
            dgvUnRegistereCourse.CellClick += dgvUnRegistereCourse_CellClick;
            dgvRegistereCourse.CellClick += dgvRegistereCourse_CellClick;
        }

        // ================= LOAD =================
        private void f_CourseRegistration_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Month >= 9
                ? DateTime.Now.Year
                : DateTime.Now.Year - 1;

            academicYear = $"{currentYear} - {currentYear + 1}";
            lblAcademicYear.Text = academicYear;

            LoadCourse();
        }

        // ================= LOAD DATA =================
        private void LoadCourse()
        {
            dgvUnRegistereCourse.DataSource =
                student.GetUnRegisteredCourses(currentMSSV, academicYear);

            dgvRegistereCourse.DataSource =
                student.GetRegisteredCourses(currentMSSV, academicYear);

            MapColumns(dgvUnRegistereCourse, isRegister: true);
            MapColumns(dgvRegistereCourse, isRegister: false);
        }

        // ================= MAP CỘT =================
        private void MapColumns(DataGridView dgv, bool isRegister)
        {
            if (isRegister)
            {
                txtCourseCodeUnRegister.DataPropertyName = "CourseCode";
                txtCourseNameUnRegister.DataPropertyName = "CourseName";
                txtCreditHourUnRegister.DataPropertyName = "CreditHour";
                txtPrerequisiteCourseUnRegister.DataPropertyName = "Prerequisite Course";
                txtSemesterUnRegister.DataPropertyName = "Semester";
                txtWeekUnRegister.DataPropertyName = "Week";
                btnRegister.Text = "Register";
                btnRegister.UseColumnTextForButtonValue = true;
            }
            else
            {
                txtCourseCodeRegister.DataPropertyName = "CourseCode";
                txtCourseNameRegister.DataPropertyName = "CourseName";
                txtCreditHourRegister.DataPropertyName = "CreditHour";
                txtPrerequisiteCourseRegister.DataPropertyName = "Prerequisite Course";
                txtSemesterRegister.DataPropertyName = "Semester";
                txtWeekRegister.DataPropertyName = "Week";
                btnUnRegister.Text = "UnRegister";
                btnUnRegister.UseColumnTextForButtonValue = true;
            }
        }

        // ================= HELPER LẤY COURSE ID =================
        private int? GetCourseIDFromRow(DataGridView dgv, int rowIndex)
        {
            var item = dgv.Rows[rowIndex].DataBoundItem as DataRowView;
            if (item == null) return null;

            var val = item["CourseID"];
            if (val == null || val == DBNull.Value) return null;

            return Convert.ToInt32(val);
        }

        // ================= CLICK REGISTER =================
        // ================= CLICK REGISTER =================
        private void dgvUnRegistereCourse_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUnRegistereCourse.Columns[e.ColumnIndex].Name != "btnRegister") return;

            int? courseID = GetCourseIDFromRow(dgvUnRegistereCourse, e.RowIndex);
            if (courseID == null) return;

            var result = Student.RegisterCourse(currentMSSV, courseID.Value, academicYear);
            MessageBox.Show(result.message);

            if (result.success)
            {
                // Insert vào Score với điểm NULL
                Score score = new Score();
                score.AddScoreEmpty(currentMSSV, courseID.Value);
                LoadCourse();
            }
        }

        // ================= CLICK UNREGISTER =================
        private void dgvRegistereCourse_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRegistereCourse.Columns[e.ColumnIndex].Name != "btnUnRegister") return;

            int? courseID = GetCourseIDFromRow(dgvRegistereCourse, e.RowIndex);
            if (courseID == null) return;

            var result = Student.CancelCourse(currentMSSV, courseID.Value, academicYear);
            MessageBox.Show(result.message);
            if (result.success) LoadCourse();
        }

        // ================= SEARCH =================
        private void txtUnRegistereSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtUnRegistereSearch.Text.Trim();
            dgvUnRegistereCourse.DataSource = string.IsNullOrEmpty(kw)
                ? student.GetUnRegisteredCourses(currentMSSV, academicYear)
                : student.SearchUnRegisteredCourses(currentMSSV, academicYear, kw);

            MapColumns(dgvUnRegistereCourse, isRegister: true);
        }

        private void txtRegistereSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtRegistereSearch.Text.Trim();
            dgvRegistereCourse.DataSource = string.IsNullOrEmpty(kw)
                ? student.GetRegisteredCourses(currentMSSV, academicYear)
                : student.SearchRegisteredCourses(currentMSSV, academicYear, kw);

            MapColumns(dgvRegistereCourse, isRegister: false);
        }
    }
}