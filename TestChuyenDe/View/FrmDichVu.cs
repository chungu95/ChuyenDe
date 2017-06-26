using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.View
{
    public partial class FrmDichVu : XtraForm
    {
        private int currentRow;
        private int mode;

        public FrmDichVu()
        {
            InitializeComponent();
        }

        public void gridControl1_Click(object sender, EventArgs e)
        {
        }


        private void clearEdit()
        {
            tbMADV.Text = string.Empty;
            tbKYHAN.Text = string.Empty;
            tbTENDV.Text = string.Empty;
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

        private void getdata()
        {
            var con = Connect.GetConnection();
            var sp = "exec SP_DICHVU";
            var da = new SqlDataAdapter(sp, con);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gridControl1.DataSource = dt;
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            getdata();
            
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                
                tbMADV.Text = gridView1.GetFocusedDataRow()["MADV"].ToString();
                tbKYHAN.Text = gridView1.GetFocusedDataRow()["KYHAN"].ToString();
                tbTENDV.Text = gridView1.GetFocusedDataRow()["TENDICHVU"].ToString();
               
            }
        }

        private void btnThemDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableEdit();
            clearEdit();
            btnGhi.Text = "Thêm";
            mode = 1;
        }

        private void btnXoaDV_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableEdit();
            clearEdit();
            btnGhi.Text = "Xóa";
            mode = 2;
        }

        private void btnSửa_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableEdit();
            clearEdit();
            btnGhi.Text = "Sửa";
            mode = 3;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            var con = Connect.GetConnection();
            if (mode == 1)
            {
                var madv = tbMADV.Text;
                var tendv = tbTENDV.Text;
                var kyhan = tbKYHAN.Text;
                using (var spCommand = con.CreateCommand())
                {
                    spCommand.CommandText = "SP_ThemDV";
                    spCommand.CommandType = CommandType.StoredProcedure;

                    spCommand.Parameters.AddWithValue("@MADV", madv);
                    spCommand.Parameters.AddWithValue("@KYHAN", kyhan);
                    spCommand.Parameters.AddWithValue("@TENDV", tendv);
                    try
                    {
                        spCommand.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        getdata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                    
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}