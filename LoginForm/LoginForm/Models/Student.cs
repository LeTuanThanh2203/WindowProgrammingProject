using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;

public class Student
{


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

    public Student(string mssv,
        string fname,
        string lname,
        DateTime dob,
        string gender,
        string phone,
        string address,
        string hometown,
        string email,
        byte[] picture)
    {
        MSSV = mssv;
        Fname = fname;
        Lname = lname;
        Dob = dob;
        Gender = gender;
        Phone = phone;
        Address = address;
        Hometown = hometown;
        Email = email;
        Picture = picture;
    }
    public Student()
    {
    }
    public bool AddStudent()
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                string query = @"
                INSERT INTO Student
                (MSSV, FirstName, LastName, Dob, Gender, Phone, Address, HomeTown, Email, Picture)
                VALUES
                (@mssv, @fname, @lname, @dob, @gender, @phone, @address, @hometown, @email, @picture)";

                SqlCommand cmd = new SqlCommand(query, db.getConnection);

                // FIX: MSSV là NVarChar, không phải Int
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
            // Hiện lỗi thật thay vì âm thầm return false
            MessageBox.Show("AddStudent Error: " + ex.Message);
            return false;
        }
    }


    public bool EditStudent()
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                string query = @"
        UPDATE Student
        SET
            FirstName = @fname,
            LastName = @lname,
            Dob = @dob,
            Gender = @gender,
            Phone = @phone,
            Address = @address,
            HomeTown = @hometown,
            Email = @email,
            Picture = @picture
        WHERE MSSV = @mssv";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@mssv", MSSV);

                cmd.Parameters.AddWithValue(
                    "@fname", Fname);

                cmd.Parameters.AddWithValue(
                    "@lname", Lname);

                cmd.Parameters.AddWithValue(
                    "@dob", Dob);

                cmd.Parameters.AddWithValue(
                    "@gender", Gender);

                cmd.Parameters.AddWithValue(
                    "@phone", Phone);

                cmd.Parameters.AddWithValue(
                    "@address", Address);

                cmd.Parameters.AddWithValue(
                    "@hometown", Hometown);

                cmd.Parameters.AddWithValue(
                    "@email", Email);

                cmd.Parameters.AddWithValue(
                    "@picture",
                    (object)Picture ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch
        {
            return false;
        }
    }


    public static bool DeleteStudent(
    string mssv)
    {


        try
        {
            using (My_DB db = new My_DB())
            {

                db.openConnection();

                string query = @"
            DELETE FROM Student
            WHERE MSSV = @mssv";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@mssv",
                    mssv);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch
        {
            return false;
        }

    }
    public static bool DeleteScoreandStudent(
    string mssv)
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                // DELETE SCORE
                SqlCommand scoreCmd =
                    new SqlCommand(
                        "DELETE FROM Score WHERE MSSV=@mssv",
                        db.getConnection);

                scoreCmd.Parameters.AddWithValue(
                    "@mssv",
                    mssv);

                scoreCmd.ExecuteNonQuery();

                // DELETE DKMH
                SqlCommand dkmhCmd =
                    new SqlCommand(
                        "DELETE FROM DKMH WHERE MSSV=@mssv",
                        db.getConnection);

                dkmhCmd.Parameters.AddWithValue(
                    "@mssv",
                    mssv);

                dkmhCmd.ExecuteNonQuery();

                // DELETE STUDENT
                SqlCommand studentCmd =
                    new SqlCommand(
                        "DELETE FROM Student WHERE MSSV=@mssv",
                        db.getConnection);

                studentCmd.Parameters.AddWithValue(
                    "@mssv",
                    mssv);

                return studentCmd.ExecuteNonQuery() > 0;
            }
        }
        catch
        {
            return false;
        }
    }
    public bool AddStudent(string x)
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                string query = @"
            INSERT INTO Student
            (
                MSSV,
                FirstName,
                LastName,
                Gender,
                Email
            )
            VALUES
            (
                @mssv,
                @fname,
                @lname,
                @gender,
                @email
            )";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@mssv",
                    MSSV);

                cmd.Parameters.AddWithValue(
                    "@fname",
                    Fname);

                cmd.Parameters.AddWithValue(
                    "@lname",
                    Lname);

                cmd.Parameters.AddWithValue(
                    "@gender",
                    Gender);

                cmd.Parameters.AddWithValue(
                    "@email",
                    Email);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch
        {
            return false;
        }
    }
    // THAY THẾ RegisterCourse cũ (đang dùng MaMH sai)
    public static (bool success, string message) RegisterCourse(string mssv, int courseID)
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                // 1. Kiểm tra đã đăng ký chưa
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM DKMH WHERE MSSV = @mssv AND CourseID = @courseID",
                    db.getConnection);
                checkCmd.Parameters.AddWithValue("@mssv", mssv);
                checkCmd.Parameters.AddWithValue("@courseID", courseID);

                if ((int)checkCmd.ExecuteScalar() > 0)
                    return (false, "Student has already registered this course!");

                // 2. Lấy tín chỉ môn muốn đăng ký
                SqlCommand creditCmd = new SqlCommand(
                    "SELECT CreditHour FROM Course WHERE CourseID = @courseID",
                    db.getConnection);
                creditCmd.Parameters.AddWithValue("@courseID", courseID);
                int newCredits = (int)creditCmd.ExecuteScalar();

                // 3. Kiểm tra tổng tín chỉ hiện tại
                SqlCommand totalCmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(c.CreditHour), 0)
                  FROM DKMH d INNER JOIN Course c ON d.CourseID = c.CourseID
                  WHERE d.MSSV = @mssv",
                    db.getConnection);
                totalCmd.Parameters.AddWithValue("@mssv", mssv);
                int currentCredits = (int)totalCmd.ExecuteScalar();

                if (currentCredits + newCredits > 24)
                    return (false, $"Exceeded 24 credits! Current: {currentCredits}, Adding: {newCredits}");

                // 4. Insert
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO DKMH (MSSV, CourseID) VALUES (@mssv, @courseID)",
                    db.getConnection);
                insertCmd.Parameters.AddWithValue("@mssv", mssv);
                insertCmd.Parameters.AddWithValue("@courseID", courseID);
                insertCmd.ExecuteNonQuery();

                db.closeConnection();
                return (true, $"Registered! Total credits: {currentCredits + newCredits}/24");
            }
        }
        catch (Exception ex)
        {
            return (false, "Error: " + ex.Message);
        }
    }

    // THÊM: Hủy đăng ký
    public static (bool success, string message) CancelCourse(string mssv, int courseID)
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM DKMH WHERE MSSV = @mssv AND CourseID = @courseID",
                    db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@courseID", courseID);

                int rows = cmd.ExecuteNonQuery();
                db.closeConnection();

                return rows > 0
                    ? (true, "Course cancelled successfully!")
                    : (false, "Registration not found!");
            }
        }
        catch (Exception ex)
        {
            return (false, "Error: " + ex.Message);
        }
    }

    // THÊM: Lấy môn đã đăng ký của sinh viên
    public DataTable GetRegisteredCourses(string mssv)
    {
        DataTable table = new DataTable();
        try
        {
            using (My_DB db = new My_DB())
            {
                string query = @"
                SELECT 
                    c.CourseID,
                    c.CourseCode,
                    c.CourseName,
                    c.CreditHour,
                    c.Semester
                FROM DKMH d
                INNER JOIN Course c ON d.CourseID = c.CourseID
                WHERE d.MSSV = @mssv
                ORDER BY c.CourseCode";

                SqlCommand cmd = new SqlCommand(query, db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
        }
        catch { }
        return table;
    }

    // THÊM: Tổng tín chỉ hiện tại
    public int GetTotalCredits(string mssv)
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT ISNULL(SUM(c.CreditHour), 0)
                  FROM DKMH d INNER JOIN Course c ON d.CourseID = c.CourseID
                  WHERE d.MSSV = @mssv",
                    db.getConnection);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                db.openConnection();
                int total = (int)cmd.ExecuteScalar();
                db.closeConnection();
                return total;
            }
        }
        catch { return 0; }
    }
    public DataTable getStudents(
    SqlCommand command)
    {
        DataTable table =
            new DataTable();

        try
        {
            using (My_DB db =
                new My_DB())
            {
                command.Connection =
                    db.getConnection;

                SqlDataAdapter adapter =
                    new SqlDataAdapter(command);

                adapter.Fill(table);
            }
        }
        catch
        {

        }

        return table;
    }
    public int TotalStudent()
    {
        using (My_DB db = new My_DB())
        {

            SqlCommand command =
                new SqlCommand(
                    "SELECT COUNT(*) FROM Student",
                    db.getConnection);

            db.openConnection();

            int total =
                Convert.ToInt32(
                    command.ExecuteScalar());

            return total;
        }
    }
    public double totalMaleStudent()
    {
        SqlCommand command =
            new SqlCommand(
                "SELECT * FROM Student WHERE Gender = 'Male'");

        return getStudents(command)
            .Rows.Count;
    }
    public double totalFemaleStudent()
    {
        SqlCommand command =
            new SqlCommand(
                "SELECT * FROM Student WHERE Gender = 'Female'");

        return getStudents(command)
            .Rows.Count;
    }
    public double totalOtherStudent()
    {
        SqlCommand command =
            new SqlCommand(
                "SELECT * FROM Student WHERE Gender = 'Other'");

        return getStudents(command)
            .Rows.Count;
    }

    public DataTable SearchStudents(
    string keyword)
    {
        DataTable table =
            new DataTable();

        try
        {
            using (My_DB db = new My_DB())
            {
                string query = @"
            SELECT *
            FROM Student
            WHERE
                CAST(MSSV AS NVARCHAR) LIKE @keyword
                OR FirstName LIKE @keyword
                OR LastName LIKE @keyword
                OR Gender LIKE @keyword
                OR Phone LIKE @keyword
                OR Address LIKE @keyword
                OR HomeTown LIKE @keyword
                OR Email LIKE @keyword";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@keyword",
                    "%" + keyword + "%");

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                adapter.Fill(table);
            }
        }
        catch
        {

        }

        return table;
    }
    public Student GetStudentByID(string mssv)
    {
        Student student =
            null;

        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                string query = @"
            SELECT *
            FROM Student
            WHERE MSSV = @mssv";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@mssv",
                    mssv);

                SqlDataReader reader =
                    cmd.ExecuteReader();

                if (reader.Read())
                {
                    student =
                        new Student();

                    student.MSSV =
                        reader["MSSV"]
                        .ToString();

                    student.Fname =
                        reader["FirstName"]
                        .ToString();

                    student.Lname =
                        reader["LastName"]
                        .ToString();

                    student.Dob =
                        Convert.ToDateTime(
                            reader["Dob"]);

                    student.Gender =
                        reader["Gender"]
                        .ToString();

                    student.Phone =
                        reader["Phone"]
                        .ToString();

                    student.Address =
                        reader["Address"]
                        .ToString();

                    student.Hometown =
                        reader["HomeTown"]
                        .ToString();

                    student.Email =
                        reader["Email"]
                        .ToString();

                    // PICTURE
                    if (reader["Picture"]
                        != DBNull.Value)
                    {
                        student.Picture =
                            (byte[])reader["Picture"];
                    }
                }
            }
        }
        catch
        {

        }

        return student;
    }
    // THÊM: Lấy môn chưa đăng ký
    public DataTable GetUnRegisteredCourses(
        string mssv)
    {
        DataTable table =
            new DataTable();

        try
        {
            using (My_DB db = new My_DB())
            {
                string query = @"
            SELECT
                CourseID,
                CourseCode,
                CourseName,
                CreditHour,
                Semester
            FROM Course
            WHERE CourseID NOT IN
            (
                SELECT CourseID
                FROM DKMH
                WHERE MSSV = @mssv
            )
            ORDER BY CourseCode";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@mssv",
                    mssv);

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                adapter.Fill(table);
            }
        }
        catch
        {

        }

        return table;
    }

}