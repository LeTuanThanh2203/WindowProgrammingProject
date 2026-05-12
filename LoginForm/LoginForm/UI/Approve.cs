using Microsoft.Data.SqlClient;
using System.Configuration;
namespace LoginForm
{
    public partial class Approve : Form
    {
        string connStr =
       ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public Approve()
        {
            InitializeComponent();

            RegisterRole.Items.Add("User");
            RegisterRole.Items.Add("Manager");
            RegisterRole.Items.Add("Admin");

            LoadPendingUsers();
        }

        // LOAD USER CHƯA DUYỆT
        private void LoadPendingUsers()
        {
            AcceptUser.Rows.Clear();

            using (SqlConnection conn =
                new SqlConnection(connStr))
            {
                conn.Open();
                 
                string query = @"
                SELECT Id, UserName
                FROM DataLoginForm
                WHERE IsApproved = 0";

                SqlCommand cmd =
                    new SqlCommand(query, conn);

                SqlDataReader reader =
                    cmd.ExecuteReader();

                while (reader.Read())
                {
                    AcceptUser.Rows.Add(
                        reader["Id"],
                        reader["UserName"],
                        "User"
                    );
                }

                reader.Close();
            }
        }

        // CLICK BUTTON
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(
                AcceptUser.Rows[e.RowIndex]
                .Cells["RegisterID"].Value);

            string role =
                AcceptUser.Rows[e.RowIndex]
                .Cells["RegisterRole"].Value
                ?.ToString() ?? "User";

            using (SqlConnection conn =
                new SqlConnection(connStr))
            {
                conn.Open();

                // ACCEPT
                if (AcceptUser.Columns[e.ColumnIndex].Name
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
                (AcceptUser.Columns[e.ColumnIndex].Name
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
    }
}