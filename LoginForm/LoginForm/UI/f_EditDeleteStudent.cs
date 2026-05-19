using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
namespace Project_Group6.UI
{
    public partial class f_EditDeleteStudent : Form
    {
        private bool isLoaded = false;
        My_DB db = new My_DB();
        byte[] studentImage = null;
        public f_EditDeleteStudent()
        {
            InitializeComponent();
        }
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            dgvStudents.AutoGenerateColumns = true;

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

            cboGenderChoose.Items.Add("Male");
            cboGenderChoose.Items.Add("Female");

            cboGender.SelectedIndex = 0;

            picStudent.SizeMode =
                PictureBoxSizeMode.StretchImage;
        }

        // ✅ Gọi LoadData sau khi form đã hiển thị hoàn toàn
        private void f_ListStudent_Shown(object sender, EventArgs e)
        {
            LoadData();
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

                dgvStudents.DataSource = dt;

                if (dgvStudents.Columns["Picture"] != null)
                    dgvStudents.Columns["Picture"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // =========================
        // CLICK ROW -> SHOW IMAGE
        // =========================
        private void dgvStudents_CellClick(
     object sender,
     DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row =
                dgvStudents.Rows[e.RowIndex];

            txtMSSV.Text =
                row.Cells["MSSV"].Value.ToString();

            txtFirstName.Text =
                row.Cells["FirstName"]
                .Value.ToString();

            txtLastName.Text =
                row.Cells["LastName"]
                .Value.ToString();

            dtpDob.Value =
                Convert.ToDateTime(
                    row.Cells["Dob"].Value);

            cboGenderChoose.Text =
                row.Cells["Gender"]
                .Value.ToString();

            txtPhone.Text =
                row.Cells["Phone"]
                .Value.ToString();

            txtAddress.Text =
                row.Cells["Address"]
                .Value.ToString();

            txtHomeTown.Text =
                row.Cells["HomeTown"]
                .Value.ToString();

            txtEmail.Text =
                row.Cells["Email"]
                .Value.ToString();

            // KHÔNG CHO SỬA MSSV
            txtMSSV.Enabled = false;

            // LOAD ẢNH
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
            }
            else
            {
                picStudent.Image = null;
            }
        }



        private void btnDelete_Click(
    object sender,
    EventArgs e)
        {
            if (txtMSSV.Text == "")
            {
                MessageBox.Show(
                    "Please select a student!");

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure to delete student "
                    + txtMSSV.Text + "?",
                    "Delete Student",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool success =
                    Student.DeleteStudent(txtMSSV.Text);

                if (success)
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
            }
        }


        private void btnUpdate_Click(
    object sender,
    EventArgs e)
        {
            Student st =
                new Student();

            st.MSSV = txtMSSV.Text;

            st.Fname =
                txtFirstName.Text;

            st.Lname =
                txtLastName.Text;

            st.Dob =
                dtpDob.Value;

            st.Gender =
                cboGenderChoose.Text;

            st.Phone =
                txtPhone.Text;

            st.Address =
                txtAddress.Text;

            st.Hometown =
                txtHomeTown.Text;

            st.Email =
                txtEmail.Text;

            if (picStudent.Image != null)
            {
                MemoryStream ms =
                    new MemoryStream();

                picStudent.Image.Save(
                    ms,
                    picStudent.Image.RawFormat);

                st.Picture =
                    ms.ToArray();
            }

            if (st.EditStudent())
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
        }
        private void btnCancel_Click(
  object sender,
  EventArgs e)
        {
            this.Close();
        }
        private void btnEditImage_Click(
    object sender,
    EventArgs e)
        {
            OpenFileDialog ofd =
                new OpenFileDialog();

            ofd.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Đọc file thành byte[]
                studentImage =
                    File.ReadAllBytes(ofd.FileName);

                // Hiển thị ảnh
                MemoryStream ms =
                    new MemoryStream(studentImage);

                picStudent.Image =
                    Image.FromStream(ms);

                MessageBox.Show(
                    "Image loaded: "
                    + studentImage.Length);
            }
        }
    }
}
