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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace TestChuyenDe.View
{
    public partial class FrmBackup2 : DevExpress.XtraEditors.XtraForm
    {
        string date;
        string position;
        public FrmBackup2()
        {
            InitializeComponent();
        }
        private void getdata()
        {
            SqlConnection con = Connect.GetConnection();
            String sp = "Exec SP_STT_BACKUP";
            SqlDataAdapter da = new SqlDataAdapter(sp, con);
            var dt = new DataSet();
            da.Fill(dt);
            gridControl1.DataSource = dt.Tables[0];
        }

        private void FrmBackup2_Load(object sender, EventArgs e)
        {

            getdata();


        }

        private void btnbackup_Click(object sender, EventArgs e)
        {

            string sql = "";
            if (cbreset.Checked)
            {
                sql = "BACKUP DATABASE TKBUUDIEN TO DEVICE_TKBUUDIEN WITH INIT";


            }
            else
            {
                sql = "BACKUP DATABASE TKBUUDIEN TO DEVICE_TKBUUDIEN";
            }
            using (SqlConnection con = Connect.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Backup thành công");
                    getdata();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }



        }

        private void cbreset_CheckedChanged(object sender, EventArgs e)
        {


        }

      

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            position=gridView1.GetFocusedDataRow()["position"].ToString();
            
        }

   



    private void btnrestore_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnrestore_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(position);
            SqlConnection con = Connect.GetConnection();
            string sql = "ALTER DATABASE TKBUUDIEN SET SINGLE_USER WITH ROLLBACK IMMEDIATE  " + "USE tempdb " + "RESTORE DATABASE TKBUUDIEN FROM DEVICE_TKBUUDIEN  WITH FILE= " + position + ", REPLACE  " + "ALTER DATABASE TKBUUDIEN  SET MULTI_USER ";
            SqlCommand command = new SqlCommand(sql, con);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("restore thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}