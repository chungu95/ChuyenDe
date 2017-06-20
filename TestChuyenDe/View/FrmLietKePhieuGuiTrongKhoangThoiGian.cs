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

            //SqlConnection con = Connect.GetConnection();
            //String sp = "exec SP_LietKePhieuGuiTrongKhoangThoiGian '" + ngaybatdau + "','" + ngayketthuc + "'";
            //SqlDataAdapter da2 = new SqlDataAdapter(sp, con); //chuyen du lieu ve
            //DataTable dt1 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            //da2.Fill(dt1);  // đổ dữ liệu vào kho
            //con.Close();  // đóng kết nối
            //gridControl1.DataSource = dt1;
            var report = new Report_LKPhieuGuiTheoThoiGian();
            report.Parameters["Ngaybatdau"].Value = ngaybatdau;
            report.Parameters["Ngayketthuc"].Value = ngayketthuc;

            report.Parameters["Ngaybatdau"].Visible = false;
            report.Parameters["Ngayketthuc"].Visible = false;
            report.ShowPreview();
        }
    }
}