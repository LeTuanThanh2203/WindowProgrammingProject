using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ProjectMonHoc
{
    internal class My_DB : IDisposable
    {
        private SqlConnection conn =
            new SqlConnection(
                ConfigurationManager
                .ConnectionStrings["MyConn"]
                .ConnectionString);

        public SqlConnection getConnection
        {
            get { return conn; }
        }

        public void openConnection()
        {
            if (conn.State ==
                System.Data.ConnectionState.Closed)
            {
                conn.Open();

                File.AppendAllText(
                "db_log.txt",
                $"[{DateTime.Now}] Connection Opened\n");       //ghi log mỗi khi mở kết nối
            }
        }

        public void closeConnection()
        {
            if (conn.State ==
                System.Data.ConnectionState.Open)
            {
                conn.Close();

                File.AppendAllText(
              "db_log.txt",
              $"[{DateTime.Now}] Connection Closed\n");     //ghi log mỗi khi đóng kết nối
            }
        }
        public void Dispose()
        {
            if (conn != null)
            {
                if (conn.State == ConnectionState.Open)
                {
                    File.AppendAllText(
                        "db_log.txt",
                        $"[{DateTime.Now}] WARNING: Connection Leak Detected\n");   //ghi log cảnh báo nếu phát hiện kết nối chưa được đóng
                }

                conn.Dispose();
            }
        }
    }
}