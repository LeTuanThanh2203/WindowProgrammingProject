using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

public class Class
{
    // ================= PROPERTIES =================
    // Theo schema: ClassID, CourseID, Semester, AcademicYear,
    //              Capacity, CurrentStudents, Room, Schedule
    // Semester values: 'Semester 1' | 'Semester 2' | 'Summer'
    public string ClassID { get; set; }
    public string CourseID { get; set; }
    public string Semester { get; set; }
    public string AcademicYear { get; set; }
    public int Capacity { get; set; }
    public int CurrentStudents { get; set; }
    public string Room { get; set; }
    public string Schedule { get; set; }

    // ================= CONSTRUCTORS =================
    public Class() { }

    public Class(string classID, string courseID, string semester,
                 string academicYear, int capacity, int currentStudents,
                 string room, string schedule)
    {
        ClassID = classID;
        CourseID = courseID;
        Semester = semester;
        AcademicYear = academicYear;
        Capacity = capacity;
        CurrentStudents = currentStudents;
        Room = room;
        Schedule = schedule;
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
            MessageBox.Show("Class Error: " + ex.Message);
            return false;
        }
    }

    private static Class MapFromReader(SqlDataReader reader) => new Class
    {
        ClassID = reader["ClassID"].ToString(),
        CourseID = reader["CourseID"].ToString(),
        Semester = reader["Semester"].ToString(),
        AcademicYear = reader["AcademicYear"].ToString(),
        Capacity = Convert.ToInt32(reader["Capacity"]),
        CurrentStudents = reader["CurrentStudents"] == DBNull.Value
                              ? 0
                              : Convert.ToInt32(reader["CurrentStudents"]),
        Room = reader["Room"]?.ToString(),
        Schedule = reader["Schedule"]?.ToString()
    };

    private void AddClassParams(SqlCommand cmd)
    {
        cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = ClassID;
        cmd.Parameters.Add("@courseID", SqlDbType.VarChar, 20).Value = CourseID;
        cmd.Parameters.Add("@semester", SqlDbType.NVarChar, 20).Value = Semester;
        cmd.Parameters.Add("@academicYear", SqlDbType.VarChar, 20).Value = AcademicYear;
        cmd.Parameters.Add("@capacity", SqlDbType.Int).Value = Capacity;
        cmd.Parameters.Add("@room", SqlDbType.NVarChar, 50).Value = (object)Room ?? DBNull.Value;
        cmd.Parameters.Add("@schedule", SqlDbType.NVarChar, 200).Value = (object)Schedule ?? DBNull.Value;
    }

    // ================= ADD =================
    public bool AddClassroom() =>
        ExecuteNonQuery(@"
            INSERT INTO Class
                (ClassID, CourseID, Semester, AcademicYear,
                 Capacity, CurrentStudents, Room, Schedule)
            VALUES
                (@classID, @courseID, @semester, @academicYear,
                 @capacity, 0, @room, @schedule)",
            AddClassParams);

    // ================= EDIT =================
    // CurrentStudents KHÔNG sửa trực tiếp — do trigger TR_DKMH_Insert/Delete quản lý.
    public bool EditClassroom() =>
        ExecuteNonQuery(@"
            UPDATE Class SET
                CourseID     = @courseID,
                Semester     = @semester,
                AcademicYear = @academicYear,
                Capacity     = @capacity,
                Room         = @room,
                Schedule     = @schedule
            WHERE ClassID = @classID",
            AddClassParams);

    // ================= DELETE =================
    public static bool DeleteClassroom(string classID)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "DELETE FROM Class WHERE ClassID = @classID", db.getConnection);
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

    // ================= GET ALL =================
    public static List<Class> GetClassrooms()
    {
        var list = new List<Class>();
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM Class ORDER BY ClassID",
                    db.getConnection);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(MapFromReader(reader));
            }
        }
        catch { }
        return list;
    }

    // GET ALL with JOIN Course (dùng cho DataGridView)
    public DataTable GetAllClassrooms() =>
        ExecuteQuery(@"
            SELECT cl.ClassID,
                   cl.CourseID,
                   co.CourseName,
                   co.Credits,
                   cl.Semester,
                   cl.AcademicYear,
                   cl.Capacity,
                   cl.CurrentStudents,
                   cl.Room,
                   cl.Schedule
            FROM Class cl
            JOIN Course co ON cl.CourseID = co.CourseID
            ORDER BY cl.ClassID");

    // ================= GET BY ID =================
    public Class GetClassByID(string classID)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM Class WHERE ClassID = @classID", db.getConnection);
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;

                using var reader = cmd.ExecuteReader();
                return reader.Read() ? MapFromReader(reader) : null;
            }
        }
        catch { return null; }
    }

    // ================= SEARCH =================
    public DataTable SearchClassrooms(string keyword) =>
        ExecuteQuery(@"
            SELECT cl.ClassID,
                   cl.CourseID,
                   co.CourseName,
                   cl.Semester,
                   cl.AcademicYear,
                   cl.Capacity,
                   cl.CurrentStudents,
                   cl.Room,
                   cl.Schedule
            FROM Class cl
            JOIN Course co ON cl.CourseID = co.CourseID
            WHERE cl.ClassID      LIKE @kw
               OR cl.CourseID     LIKE @kw
               OR co.CourseName   LIKE @kw
               OR cl.Semester     LIKE @kw
               OR cl.AcademicYear LIKE @kw
               OR cl.Room         LIKE @kw
               OR cl.Schedule     LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= FILTER =================
    public DataTable GetClassesByAcademicYear(string academicYear) =>
        ExecuteQuery(@"
            SELECT * FROM Class
            WHERE AcademicYear = @year
            ORDER BY Semester, ClassID",
            cmd => cmd.Parameters.Add("@year", SqlDbType.VarChar, 20).Value = academicYear);

    public DataTable GetClassesByCourseID(string courseID) =>
        ExecuteQuery(@"
            SELECT * FROM Class
            WHERE CourseID = @courseID
            ORDER BY AcademicYear, Semester",
            cmd => cmd.Parameters.Add("@courseID", SqlDbType.VarChar, 20).Value = courseID);

    // Filter theo cả AcademicYear lẫn Semester (dùng khi người dùng chọn cả 2 combo)
    public DataTable GetClassesByYearAndSemester(string academicYear, string semester) =>
        ExecuteQuery(@"
            SELECT cl.ClassID,
                   cl.CourseID,
                   co.CourseName,
                   co.Credits,
                   cl.Semester,
                   cl.AcademicYear,
                   cl.Capacity,
                   cl.CurrentStudents,
                   cl.Room,
                   cl.Schedule
            FROM Class cl
            JOIN Course co ON cl.CourseID = co.CourseID
            WHERE cl.AcademicYear = @year
              AND cl.Semester     = @semester
            ORDER BY cl.ClassID",
            cmd =>
            {
                cmd.Parameters.Add("@year", SqlDbType.VarChar, 20).Value = academicYear;
                cmd.Parameters.Add("@semester", SqlDbType.NVarChar, 20).Value = semester;
            });

    public DataTable GetDistinctAcademicYears() =>
        ExecuteQuery(@"
            SELECT DISTINCT AcademicYear
            FROM Class
            ORDER BY AcademicYear DESC");

    // Trả về danh sách Semester riêng biệt có trong DB
    // Kết quả có thể là: 'Semester 1', 'Semester 2', 'Summer'
    public DataTable GetDistinctSemesters() =>
        ExecuteQuery(@"
            SELECT DISTINCT Semester
            FROM Class
            ORDER BY
                CASE Semester
                    WHEN 'Semester 1' THEN 1
                    WHEN 'Semester 2' THEN 2
                    WHEN 'Summer'     THEN 3
                    ELSE 4
                END");

    // Trả về Semester riêng biệt theo năm học cụ thể
    public DataTable GetSemestersByYear(string academicYear) =>
        ExecuteQuery(@"
            SELECT DISTINCT Semester
            FROM Class
            WHERE AcademicYear = @year
            ORDER BY
                CASE Semester
                    WHEN 'Semester 1' THEN 1
                    WHEN 'Semester 2' THEN 2
                    WHEN 'Summer'     THEN 3
                    ELSE 4
                END",
            cmd => cmd.Parameters.Add("@year", SqlDbType.VarChar, 20).Value = academicYear);

    // ================= FOR COMBOBOX =================
    public DataTable GetClassesForCombo() =>
        ExecuteQuery(@"
            SELECT ClassID,
                   ClassID + ' - ' + co.CourseName AS ClassDisplay
            FROM Class cl
            JOIN Course co ON cl.CourseID = co.CourseID
            ORDER BY ClassID");

    // ================= STATS =================
    public int TotalClassrooms()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM Class", db.getConnection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    public int TotalCapacity()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(Capacity), 0) FROM Class", db.getConnection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    public int TotalCurrentStudents()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(CurrentStudents), 0) FROM Class", db.getConnection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }
}