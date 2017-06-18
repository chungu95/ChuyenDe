using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestChuyenDe.DAL.connect;
using TestChuyenDe.View;
using TestChuyenDe.Model;

namespace TestChuyenDe
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.LgName = txtLoginName.Text;
            Login.Password = txtPassword.Text;
            Connect.ConnectionString = "Data Source=" + Connect.DatasourceName + ";Initial Catalog=" + Connect.DatabaseName +
                               ";User ID=" + Login.LgName + ";Password=" + Login.Password;
            var con = Connect.GetConnection();
            if (con != null && con.State == ConnectionState.Open)
            {
                Form form = new MainForm();
                Hide();
                Login.doLogin();form.Show();
            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }
    }
}