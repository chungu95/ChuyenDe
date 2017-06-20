using DevExpress.XtraEditors;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.View
{
    public partial class FrmKhachHang : XtraForm
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void clearEdit()
        {
            txthoten.Text = string.Empty;
            txtcmnd.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            txtngaycap.Text = string.Empty;
        }

        private void enableEdit()
        {
            txthoten.Enabled = true;
            txtcmnd.Enabled = true;
            txtdiachi.Enabled = true;
            txtngaycap.Enabled = true;
        }

        private void disableEdit()
        {
            txthoten.Enabled = false;
            txtcmnd.Enabled = false;
            txtdiachi.Enabled = false;
            txtngaycap.Enabled = false;
        }

        private void FrmKhachHang_Load(object sender, System.EventArgs e)
        {
            var con = Connect.GetConnection();
        }
    }
}