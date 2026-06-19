using Microsoft.Data.SqlClient;
using Project_Group6;
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
        private PaginationHelper _pager;

        public f_ListStudent()
        {
            InitializeComponent();
            dgvContacts.CellDoubleClick += dgvStudent_CellDoubleClick;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            dgvContacts.AutoGenerateColumns = true;

            cboGender.Items.Add("All");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.SelectedIndex = 0;

            cboSort.Items.Add("Name A-Z");
            cboSort.Items.Add("Name Z-A");
            cboSort.Items.Add("ID Asc");
            cboSort.Items.Add("ID Desc");
            cboSort.SelectedIndex = 0;

            _pager = new PaginationHelper(
                pageTable => {
                    dgvContacts.DataSource = pageTable;
                    if (dgvContacts.Columns["Picture"] != null)
                        dgvContacts.Columns["Picture"].Visible = false;
                },
                lblPageInfo,
                lblTotal,
                btnFirst,
                btnPrev,
                btnNext,
                btnLast,
                cboPageSize
            );

            isLoaded = true;
            btnViewScore.Enabled = false;
        }

        // ✅ Gọi LoadData sau khi form đã hiển thị hoàn toàn
        private void f_ListStudent_Shown(object sender, EventArgs e)
        {
            LoadData();
  
        }

        // =========================
        // LOAD STUDENT
        // =========================
     

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
                    dgvContacts.Rows[e.RowIndex];

                lblID.Text =
          row.Cells["ID"].Value.ToString();

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

                    picContact.Image =
                        Image.FromStream(ms);
                    picContact.SizeMode =
                    PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picContact.Image = null;
                }
            }


            btnViewScore.Enabled = true;
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
        private void btnAdd_Click(
         object sender,
         EventArgs e)
        {
            f_AddStudent addStudent =
              new f_AddStudent();

            addStudent.ShowDialog();
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
                    query += @" AND (CAST(ID AS NVARCHAR) LIKE @search
                        OR FirstName LIKE @search
                        OR LastName LIKE @search)";
                }

                if (!string.IsNullOrEmpty(gender) && gender != "All")
                {
                    query += " AND Gender = @gender";
                }

                if (sort == "Name A-Z") query += " ORDER BY FirstName ASC";
                else if (sort == "Name Z-A") query += " ORDER BY FirstName DESC";
                else if (sort == "ID Asc") query += " ORDER BY ID ASC";
                else if (sort == "ID Desc") query += " ORDER BY ID DESC";

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

                UIStyleHelper.StyleDataGridView(dgvContacts);
                _pager.SetData(dt);

                // Reset labels
                lblID.Text = lblFirstname.Text = lblLastname.Text = "";
                lblDob.Text = lblGender.Text = lblPhone.Text = "";
                lblAddress.Text = lblEmail.Text = "";
                picContact.Image = null;
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
        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new f_EditDeleteStudent().ShowDialog();
        
            }
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
        private void btnViewScore_Click(object sender, EventArgs e)
        {
            string mssv =
                dgvContacts.CurrentRow.Cells["ID"].Value.ToString();

            f_ScoreView frm = new f_ScoreView(mssv);
            frm.ShowDialog();
        }

        //private void btnExportWord_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(lblID.Text))
        //    {
        //        MessageBox.Show("Please select a student first.");
        //        return;
        //    }

        //    Print print = new Print();

        //    print.ExportScoreStudent(
        //        lblID.Text,
        //        "Semester 1",
        //        "2025-2026");
        //}
    }
}
