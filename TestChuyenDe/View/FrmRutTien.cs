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
    public partial class FrmRutTien : XtraForm
    {
        public FrmRutTien()
        {
            InitializeComponent();
        }
        private void cbbCMND_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefreshTTPGComponents();LoadDsPhieuGui(cbbCMND.SelectedValue.ToString());
            LoadThongTinKhachHang(cbbCMND.SelectedValue.ToString());
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            LoadDsKhachHang();
            txtNgayRut.Text = DateConverter.GetCurrentDateString();
            btnLapPhieu.Enabled = false;}
        private void LoadDsKhachHang()
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
                finally { Connect.CloseConnection(con); }
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
        }private void LoadThongTinKhachHang(string cmnd)
        {
            KhachHang khachhang = KhachHang.GetDsKhachHang(cmnd);
            if (khachhang != null)
            {
                txtHoTen.Text = khachhang.HoTen;
                txtDiaChi.Text = khachhang.DiaChi;
                txtNgayCap.Text = khachhang.NgayCap.ToString(CultureInfo.InvariantCulture);
            }
        }
        private void LoadDsPhieuGui(string cmnd)
        {
            DataTable dataTable = PhieuGui.PhieuGuiByCmnd(cmnd);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                cbbMaPhieuGui.ValueMember = "MaPhieu";
                cbbMaPhieuGui.DisplayMember = "MaPhieu";
                cbbMaPhieuGui.DataSource = dataTable;
            }
            else
            {
                RefreshTTPGComponents();
                cbbMaPhieuGui.DataSource = null;}
        }
        private void LoadThongTinPhieuGui(string maphieu)
        {
            PhieuGui phieugui = PhieuGui.GetPhieuGui(maphieu);
            if (phieugui != null)
            {txtDichVu.Text = phieugui.Dichvu.Tendv;
                txtKyHan.Text = phieugui.Dichvu.Kyhan.ToString();
                txtNgayGui.Text = phieugui.NgayGui.ToString();
                txtNgayDenHan.Text = phieugui.NgayDenHan.ToString();
                if (DateTime.Today < phieugui.NgayDenHan)
                {
                    txtLaiSuat.Text = DichVu.GetDichVuByMaDv(phieugui.Madv).LaiSuat.Laisuat.ToString();
                }
                else
                {
                    txtLaiSuat.Text = phieugui.Laisuat.ToString();
                }
                txtSoTienGui.Text = phieugui.SoTienGui.ToString();
            }
        }
        private void cbbMaPhieuGui_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbbMaPhieuGui.SelectedValue != null)
            {
                LoadThongTinPhieuGui(cbbMaPhieuGui.SelectedValue.ToString());
                btnTinhLai.Enabled = true;}
        }
        private void btnTinhLai_Click(object sender, EventArgs e)
        {
            if (txtSoTienRut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số tiền rút");
            }
            else
            {
                PhieuGui phieugui = PhieuGui.GetPhieuGui(cbbMaPhieuGui.SelectedValue.ToString());
                txtTienLai.Text = PhieuRut.TinhTienLai(phieugui, 0).ToString();
                try
                {
                    txtTongTien.Text = (Decimal.Parse(txtSoTienRut.Text) + Decimal.Parse(txtTienLai.Text)).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("vui lòng nhập số");
                }
                btnLuuPhieu.Enabled = true;
            }
        }
        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (txtSoTienRut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số tiền rút");
            }
            else
            {
                PhieuRut phieurut = new PhieuRut();
                phieurut.MaPhieuGui = cbbMaPhieuGui.SelectedValue.ToString();
                try
                {
                    phieurut.SoTienRut = Decimal.Parse(txtSoTienRut.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập số!");
                    return;
                }
                phieurut.TienLai = Decimal.Parse(txtTienLai.Text);
                if (PhieuRut.LuuPhieuRut(phieurut, Login.LgName))
                {
                    MessageBox.Show("Lập phiếu rút thành công");
                    RefreshTTPGComponents();
                }
                else
                {
                    MessageBox.Show("Lập phiếu thất bại");
                }
            }
        }
        private void RefreshTTPGComponents()
        {
            txtDichVu.Text = "";
            txtKyHan.Text = "";
            txtNgayGui.Text = "";
            txtNgayDenHan.Text = "";
            txtLaiSuat.Text = "";
            txtTienLai.Text = "";
            txtSoTienGui.Text = "";
            btnTinhLai.Enabled = false;
            btnLuuPhieu.Enabled = false;
        }
    }
}