using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Windows.Forms;

public class Student
{
    // ================= PROPERTIES =================
    // Theo schema: ID, FirstName, LastName, Dob, Gender,
    //              Phone, Email, Address, Picture
    // KHÔNG còn: MSSV (đổi thành ID), HomeTown
    public string ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public byte[] Picture { get; set; }

    // ================= CONSTRUCTORS =================
    public Student() { }

    public Student(string id, string firstName, string lastName, DateTime dob,
        string gender, string phone, string email, string address, byte[] picture)
    {
        ID = id; FirstName = firstName; LastName = lastName; Dob = dob;
        Gender = gender; Phone = phone; Email = email;
        Address = address; Picture = picture;
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
            MessageBox.Show("Student Error: " + ex.Message);
            return false;
        }
    }

    private static Student MapFromReader(SqlDataReader reader) => new Student
    {
        ID = reader["ID"].ToString(),
        FirstName = reader["FirstName"].ToString(),
        LastName = reader["LastName"].ToString(),
        Dob = reader["Dob"] == DBNull.Value
                        ? DateTime.MinValue
                        : Convert.ToDateTime(reader["Dob"]),
        Gender = reader["Gender"].ToString(),
        Phone = reader["Phone"].ToString(),
        Email = reader["Email"].ToString(),
        Address = reader["Address"].ToString(),
        Picture = reader["Picture"] != DBNull.Value
                        ? (byte[])reader["Picture"]
                        : null
    };

    private void AddStudentParams(SqlCommand cmd)
    {
        cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = ID;
        cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 100).Value = (object)FirstName ?? DBNull.Value;
        cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = (object)LastName ?? DBNull.Value;
        cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Dob == DateTime.MinValue
                                                                               ? DBNull.Value
                                                                               : (object)Dob;
        cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 10).Value = (object)Gender ?? DBNull.Value;
        cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20).Value = (object)Phone ?? DBNull.Value;
        cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = (object)Email ?? DBNull.Value;
        cmd.Parameters.Add("@address", SqlDbType.NVarChar, 255).Value = (object)Address ?? DBNull.Value;
        cmd.Parameters.Add("@picture", SqlDbType.VarBinary).Value = (object)Picture ?? DBNull.Value;
    }

    // ================= ADD =================
    public bool AddStudent() =>
        ExecuteNonQuery(@"
            INSERT INTO Student
                (ID, FirstName, LastName, Dob, Gender,
                 Phone, Email, Address, Picture)
            VALUES
                (@id, @fname, @lname, @dob, @gender,
                 @phone, @email, @address, @picture)",
            AddStudentParams);

    // ================= EDIT =================
    public bool EditStudent() =>
        ExecuteNonQuery(@"
            UPDATE Student SET
                FirstName = @fname,
                LastName  = @lname,
                Dob       = @dob,
                Gender    = @gender,
                Phone     = @phone,
                Email     = @email,
                Address   = @address,
                Picture   = @picture
            WHERE ID = @id",
            AddStudentParams);

    // ================= DELETE =================
    public static bool DeleteStudent(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "DELETE FROM Student WHERE ID = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

    // Xóa Score → DKMH → Student theo thứ tự FK
    public static bool DeleteScoreAndStudent(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                // TR_DKMH_Delete tự xóa Score khi xóa DKMH,
                // nhưng gọi tường minh để chắc chắn.
                foreach (var sql in new[]
                {
                    "DELETE FROM Score   WHERE ID = @id",
                    "DELETE FROM DKMH    WHERE ID = @id",
                    "DELETE FROM Student WHERE ID = @id"
                })
                {
                    var cmd = new SqlCommand(sql, db.getConnection);
                    cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
        }
        catch { return false; }
    }

    // ================= GET ALL =================
    public DataTable GetAllStudents() =>
        ExecuteQuery("SELECT * FROM Student ORDER BY ID");

    // ================= GET BY ID =================
    public Student GetStudentByID(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM Student WHERE ID = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;

                using var reader = cmd.ExecuteReader();
                return reader.Read() ? MapFromReader(reader) : null;
            }
        }
        catch { return null; }
    }

    // ================= SEARCH =================
    public DataTable SearchStudents(string keyword) =>
        ExecuteQuery(@"
            SELECT * FROM Student
            WHERE ID        LIKE @kw
               OR FirstName LIKE @kw
               OR LastName  LIKE @kw
               OR Gender    LIKE @kw
               OR Phone     LIKE @kw
               OR Email     LIKE @kw
               OR Address   LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= STATS =================
    public int TotalStudents() => CountByGender(null);
    public int TotalMaleStudents() => CountByGender("Male");
    public int TotalFemaleStudents() => CountByGender("Female");

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
                if (gender != null)
                    cmd.Parameters.Add("@g", SqlDbType.NVarChar, 10).Value = gender;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    // ================= DKMH — REGISTERED / UNREGISTERED =================
    // Schema DKMH: (ID, ClassID, RegisterDate)
    // Join Class → Course để lấy CourseID, CourseName, Credits

    public DataTable GetUnRegisteredCourses(string id) =>
        ExecuteQuery(@"
            SELECT
                cl.ClassID,
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
            WHERE cl.ClassID NOT IN (
                SELECT ClassID FROM DKMH WHERE ID = @id
            )
            ORDER BY cl.CourseID",
            cmd => cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id);

    public DataTable GetRegisteredCourses(string id) =>
        ExecuteQuery(@"
            SELECT
                d.ClassID,
                co.CourseName,
                co.Credits,
                cl.Semester,
                cl.AcademicYear,
                cl.Room,
                cl.Schedule,
                d.RegisterDate
            FROM DKMH d
            JOIN Class  cl ON d.ClassID   = cl.ClassID
            JOIN Course co ON cl.CourseID = co.CourseID
            WHERE d.ID = @id
            ORDER BY cl.Semester, d.ClassID",
            cmd => cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id);

    public DataTable SearchUnRegisteredCourses(string id, string keyword) =>
        ExecuteQuery(@"
            SELECT
                cl.ClassID,
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
            WHERE cl.ClassID NOT IN (
                SELECT ClassID FROM DKMH WHERE ID = @id
            )
            AND (cl.ClassID    LIKE @kw
              OR co.CourseName LIKE @kw
              OR cl.Room       LIKE @kw)
            ORDER BY cl.CourseID",
            cmd =>
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
            });

    public DataTable SearchRegisteredCourses(string id, string keyword) =>
        ExecuteQuery(@"
            SELECT
                d.ClassID,
                co.CourseName,
                co.Credits,
                cl.Semester,
                cl.AcademicYear,
                cl.Room,
                cl.Schedule,
                d.RegisterDate
            FROM DKMH d
            JOIN Class  cl ON d.ClassID   = cl.ClassID
            JOIN Course co ON cl.CourseID = co.CourseID
            WHERE d.ID = @id
            AND (d.ClassID     LIKE @kw
              OR co.CourseName LIKE @kw
              OR cl.Room       LIKE @kw)
            ORDER BY cl.Semester, d.ClassID",
            cmd =>
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
            });

    // ================= REGISTER / CANCEL =================
    // PK của DKMH: (ID, ClassID) — trigger TR_CheckDuplicate + TR_CheckCapacity
    // xử lý duplicate và capacity check ở phía SQL Server.

    public static (bool success, string message) RegisterCourse(string id, string classID)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();

                // Kiểm tra còn chỗ không (trigger cũng kiểm tra, nhưng hiển thị
                // thông báo thân thiện trước khi gọi INSERT)
                var capCmd = new SqlCommand(@"
                    SELECT Capacity - CurrentStudents
                    FROM Class WHERE ClassID = @classID",
                    db.getConnection);
                capCmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                object capResult = capCmd.ExecuteScalar();

                if (capResult == null || capResult == DBNull.Value)
                    return (false, "Class not found!");

                if (Convert.ToInt32(capResult) <= 0)
                    return (false, "Class is full!");

                // INSERT — trigger TR_CheckDuplicate sẽ chặn nếu đã đăng ký,
                // trigger TR_DKMH_Insert sẽ tự tạo Score rỗng và tăng CurrentStudents.
                var insert = new SqlCommand(@"
                    INSERT INTO DKMH (ID, ClassID)
                    VALUES (@id, @classID)",
                    db.getConnection);
                insert.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                insert.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                insert.ExecuteNonQuery();

                return (true, "Registered successfully!");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }

    public static (bool success, string message) CancelCourse(string id, string classID)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();

                // Kiểm tra điểm đã nhập chưa — nếu có MidtermScore hoặc FinalScore
                // thì không cho hủy.
                var scoreCmd = new SqlCommand(@"
                    SELECT COUNT(*) FROM Score
                    WHERE ID = @id AND ClassID = @classID
                      AND (MidtermScore IS NOT NULL OR FinalScore IS NOT NULL)",
                    db.getConnection);
                scoreCmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                scoreCmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                if (Convert.ToInt32(scoreCmd.ExecuteScalar()) > 0)
                    return (false, "Cannot cancel: scores have already been entered!");

                // DELETE DKMH — trigger TR_DKMH_Delete tự xóa Score
                // và giảm CurrentStudents.
                var cmd = new SqlCommand(@"
                    DELETE FROM DKMH
                    WHERE ID = @id AND ClassID = @classID",
                    db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                return cmd.ExecuteNonQuery() > 0
                    ? (true, "Cancelled successfully!")
                    : (false, "Registration not found!");
            }
        }
        catch (Exception ex) { return (false, "Error: " + ex.Message); }
    }

    // ================= CREDITS / GPA =================
    public int GetTotalCredits(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT dbo.fn_GetTotalCredits(@id)", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    public decimal GetGPA(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT dbo.fn_GetGPA(@id)", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    // ================= STATS BY ENROLLMENT YEAR =================
    // ID format: năm 2 chữ số ở đầu, e.g. "24xxxxx" → 2024
    public DataTable GetStudentStatisticsByYear() =>
        ExecuteQuery(@"
            SELECT '20' + LEFT(ID, 2) AS EnrollmentYear,
                   COUNT(*) AS TotalStudents
            FROM Student
            GROUP BY LEFT(ID, 2)
            ORDER BY EnrollmentYear");

    // ================= ADDITIONAL STATISTICS =================
    public int TotalCoursesCount()
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

    public int TotalClassesCount()
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

    public int TotalEnrollmentsCount()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM DKMH", db.getConnection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    public DataTable GetGradeDistribution() =>
        ExecuteQuery(@"
            SELECT Overview, COUNT(*) AS Total
            FROM Score
            WHERE Overview IS NOT NULL
            GROUP BY Overview");

    public DataTable GetTopStudentsByGPA() =>
        ExecuteQuery(@"
            SELECT TOP 5 
                ID, 
                FirstName + ' ' + LastName AS StudentName, 
                dbo.fn_GetGPA(ID) AS GPA
            FROM Student
            ORDER BY GPA DESC");
}