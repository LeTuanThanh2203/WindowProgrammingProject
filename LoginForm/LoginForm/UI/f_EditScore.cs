using Project_Group6.Models;
using Project_Group6.UI;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_EditScore : Form
    {
        private readonly Score _score = new();
        private DataTable _currentTable;
        private PaginationHelper _pager;
        private readonly ReportExportService _exportService = new ReportExportService();

        public f_EditScore()
        {
            InitializeComponent();
            Load += f_EditScore_Load;

            cboClass.SelectedIndexChanged += Filter_Changed;
            cboAcademicYear.SelectedIndexChanged += Filter_Changed;
            cboSemester.SelectedIndexChanged += Filter_Changed;
            btnAdd.Click += btnAdd_Click;
            btnReset.Click += btnReset_Click;
            btnExport.Click += btnExport_Click;      // ← wire export

            dgvStudent.CellEndEdit += dgvStudent_CellEndEdit;
            dgvStudent.DataBindingComplete += dgvStudent_DataBindingComplete;
        }

        // ================= LOAD =================
        private void f_EditScore_Load(object sender, EventArgs e)
        {
            _pager = new PaginationHelper(
                pageTable => {
                    dgvStudent.DataSource = pageTable;
                    LockNonScoreColumns();
                },
                lblPageInfo,
                lblTotal,
                btnFirst,
                btnPrev,
                btnNext,
                btnLast,
                cboPageSize
            );

            UIStyleHelper.StyleDataGridView(dgvStudent);
            dgvStudent.ReadOnly = false;

            LoadClasses();
            LoadAcademicYears();
            LoadSemesters();
            RefreshGrid();
        }

        // ================= SETUP =================
        private void LoadClasses()
        {
            var dt = _score.GetAllClasses();

            var allRow = dt.NewRow();
            allRow["ClassID"] = "";
            allRow["ClassDisplay"] = "-- All Classes --";
            dt.Rows.InsertAt(allRow, 0);

            cboClass.DataSource = dt;
            cboClass.DisplayMember = "ClassDisplay";
            cboClass.ValueMember = "ClassID";
            cboClass.SelectedIndex = 0;
        }

        private void LoadAcademicYears()
        {
            cboAcademicYear.Items.Clear();
            cboAcademicYear.Items.Add("-- All --");

            var dt = new Class().GetDistinctAcademicYears();
            foreach (DataRow row in dt.Rows)
                cboAcademicYear.Items.Add(row[0].ToString());

            cboAcademicYear.SelectedIndex = 0;
        }

        private void LoadSemesters()
        {
            cboSemester.Items.Clear();
            cboSemester.Items.Add("-- All --");
            cboSemester.Items.Add("HK1");
            cboSemester.Items.Add("HK2");
            cboSemester.Items.Add("Summer");
            cboSemester.SelectedIndex = 0;
        }

        // ================= LOAD DATA =================
        private void RefreshGrid()
        {
            _currentTable = _score.GetAllScore();
            _pager.SetData(_currentTable);
        }

        private void LockNonScoreColumns()
        {
            if (dgvStudent.Columns.Count == 0) return;

            foreach (DataGridViewColumn col in dgvStudent.Columns)
            {
                bool isEditable = col.Name == "Process Grade" || col.Name == "Final Grade";
                col.ReadOnly = !isEditable;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvStudent.Columns.Contains("Process Grade"))
                dgvStudent.Columns["Process Grade"].DefaultCellStyle.BackColor = Color.LightYellow;
            if (dgvStudent.Columns.Contains("Final Grade"))
                dgvStudent.Columns["Final Grade"].DefaultCellStyle.BackColor = Color.LightYellow;
        }

        // ================= FILTER =================
        private void Filter_Changed(object sender, EventArgs e) => ApplyFilter();

        private void dgvStudent_DataBindingComplete(
            object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.IsNewRow) continue;

                string grade = row.Cells["Grade"].Value?.ToString() ?? "";
                var cell = row.Cells["Grade"];

                (cell.Style.BackColor, cell.Style.ForeColor) = grade switch
                {
                    "Excellent" => (Color.FromArgb(0, 180, 0), Color.White),
                    "Good" => (Color.FromArgb(100, 200, 100), Color.Black),
                    "Pass" => (Color.FromArgb(255, 200, 0), Color.Black),
                    "Fail" => (Color.FromArgb(220, 50, 50), Color.White),
                    _ => (Color.White, Color.Black)
                };
            }
        }

        private void ApplyFilter()
        {
            string classID = cboClass.SelectedValue?.ToString() ?? "";
            string academicYear = cboAcademicYear.SelectedItem?.ToString() ?? "";
            string semStr = cboSemester.SelectedItem?.ToString() ?? "";

            bool filterClass = !string.IsNullOrEmpty(classID);
            bool filterYear = academicYear != "-- All --" && !string.IsNullOrEmpty(academicYear);
            bool filterSem = semStr != "-- All --" && !string.IsNullOrEmpty(semStr);

            DataTable dt = filterClass
                ? _score.GetScoreByClass(classID)
                : _score.GetAllScore();

            if (dt.Rows.Count > 0)
            {
                var query = dt.AsEnumerable();

                if (filterYear)
                    query = query.Where(r => r["AcademicYear"].ToString() == academicYear);

                if (filterSem)
                    query = query.Where(r => r["Semester"].ToString() == semStr);

                dt = query.Any() ? query.CopyToDataTable() : dt.Clone();
            }

            _currentTable = dt;
            _pager.SetData(dt);
        }

        // ================= GET EXPORT DATA =================
        private DataTable GetExportData()
        {
            // Dùng _currentTable (đã filter) nhưng bỏ các cột không cần thiết khi in
            if (_currentTable == null || _currentTable.Rows.Count == 0)
                return null;

            // Tạo bản sao với tên cột đẹp hơn để xuất
            string[] skipCols = { };   // Có thể loại trừ cột nào không muốn xuất ở đây

            DataTable exportDt = new DataTable();

            foreach (DataColumn col in _currentTable.Columns)
            {
                if (Array.IndexOf(skipCols, col.ColumnName) >= 0) continue;
                exportDt.Columns.Add(col.ColumnName, col.DataType);
            }

            foreach (DataRow row in _currentTable.Rows)
            {
                DataRow newRow = exportDt.NewRow();
                foreach (DataColumn col in exportDt.Columns)
                    newRow[col.ColumnName] = row[col.ColumnName];
                exportDt.Rows.Add(newRow);
            }

            return exportDt;
        }

        // ================= EXPORT =================
        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable exportData = GetExportData();

            if (exportData == null || exportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please apply a filter first.",
                    "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi format xuất
            using (var dlg = new ExportFormatDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                if (dlg.SelectedFormat == "PDF")
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "PDF Files|*.pdf";
                        sfd.FileName = BuildFileName("pdf");
                        if (sfd.ShowDialog() != DialogResult.OK) return;

                        try
                        {
                            bool ok = _exportService.ExportScoresToPdf(
                                exportData, sfd.FileName, Globals.Username);
                            if (ok)
                                MessageBox.Show("Export PDF successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Export PDF failed: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else // Excel
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Files|*.xlsx";
                        sfd.FileName = BuildFileName("xlsx");
                        if (sfd.ShowDialog() != DialogResult.OK) return;

                        try
                        {
                            bool ok = _exportService.ExportScoresToExcel(exportData, sfd.FileName);
                            if (ok)
                                MessageBox.Show("Export Excel successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Export Excel failed: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // Tạo tên file gợi ý dựa trên filter hiện tại
        private string BuildFileName(string ext)
        {
            string classVal = cboClass.SelectedItem is DataRowView drv
                ? drv["ClassDisplay"]?.ToString() ?? "All"
                : "All";
            string sem = cboSemester.SelectedItem?.ToString() ?? "All";
            string year = cboAcademicYear.SelectedItem?.ToString() ?? "All";

            // Dọn ký tự không hợp lệ cho tên file
            classVal = classVal.Replace("--", "").Replace(" ", "_").Trim('_');
            sem = sem.Replace("--", "").Replace(" ", "").Trim('-');
            year = year.Replace("--", "").Replace(" ", "").Trim('-');

            return $"Scores_{classVal}_{sem}_{year}.{ext}";
        }

        // ================= SAVE =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvStudent.EndEdit();

            int successCount = 0, failCount = 0;

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.IsNewRow) continue;

                string midVal = row.Cells["Process Grade"].Value?.ToString()?.Trim() ?? "";
                string finalVal = row.Cells["Final Grade"].Value?.ToString()?.Trim() ?? "";

                if (string.IsNullOrEmpty(midVal) && string.IsNullOrEmpty(finalVal))
                    continue;

                decimal? midterm = null;
                decimal? final = null;
                bool isMidValid = true;
                bool isFinalValid = true;

                if (!string.IsNullOrEmpty(midVal))
                {
                    if (decimal.TryParse(midVal,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.CurrentCulture, out decimal m) ||
                        decimal.TryParse(midVal,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture, out m))
                    {
                        if (m >= 0 && m <= 10) midterm = m;
                        else isMidValid = false;
                    }
                    else isMidValid = false;
                }

                if (!string.IsNullOrEmpty(finalVal))
                {
                    if (decimal.TryParse(finalVal,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.CurrentCulture, out decimal f) ||
                        decimal.TryParse(finalVal,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture, out f))
                    {
                        if (f >= 0 && f <= 10) final = f;
                        else isFinalValid = false;
                    }
                    else isFinalValid = false;
                }

                if (!isMidValid || !isFinalValid) { failCount++; continue; }

                var s = new Score
                {
                    ID = row.Cells["ID"].Value?.ToString(),
                    ClassID = row.Cells["ClassID"].Value?.ToString(),
                    MidtermScore = midterm,
                    FinalScore = final
                };

                if (s.UpdateScore()) successCount++;
                else failCount++;
            }

            if (failCount > 0)
                MessageBox.Show(
                    $"Saved: {successCount} | Failed/Invalid: {failCount}\n"
                    + "Score must be between 0 and 10.", "Result");
            else
                MessageBox.Show($"Saved {successCount} record(s) successfully!");

            RefreshGrid();
            ApplyFilter();
        }

        // ================= RESET =================
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow == null) return;

            var row = dgvStudent.CurrentRow;
            string id = row.Cells["ID"].Value?.ToString();
            string classID = row.Cells["ClassID"].Value?.ToString();

            if (string.IsNullOrEmpty(id)) { MessageBox.Show("Select a row first!"); return; }

            if (MessageBox.Show($"Reset score for {id} - {classID}?",
                    "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var s = new Score { ID = id, ClassID = classID };

            if (s.ResetScore())
            {
                MessageBox.Show("Reset successfully!");
                RefreshGrid();
                ApplyFilter();
            }
            else
                MessageBox.Show("Reset failed!");
        }

        // ================= VALIDATE CELL =================
        private void dgvStudent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var col = dgvStudent.Columns[e.ColumnIndex];
            if (col.Name != "Process Grade" && col.Name != "Final Grade") return;

            var cell = dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string val = cell.Value?.ToString()?.Trim() ?? "";

            if (val == "")
            {
                cell.Style.BackColor = Color.LightYellow;
                cell.Style.ForeColor = Color.Black;
                cell.ErrorText = "";

                var row = dgvStudent.Rows[e.RowIndex];
                if (dgvStudent.Columns.Contains("Total Grade"))
                    row.Cells["Total Grade"].Value = DBNull.Value;
                return;
            }

            bool valid = (decimal.TryParse(val,
                             System.Globalization.NumberStyles.Any,
                             System.Globalization.CultureInfo.CurrentCulture,
                             out decimal d) ||
                          decimal.TryParse(val,
                             System.Globalization.NumberStyles.Any,
                             System.Globalization.CultureInfo.InvariantCulture,
                             out d))
                         && d >= 0 && d <= 10;

            if (!valid)
            {
                cell.Style.BackColor = Color.LightCoral;
                cell.Style.ForeColor = Color.DarkRed;
                cell.ErrorText = "Must be 0 - 10";
            }
            else
            {
                cell.Style.BackColor = Color.LightYellow;
                cell.Style.ForeColor = Color.Black;
                cell.ErrorText = "";

                var row = dgvStudent.Rows[e.RowIndex];
                string midVal = row.Cells["Process Grade"].Value?.ToString()?.Trim() ?? "";
                string finVal = row.Cells["Final Grade"].Value?.ToString()?.Trim() ?? "";

                decimal mid = 0, fin = 0;
                bool midOk = !string.IsNullOrEmpty(midVal) &&
                             (decimal.TryParse(midVal,
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.CurrentCulture, out mid) ||
                              decimal.TryParse(midVal,
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture, out mid));

                bool finOk = !string.IsNullOrEmpty(finVal) &&
                             (decimal.TryParse(finVal,
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.CurrentCulture, out fin) ||
                              decimal.TryParse(finVal,
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture, out fin));

                if (midOk && finOk && dgvStudent.Columns.Contains("Total Grade"))
                    row.Cells["Total Grade"].Value = Math.Round(mid * 0.4m + fin * 0.6m, 2);
                else if (dgvStudent.Columns.Contains("Total Grade"))
                    row.Cells["Total Grade"].Value = DBNull.Value;
            }
        }
    }
}