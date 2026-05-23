using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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
            using (My_DB db = new My_DB())
            {
                string query = @"
        SELECT 
            CourseID,
            CourseID + ' - ' + CourseName AS CourseDisplay
        FROM Course";

                SqlCommand command =
                    new SqlCommand(query, db.getConnection);

                SqlDataAdapter adapter =
                    new SqlDataAdapter(command);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                // THÊM DÒNG NONE
                DataRow row = table.NewRow();

                row["CourseID"] = DBNull.Value;
                row["CourseDisplay"] = "-- None --";

                table.Rows.InsertAt(row, 0);

                cbo_PrerequisiteCourse.DataSource = table;

                cbo_PrerequisiteCourse.DisplayMember =
                    "CourseDisplay";

                cbo_PrerequisiteCourse.ValueMember =
                    "CourseID";

                cbo_PrerequisiteCourse.SelectedIndex = 0;
            }
        }
        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            // CHECK RỖNG
            if (txt_IDCourse.Text.Trim() == "")
            {
                MessageBox.Show("Please enter course ID!");

                txt_IDCourse.Focus();

                return;
            }

            if (txt_NameCourse.Text.Trim() == "")
            {
                MessageBox.Show("Please enter course name!");

                txt_NameCourse.Focus();

                return;
            }

            if (txt_CreditHour.Text.Trim() == "")
            {
                MessageBox.Show("Please enter credit hour!");

                txt_CreditHour.Focus();

                return;
            }

            if (txt_TheoryPeriod.Text.Trim() == "")
            {
                MessageBox.Show("Please enter theory period!");

                txt_TheoryPeriod.Focus();

                return;
            }

            if (txt_PracticalPeriod.Text.Trim() == "")
            {
                MessageBox.Show("Please enter practical period!");

                txt_PracticalPeriod.Focus();

                return;
            }

            using (My_DB db = new My_DB())
            {
                string courseID =
                    txt_IDCourse.Text.Trim();

                string courseName =
                    txt_NameCourse.Text.Trim();

                string overview =
                    txt_Overview.Text.Trim();

                int creditHour =
                    Convert.ToInt32(txt_CreditHour.Text);

                int theoryPeriod =
                    Convert.ToInt32(txt_TheoryPeriod.Text);

                int practicalPeriod =
                    Convert.ToInt32(txt_PracticalPeriod.Text);

                string query = @"
INSERT INTO Course
(
    CourseID,
    CourseName,
    CreditHour,
    Overview,
    PrerequisiteCourseID,
    TheoryPeriod,
    PracticalPeriod
)
VALUES
(
    @CourseID,
    @CourseName,
    @CreditHour,
    @Overview,
    @PrerequisiteCourseID,
    @TheoryPeriod,
    @PracticalPeriod
)";

                SqlCommand command =
                    new SqlCommand(query, db.getConnection);

                command.Parameters.Add("@CourseID",
                    SqlDbType.VarChar).Value = courseID;

                command.Parameters.Add("@CourseName",
                    SqlDbType.NVarChar).Value = courseName;

                command.Parameters.Add("@CreditHour",
                    SqlDbType.Int).Value = creditHour;

                command.Parameters.Add("@Overview",
                    SqlDbType.NVarChar).Value = overview;

                command.Parameters.Add("@TheoryPeriod",
                    SqlDbType.Int).Value = theoryPeriod;

                command.Parameters.Add("@PracticalPeriod",
                    SqlDbType.Int).Value = practicalPeriod;

                // PREREQUISITE COURSE
                if (cbo_PrerequisiteCourse.SelectedValue == DBNull.Value)
                {
                    command.Parameters.Add(
                        "@PrerequisiteCourseID",
                        SqlDbType.VarChar).Value =
                        DBNull.Value;
                }
                else
                {
                    command.Parameters.Add(
                        "@PrerequisiteCourseID",
                        SqlDbType.VarChar).Value =
                        cbo_PrerequisiteCourse.SelectedValue;
                }

                db.openConnection();

                int result =
                    command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(
                        "Add Course Successfully!");

                    txt_IDCourse.Clear();
                    txt_NameCourse.Clear();
                    txt_CreditHour.Clear();
                    txt_Overview.Clear();
                    txt_TheoryPeriod.Clear();
                    txt_PracticalPeriod.Clear();

                    cbo_PrerequisiteCourse.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(
                        "Add Course Failed!");
                }

                db.closeConnection();
            }
        }
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_IDCourse.Clear();

            txt_NameCourse.Clear();

            txt_CreditHour.Clear();

            txt_TheoryPeriod.Clear();

            txt_PracticalPeriod.Clear();

            txt_Overview.Clear();

            // Reset ComboBox về "-- None --"
            cbo_PrerequisiteCourse.SelectedIndex = 0;

            // Focus lại ô đầu tiên
            txt_IDCourse.Focus();
        }
    }

}
