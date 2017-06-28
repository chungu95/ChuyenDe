using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestChuyenDe.DAL.connect;
using TestChuyenDe.Model;

namespace TestChuyenDe.View
{
    public partial class frmAddLogin : DevExpress.XtraEditors.XtraForm
    {
        private static string ROLE = "";
        public frmAddLogin()
        {
            InitializeComponent();
        }

        private void loadGDV()
        {
            string sql = "SELECT MAGDV,HOTEN FROM GDV";
            SqlConnection con = Connect.GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql,con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbbGiaoDichVien.DisplayMember = "HOTEN";
            cbbGiaoDichVien.ValueMember = "MAGDV";cbbGiaoDichVien.DataSource = dataTable;
        }

        private void rbGDV_CheckedChanged(object sender, EventArgs e)
        {
            ROLE = "GDV";
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            ROLE = "ADMIN";
        }

        private void cbbGiaoDichVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!CheckGDVCoTK(cbbGiaoDichVien.SelectedValue.ToString()))
            {
                btnAddUser.Enabled = true;
                txtUserName.Text = "";
                txtUserName.ReadOnly = false;
                btnXoaUser.Enabled = false;
                lblThongBao.Text = "";
            }
            else
            {
                lblThongBao.Text = "Nhân viên này đã có tài khoản";
                btnAddUser.Enabled = false;
                txtUserName.Text = LayLoginName(cbbGiaoDichVien.SelectedValue.ToString());
                txtUserName.ReadOnly = true;
                btnXoaUser.Enabled = true;
            }
        }
        private void frmAddLogin_Load(object sender, EventArgs e)
        {
            loadGDV();
        }

        private bool CheckGDVCoTK(string maGdv)
        {
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "EXEC SP_KIEM_TRA_LG '" + maGdv + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
            }
            catch (Exception)
            {//
            }
            finally { Connect.CloseConnection(con); }
            int result = Int32.Parse(dt.Rows[0][0].ToString());
            return (result==1);}

        private string LayLoginName(string maGdv)
        {

                DataTable dt = null;
                SqlConnection con = Connect.GetConnection();
                try
                {
                    String sql = "EXEC SP_LGNAME_VIA_MAGDV '" + maGdv + "'";
                    SqlCommand sqlCommand = new SqlCommand(sql, con);
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                    dt = new DataTable();
                    sqlData.Fill(dt);
                }
                catch (Exception)
                {//
                }
                finally { Connect.CloseConnection(con); }
                return dt.Rows[0][0].ToString();
            }

        private bool TaoLG()
        {
            bool result = false;
            SqlConnection con = Connect.GetConnection();
            using (SqlCommand sqlCommand = con.CreateCommand())
            {
                sqlCommand.CommandText = "SP_TAOLOGIN";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@LGNAME", txtUserName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@PASS", txtPass.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@USERNAME", cbbGiaoDichVien.SelectedValue.ToString());
                sqlCommand.Parameters.AddWithValue("@ROLE", ROLE);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connect.CloseConnection(con);
                }
            }
            return result;
        }

        private bool XoaLG()
        {
            bool result = false;
            SqlConnection con = Connect.GetConnection();
            using (SqlCommand sqlCommand = con.CreateCommand())
            {
                sqlCommand.CommandText = "Xoa_Login";sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@LGNAME", txtUserName.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@USERNAME", cbbGiaoDichVien.SelectedValue.ToString());
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connect.CloseConnection(con);
                }
            }
            return result;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Equals(""))
            {MessageBox.Show("Vui lòng nhập tên đăng nhập");
            }else if (txtPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else if(!rbGDV.Checked && !rbAdmin.Checked)
            {
                MessageBox.Show("Vui lòng chọn nhóm");
                return;
            }
            else
            {
                try
                {
                    if (TaoLG())
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtUserName.Text = "";
                        txtPass.Text = "";
                        btnAddUser.Enabled = false;
                        btnXoaUser.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoaUser_Click(object sender, EventArgs e){
            if (txtUserName.Text.Trim().Equals(Login.LgName))
            {
                MessageBox.Show("Bạn không thể xóa chính mình");
                return;}
            try
            {
                if (XoaLG())
                {
                    MessageBox.Show("Xóa thành công");
                    txtUserName.Text = "";
                    txtPass.Text = "";
                    lblThongBao.Text = "";
                    btnAddUser.Enabled = false;
                    btnXoaUser.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}