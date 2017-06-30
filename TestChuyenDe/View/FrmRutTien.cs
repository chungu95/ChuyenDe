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

        private void cbbCMND_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            RefreshTtpgComponents();LoadDsPhieuGui(cbbCMND.SelectedValue.ToString());
            LoadThongTinKhachHang(cbbCMND.SelectedValue.ToString());
        } 

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            LoadDsKhachHang();
            txtNgayRut.Text = DateConverter.GetCurrentDateString();
            btnLapPhieu.Enabled = false;}

        private void LoadDsKhachHang() {
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
        }

        private void LoadThongTinKhachHang(string cmnd){
            KhachHang khachhang = KhachHang.GetDsKhachHang(cmnd);
            if (khachhang != null)
            {
                txtHoTen.Text = khachhang.HoTen;
                txtDiaChi.Text = khachhang.DiaChi;
                txtNgayCap.Text = DateConverter.DateToString(khachhang.NgayCap);
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
                RefreshTtpgComponents();
                cbbMaPhieuGui.DataSource = null;}
        }

        private void LoadThongTinPhieuGui(string maphieu)
        {
            PhieuGui phieugui = PhieuGui.GetPhieuGui(maphieu);
            if (phieugui != null)
            {txtDichVu.Text = phieugui.Dichvu.Tendv;
                txtKyHan.Text = phieugui.Dichvu.Kyhan.ToString();
                txtNgayGui.Text = DateConverter.DateToString(phieugui.NgayGui); txtNgayDenHan.Text = DateConverter.DateToString(phieugui.NgayDenHan);
                txtLaiSuat.Text =  phieugui.Laisuat.ToString();
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
            else if (Decimal.Parse(txtSoTienRut.Text.Trim())<=0)
            {MessageBox.Show("Số tiền rút phải lớn hơn 0");
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

        private void btnLuuPhieu_Click(object sender, EventArgs e){
            if (txtSoTienRut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số tiền rút");
            }
            else
            {
                PhieuRut phieurut = new PhieuRut {MaPhieuGui = cbbMaPhieuGui.SelectedValue.ToString()};
                try
                {phieurut.SoTienRut = decimal.Parse(txtSoTienRut.Text, System.Globalization.NumberStyles.Float);
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập số!");
                    return;
                }
                if (Decimal.Parse(txtSoTienGui.Text) < phieurut.SoTienRut){MessageBox.Show("Số tiền rút phải nhỏ hơn số tiền còn dư trong phiếu gửi");
                    return;}
                phieurut.TienLai = Decimal.Parse(txtTienLai.Text);
                if (PhieuRut.LuuPhieuRut(phieurut, Login.LgName))
                {
                    MessageBox.Show("Lập phiếu rút thành công");
                    RefreshTtpgComponents();
                    RefreshTtkhComponents();
                    btnLapPhieu.Enabled = true;
                    txtNgayRut.Text = "";
                }
                else
                {
                    MessageBox.Show("Lập phiếu thất bại");
                }
            }
        }

        private void RefreshTtpgComponents()
        {
            txtDichVu.Text = "";
            txtKyHan.Text = "";
            txtNgayGui.Text = "";
            txtNgayDenHan.Text = "";
            txtLaiSuat.Text = "";
            txtTienLai.Text = "";
            txtSoTienGui.Text = "";
            txtSoTienRut.Text = "";
            txtTongTien.Text = "";btnTinhLai.Enabled = false;
            btnLuuPhieu.Enabled = false;
        }

        private void RefreshTtkhComponents(){
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtNgayCap.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }
        }

    }
}