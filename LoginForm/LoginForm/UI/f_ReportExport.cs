using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_ReportExport : Form
    {
        private DataTable currentData = new DataTable();
        private readonly ReportExportService exportService = new ReportExportService();
        private bool isLoaded = false;

        public f_ReportExport()
        {
            InitializeComponent();
        }

        private void f_ReportExport_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes
            cboReportType.Items.Add("Students");
            cboReportType.Items.Add("Scores");
            cboReportType.SelectedIndex = 0;

            cboGender.Items.Add("All");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.SelectedIndex = 0;

            LoadClassesComboBox();

            // Set default date range
            dtpFrom.Value = new DateTime(1990, 1, 1);
            dtpTo.Value = DateTime.Today;

            // Load session details
            lblSumUser.Text = $"User: {Globals.Username}";
            lblSumDate.Text = $"Date: {DateTime.Today:dd/MM/yyyy}";

            isLoaded = true;

            // Trigger initial UI setup and data load
            ToggleFilters();
            LoadGridData();
        }

        private void LoadClassesComboBox()
        {
            try
            {
                cboClass.DataSource = null;
                var scoreModel = new Score();
                DataTable dtClasses = scoreModel.GetAllClasses();

                cboClass.DisplayMember = "ClassDisplay";
                cboClass.ValueMember = "ClassID";

                // Create a row for "All"
                DataRow allRow = dtClasses.NewRow();
                allRow["ClassID"] = "All";
                allRow["ClassDisplay"] = "All Classes";
                dtClasses.Rows.InsertAt(allRow, 0);

                cboClass.DataSource = dtClasses;
                cboClass.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToggleFilters()
        {
            if (!isLoaded) return;

            string selectedReport = cboReportType.SelectedItem?.ToString() ?? "Students";

            if (selectedReport == "Students")
            {
                lblGender.Visible = cboGender.Visible = true;
                lblFrom.Visible = dtpFrom.Visible = true;
                lblTo.Visible = dtpTo.Visible = true;

                lblClass.Visible = cboClass.Visible = false;
            }
            else // Scores
            {
                lblGender.Visible = cboGender.Visible = false;
                lblFrom.Visible = dtpFrom.Visible = false;
                lblTo.Visible = dtpTo.Visible = false;

                lblClass.Visible = cboClass.Visible = true;
            }
        }

        private void LoadGridData()
        {
            if (!isLoaded) return;

            try
            {
                currentData = new DataTable();
                string searchKeyword = txtSearch.Text.Trim();
                string selectedReport = cboReportType.SelectedItem?.ToString() ?? "Students";

                using (var db = new My_DB())
                {
                    db.openConnection();

                    if (selectedReport == "Students")
                    {
                        string gender = cboGender.SelectedItem?.ToString() ?? "All";
                        string query = @"
                            SELECT 
                                ID AS [MSSV], 
                                FirstName, 
                                LastName, 
                                Dob AS [DOB], 
                                Gender, 
                                Phone, 
                                Email 
                            FROM Student 
                            WHERE 1=1";

                        if (!string.IsNullOrEmpty(searchKeyword))
                        {
                            query += " AND (ID LIKE @search OR FirstName LIKE @search OR LastName LIKE @search OR Phone LIKE @search OR Email LIKE @search)";
                        }
                        if (gender != "All")
                        {
                            query += " AND Gender = @gender";
                        }
                        query += " AND Dob BETWEEN @fromDate AND @toDate ORDER BY ID";

                        using (var cmd = new SqlCommand(query, db.getConnection))
                        {
                            if (!string.IsNullOrEmpty(searchKeyword))
                                cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");
                            if (gender != "All")
                                cmd.Parameters.AddWithValue("@gender", gender);

                            cmd.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date);
                            cmd.Parameters.AddWithValue("@toDate", dtpTo.Value.Date.AddDays(1).AddTicks(-1));

                            using (var adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(currentData);
                            }
                        }
                    }
                    else // Scores
                    {
                        string classId = cboClass.SelectedValue?.ToString() ?? "All";
                        string query = @"
                            SELECT 
                                s.ID AS [MSSV], 
                                st.FirstName + ' ' + st.LastName AS [FullName], 
                                co.CourseName AS [Course], 
                                s.TotalScore AS [Score], 
                                cl.Semester AS [Semester]
                            FROM Score s
                            JOIN Student st ON s.ID = st.ID
                            JOIN Class cl ON s.ClassID = cl.ClassID
                            JOIN Course co ON cl.CourseID = co.CourseID
                            WHERE 1=1";

                        if (!string.IsNullOrEmpty(searchKeyword))
                        {
                            query += " AND (s.ID LIKE @search OR st.FirstName LIKE @search OR st.LastName LIKE @search OR co.CourseName LIKE @search)";
                        }
                        if (classId != "All")
                        {
                            query += " AND s.ClassID = @classId";
                        }
                        query += " ORDER BY s.ID";

                        using (var cmd = new SqlCommand(query, db.getConnection))
                        {
                            if (!string.IsNullOrEmpty(searchKeyword))
                                cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");
                            if (classId != "All")
                                cmd.Parameters.AddWithValue("@classId", classId);

                            using (var adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(currentData);
                            }
                        }
                    }
                }

                dgvReport.DataSource = currentData;

                // Format Date in DataGridView
                if (selectedReport == "Students" && dgvReport.Columns["DOB"] != null)
                {
                    dgvReport.Columns["DOB"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                // Update total records counts
                lblTotal.Text = $"Total Records: {currentData.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFilters()
        {
            txtSearch.Text = "";
            cboGender.SelectedIndex = 0;
            if (cboClass.Items.Count > 0)
                cboClass.SelectedIndex = 0;
            dtpFrom.Value = new DateTime(1990, 1, 1);
            dtpTo.Value = DateTime.Today;

            LoadGridData();
        }

        // ==========================================
        // EVENT HANDLERS
        // ==========================================

        private void cboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleFilters();
            LoadGridData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (currentData == null || currentData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cboReportType.SelectedItem?.ToString() ?? "Students";

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.FileName = selectedReport == "Students" ? "DanhSachSinhVien.pdf" : "BangDiemSinhVien.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bool success = false;
                        if (selectedReport == "Students")
                        {
                            success = exportService.ExportStudentsToPdf(currentData, sfd.FileName, Globals.Username);
                        }
                        else // Scores
                        {
                            success = exportService.ExportScoresToPdf(currentData, sfd.FileName, Globals.Username);
                        }

                        if (success)
                        {
                            MessageBox.Show("Xuất PDF thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất PDF: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (currentData == null || currentData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cboReportType.SelectedItem?.ToString() ?? "Students";

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = selectedReport == "Students" ? "DanhSachSinhVien.xlsx" : "BangDiemSinhVien.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bool success = false;
                        if (selectedReport == "Students")
                        {
                            success = exportService.ExportStudentsToExcel(currentData, sfd.FileName);
                        }
                        else // Scores
                        {
                            success = exportService.ExportScoresToExcel(currentData, sfd.FileName);
                        }

                        if (success)
                        {
                            MessageBox.Show("Xuất Excel thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi xuất Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (currentData == null || currentData.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xem trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cboReportType.SelectedItem?.ToString() ?? "Students";

            try
            {
                string tempFile = Path.Combine(Path.GetTempPath(), $"ReportPreview_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");
                bool success = false;

                if (selectedReport == "Students")
                {
                    success = exportService.ExportStudentsToPdf(currentData, tempFile, Globals.Username);
                }
                else // Scores
                {
                    success = exportService.ExportScoresToPdf(currentData, tempFile, Globals.Username);
                }

                if (success && File.Exists(tempFile))
                {
                    var psi = new ProcessStartInfo(tempFile) { UseShellExecute = true };
                    Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xem trước: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
