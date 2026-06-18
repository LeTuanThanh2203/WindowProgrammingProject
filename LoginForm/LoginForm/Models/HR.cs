using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Windows.Forms;

public class HR
{
    // ================= PROPERTIES =================
    // Theo schema: ID, FirstName, LastName, Dob, Gender,
    //              Phone, Email, Address, Picture
    // Bổ sung: Address (có trong SQL schema nhưng thiếu trong model cũ)
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
    public HR() { }

    public HR(string id, string firstName, string lastName, DateTime dob,
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
            MessageBox.Show("HR Error: " + ex.Message);
            return false;
        }
    }

    private static HR MapFromReader(SqlDataReader reader) => new HR
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

    private void AddHRParams(SqlCommand cmd)
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
    public bool AddHR() =>
        ExecuteNonQuery(@"
            INSERT INTO HR
                (ID, FirstName, LastName, Dob, Gender,
                 Phone, Email, Address, Picture)
            VALUES
                (@id, @fname, @lname, @dob, @gender,
                 @phone, @email, @address, @picture)",
            AddHRParams);

    // ================= EDIT =================
    public bool EditHR() =>
        ExecuteNonQuery(@"
            UPDATE HR SET
                FirstName = @fname,
                LastName  = @lname,
                Dob       = @dob,
                Gender    = @gender,
                Phone     = @phone,
                Email     = @email,
                Address   = @address,
                Picture   = @picture
            WHERE ID = @id",
            AddHRParams);

    // ================= DELETE =================
    public static bool DeleteHR(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "DELETE FROM HR WHERE ID = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

    // ================= GET ALL =================
    public DataTable GetAllHRs() =>
        ExecuteQuery("SELECT * FROM HR ORDER BY ID");

    // ================= GET BY ID =================
    public HR GetHRByID(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM HR WHERE ID = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;

                using var reader = cmd.ExecuteReader();
                return reader.Read() ? MapFromReader(reader) : null;
            }
        }
        catch { return null; }
    }

    // ================= SEARCH =================
    public DataTable SearchHRs(string keyword) =>
        ExecuteQuery(@"
            SELECT * FROM HR
            WHERE ID        LIKE @kw
               OR FirstName LIKE @kw
               OR LastName  LIKE @kw
               OR Gender    LIKE @kw
               OR Phone     LIKE @kw
               OR Email     LIKE @kw
               OR Address   LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= FOR COMBOBOX =================
    public DataTable GetHRsForCombo() =>
        ExecuteQuery(@"
            SELECT ID,
                   ID + ' - ' + FirstName + ' ' + LastName AS HRDisplay
            FROM HR
            ORDER BY ID");

    // ================= ASSIGN =================
    // Lấy danh sách lớp đã được assign cho HR này
    public DataTable GetAssignedClasses(string id) =>
        ExecuteQuery(@"
            SELECT
                a.ClassID,
                co.CourseName,
                cl.Semester,
                cl.AcademicYear,
                cl.Room,
                g.GroupName,
                a.AssignDate
            FROM Assign a
            JOIN Class    cl ON a.ClassID   = cl.ClassID
            JOIN Course   co ON cl.CourseID = co.CourseID
            JOIN [Groups] g  ON a.GroupID   = g.GroupID
            WHERE a.ID = @id
            ORDER BY a.AssignDate DESC",
            cmd => cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id);

    // ================= STATS =================
    public int TotalHRs()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM HR", db.getConnection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }
}