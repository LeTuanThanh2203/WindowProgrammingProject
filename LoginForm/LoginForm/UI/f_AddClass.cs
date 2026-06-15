using System;
using System.Data;
using Project_Group6.Models;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_AddClass : Form
    {
        Class _class = new Class();
        Course _course = new Course();

        public f_AddClass()
        {
            InitializeComponent();
            this.Load += f_AddClass_Load;
            btn_AddCourse.Click += btn_AddCourse_Click;
            btnClear.Click += btnClear_Click;
            btnQuit.Click += btnQuit_Click;

            // Cả 2 đều gọi chung UpdateClassID
            cbo_CourseName.SelectedIndexChanged += (s, e) => UpdateClassID();
            cboSemester.SelectedIndexChanged += (s, e) => UpdateClassID();
        }
        // ================= AUTO CLASS ID =================
        private void UpdateClassID()
        {
            if (cbo_CourseName.SelectedValue == null
             || cbo_CourseName.SelectedValue == DBNull.Value
             || cbo_CourseName.SelectedIndex == -1)
            {
                lbl_ClassIDAuto.Text = "";
                return;
            }

            string courseCode = cbo_CourseName.SelectedValue.ToString().Trim();
            string yearShort = GenerateYearShort(lbl_AcademicYearAuto.Text);
            string semCode = SemesterCode();

            lbl_ClassIDAuto.Text = $"{courseCode}_{semCode}_{yearShort}";
        }

        // ================= LOAD =================
        private void f_AddClass_Load(object sender, EventArgs e)
        {
            LoadCourseName();
            LoadSemester();
            GenerateAcademicYear();
        }

        // ================= LOAD COURSE =================
        private void LoadCourseName()
        {
            DataTable dt = _course.GetCoursesForCombo();

            cbo_CourseName.DataSource = dt;
            cbo_CourseName.DisplayMember = "CourseDisplay";
            cbo_CourseName.ValueMember = "CourseCode";   // ← string CourseCode
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

        // ================= ACADEMIC YEAR =================
        private void GenerateAcademicYear()
        {
            int y = DateTime.Now.Month >= 9
                  ? DateTime.Now.Year
                  : DateTime.Now.Year - 1;
            lbl_AcademicYearAuto.Text = $"{y}-{y + 1}";
        }

        // ================= AUTO CLASS ID =================
        private void cbo_CourseName_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (cbo_CourseName.SelectedValue == null
             || cbo_CourseName.SelectedValue == DBNull.Value)
            {
                lbl_ClassIDAuto.Text = "";
                return;
            }

            string courseCode = cbo_CourseName.SelectedValue
                                              .ToString().Trim();

            // Lấy 2 số cuối của từng năm: "2025-2026" → "2526"
            string yearShort = GenerateYearShort(lbl_AcademicYearAuto.Text);

            string semCode = SemesterCode();

            // Format: CS101_01_2526
            lbl_ClassIDAuto.Text = $"{courseCode}_{semCode}_{yearShort}";
        }

        // ================= HELPER: semester code =================
        private string SemesterCode()
        {
            return cboSemester.SelectedItem?.ToString() switch
            {
                "Semester 1" => "01",
                "Semester 2" => "02",
                "Summer" => "03",
                _ => "01"
            };
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

        // ================= HELPER: year short =================
        // "2025-2026" → "2526"
        private string GenerateYearShort(string academicYear)
        {
            try
            {
                string[] parts = academicYear.Split('-');
                if (parts.Length == 2)
                {
                    string y1 = parts[0].Trim(); // "2025"
                    string y2 = parts[1].Trim(); // "2026"

                    // Lấy 2 số cuối mỗi năm
                    return y1.Substring(y1.Length - 2)
                         + y2.Substring(y2.Length - 2); // "2526"
                }
            }
            catch { }

            return DateTime.Now.Year.ToString().Substring(2);
        }
        // ================= ADD =================
        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            if (cbo_CourseName.SelectedValue == null
             || cbo_CourseName.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Please select a Course Name.",
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

            var newClass = new Class
            {
                ClassID = lbl_ClassIDAuto.Text.Trim(),
                CourseCode = cbo_CourseName.SelectedValue
                                               .ToString().Trim(),
                ClassName = txt_ClassCourse.Text.Trim(),
                Semester = SemesterValue(),
                AcademicYear = lbl_AcademicYearAuto.Text.Trim(),
                NumberOfStudent = 0,
                Manager = string.IsNullOrWhiteSpace(
                                    txt_HomeroomTeacher.Text)
                                  ? null
                                  : txt_HomeroomTeacher.Text.Trim()
            };

            bool ok = newClass.AddClassroom();

            MessageBox.Show(
                ok ? "Class added successfully!" : "Failed to add class.",
                "Add Class", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) ClearForm();
        }

        // ================= CLEAR =================
        private void btnClear_Click(object sender, EventArgs e)
            => ClearForm();

        private void ClearForm()
        {
            cbo_CourseName.SelectedIndex = -1;
            cboSemester.SelectedIndex = 0;
            txt_ClassCourse.Clear();
            txt_HomeroomTeacher.Clear();
            lbl_ClassIDAuto.Text = "";
            GenerateAcademicYear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
            => this.Close();
    }
}