using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using TestChuyenDe.Model;

namespace TestChuyenDe.View
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form IsExist(Type fType)
        {
            foreach (var f in MdiChildren)
                if (f.GetType() == fType)
                    return f;
            return null;
        }

        private void btnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmDichVu));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLaiSuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmLaiSuat));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmLaiSuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmKhachHang));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGiaoDichVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmGiaoDichVien));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmGiaoDichVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGuiTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmGuiTien));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmGuiTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnRutTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmRutTien));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmRutTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhsachDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            var report = new Report_LietKeDV();
            var printtool = new ReportPrintTool(report);
            printtool.ShowPreview();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
        }

        private void btnPhieuguitientrongkhoangthoigian_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmLietKePhieuGuiTrongKhoangThoiGian));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmLietKePhieuGuiTrongKhoangThoiGian();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnAddLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(frmAddLogin));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new frmAddLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

    }
}