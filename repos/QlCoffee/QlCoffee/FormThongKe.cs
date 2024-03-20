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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            loaddata();
        }

        void loaddata()
        {
            dataGridView1.Rows.Clear();
            DateTime now = DateTime.Today;
            var db = new CoffeDB();
            var thongKeTheoNgay = db.HoaDons
                  .Where(hd => hd.NgayMua.HasValue &&
                  hd.NgayMua.Value.Year == now.Year &&
                  hd.NgayMua.Value.Month == now.Month)
                 .GroupBy(hd => hd.NgayMua.Value.Day)
                 .Select(group => new
                 {
                     Ngay = group.Key,
                     TongTien = group.Sum(hd => hd.TongTien)
                 })
             .ToList();

            // Chuyển danh sách vào DataTable
            long TongDoanhThuThang = 0;
            foreach (var thongKe in thongKeTheoNgay)
            {
                TongDoanhThuThang += thongKe.TongTien;
                dataGridView1.Rows.Add(thongKe.Ngay, thongKe.TongTien);
            }
            label1.Text = "Tổng doanh thu tháng " + now.Month + " : " + TongDoanhThuThang.ToString();
            // Hiển thị DataTable trên DataGridView
            /*dataGridView1.DataSource = dataTable;*/
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DateTime thongke = dateTimePicker1.Value;
            var db = new CoffeDB();
            var thongKeTheoNgay = db.HoaDons
                  .Where(hd => hd.NgayMua.HasValue &&
                  hd.NgayMua.Value.Year == thongke.Year &&
                  hd.NgayMua.Value.Month == thongke.Month)
                 .GroupBy(hd => hd.NgayMua.Value.Day)
                 .Select(group => new
                 {
                     Ngay = group.Key,
                     TongTien = group.Sum(hd => hd.TongTien)
                 })
             .ToList();

            long TongDoanhThuThang = 0;
            foreach (var thongKe in thongKeTheoNgay)
            {
                TongDoanhThuThang += thongKe.TongTien;
                dataGridView1.Rows.Add(thongKe.Ngay, thongKe.TongTien);
            }
            label1.Text = "Tổng doanh thu tháng " + thongke.Month + " : " + TongDoanhThuThang;
            // Hiển thị DataTable trên DataGridView
            /*dataGridView1.DataSource = dataTable;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
