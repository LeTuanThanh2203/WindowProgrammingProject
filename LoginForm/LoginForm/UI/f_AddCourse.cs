using Microsoft.Data.SqlClient;
using Project_Group6.Models;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            Course course =
                new Course();

            DataTable table =
                course.GetPrerequisiteCourse();

            // ADD NONE
            DataRow row =
                table.NewRow();

            row["CourseID"] =
                DBNull.Value;

            row["CourseDisplay"] =
                "-- None --";

            table.Rows.InsertAt(row, 0);

            cbo_PrerequisiteCourse.DataSource =
                table;

            cbo_PrerequisiteCourse.DisplayMember =
                "CourseDisplay";

            cbo_PrerequisiteCourse.ValueMember =
                "CourseID";

            cbo_PrerequisiteCourse.SelectedIndex = 0;

            cbo_Semester.Items.Clear();
            cbo_Semester.Items.Add("Semester 1");
            cbo_Semester.Items.Add("Semester 2");
            cbo_Semester.Items.Add("Summer");
            cbo_Semester.SelectedIndex = 0;
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
                MessageBox.Show("Credit hour must be number!");
                return;
            }

            if (!int.TryParse(txt_TheoryPeriod.Text, out int theoryPeriod))
            {
                MessageBox.Show("Theory period must be number!");
                return;
            }

            if (!int.TryParse(txt_PracticalPeriod.Text, out int practicalPeriod))
            {
                MessageBox.Show("Practical period must be number!");
                return;
            }

            // SEMESTER FIX (ComboBox: 1 / 2 / Summer)
            int semesterValue = 1;

            if (cbo_Semester.SelectedItem != null)
            {
                string sem = cbo_Semester.SelectedItem.ToString();

                if (sem.Contains("1")) semesterValue = 1;
                else if (sem.Contains("2")) semesterValue = 2;
                else semesterValue = 3; // Summer
            }

            int? prereq = null;

            if (cbo_PrerequisiteCourse.SelectedValue != null &&
                cbo_PrerequisiteCourse.SelectedValue != DBNull.Value)
            {
                int temp;

                if (int.TryParse(
                    cbo_PrerequisiteCourse.SelectedValue.ToString(),
                    out temp))
                {
                    if (temp != 0)
                        prereq = temp;
                }
            }

            // CREATE OBJECT (KHÔNG CẦN COURSEID)
            Course course = new Course
            {
                CourseCode = txt_CourseCode.Text.Trim(),
                CourseName = txt_NameCourse.Text.Trim(),
                CreditHour = creditHour,
                Semester = semesterValue,
                Week = Convert.ToInt32(txt_Week.Text),
                Overview = txt_Overview.Text.Trim(),
                PrerequisiteCourseID = prereq,
                TheoryPeriod = theoryPeriod,
                PracticalPeriod = practicalPeriod
            };

            // ADD
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
            cbo_Semester.SelectedIndex = 0;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
     

            txt_NameCourse.Clear();

            txt_CreditHour.Clear();

            txt_TheoryPeriod.Clear();

            txt_PracticalPeriod.Clear();

            txt_Overview.Clear();

            // Reset ComboBox về "-- None --"
            cbo_PrerequisiteCourse.SelectedIndex = 0;

   
        }

   
    }

}
