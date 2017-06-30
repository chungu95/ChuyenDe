using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using TestChuyenDe.DAL.connect;
using TestChuyenDe.Model;

namespace TestChuyenDe.View
{
    public partial class FrmDoiPass : DevExpress.XtraEditors.XtraForm
    {
        public FrmDoiPass()
        {
            InitializeComponent();
            Load();
        }

        private new void Load()
        {
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "EXEC SP_LIET_KE_GDV_CO_LGNAME";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
            }
            catch (Exception)
            {
//
            }
            finally
            {
                Connect.CloseConnection(con);
            }
            if (dt != null && dt.Rows.Count > 0)
            {
                cbbMaGDV.ValueMember = "MAGDV";
                cbbMaGDV.DisplayMember = "MAGDV";
                cbbMaGDV.DataSource = dt;
            }
        }

        private void txtReType_TextChanged(object sender, EventArgs e)
        {
            if (txtReType.Text.Equals(txtNewPass.Text.Trim()))
            {
                lblOk.ForeColor = Color.Green;
                lblOk.Text = "✓";
            }
            else if (txtReType.Text.Equals(""))
            {
                lblOk.Text = "";
            }
            else
            {
                lblOk.ForeColor = Color.Red;lblOk.Text = "✗";
            }
        }

        private void cbbMaGDV_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "EXEC SP_LGNAME_AND_NAME_VIA_MAGDV '" + cbbMaGDV.SelectedValue + "'";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
                lblLgName.Text = dt.Rows[0][0].ToString();
                txtHoten.Text = dt.Rows[0][1].ToString();
            }
            catch (Exception)
            {
//
            }
            finally
            {
                Connect.CloseConnection(con);
            }
        }

        private void ChangePassword()
        {
            SqlConnection con = Connect.GetConnection();
            using (SqlCommand sqlCommand = con.CreateCommand())
            {
                sqlCommand.CommandText = "SP_DOI_PASS";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@LGNAME", lblLgName.Text);
                sqlCommand.Parameters.AddWithValue("@OLDPASS", txtOldPass.Text);
                sqlCommand.Parameters.AddWithValue("@NEWPASS", txtNewPass.Text);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    if (lblLgName.Text.Equals(Login.LgName))
                    {
                        Login.Password = txtNewPass.Text;
                        Connect.ConnectionString = "Data Source=" 
                            + Connect.DatasourceName + ";Initial Catalog=" 
                            + Connect.DatabaseName + ";User ID=" 
                            + Login.LgName + ";Password=" 
                            + Login.Password;
                    }
                    MessageBox.Show("Đổi mật khẩu thành công");
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
        }

        private void btnAccept_Click(object sender, EventArgs e){
            if (lblLgName.Text.Equals(""))
            {MessageBox.Show("Vui lòng chọn giao dịch viên");
            }
            else if (txtOldPass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ");
            }
            else if (txtNewPass.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
            }
            else if (!lblOk.Text.Equals("✓"))
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            }
            else
            {
                ChangePassword();
            }
        }
    }

}