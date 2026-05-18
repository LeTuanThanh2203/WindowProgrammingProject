using ProjectMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LoginForm
{
    public partial class ManageStudent : Form
    {

        My_DB db = new My_DB();

        public ManageStudent()
        {

            InitializeComponent();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void ManageStudent_Load(
            object sender,
            EventArgs e)
        {
            dgvStudent.AutoGenerateColumns = true;
            LoadStudent();
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
            LoadStudent();
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
            AddStudent addStudent =
              new AddStudent();

            addStudent.Show();
        }

      
    }




}
