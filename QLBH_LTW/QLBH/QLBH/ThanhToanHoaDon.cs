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
    public partial class ThanhToanHoaDon : Form
    {
        SqlConnection conn  = new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
        SqlDataAdapter da_hd;
        DataSet ds_hd = new DataSet();
        string tien = "";
        public ThanhToanHoaDon()
        {
            InitializeComponent();
            lblTen.Text = MENU.user;
        }

        private void ThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            ;
            da_hd = new SqlDataAdapter("select* from HOADON where TrangThaiThanhToan= 'C'", conn);
            da_hd.Fill(ds_hd, "HOADON");
            dtgHoaDon.DataSource = ds_hd.Tables["HOADON"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_hd.Tables["HOADON"].Columns[0];
            ds_hd.Tables["HOADON"].PrimaryKey = key;
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            MENU mnu = new MENU();
            mnu.Show();
            this.Hide();
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaHoaDon", "*" + txtMaHoaDon.Text + "*");
            (dtgHoaDon.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

      

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            DataRow dr = ds_hd.Tables["HOADON"].Rows.Find(dtgHoaDon.CurrentRow.Cells[0].Value.ToString());
            if (dr != null)
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                tien = dr["Tong"].ToString();
                MessageBox.Show("Tổng tiền thanh toán của bạn là: " + tien, "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                SqlCommand cmd = new SqlCommand("Update HOADON set TrangThaiThanhToan='R' where MaHoaDon='" + dr[0].ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                ds_hd.Tables[0].Rows.Remove(dr);
                txtMaHoaDon.Text = "";
            }
            else
            {
                MessageBox.Show("Hóa đơn bạn nhập không có dữ liệu. Vui lòng thử lại", "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void chitiet_Click(object sender, EventArgs e)
        {
            CHITIETHOADON.MHD = dtgHoaDon.CurrentRow.Cells[0].Value.ToString();
            CHITIETHOADON ctdh = new CHITIETHOADON();
            ctdh.Show();
            this.Hide();
        }
    }
}
