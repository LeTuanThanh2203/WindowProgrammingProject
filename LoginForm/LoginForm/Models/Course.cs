using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;

namespace Project_Group6.Models
{
    internal class Course
    {
        // PROPERTIES
        public int CourseID { get; set; }

        public string CourseCode { get; set; }

        public string CourseName { get; set; }

        public int CreditHour { get; set; }

        public int Semester { get; set; }

        public int Week { get; set; }

        public string Overview { get; set; }

        public int? PrerequisiteCourseID { get; set; }

        public int TheoryPeriod { get; set; }

        public int PracticalPeriod { get; set; }

        // CONSTRUCTOR
        public Course()
        {

        }

        public Course(
            int courseID,
            string courseCode,
            string courseName,
            int creditHour,
            int semester,
            int week,
            string overview,
            int? prerequisiteCourseID,
            int theoryPeriod,
            int practicalPeriod)
        {
            CourseID = courseID;
            CourseCode = courseCode;
            CourseName = courseName;
            CreditHour = creditHour;
            Semester = semester;
            Week = week;
            Overview = overview;
            PrerequisiteCourseID =
                prerequisiteCourseID;
            TheoryPeriod = theoryPeriod;
            PracticalPeriod = practicalPeriod;
        }

        // ADD COURSE
        public bool AddCourse()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    string query = @"
                    INSERT INTO Course
                    (
                        CourseCode,
                        CourseName,
                        CreditHour,
                        Semester,
                        Week,
                        Overview,
                        PrerequisiteCourseID,
                        TheoryPeriod,
                        PracticalPeriod
                    )
                    VALUES
                    (
                        @courseCode,
                        @courseName,
                        @creditHour,
                        @semester,
                        @week,
                        @overview,
                        @prerequisiteCourseID,
                        @theoryPeriod,
                        @practicalPeriod
                    )";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@courseCode",
                        CourseCode);

                    cmd.Parameters.AddWithValue(
                        "@courseName",
                        CourseName);

                    cmd.Parameters.AddWithValue(
                        "@creditHour",
                        CreditHour);

                    cmd.Parameters.AddWithValue(
                        "@semester",
                        Semester);

                    cmd.Parameters.AddWithValue(
                        "@week",
                        Week);

                    cmd.Parameters.AddWithValue(
                        "@overview",
                        (object)Overview
                        ?? DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@prerequisiteCourseID",
                        (object)PrerequisiteCourseID
                        ?? DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@theoryPeriod",
                        TheoryPeriod);

                    cmd.Parameters.AddWithValue(
                        "@practicalPeriod",
                        PracticalPeriod);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // GET PREREQUISITE COURSE
        public DataTable GetPrerequisiteCourse()
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
                        CourseCode + ' - ' + CourseName
                        AS CourseDisplay
                    FROM Course";

                    SqlCommand command =
                        new SqlCommand(
                            query,
                            db.getConnection);

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

        // EDIT COURSE
        public bool EditCourse()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    string query = @"
                    UPDATE Course
                    SET
                        CourseCode = @courseCode,
                        CourseName = @courseName,
                        CreditHour = @creditHour,
                        Semester = @semester,
                        Week = @week,
                        Overview = @overview,
                        PrerequisiteCourseID =
                            @prerequisiteCourseID,
                        TheoryPeriod = @theoryPeriod,
                        PracticalPeriod =
                            @practicalPeriod
                    WHERE CourseID = @courseID";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@courseID",
                        CourseID);

                    cmd.Parameters.AddWithValue(
                        "@courseCode",
                        CourseCode);

                    cmd.Parameters.AddWithValue(
                        "@courseName",
                        CourseName);

                    cmd.Parameters.AddWithValue(
                        "@creditHour",
                        CreditHour);

                    cmd.Parameters.AddWithValue(
                        "@semester",
                        Semester);

                    cmd.Parameters.AddWithValue(
                        "@week",
                        Week);

                    cmd.Parameters.AddWithValue(
                        "@overview",
                        (object)Overview
                        ?? DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@prerequisiteCourseID",
                        (object)PrerequisiteCourseID
                        ?? DBNull.Value);

                    cmd.Parameters.AddWithValue(
                        "@theoryPeriod",
                        TheoryPeriod);

                    cmd.Parameters.AddWithValue(
                        "@practicalPeriod",
                        PracticalPeriod);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // KHÔNG return silent
                return false;
            }
        }

        // DELETE COURSE
        public static bool DelCourse(
            int courseID)
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    string query = @"
                    DELETE FROM Course
                    WHERE CourseID = @courseID";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@courseID",
                        courseID);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // GET ALL COURSE
        public DataTable GetCourse()
        {
            DataTable table =
                new DataTable();

            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    string query =
                        "SELECT * FROM Course";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

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

        // GET COURSE BY ID
        public Course GetCourseByID(
            int courseID)
        {
            Course course = null;

            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    string query = @"
                    SELECT *
                    FROM Course
                    WHERE CourseID = @courseID";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@courseID",
                        courseID);

                    SqlDataReader reader =
                        cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        course =
                            new Course();

                        course.CourseID =
                            Convert.ToInt32(
                                reader["CourseID"]);

                        course.CourseCode =
                            reader["CourseCode"]
                            .ToString();

                        course.CourseName =
                            reader["CourseName"]
                            .ToString();

                        course.CreditHour =
                            Convert.ToInt32(
                                reader["CreditHour"]);

                        course.Semester =
                            Convert.ToInt32(
                                reader["Semester"]);

                        course.Week =
                            Convert.ToInt32(
                                reader["Week"]);

                        course.Overview =
                            reader["Overview"]
                            .ToString();

                        if (reader["PrerequisiteCourseID"]
                            != DBNull.Value)
                        {
                            course.PrerequisiteCourseID =
                                Convert.ToInt32(
                                    reader["PrerequisiteCourseID"]);
                        }

                        course.TheoryPeriod =
                            Convert.ToInt32(
                                reader["TheoryPeriod"]);

                        course.PracticalPeriod =
                            Convert.ToInt32(
                                reader["PracticalPeriod"]);
                    }
                }
            }
            catch
            {

            }

            return course;
        }

        // SEARCH COURSE
        public DataTable SearchCourse(
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
                    FROM Course
                    WHERE
                        CourseCode LIKE @keyword
                        OR CourseName LIKE @keyword
                        OR Overview LIKE @keyword";

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

        // TOTAL COURSE
        public int TotalCourse()
        {
            using (My_DB db = new My_DB())
            {
                SqlCommand command =
                    new SqlCommand(
                        "SELECT COUNT(*) FROM Course",
                        db.getConnection);

                db.openConnection();

                int total =
                    Convert.ToInt32(
                        command.ExecuteScalar());

                return total;
            }
        }
    }
}