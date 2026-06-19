using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using Microsoft.Data.SqlClient;

namespace Project_Group6.Models
{
    public class Assign
    {
        My_DB db = new My_DB();

        public bool InsertAssign(string hrid, string courseid)
        {
            string query =
                @"INSERT INTO Assign(HRID, CourseID)
                  VALUES(@hrid,@courseid)";

            SqlCommand cmd =
                new SqlCommand(query, db.getConnection);

            cmd.Parameters.Add("@hrid", SqlDbType.VarChar)
                          .Value = hrid;

            cmd.Parameters.Add("@courseid", SqlDbType.VarChar)
                          .Value = courseid;

            db.openConnection();

            bool success =
                cmd.ExecuteNonQuery() == 1;

            db.closeConnection();

            return success;
        }

        public bool DeleteAssign(string hrid, string courseid)
        {
            string query =
                @"DELETE FROM Assign
                  WHERE HRID=@hrid
                  AND CourseID=@courseid";

            SqlCommand cmd =
                new SqlCommand(query, db.getConnection);

            cmd.Parameters.Add("@hrid", SqlDbType.VarChar)
                          .Value = hrid;

            cmd.Parameters.Add("@courseid", SqlDbType.VarChar)
                          .Value = courseid;

            db.openConnection();

            bool success =
                cmd.ExecuteNonQuery() == 1;

            db.closeConnection();

            return success;
        }

        public DataTable GetAssignList()
        {
            string query =
            @"SELECT
                h.ID,
                h.FirstName + ' ' + h.LastName AS LecturerName,
                c.CourseID,
                c.CourseName,
                c.Credits
              FROM Assign a
              INNER JOIN HR h
                   ON a.HRID = h.ID
              INNER JOIN Course c
                   ON a.CourseID = c.CourseID";

            SqlDataAdapter adapter =
                new SqlDataAdapter(query,
                                   db.getConnection);

            DataTable table =
                new DataTable();

            adapter.Fill(table);

            return table;
        }

        public int CountAssignedCourses(string hrid)
        {
            string query =
                @"SELECT COUNT(*)
                  FROM Assign
                  WHERE HRID=@hrid";

            SqlCommand cmd =
                new SqlCommand(query,
                               db.getConnection);

            cmd.Parameters.Add("@hrid",
                               SqlDbType.VarChar)
                               .Value = hrid;

            db.openConnection();

            int count =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            db.closeConnection();

            return count;
        }


        public bool IsAssigned(
          string hrid,
          string courseid)
        {
            string query =
                @"SELECT COUNT(*)
                  FROM Assign
                  WHERE HRID=@hrid
                  AND CourseID=@courseid";

            SqlCommand cmd =
                new SqlCommand(query,
                               db.getConnection);

            cmd.Parameters.Add("@hrid",
                               SqlDbType.VarChar)
                               .Value = hrid;

            cmd.Parameters.Add("@courseid",
                               SqlDbType.VarChar)
                               .Value = courseid;

            db.openConnection();

            int count =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            db.closeConnection();

            return count > 0;
        }

        public DataTable GetCoursesForCombo()
        {
            DataTable table = new DataTable();

            string query =
                @"SELECT CourseID,
                 CourseName
          FROM Course
          ORDER BY CourseName";

            SqlDataAdapter adapter =
                new SqlDataAdapter(query,
                                   db.getConnection);

            adapter.Fill(table);

            return table;
        }
        public DataTable SearchHRForCombo(string keyword)
        {
            DataTable table = new DataTable();

            string query = @"
        SELECT
            ID,
            ID + ' - ' + FirstName + ' ' + LastName AS HRDisplay
        FROM HR
        WHERE ID LIKE @kw
           OR FirstName LIKE @kw
           OR LastName LIKE @kw
        ORDER BY ID";

            SqlCommand cmd =
                new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            SqlDataAdapter adapter =
                new SqlDataAdapter(cmd);

            adapter.Fill(table);

            return table;
        }

        public DataTable SearchCourseForCombo(string keyword)
        {
            DataTable table = new DataTable();

            string query = @"
        SELECT
            CourseID,
            CourseName
        FROM Course
        WHERE CourseID LIKE @kw
           OR CourseName LIKE @kw
        ORDER BY CourseName";

            SqlCommand cmd =
                new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

            SqlDataAdapter adapter =
                new SqlDataAdapter(cmd);

            adapter.Fill(table);

            return table;
        }



    }



}