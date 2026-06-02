using LoginForm;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Group6
{
    public partial class f_Request : Form
    {
        ConfirmationRequest _request =
            new ConfirmationRequest();

        string currentMSSV = Globals.Username;

        public f_Request()
        {
            InitializeComponent();

            this.Load += f_Request_Load;
            btn_Add.Click += btn_Add_Click;
        }

        // ================= LOAD FORM =================
        private void f_Request_Load(
            object sender,
            EventArgs e)
        {
            LoadConfirmationNames();
            LoadQuantity();
            LoadRequests();
        }

        // ================= LOAD CONFIRMATION NAME =================
        private void LoadConfirmationNames()
        {
            cbo_ConfirmationName.Items.Clear();
            cbo_ConfirmationName.Items.AddRange(new[]
            {
                "Giấy xác nhận sinh viên",
                "Giấy giới thiệu"
            });
            cbo_ConfirmationName.SelectedIndex = 0;
        }

        // ================= LOAD QUANTITY =================
        private void LoadQuantity()
        {
            cbo_Quantity.Items.Clear();
            for (int i = 1; i <= 10; i++)
                cbo_Quantity.Items.Add(i);
            cbo_Quantity.SelectedIndex = 0;
        }

        // ================= LOAD REQUESTS =================
        private void LoadRequests()
        {
            DataTable dt =
                _request.GetRequestsByMSSV(currentMSSV);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["ConfirmationName"].ToString(),
                    row["QueueNumber"].ToString(),
                    row["Quantity"].ToString(),
                    row["Status"].ToString()); // "Done" hoặc "Pending"
            }

            // Style
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor =
                System.Drawing.Color.White;
            dataGridView1.RowHeadersVisible = false;
        }

        // ================= ADD =================
        private void btn_Add_Click(
            object sender,
            EventArgs e)
        {
            if (cbo_ConfirmationName.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a Confirmation Name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var newRequest = new ConfirmationRequest
            {
                MSSV = currentMSSV,
                ConfirmationName =
                    cbo_ConfirmationName
                    .SelectedItem.ToString(),
                Quantity =
                    Convert.ToInt32(
                        cbo_Quantity.SelectedItem),
                Status = 0 // Pending
            };

            bool ok = newRequest.AddRequest();

            if (ok)
            {
                MessageBox.Show(
                    $"Request submitted!\nQueue Number: {newRequest.QueueNumber}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadRequests();
            }
        }
    }
}