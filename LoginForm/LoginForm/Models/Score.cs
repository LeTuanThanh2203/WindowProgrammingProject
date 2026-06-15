using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;

public class Score
{
    // ================= PROPERTIES =================
    // Theo schema PK: (MSSV, ClassID, Semester, AcademicYear)
    // KHÔNG còn: CourseID (thay bằng ClassID + Semester)
    public string MSSV { get; set; }
    public string ClassID { get; set; }
    public int Semester { get; set; }
    public string AcademicYear { get; set; }
    public decimal MidtermScore { get; set; }
    public decimal FinalScore { get; set; }
    public decimal TotalScore { get; set; }
    public string Overview { get; set; }

    // ================= HELPERS =================
    private void ComputeTotalAndOverview()
    {
        TotalScore = Math.Round((MidtermScore + FinalScore) / 2, 2);
        Overview = GetOverview();
    }

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
                return cmd.ExecuteNonQuery() == 1;
            }
        }
        catch { return false; }
    }

    // PK params dùng chung cho WHERE clause
    private void AddPKParams(SqlCommand cmd)
    {
        cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = MSSV;
        cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = ClassID; // sửa Char(10) → VarChar(20)
        cmd.Parameters.Add("@semester", SqlDbType.Int).Value = Semester;
        cmd.Parameters.Add("@academicYear", SqlDbType.NVarChar, 20).Value = AcademicYear;
    }

    // ================= ADD =================
    public bool AddScore()
    {
        ComputeTotalAndOverview();
        return ExecuteNonQuery(@"
            INSERT INTO Score
                (MSSV, ClassID, Semester, AcademicYear,
                 MidtermScore, FinalScore, TotalScore, Overview)
            VALUES
                (@mssv, @classID, @semester, @academicYear,
                 @midterm, @final, @total, @overview)",
            cmd =>
            {
                AddPKParams(cmd);
                cmd.Parameters.Add("@midterm", SqlDbType.Decimal).Value = MidtermScore;
                cmd.Parameters.Add("@final", SqlDbType.Decimal).Value = FinalScore;
                cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = TotalScore;
                cmd.Parameters.Add("@overview", SqlDbType.NVarChar, 200).Value = (object)Overview ?? DBNull.Value;
            });
    }

    // ================= ADD EMPTY =================
    public bool AddScoreEmpty(string mssv, string classID, int semester, string academicYear) =>
     ExecuteNonQuery(@"
        INSERT INTO Score
            (MSSV, ClassID, Semester, AcademicYear,
             MidtermScore, FinalScore, TotalScore, Overview)
        VALUES
            (@mssv, @classID, @semester, @academicYear,
             NULL, NULL, NULL, NULL)",
         cmd =>
         {
             cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = mssv;
             cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID; // sửa
             cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
             cmd.Parameters.Add("@academicYear", SqlDbType.NVarChar, 20).Value = academicYear;
         });

    // ================= DELETE =================
    public bool DeleteScore() =>
        ExecuteNonQuery(@"
            DELETE FROM Score
            WHERE MSSV = @mssv AND ClassID = @classID
              AND Semester = @semester AND AcademicYear = @academicYear",
            AddPKParams);
    public bool ResetScore() =>
    ExecuteNonQuery(@"
        UPDATE Score SET
            MidtermScore = NULL,
            FinalScore   = NULL,
            TotalScore   = NULL,
            Overview     = NULL
        WHERE MSSV         = @mssv
          AND ClassID      = @classID
          AND Semester     = @semester
          AND AcademicYear = @academicYear",
        AddPKParams);
    // ================= UPDATE =================
    public bool UpdateScore()
    {
        ComputeTotalAndOverview();
        return ExecuteNonQuery(@"
            UPDATE Score SET
                MidtermScore = @midterm,
                FinalScore   = @final,
                TotalScore   = @total,
                Overview     = @overview
            WHERE MSSV = @mssv AND ClassID = @classID
              AND Semester = @semester AND AcademicYear = @academicYear",
            cmd =>
            {
                AddPKParams(cmd);
                cmd.Parameters.Add("@midterm", SqlDbType.Decimal).Value = MidtermScore;
                cmd.Parameters.Add("@final", SqlDbType.Decimal).Value = FinalScore;
                cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = TotalScore;
                cmd.Parameters.Add("@overview", SqlDbType.NVarChar, 200).Value = (object)Overview ?? DBNull.Value;
            });
    }

    // ================= GET ALL =================
    // Join Class → Course để lấy CourseName
    private const string BaseSelectQuery = @"
    SELECT
        sc.MSSV,
        sc.ClassID,
        cl.CourseCode,
        sc.Semester,
        sc.AcademicYear,
        sc.MidtermScore AS [Process Grade],
        sc.FinalScore   AS [Final Grade],
        sc.TotalScore   AS [Total Grade],
        sc.Overview     AS [Grade]
    FROM Score sc
    JOIN Class cl ON sc.ClassID = cl.ClassID";

    public DataTable GetAllScore() =>
        ExecuteQuery(BaseSelectQuery + " ORDER BY sc.MSSV");

    // ================= GET BY STUDENT =================
    public DataTable GetScoreByStudent(string mssv) =>
        ExecuteQuery(BaseSelectQuery + @"
            WHERE sc.MSSV = @mssv
            ORDER BY sc.AcademicYear, sc.Semester",
            cmd => cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = mssv);

    // ================= GET BY CLASS =================
    public DataTable GetScoreByClass(string classID) =>
    ExecuteQuery(BaseSelectQuery + @"
        WHERE sc.ClassID = @classID
        ORDER BY sc.MSSV",
        cmd => cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID);

    // ================= GET BY FILTER (student + năm + học kỳ) =================
    // Giống GetScoreByFilter cũ nhưng dùng đúng schema mới
    public DataTable GetScoreByFilter(string mssv, string academicYear, int semester) =>
    ExecuteQuery(@"
        SELECT
            c.CourseName,
            sc.MidtermScore AS [Process Grade],
            sc.FinalScore   AS [Final Grade],
            sc.TotalScore   AS [TotalScore],
            sc.Overview
        FROM Score sc
        JOIN Class   cl ON sc.ClassID    = cl.ClassID
        JOIN Course  c  ON cl.CourseCode = c.CourseCode
        WHERE sc.MSSV         = @mssv
          AND sc.AcademicYear = @academicYear
          AND sc.Semester     = @semester",
        cmd =>
        {
            cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = mssv;
            cmd.Parameters.Add("@academicYear", SqlDbType.NVarChar, 20).Value = academicYear;
            cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
        });

    // ================= GET BY STUDENT + CLASS =================
    public DataTable GetScoreByStudentAndClass(string mssv, string classID, int semester, string academicYear) =>
        ExecuteQuery(@"
            SELECT
                sc.MidtermScore AS [Process Grade],
                sc.FinalScore   AS [Final Grade]
            FROM Score sc
            WHERE sc.MSSV        = @mssv
              AND sc.ClassID     = @classID
              AND sc.Semester    = @semester
              AND sc.AcademicYear = @academicYear",
            cmd =>
            {
                cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = mssv;
                cmd.Parameters.Add("@classID", SqlDbType.Char, 10).Value = classID;
                cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
                cmd.Parameters.Add("@academicYear", SqlDbType.NVarChar, 20).Value = academicYear;
            });

    // ================= SEARCH =================
    public DataTable SearchScore(string keyword) =>
        ExecuteQuery(@"
            SELECT
                sc.MSSV,
                sv.FirstName,
                sv.LastName,
                c.CourseName,
                cl.ClassName,
                sc.TotalScore,
                sc.Overview
            FROM Score sc
            JOIN Student sv ON sc.MSSV       = sv.MSSV
            JOIN Class   cl ON sc.ClassID    = cl.ClassID
            JOIN Course  c  ON cl.CourseCode = c.CourseCode
            WHERE sc.MSSV        LIKE @kw
               OR c.CourseName   LIKE @kw
               OR cl.ClassName   LIKE @kw
               OR sc.Overview    LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= GET CLASSES FOR COMBOBOX =================
    public DataTable GetAllClasses() =>
        ExecuteQuery(@"
            SELECT ClassID,
                   ClassID + ' - ' + ClassName AS ClassDisplay
            FROM Class
            ORDER BY ClassID");

    // ================= OVERVIEW =================
    public string GetOverview() => TotalScore switch
    {
        >= 9 => "A+",
        >= 8 => "A",
        >= 7 => "B+",
        >= 6.5m => "B",
        >= 5.5m => "C+",
        >= 5 => "C",
        >= 4 => "D+",
        >= 3.5m => "D",
        _ => "F"
    };
}