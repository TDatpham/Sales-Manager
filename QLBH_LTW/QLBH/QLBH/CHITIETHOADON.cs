using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
   
    public partial class CHITIETHOADON : Form
    {
        public static string MHD;
        SqlConnection cnn;
        public CHITIETHOADON()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
            SqlDataAdapter sqldt = new SqlDataAdapter("select MaHangHoa,TenHang,GiaMua,SoLuongMua from HANGHOA where MaHoaDon='" + MHD + "'", cnn);
            DataSet ds = new DataSet();
            sqldt.Fill(ds);
            dtgCTHD.DataSource = ds.Tables[0];
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            KIEMTRAHOADONBANHANG kt = new KIEMTRAHOADONBANHANG();
            kt.Show();
            this.Hide();
        }
    }
}
