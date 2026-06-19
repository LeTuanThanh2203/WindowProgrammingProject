using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
namespace Project_Group6.Models
{
    public class Group
    {
        My_DB db = new My_DB();

        // ================= ADD =================
        public bool AddGroup(string name)
        {
            string query = @"
                INSERT INTO Groups(Name, UserID)
                VALUES(@name, @uid)";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            db.openConnection();
            bool result = cmd.ExecuteNonQuery() > 0;
            db.closeConnection();

            return result;
        }

        // ================= UPDATE =================
        public bool UpdateGroup(int id, string name)
        {
            string query = @"
                UPDATE Groups
                SET Name = @name
                WHERE ID = @id AND UserID = @uid";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            db.openConnection();
            bool result = cmd.ExecuteNonQuery() > 0;
            db.closeConnection();

            return result;
        }

        // ================= DELETE =================
        public bool DeleteGroup(int id)
        {
            string query = @"
                DELETE FROM Groups
                WHERE ID = @id AND UserID = @uid";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            db.openConnection();
            bool result = cmd.ExecuteNonQuery() > 0;
            db.closeConnection();

            return result;
        }

        // ================= GET =================
        public DataTable GetGroups()
        {
            string query = @"
                SELECT ID, Name
                FROM Groups
                WHERE UserID = @uid";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}
