using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Windows.Forms;

public class Manager
{
    // ================= PROPERTIES =================
    public string ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public byte[] Picture { get; set; }

    // ================= CONSTRUCTORS =================
    public Manager() { }

    public Manager(string id, string firstName, string lastName, DateTime dob,
                   string gender, string phone, string email, byte[] picture)
    {
        ID = id; FirstName = firstName; LastName = lastName; Dob = dob;
        Gender = gender; Phone = phone; Email = email; Picture = picture;
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
            MessageBox.Show("Manager Error: " + ex.Message);
            return false;
        }
    }

    private static Manager MapFromReader(SqlDataReader reader) => new Manager
    {
        ID = reader["ID"].ToString(),
        FirstName = reader["FirstName"].ToString(),
        LastName = reader["LastName"].ToString(),
        Dob = reader["Dob"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["Dob"]),
        Gender = reader["Gender"].ToString(),
        Phone = reader["Phone"].ToString(),
        Email = reader["Email"].ToString(),
        Picture = reader["Picture"] != DBNull.Value ? (byte[])reader["Picture"] : null
    };

    // ================= ADD =================
    public bool AddManager() =>
        ExecuteNonQuery(@"
            INSERT INTO Manager
                (ID, FirstName, LastName, Dob, Gender, Phone, Email, Picture)
            VALUES
                (@id, @fname, @lname, @dob, @gender, @phone, @email, @picture)",
            cmd =>
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = ID;
                cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 100).Value = (object)FirstName ?? DBNull.Value;
                cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = (object)LastName ?? DBNull.Value;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Dob == DateTime.MinValue ? DBNull.Value : (object)Dob;
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 10).Value = (object)Gender ?? DBNull.Value;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20).Value = (object)Phone ?? DBNull.Value;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = (object)Email ?? DBNull.Value;
                cmd.Parameters.Add("@picture", SqlDbType.VarBinary).Value = (object)Picture ?? DBNull.Value;
            });

    // ================= EDIT =================
    public bool EditManager() =>
        ExecuteNonQuery(@"
            UPDATE Manager SET
                FirstName = @fname,
                LastName  = @lname,
                Dob       = @dob,
                Gender    = @gender,
                Phone     = @phone,
                Email     = @email,
                Picture   = @picture
            WHERE ID = @id",
            cmd =>
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = ID;
                cmd.Parameters.Add("@fname", SqlDbType.NVarChar, 100).Value = (object)FirstName ?? DBNull.Value;
                cmd.Parameters.Add("@lname", SqlDbType.NVarChar, 50).Value = (object)LastName ?? DBNull.Value;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = Dob == DateTime.MinValue ? DBNull.Value : (object)Dob;
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 10).Value = (object)Gender ?? DBNull.Value;
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20).Value = (object)Phone ?? DBNull.Value;
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = (object)Email ?? DBNull.Value;
                cmd.Parameters.Add("@picture", SqlDbType.VarBinary).Value = (object)Picture ?? DBNull.Value;
            });

    // ================= DELETE =================
    public static bool DeleteManager(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "DELETE FROM Manager WHERE ID = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch { return false; }
    }

    // ================= GET ALL =================
    public DataTable GetAllManagers() =>
        ExecuteQuery("SELECT * FROM Manager ORDER BY ID");

    // ================= GET BY ID =================
    public Manager GetManagerByID(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT * FROM Manager WHERE ID = @id", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;

                using var reader = cmd.ExecuteReader();
                return reader.Read() ? MapFromReader(reader) : null;
            }
        }
        catch { return null; }
    }

    // ================= SEARCH =================
    public DataTable SearchManagers(string keyword) =>
        ExecuteQuery(@"
            SELECT * FROM Manager
            WHERE ID        LIKE @kw
               OR FirstName LIKE @kw
               OR LastName  LIKE @kw
               OR Gender    LIKE @kw
               OR Phone     LIKE @kw
               OR Email     LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= STATS =================
    public int TotalManagers()
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand("SELECT COUNT(*) FROM Manager", db.getConnection);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }
}