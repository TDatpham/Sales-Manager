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
    public partial class NHAPHANG : Form
    {
        public NHAPHANG()
        {
            InitializeComponent();
           
            cnn = new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
            lblTen.Text = MENU.user;
            ds.Tables.Add("DSHH");
            ds.Tables[0].Columns.Add("MaHangHoa");
            ds.Tables[0].Columns.Add("TenHang");
            ds.Tables[0].Columns.Add("GiaMua");
            ds.Tables[0].Columns.Add("GiaBan");
            ds.Tables[0].Columns.Add("SoLuongMua");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables[0].Columns[0];
            ds.Tables[0].PrimaryKey = key;
            sqlds = new SqlDataAdapter("select * from HANGHOA", cnn);
            dtgDSHH.DataSource = ds.Tables[0];
            dtgDSHH.Columns[0].Width = dtgDSHH.Width / 5;
            dtgDSHH.Columns[0].HeaderText = "Mã Hàng Hóa";
            dtgDSHH.Columns[1].Width = dtgDSHH.Width / 5;
            dtgDSHH.Columns[1].HeaderText = "Tên Hàng Hóa";
            dtgDSHH.Columns[2].Width = dtgDSHH.Width / 5;
            dtgDSHH.Columns[2].HeaderText = "Giá Mua";
            dtgDSHH.Columns[3].Width = dtgDSHH.Width / 5;
            dtgDSHH.Columns[3].HeaderText = "Giá Bán";
            dtgDSHH.Columns[4].Width = dtgDSHH.Width / 5;
            dtgDSHH.Columns[4].HeaderText = "Số lượng";
            txtMaHang.Focus();
        }
        private void Tong()
        {
            tg = 0;
            foreach(DataRow rw in ds.Tables[0].Rows)
            {
                tg += int.Parse(rw[2].ToString()) * int.Parse(rw[4].ToString());
               
            }
            lblsum.Text = tg.ToString();
        }
        
        SqlConnection cnn;
        SqlDataAdapter sqlds;
        DataSet ds = new DataSet();
        int tg = 0;
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Enabled == true)
            {
                if (txtGiaBan.Text.Length > 0 && txtGiaMua.Text.Length > 0 && txtMaHang.Text.Length > 0 && txtTenHang.Text.Length > 0 &&txtSL.Text.Length>0)
                {
                    DataRow newrow = ds.Tables[0].NewRow();
                    newrow[0] = txtMaHang.Text;
                    newrow[1] = txtTenHang.Text;
                    newrow[2] = txtGiaMua.Text;
                    newrow[3] = txtGiaBan.Text;
                    newrow[4] = txtSL.Text;
                    ds.Tables[0].Rows.Add(newrow);
                    txtMaHang.Text = "";
                    txtMaHang.Focus();
                    Tong();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    txtMaHang.Focus();
                   
                }
            }
            else
            {
                DataRow dtr = ds.Tables[0].Rows.Find(dtgDSHH.CurrentRow.Cells[0].Value.ToString());
                dtr[1] = txtTenHang.Text;
                dtr[2] = txtGiaMua.Text;
                dtr[3] = txtGiaBan.Text;
                Tong();
            }
        }
        
        private void btnNewHD_Click(object sender, EventArgs e)
        {
            if (txtMAHD.Text.Length > 0)
            {
                DateTime dt = DateTime.Now;
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                SqlCommand cmd1 = new SqlCommand("insert HOADON values ('" + txtMAHD.Text + "','" + dt + "'," + lblsum.Text + ",'" + MENU.manv +"','C')", cnn);
                cmd1.ExecuteNonQuery();
                DataSet dt2 = new DataSet();
                dt2 = ds;
                dt2.Tables[0].Columns.Add("SoLuongBan");
                dt2.Tables[0].Columns.Add("MaHoaDon");
                foreach(DataRow rw in dt2.Tables[0].Rows)
                {
                    rw["SoLuongBan"] = 0;
                    rw["MaHoaDon"] = txtMAHD.Text;
                }
                SqlCommandBuilder newbuil = new SqlCommandBuilder(sqlds);
                sqlds.Update(dt2,"DSHH");
                
                MessageBox.Show("Tạo hóa đơn thành công");
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ctr.Text = "";
                    }
                }
                txtMaHang.Focus();
                ds.Clear();
                tg = 0;
                lblsum.Text = "0";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                txtMAHD.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MENU menu = new MENU();
            menu.Show();
            this.Hide();
        }

        private void sua_Click(object sender, EventArgs e)
        {

            txtMaHang.Text = dtgDSHH.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dtgDSHH.CurrentRow.Cells[1].Value.ToString();
            txtGiaMua.Text = dtgDSHH.CurrentRow.Cells[2].Value.ToString();
            txtGiaBan.Text = dtgDSHH.CurrentRow.Cells[3].Value.ToString();
            txtSL.Text = dtgDSHH.CurrentRow.Cells[4].Value.ToString();
            txtMaHang.Enabled = false;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            DataRow dtr = ds.Tables[0].Rows.Find(dtgDSHH.CurrentRow.Cells[0].Value.ToString());
            ds.Tables[0].Rows.Remove(dtr);
            Tong();
        }
    }
}
