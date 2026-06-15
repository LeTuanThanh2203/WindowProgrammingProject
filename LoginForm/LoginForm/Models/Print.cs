using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Project_Group6.UI
{
    internal class Print
    {
        // ================= PROPERTIES =================
        private string SavePath { get; set; } = "";

        // Dùng My_DB() giống Course, Score, Student, Class
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

        private bool PickSavePath()
        {
            var dialog = new SaveFileDialog
            {
                Filter = "Word Document|*.docx",
                Title = "Save Word File"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SavePath = dialog.FileName;
                return true;
            }

            return false;
        }

        private bool ExportToWord(DataTable dt, string title)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return false;
            }

            if (string.IsNullOrEmpty(SavePath))
            {
                MessageBox.Show("Chưa chọn nơi lưu!");
                return false;
            }

            try
            {
                var doc = DocX.Create(SavePath);

                doc.InsertParagraph(title)
                   .FontSize(18)
                   .Bold()
                   .Alignment = Alignment.center;

                doc.InsertParagraph();

                var table = doc.AddTable(dt.Rows.Count + 1, dt.Columns.Count);
                table.Design = TableDesign.TableGrid;

                // Header row
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    table.Rows[0].Cells[col]
                         .Paragraphs[0]
                         .Append(dt.Columns[col].ColumnName)
                         .Bold();
                }

                // Data rows
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        table.Rows[row + 1].Cells[col]
                             .Paragraphs[0]
                             .Append(dt.Rows[row][col]?.ToString() ?? "");
                    }
                }

                doc.InsertTable(table);
                doc.Save();

                MessageBox.Show("Xuất Word thành công!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Word: " + ex.Message);
                return false;
            }
        }

        // ================= EXPORT STUDENT SCORE =================
        // Score schema: (MSSV, ClassID, Semester, AcademicYear, ...)
        // Join Class → Course để lấy CourseName
        public bool ExportScoreStudent(string mssv, string academicYear, int semester)
        {
            var dt = ExecuteQuery(@"
                SELECT
                    c.CourseCode        AS [Mã Môn],
                    c.CourseName        AS [Tên Môn],
                    sc.MidtermScore     AS [Điểm Quá Trình],
                    sc.FinalScore       AS [Điểm Cuối Kỳ],
                    sc.TotalScore       AS [Điểm Tổng],
                    sc.Overview         AS [Xếp Loại]
                FROM Score sc
                JOIN Class   cl ON sc.ClassID    = cl.ClassID
                JOIN Course  c  ON cl.CourseCode = c.CourseCode
                WHERE sc.MSSV        = @mssv
                  AND sc.AcademicYear = @academicYear
                  AND sc.Semester     = @semester",
                cmd =>
                {
                    cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = mssv;
                    cmd.Parameters.Add("@academicYear", SqlDbType.NVarChar, 20).Value = academicYear;
                    cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
                });

            return PickSavePath() && ExportToWord(dt, "BẢNG ĐIỂM SINH VIÊN");
        }

        // ================= EXPORT CLASS SCORE =================
        // Xuất toàn bộ điểm của 1 lớp (ClassID) trong 1 học kỳ + năm học
        // Score PK: (MSSV, ClassID, Semester, AcademicYear)
        public bool ExportScoreClass(string classID, int semester, string academicYear)
        {
            var dt = ExecuteQuery(@"
                SELECT
                    sv.MSSV,
                    sv.FirstName        AS [Họ],
                    sv.LastName         AS [Tên],
                    sc.MidtermScore     AS [Điểm Quá Trình],
                    sc.FinalScore       AS [Điểm Cuối Kỳ],
                    sc.TotalScore       AS [Điểm Tổng],
                    sc.Overview         AS [Xếp Loại]
                FROM Score sc
                JOIN Student sv ON sc.MSSV     = sv.MSSV
                WHERE sc.ClassID     = @classID
                  AND sc.Semester    = @semester
                  AND sc.AcademicYear = @academicYear
                ORDER BY sv.LastName, sv.FirstName",
                cmd =>
                {
                    cmd.Parameters.Add("@classID", SqlDbType.Char, 10).Value = classID;
                    cmd.Parameters.Add("@semester", SqlDbType.Int).Value = semester;
                    cmd.Parameters.Add("@academicYear", SqlDbType.NVarChar, 20).Value = academicYear;
                });

            return PickSavePath() && ExportToWord(dt, "BẢNG ĐIỂM LỚP");
        }

        // ================= EXPORT REGISTERED COURSES =================
        // DKMH schema: (MSSV, CourseCode, Semester, AcademicYear)
        public bool ExportRegisteredCourses(string mssv, string academicYear)
        {
            var dt = ExecuteQuery(@"
                SELECT
                    d.CourseCode        AS [Mã Môn],
                    c.CourseName        AS [Tên Môn],
                    d.Semester          AS [Học Kỳ],
                    c.CreditHour        AS [Số Tín Chỉ],
                    c.Week              AS [Số Tuần],
                    pre.CourseName      AS [Môn Tiên Quyết]
                FROM DKMH d
                JOIN Course c   ON d.CourseCode             = c.CourseCode
                LEFT JOIN Course pre ON c.PrerequisiteCourseCode = pre.CourseCode
                WHERE d.MSSV         = @mssv
                  AND d.AcademicYear = @academicYear
                ORDER BY d.Semester, c.CourseCode",
                cmd =>
                {
                    cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = mssv;
                    cmd.Parameters.Add("@academicYear", SqlDbType.NVarChar, 20).Value = academicYear;
                });

            return PickSavePath() && ExportToWord(dt, "DANH SÁCH MÔN HỌC ĐĂNG KÝ");
        }

        // ================= EXPORT CONFIRMATION REQUEST =================
        // Bảng ConfirmationRequest dùng SqlConnection riêng (ConfigurationManager)
        // giống ConfirmationRequest.cs
        public bool ExportConfirmationRequest(string mssv)
        {
            var table = new DataTable();
            try
            {
                using (var conn = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"
                        SELECT
                            ConfirmationName    AS [Loại Giấy],
                            QueueNumber         AS [Số Thứ Tự],
                            Quantity            AS [Số Lượng],
                            CASE Status
                                WHEN 1 THEN N'Done'
                                ELSE        N'Pending'
                            END                 AS [Trạng Thái]
                        FROM ConfirmationRequest
                        WHERE MSSV = @mssv
                        ORDER BY RequestID DESC",
                        conn);
                    cmd.Parameters.Add("@mssv", SqlDbType.VarChar, 20).Value = mssv;
                    new SqlDataAdapter(cmd).Fill(table);
                }
            }
            catch { }

            return PickSavePath() && ExportToWord(table, "GIẤY XÁC NHẬN");
        }
    }
}