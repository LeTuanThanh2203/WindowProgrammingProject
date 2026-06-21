using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_EditDeleteHR : Form
    {
        private bool _isLoaded = false;
        private byte[] hrImage = null;

        public f_EditDeleteHR()
        {
            InitializeComponent();
        }

        private void ManageHR_Load(object sender, EventArgs e)
        {
            dgvHR.AutoGenerateColumns = true;

            cboGender.Items.AddRange(new[] { "All", "Male", "Female" });
            cboGender.SelectedIndex = 0;

            cboSort.Items.AddRange(new[]
            {
                "Name A-Z", "Name Z-A",
                "ID Asc",   "ID Desc"
            });
            cboSort.SelectedIndex = 0;

            cboGenderChoose.Items.AddRange(new[] { "Male", "Female" });
            cboGenderChoose.SelectedIndex = 0;

            picHR.SizeMode = PictureBoxSizeMode.StretchImage;

            _isLoaded = true;
        }

        private void f_ListHR_Shown(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                string gender = cboGender.SelectedItem?.ToString();
                string sort = cboSort.SelectedItem?.ToString();

                string query = "SELECT * FROM HR WHERE 1=1";

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
                    dgvHR.DataSource = dt;
                    UIStyleHelper.StyleDataGridView(dgvHR);

                    if (dgvHR.Columns["Picture"] != null)
                        dgvHR.Columns["Picture"].Visible = false;
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

        private void dgvHR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvHR.Rows[e.RowIndex];

            txtID.Text = row.Cells["ID"].Value?.ToString();
            txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = row.Cells["LastName"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["Dob"].Value?.ToString(), out DateTime dob))
                dtpDob.Value = dob;

            cboGenderChoose.Text = row.Cells["Gender"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
            txtAddress.Text = row.Cells["Address"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            // Load photo
            var picCell = row.Cells["Picture"].Value;
            if (picCell != null && picCell != DBNull.Value)
            {
                hrImage = (byte[])picCell;
                picHR.Image = Image.FromStream(new MemoryStream(hrImage));
            }
            else
            {
                picHR.Image = null;
                hrImage = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select an HR record!");
                return;
            }

            if (MessageBox.Show(
                    $"Are you sure to delete HR {txtID.Text}?",
                    "Delete HR",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            string id = txtID.Text.Trim();

            bool ok = HR.DeleteHR(id);
            if (ok)
            {
                // Delete corresponding login account
                try
                {
                    using (var db = new My_DB())
                    {
                        db.openConnection();
                        var cmd = new SqlCommand("DELETE FROM DataLoginForm WHERE UserName = @user", db.getConnection);
                        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = id;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch { }

                MessageBox.Show("Deleted successfully!");
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Delete failed! HR might be assigned to courses.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please select an HR record to update!");
                return;
            }

            var updatedHr = new HR
            {
                ID = txtID.Text,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Dob = dtpDob.Value,
                Gender = cboGenderChoose.Text,
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Picture = hrImage
            };

            bool ok = updatedHr.EditHR();
            if (ok)
            {
                // Also update email in DataLoginForm
                try
                {
                    using (var db = new My_DB())
                    {
                        db.openConnection();
                        var cmd = new SqlCommand("UPDATE DataLoginForm SET Email = @mail WHERE UserName = @user", db.getConnection);
                        cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = updatedHr.Email;
                        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = updatedHr.ID;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch { }

                MessageBox.Show("Updated successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            dtpDob.Value = DateTime.Now;
            cboGenderChoose.SelectedIndex = 0;
            picHR.Image = null;
            hrImage = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                hrImage = File.ReadAllBytes(ofd.FileName);
                picHR.Image = Image.FromStream(new MemoryStream(hrImage));
            }
        }
    }
}
