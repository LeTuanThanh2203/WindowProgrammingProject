using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;

namespace Project_Group6
{
    public class Score
    {
        public string MSSV { get; set; }
        public int CourseID { get; set; }
        public decimal MidtermScore { get; set; }
        public decimal FinalScore { get; set; }
        public decimal TotalScore { get; set; }
        public string Overview { get; set; }

        public Score()
        {
        }

        public Score(
            string mssv,
            int courseID,
            decimal midtermScore,
            decimal finalScore)
        {
            MSSV = mssv;
            CourseID = courseID;
            MidtermScore = midtermScore;
            FinalScore = finalScore;
        }

        public bool AddScore()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    TotalScore = Math.Round(
                        MidtermScore * 0.4m +
                        FinalScore * 0.6m, 2);

                    Overview = GetOverview();

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

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EditScore()
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    TotalScore = Math.Round(
                        MidtermScore * 0.4m +
                        FinalScore * 0.6m, 2);

                    Overview = GetOverview();

                    string query = @"
                    UPDATE Score
                    SET
                        MidtermScore = @midterm,
                        FinalScore = @final,
                        TotalScore = @total,
                        Overview = @overview
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

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteScore(
            string mssv,
            int courseID)
        {
            try
            {
                using (My_DB db = new My_DB())
                {
                    db.openConnection();

                    string query = @"
                    DELETE FROM Score
                    WHERE MSSV = @mssv
                    AND CourseID = @courseID";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@mssv",
                        mssv);

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

        public DataTable GetScores(
            SqlCommand command)
        {
            DataTable table =
                new DataTable();

            try
            {
                using (My_DB db =
                    new My_DB())
                {
                    command.Connection =
                        db.getConnection;

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

        public DataTable SearchScore(
            string keyword)
        {
            DataTable table =
                new DataTable();

            try
            {
                using (My_DB db =
                    new My_DB())
                {
                    string query = @"
                    SELECT *
                    FROM Score
                    WHERE
                        MSSV LIKE @keyword
                        OR CAST(CourseID AS VARCHAR) LIKE @keyword
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

        public Score GetScoreByID(
            string mssv,
            int courseID)
        {
            Score score = null;

            try
            {
                using (My_DB db =
                    new My_DB())
                {
                    db.openConnection();

                    string query = @"
                    SELECT *
                    FROM Score
                    WHERE MSSV = @mssv
                    AND CourseID = @courseID";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@mssv",
                        mssv);

                    cmd.Parameters.AddWithValue(
                        "@courseID",
                        courseID);

                    SqlDataReader reader =
                        cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        score = new Score();

                        score.MSSV =
                            reader["MSSV"]
                            .ToString();

                        score.CourseID =
                            Convert.ToInt32(
                                reader["CourseID"]);

                        score.MidtermScore =
                            Convert.ToDecimal(
                                reader["MidtermScore"]);

                        score.FinalScore =
                            Convert.ToDecimal(
                                reader["FinalScore"]);

                        score.TotalScore =
                            Convert.ToDecimal(
                                reader["TotalScore"]);

                        score.Overview =
                            reader["Overview"]
                            .ToString();
                    }
                }
            }
            catch
            {
            }

            return score;
        }

        private string GetOverview()
        {
            if (TotalScore >= 8)
                return "Excellent";

            if (TotalScore >= 6.5m)
                return "Good";

            if (TotalScore >= 5)
                return "Pass";

            return "Fail";
        }
    }
}