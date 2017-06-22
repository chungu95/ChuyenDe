using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TestChuyenDe.View
{
    public partial class FrmGuiTien : XtraForm
    {
        public FrmGuiTien()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            dateTimePicker1.MinDate = DateTime.Today;
//            dateTimePicker1.ShowUpDown = true;
        }private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {

        }
    }
}