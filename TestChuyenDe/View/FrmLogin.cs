using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestChuyenDe.DAL.connect;
using TestChuyenDe.View;
using TestChuyenDe.Model;

namespace TestChuyenDe {
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.LgName = txtLoginName.Text.Trim();
            Login.Password = txtPassword.Text.Trim();
            Connect.ConnectionString = "Data Source=" + Connect.DatasourceName + ";Initial Catalog=" + Connect.DatabaseName +
                               ";User ID=" + Login.LgName + ";Password=" + Login.Password;
            var con = Connect.GetConnection();
            if (con != null && con.State == ConnectionState.Open)
            {
                Login.doLogin();
                new MainForm().Show();Hide();}
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
    }
}