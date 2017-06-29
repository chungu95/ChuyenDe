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
    public partial class FrmLaiSuat2 : DevExpress.XtraEditors.XtraForm
    {
        private int mode = 0;

        public FrmLaiSuat2()
        {
            InitializeComponent();
        }



        private void getDichVu()
        {
            string sql = "Select * from DICHVU ";
            SqlConnection con = Connect.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            cbbDichVu.DisplayMember = "MADV";
            cbbDichVu.DataSource = dt;
        }

        private void clearedit()
        {
            txtlaisuat.Text = string.Empty;

        }

        private void FrmLaiSuat2_Load(object sender, EventArgs e)
        {
          
        }



        private void cbbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtlaisuat.Text = string.Empty;
            SqlConnection con = Connect.GetConnection();
            string sql = "select * from LAISUAT where MADV= '" + cbbDichVu.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            try
            {
                da.Fill(dt);
                gridControl1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
      

        private void btnghi_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connect.GetConnection();
            if (mode == 0) {
                MessageBox.Show("Bạn chưa chọn chế độ");
                return;
            }
            string laisuatstr = txtlaisuat.Text;
            var ngayad = dtpngayapdung.Value.ToString("yyyy-MM-dd");

            try
            {
                float.Parse(laisuatstr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lãi suất phải là kiểu số và không được bỏ trống");
                return;
            }

            if (mode == 1)
            {
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = "SP_ThemNgayApDungLaiSuat";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LAISUAT", laisuatstr);
                    command.Parameters.AddWithValue("@NGAYAD", ngayad);
                    command.Parameters.AddWithValue("@MADV", cbbDichVu.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm lãi suất và ngày áp dụng thành công");
                        getDichVu();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

            }
            else if (mode == 2)
            {
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = "SP_SuaLaiSuat";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LAISUAT", laisuatstr);
                    command.Parameters.AddWithValue("@NGAYAD", ngayad);
                    command.Parameters.AddWithValue("@MADV", cbbDichVu.Text);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa lãi suất thành công");
                        getDichVu();
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

        private void FrmLaiSuat2_Load_1(object sender, EventArgs e)
        {
            getDichVu();

        }

        private void btnthem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtpngayapdung.Enabled = true;
            mode = 1;
            btnghi.Text = "Thêm";
            clearedit();
           
        }

        private void btnsua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = 2;
            btnghi.Text = "Sửa";
            dtpngayapdung.Enabled = false;
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {

                txtlaisuat.Text = gridView1.GetFocusedDataRow()["LAISUAT"].ToString();
                dtpngayapdung.Value = (DateTime)gridView1.GetFocusedDataRow()["NGAYAD"];


            }
        }
    }
}