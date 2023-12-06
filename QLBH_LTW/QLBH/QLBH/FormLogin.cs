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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=NHATANH;Initial Catalog=QLBH;Integrated Security=True");
        }
        SqlConnection cnn;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0)
            {
                if (txtPass.Text.Length > 0)
                {
                    SqlDataAdapter tkhoan = new SqlDataAdapter("select Username,Password from TAIKHOAN where Username='" + txtUser.Text + "'", cnn);
                    DataSet admin = new DataSet();
                    tkhoan.Fill(admin);
                    if (admin.Tables[0].Rows.Count > 0)
                    {
                        string s="";
                        foreach (DataRow dr in admin.Tables[0].Rows)
                            s = dr[1].ToString();
                            if (txtPass.Text == s.Trim())
                        {
                            SqlDataAdapter name = new SqlDataAdapter("select * from TAIKHOAN where Username='" + txtUser.Text + "'", cnn);
                            DataSet dt = new DataSet();
                            name.Fill(dt);
                            string nm="";
                            string ma = "";
                            foreach (DataRow dtr in dt.Tables[0].Rows)
                            {
                                nm = dtr[3].ToString();
                                ma = dtr[2].ToString();
                            }
                            MENU.user = nm;
                            MENU.manv = ma;
                            MENU menu = new MENU();
                            menu.Show();
                            this.Hide();
                            return;
                        }
                            MessageBox.Show("Sai password");
                    }
                    else
                    {
                        MessageBox.Show("Sai user");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập password");
                    txtPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập user");
                txtUser.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtUser.Text.Length > 0)
                {
                    if (txtPass.Text.Length > 0)
                    {
                        SqlDataAdapter tkhoan = new SqlDataAdapter("select Username,Password from TAIKHOAN where Username='" + txtUser.Text + "'", cnn);
                        DataSet admin = new DataSet();
                        tkhoan.Fill(admin);
                        if (admin.Tables[0].Rows.Count > 0)
                        {
                            string s = "";
                            foreach (DataRow dr in admin.Tables[0].Rows)
                                s = dr[1].ToString();
                            if (txtPass.Text == s.Trim())
                            {
                                SqlDataAdapter name = new SqlDataAdapter("select * from TAIKHOAN where Username='" + txtUser.Text + "'", cnn);
                                DataSet dt = new DataSet();
                                name.Fill(dt);
                                string nm = "";
                                string ma = "";
                                foreach (DataRow dtr in dt.Tables[0].Rows)
                                {
                                    nm = dtr[3].ToString();
                                    ma = dtr[2].ToString();
                                }
                                MENU.user = nm;
                                MENU.manv = ma;
                                MENU menu = new MENU();
                                menu.Show();
                                this.Hide();
                                return;
                            }
                            MessageBox.Show("Sai password");
                            txtPass.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Sai user");
                            txtUser.Text = "";
                            txtPass.Text = "";
                            txtUser.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập password");
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập user");
                    txtUser.Focus();
                }
            }
        }
    }
}
