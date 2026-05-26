using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;

namespace Project_Group6
{
    internal class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public int CreditHour { get; set; }
        public string Overview { get; set; }
        public string PrerequisiteCourseID { get; set; }
        public int TheoryPeriod { get; set; }
        public int PracticalPeriod { get; set; }

        public Course()
        {

        }

        public Course(
            string courseID,
            string courseName,
            int creditHour,
            string overview,
            string prerequisiteCourseID,
            int theoryPeriod,
            int practicalPeriod)
        {
            CourseID = courseID;
            CourseName = courseName;
            CreditHour = creditHour;
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
                        CourseID,
                        CourseName,
                        CreditHour,
                        Overview,
                        PrerequisiteCourseID,
                        TheoryPeriod,
                        PracticalPeriod
                    )
                    VALUES
                    (
                        @courseID,
                        @courseName,
                        @creditHour,
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
                        "@courseID",
                        CourseID);

                    cmd.Parameters.AddWithValue(
                        "@courseName",
                        CourseName);

                    cmd.Parameters.AddWithValue(
                        "@creditHour",
                        CreditHour);

                    cmd.Parameters.AddWithValue(
                        "@overview",
                        Overview);

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
                CourseID + ' - ' + CourseName
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
                        CourseName = @courseName,
                        CreditHour = @creditHour,
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
                        "@courseName",
                        CourseName);

                    cmd.Parameters.AddWithValue(
                        "@creditHour",
                        CreditHour);

                    cmd.Parameters.AddWithValue(
                        "@overview",
                        Overview);

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

        // DELETE COURSE
        public static bool DelCourse(
            string courseID)
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
            string courseID)
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
                            reader["CourseID"]
                            .ToString();

                        course.CourseName =
                            reader["CourseName"]
                            .ToString();

                        course.CreditHour =
                            Convert.ToInt32(
                                reader["CreditHour"]);

                        course.Overview =
                            reader["Overview"]
                            .ToString();

                        course.PrerequisiteCourseID =
                            reader["PrerequisiteCourseID"]
                            .ToString();

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
                        CourseID LIKE @keyword
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