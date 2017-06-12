using System;
using System.Data;
using System.Data.SqlClient;

namespace TestChuyenDe.DAL.connect
{

    class Connect
    {
        private static readonly string DatasourceName = "localhost";
        private static readonly string DatabaseName = "TKBUUDIEN";
        private static string _username; 
        private static string _password;

        private static string _connectionString = "";

        public static string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private static string ConnectionString
        {
            get { return _connectionString; }

            set
            {
                _connectionString = value;
            }
        }


        public static SqlConnection GetConnection()
        {
            SqlConnection con = null;
            try
            {
                ConnectionString  = "Data Source=" + DatasourceName + ";Initial Catalog=" + DatabaseName +
                    ";User ID=" + Username + ";Password=" + Password;
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
