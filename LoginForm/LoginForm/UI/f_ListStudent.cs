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
        private readonly ReportExportService _exportService = new ReportExportService();

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

        private void f_ListStudent_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        // =========================
        // CLICK ROW -> SHOW INFO
        // =========================
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContacts.Rows[e.RowIndex];

                lblID.Text = row.Cells["ID"].Value.ToString();
                lblFirstname.Text = row.Cells["FirstName"].Value.ToString();
                lblLastname.Text = row.Cells["LastName"].Value.ToString();
                lblDob.Text = Convert.ToDateTime(row.Cells["Dob"].Value).ToString("dd/MM/yyyy");
                lblGender.Text = row.Cells["Gender"].Value.ToString();
                lblPhone.Text = row.Cells["Phone"].Value.ToString();
                lblAddress.Text = row.Cells["Address"].Value.ToString();
                lblEmail.Text = row.Cells["Email"].Value.ToString();

                if (row.Cells["Picture"].Value != DBNull.Value)
                {
                    byte[] img = (byte[])row.Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(img);
                    picContact.Image = Image.FromStream(ms);
                    picContact.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picContact.Image = null;
                }
            }

            btnViewScore.Enabled = true;
        }

        // =========================
        // LOAD DATA
        // =========================
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
                        OR LastName  LIKE @search)";
                }

                if (!string.IsNullOrEmpty(gender) && gender != "All")
                    query += " AND Gender = @gender";

                if (sort == "Name A-Z") query += " ORDER BY FirstName ASC";
                else if (sort == "Name Z-A") query += " ORDER BY FirstName DESC";
                else if (sort == "ID Asc") query += " ORDER BY ID ASC";
                else if (sort == "ID Desc") query += " ORDER BY ID DESC";

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

        // =========================
        // GET EXPORT DATA (dùng chung cho PDF & Excel)
        // =========================
        private DataTable GetExportData()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                string gender = cboGender.SelectedItem?.ToString();
                string sort = cboSort.SelectedItem?.ToString();

                // Query KHÔNG dùng alias — tránh lỗi "Column does not belong to table"
                string query = @"SELECT ID, FirstName, LastName, Dob, Gender, Phone, Email, Address
                                 FROM Student WHERE 1=1";

                if (!string.IsNullOrEmpty(keyword))
                    query += @" AND (CAST(ID AS NVARCHAR) LIKE @search
                                OR FirstName LIKE @search
                                OR LastName  LIKE @search)";

                if (!string.IsNullOrEmpty(gender) && gender != "All")
                    query += " AND Gender = @gender";

                if (sort == "Name A-Z") query += " ORDER BY FirstName ASC";
                else if (sort == "Name Z-A") query += " ORDER BY FirstName DESC";
                else if (sort == "ID Asc") query += " ORDER BY ID ASC";
                else if (sort == "ID Desc") query += " ORDER BY ID DESC";
                else query += " ORDER BY ID ASC";

                SqlConnection conn = db.getConnection;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(keyword))
                    cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");
                if (!string.IsNullOrEmpty(gender) && gender != "All")
                    cmd.Parameters.AddWithValue("@gender", gender);

                DataTable raw = new DataTable();
                new SqlDataAdapter(cmd).Fill(raw);

                // Build bảng export với tên cột đẹp + format ngày — tránh alias gây lỗi
                DataTable export = new DataTable();
                export.Columns.Add("Student ID", typeof(string));
                export.Columns.Add("First Name", typeof(string));
                export.Columns.Add("Last Name", typeof(string));
                export.Columns.Add("Date of Birth", typeof(string));
                export.Columns.Add("Gender", typeof(string));
                export.Columns.Add("Phone", typeof(string));
                export.Columns.Add("Email", typeof(string));
                export.Columns.Add("Address", typeof(string));

                foreach (DataRow r in raw.Rows)
                {
                    string dob = r["Dob"] != DBNull.Value
                        ? Convert.ToDateTime(r["Dob"]).ToString("dd/MM/yyyy")
                        : "";

                    export.Rows.Add(
                        r["ID"]?.ToString(),
                        r["FirstName"]?.ToString(),
                        r["LastName"]?.ToString(),
                        dob,
                        r["Gender"]?.ToString(),
                        r["Phone"]?.ToString(),
                        r["Email"]?.ToString(),
                        r["Address"]?.ToString()
                    );
                }

                return export;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing data: " + ex.Message);
                return new DataTable();
            }
        }

        // =========================
        // EXPORT BUTTON
        // =========================
        private void btnExport_Click(object sender, EventArgs e)
        {
            // Lấy thẳng data gốc từ DB, không cần build lại DataTable
            DataTable exportData = GetRawExportData();

            if (exportData == null || exportData.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dlg = new ExportFormatDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                if (dlg.SelectedFormat == "PDF")
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "PDF Files|*.pdf";
                        sfd.FileName = "StudentList.pdf";
                        if (sfd.ShowDialog() != DialogResult.OK) return;

                        try
                        {
                            bool ok = _exportService.ExportStudentsToPdf(
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
                else
                {
                    using (var sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "Excel Files|*.xlsx";
                        sfd.FileName = "StudentList.xlsx";
                        if (sfd.ShowDialog() != DialogResult.OK) return;

                        try
                        {
                            bool ok = _exportService.ExportStudentsToExcel(exportData, sfd.FileName);
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

        // Thay GetExportData() cũ bằng method này — trả về DataTable với tên cột gốc
        private DataTable GetRawExportData()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                string gender = cboGender.SelectedItem?.ToString();
                string sort = cboSort.SelectedItem?.ToString();

                string query = @"SELECT ID, FirstName, LastName, Dob, Gender, Phone, Email
                         FROM Student WHERE 1=1";

                if (!string.IsNullOrEmpty(keyword))
                    query += @" AND (CAST(ID AS NVARCHAR) LIKE @search
                        OR FirstName LIKE @search
                        OR LastName  LIKE @search)";

                if (!string.IsNullOrEmpty(gender) && gender != "All")
                    query += " AND Gender = @gender";

                if (sort == "Name A-Z") query += " ORDER BY FirstName ASC";
                else if (sort == "Name Z-A") query += " ORDER BY FirstName DESC";
                else if (sort == "ID Asc") query += " ORDER BY ID ASC";
                else if (sort == "ID Desc") query += " ORDER BY ID DESC";
                else query += " ORDER BY ID ASC";

                SqlConnection conn = db.getConnection;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(keyword))
                    cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");
                if (!string.IsNullOrEmpty(gender) && gender != "All")
                    cmd.Parameters.AddWithValue("@gender", gender);

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing data: " + ex.Message);
                return new DataTable();
            }
        }

        // =========================
        // OTHER BUTTONS
        // =========================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cboGender.SelectedIndex = 0;
            cboSort.SelectedIndex = 0;
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new f_AddStudent().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new f_EditDeleteStudent().ShowDialog();
        }

        private void dgvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                new f_EditDeleteStudent().ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            LoadData();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            LoadData();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            LoadData();
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            string mssv = dgvContacts.CurrentRow.Cells["ID"].Value.ToString();
            new f_ScoreView(mssv).ShowDialog();
        }

        public void OpenAddStudent() => new f_AddStudent().ShowDialog();
        public void OpenEditStudent() => new f_EditDeleteStudent().ShowDialog();
    }
}