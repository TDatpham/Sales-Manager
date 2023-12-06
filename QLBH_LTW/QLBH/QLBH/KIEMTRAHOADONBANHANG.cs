using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLBH
{
    public partial class KIEMTRAHOADONBANHANG : Form
    {

        SqlConnection cnn;
        public KIEMTRAHOADONBANHANG()
        {
            InitializeComponent();
            lblten.Text = MENU.user;
            cnn = new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
        }
        SqlDataAdapter adapter;
        private void KIEMTRAHOADONBANHANG_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from HOADONBANHANG",cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dtgHoaDon.DataSource = ds.Tables[0];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables[0].Columns[0];
            ds.Tables[0].PrimaryKey = key;
        }

        private void txtMHD_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaHoaDon", "*" + txtMHD.Text + "*");
            (dtgHoaDon.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void dtgHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CHITIETHOADONBANHANG.mhd = dtgHoaDon.CurrentRow.Cells[0].Value.ToString();
            CHITIETHOADONBANHANG cthd = new CHITIETHOADONBANHANG();
            cthd.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MENU mn = new MENU();
            mn.Show();
            this.Hide();
        }
    }
}
