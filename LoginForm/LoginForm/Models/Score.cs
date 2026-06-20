using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;

public class Score
{
    // ================= PROPERTIES =================
    // Theo schema PK: (ID, ClassID)
    // TotalScore   — COMPUTED COLUMN trong SQL Server → KHÔNG ghi từ C#.
    // LetterGrade  — do trigger TR_Score_Update tính   → KHÔNG ghi từ C#.
    // Overview     — do trigger TR_Score_Update tính   → KHÔNG ghi từ C#.
    // Overview values (CHK_Score_Overview): 'Excellent' | 'Good' | 'Pass' | 'Fail'
    // LetterGrade values (CHK_Score_LetterGrade): 'A'|'B+'|'B'|'C+'|'C'|'D'|'F'
    public string ID { get; set; }
    public string ClassID { get; set; }
    public decimal? MidtermScore { get; set; }
    public decimal? FinalScore { get; set; }
    // Read-only từ DB (computed / trigger) — KHÔNG dùng để INSERT/UPDATE
    public decimal? TotalScore { get; set; }
    public string LetterGrade { get; set; }
    public string Overview { get; set; }

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
        catch { return false; }
    }

    // PK params dùng chung cho WHERE clause
    private void AddPKParams(SqlCommand cmd)
    {
        cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = ID;
        cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = ClassID;
    }

    // ================= UPDATE SCORE =================
    // Chỉ ghi MidtermScore và FinalScore.
    // TotalScore   → SQL Server tự tính (computed column).
    // LetterGrade  → trigger TR_Score_Update tự cập nhật.
    // Overview     → trigger TR_Score_Update tự cập nhật.
    public bool UpdateScore() =>
        ExecuteNonQuery(@"
            UPDATE Score SET
                MidtermScore = @midterm,
                FinalScore   = @final
            WHERE ID = @id AND ClassID = @classID",
            cmd =>
            {
                AddPKParams(cmd);
                cmd.Parameters.Add("@midterm", SqlDbType.Decimal).Value =
                    MidtermScore.HasValue ? (object)MidtermScore.Value : DBNull.Value;
                cmd.Parameters.Add("@final", SqlDbType.Decimal).Value =
                    FinalScore.HasValue ? (object)FinalScore.Value : DBNull.Value;
            });

    // ================= RESET SCORE =================
    public bool ResetScore() =>
        ExecuteNonQuery(@"
            UPDATE Score SET
                MidtermScore = 0,
                FinalScore   = 0
            WHERE ID = @id AND ClassID = @classID",
            AddPKParams);

    // ================= DELETE =================
    // Thường không cần gọi trực tiếp vì trigger TR_DKMH_Delete
    // tự xóa Score khi xóa DKMH.
    public bool DeleteScore() =>
        ExecuteNonQuery(@"
            DELETE FROM Score
            WHERE ID = @id AND ClassID = @classID",
            AddPKParams);

    // ================= GET ALL =================
    // Bao gồm LetterGrade trong SELECT (thêm mới so với version cũ)
    private const string BaseSelectQuery = @"
        SELECT
            s.ID,
            st.FirstName + ' ' + st.LastName AS StudentName,
            s.ClassID,
            co.CourseID,
            co.CourseName,
            cl.Semester,
            cl.AcademicYear,
            s.MidtermScore  AS [Process Grade],
            s.FinalScore    AS [Final Grade],
            s.TotalScore    AS [Total Grade],
            s.LetterGrade,
            s.Overview      AS [Grade]
        FROM Score s
        JOIN DKMH    d  ON d.ID = s.ID AND d.ClassID = s.ClassID
        JOIN Student st ON st.ID       = s.ID
        JOIN Class   cl ON cl.ClassID  = s.ClassID
        JOIN Course  co ON co.CourseID = cl.CourseID";

    public DataTable GetAllScore() =>
        ExecuteQuery(BaseSelectQuery + " ORDER BY s.ID");

    // ================= GET BY STUDENT =================
    public DataTable GetScoreByStudent(string id) =>
        ExecuteQuery(BaseSelectQuery + @"
            WHERE s.ID = @id
            ORDER BY cl.AcademicYear, cl.Semester",
            cmd => cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id);

    // ================= GET BY CLASS =================
    public DataTable GetScoreByClass(string classID) =>
        ExecuteQuery(BaseSelectQuery + @"
            WHERE s.ClassID = @classID
            ORDER BY s.ID",
            cmd => cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID);

    // ================= GET BY STUDENT + SEMESTER FILTER =================
    // Semester values: 'Semester 1' | 'Semester 2' | 'Summer'
    public DataTable GetScoreByFilter(string id, string academicYear, string semester) =>
        ExecuteQuery(@"
            SELECT
                co.CourseName,
                s.MidtermScore  AS [Process Grade],
                s.FinalScore    AS [Final Grade],
                s.TotalScore,
                s.LetterGrade,
                s.Overview
            FROM Score s
            JOIN Class   cl ON s.ClassID   = cl.ClassID
            JOIN Course  co ON cl.CourseID = co.CourseID
            WHERE s.ID            = @id
              AND cl.AcademicYear = @academicYear
              AND cl.Semester     = @semester",
            cmd =>
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                cmd.Parameters.Add("@academicYear", SqlDbType.VarChar, 20).Value = academicYear;
                cmd.Parameters.Add("@semester", SqlDbType.NVarChar, 20).Value = semester;
            });

    // ================= GET BY STUDENT + CLASS =================
    public DataTable GetScoreByStudentAndClass(string id, string classID) =>
        ExecuteQuery(@"
            SELECT
                s.MidtermScore  AS [Process Grade],
                s.FinalScore    AS [Final Grade],
                s.TotalScore    AS [Total Grade],
                s.LetterGrade,
                s.Overview
            FROM Score s
            WHERE s.ID = @id AND s.ClassID = @classID",
            cmd =>
            {
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
            });

    // ================= SEARCH =================
    public DataTable SearchScore(string keyword) =>
        ExecuteQuery(@"
            SELECT
                s.ID,
                st.FirstName,
                st.LastName,
                co.CourseName,
                cl.ClassID,
                s.TotalScore,
                s.LetterGrade,
                s.Overview
            FROM Score s
            JOIN DKMH    d  ON d.ID = s.ID AND d.ClassID = s.ClassID
            JOIN Student st ON st.ID       = s.ID
            JOIN Class   cl ON cl.ClassID  = s.ClassID
            JOIN Course  co ON co.CourseID = cl.CourseID
            WHERE s.ID          LIKE @kw
               OR co.CourseName LIKE @kw
               OR cl.ClassID    LIKE @kw
               OR s.LetterGrade LIKE @kw
               OR s.Overview    LIKE @kw",
            cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%"));

    // ================= TRANSCRIPT (via stored procedure) =================
    public DataTable GetTranscript(string id)
    {
        var table = new DataTable();
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand("sp_Score_GetTranscript", db.getConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@StudentID", SqlDbType.VarChar, 20).Value = id;
                new SqlDataAdapter(cmd).Fill(table);
            }
        }
        catch { }
        return table;
    }

    // ================= GPA =================
    public decimal GetGPA(string id)
    {
        try
        {
            using (var db = new My_DB())
            {
                db.openConnection();
                var cmd = new SqlCommand(
                    "SELECT dbo.fn_GetGPA(@id)", db.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = id;
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
        catch { return 0; }
    }

    // ================= FOR COMBOBOX =================
    public DataTable GetAllClasses() =>
        ExecuteQuery(@"
            SELECT cl.ClassID,
                   cl.ClassID + ' - ' + co.CourseName AS ClassDisplay
            FROM Class cl
            JOIN Course co ON cl.CourseID = co.CourseID
            ORDER BY cl.ClassID");
}