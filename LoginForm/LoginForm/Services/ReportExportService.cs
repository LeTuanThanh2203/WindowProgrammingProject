using System;
using System.Data;
using System.IO;
using OfficeOpenXml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Geom;
using iText.Kernel.Colors;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace LoginForm
{
    public class ReportExportService
    {
        // Helper to load Vietnamese Font
        private PdfFont GetVietnameseFont()
        {
            string fontPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Fonts", "arial.ttf");
            if (File.Exists(fontPath))
            {
                return PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.FORCE_EMBEDDED);
            }
            // Fallback to standard font if file is not found (though Windows always has arial.ttf)
            return PdfFontFactory.CreateFont(StandardFonts.HELVETICA, PdfEncodings.WINANSI);
        }

        // ==========================================
        // PDF EXPORT
        // ==========================================

        /// <summary>
        /// Exports the Student DataTable to a PDF file.
        /// </summary>
        public bool ExportStudentsToPdf(DataTable dt, string filePath, string authorName)
        {
            try
            {
                using (var writer = new PdfWriter(filePath))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        var document = new Document(pdf, PageSize.A4);
                        document.SetMargins(36, 36, 36, 36);

                        // Set Vietnamese Font
                        PdfFont font = GetVietnameseFont();
                        document.SetFont(font);

                        // Header Title
                        Paragraph title = new Paragraph("DANH SÁCH SINH VIÊN")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(18)
                            .SetBold()
                            .SetFontColor(new DeviceRgb(37, 99, 235)); // Primary color #2563EB
                        document.Add(title);

                        // Info metadata
                        Paragraph meta = new Paragraph()
                            .SetFontSize(10)
                            .SetFontColor(ColorConstants.DARK_GRAY)
                            .Add($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n")
                            .Add($"Người xuất: {authorName}\n")
                            .Add($"Tổng số dòng: {dt.Rows.Count}\n\n");
                        document.Add(meta);

                        // Build Table
                        Table table = BuildPdfTable(dt, font);
                        document.Add(table);

                        // Footer
                        Paragraph footer = new Paragraph("\nStudent Management System")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(9)
                            .SetItalic()
                            .SetFontColor(ColorConstants.GRAY);
                        document.Add(footer);

                        document.Close();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Helper to map and construct PDF table columns precisely:
        /// | MSSV | FirstName | LastName | Gender | Email |
        /// </summary>
        public Table BuildPdfTable(DataTable dt, PdfFont font)
        {
            // Column count: 5
            Table table = new Table(5);
            table.SetWidth(UnitValue.CreatePercentValue(100));

            string[] headers = { "MSSV", "First Name", "Last Name", "Gender", "Email" };
            DeviceRgb headerBg = new DeviceRgb(37, 99, 235); // #2563EB

            foreach (var h in headers)
            {
                Cell cell = new Cell()
                    .Add(new Paragraph(h).SetFont(font).SetBold().SetFontColor(ColorConstants.WHITE))
                    .SetBackgroundColor(headerBg)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetPadding(6);
                table.AddHeaderCell(cell);
            }

            foreach (DataRow row in dt.Rows)
            {
                // Ensure correct columns mapping. If we use alias in SQL query, or properties
                string mssv = row.Table.Columns.Contains("MSSV") ? row["MSSV"]?.ToString() : row["ID"]?.ToString();
                string firstName = row.Table.Columns.Contains("FirstName") ? row["FirstName"]?.ToString() : "";
                string lastName = row.Table.Columns.Contains("LastName") ? row["LastName"]?.ToString() : "";
                string gender = row.Table.Columns.Contains("Gender") ? row["Gender"]?.ToString() : "";
                string email = row.Table.Columns.Contains("Email") ? row["Email"]?.ToString() : "";

                table.AddCell(new Cell().Add(new Paragraph(mssv ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(firstName ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(lastName ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(gender ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(email ?? "").SetFont(font)).SetPadding(4));
            }

            return table;
        }

        /// <summary>
        /// Exports the Score DataTable to a PDF file.
        /// </summary>
        public bool ExportScoresToPdf(DataTable dt, string filePath, string authorName)
        {
            try
            {
                using (var writer = new PdfWriter(filePath))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        var document = new Document(pdf, PageSize.A4);
                        document.SetMargins(36, 36, 36, 36);

                        // Set Vietnamese Font
                        PdfFont font = GetVietnameseFont();
                        document.SetFont(font);

                        // Header Title
                        Paragraph title = new Paragraph("BẢNG ĐIỂM SINH VIÊN")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(18)
                            .SetBold()
                            .SetFontColor(new DeviceRgb(37, 99, 235)); // Primary color #2563EB
                        document.Add(title);

                        // Info metadata
                        Paragraph meta = new Paragraph()
                            .SetFontSize(10)
                            .SetFontColor(ColorConstants.DARK_GRAY)
                            .Add($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n")
                            .Add($"Người xuất: {authorName}\n")
                            .Add($"Tổng số dòng: {dt.Rows.Count}\n\n");
                        document.Add(meta);

                        // Build Table
                        Table table = BuildScoresPdfTable(dt, font);
                        document.Add(table);

                        // Footer
                        Paragraph footer = new Paragraph("\nStudent Management System")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(9)
                            .SetItalic()
                            .SetFontColor(ColorConstants.GRAY);
                        document.Add(footer);

                        document.Close();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Helper to map and construct PDF table columns precisely for Scores:
        /// | MSSV | Full Name | Course | Score | Semester |
        /// </summary>
        public Table BuildScoresPdfTable(DataTable dt, PdfFont font)
        {
            // Column count: 5
            Table table = new Table(5);
            table.SetWidth(UnitValue.CreatePercentValue(100));

            string[] headers = { "MSSV", "Full Name", "Course", "Score", "Semester" };
            DeviceRgb headerBg = new DeviceRgb(37, 99, 235); // #2563EB

            foreach (var h in headers)
            {
                Cell cell = new Cell()
                    .Add(new Paragraph(h).SetFont(font).SetBold().SetFontColor(ColorConstants.WHITE))
                    .SetBackgroundColor(headerBg)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetPadding(6);
                table.AddHeaderCell(cell);
            }

            foreach (DataRow row in dt.Rows)
            {
                string mssv = row.Table.Columns.Contains("MSSV") ? row["MSSV"]?.ToString() : row["ID"]?.ToString();
                string fullName = row.Table.Columns.Contains("FullName") ? row["FullName"]?.ToString() : (row.Table.Columns.Contains("StudentName") ? row["StudentName"]?.ToString() : "");
                string course = row.Table.Columns.Contains("Course") ? row["Course"]?.ToString() : (row.Table.Columns.Contains("CourseName") ? row["CourseName"]?.ToString() : "");
                string score = row.Table.Columns.Contains("Score") ? row["Score"]?.ToString() : (row.Table.Columns.Contains("Total Grade") ? row["Total Grade"]?.ToString() : (row.Table.Columns.Contains("TotalScore") ? row["TotalScore"]?.ToString() : ""));
                string semester = row.Table.Columns.Contains("Semester") ? row["Semester"]?.ToString() : "";

                table.AddCell(new Cell().Add(new Paragraph(mssv ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(fullName ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(course ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(score ?? "").SetFont(font)).SetPadding(4));
                table.AddCell(new Cell().Add(new Paragraph(semester ?? "").SetFont(font)).SetPadding(4));
            }

            return table;
        }


        // ==========================================
        // EXCEL EXPORT
        // ==========================================

        /// <summary>
        /// Exports the Student DataTable to an Excel file.
        /// </summary>
        public bool ExportStudentsToExcel(DataTable dt, string filePath)
        {
            try
            {
                ExcelPackage.License.SetNonCommercialPersonal("Student Management Project");
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Danh sách sinh viên");

                    // Build Header
                    BuildExcelHeader(worksheet);

                    // Write Data
                    int rowIdx = 2;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mssv = row.Table.Columns.Contains("MSSV") ? row["MSSV"]?.ToString() : row["ID"]?.ToString();
                        string firstName = row.Table.Columns.Contains("FirstName") ? row["FirstName"]?.ToString() : "";
                        string lastName = row.Table.Columns.Contains("LastName") ? row["LastName"]?.ToString() : "";
                        object dobVal = row.Table.Columns.Contains("Dob") ? row["Dob"] : (row.Table.Columns.Contains("DOB") ? row["DOB"] : DBNull.Value);
                        string gender = row.Table.Columns.Contains("Gender") ? row["Gender"]?.ToString() : "";
                        string phone = row.Table.Columns.Contains("Phone") ? row["Phone"]?.ToString() : "";
                        string email = row.Table.Columns.Contains("Email") ? row["Email"]?.ToString() : "";

                        worksheet.Cells[rowIdx, 1].Value = mssv;
                        worksheet.Cells[rowIdx, 2].Value = firstName;
                        worksheet.Cells[rowIdx, 3].Value = lastName;

                        if (dobVal != DBNull.Value && dobVal != null)
                        {
                            var dobValue = Convert.ToDateTime(dobVal);
                            worksheet.Cells[rowIdx, 4].Value = dobValue;
                            worksheet.Cells[rowIdx, 4].Style.Numberformat.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            worksheet.Cells[rowIdx, 4].Value = "";
                        }

                        worksheet.Cells[rowIdx, 5].Value = gender;
                        worksheet.Cells[rowIdx, 6].Value = phone;
                        worksheet.Cells[rowIdx, 7].Value = email;

                        rowIdx++;
                    }

                    // Freeze Pane (2nd row, 1st column => rows above row 2 are frozen)
                    worksheet.View.FreezePanes(2, 1);

                    // Auto Fit Columns
                    worksheet.Cells.AutoFitColumns();

                    // Save file
                    FileInfo fi = new FileInfo(filePath);
                    package.SaveAs(fi);
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Helper to construct Excel headers:
        /// | MSSV | FirstName | LastName | DOB | Gender | Phone | Email |
        /// </summary>
        public void BuildExcelHeader(ExcelWorksheet worksheet)
        {
            string[] headers = { "MSSV", "FirstName", "LastName", "DOB", "Gender", "Phone", "Email" };
            for (int col = 1; col <= headers.Length; col++)
            {
                var cell = worksheet.Cells[1, col];
                cell.Value = headers[col - 1];
                cell.Style.Font.Bold = true;
                cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#2563EB")); // Primary color
                cell.Style.Font.Color.SetColor(System.Drawing.Color.White);
                
                cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            }
        }

        /// <summary>
        /// Exports the Score DataTable to an Excel file.
        /// </summary>
        public bool ExportScoresToExcel(DataTable dt, string filePath)
        {
            try
            {
                ExcelPackage.License.SetNonCommercialPersonal("Student Management Project");
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Bảng điểm sinh viên");

                    // Build Header
                    BuildScoresExcelHeader(worksheet);

                    // Write Data
                    int rowIdx = 2;
                    foreach (DataRow row in dt.Rows)
                    {
                        string mssv = row.Table.Columns.Contains("MSSV") ? row["MSSV"]?.ToString() : row["ID"]?.ToString();
                        string fullName = row.Table.Columns.Contains("FullName") ? row["FullName"]?.ToString() : (row.Table.Columns.Contains("StudentName") ? row["StudentName"]?.ToString() : "");
                        string course = row.Table.Columns.Contains("Course") ? row["Course"]?.ToString() : (row.Table.Columns.Contains("CourseName") ? row["CourseName"]?.ToString() : "");
                        string score = row.Table.Columns.Contains("Score") ? row["Score"]?.ToString() : (row.Table.Columns.Contains("Total Grade") ? row["Total Grade"]?.ToString() : (row.Table.Columns.Contains("TotalScore") ? row["TotalScore"]?.ToString() : ""));
                        string semester = row.Table.Columns.Contains("Semester") ? row["Semester"]?.ToString() : "";

                        worksheet.Cells[rowIdx, 1].Value = mssv;
                        worksheet.Cells[rowIdx, 2].Value = fullName;
                        worksheet.Cells[rowIdx, 3].Value = course;
                        worksheet.Cells[rowIdx, 4].Value = score;
                        worksheet.Cells[rowIdx, 5].Value = semester;

                        rowIdx++;
                    }

                    // Freeze Pane
                    worksheet.View.FreezePanes(2, 1);

                    // Auto Fit Columns
                    worksheet.Cells.AutoFitColumns();

                    // Save file
                    FileInfo fi = new FileInfo(filePath);
                    package.SaveAs(fi);
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Helper to construct Excel headers for Scores:
        /// | MSSV | FullName | Course | Score | Semester |
        /// </summary>
        public void BuildScoresExcelHeader(ExcelWorksheet worksheet)
        {
            string[] headers = { "MSSV", "FullName", "Course", "Score", "Semester" };
            for (int col = 1; col <= headers.Length; col++)
            {
                var cell = worksheet.Cells[1, col];
                cell.Value = headers[col - 1];
                cell.Style.Font.Bold = true;
                cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                cell.Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#2563EB")); // Primary color
                cell.Style.Font.Color.SetColor(System.Drawing.Color.White);
                
                cell.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                cell.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                cell.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            }
        }
    }
}
