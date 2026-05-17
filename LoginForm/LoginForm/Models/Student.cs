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
}