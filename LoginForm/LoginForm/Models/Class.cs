using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System.Windows.Forms;

public class Class
{
    // ================= PROPERTIES =================
    public string ClassID { get; set; }
    public string ClassName { get; set; }
    public string AcademicYear { get; set; }
    public int NumberOfStudent { get; set; }
    public string HomeroomTeacher { get; set; }

    // ================= CONSTRUCTORS =================
    public Class() { }

    public Class(string classID, string className, string academicYear,
                 int numberOfStudent, string homeroomTeacher)
    {
        ClassID = classID;
        ClassName = className;
        AcademicYear = academicYear;
        NumberOfStudent = numberOfStudent;
        HomeroomTeacher = homeroomTeacher;
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

    private static DataTable ExecuteQueryStatic(string query, Action<SqlCommand> addParams = null)
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

    // ================= ADD =================
    public bool AddClassroom()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(@"
                    INSERT INTO Class
                        (ClassID, ClassName, AcademicYear, NumberOfStudent, HomeroomTeacher)
                    VALUES
                        (@classID, @className, @academicYear, @numberOfStudent, @homeroomTeacher)",
                    db.getConnection);

                cmd.Parameters.Add("@classID", SqlDbType.VarChar).Value = ClassID;
                cmd.Parameters.Add("@className", SqlDbType.VarChar).Value = ClassName;
                cmd.Parameters.Add("@academicYear", SqlDbType.VarChar).Value = AcademicYear;
                cmd.Parameters.Add("@numberOfStudent", SqlDbType.Int).Value = NumberOfStudent;
                cmd.Parameters.Add("@homeroomTeacher", SqlDbType.VarChar).Value =
                    (object)HomeroomTeacher ?? DBNull.Value;

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("AddClassroom Error: " + ex.Message);
            return false;
        }
    }

    // ================= EDIT =================
    public bool EditClassroom()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(@"
                    UPDATE Class SET
                        ClassName       = @className,
                        AcademicYear    = @academicYear,
                        NumberOfStudent = @numberOfStudent,
                        HomeroomTeacher = @homeroomTeacher
                    WHERE ClassID = @classID",
                    db.getConnection);

                cmd.Parameters.AddWithValue("@classID", ClassID);
                cmd.Parameters.AddWithValue("@className", ClassName);
                cmd.Parameters.AddWithValue("@academicYear", AcademicYear);
                cmd.Parameters.AddWithValue("@numberOfStudent", NumberOfStudent);
                cmd.Parameters.AddWithValue("@homeroomTeacher", (object)HomeroomTeacher ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

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
                cmd.Parameters.AddWithValue("@classID", classID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

    // ================= GET / SEARCH =================
    public static List<Class> GetClassrooms()
    {
        var list = new List<Class>();
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT ClassID, ClassName, AcademicYear, NumberOfStudent, HomeroomTeacher FROM Class ORDER BY ClassID",
                    db.getConnection);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(new Class
                    {
                        ClassID = reader["ClassID"].ToString(),
                        ClassName = reader["ClassName"].ToString(),
                        AcademicYear = reader["AcademicYear"].ToString(),
                        NumberOfStudent = reader["NumberOfStudent"] == DBNull.Value
                                            ? 0 : Convert.ToInt32(reader["NumberOfStudent"]),
                        HomeroomTeacher = reader["HomeroomTeacher"].ToString()
                    });
            }
        }
        catch { }
        return list;
    }

    public DataTable SearchClassrooms(string keyword) =>
        ExecuteQuery(@"
            SELECT * FROM Class
            WHERE ClassID       LIKE @kw
               OR ClassName     LIKE @kw
               OR AcademicYear  LIKE @kw
               OR HomeroomTeacher LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

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
                cmd.Parameters.AddWithValue("@classID", classID);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                    c = new Class
                    {
                        ClassID = reader["ClassID"].ToString(),
                        ClassName = reader["ClassName"].ToString(),
                        AcademicYear = reader["AcademicYear"].ToString(),
                        NumberOfStudent = reader["NumberOfStudent"] == DBNull.Value
                                            ? 0 : Convert.ToInt32(reader["NumberOfStudent"]),
                        HomeroomTeacher = reader["HomeroomTeacher"].ToString()
                    };
            }
        }
        catch { }
        return c;
    }

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

    public DataTable GetClassesByAcademicYear(string academicYear) =>
        ExecuteQuery(@"
            SELECT ClassID, ClassName, AcademicYear, NumberOfStudent, HomeroomTeacher
            FROM Class
            WHERE AcademicYear = @year
            ORDER BY ClassID",
            cmd => cmd.Parameters.AddWithValue("@year", academicYear));

    public DataTable GetDistinctAcademicYears() =>
        ExecuteQuery(@"
            SELECT DISTINCT AcademicYear
            FROM Class
            ORDER BY AcademicYear DESC");
}