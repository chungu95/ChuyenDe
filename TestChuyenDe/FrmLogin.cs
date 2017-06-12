using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connect.Username = txtLoginName.Text;
            Connect.Password = txtPassword.Text;
            SqlConnection con = Connect.GetConnection();
            if (con != null && con.State == ConnectionState.Open)
            {
                MessageBox.Show("kết nối thành công");

            }
            else if (con.State == ConnectionState.Closed)
            {
                MessageBox.Show("kết nối đã đóng");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

    }
}
