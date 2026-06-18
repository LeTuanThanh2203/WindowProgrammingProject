using System;
using System.Data;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_CourseRegistration : Form
    {
        private readonly Student _student = new();
        // Schema mới: currentID thay currentMSSV
        private string currentID = Globals.Username;

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
            // Schema mới: DKMH chỉ có (ID, ClassID, RegisterDate)
            // Semester và AcademicYear lấy từ bảng Class qua JOIN
            // Nên DataPropertyName bind theo cột trả về từ GetUnRegisteredCourses/GetRegisteredCourses

            // Unregistered grid columns
            txtClassIDUnRegister.DataPropertyName = "ClassID";
            txtCourseNameUnRegister.DataPropertyName = "CourseName";
            txtCreditUnRegister.DataPropertyName = "Credits";
            txtSemesterUnRegister.DataPropertyName = "Semester";
            txtAcademicYearUnRegister.DataPropertyName = "AcademicYear";
            txtCapacityUnRegister.DataPropertyName = "Capacity";
            txtCurrentStudentsUnRegister.DataPropertyName = "CurrentStudents";
            txtRoomUnRegister.DataPropertyName = "Room";
            txtScheduleUnRegister.DataPropertyName = "Schedule";

            // Registered grid columns
            txtClassIDRegister.DataPropertyName = "ClassID";
            txtCourseNameRegister.DataPropertyName = "CourseName";
            txtCreditRegister.DataPropertyName = "Credits";
            txtSemesterRegister.DataPropertyName = "Semester";
            txtAcademicYearRegister.DataPropertyName = "AcademicYear";
            txtRoomRegister.DataPropertyName = "Room";
            txtScheduleRegister.DataPropertyName = "Schedule";
            txtRegisterDateRegister.DataPropertyName = "RegisterDate";

            LoadCourse();
        }

        // ================= LOAD DATA =================
        private void LoadCourse()
        {
            // Schema mới: không cần truyền academicYear
            dgvUnRegistereCourse.DataSource = _student.GetUnRegisteredCourses(currentID);
            dgvRegistereCourse.DataSource = _student.GetRegisteredCourses(currentID);
        }

        // ================= HELPER LẤY ClassID TỪ ROW =================
        private string GetClassID(DataGridView dgv, int rowIndex)
        {
            if (dgv.Rows[rowIndex].DataBoundItem is not DataRowView item)
                return null;
            return item["ClassID"]?.ToString().Trim();
        }

        // ================= CLICK REGISTER =================
        private void dgvUnRegistereCourse_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUnRegistereCourse.Columns[e.ColumnIndex].Name != "btnRegister") return;

            string classID = GetClassID(dgvUnRegistereCourse, e.RowIndex);
            if (string.IsNullOrEmpty(classID)) return;

            // Schema mới: RegisterCourse chỉ nhận (id, classID)
            // TR_CheckDuplicate + TR_CheckCapacity ở SQL Server xử lý validation
            var result = Student.RegisterCourse(currentID, classID);

            MessageBox.Show(result.message);

            if (result.success) LoadCourse();
        }

        // ================= CLICK UNREGISTER =================
        private void dgvRegistereCourse_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvRegistereCourse.Columns[e.ColumnIndex].Name != "btnUnRegister") return;

            string classID = GetClassID(dgvRegistereCourse, e.RowIndex);
            if (string.IsNullOrEmpty(classID)) return;

            // Schema mới: CancelCourse chỉ nhận (id, classID)
            var result = Student.CancelCourse(currentID, classID);

            MessageBox.Show(result.message);

            if (result.success) LoadCourse();
        }

        // ================= SEARCH =================
        private void txtUnRegistereSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtUnRegistereSearch.Text.Trim();
            dgvUnRegistereCourse.DataSource = string.IsNullOrEmpty(kw)
                ? _student.GetUnRegisteredCourses(currentID)
                : _student.SearchUnRegisteredCourses(currentID, kw);
        }

        private void txtRegistereSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtRegistereSearch.Text.Trim();
            dgvRegistereCourse.DataSource = string.IsNullOrEmpty(kw)
                ? _student.GetRegisteredCourses(currentID)
                : _student.SearchRegisteredCourses(currentID, kw);
        }
    }
}