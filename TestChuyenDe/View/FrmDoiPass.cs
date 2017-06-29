using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.View
{
    public partial class FrmDoiPass : DevExpress.XtraEditors.XtraForm
    {
        public FrmDoiPass()
        {
            InitializeComponent();
            Load();}

        private new void Load()
        {
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try
            {
                String sql = "EXEC SP_LIET_KE_GDV_CO_LGNAME";
                SqlCommand sqlCommand = new SqlCommand(sql, con); SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
            }
            catch (Exception)
            {//
            }
            finally { Connect.CloseConnection(con); }
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
            }else
            {
                lblOk.ForeColor = Color.Red;
                lblOk.Text = "✗";
            }
        }

        private void cbbMaGDV_SelectionChangeCommitted(object sender, EventArgs e) 
        {
            DataTable dt = null;
            SqlConnection con = Connect.GetConnection();
            try{
                String sql = "EXEC SP_LGNAME_AND_NAME_VIA_MAGDV '"+cbbMaGDV.SelectedValue+"'";
                SqlCommand sqlCommand = new SqlCommand(sql, con);
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                sqlData.Fill(dt);
                lblLgName.Text = dt.Rows[0][0].ToString();
                txtHoten.Text = dt.Rows[0][1].ToString();
            }
            catch (Exception)
            {//
            }
            finally { Connect.CloseConnection(con); }
        }
    }
}