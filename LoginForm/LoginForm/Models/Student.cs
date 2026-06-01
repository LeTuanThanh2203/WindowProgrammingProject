using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;
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

    // Base query cho course registration — dùng chung
    private const string CourseSelectBase = @"
        SELECT
            c.CourseID,
            c.CourseCode,
            c.CourseName,
            c.CreditHour,
            pre.CourseName AS [Prerequisite Course],
            c.Semester,
            c.Week
        FROM {0}
        LEFT JOIN Course pre ON c.PrerequisiteCourseID = pre.CourseID
        {1}
        ORDER BY c.CourseCode";

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
                        FirstName = @fname, LastName  = @lname,
                        Dob       = @dob,   Gender    = @gender,
                        Phone     = @phone, Address   = @address,
                        HomeTown  = @hometown, Email  = @email,
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

    public static bool DeleteScoreandStudent(string mssv)
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
    public DataTable getStudents(SqlCommand command)
    {
        var table = new DataTable();
        try
        {
            using (var db = new My_DB())
            {
                command.Connection = db.getConnection;
                new SqlDataAdapter(command).Fill(table);
            }
        }
        catch { }
        return table;
    }

    public DataTable SearchStudents(string keyword) =>
        ExecuteQuery(@"
            SELECT * FROM Student
            WHERE CAST(MSSV AS NVARCHAR) LIKE @kw
               OR FirstName LIKE @kw OR LastName LIKE @kw
               OR Gender    LIKE @kw OR Phone    LIKE @kw
               OR Address   LIKE @kw OR HomeTown LIKE @kw
               OR Email     LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    public Student GetStudentByID(string mssv)
    {
        Student s = null;
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM Student WHERE MSSV = @mssv", db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                    s = new Student
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
                        Picture = reader["Picture"] != DBNull.Value
                                    ? (byte[])reader["Picture"] : null
                    };
            }
        }
        catch { }
        return s;
    }

    // ================= STATS =================
    public int TotalStudent() => CountByGender(null);
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

    // ================= REGISTERED / UNREGISTERED (no year) =================
    public DataTable GetStudentsRegisteredCourse() =>
        ExecuteQuery(@"
            SELECT DISTINCT s.MSSV, s.FirstName, s.LastName
            FROM Student s JOIN DKMH d ON s.MSSV = d.MSSV");

    public DataTable GetUnRegisteredCourses(string mssv) =>
        ExecuteQuery(@"
            SELECT CourseID, CourseCode, CourseName, CreditHour, Semester
            FROM Course
            WHERE CourseID NOT IN (SELECT CourseID FROM DKMH WHERE MSSV = @mssv)
            ORDER BY CourseCode",
            cmd => cmd.Parameters.AddWithValue("@mssv", mssv));

    public DataTable GetRegisteredCourses(string mssv) =>
        ExecuteQuery(@"
            SELECT c.CourseID, c.CourseCode, c.CourseName, c.CreditHour, c.Semester
            FROM DKMH d JOIN Course c ON d.CourseID = c.CourseID
            WHERE d.MSSV = @mssv ORDER BY c.CourseCode",
            cmd => cmd.Parameters.AddWithValue("@mssv", mssv));

    public DataTable GetCoursesWithoutScore(string mssv) =>
        ExecuteQuery(@"
            SELECT Course.CourseID, Course.CourseName
            FROM DKMH JOIN Course ON DKMH.CourseID = Course.CourseID
            WHERE DKMH.MSSV = @mssv
              AND NOT EXISTS (
                SELECT * FROM Score
                WHERE Score.MSSV = @mssv AND Score.CourseID = Course.CourseID
              )",
            cmd => cmd.Parameters.AddWithValue("@mssv", mssv));

    public int GetTotalCredits(string mssv)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(@"
                    SELECT ISNULL(SUM(c.CreditHour), 0)
                    FROM DKMH d JOIN Course c ON d.CourseID = c.CourseID
                    WHERE d.MSSV = @mssv", db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    // ================= REGISTERED / UNREGISTERED (with year) =================
    public DataTable GetUnRegisteredCourses(string mssv, string academicYear) =>
        ExecuteQuery(@"
            SELECT c.CourseID, c.CourseCode, c.CourseName, c.CreditHour,
                   pre.CourseName AS [Prerequisite Course], c.Semester, c.Week
            FROM Course c
            LEFT JOIN Course pre ON c.PrerequisiteCourseID = pre.CourseID
            WHERE c.CourseID NOT IN (
                SELECT CourseID FROM DKMH WHERE MSSV = @mssv AND AcademicYear = @year
            )
            ORDER BY c.CourseCode",
            cmd => {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@year", academicYear);
            });

    public DataTable GetRegisteredCourses(string mssv, string academicYear) =>
        ExecuteQuery(@"
            SELECT c.CourseID, c.CourseCode, c.CourseName, c.CreditHour,
                   pre.CourseName AS [Prerequisite Course], c.Semester, c.Week
            FROM DKMH d
            JOIN Course c ON d.CourseID = c.CourseID
            LEFT JOIN Course pre ON c.PrerequisiteCourseID = pre.CourseID
            WHERE d.MSSV = @mssv AND d.AcademicYear = @year
            ORDER BY c.CourseCode",
            cmd => {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@year", academicYear);
            });

    public DataTable SearchUnRegisteredCourses(
        string mssv, string academicYear, string keyword) =>
        ExecuteQuery(@"
            SELECT c.CourseID, c.CourseCode, c.CourseName, c.CreditHour,
                   pre.CourseName AS [Prerequisite Course], c.Semester, c.Week
            FROM Course c
            LEFT JOIN Course pre ON c.PrerequisiteCourseID = pre.CourseID
            WHERE c.CourseID NOT IN (
                SELECT CourseID FROM DKMH WHERE MSSV = @mssv AND AcademicYear = @year
            )
            AND (c.CourseCode LIKE @kw OR c.CourseName LIKE @kw)
            ORDER BY c.CourseCode",
            cmd => {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@year", academicYear);
                cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
            });

    public DataTable SearchRegisteredCourses(
        string mssv, string academicYear, string keyword) =>
        ExecuteQuery(@"
            SELECT c.CourseID, c.CourseCode, c.CourseName, c.CreditHour,
                   pre.CourseName AS [Prerequisite Course], c.Semester, c.Week
            FROM DKMH d
            JOIN Course c ON d.CourseID = c.CourseID
            LEFT JOIN Course pre ON c.PrerequisiteCourseID = pre.CourseID
            WHERE d.MSSV = @mssv AND d.AcademicYear = @year
            AND (c.CourseCode LIKE @kw OR c.CourseName LIKE @kw)
            ORDER BY c.CourseCode",
            cmd => {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@year", academicYear);
                cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
            });

    // ================= REGISTER / CANCEL (with year) =================
    // ================= REGISTER / CANCEL (with year) =================
    public static (bool success, string message) RegisterCourse(
        string mssv, int courseID, string academicYear)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();

                // Guard: courseID không hợp lệ
                if (courseID <= 0)
                    return (false, "Invalid course!");

                var check = new SqlCommand(@"
                SELECT COUNT(*) FROM DKMH
                WHERE MSSV = @mssv AND CourseID = @id AND AcademicYear = @year",
                    db.getConnection);
                check.Parameters.AddWithValue("@mssv", mssv);
                check.Parameters.AddWithValue("@id", courseID);
                check.Parameters.AddWithValue("@year", academicYear);
                if ((int)check.ExecuteScalar() > 0)
                    return (false, "Already registered this course!");

                var credit = new SqlCommand(
                    "SELECT CreditHour FROM Course WHERE CourseID = @id",
                    db.getConnection);
                credit.Parameters.AddWithValue("@id", courseID);
                object creditResult = credit.ExecuteScalar();

                // Guard: môn không tồn tại
                if (creditResult == null || creditResult == DBNull.Value)
                    return (false, "Course not found!");

                int newCredits = Convert.ToInt32(creditResult);

                var total = new SqlCommand(@"
                SELECT ISNULL(SUM(c.CreditHour), 0)
                FROM DKMH d JOIN Course c ON d.CourseID = c.CourseID
                WHERE d.MSSV = @mssv AND d.AcademicYear = @year",
                    db.getConnection);
                total.Parameters.AddWithValue("@mssv", mssv);
                total.Parameters.AddWithValue("@year", academicYear);
                int current = Convert.ToInt32(total.ExecuteScalar());

                if (current + newCredits > 24)
                    return (false, $"Exceeded 24 credits! Current: {current}, Adding: {newCredits}");

                var insert = new SqlCommand(@"
                INSERT INTO DKMH (MSSV, CourseID, AcademicYear)
                VALUES (@mssv, @id, @year)",
                    db.getConnection);
                insert.Parameters.AddWithValue("@mssv", mssv);
                insert.Parameters.AddWithValue("@id", courseID);
                insert.Parameters.AddWithValue("@year", academicYear);
                insert.ExecuteNonQuery();

                return (true, $"Registered! Total credits: {current + newCredits}/24");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }

    // ================= REGISTER / CANCEL (no year) =================
    public static (bool success, string message) RegisterCourse(string mssv, int courseID)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();

                if (courseID <= 0)
                    return (false, "Invalid course!");

                var check = new SqlCommand(
                    "SELECT COUNT(*) FROM DKMH WHERE MSSV=@mssv AND CourseID=@id",
                    db.getConnection);
                check.Parameters.AddWithValue("@mssv", mssv);
                check.Parameters.AddWithValue("@id", courseID);
                if ((int)check.ExecuteScalar() > 0)
                    return (false, "Already registered this course!");

                var credit = new SqlCommand(
                    "SELECT CreditHour FROM Course WHERE CourseID=@id",
                    db.getConnection);
                credit.Parameters.AddWithValue("@id", courseID);
                object creditResult = credit.ExecuteScalar();

                if (creditResult == null || creditResult == DBNull.Value)
                    return (false, "Course not found!");

                int newCredits = Convert.ToInt32(creditResult);

                var total = new SqlCommand(@"
                SELECT ISNULL(SUM(c.CreditHour), 0)
                FROM DKMH d JOIN Course c ON d.CourseID = c.CourseID
                WHERE d.MSSV = @mssv",
                    db.getConnection);
                total.Parameters.AddWithValue("@mssv", mssv);
                int current = Convert.ToInt32(total.ExecuteScalar());

                if (current + newCredits > 24)
                    return (false, $"Exceeded 24 credits! Current: {current}, Adding: {newCredits}");

                var insert = new SqlCommand(
                    "INSERT INTO DKMH (MSSV, CourseID) VALUES (@mssv, @id)",
                    db.getConnection);
                insert.Parameters.AddWithValue("@mssv", mssv);
                insert.Parameters.AddWithValue("@id", courseID);
                insert.ExecuteNonQuery();

                return (true, $"Registered! Total credits: {current + newCredits}/24");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }
    public static (bool success, string message) CancelCourse(
    string mssv, int courseID, string academicYear)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(@"
                DELETE FROM DKMH
                WHERE MSSV = @mssv AND CourseID = @id AND AcademicYear = @year",
                    db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@id", courseID);
                cmd.Parameters.AddWithValue("@year", academicYear);
                return cmd.ExecuteNonQuery() > 0
                    ? (true, "Cancelled successfully!")
                    : (false, "Registration not found!");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }
    public static (bool success, string message) CancelCourse(string mssv, int courseID)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "DELETE FROM DKMH WHERE MSSV=@mssv AND CourseID=@id", db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@id", courseID);
                return cmd.ExecuteNonQuery() > 0
                    ? (true, "Cancelled successfully!")
                    : (false, "Registration not found!");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }
    // Thêm vào Student.cs
    public DataTable GetAcademicYearsByMSSV(string mssv) =>
        ExecuteQuery(@"
        SELECT DISTINCT AcademicYear
        FROM DKMH
        WHERE MSSV = @mssv
        ORDER BY AcademicYear DESC",
            cmd => cmd.Parameters.AddWithValue("@mssv", mssv));
}