using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static Decimal TinhTienLai(PhieuGui phieugui, int type)
        {
            Decimal tienLai = 0;
            DateTime currentDate = DateTime.Today;
            int method;
            if (currentDate < phieugui.NgayDenHan) method = 0;
            else if (currentDate == phieugui.NgayDenHan) method = 1;
            else method = 2;
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
            float laisuat = LaiSuat.LayLaiSuat("40").Laisuat;
            DateTime currentDate = DateTime.Today;
            TimeSpan time = currentDate - phieugui.NgayGui;
            float songay = time.Days;
            float sotiengui = float.Parse(phieugui.SoTienGui.ToString());
            tienlai = Decimal.Parse((sotiengui * (songay / 365) * laisuat).ToString());
            return tienlai;
        }

        private static Decimal LaiRutDungHan(PhieuGui phieugui)
        {
            Decimal tienlai = 0;
            DichVu dichvu = DichVu.GetDichVuByMaDv(phieugui.Madv);
            float laisuat = dichvu.LaiSuat.Laisuat;
            float sotiengui = float.Parse(phieugui.SoTienGui.ToString());
            tienlai = Decimal.Parse((sotiengui * (laisuat/12) * dichvu.Kyhan).ToString());
            return tienlai;
        }

        private static Decimal LaiRutQuaHan(PhieuGui phieugui)
        {
            return 0;
        }
    }
}
