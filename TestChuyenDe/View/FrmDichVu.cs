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

namespace TestChuyenDe.View
{
    public partial class FrmDichVu : DevExpress.XtraEditors.XtraForm
    {
        private int currentRow;

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            SqlConnection con = Connect.GetConnection();
            String sp = "exec SP_DICHVU";
            SqlDataAdapter da = new SqlDataAdapter(sp,con); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            gridControl1.DataSource = dt;

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                currentRow = gridView1.FocusedRowHandle;
                //gridView1.GetSelectedRows();
                //if (!button.Text.Equals("Them"))

                    tbMADV.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MADV");
                    //textMaKho.Text = Convert.ToString(result.Rows[currentRow].ItemArray[0]);
                    tbKYHAN.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KYHAN").ToString();
                    //textTen.Text = Convert.ToString(result.Rows[currentRow].ItemArray[1]);
                    tbTENDV.Text = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENDICHVU");
                    //textDC.Text = Convert.ToString(result.Rows[currentRow].ItemArray[2]);
                
            }
        }
    }
}