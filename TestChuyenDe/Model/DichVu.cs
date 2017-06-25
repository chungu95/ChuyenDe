

using System;
using System.Data;
using System.Data.SqlClient;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.Model
{
    class DichVu
    {
        private string _madv;
        private string _tendv;
        private int _kyhan;
        private LaiSuat _laiSuat;

        public string Madv
        {
            get { return _madv; }
            set { _madv = value; }
        }

        public string Tendv
        {
            get { return _tendv; }
            set { _tendv = value; }
        }

        public int Kyhan
        {
            get { return _kyhan; }
            set { _kyhan = value; }
        }

        public LaiSuat LaiSuat
        {
            get { return _laiSuat; }
            set { _laiSuat = value; }
        }

        public static DichVu GetDichVuByMaDv(string madv)
        {
            DichVu dichvu = null;
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "EXEC SP_DICH_VU_VA_LAI_SUAT_HIEN_HANH "+madv+"";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
            }
            catch (Exception)
            {//
            }
            finally { Connect.CloseConnection(con); }
            if (dt != null && dt.Rows.Count != 0)
            {
                LaiSuat laisuat = new LaiSuat();
                laisuat.Madv = madv;
                laisuat.Laisuat = float.Parse(dt.Rows[0][3].ToString()); 
                dichvu = new DichVu();
                dichvu.LaiSuat = laisuat;
                dichvu.Madv = madv;
                dichvu.Tendv = dt.Rows[0][1].ToString();
                dichvu.Kyhan = Int32.Parse(dt.Rows[0][2].ToString());
            }
            return dichvu;
        }
    }
}
