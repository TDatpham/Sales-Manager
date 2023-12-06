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
    public partial class KIEMTRAHH : Form
    {
        SqlConnection conn;
        public KIEMTRAHH()
        {
            InitializeComponent();
            conn= new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
            lblTen.Text = MENU.user;
        }
        private void Show()
        {
            if(conn.State==ConnectionState.Closed)
            conn.Open();
            string sql = "select * from HANGHOA";  // lay het du lieu trong bang hang hoa
            SqlCommand com = new SqlCommand(sql, conn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            conn.Close();  // đóng kết nối
            dtgHH.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            string rowFilter = string.Format("{0} like '{1}'", "TenHang", "*" + txttk.Text + "*");
            (dtgHH.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MENU mnu = new MENU();
            mnu.Show();
            this.Hide();
        }

        
    }
}
