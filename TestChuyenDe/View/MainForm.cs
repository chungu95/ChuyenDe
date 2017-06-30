using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UI;
using TestChuyenDe.Model;

namespace TestChuyenDe.View
{
    public partial class MainForm : RibbonForm{
        public MainForm()
        {
            InitializeComponent();LoadComponents();
        }

        public void LoadComponents()
        {
            if(Login.Role.Equals("GDV"))
            {
                rpgDoiPass.Visible = false;
                rpgBackupRestore.Visible = false;
                rpgGiaoDichVien.Visible = false;
                rpgTaoTaiKhoan.Visible = false;
                rpgTongTien.Visible = false;}
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
            var frm = IsExist(typeof(FrmLaiSuat2));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmLaiSuat2();
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
            var report = new Report_LietKeDichVuHienHanh();
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

        private void btnPhieuguitienquahanrut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report_LietKePhieuGuiDaHetHan report = new Report_LietKePhieuGuiDaHetHan();
            report.ShowPreview();
        }

        private void btnTongtien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmLietKeSoTienTungThangTheoNam));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmLietKeSoTienTungThangTheoNam();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBackupRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmBackup2));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmBackup2();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = IsExist(typeof(FrmDoiPass));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                var f = new FrmDoiPass();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)  //logout
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Application.Restart();}
            else
            {
                return;
            }
        }
    }
}