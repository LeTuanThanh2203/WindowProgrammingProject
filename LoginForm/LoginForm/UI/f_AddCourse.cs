using Microsoft.Data.SqlClient;
using Project_Group6.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_AddCourse : Form
    {
        public f_AddCourse()
        {
            InitializeComponent();
            LoadPrerequisiteCourse();
        }

        private void LoadPrerequisiteCourse()
        {
            Course course = new Course();
            DataTable table = course.GetPrerequisiteCourse();

            // Thêm dòng "-- None --" với CourseCode = null/empty
            DataRow row = table.NewRow();
            row["CourseCode"] = DBNull.Value;
            row["CourseDisplay"] = "-- None --";
            table.Rows.InsertAt(row, 0);

            cbo_PrerequisiteCourse.DataSource = table;
            cbo_PrerequisiteCourse.DisplayMember = "CourseDisplay";
            cbo_PrerequisiteCourse.ValueMember = "CourseCode";   // ← string, không phải int
            cbo_PrerequisiteCourse.SelectedIndex = 0;
        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            // VALIDATION
            if (txt_NameCourse.Text.Trim() == "")
            {
                MessageBox.Show("Please enter course name!");
                return;
            }
            if (!int.TryParse(txt_CreditHour.Text, out int creditHour))
            {
                MessageBox.Show("Credit hour must be a number!");
                return;
            }
            if (!int.TryParse(txt_TheoryPeriod.Text, out int theoryPeriod))
            {
                MessageBox.Show("Theory period must be a number!");
                return;
            }
            if (!int.TryParse(txt_PracticalPeriod.Text, out int practicalPeriod))
            {
                MessageBox.Show("Practical period must be a number!");
                return;
            }
            if (!int.TryParse(txt_Week.Text, out int week))
            {
                MessageBox.Show("Week must be a number!");
                return;
            }

            // PREREQUISITE — lấy CourseCode (string), null nếu chọn None
            string prereqCode = null;
            if (cbo_PrerequisiteCourse.SelectedValue != null &&
                cbo_PrerequisiteCourse.SelectedValue != DBNull.Value)
            {
                string val = cbo_PrerequisiteCourse.SelectedValue.ToString().Trim();
                if (val != "")
                    prereqCode = val;
            }

            Course course = new Course
            {
                CourseCode = txt_CourseCode.Text.Trim(),
                CourseName = txt_NameCourse.Text.Trim(),
                CreditHour = creditHour,
                TheoryPeriod = theoryPeriod,
                PracticalPeriod = practicalPeriod,
                Overview = txt_Overview.Text.Trim(),
                PrerequisiteCourseCode = prereqCode,   // ← string
                Week = week
            };

            if (course.AddCourse())
            {
                MessageBox.Show("Add Course Successfully!");
                ClearForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("Add Course Failed!");
            }
        }

        private void ClearForm()
        {
            txt_NameCourse.Clear();
            txt_CourseCode.Clear();
            txt_CreditHour.Clear();
            txt_TheoryPeriod.Clear();
            txt_PracticalPeriod.Clear();
            txt_Overview.Clear();
            txt_Week.Clear();
            cbo_PrerequisiteCourse.SelectedIndex = 0;
        }

        private void bt_Cancel_Click(object sender, EventArgs e) => this.Close();

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();
    }
}