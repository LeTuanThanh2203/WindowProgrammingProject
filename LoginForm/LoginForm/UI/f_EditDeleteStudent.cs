using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_Group6.UI
{
    public partial class f_EditDeleteStudent : Form
    {
        private bool _isLoaded = false;
        private byte[] studentImage = null;

        public f_EditDeleteStudent()
        {
            InitializeComponent();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            dgvStudents.AutoGenerateColumns = true;

            cboGender.Items.AddRange(new[] { "All", "Male", "Female" });
            cboGender.SelectedIndex = 0;

            cboSort.Items.AddRange(new[]
            {
                "Name A-Z", "Name Z-A",
                "ID Asc",   "ID Desc"    // đổi "MSSV" → "ID" theo schema
            });
            cboSort.SelectedIndex = 0;

            cboGenderChoose.Items.AddRange(new[] { "Male", "Female" });
            cboGenderChoose.SelectedIndex = 0;

            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;

            _isLoaded = true;
        }

        private void f_ListStudent_Shown(object sender, EventArgs e) => LoadData();

        // ================= LOAD DATA =================
        private void LoadData()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                string gender = cboGender.SelectedItem?.ToString();
                string sort = cboSort.SelectedItem?.ToString();

                // Schema mới: cột ID thay MSSV, không có HomeTown
                string query = "SELECT * FROM Student WHERE 1=1";

                if (!string.IsNullOrEmpty(keyword))
                    query += @" AND (ID LIKE @search
                                 OR FirstName LIKE @search
                                 OR LastName  LIKE @search
                                 OR Phone     LIKE @search
                                 OR Email     LIKE @search
                                 OR Address   LIKE @search)";

                if (!string.IsNullOrEmpty(gender) && gender != "All")
                    query += " AND Gender = @gender";

                query += sort switch
                {
                    "Name A-Z" => " ORDER BY FirstName ASC",
                    "Name Z-A" => " ORDER BY FirstName DESC",
                    "ID Asc" => " ORDER BY ID ASC",
                    "ID Desc" => " ORDER BY ID DESC",
                    _ => " ORDER BY ID ASC"
                };

                using (var db = new My_DB())
                {
                    SqlConnection conn = db.getConnection;
                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    var cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(keyword))
                        cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");

                    if (!string.IsNullOrEmpty(gender) && gender != "All")
                        cmd.Parameters.AddWithValue("@gender", gender);

                    var dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    dgvStudents.DataSource = dt;

                    if (dgvStudents.Columns["Picture"] != null)
                        dgvStudents.Columns["Picture"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isLoaded) LoadData();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoaded) LoadData();
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoaded) LoadData();
        }

        // ================= CLICK ROW =================
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvStudents.Rows[e.RowIndex];

            // Schema mới: cột ID thay MSSV
            txtID.Text = row.Cells["ID"].Value?.ToString();
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["Dob"].Value?.ToString(), out DateTime dob))
                dtpDob.Value = dob;

            cboGenderChoose.Text = row.Cells["Gender"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            // Không còn HomeTown
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            txtID.Enabled = false;   // Không cho sửa ID

            // Load ảnh
            var picCell = row.Cells["Picture"].Value;
            if (picCell != null && picCell != DBNull.Value)
            {
                byte[] img = (byte[])picCell;
                picStudent.Image = Image.FromStream(new MemoryStream(img));
            }
            else
            {
                picStudent.Image = null;
            }
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select a student!");
                return;
            }

            if (MessageBox.Show(
                    $"Are you sure to delete student {txtID.Text}?",
                    "Delete Student",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            bool ok = Student.DeleteStudent(txtID.Text);

            MessageBox.Show(ok ? "Deleted successfully!" : "Delete failed!");

            if (ok) LoadData();
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var st = new Student
            {
                // Schema mới: ID, FirstName, LastName, Address (không có Hometown)
                ID = txtID.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Dob = dtpDob.Value,
                Gender = cboGenderChoose.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text
            };

            if (picStudent.Image != null)
            {
                using var ms = new MemoryStream();
                picStudent.Image.Save(ms, picStudent.Image.RawFormat);
                st.Picture = ms.ToArray();
            }

            bool ok = st.EditStudent();
            MessageBox.Show(ok ? "Updated successfully!" : "Update failed!");

            if (ok) LoadData();
        }

        // ================= CANCEL =================
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        // ================= EDIT IMAGE =================
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                studentImage = File.ReadAllBytes(ofd.FileName);
                picStudent.Image = Image.FromStream(new MemoryStream(studentImage));
                MessageBox.Show("Image loaded: " + studentImage.Length + " bytes");
            }
        }
    }
}