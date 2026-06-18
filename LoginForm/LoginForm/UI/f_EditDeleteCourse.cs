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
                else if (sort == "Credit Asc") dv.Sort = "Credits ASC";
                else if (sort == "Credit Desc") dv.Sort = "Credits DESC";

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
        // PREREQUISITE COMBO ← bind bằng CourseID (string), loại trừ chính khoá học đang chọn
        // ======================
        private void LoadPrerequisiteCourse(string currentCourseID = "")
        {
            DataTable table = courseModel.GetPrerequisiteCandidates(currentCourseID ?? "");

            DataRow row = table.NewRow();
            row["CourseID"] = DBNull.Value;
            row["CourseDisplay"] = "-- None --";
            table.Rows.InsertAt(row, 0);

            cbo_PrerequisiteCourse.DataSource = table;
            cbo_PrerequisiteCourse.DisplayMember = "CourseDisplay";
            cbo_PrerequisiteCourse.ValueMember = "CourseID";   // ← string
            cbo_PrerequisiteCourse.SelectedIndex = 0;
        }

        // ======================
        // CLICK GRID
        // ======================
        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCourse.Rows[e.RowIndex];

            txt_IDCourse.Text = row.Cells["CourseID"].Value.ToString().Trim();
            txt_NameCourse.Text = row.Cells["CourseName"].Value.ToString();
            txt_Credits.Text = row.Cells["Credits"].Value.ToString();
            txt_TheoryPeriod.Text = row.Cells["TheoryPeriods"].Value.ToString();
            txt_PracticalPeriod.Text = row.Cells["PracticePeriods"].Value.ToString();
            txt_TotalPeriod.Text = row.Cells["TotalPeriods"].Value.ToString();
            chk_IsRequired.Checked = row.Cells["IsRequired"].Value != DBNull.Value &&
                                      Convert.ToBoolean(row.Cells["IsRequired"].Value);
            txt_Description.Text = row.Cells["Description"].Value == DBNull.Value
                                        ? ""
                                        : row.Cells["Description"].Value.ToString();
            txt_IDCourse.Enabled = false;

            // Nạp lại danh sách tiên quyết, loại trừ chính khoá học đang chọn
            LoadPrerequisiteCourse(txt_IDCourse.Text);

            object prereq = row.Cells["PrerequisiteID"].Value;
            if (prereq != DBNull.Value && prereq != null)
                cbo_PrerequisiteCourse.SelectedValue = prereq.ToString().Trim();
            else
                cbo_PrerequisiteCourse.SelectedIndex = 0;
        }

        // ======================
        // AUTO-CALC TOTAL PERIODS (TheoryPeriods + PracticePeriods)
        // ======================
        private void Period_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_TheoryPeriod.Text, out int theory) &&
                int.TryParse(txt_PracticalPeriod.Text, out int practical))
            {
                txt_TotalPeriod.Text = (theory + practical).ToString();
            }
            else
            {
                txt_TotalPeriod.Text = "";
            }
        }

        // ======================
        // UPDATE
        // ======================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IDCourse.Text))
                {
                    MessageBox.Show("Select a course to update!");
                    return;
                }

                if (!int.TryParse(txt_Credits.Text, out int credits) ||
                    !int.TryParse(txt_TheoryPeriod.Text, out int theoryPeriods) ||
                    !int.TryParse(txt_PracticalPeriod.Text, out int practicePeriods))
                {
                    MessageBox.Show("Numeric fields must be valid numbers!");
                    return;
                }

                int totalPeriods = theoryPeriods + practicePeriods;

                string prereqID = null;
                if (cbo_PrerequisiteCourse.SelectedValue != null &&
                    cbo_PrerequisiteCourse.SelectedValue != DBNull.Value)
                {
                    string val = cbo_PrerequisiteCourse.SelectedValue.ToString().Trim();
                    if (val != "")
                        prereqID = val;
                }

                Course c = new Course
                {
                    CourseID = txt_IDCourse.Text.Trim(),
                    CourseName = txt_NameCourse.Text.Trim(),
                    Credits = credits,
                    TotalPeriods = totalPeriods,
                    TheoryPeriods = theoryPeriods,
                    PracticePeriods = practicePeriods,
                    PrerequisiteID = prereqID,           // ← string
                    IsRequired = chk_IsRequired.Checked,
                    Description = txt_Description.Text.Trim()
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
        // DELETE
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
                bool ok = Course.DelCourse(txt_IDCourse.Text.Trim());
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
            txt_NameCourse.Clear();
            txt_Credits.Clear();
            txt_TheoryPeriod.Clear();
            txt_PracticalPeriod.Clear();
            txt_TotalPeriod.Clear();
            chk_IsRequired.Checked = false;
            txt_Description.Clear();
            cbo_PrerequisiteCourse.SelectedIndex = 0;
            txt_IDCourse.Enabled = true;
        }

        private void btnQuit_Click(object sender, EventArgs e) => this.Close();
    }
}