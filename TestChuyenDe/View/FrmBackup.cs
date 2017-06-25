using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestChuyenDe.DAL.connect;
using System.Data.SqlClient;

namespace TestChuyenDe.View
{
    public partial class FrmBackup : DevExpress.XtraEditors.XtraForm
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            SqlConnection con = Connect.GetConnection();
            tbdatabase.Text="HowKteam";
    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbvitriluu.Text = dlg.SelectedPath;
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
                  
            
            try
            {
                if (tbvitriluu.Text.Equals(""))
                {
                    MessageBox.Show("V? trí luu không du?c r?ng");
                    tbvitriluu.Focus();
                }
                
                if ((!(tbdatabase.Text.CompareTo("") == 0) && (!(tbvitriluu.Text.Equals("")))))
                {
                    SqlConnection con = Connect.GetConnection();
                    string sql = "BACKUP DATABASE " + tbdatabase.Text + " TO DISK = '" + tbvitriluu.Text + "\\" + tbdatabase.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Backup Thành Công.");
                }

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}