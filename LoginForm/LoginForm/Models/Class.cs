using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

public class Class
{
    // ================= PROPERTIES =================
    // Theo schema: ClassID, CourseCode, ClassName, Semester,
    //              AcademicYear, NumberOfStudent, Manager
    // KHÔNG còn: HomeroomTeacher (đổi thành Manager)
    public string ClassID { get; set; }
    public string CourseCode { get; set; }
    public string ClassName { get; set; }
    public int Semester { get; set; }
    public string AcademicYear { get; set; }
    public int NumberOfStudent { get; set; }
    public string Manager { get; set; }

    // ================= CONSTRUCTORS =================
    public Class() { }

    public Class(string classID, string courseCode, string className,
                 int semester, string academicYear,
                 int numberOfStudent, string manager)
    {
        ClassID = classID;
        CourseCode = courseCode;
        ClassName = className;
        Semester = semester;
        AcademicYear = academicYear;
        NumberOfStudent = numberOfStudent;
        Manager = manager;
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
        CourseCode = reader["CourseCode"].ToString().Trim(),
        ClassName = reader["ClassName"].ToString(),
        Semester = Convert.ToInt32(reader["Semester"]),
        AcademicYear = reader["AcademicYear"].ToString(),
        NumberOfStudent = reader["NumberOfStudent"] == DBNull.Value
                            ? 0 : Convert.ToInt32(reader["NumberOfStudent"]),
        Manager = reader["Manager"]?.ToString()
    };

    // ================= ADD =================
    public bool AddClassroom() =>
        ExecuteNonQuery(@"
            INSERT INTO Class
                (ClassID, CourseCode, ClassName, Semester,
                 AcademicYear, NumberOfStudent, Manager)
            VALUES
                (@classID, @courseCode, @className, @semester,
                 @academicYear, @numberOfStudent, @manager)",
            cmd =>
            {
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = ClassID;
                cmd.Parameters.Add("@courseCode", SqlDbType.Char, 10).Value = CourseCode;
                cmd.Parameters.Add("@className", SqlDbType.VarChar, 100).Value = ClassName;
                cmd.Parameters.Add("@semester", SqlDbType.Int).Value = Semester;
                cmd.Parameters.Add("@academicYear", SqlDbType.VarChar, 20).Value = AcademicYear;
                cmd.Parameters.Add("@numberOfStudent", SqlDbType.Int).Value = NumberOfStudent;
                cmd.Parameters.Add("@manager", SqlDbType.VarChar, 100).Value = (object)Manager ?? DBNull.Value;
            });

    // ================= EDIT =================
    public bool EditClassroom() =>
        ExecuteNonQuery(@"
            UPDATE Class SET
                CourseCode      = @courseCode,
                ClassName       = @className,
                Semester        = @semester,
                AcademicYear    = @academicYear,
                NumberOfStudent = @numberOfStudent,
                Manager         = @manager
            WHERE ClassID = @classID",
            cmd =>
            {
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = ClassID;
                cmd.Parameters.Add("@courseCode", SqlDbType.Char, 10).Value = CourseCode;
                cmd.Parameters.Add("@className", SqlDbType.VarChar, 100).Value = ClassName;
                cmd.Parameters.Add("@semester", SqlDbType.Int).Value = Semester;
                cmd.Parameters.Add("@academicYear", SqlDbType.VarChar, 20).Value = AcademicYear;
                cmd.Parameters.Add("@numberOfStudent", SqlDbType.Int).Value = NumberOfStudent;
                cmd.Parameters.Add("@manager", SqlDbType.VarChar, 100).Value = (object)Manager ?? DBNull.Value;
            });

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

    // ================= GET BY ID =================
    public Class GetClassByID(string classID)
    {
        Class c = null;
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM Class WHERE ClassID = @classID", db.getConnection);
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                    c = MapFromReader(reader);
            }
        }
        catch { }
        return c;
    }

    // ================= SEARCH =================
    public DataTable SearchClassrooms(string keyword) =>
        ExecuteQuery(@"
            SELECT * FROM Class
            WHERE ClassID       LIKE @kw
               OR CourseCode    LIKE @kw
               OR ClassName     LIKE @kw
               OR AcademicYear  LIKE @kw
               OR Manager       LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= FILTER =================
    public DataTable GetClassesByAcademicYear(string academicYear) =>
        ExecuteQuery(@"
            SELECT * FROM Class
            WHERE AcademicYear = @year
            ORDER BY ClassID",
            cmd => cmd.Parameters.AddWithValue("@year", academicYear));

    public DataTable GetClassesByCourseCode(string courseCode) =>
        ExecuteQuery(@"
            SELECT * FROM Class
            WHERE CourseCode = @courseCode
            ORDER BY AcademicYear, Semester",
            cmd => cmd.Parameters.Add("@courseCode", SqlDbType.Char, 10).Value = courseCode);

    public DataTable GetDistinctAcademicYears() =>
        ExecuteQuery(@"
            SELECT DISTINCT AcademicYear
            FROM Class
            ORDER BY AcademicYear DESC");

    // ================= FOR COMBOBOX =================
    public DataTable GetClassesForCombo() =>
        ExecuteQuery(@"
            SELECT ClassID,
                   ClassID + ' - ' + ClassName AS ClassDisplay
            FROM Class
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

    public int TotalStudentsAllClasses()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(NumberOfStudent), 0) FROM Class", db.getConnection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }
}