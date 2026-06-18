using Project_Group6.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_AddClass : Form
    {
        private readonly Class _class = new();
        private readonly Course _course = new();

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

        // ================= ACADEMIC YEAR =================
        private void GenerateAcademicYear()
        {
            int y = DateTime.Now.Month >= 9
                  ? DateTime.Now.Year
                  : DateTime.Now.Year - 1;
            lbl_AcademicYearAuto.Text = $"{y}-{y + 1}";
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

            string courseID = cbo_CourseName.SelectedValue.ToString().Trim();
            string yearShort = GenerateYearShort(lbl_AcademicYearAuto.Text);
            string semCode = SemesterCode();

            // Format: CS101_01_2526
            lbl_ClassIDAuto.Text = $"{courseID}_{semCode}_{yearShort}";
        }

        // ================= HELPERS =================
        private string SemesterCode() =>
            cboSemester.SelectedItem?.ToString() switch
            {
                "Semester 1" => "01",
                "Semester 2" => "02",
                "Summer" => "03",
                _ => "01"
            };

        // Semester dạng NVARCHAR(20) theo schema
        private string SemesterValue() =>
            cboSemester.SelectedItem?.ToString() switch
            {
                "Semester 1" => "HK1",
                "Semester 2" => "HK2",
                "Summer" => "Summer",
                _ => "HK1"
            };

        // "2025-2026" → "2526"
        private string GenerateYearShort(string academicYear)
        {
            try
            {
                string[] parts = academicYear.Split('-');
                if (parts.Length == 2)
                {
                    string y1 = parts[0].Trim();
                    string y2 = parts[1].Trim();
                    return y1[^2..] + y2[^2..];
                }
            }
            catch { }
            return DateTime.Now.Year.ToString()[^2..];
        }

        // ================= ADD =================
        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            if (cbo_CourseName.SelectedValue == null
             || cbo_CourseName.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Please select a Course.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_Capacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Capacity must be a positive number.",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txt_Capacity.Focus();
                return;
            }

            var newClass = new Class
            {
                ClassID = lbl_ClassIDAuto.Text.Trim(),
                CourseID = cbo_CourseName.SelectedValue.ToString().Trim(),
                Semester = SemesterValue(),
                AcademicYear = lbl_AcademicYearAuto.Text.Trim(),
                Capacity = capacity,
                CurrentStudents = 0,
                Room = string.IsNullOrWhiteSpace(txt_Room.Text)
                               ? null : txt_Room.Text.Trim(),
                Schedule = string.IsNullOrWhiteSpace(txt_Schedule.Text)
                               ? null : txt_Schedule.Text.Trim()
            };

            bool ok = newClass.AddClassroom();

            MessageBox.Show(
                ok ? "Class added successfully!" : "Failed to add class.",
                "Add Class", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) ClearForm();
        }

        // ================= CLEAR =================
        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            cbo_CourseName.SelectedIndex = -1;
            cboSemester.SelectedIndex = 0;
            txt_Capacity.Clear();
            txt_Room.Clear();
            txt_Schedule.Clear();
            lbl_ClassIDAuto.Text = "";
            GenerateAcademicYear();
        }

        private void btnQuit_Click(object sender, EventArgs e) => this.Close();
    }
}