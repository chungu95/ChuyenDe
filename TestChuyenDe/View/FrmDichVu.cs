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

        }

        private void btnXoaDV_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSửa_ItemClick(object sender, ItemClickEventArgs e)
        {

            clearEdit();
            btnGhi.Text = "Sửa";
            mode = 3;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            var madv = tbMADV.Text;
            var tendv = tbTENDV.Text;
            string kyhan = tbKYHAN.Text.Trim();
            if (string.IsNullOrWhiteSpace(tbMADV.Text))
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbKYHAN.Text))
            {
                MessageBox.Show("Bạn chưa nhập kỳ hạn");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbTENDV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên dịch vụ");
                return;
            }


            var con = Connect.GetConnection();
            if (mode == 3)
            {

                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = "SP_SUA_DICH_VU";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MADV", madv);
                    command.Parameters.AddWithValue("@TENDICHVU", tendv);
                    command.Parameters.AddWithValue("@KYHAN", kyhan);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa dịch vụ thành công");
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

        private void tbKYHAN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}