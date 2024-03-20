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
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();
            Loaddata();
            txtMaNV.ReadOnly = true;
        }
        void Loaddata()
        {
            var db = new CoffeDB();
            var ls = db.NhanViens.Select(e => new NhanVien
            {
                MaNV = e.MaNV,
                Hovaten = e.Hovaten,
                Ngaysinh = e.Ngaysinh,
                SDT = e.SDT,
                Email = e.Email,
                DiaChi = e.DiaChi
            }).ToList();
            nhanVienBindingSource.DataSource = ls;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenNV.Text))
            {

                var db = new CoffeDB();
                var obj = new NhanVien
                {
                    MaNV = NhanVien.TaoMaNV(),
                    Hovaten = txtTenNV.Text,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    SDT = txtSDT.Text,
                    Ngaysinh = dtpNgaySinh.Value
                };
                db.NhanViens.Add(obj);
                db.SaveChanges();
                txtMaNV.Text = obj.MaNV;
                Loaddata();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selNV = nhanVienBindingSource.Current as NhanVien;

            if (selNV != null)
            {
                txtMaNV.Text = selNV.MaNV;
                txtTenNV.Text = selNV.Hovaten;
                txtDiaChi.Text = selNV.DiaChi;
                txtSDT.Text = selNV.SDT;
                txtEmail.Text = selNV.Email;
                dtpNgaySinh.Value = (DateTime)selNV.Ngaysinh;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var selNV = nhanVienBindingSource.Current as NhanVien;
            if (selNV != null)
            {
                var rs = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    var db = new CoffeDB();
                    db.NhanViens.Remove(selNV);
                    db.SaveChanges();
                    Loaddata();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenNV.Text))
            {

                var db = new CoffeDB();
                var obj = db.NhanViens.Where(e => e.MaNV == txtMaNV.Text).FirstOrDefault();
                if (obj != null)
                {
                    obj.SDT = txtTenNV.Text;
                    obj.Email = txtEmail.Text;
                    obj.DiaChi = txtDiaChi.Text;
                    obj.Hovaten = txtTenNV.Text;
                    obj.Ngaysinh = dtpNgaySinh.Value;
                    txtMaNV.Text = obj.MaNV;
                }
                db.SaveChanges();
                Loaddata();
            }
        }
    }
}
