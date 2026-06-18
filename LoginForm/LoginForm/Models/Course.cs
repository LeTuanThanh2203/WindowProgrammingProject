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
        // Đồng bộ đầy đủ với SQL schema
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int TotalPeriods { get; set; }
        public int TheoryPeriods { get; set; }
        public int PracticePeriods { get; set; }
        public string PrerequisiteID { get; set; }   // NULL nếu không có môn tiên quyết
        public bool IsRequired { get; set; }          // BIT: true = bắt buộc
        public string Description { get; set; }

        // ================= CONSTRUCTORS =================
        public Course() { }

        public Course(string courseID, string courseName, int credits,
                      int totalPeriods, int theoryPeriods, int practicePeriods,
                      string prerequisiteID, bool isRequired, string description)
        {
            CourseID = courseID;
            CourseName = courseName;
            Credits = credits;
            TotalPeriods = totalPeriods;
            TheoryPeriods = theoryPeriods;
            PracticePeriods = practicePeriods;
            PrerequisiteID = prerequisiteID;
            IsRequired = isRequired;
            Description = description;
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
            cmd.Parameters.Add("@courseID", SqlDbType.VarChar, 20).Value = CourseID;
            cmd.Parameters.Add("@courseName", SqlDbType.NVarChar, 200).Value = CourseName;
            cmd.Parameters.Add("@credits", SqlDbType.Int).Value = Credits;
            cmd.Parameters.Add("@totalPeriods", SqlDbType.Int).Value = TotalPeriods;
            cmd.Parameters.Add("@theoryPeriods", SqlDbType.Int).Value = TheoryPeriods;
            cmd.Parameters.Add("@practicePeriods", SqlDbType.Int).Value = PracticePeriods;
            cmd.Parameters.Add("@prerequisiteID", SqlDbType.VarChar, 20).Value =
                string.IsNullOrEmpty(PrerequisiteID) ? (object)DBNull.Value : PrerequisiteID;
            cmd.Parameters.Add("@isRequired", SqlDbType.Bit).Value = IsRequired;
            cmd.Parameters.Add("@description", SqlDbType.NVarChar, 500).Value =
                (object)Description ?? DBNull.Value;
        }

        private static Course MapFromReader(SqlDataReader reader) => new Course
        {
            CourseID = reader["CourseID"].ToString(),
            CourseName = reader["CourseName"].ToString(),
            Credits = Convert.ToInt32(reader["Credits"]),
            TotalPeriods = Convert.ToInt32(reader["TotalPeriods"]),
            TheoryPeriods = Convert.ToInt32(reader["TheoryPeriods"]),
            PracticePeriods = Convert.ToInt32(reader["PracticePeriods"]),
            PrerequisiteID = reader["PrerequisiteID"] != DBNull.Value
                                  ? reader["PrerequisiteID"].ToString()
                                  : null,
            IsRequired = reader["IsRequired"] != DBNull.Value &&
                              Convert.ToBoolean(reader["IsRequired"]),
            Description = reader["Description"] != DBNull.Value
                                  ? reader["Description"].ToString()
                                  : null
        };

        // ================= ADD =================
        // Trigger TR_Course_CheckPeriods kiểm tra TheoryPeriods + PracticePeriods = TotalPeriods.
        // Trigger TR_Course_CheckPrerequisite kiểm tra không tự tham chiếu / vòng lặp.
        public bool AddCourse() =>
            ExecuteNonQuery(@"
                INSERT INTO Course
                    (CourseID, CourseName, Credits, TotalPeriods, TheoryPeriods,
                     PracticePeriods, PrerequisiteID, IsRequired, Description)
                VALUES
                    (@courseID, @courseName, @credits, @totalPeriods, @theoryPeriods,
                     @practicePeriods, @prerequisiteID, @isRequired, @description)",
                AddCourseParams);

        // ================= EDIT =================
        public bool EditCourse() =>
            ExecuteNonQuery(@"
                UPDATE Course SET
                    CourseName      = @courseName,
                    Credits         = @credits,
                    TotalPeriods    = @totalPeriods,
                    TheoryPeriods   = @theoryPeriods,
                    PracticePeriods = @practicePeriods,
                    PrerequisiteID  = @prerequisiteID,
                    IsRequired      = @isRequired,
                    Description     = @description
                WHERE CourseID = @courseID",
                AddCourseParams);

        // ================= DELETE =================
        public static bool DelCourse(string courseID)
        {
            try
            {
                using (var db = new My_DB())
                {
                    db.openConnection();
                    var cmd = new SqlCommand(
                        "DELETE FROM Course WHERE CourseID = @courseID",
                        db.getConnection);
                    cmd.Parameters.Add("@courseID", SqlDbType.VarChar, 20).Value = courseID;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // ================= GET ALL =================
        // Join với chính nó để lấy tên môn tiên quyết (dùng cho DataGridView)
        public DataTable GetCourse() =>
            ExecuteQuery(@"
                SELECT
                    c.CourseID,
                    c.CourseName,
                    c.Credits,
                    c.TotalPeriods,
                    c.TheoryPeriods,
                    c.PracticePeriods,
                    c.PrerequisiteID,
                    p.CourseName  AS PrerequisiteName,
                    c.IsRequired,
                    c.Description
                FROM Course c
                LEFT JOIN Course p ON c.PrerequisiteID = p.CourseID
                ORDER BY c.CourseID");

        // ================= GET BY ID =================
        public Course GetCourseByID(string courseID)
        {
            try
            {
                using (var db = new My_DB())
                {
                    db.openConnection();
                    var cmd = new SqlCommand(
                        "SELECT * FROM Course WHERE CourseID = @courseID",
                        db.getConnection);
                    cmd.Parameters.Add("@courseID", SqlDbType.VarChar, 20).Value = courseID;

                    using var reader = cmd.ExecuteReader();
                    return reader.Read() ? MapFromReader(reader) : null;
                }
            }
            catch { return null; }
        }

        // ================= SEARCH =================
        public DataTable SearchCourse(string keyword) =>
            ExecuteQuery(@"
                SELECT
                    c.CourseID,
                    c.CourseName,
                    c.Credits,
                    c.TotalPeriods,
                    c.TheoryPeriods,
                    c.PracticePeriods,
                    c.PrerequisiteID,
                    p.CourseName AS PrerequisiteName,
                    c.IsRequired,
                    c.Description
                FROM Course c
                LEFT JOIN Course p ON c.PrerequisiteID = p.CourseID
                WHERE c.CourseID     LIKE @kw
                   OR c.CourseName   LIKE @kw
                   OR c.Description  LIKE @kw
                   OR p.CourseName   LIKE @kw",
                cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

        // ================= FOR COMBOBOX =================
        public DataTable GetCoursesForCombo() =>
            ExecuteQuery(@"
                SELECT CourseID,
                       CourseID + ' - ' + CourseName AS CourseDisplay,
                       Credits
                FROM Course
                ORDER BY CourseID");

        // Chỉ lấy môn có thể làm tiên quyết cho @courseID
        // (loại chính nó và các môn mà @courseID là tiên quyết của chúng)
        public DataTable GetPrerequisiteCandidates(string courseID) =>
            ExecuteQuery(@"
                SELECT CourseID,
                       CourseID + ' - ' + CourseName AS CourseDisplay
                FROM Course
                WHERE CourseID <> @courseID
                  AND PrerequisiteID <> @courseID OR PrerequisiteID IS NULL
                ORDER BY CourseID",
                cmd => cmd.Parameters.Add("@courseID", SqlDbType.VarChar, 20).Value = courseID);

        // ================= FILTER =================
        public DataTable GetRequiredCourses() =>
            ExecuteQuery("SELECT * FROM Course WHERE IsRequired = 1 ORDER BY CourseID");

        public DataTable GetElectiveCourses() =>
            ExecuteQuery("SELECT * FROM Course WHERE IsRequired = 0 ORDER BY CourseID");

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