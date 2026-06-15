using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Windows.Forms;

public class Student
{
    // ================= PROPERTIES =================
    public string MSSV { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Hometown { get; set; }
    public string Email { get; set; }
    public byte[] Picture { get; set; }

    public Student() { }

    public Student(string mssv, string fname, string lname, DateTime dob,
        string gender, string phone, string address, string hometown,
        string email, byte[] picture)
    {
        MSSV = mssv; Fname = fname; Lname = lname; Dob = dob;
        Gender = gender; Phone = phone; Address = address;
        Hometown = hometown; Email = email; Picture = picture;
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

    private static Student MapFromReader(SqlDataReader reader) => new Student
    {
        MSSV = reader["MSSV"].ToString(),
        Fname = reader["FirstName"].ToString(),
        Lname = reader["LastName"].ToString(),
        Dob = Convert.ToDateTime(reader["Dob"]),
        Gender = reader["Gender"].ToString(),
        Phone = reader["Phone"].ToString(),
        Address = reader["Address"].ToString(),
        Hometown = reader["HomeTown"].ToString(),
        Email = reader["Email"].ToString(),
        Picture = reader["Picture"] != DBNull.Value ? (byte[])reader["Picture"] : null
    };

    // ================= ADD =================
    public bool AddStudent()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(@"
                    INSERT INTO Student
                        (MSSV, FirstName, LastName, Dob, Gender,
                         Phone, Address, HomeTown, Email, Picture)
                    VALUES
                        (@mssv, @fname, @lname, @dob, @gender,
                         @phone, @address, @hometown, @email, @picture)",
                    db.getConnection);

                cmd.Parameters.Add("@mssv", SqlDbType.NVarChar).Value = MSSV;
                cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = Fname;
                cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = Lname;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Dob;
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = Gender;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = Phone;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = Address;
                cmd.Parameters.Add("@hometown", SqlDbType.NVarChar).Value = Hometown;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@picture", SqlDbType.VarBinary).Value = (object)Picture ?? DBNull.Value;

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("AddStudent Error: " + ex.Message);
            return false;
        }
    }

    // ================= EDIT =================
    public bool EditStudent()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(@"
                    UPDATE Student SET
                        FirstName = @fname,   LastName  = @lname,
                        Dob       = @dob,     Gender    = @gender,
                        Phone     = @phone,   Address   = @address,
                        HomeTown  = @hometown, Email    = @email,
                        Picture   = @picture
                    WHERE MSSV = @mssv",
                    db.getConnection);

                cmd.Parameters.AddWithValue("@mssv", MSSV);
                cmd.Parameters.AddWithValue("@fname", Fname);
                cmd.Parameters.AddWithValue("@lname", Lname);
                cmd.Parameters.AddWithValue("@dob", Dob);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@phone", Phone);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@hometown", Hometown);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@picture", (object)Picture ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

    // ================= DELETE =================
    public static bool DeleteStudent(string mssv)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "DELETE FROM Student WHERE MSSV = @mssv", db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

    // Xóa Score + DKMH + Student theo thứ tự FK
    public static bool DeleteScoreAndStudent(string mssv)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                foreach (var sql in new[]
                {
                    "DELETE FROM Score   WHERE MSSV = @mssv",
                    "DELETE FROM DKMH    WHERE MSSV = @mssv",
                    "DELETE FROM Student WHERE MSSV = @mssv"
                })
                {
                    var cmd = new SqlCommand(sql, db.getConnection);
                    cmd.Parameters.AddWithValue("@mssv", mssv);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
        }
        catch { return false; }
    }

    // ================= GET / SEARCH =================
    public DataTable GetAllStudents() =>
        ExecuteQuery("SELECT * FROM Student ORDER BY MSSV");

    public DataTable SearchStudents(string keyword) =>
        ExecuteQuery(@"
            SELECT * FROM Student
            WHERE CAST(MSSV AS NVARCHAR) LIKE @kw
               OR FirstName LIKE @kw OR LastName  LIKE @kw
               OR Gender    LIKE @kw OR Phone     LIKE @kw
               OR Address   LIKE @kw OR HomeTown  LIKE @kw
               OR Email     LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    public Student GetStudentByID(string mssv)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM Student WHERE MSSV = @mssv", db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);

                using var reader = cmd.ExecuteReader();
                return reader.Read() ? MapFromReader(reader) : null;
            }
        }
        catch { return null; }
    }

    // ================= STATS =================
    public int totalStudent() => CountByGender(null);
    public double totalMaleStudent() => CountByGender("Male");
    public double totalFemaleStudent() => CountByGender("Female");
    public double totalOtherStudent() => CountByGender("Other");

    private int CountByGender(string gender)
    {
        string sql = gender == null
            ? "SELECT COUNT(*) FROM Student"
            : "SELECT COUNT(*) FROM Student WHERE Gender = @g";
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(sql, db.getConnection);
                if (gender != null) cmd.Parameters.AddWithValue("@g", gender);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    // ================= DKMH — REGISTERED / UNREGISTERED =================
    // Schema DKMH: (MSSV, ClassID, Semester, AcademicYear)
    // Join Class → Course để lấy CourseCode, CourseName, CreditHour, Week

    public DataTable GetUnRegisteredCourses(string mssv, string academicYear) =>
    ExecuteQuery(@"
        SELECT
            cl.ClassID,
            cl.ClassName,
            c.CourseName,
            cl.Manager,
            c.CreditHour,
            pre.CourseName AS [Prerequisite Course],
            cl.Semester,
            c.Week
        FROM Class cl
        JOIN Course c ON cl.CourseCode = c.CourseCode
        LEFT JOIN Course pre ON c.PrerequisiteCourseCode = pre.CourseCode
        WHERE cl.ClassID NOT IN (
            SELECT ClassID FROM DKMH
            WHERE MSSV = @mssv AND AcademicYear = @academicYear
        )
        ORDER BY cl.CourseCode",
        cmd =>
        {
            cmd.Parameters.AddWithValue("@mssv", mssv);
            cmd.Parameters.AddWithValue("@academicYear", academicYear);
        });

    public DataTable GetRegisteredCourses(string mssv, string academicYear) =>
        ExecuteQuery(@"
        SELECT
            d.ClassID,
            cl.ClassName,
            c.CourseName,
            cl.Manager,
            c.CreditHour,
            pre.CourseName AS [Prerequisite Course],
            d.Semester,
            c.Week
        FROM DKMH d
        JOIN Class   cl  ON d.ClassID     = cl.ClassID
        JOIN Course  c   ON cl.CourseCode  = c.CourseCode
        LEFT JOIN Course pre ON c.PrerequisiteCourseCode = pre.CourseCode
        WHERE d.MSSV         = @mssv
          AND d.AcademicYear = @academicYear
        ORDER BY d.Semester, cl.ClassID",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@academicYear", academicYear);
            });

    public DataTable SearchUnRegisteredCourses(string mssv, string academicYear, string keyword) =>
        ExecuteQuery(@"
        SELECT
            cl.ClassID,
            cl.ClassName,
            c.CourseName,
            cl.Manager,
            c.CreditHour,
            pre.CourseName AS [Prerequisite Course],
            cl.Semester,
            c.Week
        FROM Class cl
        JOIN Course c ON cl.CourseCode = c.CourseCode
        LEFT JOIN Course pre ON c.PrerequisiteCourseCode = pre.CourseCode
        WHERE cl.ClassID NOT IN (
            SELECT ClassID FROM DKMH
            WHERE MSSV = @mssv AND AcademicYear = @academicYear
        )
        AND (cl.ClassID   LIKE @kw
          OR cl.ClassName LIKE @kw
          OR c.CourseName LIKE @kw
          OR cl.Manager   LIKE @kw)
        ORDER BY cl.CourseCode",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@academicYear", academicYear);
                cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
            });

    public DataTable SearchRegisteredCourses(string mssv, string academicYear, string keyword) =>
        ExecuteQuery(@"
        SELECT
            d.ClassID,
            cl.ClassName,
            c.CourseName,
            cl.Manager,
            c.CreditHour,
            pre.CourseName AS [Prerequisite Course],
            d.Semester,
            c.Week
        FROM DKMH d
        JOIN Class   cl ON d.ClassID     = cl.ClassID
        JOIN Course  c  ON cl.CourseCode  = c.CourseCode
        LEFT JOIN Course pre ON c.PrerequisiteCourseCode = pre.CourseCode
        WHERE d.MSSV         = @mssv
          AND d.AcademicYear = @academicYear
          AND (d.ClassID    LIKE @kw
            OR cl.ClassName LIKE @kw
            OR c.CourseName LIKE @kw
            OR cl.Manager   LIKE @kw)
        ORDER BY d.Semester, cl.ClassID",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@academicYear", academicYear);
                cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
            });
    // ================= REGISTER / CANCEL =================
    // PK của DKMH: (MSSV, ClassID, Semester, AcademicYear)
    public static (bool success, string message) RegisterCourse(
    string mssv, string classID, int semester, string academicYear)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();

                var check = new SqlCommand(@"
                SELECT COUNT(*) FROM DKMH
                WHERE MSSV = @mssv AND ClassID = @classID
                  AND Semester = @semester AND AcademicYear = @academicYear",
                    db.getConnection);
                check.Parameters.AddWithValue("@mssv", mssv);
                check.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                check.Parameters.AddWithValue("@semester", semester);
                check.Parameters.AddWithValue("@academicYear", academicYear);
                if ((int)check.ExecuteScalar() > 0)
                    return (false, "Already registered this class!");

                var credit = new SqlCommand(@"
                SELECT c.CreditHour
                FROM Class cl
                JOIN Course c ON cl.CourseCode = c.CourseCode
                WHERE cl.ClassID = @classID",
                    db.getConnection);
                credit.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                object creditResult = credit.ExecuteScalar();

                if (creditResult == null || creditResult == DBNull.Value)
                    return (false, "Class not found!");

                int newCredits = Convert.ToInt32(creditResult);

                var total = new SqlCommand(@"
                SELECT ISNULL(SUM(c.CreditHour), 0)
                FROM DKMH d
                JOIN Class  cl ON d.ClassID    = cl.ClassID
                JOIN Course c  ON cl.CourseCode = c.CourseCode
                WHERE d.MSSV = @mssv AND d.AcademicYear = @academicYear",
                    db.getConnection);
                total.Parameters.AddWithValue("@mssv", mssv);
                total.Parameters.AddWithValue("@academicYear", academicYear);
                int current = Convert.ToInt32(total.ExecuteScalar());

                if (current + newCredits > 24)
                    return (false, $"Exceeded 24 credits! Current: {current}, Adding: {newCredits}");

                var insert = new SqlCommand(@"
                INSERT INTO DKMH (MSSV, ClassID, Semester, AcademicYear)
                VALUES (@mssv, @classID, @semester, @academicYear)",
                    db.getConnection);
                insert.Parameters.AddWithValue("@mssv", mssv);
                insert.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                insert.Parameters.AddWithValue("@semester", semester);
                insert.Parameters.AddWithValue("@academicYear", academicYear);
                insert.ExecuteNonQuery();

                var insertScore = new SqlCommand(@"
                INSERT INTO Score (MSSV, ClassID, Semester, AcademicYear,
                                   MidtermScore, FinalScore, TotalScore, Overview)
                VALUES (@mssv, @classID, @semester, @academicYear,
                        NULL, NULL, NULL, NULL)",
                    db.getConnection);
                insertScore.Parameters.AddWithValue("@mssv", mssv);
                insertScore.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                insertScore.Parameters.AddWithValue("@semester", semester);
                insertScore.Parameters.AddWithValue("@academicYear", academicYear);
                insertScore.ExecuteNonQuery();

                return (true, $"Registered! Total credits: {current + newCredits}/24");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }

    public static (bool success, string message) CancelCourse(
        string mssv, string classID, int semester, string academicYear)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();

                var deleteScore = new SqlCommand(@"
                DELETE FROM Score
                WHERE MSSV         = @mssv
                  AND ClassID      = @classID
                  AND Semester     = @semester
                  AND AcademicYear = @academicYear
                  AND MidtermScore IS NULL
                  AND FinalScore   IS NULL",
                    db.getConnection);
                deleteScore.Parameters.AddWithValue("@mssv", mssv);
                deleteScore.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                deleteScore.Parameters.AddWithValue("@semester", semester);
                deleteScore.Parameters.AddWithValue("@academicYear", academicYear);
                deleteScore.ExecuteNonQuery();

                var cmd = new SqlCommand(@"
                DELETE FROM DKMH
                WHERE MSSV = @mssv AND ClassID = @classID
                  AND Semester = @semester AND AcademicYear = @academicYear",
                    db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                cmd.Parameters.AddWithValue("@semester", semester);
                cmd.Parameters.AddWithValue("@academicYear", academicYear);
                return cmd.ExecuteNonQuery() > 0
                    ? (true, "Cancelled successfully!")
                    : (false, "Registration not found!");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }

    // ================= ACADEMIC YEARS =================
    public DataTable GetAcademicYearsByMSSV(string mssv) =>
        ExecuteQuery(@"
            SELECT DISTINCT AcademicYear
            FROM DKMH
            WHERE MSSV = @mssv
            ORDER BY AcademicYear DESC",
            cmd => cmd.Parameters.AddWithValue("@mssv", mssv));

    public int GetTotalCredits(string mssv, string academicYear)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(@"
                    SELECT ISNULL(SUM(c.CreditHour), 0)
                    FROM DKMH d
                    JOIN Class  cl ON d.ClassID    = cl.ClassID
                    JOIN Course c  ON cl.CourseCode = c.CourseCode
                    WHERE d.MSSV = @mssv AND d.AcademicYear = @academicYear",
                    db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@academicYear", academicYear);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    // ================= STATS BY ENROLLMENT YEAR =================
    public DataTable GetStudentStatisticsByYear() =>
        ExecuteQuery(@"
            SELECT '20' + LEFT(MSSV, 2) AS EnrollmentYear,
                   COUNT(*) AS TotalStudents
            FROM Student
            GROUP BY LEFT(MSSV, 2)
            ORDER BY EnrollmentYear");
}