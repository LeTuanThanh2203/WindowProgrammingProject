using Project_Group6.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_EditScore : Form
    {
        private readonly Student student = new();
        private readonly Score score = new();

        private decimal _originalMidterm;
        private decimal _originalFinal;
        private bool _isFillingFromRow;
        private bool _isEditMode;

        public f_EditScore() => InitializeComponent();

        // ================= LOAD =================
        private void f_AddScore_Load(object sender, EventArgs e)
        {
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            SetFormVisibility(false);
            LoadAllCourses();
            RefreshGrid();
        }

        // ================= HELPERS =================
        private void SetFormVisibility(bool visible)
        {
            foreach (var ctrl in new Control[]
            {
        MSSV, lblID, label2, label3, label4,
        txtQT, txtCK, lblTotal,
        btnAdd, btnRefresh
            })
                ctrl.Visible = visible;

            // Delete chỉ hiện khi Edit mode (đã có điểm)
            btnDelete.Visible = visible && _isEditMode;
        }

        private void LoadAllCourses()
        {
            var courses = score.GetAllCourses();
            var allRow = courses.NewRow();
            allRow["CourseID"] = -1;
            allRow["CourseName"] = "-- All Courses --";
            courses.Rows.InsertAt(allRow, 0);
            BindComboBox(courses);
        }

        private void BindComboBox(DataTable table)
        {
            _isFillingFromRow = true;
            cboCourse.DataSource = table;
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseID";
            _isFillingFromRow = false;
        }

        private void RefreshGrid() =>
            dgvStudent.DataSource = score.GetAllScore();

        private void ResetInputs()
        {
            txtQT.Text = "";
            txtCK.Text = "";
            lblTotal.Text = "";
        }

        private void CalculateScore()
        {
            if (txtQT.Text == "" || txtCK.Text == "")
            {
                lblTotal.Text = "";
                return;
            }
            decimal qt = Convert.ToDecimal(txtQT.Text);
            decimal ck = Convert.ToDecimal(txtCK.Text);
            lblTotal.Text = ((qt + ck) / 2).ToString("0.00");
        }

        private bool ValidateScore(string text, out decimal value)
        {
            value = 0;
            if (!decimal.TryParse(text, out value) || value < 0 || value > 10)
            {
                MessageBox.Show("Score must be 0 -> 10");
                return false;
            }
            return true;
        }

        private bool Verify() =>
            lblID.Text != ""
            && txtQT.Text != ""
            && txtCK.Text != ""
            && cboCourse.SelectedValue != null
            && Convert.ToInt32(cboCourse.SelectedValue) != -1;

        // ================= CLICK SINH VIÊN =================
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvStudent.Rows[e.RowIndex];
            var midCell = row.Cells["Process Grade"];
            var finalCell = row.Cells["Final Grade"];

            bool hasScore = midCell.Value != null && midCell.Value != DBNull.Value
                         && finalCell.Value != null && finalCell.Value != DBNull.Value;

            _isEditMode = hasScore;

            string mssv = row.Cells["MSSV"].Value.ToString();
            string courseName = row.Cells["CourseName"].Value?.ToString(); // tên môn từ grid
            lblID.Text = mssv;

            if (hasScore)
            {
                _originalMidterm = Convert.ToDecimal(midCell.Value);
                _originalFinal = Convert.ToDecimal(finalCell.Value);
                txtQT.Text = _originalMidterm.ToString();
                txtCK.Text = _originalFinal.ToString();
                btnAdd.Text = "Update";
                BindComboBox(score.GetCoursesWithScore(mssv));
            }
            else
            {
                _originalMidterm = 0;
                _originalFinal = 0;
                ResetInputs();
                btnAdd.Text = "Add";
                BindComboBox(score.GetCoursesWithoutScore(mssv));
            }

            // ✅ Focus đúng môn của row đang click
            // Lấy CourseID từ DB dựa theo mssv + courseName
            var courseRow = score.GetCourseIDByStudentAndName(mssv, courseName);
            if (courseRow != null)
            {
                _isFillingFromRow = true;
                cboCourse.SelectedValue = courseRow;
                _isFillingFromRow = false;
            }

            SetFormVisibility(true);
            CalculateScore();
        }

        // ================= CHỌN MÔN =================
        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isFillingFromRow) return;
            if (cboCourse.SelectedValue == null) return;
            if (!int.TryParse(cboCourse.SelectedValue.ToString(), out int courseID)) return;

            if (lblID.Text == "")
            {
                // Chưa chọn sinh viên → filter grid theo môn
                dgvStudent.DataSource = courseID == -1
                    ? score.GetAllScore()
                    : score.GetScoreByCourse(courseID);
                return;
            }

            // Đã chọn sinh viên → load điểm của môn vừa chọn
            var scoreData = score.GetScoreByStudentAndCourse(lblID.Text, courseID);
            if (scoreData != null && scoreData.Rows.Count > 0)
            {
                var r = scoreData.Rows[0];
                bool hasScore = r["Process Grade"] != DBNull.Value
                             && r["Final Grade"] != DBNull.Value;

                _isEditMode = hasScore;
                btnDelete.Visible = hasScore;

                if (hasScore)
                {
                    _originalMidterm = Convert.ToDecimal(r["Process Grade"]);
                    _originalFinal = Convert.ToDecimal(r["Final Grade"]);
                    txtQT.Text = _originalMidterm.ToString();
                    txtCK.Text = _originalFinal.ToString();
                    btnAdd.Text = "Update";
                }
                else
                {
                    _originalMidterm = 0;
                    _originalFinal = 0;
                    ResetInputs();
                    btnAdd.Text = "Add";
                }
                CalculateScore();
            }
        }

        // ================= REFRESH =================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtQT.Text = _originalMidterm != 0 ? _originalMidterm.ToString() : "";
            txtCK.Text = _originalFinal != 0 ? _originalFinal.ToString() : "";
            lblTotal.Text = "";
            CalculateScore();
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "" || cboCourse.SelectedValue == null) return;

            if (MessageBox.Show("Reset score to 0 for this student?", "Confirm",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            var reset = new Score
            {
                MSSV = lblID.Text,
                CourseID = Convert.ToInt32(cboCourse.SelectedValue),
                MidtermScore = 0,
                FinalScore = 0
            };

            if (reset.UpdateScore())
            {
                MessageBox.Show("Score reset to 0");
                txtQT.Text = "0";
                txtCK.Text = "0";
                _originalMidterm = 0;
                _originalFinal = 0;
                CalculateScore();
                RefreshGrid();
            }
            else
                MessageBox.Show("Reset failed");
        }

        // ================= QT =================
        private void txtQT_TextChanged(object sender, EventArgs e)
        {
            if (txtQT.Text == "") return;
            if (!ValidateScore(txtQT.Text, out _)) { txtQT.Clear(); return; }
            CalculateScore();
        }

        // ================= CK =================
        private void txtCK_TextChanged(object sender, EventArgs e)
        {
            if (txtCK.Text == "") return;
            if (!ValidateScore(txtCK.Text, out _)) { txtCK.Clear(); return; }
            CalculateScore();
        }

        // ================= ADD / UPDATE =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Verify())
            {
                MessageBox.Show("Please select a student and input score");
                return;
            }

            var s = new Score
            {
                MSSV = lblID.Text,
                CourseID = Convert.ToInt32(cboCourse.SelectedValue),
                MidtermScore = Convert.ToDecimal(txtQT.Text),
                FinalScore = Convert.ToDecimal(txtCK.Text)
            };

            // Luôn dùng UpdateScore vì record đã có sẵn (insert khi đăng ký)
            bool success = s.UpdateScore();

            if (success)
            {
                MessageBox.Show("Update success");
                _originalMidterm = s.MidtermScore;
                _originalFinal = s.FinalScore;
                ResetInputs();
                RefreshGrid();
                BindComboBox(score.GetCoursesWithScore(lblID.Text));
            }
            else
                MessageBox.Show("Update failed");
        }
    }
}