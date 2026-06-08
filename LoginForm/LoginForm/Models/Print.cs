using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Controls;
using Xceed.Document.NET;
using Xceed.Words.NET;// Tải Xceed.Words.NET


namespace Project_Group6.UI
{
    internal class Print
    {
        // lưu đường dẫn file
        private string savePath = "";

        // Chọn nơi lưu
        public bool SavePlace()
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Word Document|*.docx";
            save.Title = "Save Word File";

            if (save.ShowDialog() == DialogResult.OK)
            {
                savePath = save.FileName;
                return true;
            }

            return false;
        }

        // Xuất DataTable ra Word
        public void ChangeToWord(DataTable dt, string title)
        {
            if (string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Chưa chọn nơi lưu!");
                return;
            }

            var doc = DocX.Create(savePath);

            doc.InsertParagraph(title)
               .FontSize(18)
               .Bold()
               .Alignment = Alignment.center;

            doc.InsertParagraph();

            var table = doc.AddTable(dt.Rows.Count + 1, dt.Columns.Count);

            table.Design = TableDesign.TableGrid;

            // Header
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                table.Rows[0].Cells[i].Paragraphs[0]
                    .Append(dt.Columns[i].ColumnName)
                    .Bold();
            }

            // Data
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    table.Rows[r + 1].Cells[c]
                        .Paragraphs[0]
                        .Append(dt.Rows[r][c].ToString());
                }
            }

            doc.InsertTable(table);
            doc.Save();

            MessageBox.Show("Xuất Word thành công!");
        }
        public void ExportScoreStudent(
        string studentID,
        string semester,
        string schoolYear)
        {
            string query =
            @"SELECT SubjectID,
             Score
      FROM Score
      WHERE StudentID=@id
      AND Semester=@semester
      AND SchoolYear=@year";
            My_DB db = new My_DB();

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@id", studentID);
            cmd.Parameters.AddWithValue("@semester", semester);
            cmd.Parameters.AddWithValue("@year", schoolYear);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            SavePlace();

            ChangeToWord(dt,
                "BẢNG ĐIỂM SINH VIÊN");
        }
        public void ExportScoreClass(
    string classID,
    string semester)
        {
            string query =
            @"SELECT sv.StudentID,
             sv.FullName,
             sc.Score
      FROM Student sv
      INNER JOIN Score sc
      ON sv.StudentID=sc.StudentID
      WHERE sv.ClassID=@classID
      AND sc.Semester=@semester";
            My_DB db = new My_DB();

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@classID", classID);
            cmd.Parameters.AddWithValue("@semester", semester);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            SavePlace();

            ChangeToWord(dt,
                "BẢNG ĐIỂM LỚP");
        }
        public void ExportConfirmationRequest(int requestID)
        {
            string query =
            @"SELECT *
      FROM ConfirmationRequest
      WHERE RequestID=@id";
            My_DB db = new My_DB();

            SqlCommand cmd = new SqlCommand(query, db.getConnection);

            cmd.Parameters.AddWithValue("@id", requestID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            SavePlace();

            ChangeToWord(dt,
                "GIẤY XÁC NHẬN");
        }
    }
}
