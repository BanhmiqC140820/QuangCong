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

namespace QLCoffee
{
    public partial class FormQLHD : Form
    {
        public FormQLHD()
        {
            InitializeComponent();
            Loaddata();
        }
        void Loaddata()
        {
            var db = new CoffeDB();
            var ls = db.HoaDons.Select(e => new HoaDon
            {
                MaHD = e.MaHD,
                MaHDS = e.MaHDS,
                MaKH = e.MaKH,
                MaNV = e.MaNV,
                TongTien = e.TongTien,
                NgayMua = e.NgayMua,
                DaMua = e.DaMua,
            }).ToList();
            hoaDonBindingSource.DataSource = ls;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selhd=hoaDonBindingSource.Current as HoaDon;
            dateTuNgay.Value = (DateTime)selhd.NgayMua;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selHD = hoaDonBindingSource.Current as HoaDon;
            if (selHD != null)
            {
                var f = new FormHoaDon(selHD);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Loaddata();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new FormHoaDon();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Loaddata();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new CoffeDB();
            var dt =dateTuNgay.Value;
            var dn = dateTimePicker2.Value;
            var ls = db.HoaDons.Where(t => (t.NgayMua >= dt && t.NgayMua<=dn)).ToList();
            hoaDonBindingSource.DataSource = ls;
        }
    }
}
