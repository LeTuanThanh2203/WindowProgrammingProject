using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;

public class Score
{
    // ================= PROPERTIES =================
    public string  MSSV          { get; set; }
    public int     CourseID      { get; set; }
    public decimal MidtermScore  { get; set; }
    public decimal FinalScore    { get; set; }
    public decimal TotalScore    { get; set; }
    public string  Overview      { get; set; }

    // ================= HELPER =================
    private void ComputeTotalAndOverview()
    {
        TotalScore = Math.Round((MidtermScore + FinalScore) / 2, 2);
        Overview   = GetOverview();
    }

    private DataTable ExecuteQuery(string query, Action<SqlCommand> addParams = null)
    {
        var table = new DataTable();
        using (var db = new My_DB())
        {
            var cmd = new SqlCommand(query, db.getConnection);
            addParams?.Invoke(cmd);
            new SqlDataAdapter(cmd).Fill(table);
        }
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
                return cmd.ExecuteNonQuery() == 1;
            }
        }
        catch { return false; }
    }

    // ================= ADD =================
    public bool AddScore()
    {
        ComputeTotalAndOverview();

        return ExecuteNonQuery(@"
            INSERT INTO Score (MSSV, CourseID, MidtermScore, FinalScore, TotalScore, Overview)
            VALUES (@mssv, @courseID, @midterm, @final, @total, @overview)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@mssv",     MSSV);
                cmd.Parameters.AddWithValue("@courseID", CourseID);
                cmd.Parameters.AddWithValue("@midterm",  MidtermScore);
                cmd.Parameters.AddWithValue("@final",    FinalScore);
                cmd.Parameters.AddWithValue("@total",    TotalScore);
                cmd.Parameters.AddWithValue("@overview", Overview);
            });
    }

    // ================= DELETE =================
    public bool DeleteScore() =>
        ExecuteNonQuery(@"
            DELETE FROM Score
            WHERE MSSV = @mssv AND CourseID = @courseID",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@mssv",     MSSV);
                cmd.Parameters.AddWithValue("@courseID", CourseID);
            });

    // ================= GET ALL =================
    private const string BaseSelectQuery = @"
    SELECT
        Score.MSSV,
        Course.CourseName,
        Score.MidtermScore  AS [Process Grade],
        Score.FinalScore    AS [Final Grade],
        Score.TotalScore    AS [Total Grade]
    FROM Score
    JOIN Student ON Score.MSSV     = Student.MSSV
    JOIN Course  ON Score.CourseID = Course.CourseID";

    // ================= COURSES =================

    public DataTable GetAllCourses() =>
    ExecuteQuery(@"
    SELECT
        CourseID,
        CourseCode + ' - ' + CourseName AS CourseName
    FROM Course");

    public DataTable GetAllScore() =>
        ExecuteQuery(BaseSelectQuery);

    public DataTable GetScoreByCourse(int courseID) =>
        ExecuteQuery(BaseSelectQuery + " WHERE Score.CourseID = @courseID",
            cmd => cmd.Parameters.AddWithValue("@courseID", courseID));

    public DataTable GetScoreByStudent(string mssv) =>
    ExecuteQuery(@"
        SELECT
            Score.MSSV,
            Course.CourseName,
            Score.MidtermScore  AS [Process Grade],
            Score.FinalScore    AS [Final Grade],
            Score.TotalScore    AS [Total Grade],
            Score.Overview
        FROM Score
        JOIN Student ON Score.MSSV     = Student.MSSV
        JOIN Course  ON Score.CourseID = Course.CourseID
        WHERE Score.MSSV = @mssv",
        cmd => cmd.Parameters.AddWithValue("@mssv", mssv));

    // ================= SEARCH =================
    public DataTable SearchScore(string keyword) =>
        ExecuteQuery(@"
            SELECT
                Score.MSSV,
                Student.FirstName,
                Student.LastName,
                Course.CourseName,
                Score.TotalScore,
                Score.Overview
            FROM Score
            JOIN Student ON Score.MSSV    = Student.MSSV
            JOIN Course  ON Score.CourseID = Course.CourseID
            WHERE Score.MSSV         LIKE @kw
               OR Course.CourseName  LIKE @kw
               OR Score.Overview     LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= OVERVIEW =================
    public string GetOverview() => TotalScore switch
    {
        >= 8    => "Excellent",
        >= 6.5m => "Good",
        >= 5    => "Pass",
        _       => "Fail"
    };
    // ================= UPDATE SCORE =================
    public bool UpdateScore() =>
        ExecuteNonQuery(@"
        UPDATE Score
        SET
            MidtermScore = @midterm,
            FinalScore   = @final,
            TotalScore   = @total,
            Overview     = @overview
        WHERE MSSV = @mssv AND CourseID = @courseID",
            cmd =>
            {
                ComputeTotalAndOverview();
                cmd.Parameters.AddWithValue("@mssv", MSSV);
                cmd.Parameters.AddWithValue("@courseID", CourseID);
                cmd.Parameters.AddWithValue("@midterm", MidtermScore);
                cmd.Parameters.AddWithValue("@final", FinalScore);
                cmd.Parameters.AddWithValue("@total", TotalScore);
                cmd.Parameters.AddWithValue("@overview", Overview);
            });

    // ================= GET COURSES WITH SCORE =================
    public DataTable GetCoursesWithScore(string mssv) =>
    ExecuteQuery(@"
    SELECT
        Course.CourseID,
        Course.CourseCode + ' - ' + Course.CourseName AS CourseName
    FROM Score
    JOIN Course ON Score.CourseID = Course.CourseID
    WHERE Score.MSSV = @mssv
      AND Score.MidtermScore IS NOT NULL",
        cmd => cmd.Parameters.AddWithValue("@mssv", mssv));

    public DataTable GetScoreByFilter(string mssv, string academicYear, string semester) =>
    ExecuteQuery(@"
    SELECT Course.CourseName, Score.TotalScore
    FROM Score
    JOIN Course ON Score.CourseID = Course.CourseID
    JOIN DKMH   ON Score.MSSV     = DKMH.MSSV
                AND Score.CourseID = DKMH.CourseID
    WHERE Score.MSSV        = @mssv
      AND DKMH.AcademicYear = @academicYear
      AND Course.Semester   = @semester",
        cmd =>
        {
            cmd.Parameters.AddWithValue("@mssv", mssv);
            cmd.Parameters.AddWithValue("@academicYear", academicYear);
            cmd.Parameters.AddWithValue("@semester", Convert.ToInt32(semester));
        });

    // ================= GET COURSES WITHOUT SCORE =================
    public DataTable GetCoursesWithoutScore(string mssv) =>
    ExecuteQuery(@"
    SELECT
        Course.CourseID,
        Course.CourseCode + ' - ' + Course.CourseName AS CourseName
    FROM Score
    JOIN Course ON Score.CourseID = Course.CourseID
    WHERE Score.MSSV = @mssv
      AND Score.MidtermScore IS NULL",
        cmd => cmd.Parameters.AddWithValue("@mssv", mssv));

    // ================= ADD EMPTY SCORE =================
    public bool AddScoreEmpty(string mssv, int courseID) =>
        ExecuteNonQuery(@"
        INSERT INTO Score (MSSV, CourseID, MidtermScore, FinalScore, TotalScore, Overview)
        VALUES (@mssv, @courseID, NULL, NULL, NULL, NULL)",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@courseID", courseID);
            });
    public DataTable GetScoreByStudentAndCourse(string mssv, int courseID) =>
    ExecuteQuery(@"
    SELECT
        Score.MidtermScore AS [Process Grade],
        Score.FinalScore   AS [Final Grade]
    FROM Score
    WHERE Score.MSSV     = @mssv
      AND Score.CourseID = @courseID",
        cmd =>
        {
            cmd.Parameters.AddWithValue("@mssv", mssv);
            cmd.Parameters.AddWithValue("@courseID", courseID);
        });
    // Trả về CourseID dựa theo MSSV và CourseName (để focus combobox đúng môn)
    public int? GetCourseIDByStudentAndName(string mssv, string courseName)
    {
        var table = ExecuteQuery(@"
        SELECT Course.CourseID
        FROM Score
        JOIN Course ON Score.CourseID = Course.CourseID
        WHERE Score.MSSV = @mssv
          AND Course.CourseName = @courseName",
            cmd =>
            {
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@courseName", courseName);
            });

        if (table.Rows.Count > 0)
            return Convert.ToInt32(table.Rows[0]["CourseID"]);

        return null;
    }
}