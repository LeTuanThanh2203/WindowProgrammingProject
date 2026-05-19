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
                (
                    MSSV,
                    FirstName,
                    LastName,
                    Dob,
                    Gender,
                    Phone,
                    Address,
                    HomeTown,
                    Email,
                    Picture
                )
                VALUES
                (
                    @mssv,
                    @fname,
                    @lname,
                    @dob,
                    @gender,
                    @phone,
                    @address,
                    @hometown,
                    @email,
                    @picture
                )";

                SqlCommand cmd =
                    new SqlCommand(query, db.getConnection);

                cmd.Parameters.Add("@mssv",
                    SqlDbType.Int).Value = MSSV;

                cmd.Parameters.Add("@fname",
                    SqlDbType.NVarChar).Value = Fname;

                cmd.Parameters.Add("@lname",
                    SqlDbType.NVarChar).Value = Lname;

                cmd.Parameters.Add("@dob",
                    SqlDbType.Date).Value = Dob;

                cmd.Parameters.Add("@gender",
                    SqlDbType.NVarChar).Value = Gender;

                cmd.Parameters.Add("@phone",
                    SqlDbType.VarChar).Value = Phone;

                cmd.Parameters.Add("@address",
                    SqlDbType.NVarChar).Value = Address;

                cmd.Parameters.Add("@hometown",
                    SqlDbType.NVarChar).Value = Hometown;

                cmd.Parameters.Add("@email",
                    SqlDbType.VarChar).Value = Email;

                //cmd.Parameters.Add("@picture",
                //    SqlDbType.Image).Value =
                //    (object)Picture ?? DBNull.Value;
                cmd.Parameters.Add("@picture",
                SqlDbType.VarBinary).Value =
                (object)Picture ?? DBNull.Value;

                int result = cmd.ExecuteNonQuery();

                return result > 0;
            }
        }
        catch
        {
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
    public static bool RegisterCourse(
    string mssv,
    string mamh)
    {
        try
        {
            using (My_DB db = new My_DB())
            {
                db.openConnection();

                string query = @"
            INSERT INTO DKMH
            (
                MSSV,
                MaMH
            )
            VALUES
            (
                @mssv,
                @mamh
            )";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@mssv",
                    mssv);

                cmd.Parameters.AddWithValue(
                    "@mamh",
                    mamh);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch
        {
            return false;
        }
    }
    public DataTable getStudents(
    SqlCommand command)
    {
        DataTable table =
            new DataTable();

        SqlDataAdapter adapter =
            new SqlDataAdapter(command);

        adapter.Fill(table);

        return table;
    }
    public double totalStudent()
    {
        SqlCommand command =
            new SqlCommand(
                "SELECT COUNT(*) FROM Student");

        return Convert.ToDouble(
            getStudents(command)
            .Rows.Count);
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
    public Student GetStudentByID(
    int mssv)
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

}