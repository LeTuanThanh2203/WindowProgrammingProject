using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;


    public class Score
    {
        // ================= PROPERTY =================
        public string MSSV { get; set; }

        public int CourseID { get; set; }

        public decimal MidtermScore { get; set; }

        public decimal FinalScore { get; set; }

        public decimal TotalScore { get; set; }

        public string Overview { get; set; }

        // ================= ADD SCORE =================
        public bool AddScore()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    TotalScore =
                        Math.Round(
                            (MidtermScore + FinalScore) / 2,
                            2);

                    Overview =
                        GetOverview();

                    string query = @"
                    INSERT INTO Score
                    (
                        MSSV,
                        CourseID,
                        MidtermScore,
                        FinalScore,
                        TotalScore,
                        Overview
                    )
                    VALUES
                    (
                        @mssv,
                        @courseID,
                        @midterm,
                        @final,
                        @total,
                        @overview
                    )";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@mssv",
                        MSSV);

                    cmd.Parameters.AddWithValue(
                        "@courseID",
                        CourseID);

                    cmd.Parameters.AddWithValue(
                        "@midterm",
                        MidtermScore);

                    cmd.Parameters.AddWithValue(
                        "@final",
                        FinalScore);

                    cmd.Parameters.AddWithValue(
                        "@total",
                        TotalScore);

                    cmd.Parameters.AddWithValue(
                        "@overview",
                        Overview);

                    return
                        cmd.ExecuteNonQuery() == 1;
                }
            }
            catch
            {
                return false;
            }
        }

        // ================= DELETE SCORE =================
        public bool DeleteScore()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    string query = @"
                    DELETE FROM Score
                    WHERE
                        MSSV = @mssv
                        AND CourseID = @courseID";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@mssv",
                        MSSV);

                    cmd.Parameters.AddWithValue(
                        "@courseID",
                        CourseID);

                    return
                        cmd.ExecuteNonQuery() == 1;
                }
            }
            catch
            {
                return false;
            }
        }

        // ================= GET ALL SCORE =================
        public DataTable GetAllScore()
        {
            DataTable table =
                new DataTable();

            using (My_DB db = new My_DB())
            {
                string query = @"
                SELECT
                    Score.MSSV,
                    Student.FirstName,
                    Student.LastName,
                    Course.CourseName,
                    Score.MidtermScore,
                    Score.FinalScore,
                    Score.TotalScore,
                    Score.Overview
                FROM Score
                JOIN Student
                ON Score.MSSV = Student.MSSV
                JOIN Course
                ON Score.CourseID = Course.CourseID";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                adapter.Fill(table);
            }

            return table;
        }

    // ================= GET SCORE BY STUDENT =================
    public DataTable GetScoreByStudent(string mssv)
    {
        DataTable table = new DataTable();

        using (My_DB db = new My_DB())
        {
            string query = @"
        SELECT
            Score.MSSV,
            Course.CourseName,
            Score.MidtermScore,
            Score.FinalScore,
            Score.TotalScore,
            Score.Overview
        FROM Score
        INNER JOIN Course
            ON Score.CourseID = Course.CourseID
        WHERE Score.MSSV = @mssv";

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.Add("@mssv", SqlDbType.NVarChar).Value = mssv;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);
        }

        return table;
    }

    // ================= SEARCH SCORE =================
    public DataTable SearchScore(
            string keyword)
        {
            DataTable table =
                new DataTable();

            using (My_DB db = new My_DB())
            {
                string query = @"
                SELECT
                    Score.MSSV,
                    Student.FirstName,
                    Student.LastName,
                    Course.CourseName,
                    Score.TotalScore,
                    Score.Overview
                FROM Score
                JOIN Student
                ON Score.MSSV = Student.MSSV
                JOIN Course
                ON Score.CourseID = Course.CourseID
                WHERE
                    Score.MSSV LIKE @keyword
                    OR Course.CourseName LIKE @keyword
                    OR Score.Overview LIKE @keyword";

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

            return table;
        }

        // ================= OVERVIEW =================
        public string GetOverview()
        {
            if (TotalScore >= 8)
            {
                return "Excellent";
            }

            if (TotalScore >= 6.5m)
            {
                return "Good";
            }

            if (TotalScore >= 5)
            {
                return "Pass";
            }

            return "Fail";
        }
    }
