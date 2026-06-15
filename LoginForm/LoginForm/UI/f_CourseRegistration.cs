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
            int y = DateTime.Now.Month >= 9
                  ? DateTime.Now.Year
                  : DateTime.Now.Year - 1;

            academicYear = $"{y}-{y + 1}";

            lblAcademicYearRegister.Text = academicYear;
            lblAcademicYearUnRegister.Text = academicYear;

            // Set DataPropertyName 1 lần duy nhất
            txtClassIDUnRegister.DataPropertyName = "ClassID";
            txtClassNameUnRegister.DataPropertyName = "ClassName";
            txtCourseNameUnRegister.DataPropertyName = "CourseName";
            txtManagerNameUnRegister.DataPropertyName = "Manager";
            txtCreditHourUnRegister.DataPropertyName = "CreditHour";
            txtPrerequisiteCourseUnRegister.DataPropertyName = "Prerequisite Course";
            txtSemesterUnRegister.DataPropertyName = "Semester";
            txtWeekUnRegister.DataPropertyName = "Week";

            txtClassIDRegister.DataPropertyName = "ClassID";
            txtClassNameRegister.DataPropertyName = "ClassName";
            txtCourseNameRegister.DataPropertyName = "CourseName";
            txtManagerNameRegister.DataPropertyName = "Manager";
            txtCreditHourRegister.DataPropertyName = "CreditHour";
            txtPrerequisiteCourseRegister.DataPropertyName = "Prerequisite Course";
            txtSemesterRegister.DataPropertyName = "Semester";
            txtWeekRegister.DataPropertyName = "Week";

            LoadCourse();
        }

        // ================= LOAD DATA =================
        private void LoadCourse()
        {
            dgvUnRegistereCourse.DataSource =
                student.GetUnRegisteredCourses(currentMSSV, academicYear);

            dgvRegistereCourse.DataSource =
                student.GetRegisteredCourses(currentMSSV, academicYear);
        }

        // ================= HELPER LẤY ClassID + Semester =================
        private (string classID, int semester) GetRowInfo(
            DataGridView dgv, int rowIndex)
        {
            if (dgv.Rows[rowIndex].DataBoundItem is not DataRowView item)
                return (null, 0);

            string classID = item["ClassID"]?.ToString().Trim();

            int sem = 1;
            if (item.Row.Table.Columns.Contains("Semester")
             && item["Semester"] != DBNull.Value)
                sem = Convert.ToInt32(item["Semester"]);

            return (classID, sem);
        }

        // ================= CLICK REGISTER =================
        private void dgvUnRegistereCourse_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUnRegistereCourse.Columns[e.ColumnIndex].Name != "btnRegister") return;

            var (classID, semester) = GetRowInfo(dgvUnRegistereCourse, e.RowIndex);
            if (string.IsNullOrEmpty(classID)) return;

            var result = Student.RegisterCourse(
                currentMSSV, classID, semester, academicYear);

            MessageBox.Show(result.message);

            if (result.success)
                LoadCourse();
        }

        // ================= CLICK UNREGISTER =================
        private void dgvRegistereCourse_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRegistereCourse.Columns[e.ColumnIndex].Name != "btnUnRegister") return;

            var (classID, semester) = GetRowInfo(dgvRegistereCourse, e.RowIndex);
            if (string.IsNullOrEmpty(classID)) return;

            var result = Student.CancelCourse(
                currentMSSV, classID, semester, academicYear);

            MessageBox.Show(result.message);

            if (result.success)
                LoadCourse();
        }

        // ================= SEARCH =================
        private void txtUnRegistereSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtUnRegistereSearch.Text.Trim();
            dgvUnRegistereCourse.DataSource = string.IsNullOrEmpty(kw)
                ? student.GetUnRegisteredCourses(currentMSSV, academicYear)
                : student.SearchUnRegisteredCourses(currentMSSV, academicYear, kw);
        }

        private void txtRegistereSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtRegistereSearch.Text.Trim();
            dgvRegistereCourse.DataSource = string.IsNullOrEmpty(kw)
                ? student.GetRegisteredCourses(currentMSSV, academicYear)
                : student.SearchRegisteredCourses(currentMSSV, academicYear, kw);
        }
    }
}