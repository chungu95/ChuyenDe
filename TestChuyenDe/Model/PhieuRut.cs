using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.Model
{
    class PhieuRut
    {
        private string _maPhieuGui;
        private Decimal _soTienRut;
        private Decimal _tienLai;

        public string MaPhieuGui
        {
            get { return _maPhieuGui; }
            set { _maPhieuGui = value; }
        }

        public decimal SoTienRut
        {
            get { return _soTienRut; }
            set { _soTienRut = value; }
        }

        public decimal TienLai
        {
            get { return _tienLai; }
            set { _tienLai = value; }
        }

        public static bool LuuPhieuRut(PhieuRut phieurut, string loginName)
        {
            bool result = false;
            SqlConnection con = Connect.GetConnection();
            using (SqlCommand sqlCommand = con.CreateCommand())
            {
                sqlCommand.CommandText = "SP_LAP_PHIEU_RUT";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@MAPHIEU", phieurut.MaPhieuGui);
                sqlCommand.Parameters.AddWithValue("@SOTIENRUT", phieurut.SoTienRut);
                sqlCommand.Parameters.AddWithValue("@TIENLAI", phieurut.TienLai);
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

        public static Decimal TinhTienLai(PhieuGui phieugui, int type)
        {
            Decimal tienLai = 0;
            DateTime currentDate = DateTime.Today;
            int method;
            if (currentDate < phieugui.NgayDenHan) method = 0;             // Rút trước hạn
            else if (currentDate == phieugui.NgayDenHan) method = 1;       // Rút đúng hạn
            else method = 2;                                               // Rút quá hạn
            switch (method)
            {
                case 0:
                    tienLai = LaiRutTruocHan(phieugui);
                    break;
                case 1:
                    tienLai = LaiRutDungHan(phieugui);
                    break;
                case 2:
                    tienLai = LaiRutQuaHan(phieugui);
                    break;
            }
            return tienLai;
        }
        private static Decimal LaiRutTruocHan(PhieuGui phieugui)
        {
            Decimal tienlai = 0;
            float laisuat = LaiSuat.LayLaiSuat("40").Laisuat;DateTime currentDate = DateTime.Today;
            TimeSpan time = currentDate - phieugui.NgayGui;
            float songay = time.Days;float sotiengui = float.Parse(phieugui.SoTienGui.ToString());
            tienlai = Decimal.Parse((sotiengui * (songay / 365) * laisuat).ToString(), System.Globalization.NumberStyles.Float);
            return tienlai;}
        private static Decimal LaiRutDungHan(PhieuGui phieugui)
        {
            Decimal tienlai = 0;
            DichVu dichvu = DichVu.GetDichVuByMaDv(phieugui.Madv);
            float laisuat = phieugui.Laisuat;
            float sotiengui = float.Parse(phieugui.SoTienGui.ToString());
            tienlai = Decimal.Parse((sotiengui * (laisuat / 12) * dichvu.Kyhan).ToString(), System.Globalization.NumberStyles.Float);
            return tienlai;
        }
        private static Decimal LaiRutQuaHan(PhieuGui phieugui){
            Decimal tienlai = 0;while (phieugui.NgayGui <= DateTime.Today)
            {
                MessageBox.Show("lặp");tienlai += LaiRutDungHan(phieugui);
                phieugui.SoTienGui += LaiRutDungHan(phieugui);
                phieugui.NgayGui = phieugui.NgayGui.AddMonths(phieugui.Dichvu.Kyhan);
                if ((phieugui.NgayGui == DateTime.Today))
                {
                    break;
                }
            } 
            if (phieugui.NgayGui.AddMonths(phieugui.Dichvu.Kyhan) < DateTime.Today)
            {phieugui.NgayGui = phieugui.NgayGui.AddMonths(-phieugui.Dichvu.Kyhan);
                tienlai += LaiRutTruocHan(phieugui);
            }
            return tienlai;
        }
    }
}
