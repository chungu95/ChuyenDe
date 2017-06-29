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
        private int mode=0;
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
            mode = 2;
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

        private Boolean checknhaplieu()
        {
            if (string.IsNullOrWhiteSpace(txthoten.Text))
            {
                MessageBox.Show("Bạn chưa điền họ tên");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtdiachi.Text))
            {
                MessageBox.Show("Bạn chưa điền địa chỉ");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtcmnd.Text))
            {
                MessageBox.Show("Bạn chưa điền CMND");
                return false;
            }
            if (txtcmnd.Text.Length < 9 || txtcmnd.Text.Length > 9)
            {
                MessageBox.Show("cmnd phải có 9 kí tự");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtsodt.Text))
            {
                MessageBox.Show("Bạn chưa điền số điện thoại");
                return false;
            }
            return true;
        }

        private void btnghi_Click(object sender, System.EventArgs e)
        {
            if (mode == 0)
            {
                MessageBox.Show("Bạn chưa chọn chế đô");
                return;
            }
           
            var sodt = txtsodt.Text;
            var cmnd = txtcmnd.Text;


            var con = Connect.GetConnection();
            if (mode == 1)
            {
                if (!checknhaplieu())
                {
                    return;
                }
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
                if (string.IsNullOrWhiteSpace(txtmagdv.Text))
                {
                    MessageBox.Show("Bạn chưa chọn GDV để sửa");
                    return;
                }
                if (!checknhaplieu())
                {
                    return;
                }
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
                if (string.IsNullOrWhiteSpace(txtmagdv.Text))
                {
                    MessageBox.Show("Bạn chưa chọn GDV để xóa");
                    return;
                }
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtsodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}