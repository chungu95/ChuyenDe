using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestChuyenDe.DAL.connect;
using TestChuyenDe.function;

namespace TestChuyenDe.View
{
    public partial class FrmGiaoDichVien : XtraForm
    {
        private int currentRow;
        private int mode;
        public FrmGiaoDichVien()
        {
            InitializeComponent();
        }

        private void clearEdit()
        {
            txtmagdv.Text = string.Empty;
            txthoten.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            txtcmnd.Text = string.Empty;
            txtsodt.Text = string.Empty;
        }

        private void enableEdit()
        {
           
            txthoten.Enabled = true;
            txtsodt.Enabled = true;
            txtdiachi.Enabled = true;
            txtcmnd.Enabled = true;
        }

        private void disableEdit()
        {
            txtmagdv.Enabled = false;
            txthoten.Enabled = false;
            txtsodt.Enabled = false;
            txtdiachi.Enabled = false;
            txtcmnd.Enabled = false;
        }

        private void getdata()
        {
            SqlConnection con = Connect.GetConnection();
            string sql = "exec SP_LietKeGDV";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gridControl1.DataSource = dt;

        }


        private void FrmGiaoDichVien_Load(object sender, System.EventArgs e)
        {
            getdata();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnghi.Text = "Thêm";
            mode = 1;
            enableEdit();
            clearEdit();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnghi.Text = "Sửa";
            mode = 3;
            enableEdit();

        }
        private void btnxoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            disableEdit();
            btnghi.Text = "Xóa";
            mode = 3;
        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {

                txtcmnd.Text = gridView1.GetFocusedDataRow()["CMND"].ToString();
                txtdiachi.Text = gridView1.GetFocusedDataRow()["DIACHI"].ToString();
                txthoten.Text = gridView1.GetFocusedDataRow()["HOTEN"].ToString();
                txtmagdv.Text = gridView1.GetFocusedDataRow()["MAGDV"].ToString();
                txtsodt.Text = gridView1.GetFocusedDataRow()["SODT"].ToString();

            }
        }

        private void btnghi_Click(object sender, System.EventArgs e)
        {
            var sodt = txtsodt.Text;
            var cmnd = txtcmnd.Text;
            int sodtso = 0;
            int cmndso = 0;
            try
            {
                sodtso = int.Parse(sodt);
                cmndso = int.Parse(cmnd);
                
            }catch(Exception ex)
            {
                MessageBox.Show("Số điện thoại hoặc cmnd phải là số");
                return;
            }

            var con = Connect.GetConnection();
            if (mode == 1)
            {
                var magdv = RandomKey.GetRandomKey(7);
               
                var hoten = txthoten.Text;
                
                var diachi = txtdiachi.Text;


                using (var command = con.CreateCommand())
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_ThemGDV";
                    command.Parameters.AddWithValue("@MAGDV", magdv);
                    command.Parameters.AddWithValue("@CMND", cmnd);
                    command.Parameters.AddWithValue("@HOTEN", hoten);
                    command.Parameters.AddWithValue("@DIACHI", diachi);
                    command.Parameters.AddWithValue("@SODT", sodt);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm giao dịch viên thành công");
                        getdata();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (mode == 2)
            {
                txtmagdv.Enabled = false;
                var magdv = txtmagdv.Text;
                
                var hoten = txthoten.Text;
                
                var diachi = txtdiachi.Text;
                using (var command = con.CreateCommand())
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_SuaGDV";
                    command.Parameters.AddWithValue("@MAGDV", magdv);
                    command.Parameters.AddWithValue("@CMND", cmnd);
                    command.Parameters.AddWithValue("@HOTEN", hoten);
                    command.Parameters.AddWithValue("@DIACHI", diachi);
                    command.Parameters.AddWithValue("@SODT", sodt);


                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sửa thông tin giao dịch viên thành công");
                        getdata();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            else if (mode == 3)
            {

                var magdv = txtmagdv.Text;
                using (var command = con.CreateCommand())
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_XoaGDV";
                    command.Parameters.AddWithValue("@MAGDV", magdv);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa giao dịch viên thành công");
                        getdata();
                        clearEdit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


        }

    }
    }