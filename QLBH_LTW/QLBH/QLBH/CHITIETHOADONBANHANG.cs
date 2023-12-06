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
    public partial class CHITIETHOADONBANHANG : Form
    {
        SqlConnection cnn;
        public static string mhd;
        public CHITIETHOADONBANHANG()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
        }

        private void CHITIETHOADONBANHANG_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqldt = new SqlDataAdapter("select HANGHOA.MaHangHoa,HANGHOA.TenHang,CHITIETBANHANG.SoLuong,HANGHOA.GiaBan from HANGHOA,CHITIETBANHANG where CHITIETBANHANG.MaHoaDon='"+mhd+"'and HANGHOA.MaHangHoa=CHITIETBANHANG.MaHang",cnn);
            DataSet dt = new DataSet();
            sqldt.Fill(dt);
            dtDSHH.DataSource=dt.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            KIEMTRAHOADONBANHANG kt = new KIEMTRAHOADONBANHANG();
            kt.Show();
            this.Hide();
        }
    }
}
