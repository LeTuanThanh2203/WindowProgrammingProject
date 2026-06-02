using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System.Configuration;

namespace LoginForm
{
    public partial class f_Approve : Form
    {
        string connStr =
            ConfigurationManager
            .ConnectionStrings["MyConn"]
            .ConnectionString;

        public f_Approve()
        {
            InitializeComponent();

            RegisterRole.Items.Add("User");
            RegisterRole.Items.Add("Manager");
            RegisterRole.Items.Add("Admin");

            dataGridView_AcceptUser.Visible = true;
            dataGridView_UnlockAcc.Visible = false;
            dataGridView_ConfirmationRequest.Visible = false;

            LoadPendingUsers();
        }

        // ================= LOAD USER CHƯA DUYỆT =================
        private void LoadPendingUsers()
        {
            dataGridView_AcceptUser.Rows.Clear();

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT Id, UserName
                    FROM DataLoginForm
                    WHERE IsApproved = 0", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView_AcceptUser.Rows.Add(
                        reader["Id"],
                        reader["UserName"],
                        "User");
                }
                reader.Close();
            }
        }

        // ================= ACCEPT / CANCEL USER =================
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(
                dataGridView_AcceptUser
                .Rows[e.RowIndex]
                .Cells["RegisterID"].Value);

            string role =
                dataGridView_AcceptUser
                .Rows[e.RowIndex]
                .Cells["RegisterRole"].Value
                ?.ToString() ?? "User";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                if (dataGridView_AcceptUser
                    .Columns[e.ColumnIndex].Name == "RegisterAcp")
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
                else if (dataGridView_AcceptUser
                    .Columns[e.ColumnIndex].Name == "RegisterCancel")
                {
                    var cmd = new SqlCommand(
                        "DELETE FROM DataLoginForm WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted!");
                }
            }

            LoadPendingUsers();
        }

        // ================= SWITCH: APPLY ACC =================
        private void bt_ApplyAcc_Click(
            object sender,
            EventArgs e)
        {
            dataGridView_AcceptUser.Visible = true;
            dataGridView_UnlockAcc.Visible = false;
            dataGridView_ConfirmationRequest.Visible = false;
            LoadPendingUsers();
        }

        // ================= SWITCH: UNLOCK ACC =================
        private void bt_UnlockAcc_Click(
            object sender,
            EventArgs e)
        {
            dataGridView_AcceptUser.Visible = false;
            dataGridView_UnlockAcc.Visible = true;
            dataGridView_ConfirmationRequest.Visible = false;
            LoadLockedAccounts();
        }

        // ================= LOAD LOCKED ACCOUNTS =================
        private void LoadLockedAccounts()
        {
            dataGridView_UnlockAcc.Rows.Clear();

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT ID, UserName, RoleName
                    FROM DataLoginForm
                    WHERE IsLocked = 1", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView_UnlockAcc.Rows.Add(
                        reader["ID"].ToString(),
                        reader["UserName"].ToString(),
                        reader["RoleName"].ToString());
                }
                reader.Close();
            }
        }

        // ================= UNLOCK / DELETE ACC =================
        private void dataGridView_UnlockAcc_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(
                dataGridView_UnlockAcc
                .Rows[e.RowIndex]
                .Cells["txt_ID"].Value);

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                if (dataGridView_UnlockAcc
                    .Columns[e.ColumnIndex].Name == "bt_Unlock")
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
                else if (dataGridView_UnlockAcc
                    .Columns[e.ColumnIndex].Name == "bt_Delete")
                {
                    var cmd = new SqlCommand(
                        "DELETE FROM DataLoginForm WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account deleted!");
                }
            }

            LoadLockedAccounts();
        }

        // ================= SWITCH: CONFIRMATION REQUEST =================
        private void btn_ConfirmationRequest_Click(
            object sender,
            EventArgs e)
        {
            dataGridView_AcceptUser.Visible = false;
            dataGridView_UnlockAcc.Visible = false;
            dataGridView_ConfirmationRequest.Visible = true;
            LoadConfirmationRequests();
        }

        // ================= LOAD CONFIRMATION REQUESTS =================
        private void LoadConfirmationRequests()
        {
            dataGridView_ConfirmationRequest.Rows.Clear();

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

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int rowIdx = dataGridView_ConfirmationRequest.Rows.Add(
                        reader["MSSV"].ToString(),
                        reader["ConfirmationName"].ToString(),
                        reader["Quantity"].ToString(),
                        "Accept",
                        "Delete");

                    // Lưu RequestID vào Tag
                    dataGridView_ConfirmationRequest
                        .Rows[rowIdx].Tag =
                        Convert.ToInt32(reader["RequestID"]);
                }
                reader.Close();
            }
        }

        // ================= ACCEPT / DELETE REQUEST =================
        private void dataGridView_ConfirmationRequest_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            object tag =
                dataGridView_ConfirmationRequest
                .Rows[e.RowIndex].Tag;

            if (tag == null) return;

            int requestID = Convert.ToInt32(tag);

            string colName =
                dataGridView_ConfirmationRequest
                .Columns[e.ColumnIndex].Name;

            // ACCEPT
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
                    int rows = cmd.ExecuteNonQuery();
                }
            }

            // DELETE
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
                    int rows = cmd.ExecuteNonQuery();
                }
            }

            LoadConfirmationRequests();
        }
    }
}