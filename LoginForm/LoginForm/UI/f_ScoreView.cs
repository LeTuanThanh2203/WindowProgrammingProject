using ProjectMonHoc;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_ScoreView : Form
    {
        private readonly string _mssv;
        private readonly Score score = new Score();
        private DataTable _scoreTable;
        public f_ScoreView(string mssv)
        {
            InitializeComponent();
            _mssv = mssv;
            this.Load += f_Score_Load;
            dgvScore.CellClick += dgvScore_CellClick;
            btnClose.Click += (s, e) => Close();

            cboSort.Items.AddRange(new object[] { "Academic Year", "Semester", "Course Name" });
            cboOverviewFilter.Items.AddRange(new object[] { "All", "Excellent", "Good", "Pass", "Fail" });
            cboOverviewFilter.SelectedIndex = 0;


            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            cboOverviewFilter.SelectedIndexChanged += cboOverviewFilter_SelectedIndexChanged;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void f_Score_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
            LoadScores();
        }

        // =========================
        // LOAD STUDENT INFO
        // =========================
        private void LoadStudentInfo()
        {
            // Dùng GetStudentByID — connection riêng, không conflict
            Student student = new Student().GetStudentByID(_mssv);
            if (student == null) return;

            lblID.Text = student.ID;
            lblFirstname.Text = student.FirstName;
            lblLastname.Text = student.LastName;
            lblDob.Text = student.Dob.ToString("dd/MM/yyyy");
            lblGender.Text = student.Gender;
            lblPhone.Text = student.Phone;
            lblAddress.Text = student.Address;
            lblEmail.Text = student.Email;

            // Hiện ảnh — copy y chang f_ListStudent
            if (student.Picture != null && student.Picture.Length > 0)
            {
                MemoryStream ms = new MemoryStream(student.Picture);
                picStudent.Image = Image.FromStream(ms);
                picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                picStudent.Image = null;
            }
        }

        // =========================
        // LOAD SCORE
        // =========================
        private void LoadScores()
        {
            _scoreTable = score.GetScoreByStudent(_mssv);
            dgvScore.DataSource = _scoreTable;

            // ID / StudentName / ClassID / CourseID đã hiển thị ở panel bên trái
            // (lblID, lblFirstname...) nên ẩn đi trong bảng cho gọn
            HideColumnIfExists("ID");
            HideColumnIfExists("StudentName");
            HideColumnIfExists("ClassID");
            HideColumnIfExists("CourseID");

            // GPA tổng (Score.GetGPA gọi fn_GetGPA trong SQL Server)
            decimal gpa = score.GetGPA(_mssv);
            lblTotalScore.Text = "Total: " + gpa.ToString("0.00");
        }

        private void HideColumnIfExists(string columnName)
        {
            if (dgvScore.Columns.Contains(columnName))
                dgvScore.Columns[columnName].Visible = false;
        }

        // =========================
        // CLICK SCORE ROW
        // =========================
        private void dgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (!dgvScore.Columns.Contains("Grade")) return;

            DataGridViewRow row = dgvScore.Rows[e.RowIndex];
            string ov = row.Cells["Grade"].Value?.ToString();

            lblOverview.Text = "Overview: " + ov;
            lblOverview.ForeColor = ov switch
            {
                "Excellent" => Color.Blue,
                "Good" => Color.Green,
                "Pass" => Color.DarkOrange,
                _ => Color.Red
            };
        }
        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_scoreTable == null) return;

            DataView dv = _scoreTable.DefaultView;

            switch (cboSort.SelectedItem.ToString())
            {
                case "Academic Year":
                    dv.Sort = "AcademicYear DESC";
                    break;

                case "Semester":
                    dv.Sort = "Semester DESC";
                    break;

                case "Course Name":
                    dv.Sort = "CourseName ASC";
                    break;
            }

            dgvScore.DataSource = dv.ToTable();
        }
        private void cboOverviewFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void ApplyFilter()
        {
            if (_scoreTable == null) return;

            string gradeFilter = cboOverviewFilter.SelectedItem?.ToString();
            string searchText = txtSearch.Text.Trim().Replace("'", "''");

            string filter = "";

            // FILTER GRADE
            if (gradeFilter != null && gradeFilter != "All")
            {
                filter = $"Grade = '{gradeFilter}'";
            }

            // SEARCH COURSE NAME
            if (!string.IsNullOrEmpty(searchText))
            {
                string searchFilter = $"CourseName LIKE '%{searchText}%'";

                if (string.IsNullOrEmpty(filter))
                    filter = searchFilter;
                else
                    filter += $" AND {searchFilter}";
            }

            DataView dv = _scoreTable.DefaultView;
            dv.RowFilter = filter;

            dgvScore.DataSource = dv;
        }
    }
}