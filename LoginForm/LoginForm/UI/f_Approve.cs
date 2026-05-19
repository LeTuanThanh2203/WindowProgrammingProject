using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System.Configuration;
namespace LoginForm
{
    public partial class f_Approve : Form
    {
        string connStr =
       ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public f_Approve()
        {
            InitializeComponent();

            RegisterRole.Items.Add("User");
            RegisterRole.Items.Add("Manager");
            RegisterRole.Items.Add("Admin");
            // Mặc định chỉ hiện AcceptUser
            dataGridView_AcceptUser.Visible = true;
            dataGridView_UnlockAcc.Visible = false;
            LoadPendingUsers();
        }

        // LOAD USER CHƯA DUYỆT
        private void LoadPendingUsers()
        {
            dataGridView_AcceptUser.Rows.Clear();

         
                My_DB db = new My_DB();
            db.openConnection();

                string query = @"
                SELECT Id, UserName
                FROM DataLoginForm
                WHERE IsApproved = 0";

                SqlCommand cmd =
                    new SqlCommand(query, db.getConnection);

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView_AcceptUser.Rows.Add(
                        reader["Id"],
                        reader["UserName"],
                        "User"
                    );
                }

                reader.Close();
            db.closeConnection();

        }

        // CLICK BUTTON
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dataGridView_AcceptUser.Rows[e.RowIndex]
                .Cells["RegisterID"].Value);

            string role =
                dataGridView_AcceptUser.Rows[e.RowIndex]
                .Cells["RegisterRole"].Value
                ?.ToString() ?? "User";

            using (SqlConnection conn =
                new SqlConnection(connStr))
            {
                conn.Open();

                // ACCEPT
                if (dataGridView_AcceptUser.Columns[e.ColumnIndex].Name
                    == "RegisterAcp")
                {
                    string query = @"
                    UPDATE DataLoginForm
                    SET IsApproved = 1,
                        RoleName = @role
                    WHERE Id = @id";

                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Approved!");
                }

                // CANCEL
                else if
                (dataGridView_AcceptUser.Columns[e.ColumnIndex].Name
                    == "RegisterCancel")
                {
                    string query =
                    "DELETE FROM DataLoginForm WHERE Id = @id";

                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted!");
                }
            }

            LoadPendingUsers();
        }

        private void bt_Quit_Click(object sender, EventArgs e)
        {
            f_LoginForm login = new f_LoginForm();
            login.Show();
            this.Close();
        }
        private void bt_ApplyAcc_Click(object sender, EventArgs e)
        {
            dataGridView_AcceptUser.Visible = true;
            dataGridView_UnlockAcc.Visible = false;
        }

        private void bt_UnlockAcc_Click(object sender, EventArgs e)
        {
            dataGridView_AcceptUser.Visible = false;
            dataGridView_UnlockAcc.Visible = true;

            LoadLockedAccounts();
        }
        private void LoadLockedAccounts()
        {
            My_DB db = new My_DB();

            string query = @"
    SELECT ID, UserName, RoleName
    FROM DataLoginForm
    WHERE IsLocked = 1";

            SqlCommand command =
                new SqlCommand(query, db.getConnection);

            db.openConnection();

            SqlDataReader reader =
                command.ExecuteReader();

            dataGridView_UnlockAcc.Rows.Clear();

            while (reader.Read())
            {
                dataGridView_UnlockAcc.Rows.Add(
                    reader["ID"].ToString(),
                    reader["UserName"].ToString(),
                    reader["RoleName"].ToString()
                );
            }

            reader.Close();
            db.closeConnection();
        }
        private void dataGridView_UnlockAcc_CellContentClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                dataGridView_UnlockAcc.Rows[e.RowIndex]
                .Cells["txt_ID"].Value);

            using (SqlConnection conn =
                new SqlConnection(connStr))
            {
                conn.Open();

                // UNLOCK
                if (dataGridView_UnlockAcc.Columns[e.ColumnIndex].Name
                    == "bt_Unlock")
                {
                    string query = @"
            UPDATE DataLoginForm
            SET IsLocked = 0,
                LoginAttempts = 0
            WHERE Id = @id";

                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account unlocked!");
                }

                // DELETE
                else if
                (dataGridView_UnlockAcc.Columns[e.ColumnIndex].Name
                    == "bt_Delete")
                {
                    string query =
                    "DELETE FROM DataLoginForm WHERE Id = @id";

                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account deleted!");
                }
            }

            // LOAD LẠI DANH SÁCH BỊ KHÓA
            LoadLockedAccounts();
        }
    }
}