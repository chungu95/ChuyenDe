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

namespace TestChuyenDe.View
{
    public partial class frmAddLogin : DevExpress.XtraEditors.XtraForm
    {
        public static class User
        {
            private static string loginName;
            private static string userName;
            private static string password;
            private static string role;
        } 
        public frmAddLogin()
        {
            InitializeComponent();
            loadGDV();
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
            cbbGiaoDichVien.ValueMember = "MAGDV";
            cbbGiaoDichVien.DataSource = dataTable;
        }


        private void rbGDV_CheckedChanged(object sender, EventArgs e)
        {
            cbbGiaoDichVien.Enabled = true;
            lblHoten.Visible = true;
            cbbGiaoDichVien.Visible = true;
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            cbbGiaoDichVien.Enabled = false;
            btnAddUser.Enabled = true;
            lblHoten.Visible = false;
            cbbGiaoDichVien.Visible = false;}

        private void cbbGiaoDichVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddLogin_Load(object sender, EventArgs e)
        {

        }
    }
}