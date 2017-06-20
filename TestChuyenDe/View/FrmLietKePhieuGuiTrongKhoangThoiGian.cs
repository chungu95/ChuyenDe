using System;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace TestChuyenDe.View
{
    public partial class FrmLietKePhieuGuiTrongKhoangThoiGian : XtraForm
    {
        public FrmLietKePhieuGuiTrongKhoangThoiGian()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            var ngaybatdau = txtNgaybatdau.Value.ToString("yyyy-MM-dd");
            var ngayketthuc = txtNgayketthuc.Value.ToString("yyyy-MM-dd");

            
            var report = new Report_LietKePhieuGuiTrongKhoangThoiGian();
            report.Parameters["Ngaybatdau"].Value = ngaybatdau;
            report.Parameters["Ngayketthuc"].Value = ngayketthuc;

            report.Parameters["Ngaybatdau"].Visible = false;
            report.Parameters["Ngayketthuc"].Visible = false;
            report.ShowPreview();
        }
    }
}