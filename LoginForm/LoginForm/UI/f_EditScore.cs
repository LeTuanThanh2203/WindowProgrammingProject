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

        public f_EditScore()
        {
            InitializeComponent();
            Load += f_EditScore_Load;

            cboClass.SelectedIndexChanged += Filter_Changed;
            cboAcademicYear.SelectedIndexChanged += Filter_Changed;
            cboSemester.SelectedIndexChanged += Filter_Changed;
            btnAdd.Click += btnAdd_Click;
            btnReset.Click += btnReset_Click;   // sửa đúng
                                                // btnExport để sau
            dgvStudent.CellEndEdit += dgvStudent_CellEndEdit;
        }

        // ================= LOAD =================
        private void f_EditScore_Load(object sender, EventArgs e)
        {
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
            cboSemester.Items.Add("1");
            cboSemester.Items.Add("2");
            cboSemester.Items.Add("3");
            cboSemester.SelectedIndex = 0;
        }

        // ================= LOAD DATA =================
        private void RefreshGrid()
        {
            _currentTable = _score.GetAllScore();
            dgvStudent.DataSource = _currentTable;
            LockNonScoreColumns();
        }

        private void LockNonScoreColumns()
        {
            if (dgvStudent.Columns.Count == 0) return;

            foreach (DataGridViewColumn col in dgvStudent.Columns)
            {
                bool isEditable = col.Name == "Process Grade"
                               || col.Name == "Final Grade";
                col.ReadOnly = !isEditable;

                // Căn giữa header và cell
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

        private void dgvStudent_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.IsNewRow) continue;
                string grade = row.Cells["Grade"].Value?.ToString() ?? "";
                var cell = row.Cells["Grade"];

                (cell.Style.BackColor, cell.Style.ForeColor) = grade switch
                {
                    "A+" or "A" => (Color.FromArgb(0, 180, 0), Color.White),
                    "B+" or "B" => (Color.FromArgb(100, 200, 100), Color.Black),
                    "C+" or "C" => (Color.FromArgb(255, 200, 0), Color.Black),
                    "D+" or "D" => (Color.FromArgb(255, 140, 0), Color.White),
                    "F" => (Color.FromArgb(220, 50, 50), Color.White),
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
            bool filterSem = int.TryParse(semStr, out int semester);

            DataTable dt = filterClass
                ? _score.GetScoreByClass(classID)
                : _score.GetAllScore();

            if (dt.Rows.Count > 0)
            {
                var query = dt.AsEnumerable();

                if (filterYear)
                    query = query.Where(r => r["AcademicYear"].ToString() == academicYear);

                if (filterSem)
                    query = query.Where(r => r.Field<int>("Semester") == semester);

                dt = query.Any() ? query.CopyToDataTable() : dt.Clone();
            }

            _currentTable = dt;
            dgvStudent.DataSource = dt;
            LockNonScoreColumns();
        }

        // ================= SAVE =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvStudent.EndEdit();

            int successCount = 0;
            int failCount = 0;

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.IsNewRow) continue;

                string midVal = row.Cells["Process Grade"].Value?.ToString();
                string finalVal = row.Cells["Final Grade"].Value?.ToString();

                if (string.IsNullOrEmpty(midVal) && string.IsNullOrEmpty(finalVal))
                    continue;

                bool midOk = decimal.TryParse(midVal,
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture,
                                 out decimal midterm);
                bool finalOk = decimal.TryParse(finalVal,
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture,
                                 out decimal final);

                if (!midOk || !finalOk || midterm < 0 || midterm > 10 || final < 0 || final > 10)
                {
                    failCount++;
                    continue;
                }

                var s = new Score
                {
                    MSSV = row.Cells["MSSV"].Value?.ToString(),
                    ClassID = row.Cells["ClassID"].Value?.ToString(),
                    Semester = Convert.ToInt32(row.Cells["Semester"].Value),
                    AcademicYear = row.Cells["AcademicYear"].Value?.ToString(),
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
        // ================= EXPORT (chưa làm) =================
        private void btnExport_Click(object sender, EventArgs e) { }

        // ================= RESET =================
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow == null) return;

            var row = dgvStudent.CurrentRow;
            string mssv = row.Cells["MSSV"].Value?.ToString();
            string classID = row.Cells["ClassID"].Value?.ToString();
            int semester = Convert.ToInt32(row.Cells["Semester"].Value);
            string acadYear = row.Cells["AcademicYear"].Value?.ToString();

            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Select a row first!");
                return;
            }

            if (MessageBox.Show(
                    $"Reset score for {mssv} - {classID}?",
                    "Confirm",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            var s = new Score
            {
                MSSV = mssv,
                ClassID = classID,
                Semester = semester,
                AcademicYear = acadYear
            };

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
            string val = cell.Value?.ToString() ?? "";

            if (val == "") return;

            bool valid = decimal.TryParse(val,
                             System.Globalization.NumberStyles.Any,
                             System.Globalization.CultureInfo.InvariantCulture,
                             out decimal d)
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
                bool midOk = decimal.TryParse(
                                 row.Cells["Process Grade"].Value?.ToString(),
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture,
                                 out decimal mid);
                bool finOk = decimal.TryParse(
                                 row.Cells["Final Grade"].Value?.ToString(),
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture,
                                 out decimal fin);

                if (midOk && finOk && dgvStudent.Columns.Contains("Total Grade"))
                    row.Cells["Total Grade"].Value = Math.Round((mid + fin) / 2, 2);
            }
        }
    }
}