using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Project_Group6.Models
{
    public class Contact
    {
        My_DB db = new My_DB();

        // ================= ADD =================
        public bool AddContact(
            string fname,
            string lname,
            DateTime dob,
            string gender,
            string phone,
            string email,
            string address,
            byte[] picture,
            int groupId)
        {
            string query = @"
                INSERT INTO Contact
                (Fname, Lname, Dob, Gender, Phone, Email, Address, Picture, Group_ID, UserID)
                VALUES
                (@fname,@lname,@dob,@gender,@phone,@email,@address,@pic,@gid,@uid)";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@pic", (object)picture ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@gid", groupId);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            db.openConnection();
            bool result = cmd.ExecuteNonQuery() > 0;
            db.closeConnection();

            return result;
        }

        // ================= UPDATE =================
        public bool UpdateContact(int id,
            string fname,
            string lname,
            DateTime dob,
            string gender,
            string phone,
            string email,
            string address,
            byte[] picture,
            int groupId)
        {
            string query = @"
                UPDATE Contact
                SET Fname=@fname,
                    Lname=@lname,
                    Dob=@dob,
                    Gender=@gender,
                    Phone=@phone,
                    Email=@email,
                    Address=@address,
                    Picture=@pic,
                    Group_ID=@gid
                WHERE ID=@id AND UserID=@uid";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@pic", (object)picture ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@gid", groupId);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            db.openConnection();
            bool result = cmd.ExecuteNonQuery() > 0;
            db.closeConnection();

            return result;
        }

        // ================= DELETE =================
        public bool DeleteContact(int id)
        {
            string query = @"
                DELETE FROM Contact
                WHERE ID=@id AND UserID=@uid";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            db.openConnection();
            bool result = cmd.ExecuteNonQuery() > 0;
            db.closeConnection();

            return result;
        }

        // ================= GET ALL =================
        public DataTable GetContacts()
        {
            // Dùng LEFT JOIN (không phải INNER JOIN) để contact vẫn hiển thị
            // ngay cả khi Group_ID không khớp với bảng Groups (ví dụ nhóm đã bị xóa,
            // hoặc do lỗi dữ liệu cũ) - tránh hiện tượng "mất" contact khỏi danh sách
            // ngay sau khi thêm. Lấy c.Group_ID (không phải g.ID) để giá trị luôn
            // đúng với những gì đang lưu trên contact, dùng để populate lại combo khi sửa.
            string query = @"
                SELECT c.ID, c.Fname, c.Lname, c.Dob, c.Gender,
                       c.Phone, c.Email, c.Address, c.Picture,
                       g.Name AS GroupName, c.Group_ID AS Group_ID
                FROM Contact c
                LEFT JOIN Groups g ON c.Group_ID = g.ID
                WHERE c.UserID = @uid
                ORDER BY c.Fname, c.Lname";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);
            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // ================= FILTER BY GROUP =================
        public DataTable GetContactsByGroup(int groupId)
        {
            // Cùng lý do với GetContacts(): dùng LEFT JOIN để không bị ẩn contact,
            // và lấy c.Group_ID trực tiếp từ bảng Contact.
            string query = @"
                SELECT c.ID, c.Fname, c.Lname, c.Dob, c.Gender,
                       c.Phone, c.Email, c.Address, c.Picture,
                       g.Name AS GroupName, c.Group_ID AS Group_ID
                FROM Contact c
                LEFT JOIN Groups g ON c.Group_ID = g.ID
                WHERE c.UserID = @uid AND c.Group_ID = @gid
                ORDER BY c.Fname, c.Lname";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);
            cmd.Parameters.AddWithValue("@gid", groupId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        // ================= SEARCH =================
        public DataTable SearchContacts(string keyword)
        {
            // Cùng lý do với GetContacts(): dùng LEFT JOIN để không bị ẩn contact,
            // và lấy c.Group_ID trực tiếp từ bảng Contact.
            string query = @"
                SELECT c.ID, c.Fname, c.Lname, c.Dob, c.Gender,
                       c.Phone, c.Email, c.Address, c.Picture,
                       g.Name AS GroupName, c.Group_ID AS Group_ID
                FROM Contact c
                LEFT JOIN Groups g ON c.Group_ID = g.ID
                WHERE c.UserID = @uid
                  AND (c.Fname LIKE @kw OR c.Lname LIKE @kw
                    OR c.Phone LIKE @kw OR c.Email LIKE @kw)";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@uid", LoginForm.Globals.GlobalUserId);
            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}