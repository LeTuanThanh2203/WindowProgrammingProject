using System;
using System.Data;
using System.Windows.Forms;
using Project_Group6.Models;

namespace LoginForm
{
    public partial class f_EditDeleteCourse : Form
    {
        private bool isLoaded = false;
        Course courseModel = new Course();

        public f_EditDeleteCourse()
        {
            InitializeComponent();
        }

        private void f_EditDeleteCourse_Load(object sender, EventArgs e)
        {
            cboSort.Items.Add("Name A-Z");
            cboSort.Items.Add("Name Z-A");
            cboSort.Items.Add("Credit Asc");
            cboSort.Items.Add("Credit Desc");
            cboSort.SelectedIndex = 0;

            LoadPrerequisiteCourse();
            isLoaded = true;
        }

        private void f_EditDeleteCourse_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        // ======================
        // LOAD DATA
        // ======================
        private void LoadData()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                DataTable dt = string.IsNullOrEmpty(keyword)
                    ? courseModel.GetCourse()
                    : courseModel.SearchCourse(keyword);

                DataView dv = dt.DefaultView;
                string sort = cboSort.SelectedItem?.ToString();

                if (sort == "Name A-Z") dv.Sort = "CourseName ASC";
                else if (sort == "Name Z-A") dv.Sort = "CourseName DESC";
                else if (sort == "Credit Asc") dv.Sort = "CreditHour ASC";
                else if (sort == "Credit Desc") dv.Sort = "CreditHour DESC";

                dgvCourse.DataSource = dv.ToTable();
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearForm();
        }

        private void FormatGrid()
        {
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ======================
        // PREREQUISITE COMBO  ← bind bằng CourseCode (string)
        // ======================
        private void LoadPrerequisiteCourse()
        {
            DataTable table = courseModel.GetPrerequisiteCourse();

            DataRow row = table.NewRow();
            row["CourseCode"] = DBNull.Value;
            row["CourseDisplay"] = "-- None --";
            table.Rows.InsertAt(row, 0);

            cbo_PrerequisiteCourse.DataSource = table;
            cbo_PrerequisiteCourse.DisplayMember = "CourseDisplay";
            cbo_PrerequisiteCourse.ValueMember = "CourseCode";   // ← string
            cbo_PrerequisiteCourse.SelectedIndex = 0;
        }

        // ======================
        // CLICK GRID
        // ======================
        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCourse.Rows[e.RowIndex];

            txt_IDCourse.Text = row.Cells["CourseID"].Value.ToString();
            txt_CourseCode.Text = row.Cells["CourseCode"].Value.ToString().Trim();
            txt_NameCourse.Text = row.Cells["CourseName"].Value.ToString();
            txt_CreditHour.Text = row.Cells["CreditHour"].Value.ToString();
            txt_TheoryPeriod.Text = row.Cells["TheoryPeriod"].Value.ToString();
            txt_PracticalPeriod.Text = row.Cells["PracticalPeriod"].Value.ToString();
            txt_Week.Text = row.Cells["Week"].Value.ToString();
            txt_Overview.Text = row.Cells["Overview"].Value == DBNull.Value
                                        ? ""
                                        : row.Cells["Overview"].Value.ToString();
            txt_IDCourse.Enabled = false;

            // Prerequisite — so sánh bằng CourseCode string
            object prereq = row.Cells["PrerequisiteCourseCode"].Value;
            if (prereq != DBNull.Value && prereq != null)
                cbo_PrerequisiteCourse.SelectedValue = prereq.ToString().Trim();
            else
                cbo_PrerequisiteCourse.SelectedIndex = 0;
        }

        // ======================
        // UPDATE
        // ======================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_CreditHour.Text, out int creditHour) ||
                    !int.TryParse(txt_TheoryPeriod.Text, out int theoryPeriod) ||
                    !int.TryParse(txt_PracticalPeriod.Text, out int practicalPeriod) ||
                    !int.TryParse(txt_Week.Text, out int week))
                {
                    MessageBox.Show("Numeric fields must be valid numbers!");
                    return;
                }

                string prereqCode = null;
                if (cbo_PrerequisiteCourse.SelectedValue != null &&
                    cbo_PrerequisiteCourse.SelectedValue != DBNull.Value)
                {
                    string val = cbo_PrerequisiteCourse.SelectedValue.ToString().Trim();
                    if (val != "")
                        prereqCode = val;
                }

                Course c = new Course
                {
                    CourseID = Convert.ToInt32(txt_IDCourse.Text.Trim()),
                    CourseCode = txt_CourseCode.Text.Trim(),
                    CourseName = txt_NameCourse.Text.Trim(),
                    CreditHour = creditHour,
                    TheoryPeriod = theoryPeriod,
                    PracticalPeriod = practicalPeriod,
                    Overview = txt_Overview.Text.Trim(),
                    PrerequisiteCourseCode = prereqCode,   // ← string
                    Week = week
                };

                if (c.EditCourse())
                {
                    MessageBox.Show("Updated successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        // ======================
        // DELETE (không đổi)
        // ======================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_IDCourse.Text))
            {
                MessageBox.Show("Select a course!");
                return;
            }

            if (MessageBox.Show("Delete this course?", "Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool ok = Course.DelCourse(Convert.ToInt32(txt_IDCourse.Text));
                MessageBox.Show(ok ? "Deleted!" : "Delete failed!");
                if (ok) LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (isLoaded) LoadData();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded) LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboSort.SelectedIndex = 0;
            LoadData();
        }

        private void ClearForm()
        {
            txt_IDCourse.Clear();
            txt_CourseCode.Clear();
            txt_NameCourse.Clear();
            txt_CreditHour.Clear();
            txt_TheoryPeriod.Clear();
            txt_PracticalPeriod.Clear();
            txt_Week.Clear();
            txt_Overview.Clear();
            cbo_PrerequisiteCourse.SelectedIndex = 0;
            txt_IDCourse.Enabled = true;
        }

        private void btnQuit_Click(object sender, EventArgs e) => this.Close();
    }
}