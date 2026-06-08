using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;
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

            // GẮN EVENTS
            this.Load += f_AddClass_Load;
            btn_AddCourse.Click += btn_AddCourse_Click;
            btnClear.Click += btnClear_Click;
            btnQuit.Click += btnQuit_Click;
            cbo_CourseName.SelectedIndexChanged
                                += cbo_CourseName_SelectedIndexChanged;
        }

        // ================= LOAD FORM =================
        private void f_AddClass_Load(
            object sender,
            EventArgs e)
        {
            LoadCourseName();
            GenerateAcademicYear();
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

        // ================= SINH ACADEMIC YEAR =================
        private void GenerateAcademicYear()
        {
            int currentYear =
                DateTime.Now.Month >= 9
                ? DateTime.Now.Year
                : DateTime.Now.Year - 1;

            lbl_AcademicYearAuto.Text =
                $"{currentYear} - {currentYear + 1}";
        }

        // ================= SINH CLASS ID KHI CHỌN COURSE =================
        private void cbo_CourseName_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cbo_CourseName.SelectedItem == null)
            {
                lbl_ClassIDAuto.Text = "";
                return;
            }

            string display = cbo_CourseName.Text;
            string courseCode = display.Contains(" - ")
                ? display.Split(" - ")[0].Trim()
                : display.Trim();

            string year = lbl_AcademicYearAuto.Text.Contains(" - ")
                ? lbl_AcademicYearAuto.Text.Split(" - ")[0].Trim()
                : DateTime.Now.Year.ToString();

            lbl_ClassIDAuto.Text = $"{courseCode}-{year}";
        }

        // ================= ADD =================
        private void btn_AddCourse_Click(
            object sender,
            EventArgs e)
        {
            // VALIDATE
            if (cbo_CourseName.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a Course Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cbo_CourseName.Focus();
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

            // BUILD OBJECT
            var newClass = new Class
            {
                ClassID = lbl_ClassIDAuto.Text.Trim(),
                ClassName = txt_ClassCourse.Text.Trim(),
                AcademicYear = lbl_AcademicYearAuto.Text.Trim(),
                NumberOfStudent = 0,
                HomeroomTeacher =
                    string.IsNullOrWhiteSpace(txt_HomeroomTeacher.Text)
                    ? null
                    : txt_HomeroomTeacher.Text.Trim()
            };

            // SAVE
            bool ok = newClass.AddClassroom();

            MessageBox.Show(
                ok ? "Class added successfully!"
                   : "Failed to add class.",
                "Add Class",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information
                   : MessageBoxIcon.Error);

            if (ok) ClearForm();
        }

        // ================= RESET =================
        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cbo_CourseName.SelectedIndex = -1;
            txt_HomeroomTeacher.Clear();
            txt_ClassCourse.Clear();
            lbl_ClassIDAuto.Text = "";
            GenerateAcademicYear();
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