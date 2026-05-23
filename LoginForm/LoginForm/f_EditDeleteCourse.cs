using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;

namespace Project_Group6
{
    public partial class f_EditDeleteCourse : Form
    {
        private bool isLoaded = false;

        My_DB db = new My_DB();
        public f_EditDeleteCourse()
        {
            InitializeComponent();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void f_EditDeleteCourse_Load(
            object sender,
            EventArgs e)
        {
            dgvCourse.AutoGenerateColumns = true;

            cboSort.Items.Add("Name A-Z");
            cboSort.Items.Add("Name Z-A");
            cboSort.Items.Add("Credit Asc");
            cboSort.Items.Add("Credit Desc");

            cboSort.SelectedIndex = 0;

            LoadPrerequisiteCourse();

            isLoaded = true;
        }

        // =========================
        // FORM SHOWN
        // =========================
        private void f_EditDeleteCourse_Shown(
            object sender,
            EventArgs e)
        {
            LoadData();
        }

        // =========================
        // LOAD DATA GRIDVIEW
        // =========================
        private void LoadData()
        {
            try
            {
                DataTable dt =
                    new DataTable();

                string keyword =
                    txtSearch.Text.Trim();

                string sort =
                    cboSort.SelectedItem?.ToString();

                string query =
                    @"SELECT
                        CourseID,
                        CourseName,
                        CreditHour,
                        Overview,
                        PrerequisiteCourseID,
                        TheoryPeriod,
                        PracticalPeriod
                    FROM Course
                    WHERE 1=1";

                // SEARCH
                if (!string.IsNullOrEmpty(keyword))
                {
                    query += @"
                    AND
                    (
                        CourseID LIKE @search
                        OR CourseName LIKE @search
                    )";
                }

                // SORT
                if (sort == "Name A-Z")
                {
                    query +=
                        " ORDER BY CourseName ASC";
                }
                else if (sort == "Name Z-A")
                {
                    query +=
                        " ORDER BY CourseName DESC";
                }
                else if (sort == "Credit Asc")
                {
                    query +=
                        " ORDER BY CreditHour ASC";
                }
                else if (sort == "Credit Desc")
                {
                    query +=
                        " ORDER BY CreditHour DESC";
                }

                SqlConnection conn =
                    db.getConnection;

                if (conn.State
                    != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(keyword))
                {
                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" + keyword + "%");
                }

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                dgvCourse.DataSource = dt;

                dgvCourse.AllowUserToAddRows = false;

                dgvCourse.RowHeadersVisible = false;

                dgvCourse.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvCourse.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_IDCourse.Clear();

            txt_NameCourse.Clear();

            txt_CreditHour.Clear();

            txt_TheoryPeriod.Clear();

            txt_PracticalPeriod.Clear();

            txt_Overview.Clear();

            cbo_PrerequisiteCourse.SelectedIndex = 0;

            txt_IDCourse.Enabled = true;
        }

        // =========================
        // LOAD COMBOBOX
        // =========================
        private void LoadPrerequisiteCourse()
        {
            try
            {
                string query = @"
                SELECT
                    CourseID,
                    CourseID + ' - ' + CourseName
                    AS CourseDisplay
                FROM Course";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                SqlDataAdapter adapter =
                    new SqlDataAdapter(cmd);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                DataRow row =
                    table.NewRow();

                row["CourseID"] =
                    DBNull.Value;

                row["CourseDisplay"] =
                    "-- None --";

                table.Rows.InsertAt(row, 0);

                cbo_PrerequisiteCourse
                    .DataSource = table;

                cbo_PrerequisiteCourse
                    .DisplayMember =
                    "CourseDisplay";

                cbo_PrerequisiteCourse
                    .ValueMember =
                    "CourseID";

                cbo_PrerequisiteCourse
                    .SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // CLICK DATAGRIDVIEW
        // =========================
        private void dgvCourse_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvCourse.Rows[e.RowIndex];

            txt_IDCourse.Text =
                row.Cells["CourseID"]
                .Value.ToString();

            txt_NameCourse.Text =
                row.Cells["CourseName"]
                .Value.ToString();

            txt_CreditHour.Text =
                row.Cells["CreditHour"]
                .Value.ToString();

            txt_TheoryPeriod.Text =
                row.Cells["TheoryPeriod"]
                .Value.ToString();

            txt_PracticalPeriod.Text =
                row.Cells["PracticalPeriod"]
                .Value.ToString();

            txt_Overview.Text =
                row.Cells["Overview"]
                .Value.ToString();

            // KHÔNG CHO SỬA ID
            txt_IDCourse.Enabled = false;

            // PREREQUISITE
            if (row.Cells["PrerequisiteCourseID"]
                .Value != DBNull.Value)
            {
                cbo_PrerequisiteCourse
                    .SelectedValue =
                    row.Cells[
                        "PrerequisiteCourseID"]
                    .Value.ToString();
            }
            else
            {
                cbo_PrerequisiteCourse
                    .SelectedIndex = 0;
            }
        }

        // =========================
        // UPDATE
        // =========================
        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string query = @"
                UPDATE Course
                SET
                    CourseName = @CourseName,
                    CreditHour = @CreditHour,
                    Overview = @Overview,
                    PrerequisiteCourseID =
                        @PrerequisiteCourseID,
                    TheoryPeriod = @TheoryPeriod,
                    PracticalPeriod =
                        @PracticalPeriod
                WHERE CourseID = @CourseID";

                SqlCommand cmd =
                    new SqlCommand(
                        query,
                        db.getConnection);

                cmd.Parameters.AddWithValue(
                    "@CourseID",
                    txt_IDCourse.Text);

                cmd.Parameters.AddWithValue(
                    "@CourseName",
                    txt_NameCourse.Text);

                cmd.Parameters.AddWithValue(
                    "@CreditHour",
                    Convert.ToInt32(
                        txt_CreditHour.Text));

                cmd.Parameters.AddWithValue(
                    "@Overview",
                    txt_Overview.Text);

                cmd.Parameters.AddWithValue(
                    "@TheoryPeriod",
                    Convert.ToInt32(
                        txt_TheoryPeriod.Text));

                cmd.Parameters.AddWithValue(
                    "@PracticalPeriod",
                    Convert.ToInt32(
                        txt_PracticalPeriod.Text));

                // PREREQUISITE
                if (cbo_PrerequisiteCourse
                    .SelectedValue
                    == DBNull.Value)
                {
                    cmd.Parameters.AddWithValue(
                        "@PrerequisiteCourseID",
                        DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue(
                        "@PrerequisiteCourseID",
                        cbo_PrerequisiteCourse
                        .SelectedValue);
                }

                db.openConnection();

                int result =
                    cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show(
                        "Updated successfully!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show(
                        "Update failed!");
                }

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================
        // DELETE
        // =========================
        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (txt_IDCourse.Text == "")
            {
                MessageBox.Show(
                    "Please select a course!");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure to delete course "
                    + txt_IDCourse.Text + "?",
                    "Delete Course",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = @"
                    DELETE FROM Course
                    WHERE CourseID = @CourseID";

                    SqlCommand cmd =
                        new SqlCommand(
                            query,
                            db.getConnection);

                    cmd.Parameters.AddWithValue(
                        "@CourseID",
                        txt_IDCourse.Text);

                    db.openConnection();

                    int rs =
                        cmd.ExecuteNonQuery();

                    if (rs > 0)
                    {
                        MessageBox.Show(
                            "Deleted successfully!");

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Delete failed!");
                    }

                    db.closeConnection();
                }
                catch (SqlException)
                {
                    MessageBox.Show(
                        "This course is being used as prerequisite!");
                }
            }
        }

        // =========================
        // CANCEL
        // =========================
        private void btnQuit_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
        private void btnRefresh_Click(
    object sender,
    EventArgs e)
        {
            txtSearch.Text = "";

            cboSort.SelectedIndex = 0;

            LoadData();
        }

        // =========================
        // SEARCH
        // =========================
        private void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            if (isLoaded)
            {
                LoadData();
            }
        }

        // =========================
        // SORT
        // =========================
        private void cboSort_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (isLoaded)
            {
                LoadData();
            }
        }
    }
}
