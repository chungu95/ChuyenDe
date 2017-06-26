using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestChuyenDe.DAL.connect;

namespace TestChuyenDe.View
{
    public partial class FrmLaiSuat : XtraForm
    {
        public FrmLaiSuat()
        {
            InitializeComponent();
        }

        private void getDichVu()
        {
            string sql = "Select * from DICHVU ";
            SqlConnection con = Connect.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            cbbDichVu.DisplayMember = "MADV";
            cbbDichVu.DataSource = dt;
          

        }
      

        private void FrmLaiSuat_Load(object sender, System.EventArgs e)
        {
            getDichVu();


        }

        private void cbbDichVu_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            txtlaisuat.Text = string.Empty;
            SqlConnection con = Connect.GetConnection();
            string sql = "select * from LAISUAT where MADV= '"+cbbDichVu.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var ngayad = reader["NGAYAD"];
                    var laisuat = reader["LAISUAT"].ToString();
                    dtngayad.Value = (DateTime)ngayad;
                    txtlaisuat.Text = laisuat;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            string newlaisuat= txtlaisuat.Text;
            float newlaisuatso = 0; 
            try
            {
                newlaisuatso = float.Parse(newlaisuat);
            }catch(Exception ex)
            {
                MessageBox.Show("Lãi suất phải là 1 chữ số");
                return;
            }
            string madv = cbbDichVu.Text;
            var newngayad = dtngayad.Value.ToString("yyyy-MM-dd");
            
            SqlConnection con = Connect.GetConnection();
            using (var spCommand = con.CreateCommand())
            {
                spCommand.CommandText = "SP_CAP_NHAT_LAI_SUAT";
                spCommand.CommandType = CommandType.StoredProcedure;
                spCommand.Parameters.AddWithValue("@MADV",madv);
                spCommand.Parameters.AddWithValue("@LAISUAT", newlaisuatso);
                spCommand.Parameters.AddWithValue("@NGAYAD", newngayad);

                try {
                    spCommand.ExecuteNonQuery();
                    MessageBox.Show("Sửa lãi suất thành công");
                    getDichVu();

                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}