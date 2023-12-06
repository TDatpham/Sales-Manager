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
using System.Text.RegularExpressions;

namespace QLBH
{
    public partial class BanHang : Form
    {
        SqlConnection conn;
        public BanHang()
        {
            InitializeComponent();
            lblTen.Text = MENU.user;
            conn = new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
            dtset.Tables.Add("HANGHOA");
            dtset.Tables[0].Columns.Add("MaHang");
            dtset.Tables[0].Columns.Add("TenHangHoa");
            dtset.Tables[0].Columns.Add("Gia");
            dtset.Tables[0].Columns.Add("SoLuong");
            DataColumn[] key = new DataColumn[1];
            key[0]= dtset.Tables[0].Columns[0];
            dtset.Tables[0].PrimaryKey = key;
            dtgDS.DataSource = dtset.Tables[0];
        }
        DataSet dtset= new DataSet();
        int tg = 0;
        private void Tong()
       {
            tg = 0;
            foreach(DataRow rw in dtset.Tables[0].Rows)
            {
                tg += int.Parse(rw[2].ToString()) * int.Parse(rw[3].ToString());
            }
            lblTong.Text = tg.ToString();
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMH.Enabled == true)
            {
                if (txtMH.Text.Length > 0)
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select MaHangHoa,TenHang,GiaBan from HANGHOA where MaHangHoa='" + txtMH.Text + "'", conn);
                    DataSet dt = new DataSet();
                    adapter.Fill(dt);
                    foreach (DataRow rw in dt.Tables[0].Rows)
                    {
                        DataRow dtr = dtset.Tables[0].NewRow();
                        dtr[0] = rw[0];
                        dtr[1] = rw[1];
                        dtr[2] = rw[2];
                        dtr[3] = txtSL.Text;
                        dtset.Tables[0].Rows.Add(dtr);
                  
                    }

                    Tong();
                    txtMH.Text = "";
                    txtSL.Text = "";
                    txtMH.Focus();
                }
            }
            else
            {
                DataRow dtr = dtset.Tables[0].Rows.Find(dtgDS.CurrentRow.Cells[0].Value.ToString());
                dtr[3] = txtSL.Text;
                Tong();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MENU mn = new MENU();
            mn.Show();
            this.Hide();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            txtMH.Text = dtgDS.CurrentRow.Cells[0].Value.ToString();
            txtSL.Text = dtgDS.CurrentRow.Cells[3].Value.ToString();
            txtMH.Enabled = false;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            DataRow dtr = dtset.Tables[0].Rows.Find(dtgDS.CurrentRow.Cells[0].Value.ToString());
            dtset.Tables[0].Rows.Remove(dtr);
            Tong();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtMHD.Text.Length > 0)
            {
                DateTime dt = DateTime.Now;
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("insert into HOADONBANHANG values ('" + txtMHD.Text + "','" + dt + "'," +lblTong.Text+",'"+ MENU.manv + "')", conn);
                cmd.ExecuteNonQuery();
                foreach (DataRow rw in dtset.Tables[0].Rows)
                {
                    SqlCommand cmd1= new SqlCommand("update HANGHOA set SoLuongBan=" + rw[3].ToString() + "where MaHangHoa='" + rw[0].ToString() + "'", conn);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("insert into CHITIETBANHANG values ('" + txtMHD.Text + "','" + rw[0].ToString() + "'," + rw[2].ToString() + ")", conn);
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Tổng tiền thanh toán là:" + lblTong.Text, "Hóa đơn bán hàng");
                dtset.Clear();
                tg = 0;
                lblTong.Text = "0";
            }
        } 
    }
}
