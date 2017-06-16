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
        private int mode;
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


        private void clearEdit()
        {
            tbMADV.Text = "";
            tbKYHAN.Text = "";
            tbTENDV.Text = "";
        }

        private void enableEdit()
        {
            tbMADV.Enabled = true;
            tbKYHAN.Enabled = true;
            tbTENDV.Enabled = true;
        }

        private void disableEdit()
        {
            tbMADV.Enabled = false;
            tbKYHAN.Enabled = false;
            tbTENDV.Enabled = false;
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

        private void btnThemDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enableEdit();
            clearEdit();
            //gridView1.RefreshData
            btnGhi.Text = "Thêm";
            mode = 1;
           


         }

        private void btnXoaDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enableEdit();
            clearEdit();
            btnGhi.Text = "Xóa";
            mode = 2;
               
            

        }

        private void btnSửa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            enableEdit();
            clearEdit();
            btnGhi.Text = "Sửa";
            mode = 3;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connect.GetConnection();
            if (mode == 1)
            {
                string madv = tbMADV.Text;
                string tendv = tbTENDV.Text;
                string kyhan = tbKYHAN.Text;
                using (SqlCommand spCommand = con.CreateCommand())
                {
                    spCommand.CommandText = "SP_ThemDV";
                    spCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    spCommand.Parameters.AddWithValue("@MADV", madv);
                    spCommand.Parameters.AddWithValue("@KYHAN", kyhan);
                    spCommand.Parameters.AddWithValue("@TENDV", tendv);
                    try
                    {
                        spCommand.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                    }
                   catch (Exception ex) { }
                    gridView1.RefreshData();

                }
            }
        }
    }
}