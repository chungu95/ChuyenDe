using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace TestChuyenDe.View
{
    public partial class FrmLietKeSoTienTungThangTheoNam : DevExpress.XtraEditors.XtraForm
    {
        public FrmLietKeSoTienTungThangTheoNam()
        {
            InitializeComponent();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            String nam = txtnam.Text;
            Report_LietKePhieuGuiTheoNam report = new Report_LietKePhieuGuiTheoNam();
            report.Parameters["Nam"].Value = nam;
            report.Parameters["Nam"].Visible = false;


            report.ShowPreview();
        }

        private void txtnam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}