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
    public partial class FormQLLoaiCoffe : Form
    {
        public FormQLLoaiCoffe()
        {
            InitializeComponent();
            Loadloai();
        }
        void Loadloai()
        {
            var db = new CoffeDB();
            var ls = db.Loais.OrderBy(e => e.MaLoai).Select(e => new LoaiDTO
            {
                MaLoai = e.MaLoai,
                TenLoai = e.TenLoai,
                SoLuongSP = e.Coffes.Count()
            }).ToList();
            loaiDTOBindingSource.DataSource = ls;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var f = new FormLoai();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Loadloai();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selloai = loaiDTOBindingSource.Current as LoaiDTO;
            if (selloai != null)
            {
                if (e.ColumnIndex == 3)
                {
                    var f = new FormLoai(selloai);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        Loadloai();
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    var rs = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.OK)
                    {
                        var db = new CoffeDB();
                        var obj = db.Loais.Where(e => e.MaLoai == selloai.MaLoai).FirstOrDefault();
                        if (obj != null)
                        {
                            db.Loais.Remove(obj);
                            db.SaveChanges();
                            Loadloai();
                        }
                    }
                }
            }
        }
    }
}

