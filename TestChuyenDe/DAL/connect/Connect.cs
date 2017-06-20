using System;
using System.Data;
using System.Data.SqlClient;

namespace TestChuyenDe.DAL.connect
{
    internal class Connect
    {
        private static readonly string _datasourceName = "localhost";
        private static readonly string _databaseName = "TKBUUDIEN";

        public static string ConnectionString { get; set; } = "";

        public static string DatasourceName
        {
            get { return _datasourceName; }
        }

        public static string DatabaseName
        {
            get { return _databaseName; }
        }


        public static SqlConnection GetConnection()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(ConnectionString);
                con.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return con;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}