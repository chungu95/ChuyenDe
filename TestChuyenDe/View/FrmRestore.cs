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
using System.Data.SqlClient;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.View
{
    public partial class FrmRestore : DevExpress.XtraEditors.XtraForm
    {
        public FrmRestore()
        {
            InitializeComponent();
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txbrowser.Text = dlg.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string db = "HowKteam";
            try
            {
                SqlConnection con = Connect.GetConnection();
                string sql = "Alter Database " + db + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    sql += "Restore Database " + db + " FROM Disk = '" + txbrowser.Text + "' WITH REPLACE;";
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                     con.Close();
                    MessageBox.Show("Restore thành công");
                    this.Refresh();
                  
          
            }
            catch
            {

            }
        }
    }
}