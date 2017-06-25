

using System;

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
    }
}
