using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.Model
{
    class PhieuGui
    {
        private string _maPhieu;
        private string _cmnd;
        private string _madv;
        private Decimal _soTienGui;
        private DateTime _ngayDenHan;

        public string MaPhieu
        {
            get { return _maPhieu; }
            set { _maPhieu = value; }
        }

        public string Cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }

        public string Madv
        {
            get { return _madv; }
            set { _madv = value; }
        }

        public Decimal SoTienGui
        {
            get { return _soTienGui; }
            set { _soTienGui = value; }
        }

        public DateTime NgayDenHan
        {
            get { return _ngayDenHan; }
            set { _ngayDenHan = value; }
        }

        public static bool LuuPhieuGui(PhieuGui phieugui, string loginName)
        {
            bool result = false;
            SqlConnection con = Connect.GetConnection();
            using (SqlCommand sqlCommand = con.CreateCommand())
            {
                sqlCommand.CommandText = "SP_LAP_PHIEU_GUI";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MAPHIEU", phieugui.MaPhieu);
                sqlCommand.Parameters.AddWithValue("@CMND", phieugui.Cmnd);
                sqlCommand.Parameters.AddWithValue("@MADV", phieugui.Madv);
                sqlCommand.Parameters.AddWithValue("@SOTIENGUI", phieugui.SoTienGui);
                sqlCommand.Parameters.AddWithValue("@NGAYDENHAN", new SqlDateTime(phieugui.NgayDenHan));
                sqlCommand.Parameters.AddWithValue("@LGNAME", loginName);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connect.CloseConnection(con);
                }
            }
            return result;
        }
    }
}
