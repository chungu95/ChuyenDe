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
    public partial class FrmKhachHang : XtraForm
    {

        private int currentRow;
        private int mode;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void clearEdit()
        {
            txthoten.Text = string.Empty;
            txtcmnd.Text = string.Empty;
            txtdiachi.Text = string.Empty;
            ngaycap.Text = string.Empty;
        }

        private void enableEdit()
        {
            txthoten.Enabled = true;
            txtcmnd.Enabled = true;
            txtdiachi.Enabled = true;
            ngaycap.Enabled = true;
        }

        private void disableEdit()
        {
            txthoten.Enabled = false;
            txtcmnd.Enabled = false;
            txtdiachi.Enabled = false;
            ngaycap.Enabled = false;
        }

        private void getdata()
        {
            var con = Connect.GetConnection();
            string sp = "exec SP_DSKhachHang";
            var da = new SqlDataAdapter(sp, con);
            var dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gridControl1.DataSource = dt;
        }

        private void FrmKhachHang_Load(object sender, System.EventArgs e)
        {
            getdata();
        }

        private void btnthem_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableEdit();
            clearEdit();
            btnghi.Text = "Thêm";
            mode = 1;
        }

        private void btnsua_ItemClick(object sender, ItemClickEventArgs e)
        {
            enableEdit();
            btnghi.Text = "Sửa";
            txtcmnd.Enabled = false;
            mode = 2;
        }

        private void btnxoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            disableEdit();
            btnghi.Text = "Xóa";
            mode = 3;

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
        

                txthoten.Text = gridView1.GetFocusedDataRow()["HOTEN"].ToString();
                txtdiachi.Text = gridView1.GetFocusedDataRow()["DIACHI"].ToString();
                txtcmnd.Text = gridView1.GetFocusedDataRow()["CMND"].ToString();
                ngaycap.Value =(DateTime) gridView1.GetFocusedDataRow()["NGAYCAP"];      
            }

        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            var con = Connect.GetConnection();
            if (mode == 1)//them
            {
                var hoten = txthoten.Text;
                var diachi = txtdiachi.Text;
                var cmnd = txtcmnd.Text;
                var Ngaycap = ngaycap.Value.ToString("yyyy-MM-dd");

                using (var spCommand = con.CreateCommand())
                {

                    spCommand.CommandText = "SP_THEM_KHACH_HANG";
                    spCommand.CommandType = CommandType.StoredProcedure;

                    spCommand.Parameters.AddWithValue("@HOTEN", hoten);
                    spCommand.Parameters.AddWithValue("@DIACHI", diachi);
                    spCommand.Parameters.AddWithValue("@CMND", cmnd);
                    spCommand.Parameters.AddWithValue("@NGAYCAP", Ngaycap);

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
            else if (mode == 2)//sua
            {
                var hoten = txthoten.Text;
                var diachi = txtdiachi.Text;
                var cmnd = txtcmnd.Text;
                var Ngaycap = ngaycap.Value.ToString("yyyy-MM-dd");
                using (var spCommand = con.CreateCommand())
                {
                    spCommand.CommandText = "SP_SUA_KHACH_HANG";
                    spCommand.CommandType = CommandType.StoredProcedure;

                    spCommand.Parameters.AddWithValue("@HOTEN", hoten);
                    spCommand.Parameters.AddWithValue("@DIACHI", diachi);
                    spCommand.Parameters.AddWithValue("@CMND", cmnd);
                    spCommand.Parameters.AddWithValue("@NGAYCAP", Ngaycap);
                    try
                    {
                        spCommand.ExecuteNonQuery();
                        MessageBox.Show("Sửa Khách Hàng thành công");
                        getdata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                }

            else if(mode == 3)//xoa
            {
                var cmnd = txtcmnd.Text;
                using (var spcommand = con.CreateCommand())
                {
                    spcommand.CommandText = "SP_XoaKhachHang";
                    spcommand.CommandType = CommandType.StoredProcedure;
                    spcommand.Parameters.AddWithValue("@cmnd", cmnd);
                    try
                    {
                        spcommand.ExecuteNonQuery();
                        MessageBox.Show("Xóa Khách Hàng thành công");
                        getdata();

                    } catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại");
                    }

                }

            }

            }
    }
    }
