using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class f_Approve : Form
    {
        private readonly string connStr =
            ConfigurationManager
            .ConnectionStrings["MyConn"]
            .ConnectionString;

        private PaginationHelper _pager;

        public f_Approve()
        {
            InitializeComponent();

            RegisterRole.Items.Clear();
            RegisterRole.Items.Add("User");
            RegisterRole.Items.Add("HR");
            RegisterRole.Items.Add("Admin");

            // Setup grids visibility
            dataGridView_AcceptUser.Visible = true;
            dataGridView_UnlockAcc.Visible = false;
            dataGridView_ConfirmationRequest.Visible = false;

            // Style grids
            UIStyleHelper.StyleDataGridView(dataGridView_AcceptUser);
            UIStyleHelper.StyleDataGridView(dataGridView_UnlockAcc);
            UIStyleHelper.StyleDataGridView(dataGridView_ConfirmationRequest);

            // Initialize pagination helper
            _pager = new PaginationHelper(
                pageTable =>
                {
                    if (dataGridView_AcceptUser.Visible)
                        BindAcceptUserGrid(pageTable);
                    else if (dataGridView_UnlockAcc.Visible)
                        BindUnlockAccGrid(pageTable);
                    else if (dataGridView_ConfirmationRequest.Visible)
                        BindConfirmationRequestGrid(pageTable);
                },
                lblPageInfo,
                lblTotal,
                btnFirst,
                btnPrev,
                btnNext,
                btnLast,
                cboPageSize
            );

            HighlightActiveTab(bt_ApplyAcc);
            LoadPendingUsers();
        }

        private void HighlightActiveTab(Button activeBtn)
        {
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn)
                {
                    if (btn == activeBtn)
                    {
                        btn.BackColor = Color.FromArgb(10, 61, 120);
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.FromArgb(60, 70, 85);
                    }
                }
            }
        }

        // ================= DATAGRIDVIEW BINDERS =================
        private void BindAcceptUserGrid(DataTable pageTable)
        {
            dataGridView_AcceptUser.Rows.Clear();
            foreach (DataRow row in pageTable.Rows)
            {
                dataGridView_AcceptUser.Rows.Add(row["Id"], row["UserName"], row["Role"]);
            }
        }

        private void BindUnlockAccGrid(DataTable pageTable)
        {
            dataGridView_UnlockAcc.Rows.Clear();
            foreach (DataRow row in pageTable.Rows)
            {
                dataGridView_UnlockAcc.Rows.Add(row["ID"], row["UserName"], row["RoleName"]);
            }
        }

        private void BindConfirmationRequestGrid(DataTable pageTable)
        {
            dataGridView_ConfirmationRequest.Rows.Clear();
            foreach (DataRow row in pageTable.Rows)
            {
                int rowIdx = dataGridView_ConfirmationRequest.Rows.Add(
                    row["MSSV"],
                    row["ConfirmationName"],
                    row["Quantity"],
                    "Accept",
                    "Delete"
                );
                dataGridView_ConfirmationRequest.Rows[rowIdx].Tag = row["RequestID"];
            }
        }

        // ================= LOAD DATA METHODS =================
        private void LoadPendingUsers()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Role", typeof(string));

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT Id, UserName
                    FROM DataLoginForm
                    WHERE IsApproved = 0", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader["Id"], reader["UserName"], "User");
                    }
                }
            }
            _pager.ResetPage();
            _pager.SetData(dt);
        }

        private void LoadLockedAccounts()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("RoleName", typeof(string));

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT ID, UserName, RoleName
                    FROM DataLoginForm
                    WHERE IsLocked = 1", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(reader["ID"].ToString(), reader["UserName"].ToString(), reader["RoleName"].ToString());
                    }
                }
            }
            _pager.ResetPage();
            _pager.SetData(dt);
        }

        private void LoadConfirmationRequests()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RequestID", typeof(int));
            dt.Columns.Add("MSSV", typeof(string));
            dt.Columns.Add("ConfirmationName", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT
                        RequestID,
                        MSSV,
                        ConfirmationName,
                        Quantity
                    FROM ConfirmationRequest
                    WHERE Status = 0
                    ORDER BY QueueNumber ASC", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            Convert.ToInt32(reader["RequestID"]),
                            reader["MSSV"].ToString(),
                            reader["ConfirmationName"].ToString(),
                            reader["Quantity"].ToString()
                        );
                    }
                }
            }
            _pager.ResetPage();
            _pager.SetData(dt);
        }

        // ================= ACTION HANDLERS =================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dataGridView_AcceptUser.Rows[e.RowIndex].Cells["RegisterID"].Value);
            string role = dataGridView_AcceptUser.Rows[e.RowIndex].Cells["RegisterRole"].Value?.ToString() ?? "User";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                if (dataGridView_AcceptUser.Columns[e.ColumnIndex].Name == "RegisterAcp")
                {
                    var cmd = new SqlCommand(@"
                        UPDATE DataLoginForm
                        SET IsApproved = 1,
                            RoleName   = @role
                        WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Approved!");
                }
                else if (dataGridView_AcceptUser.Columns[e.ColumnIndex].Name == "RegisterCancel")
                {
                    var cmd = new SqlCommand("DELETE FROM DataLoginForm WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted!");
                }
            }

            LoadPendingUsers();
        }

        private void dataGridView_UnlockAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dataGridView_UnlockAcc.Rows[e.RowIndex].Cells["txt_ID"].Value);

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                if (dataGridView_UnlockAcc.Columns[e.ColumnIndex].Name == "bt_Unlock")
                {
                    var cmd = new SqlCommand(@"
                        UPDATE DataLoginForm
                        SET IsLocked      = 0,
                            LoginAttempts = 0
                        WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account unlocked!");
                }
                else if (dataGridView_UnlockAcc.Columns[e.ColumnIndex].Name == "bt_Delete")
                {
                    var cmd = new SqlCommand("DELETE FROM DataLoginForm WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account deleted!");
                }
            }

            LoadLockedAccounts();
        }

        private void dataGridView_ConfirmationRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            object tag = dataGridView_ConfirmationRequest.Rows[e.RowIndex].Tag;
            if (tag == null) return;

            int requestID = Convert.ToInt32(tag);
            string colName = dataGridView_ConfirmationRequest.Columns[e.ColumnIndex].Name;

            if (colName == "btn_AcpRequest")
            {
                DialogResult confirm = MessageBox.Show(
                    "Approve this request?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"
                        UPDATE ConfirmationRequest
                        SET Status = 1
                        WHERE RequestID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", requestID);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (colName == "btn_DeleteRequest")
            {
                DialogResult confirm = MessageBox.Show(
                    "Delete this request?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"
                        DELETE FROM ConfirmationRequest
                        WHERE RequestID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", requestID);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadConfirmationRequests();
        }

        // ================= SWITCH BUTTONS =================
        private void bt_ApplyAcc_Click(object sender, EventArgs e)
        {
            dataGridView_AcceptUser.Visible = true;
            dataGridView_UnlockAcc.Visible = false;
            dataGridView_ConfirmationRequest.Visible = false;

            HighlightActiveTab(bt_ApplyAcc);
            LoadPendingUsers();
        }

        private void bt_UnlockAcc_Click(object sender, EventArgs e)
        {
            dataGridView_AcceptUser.Visible = false;
            dataGridView_UnlockAcc.Visible = true;
            dataGridView_ConfirmationRequest.Visible = false;

            HighlightActiveTab(bt_UnlockAcc);
            LoadLockedAccounts();
        }

        private void btn_ConfirmationRequest_Click(object sender, EventArgs e)
        {
            dataGridView_AcceptUser.Visible = false;
            dataGridView_UnlockAcc.Visible = false;
            dataGridView_ConfirmationRequest.Visible = true;

            HighlightActiveTab(btn_ConfirmationRequest);
            LoadConfirmationRequests();
        }
    }
}