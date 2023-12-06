using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLBH
{
    public partial class MENU : Form
    {
        public static string user;
        public static string manv;
        public MENU()
        {
            InitializeComponent();
            lblUser.Text = user;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            NHAPHANG nhaphang = new NHAPHANG();
            nhaphang.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnKienTra_Click(object sender, EventArgs e)
        {
            KIEMTRAHH kiemtra = new KIEMTRAHH();
            kiemtra.Show();
            this.Hide();
        }

        private void btnThanhToanHD_Click(object sender, EventArgs e)
        {
            ThanhToanHoaDon TTHD = new ThanhToanHoaDon();
            TTHD.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BanHang Bh = new BanHang();
            Bh.Show();
            this.Hide();
        }

        private void btnKTHDBH_Click(object sender, EventArgs e)
        {
            KIEMTRAHOADONBANHANG ktra = new KIEMTRAHOADONBANHANG();
            ktra.Show();
            this.Hide();
        }
    }
}
