using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;

namespace TestChuyenDe.View
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form IsExist(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.IsExist(typeof(TestChuyenDe.View.FrmDichVu));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                TestChuyenDe.View.FrmDichVu f = new TestChuyenDe.View.FrmDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLaiSuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.IsExist(typeof(TestChuyenDe.View.FrmLaiSuat));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                TestChuyenDe.View.FrmLaiSuat f = new TestChuyenDe.View.FrmLaiSuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.IsExist(typeof(TestChuyenDe.View.FrmKhachHang));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                TestChuyenDe.View.FrmKhachHang f = new TestChuyenDe.View.FrmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGiaoDichVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.IsExist(typeof(TestChuyenDe.View.FrmGiaoDichVien));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                TestChuyenDe.View.FrmGiaoDichVien f = new TestChuyenDe.View.FrmGiaoDichVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnGuiTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.IsExist(typeof(TestChuyenDe.View.FrmGuiTien));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                TestChuyenDe.View.FrmGuiTien f = new TestChuyenDe.View.FrmGuiTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnRutTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.IsExist(typeof(TestChuyenDe.View.FrmRutTien));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {Console.Write(frm);
                TestChuyenDe.View.FrmRutTien f = new TestChuyenDe.View.FrmRutTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhsachDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Report_LietKeDV report = new Report_LietKeDV();
            ReportPrintTool printtool = new ReportPrintTool(report);
            printtool.ShowPreview();
         }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {}

        private void btnPhieuguitientrongkhoangthoigian_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.IsExist(typeof(TestChuyenDe.View.FrmLietKePhieuGuiTrongKhoangThoiGian));
            if (frm != null)
            {
                frm.Activate();
                Console.Write(frm);
            }
            else
            {
                Console.Write(frm);
                TestChuyenDe.View.FrmLietKePhieuGuiTrongKhoangThoiGian f = new TestChuyenDe.View.FrmLietKePhieuGuiTrongKhoangThoiGian();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
    }
