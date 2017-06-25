

using System;
using System.Data;
using System.Data.SqlClient;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.Model
{
    class LaiSuat
    {
        private string _madv;
        private DateTime _ngayAd;
        private float _laisuat;

        public string Madv
        {
            get { return _madv; }
            set { _madv = value; }
        }

        public DateTime NgayAd
        {
            get { return _ngayAd; }
            set { _ngayAd = value; }
        }

        public float Laisuat
        {
            get { return _laisuat; }
            set { _laisuat = value; }
        }

        public static LaiSuat LayLaiSuat(string madv)
        {
            LaiSuat laisuat = null;
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "EXEC SP_LAI_SUAT_HIEN_HANH '" + madv + "'";
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
                laisuat = new LaiSuat();
                laisuat.Laisuat = float.Parse(dt.Rows[0][0].ToString());
            }
            return laisuat;
        }
    }
}
