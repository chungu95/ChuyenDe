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
using System.Data.SqlClient;
using TestChuyenDe.DAL.connect;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace TestChuyenDe.View
{
    public partial class FrmLietKePhieuGuiTrongKhoangThoiGian : DevExpress.XtraEditors.XtraForm
    {
        public FrmLietKePhieuGuiTrongKhoangThoiGian()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            
            String ngaybatdau = txtNgaybatdau.Value.ToString("yyyy-MM-dd");
            String ngayketthuc = txtNgayketthuc.Value.ToString("yyyy-MM-dd");

            //SqlConnection con = Connect.GetConnection();
            //String sp = "exec SP_LietKePhieuGuiTrongKhoangThoiGian '" + ngaybatdau + "','" + ngayketthuc + "'";
            //SqlDataAdapter da2 = new SqlDataAdapter(sp, con); //chuyen du lieu ve
            //DataTable dt1 = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            //da2.Fill(dt1);  // đổ dữ liệu vào kho
            //con.Close();  // đóng kết nối
            //gridControl1.DataSource = dt1;
            Report_LKPhieuGuiTheoThoiGian report = new Report_LKPhieuGuiTheoThoiGian();
            report.Parameters["Ngaybatdau"].Value = ngaybatdau;
            report.Parameters["Ngayketthuc"].Value = ngayketthuc;

            report.Parameters["Ngaybatdau"].Visible = false;
            report.Parameters["Ngayketthuc"].Visible = false;
            report.ShowPreview();
         







        }
    }
}