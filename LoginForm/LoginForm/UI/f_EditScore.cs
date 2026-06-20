using Project_Group6.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_EditScore : Form
    {
        private readonly Score _score = new();
        private DataTable _currentTable;
        private PaginationHelper _pager;

        public f_EditScore()
        {
            InitializeComponent();
            Load += f_EditScore_Load;

            cboClass.SelectedIndexChanged += Filter_Changed;
            cboAcademicYear.SelectedIndexChanged += Filter_Changed;
            cboSemester.SelectedIndexChanged += Filter_Changed;
            btnAdd.Click += btnAdd_Click;
            btnReset.Click += btnReset_Click;
   

            dgvStudent.CellEndEdit += dgvStudent_CellEndEdit;
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
            // GetAllClasses() trong Score JOIN Course, trả về ClassID + ClassDisplay
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

            // AcademicYear lấy từ bảng Class (Score không có cột này)
            var dt = new Class().GetDistinctAcademicYears();
            foreach (DataRow row in dt.Rows)
                cboAcademicYear.Items.Add(row[0].ToString());

            cboAcademicYear.SelectedIndex = 0;
        }

        private void LoadSemesters()
        {
            cboSemester.Items.Clear();
            cboSemester.Items.Add("-- All --");
            // Schema mới: Semester là NVARCHAR(20)
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
                bool isEditable = col.Name == "Process Grade"
                               || col.Name == "Final Grade";
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

                // Schema mới: cột tên "Grade" (Overview từ trigger)
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
            // Schema mới: Semester là string (HK1/HK2/Summer)
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
                    if (decimal.TryParse(midVal, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out decimal m) ||
                        decimal.TryParse(midVal, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out m))
                    {
                        if (m >= 0 && m <= 10)
                            midterm = m;
                        else
                            isMidValid = false;
                    }
                    else
                    {
                        isMidValid = false;
                    }
                }

                if (!string.IsNullOrEmpty(finalVal))
                {
                    if (decimal.TryParse(finalVal, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out decimal f) ||
                        decimal.TryParse(finalVal, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out f))
                    {
                        if (f >= 0 && f <= 10)
                            final = f;
                        else
                            isFinalValid = false;
                    }
                    else
                    {
                        isFinalValid = false;
                    }
                }

                if (!isMidValid || !isFinalValid)
                {
                    failCount++;
                    continue;
                }

                // Schema mới: Score PK = (ID, ClassID) — không có Semester/AcademicYear
                var s = new Score
                {
                    ID = row.Cells["ID"].Value?.ToString(),    // thay MSSV
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
            // Schema mới: cột ID thay MSSV
            string id = row.Cells["ID"].Value?.ToString();
            string classID = row.Cells["ClassID"].Value?.ToString();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Select a row first!");
                return;
            }

            if (MessageBox.Show(
                    $"Reset score for {id} - {classID}?",
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

        // ================= VALIDATE =================
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

                // TotalScore là computed column — chỉ preview, không ghi
                var row = dgvStudent.Rows[e.RowIndex];

                string midVal = row.Cells["Process Grade"].Value?.ToString()?.Trim() ?? "";
                string finVal = row.Cells["Final Grade"].Value?.ToString()?.Trim() ?? "";

                decimal mid = 0;
                decimal fin = 0;

                bool midOk = !string.IsNullOrEmpty(midVal) && (decimal.TryParse(midVal,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.CurrentCulture, out mid) ||
                    decimal.TryParse(midVal,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out mid));

                bool finOk = !string.IsNullOrEmpty(finVal) && (decimal.TryParse(finVal,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.CurrentCulture, out fin) ||
                    decimal.TryParse(finVal,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out fin));

                // Preview tổng: 40% giữa kỳ + 60% cuối kỳ (theo trigger TR_Score_Update)
                if (midOk && finOk && dgvStudent.Columns.Contains("Total Grade"))
                    row.Cells["Total Grade"].Value =
                        Math.Round(mid * 0.4m + fin * 0.6m, 2);
                else if (dgvStudent.Columns.Contains("Total Grade"))
                    row.Cells["Total Grade"].Value = DBNull.Value;
            }
        }
    }
}