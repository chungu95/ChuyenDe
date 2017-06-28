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
        private DateTime _ngayGui;
        private float _laisuat;
        private DichVu _dichvu;

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

        public DateTime NgayGui
        {
            get { return _ngayGui; }
            set { _ngayGui = value; }
        }

        public float Laisuat
        {
            get { return _laisuat; }
            set { _laisuat = value; }
        }

        public DichVu Dichvu
        {
            get { return _dichvu; }
            set { _dichvu = value; }
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
        public static PhieuGui GetPhieuGui(string maphieu)
        {
            PhieuGui phieugui = null;
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = " SELECT * FROM PHIEUGUI WHERE MAPHIEU = '" + maphieu + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
            }
            catch (Exception)
            {//
            }
            finally { Connect.CloseConnection(con); }
            if (dt != null && dt.Rows.Count > 0)
            {
                phieugui = new PhieuGui();
                phieugui.MaPhieu = dt.Rows[0][0].ToString();
                phieugui.Cmnd = dt.Rows[0][1].ToString();
                phieugui.Madv = dt.Rows[0][2].ToString();
                phieugui.NgayGui = DateTime.Parse(dt.Rows[0][3].ToString());
                phieugui.Laisuat = float.Parse(dt.Rows[0][4].ToString());
                phieugui.SoTienGui = Decimal.Parse(dt.Rows[0][5].ToString());
                phieugui.NgayDenHan = DateTime.Parse(dt.Rows[0][6].ToString());
                // Lấy thông tin dịch vụ
                phieugui.Dichvu = DichVu.GetDichVuByMaDv(phieugui.Madv);
            }
            return phieugui;
        }
        public static DataTable PhieuGuiByCmnd(string cmnd)
        {
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "SELECT MAPHIEU FROM PHIEUGUI WHERE CMND = '" + cmnd + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, con);SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
            }
            catch (Exception)
            {//
            }
            finally { Connect.CloseConnection(con); }
            return dt;
        }
    }
}
