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
        private static bool chonDV = false;
        private static bool chonKH = false;
        public FrmGuiTien(){
            InitializeComponent();
            FormLoad();
        }

        public void FormLoad()  
        {
            LoadThongTinKh();
            LoadAllDv();
        }

        private void cbbCMND_SelectionChangeCommitted(object sender, EventArgs e){KhachHang khachhang = KhachHang.GetDsKhachHang(cbbCMND.SelectedValue.ToString());
            if (khachhang!=null){
                lblHoTen.Text = khachhang.HoTen;
                lblDiaChi.Text = khachhang.DiaChi;
                lblNgayCap.Text = khachhang.NgayCap.ToString(CultureInfo.InvariantCulture);
                chonKH = true;
                if (btnLapPhieuMoi.Enabled == false && chonDV)
                    btnLuuPhieu.Enabled = true;
            }
        } 

        private void cbbMaDichVu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadThongTinDv(cbbMaDichVu.SelectedValue.ToString());
            chonDV = true;
            if (btnLapPhieuMoi.Enabled == false && chonKH)
                btnLuuPhieu.Enabled = true;
        } 
        private void btnLapPhieuMoi_Click(object sender, EventArgs e){
            txtMaPhieu.Text = RandomKey.GetRandomKey(9);
            txtNgayGui.Text = DateConverter.GetCurrentDateString();
            btnLapPhieuMoi.Enabled = false;
            btnXoaPhieu.Enabled = true;
            if (chonDV && chonKH)
            {
                btnLuuPhieu.Enabled = true;
            }
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
                    txtNgayDenHan.Text = DateTime.MaxValue.ToString(CultureInfo.CurrentCulture); 
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
            // refresh  toàn bộ form.
            txtMaPhieu.Text = "";
            txtNgayGui.Text = "";
            txtNgayDenHan.Text = "";
            txtSoTienGui.Text = "";
            lblHoTen.Text = "";
            lblDiaChi.Text = "";
            lblNgayCap.Text = "";
            lblTenDichVu.Text = "";
            lblNgayDenHan.Text = "";
            lblLaiSuat.Text = "";
            btnLuuPhieu.Enabled = false;
            btnLapPhieuMoi.Enabled = true;
            btnXoaPhieu.Enabled = false;
            chonDV = false;
            chonKH = false;
        }
        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (txtSoTienGui.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số tiền");
                return;
            }
            try
            {
                if (Decimal.Parse(txtSoTienGui.Text.Trim()) < 100000)
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
                    phieugui.SoTienGui = Decimal.Parse(txtSoTienGui.Text.Trim());
                    if (PhieuGui.LuuPhieuGui(phieugui, Login.LgName))
                    {
                        MessageBox.Show("Thêm thành công phiếu gửi");RefreshComponents();}
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }}
            catch (FormatException)
            {
                txtSoTienGui.Text = "";
                MessageBox.Show("Số tiền phải là chữ số");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
//                FrmLogin.form.Hide();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}