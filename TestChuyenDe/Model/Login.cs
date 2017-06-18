using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.PivotGrid.OLAP.AdoWrappers;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.Model
{
    class Login
    {
        private static string LGName;
        private static string _username;
        private static string _password;
        private static string _role;

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

        public static string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public static string LgName
        {
            get { return LGName; }
            set { LGName = value; }
        }

        public static void doLogin()
        {
            string sql = "exec SP_DANGNHAP '" + Login.LgName + "'";
            SqlConnection con = Connect.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql,con);
            SqlDataAdapter data = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);
            string _username = dataTable.Rows[0][0].ToString();
            if (_username.Equals("dbo"))
            {
                _username = "Admin";
            }
            Login.Username = _username;
            Login.Role = dataTable.Rows[0][2].ToString();
        }

    }
}
