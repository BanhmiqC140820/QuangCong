using QLCoffee;
using QLCoffee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlCoffee
{
    public partial class MenuHome : Form
    {
        public bool isThoat = true;
        public MenuHome(NhanVien nv = null)
        {
            InitializeComponent();
            if (nv != null)
            {
                toolStripLoai.Visible = false;
                toolStripNV.Visible = false;
                toolStripQLHD.Visible = false;
            }
            loaddata();
        }
        void loaddata()
        {

            var db = new CoffeDB();

            var ttngay = db.HoaDons.Where(t => t.NgayMua.Value.Date == DateTime.Today && t.DaMua == 1).Sum(t => t.TongTien);
            lbNgay.Text = ttngay.ToString();
            var ttThang = db.HoaDons
                    .Where(hd => hd.NgayMua.HasValue &&
                                 hd.NgayMua.Value.Month == DateTime.Now.Month &&
                                 hd.NgayMua.Value.Year == DateTime.Now.Year && hd.DaMua == 1)
                    .Sum(hd => hd.TongTien);
            lbThang.Text = ttThang.ToString();
        }
        public event EventHandler DangXuat;

        private void button2_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* isThoat = false;*/
            /*            this.Close();
                        var f = new LoginForm();
                        f.Show();*/
            DangXuat(this, new EventArgs());
        }

        private void MenuHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            var f = new FormQLSanPham();
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new FormQLLoaiCoffe();
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var f = new FormNV();
            f.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            var f = new FormQLHD();
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

        private void toolStripHoaDon_Click(object sender, EventArgs e)
        {
            var f = new FormHoaDon();
           
            if (f.ShowDialog() == DialogResult.OK)
            {
                loaddata();
            }
        }

        private void MenuHome_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            var f = new FormThongKe();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            var f= new FormKH();
            f.ShowDialog();
        }
    }
}
