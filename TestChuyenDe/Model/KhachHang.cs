using System;
using System.Data;
using System.Data.SqlClient;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.Model
{
    class KhachHang
    {
        private string _cmnd;
        private string _hoTen;
        private string _diaChi;
        private DateTime _ngayCap;

        public string Cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public DateTime NgayCap
        {
            get { return _ngayCap; }
            set { _ngayCap = value; }
        }

        public static KhachHang GetDsKhachHang(string cmnd)
        {
            KhachHang khachhang = null;
            SqlConnection con = Connect.GetConnection();
            string sql = "SELECT * FROM KHACHHANG WHERE CMND = '"+cmnd+"'";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql,con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    khachhang = new KhachHang();khachhang.HoTen = dataTable.Rows[0][0].ToString();
                    khachhang.DiaChi = dataTable.Rows[0][1].ToString();
                    khachhang.Cmnd = dataTable.Rows[0][2].ToString();
                    khachhang.NgayCap = (DateTime) dataTable.Rows[0][3];
                }
            }
            catch (Exception)
            {
                // 
            }
            finally { Connect.CloseConnection(con); }
            return khachhang;
        }


    }
}
