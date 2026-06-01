using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System.Windows.Forms;

namespace Project_Group6.Models
{
    internal class Course
    {
        // ================= PROPERTIES =================
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CreditHour { get; set; }
        public int Semester { get; set; }
        public int Week { get; set; }
        public string Overview { get; set; }
        public int? PrerequisiteCourseID { get; set; }
        public int TheoryPeriod { get; set; }
        public int PracticalPeriod { get; set; }

        public Course() { }

        public Course(int courseID, string courseCode, string courseName,
            int creditHour, int semester, int week, string overview,
            int? prerequisiteCourseID, int theoryPeriod, int practicalPeriod)
        {
            CourseID = courseID;
            CourseCode = courseCode;
            CourseName = courseName;
            CreditHour = creditHour;
            Semester = semester;
            Week = week;
            Overview = overview;
            PrerequisiteCourseID = prerequisiteCourseID;
            TheoryPeriod = theoryPeriod;
            PracticalPeriod = practicalPeriod;
        }

        // ================= HELPERS =================
        private DataTable ExecuteQuery(string query, Action<SqlCommand> addParams = null)
        {
            var table = new DataTable();
            try
            {
                using (var db = new My_DB())
                {
                    var cmd = new SqlCommand(query, db.getConnection);
                    addParams?.Invoke(cmd);
                    new SqlDataAdapter(cmd).Fill(table);
                }
            }
            catch { }
            return table;
        }

        private bool ExecuteNonQuery(string query, Action<SqlCommand> addParams = null)
        {
            try
            {
                using (var db = new My_DB())
                {
                    db.openConnection();
                    var cmd = new SqlCommand(query, db.getConnection);
                    addParams?.Invoke(cmd);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void AddCourseParams(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@courseCode", CourseCode);
            cmd.Parameters.AddWithValue("@courseName", CourseName);
            cmd.Parameters.AddWithValue("@creditHour", CreditHour);
            cmd.Parameters.AddWithValue("@semester", Semester);
            cmd.Parameters.AddWithValue("@week", Week);
            cmd.Parameters.AddWithValue("@overview", (object)Overview ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@prerequisiteCourseID", (object)PrerequisiteCourseID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@theoryPeriod", TheoryPeriod);
            cmd.Parameters.AddWithValue("@practicalPeriod", PracticalPeriod);
        }

        // ================= ADD =================
        public bool AddCourse() =>
            ExecuteNonQuery(@"
                INSERT INTO Course
                    (CourseCode, CourseName, CreditHour, Semester, Week,
                     Overview, PrerequisiteCourseID, TheoryPeriod, PracticalPeriod)
                VALUES
                    (@courseCode, @courseName, @creditHour, @semester, @week,
                     @overview, @prerequisiteCourseID, @theoryPeriod, @practicalPeriod)",
                AddCourseParams);

        // ================= EDIT =================
        public bool EditCourse() =>
            ExecuteNonQuery(@"
                UPDATE Course SET
                    CourseCode           = @courseCode,
                    CourseName           = @courseName,
                    CreditHour           = @creditHour,
                    Semester             = @semester,
                    Week                 = @week,
                    Overview             = @overview,
                    PrerequisiteCourseID = @prerequisiteCourseID,
                    TheoryPeriod         = @theoryPeriod,
                    PracticalPeriod      = @practicalPeriod
                WHERE CourseID = @courseID",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@courseID", CourseID);
                    AddCourseParams(cmd);
                });

        // ================= DELETE =================
        public static bool DelCourse(int courseID)
        {
            try
            {
                using (var db = new My_DB())
                {
                    db.openConnection();
                    var cmd = new SqlCommand(
                        "DELETE FROM Course WHERE CourseID = @courseID",
                        db.getConnection);
                    cmd.Parameters.AddWithValue("@courseID", courseID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // ================= GET ALL =================
        public DataTable GetCourse() =>
            ExecuteQuery("SELECT * FROM Course");

        // ================= GET BY ID =================
        public Course GetCourseByID(int courseID)
        {
            Course course = null;
            try
            {
                using (var db = new My_DB())
                {
                    db.openConnection();
                    var cmd = new SqlCommand(
                        "SELECT * FROM Course WHERE CourseID = @courseID",
                        db.getConnection);
                    cmd.Parameters.AddWithValue("@courseID", courseID);

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        course = new Course
                        {
                            CourseID = Convert.ToInt32(reader["CourseID"]),
                            CourseCode = reader["CourseCode"].ToString(),
                            CourseName = reader["CourseName"].ToString(),
                            CreditHour = Convert.ToInt32(reader["CreditHour"]),
                            Semester = Convert.ToInt32(reader["Semester"]),
                            Week = Convert.ToInt32(reader["Week"]),
                            Overview = reader["Overview"].ToString(),
                            TheoryPeriod = Convert.ToInt32(reader["TheoryPeriod"]),
                            PracticalPeriod = Convert.ToInt32(reader["PracticalPeriod"]),
                            PrerequisiteCourseID = reader["PrerequisiteCourseID"] != DBNull.Value
                                ? Convert.ToInt32(reader["PrerequisiteCourseID"])
                                : null
                        };
                    }
                }
            }
            catch { }
            return course;
        }

        // ================= SEARCH =================
        public DataTable SearchCourse(string keyword) =>
            ExecuteQuery(@"
                SELECT * FROM Course
                WHERE CourseCode LIKE @kw
                   OR CourseName LIKE @kw
                   OR Overview   LIKE @kw",
                cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

        // ================= FOR COMBOBOX =================
        public DataTable GetPrerequisiteCourse() =>
            ExecuteQuery(@"
                SELECT CourseID,
                       CourseCode + ' - ' + CourseName AS CourseDisplay
                FROM Course");

        public DataTable GetCoursesForCombo() =>
            ExecuteQuery(@"
                SELECT CourseID,
                       CourseCode + ' - ' + CourseName AS CourseDisplay,
                       CreditHour
                FROM Course
                ORDER BY CourseCode");

        // ================= TOTAL =================
        public int TotalCourse()
        {
            try
            {
                using (var db = new My_DB())
                {
                    db.openConnection();
                    var cmd = new SqlCommand("SELECT COUNT(*) FROM Course", db.getConnection);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }
    }
}