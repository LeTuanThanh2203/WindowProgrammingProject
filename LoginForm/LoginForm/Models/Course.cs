using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Group6.Models
{
    internal class Course
    {
        // ================= PROPERTIES =================
        // Theo schema: CourseID, CourseCode, CourseName, CreditHour,
        //              TheoryPeriod, PracticalPeriod, Overview,
        //              PrerequisiteCourseCode, Week
        // KHÔNG còn: Semester, PrerequisiteCourseID
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int CreditHour { get; set; }
        public int TheoryPeriod { get; set; }
        public int PracticalPeriod { get; set; }
        public string Overview { get; set; }
        public string PrerequisiteCourseCode { get; set; } // CHAR(10), nullable
        public int Week { get; set; }

        public Course() { }

        public Course(int courseID, string courseCode, string courseName,
            int creditHour, int theoryPeriod, int practicalPeriod,
            string overview, string prerequisiteCourseCode, int week)
        {
            CourseID = courseID;
            CourseCode = courseCode;
            CourseName = courseName;
            CreditHour = creditHour;
            TheoryPeriod = theoryPeriod;
            PracticalPeriod = practicalPeriod;
            Overview = overview;
            PrerequisiteCourseCode = prerequisiteCourseCode;
            Week = week;
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
            cmd.Parameters.Add("@courseCode", SqlDbType.Char, 10).Value = CourseCode;
            cmd.Parameters.Add("@courseName", SqlDbType.NVarChar, 100).Value = CourseName;
            cmd.Parameters.Add("@creditHour", SqlDbType.Int).Value = CreditHour;
            cmd.Parameters.Add("@theoryPeriod", SqlDbType.Int).Value = TheoryPeriod;
            cmd.Parameters.Add("@practicalPeriod", SqlDbType.Int).Value = PracticalPeriod;
            cmd.Parameters.Add("@overview", SqlDbType.NVarChar, 500).Value = (object)Overview ?? DBNull.Value;
            cmd.Parameters.Add("@prerequisiteCourseCode", SqlDbType.Char, 10).Value = (object)PrerequisiteCourseCode ?? DBNull.Value;
            cmd.Parameters.Add("@week", SqlDbType.Int).Value = Week;
        }

        // ================= ADD =================
        public bool AddCourse() =>
            ExecuteNonQuery(@"
                INSERT INTO Course
                    (CourseCode, CourseName, CreditHour,
                     TheoryPeriod, PracticalPeriod, Overview,
                     PrerequisiteCourseCode, Week)
                VALUES
                    (@courseCode, @courseName, @creditHour,
                     @theoryPeriod, @practicalPeriod, @overview,
                     @prerequisiteCourseCode, @week)",
                AddCourseParams);

        // ================= EDIT =================
        public bool EditCourse() =>
            ExecuteNonQuery(@"
                UPDATE Course SET
                    CourseCode             = @courseCode,
                    CourseName             = @courseName,
                    CreditHour             = @creditHour,
                    TheoryPeriod           = @theoryPeriod,
                    PracticalPeriod        = @practicalPeriod,
                    Overview               = @overview,
                    PrerequisiteCourseCode = @prerequisiteCourseCode,
                    Week                   = @week
                WHERE CourseID = @courseID",
                cmd =>
                {
                    cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = CourseID;
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
                    cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // ================= GET ALL =================
        public DataTable GetCourse() =>
            ExecuteQuery("SELECT * FROM Course ORDER BY CourseCode");

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
                    cmd.Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                        course = MapFromReader(reader);
                }
            }
            catch { }
            return course;
        }

        // ================= GET BY CODE =================
        public Course GetCourseByCode(string courseCode)
        {
            Course course = null;
            try
            {
                using (var db = new My_DB())
                {
                    db.openConnection();
                    var cmd = new SqlCommand(
                        "SELECT * FROM Course WHERE CourseCode = @courseCode",
                        db.getConnection);
                    cmd.Parameters.Add("@courseCode", SqlDbType.Char, 10).Value = courseCode;

                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                        course = MapFromReader(reader);
                }
            }
            catch { }
            return course;
        }

        private static Course MapFromReader(SqlDataReader reader) => new Course
        {
            CourseID = Convert.ToInt32(reader["CourseID"]),
            CourseCode = reader["CourseCode"].ToString().Trim(),
            CourseName = reader["CourseName"].ToString(),
            CreditHour = Convert.ToInt32(reader["CreditHour"]),
            TheoryPeriod = Convert.ToInt32(reader["TheoryPeriod"]),
            PracticalPeriod = Convert.ToInt32(reader["PracticalPeriod"]),
            Overview = reader["Overview"]?.ToString(),
            PrerequisiteCourseCode = reader["PrerequisiteCourseCode"] != DBNull.Value
                                        ? reader["PrerequisiteCourseCode"].ToString().Trim()
                                        : null,
            Week = Convert.ToInt32(reader["Week"])
        };

        // ================= SEARCH =================
        public DataTable SearchCourse(string keyword) =>
            ExecuteQuery(@"
                SELECT * FROM Course
                WHERE CourseCode LIKE @kw
                   OR CourseName LIKE @kw
                   OR Overview   LIKE @kw",
                cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

        // ================= FOR COMBOBOX =================
        // Trả về CourseCode + CourseName để bind combobox prerequisite
        public DataTable GetPrerequisiteCourse() =>
            ExecuteQuery(@"
                SELECT CourseCode,
                       RTRIM(CourseCode) + ' - ' + CourseName AS CourseDisplay
                FROM Course
                ORDER BY CourseCode");

        public DataTable GetCoursesForCombo() =>
            ExecuteQuery(@"
                SELECT CourseCode,
                       RTRIM(CourseCode) + ' - ' + CourseName AS CourseDisplay,
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