using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestChuyenDe.DAL.connect;
using TestChuyenDe.function;
using TestChuyenDe.Model;

namespace TestChuyenDe.View
{
    public partial class FrmGuiTien : XtraForm
    {
        public FrmGuiTien()
        {
            InitializeComponent();
        }

        private void FrmGuiTien_Load(object sender, EventArgs e){
            LoadThongTinKh();
            LoadAllDv();
        }

        private void cbbCMND_SelectedIndexChanged(object sender, EventArgs e)
        {KhachHang khachhang = KhachHang.GetDsKhachHang(cbbCMND.SelectedValue.ToString());
            if (khachhang!=null){
                lblHoTen.Text = khachhang.HoTen;
                lblDiaChi.Text = khachhang.DiaChi;
                lblNgayCap.Text = khachhang.NgayCap.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void cbbMaDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThongTinDv(cbbMaDichVu.SelectedValue.ToString());
        }

        private void btnLapPhieuMoi_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = RandomKey.GetRandomKey(9);
            txtNgayGui.Text = DateConverter.GetCurrentDateString();
            btnLapPhieuMoi.Enabled = false;
            btnLuuPhieu.Enabled = true;
            btnXoaPhieu.Enabled = true;
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            RefreshComponents();
        }
        private void LoadThongTinKh ()
        {
                        DataTable dt = null;
                        SqlConnection con = Connect.GetConnection();
                        try
                        {
                            String sql = "SELECT CMND FROM KHACHHANG WHERE TRANGTHAI = 1";
                            SqlCommand sqlCommand = new SqlCommand(sql, con);
                            SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                            dt = new DataTable();
                            sqlData.Fill(dt);
                        }
                        catch (Exception)
                        {//
                        }
                        finally { Connect.CloseConnection(con);}
                        if (dt != null)
                        {
                            cbbCMND.ValueMember = "CMND";
                            cbbCMND.DisplayMember = "CMND";
                            cbbCMND.DataSource = dt;
                            AutoCompleteStringCollection cmnd = new AutoCompleteStringCollection();
                            for (int i = 0; i <= dt.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j <= dt.Columns.Count - 1; j++)
                                    cmnd.Add(dt.Rows[i][j].ToString());
                            }
                            cbbCMND.AutoCompleteCustomSource = cmnd;
                            cbbCMND.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                            cbbCMND.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        }
        }
        private void LoadThongTinDv(string madv){
            DichVu dichvu = DichVu.GetDichVuByMaDv(madv);
            if (dichvu != null)
            {
                lblMaDichVu.Text = dichvu.Madv;
                lblTenDichVu.Text = dichvu.Tendv;
                lblKyHan.Text = dichvu.Kyhan.ToString();
                lblLaiSuat.Text = dichvu.LaiSuat.Laisuat.ToString(CultureInfo.InvariantCulture);
                if (dichvu.Kyhan == 0)
                {
                    txtNgayDenHan.Text = DateTime.MaxValue.ToString(); 
                }
                else
                {
                    txtNgayDenHan.Text = DateConverter.LayNgayDenHan(dichvu.Kyhan).ToString(CultureInfo.InvariantCulture);
                }
            }
        }
        private void LoadAllDv()
        {
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "SELECT MADV FROM DICHVU";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
            }
            catch (Exception)
            {//
            }
            finally { Connect.CloseConnection(con); }
            if (dt != null && dt.Rows.Count > 0)
            {
                cbbMaDichVu.ValueMember = "MADV";
                cbbMaDichVu.DisplayMember = "MADV";
                cbbMaDichVu.DataSource = dt;
            }
        }
        private void RefreshComponents(){
            txtMaPhieu.Text = "";
            txtNgayGui.Text = "";
            txtNgayDenHan.Text = "";
            btnLuuPhieu.Enabled = false;
            btnLapPhieuMoi.Enabled = true;
            btnXoaPhieu.Enabled = false;
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (txtSoTienGui.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số tiền");
            }
            if (Decimal.Parse(txtSoTienGui.Text) < 100000)
            {
                MessageBox.Show("Số tiền gửi phải lớn hơn hoặc bằng 100.000");
            }
            else
            {
                PhieuGui phieugui = new PhieuGui();
                phieugui.MaPhieu = txtMaPhieu.Text;
                phieugui.Madv = cbbMaDichVu.SelectedValue.ToString();
                phieugui.Cmnd = cbbCMND.SelectedValue.ToString();
                phieugui.NgayDenHan = DateConverter.LayNgayDenHan(Int32.Parse(lblKyHan.Text));
                phieugui.SoTienGui = Decimal.Parse(txtSoTienGui.Text);
                if (PhieuGui.LuuPhieuGui(phieugui, Login.LgName))
                {
                    MessageBox.Show("Thêm thành công phiếu gửi");
                    RefreshComponents();}
                else
                {
                    MessageBox.Show("Thêm thất bại");}
            }
        }
    }
}