using Microsoft.Data.SqlClient;
using Project_Group6.UI;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_ListStudent : Form
    {

        My_DB db = new My_DB();
        private bool isLoaded = false;
        public f_ListStudent()
        {

            InitializeComponent();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            dgvStudent.AutoGenerateColumns = true;

            cboGender.Items.Add("All");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.SelectedIndex = 0;

            cboSort.Items.Add("Name A-Z");
            cboSort.Items.Add("Name Z-A");
            cboSort.Items.Add("MSSV Asc");
            cboSort.Items.Add("MSSV Desc");
            cboSort.SelectedIndex = 0;

            isLoaded = true;
        }

        // ✅ Gọi LoadData sau khi form đã hiển thị hoàn toàn
        private void f_ListStudent_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        // =========================
        // LOAD STUDENT
        // =========================
        private void LoadStudent()
        {
            try
            {
                string query =
                    "SELECT * FROM Student";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        query,
                        db.getConnection);

                DataTable table =
                    new DataTable();

                adapter.Fill(table);

                dgvStudent.DataSource = table;

                // Hide picture column
                if (dgvStudent.Columns["Picture"] != null)
                {
                    dgvStudent.Columns["Picture"]
                        .Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblID.Text = "";
            lblFirstname.Text = "";
            lblLastname.Text = "";
            lblDob.Text = "";
            lblGender.Text = "";
            lblPhone.Text = "";
            lblAddress.Text = "";
            lblEmail.Text = "";
        }

        // =========================
        // CLICK ROW -> SHOW IMAGE
        // =========================
        private void dgvStudent_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvStudent.Rows[e.RowIndex];

                lblID.Text =
          row.Cells["MSSV"].Value.ToString();

                lblFirstname.Text =
                    row.Cells["FirstName"].Value.ToString();

                lblLastname.Text =
                    row.Cells["LastName"].Value.ToString();

                lblDob.Text =
                    Convert.ToDateTime(
                        row.Cells["Dob"].Value)
                        .ToString("dd/MM/yyyy");

                lblGender.Text =
                    row.Cells["Gender"].Value.ToString();

                lblPhone.Text =
                    row.Cells["Phone"].Value.ToString();

                lblAddress.Text =
                    row.Cells["Address"].Value.ToString();

                lblEmail.Text =
                    row.Cells["Email"].Value.ToString();

                // Hien thi anh neu co, neu khong co thi xoa anh cu
                if (row.Cells["Picture"].Value
                    != DBNull.Value)
                {
                    byte[] img =
                        (byte[])row.Cells["Picture"]
                        .Value;

                    MemoryStream ms =
                        new MemoryStream(img);

                    picStudent.Image =
                        Image.FromStream(ms);
                    picStudent.SizeMode =
                    PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picStudent.Image = null;
                }
            }
        }


        // =========================
        // REFRESH BUTTON
        // =========================
        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Text = "";
            cboGender.SelectedIndex = 0;
            cboSort.SelectedIndex = 0;
            LoadData(); // ← thay vì LoadStudent()
        }

        // =========================
        // CLOSE BUTTON
        // =========================
        private void btnClose_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(
         object sender,
         EventArgs e)
        {
            f_AddStudent addStudent =
              new f_AddStudent();

            addStudent.Show();
        }
        private void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                string keyword = txtSearch.Text.Trim();
                string gender = cboGender.SelectedItem?.ToString();
                string sort = cboSort.SelectedItem?.ToString();

                string query = "SELECT * FROM Student WHERE 1=1";

                if (!string.IsNullOrEmpty(keyword))
                {
                    query += @" AND (CAST(MSSV AS NVARCHAR) LIKE @search
                        OR FirstName LIKE @search
                        OR LastName LIKE @search)";
                }

                if (!string.IsNullOrEmpty(gender) && gender != "All")
                {
                    query += " AND Gender = @gender";
                }

                if (sort == "Name A-Z") query += " ORDER BY FirstName ASC";
                else if (sort == "Name Z-A") query += " ORDER BY FirstName DESC";
                else if (sort == "MSSV Asc") query += " ORDER BY MSSV ASC";
                else if (sort == "MSSV Desc") query += " ORDER BY MSSV DESC";

                // ✅ Mở connection thủ công
                SqlConnection conn = db.getConnection;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(keyword))
                    cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");

                if (!string.IsNullOrEmpty(gender) && gender != "All")
                    cmd.Parameters.AddWithValue("@gender", gender);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvStudent.DataSource = dt;

                if (dgvStudent.Columns["Picture"] != null)
                    dgvStudent.Columns["Picture"].Visible = false;

                lblTotal.Text = "Total Students: " + dt.Rows.Count;

                dgvStudent.AllowUserToAddRows = false;
                dgvStudent.RowHeadersVisible = false;
                dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Reset labels
                lblID.Text = lblFirstname.Text = lblLastname.Text = "";
                lblDob.Text = lblGender.Text = lblPhone.Text = "";
                lblAddress.Text = lblEmail.Text = "";
                picStudent.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(
        object sender,
        EventArgs e)
        {

            if (!isLoaded)
            {
                return;
            }

            LoadData();
        
        }
        private void cboGender_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            if (!isLoaded)
            {
                return;
            }

            LoadData();
        }
        private void cboSort_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            if (!isLoaded)
            {
                return;
            }

            LoadData();
        }
        private void btnEdit_Click(
          object sender,
        EventArgs e)
        {
            f_EditDeleteStudent editdeleteStudent =
              new f_EditDeleteStudent();

            editdeleteStudent.ShowDialog();
        
        }


        public void OpenAddStudent()
        {
            f_AddStudent add =
                new f_AddStudent();

            add.ShowDialog();
        }
        public void OpenEditStudent()
        {
            f_EditDeleteStudent edit =
                new f_EditDeleteStudent();

            edit.ShowDialog();
        }

    }




}
