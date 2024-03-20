using QLCoffee.DTO;
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
    public partial class FormQLSanPham : Form
    {
        public FormQLSanPham()
        {
            InitializeComponent();
            loadData();
        }
  
        void loadData()
        {
            var db = new CoffeDB();
            var ls = db.Loais.Select(
                e => new LoaiDTO
                {
                    MaLoai = e.MaLoai,
                    TenLoai = e.TenLoai,
                    SoLuongSP = e.Coffes.Count()
                }
                ).ToList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "Display";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLoai = comboBox1.SelectedItem as LoaiDTO;
            if (selectedLoai != null)
            {
                var db = new CoffeDB();
                var ls = db.Coffes.Where(t => t.MaLoai == selectedLoai.MaLoai).Select(
                    t => new CoffeDTO
                    {
                        MaSanPham = t.MaSanPham,
                        TenSanPHam = t.TenSanPHam,
                        XuatXu = t.XuatXu,
                        Gia = t.Gia,
                        SoLuong = t.SoLuong,
                        MoTa = t.MoTa,
                        image = Image.FromFile(t.LinkAnh),
                        /*image = (t.LinkAnh == null ? productnotfound : Image.FromFile(t.LinkAnh)),*/
                    }
                    ).ToList();
                coffeDTOBindingSource.DataSource = ls;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            var selcat1 = coffeDTOBindingSource.Current as CoffeDTO;
            if (selcat1 != null)
            {
                if (e.ColumnIndex == 6)
                {
                    var f = new FormCoffe(selcat1);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        loadData();
                    }

                }
                if (e.ColumnIndex == 7)
                {
                    var f= new formDetailSP(selcat1);
                    if (f.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                if (e.ColumnIndex == 8)
                {
                    var rs = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.OK)
                    {
                        var db = new CoffeDB();
                        var obj = db.Coffes.Where(t => t.MaSanPham == selcat1.MaSanPham).FirstOrDefault();
                        if (obj != null)
                        {
                            db.Coffes.Remove(obj);
                            db.SaveChanges();
                            loadData();
                        }
                    }
                }
            }

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            var f = new FormCoffe();
            if (f.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }
    }
}
