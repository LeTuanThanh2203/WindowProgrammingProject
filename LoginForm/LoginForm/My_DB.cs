using System.Configuration;
using Microsoft.Data.SqlClient;

namespace ProjectMonHoc
{
    internal class My_DB
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
            }
        }

        public void closeConnection()
        {
            if (conn.State ==
                System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}