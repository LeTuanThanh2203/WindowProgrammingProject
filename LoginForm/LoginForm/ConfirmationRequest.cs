using System;
using System.Data;
using Microsoft.Data.SqlClient;
using ProjectMonHoc;
using System.Configuration;
using System.Windows.Forms;

public class ConfirmationRequest
{
    // ================= PROPERTIES =================
    public int RequestID { get; set; }
    public string MSSV { get; set; }
    public string ConfirmationName { get; set; }
    public int QueueNumber { get; set; }
    public int Quantity { get; set; }
    public int Status { get; set; }

    private static string ConnStr =>
        ConfigurationManager
        .ConnectionStrings["MyConn"]
        .ConnectionString;

    // ================= CONSTRUCTORS =================
    public ConfirmationRequest() { }

    public ConfirmationRequest(string mssv,
        string confirmationName, int quantity)
    {
        MSSV = mssv;
        ConfirmationName = confirmationName;
        Quantity = quantity;
        Status = 0;
    }

    // ================= GET NEXT QUEUE NUMBER =================
    private int GetNextQueueNumber(string confirmationName)
    {
        try
        {
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT ISNULL(MAX(QueueNumber), 0) + 1
                    FROM ConfirmationRequest
                    WHERE ConfirmationName = @name
                      AND Status = 0",
                    conn);
                cmd.Parameters.AddWithValue("@name", confirmationName);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch { return 1; }
    }

    // ================= ADD =================
    public bool AddRequest()
    {
        try
        {
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();

                // Kiểm tra đã có request pending chưa
                var checkCmd = new SqlCommand(@"
                    SELECT COUNT(*) FROM ConfirmationRequest
                    WHERE MSSV = @mssv
                      AND ConfirmationName = @name
                      AND Status = 0",
                    conn);
                checkCmd.Parameters.AddWithValue("@mssv", MSSV);
                checkCmd.Parameters.AddWithValue("@name", ConfirmationName);

                int existing = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (existing > 0)
                {
                    MessageBox.Show(
                        "You already have a pending request for this confirmation type.",
                        "Duplicate Request",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return false;
                }

                // Lấy số thứ tự
                QueueNumber = GetNextQueueNumber(ConfirmationName);

                var cmd = new SqlCommand(@"
                    INSERT INTO ConfirmationRequest
                        (MSSV, ConfirmationName,
                         QueueNumber, Quantity, Status)
                    VALUES
                        (@mssv, @name,
                         @queue, @quantity, 0);
                    SELECT SCOPE_IDENTITY();",
                    conn);

                cmd.Parameters.Add("@mssv", SqlDbType.VarChar).Value = MSSV;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = ConfirmationName;
                cmd.Parameters.Add("@queue", SqlDbType.Int).Value = QueueNumber;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = Quantity;

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    RequestID = Convert.ToInt32(result);
                    return true;
                }
                return false;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("AddRequest Error: " + ex.Message);
            return false;
        }
    }

    // ================= GET BY MSSV =================
    public DataTable GetRequestsByMSSV(string mssv)
    {
        var table = new DataTable();
        try
        {
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    SELECT
                        ConfirmationName,
                        QueueNumber,
                        Quantity,
                        CASE Status
                            WHEN 1 THEN N'Done'
                            ELSE        N'Pending'
                        END AS Status
                    FROM ConfirmationRequest
                    WHERE MSSV = @mssv
                    ORDER BY RequestID DESC",
                    conn);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                new SqlDataAdapter(cmd).Fill(table);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("GetRequestsByMSSV Error: " + ex.Message);
        }
        return table;
    }

    // ================= APPROVE =================
    public static bool ApproveRequest(int requestID)
    {
        try
        {
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    UPDATE ConfirmationRequest
                    SET Status = 1
                    WHERE RequestID = @id",
                    conn);
                cmd.Parameters.AddWithValue("@id", requestID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("ApproveRequest Error: " + ex.Message);
            return false;
        }
    }

    // ================= CANCEL =================
    public static bool CancelRequest(int requestID)
    {
        try
        {
            using (var conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                var cmd = new SqlCommand(@"
                    DELETE FROM ConfirmationRequest
                    WHERE RequestID = @id",
                    conn);
                cmd.Parameters.AddWithValue("@id", requestID);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("CancelRequest Error: " + ex.Message);
            return false;
        }
    }
}