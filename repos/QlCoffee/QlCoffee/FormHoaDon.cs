using QlCoffee;
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
    public partial class FormHoaDon : Form
    {
        HoaDon hd;
        public FormHoaDon(HoaDon hd = null)
        {
            InitializeComponent();
            this.hd = hd;
            loaddata();
            blockField();
            if (hd != null)
            {
                txtMaHD.Text = hd.MaHDS;
                dtpNgayBan.Value = (DateTime)hd.NgayMua;
                cbxMaNV.SelectedIndex = cbxMaNV.FindStringExact(hd.MaNV);
                LoadGridview();
            }
            else
            {
                txtMaHD.Text = HoaDon.TaoMaHD();
                dtpNgayBan.Value = DateTime.Today;
            }
        }
        void blockField()
        {
            txtMaHD.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtMaSP.ReadOnly = true;
            numbericGia.ReadOnly = true;
            txtSDT.ReadOnly = true;

        }
        void loaddata()
        {
            var db = new CoffeDB();
            var lsNV = db.NhanViens.Select(e => new NhanVien { MaNV = e.MaNV, Hovaten = e.Hovaten }).ToList();
            var lsKH = db.Customers.Select(e => new Customer
            {
                MaKH = e.MaKH,
                Hovaten = e.Hovaten,
                DiaChi = e.DiaChi,
                SDT = e.SDT,
            }).ToList();
            var lsSP = db.Coffes.Select(e => new Coffe { MaSanPham = e.MaSanPham, TenSanPHam = e.TenSanPHam, Gia = e.Gia }).ToList();

            cbxNV.DataSource = lsNV;
            cbxNV.DisplayMember = "Hovaten";
            cbxMaNV.DataSource = lsNV;
            cbxMaNV.DisplayMember = "MaNV";
            cbxKH.DataSource = lsKH;
            cbxKH.DisplayMember = "MaKH";
            cbxSP.DataSource = lsSP;
            cbxSP.DisplayMember = "TenSanPHam";


        }
        //select ChittietHDDTO
        void LoadGridview()
        {
            if (hd != null)
            {
                var db = new CoffeDB();
                var lsChiTietHD = db.ChiTietHDs.Join(
                db.Coffes,
                ChiTietHD => ChiTietHD.MaSanPham,
                Coffe => Coffe.MaSanPham,
                (ChiTietHD, Coffe) => new ChiTietHDDTO
                {
                    MaChiTietHD = ChiTietHD.MaChiTietHD,
                    MaSanPham = Coffe.MaSanPham,
                    Tensanpham = Coffe.TenSanPHam,
                    SoLuongMua = ChiTietHD.SoLuongMua,
                    DonGia = Coffe.Gia,
                    ThanhTien = Coffe.Gia * ChiTietHD.SoLuongMua,
                    MaHD = ChiTietHD.MaHD,
                }
                ).Where(ChiTietHD => ChiTietHD.MaHD == hd.MaHD).ToList();
                var result = lsChiTietHD.Sum(e => e.ThanhTien);
                label16.Text = result.ToString();
                chiTietHDDTOBindingSource.DataSource = lsChiTietHD;
                if (hd.DaMua == 1)
                {
                    btnLuuHD.Visible = false;
                    btnThanhToan.Visible = false;
                }
            }
            else
            {

            }
        }
        private void cbxKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selKH = cbxKH.SelectedItem as Customer;
            if (selKH != null)
            {
                txtTenKH.Text = selKH.Hovaten;
                txtDiachi.Text = selKH.DiaChi;
                txtSDT.Text = selKH.SDT;
            }
        }

        private void cbxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selSP = cbxSP.SelectedItem as Coffe;
            if (selSP != null)
            {
                txtMaSP.Text = selSP.MaSanPham;
                numbericGia.Value = (long)selSP.Gia;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selSP = chiTietHDDTOBindingSource.Current as ChiTietHDDTO;
            if (hd != null)
            {
                if (e.ColumnIndex == 5)
                {
                    var selCT = chiTietHDDTOBindingSource.Current as ChiTietHDDTO;
                    if (selCT != null)
                    {
                        if (hd != null)
                        {
                            var db = new CoffeDB();
                            var obj = db.ChiTietHDs.Where(t => t.MaChiTietHD == selCT.MaChiTietHD).FirstOrDefault();

                            if (obj != null)
                            {
                                db.ChiTietHDs.Remove(obj);
                                db.SaveChanges();
                                LoadGridview();
                            }
                            else
                            {
                                return;
                            }
                        }

                    }
                    return;
                }

            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    if (selSP != null)
                    {
                        var tong = long.Parse(label16.Text) - selSP.ThanhTien;
                        label16.Text = tong.ToString();
                        chiTietHDDTOBindingSource.Remove(selSP);
                        chiTietHDDTOBindingSource.ResetBindings(false);
                    }

                }
            }
            if (selSP != null)
            {
                txtMaSP.Text = selSP.MaSanPham;
                cbxSP.SelectedIndex = cbxSP.FindStringExact(selSP.Tensanpham);
                numbericGia.Value = (long)selSP.DonGia;
                numericSL.Value = (long)selSP.SoLuongMua;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hd != null)
            {
                var db = new CoffeDB();

                var obj = db.ChiTietHDs.Where(t => (t.MaSanPham == txtMaSP.Text && t.MaHD == hd.MaHD)).FirstOrDefault();
                if (obj != null)
                {
                    obj.SoLuongMua += (long)numericSL.Value;
                    db.SaveChanges();
                    LoadGridview();
                }
                else
                {
                    var obj2 = new ChiTietHD();
                    obj2.MaSanPham = txtMaSP.Text;
                    obj2.SoLuongMua = (long)numericSL.Value;
                    obj2.MaHD = hd.MaHD;
                    db.ChiTietHDs.Add(obj2);
                    db.SaveChanges();
                    LoadGridview();
                }
            }
            else
            {
                var obj = chiTietHDDTOBindingSource.List.OfType<ChiTietHDDTO>().FirstOrDefault(item => item.MaSanPham == txtMaSP.Text); ;
                if (obj != null)
                {
                    obj.SoLuongMua += (long)numericSL.Value;
                    obj.ThanhTien = obj.SoLuongMua * (long)numbericGia.Value;
                    chiTietHDDTOBindingSource.ResetBindings(false);
                    var tong = long.Parse(label16.Text);
                    tong = tong + (long)numericSL.Value * (long)numbericGia.Value;
                    label16.Text = tong.ToString();
                }
                else
                {

                    obj = new ChiTietHDDTO();
                    obj.MaSanPham = txtMaSP.Text;
                    obj.Tensanpham = cbxSP.Text;
                    obj.SoLuongMua = (long)numericSL.Value;
                    obj.DonGia = (long)numbericGia.Value;
                    obj.ThanhTien = (long)numericSL.Value * (long)numbericGia.Value;
                    chiTietHDDTOBindingSource.Add(obj);
                    var tong = long.Parse(label16.Text);
                    tong = tong + (obj.ThanhTien ?? 0);
                    label16.Text = tong.ToString();
                }
            }
        }

        private void cbxNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selNV = cbxNV.SelectedItem as NhanVien;
            if (selNV != null)
            {
                /*  cbxMaNV.SelectedIndex = cbxNV.SelectedIndex;*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hd != null)
            {
                var db = new CoffeDB();
                var obj = db.HoaDons.Where(t => (t.MaHD == hd.MaHD)).FirstOrDefault();
                if (obj != null)
                {
                    obj.DaMua = 1;
                    obj.TongTien = long.Parse(label16.Text);
                    foreach (ChiTietHDDTO ct in chiTietHDDTOBindingSource)
                    {
                        var sp = db.Coffes.Where(t => t.MaSanPham == ct.MaSanPham).FirstOrDefault();
                        if (sp != null)
                        {
                            sp.SoLuong = sp.SoLuong - ct.SoLuongMua;
                        }
                    }
                    db.SaveChanges();
                    DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var f = new FormPrint(obj);
                        f.ShowDialog();
                    }
                }
                DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                var db = new CoffeDB();
                HoaDon hd2 = new HoaDon
                {
                    MaHDS = txtMaHD.Text,
                    MaKH = cbxKH.Text,
                    MaNV = cbxMaNV.Text,
                    NgayMua = dtpNgayBan.Value,
                    TongTien = long.Parse(label16.Text),
                    DaMua = 1
                };
                db.HoaDons.Add(hd2); db.SaveChanges();
                var id = db.HoaDons.Where(t => t.MaHDS == hd2.MaHDS).FirstOrDefault();

                if (id != null)
                {
                    foreach (ChiTietHDDTO ct in chiTietHDDTOBindingSource)
                    {
                        ChiTietHD chiTietHD = new ChiTietHD
                        {
                            MaSanPham = ct.MaSanPham,
                            SoLuongMua = ct.SoLuongMua,
                            MaHD = id.MaHD,
                            DaMua = 1
                        };
                        var sp = db.Coffes.Where(t => t.MaSanPham == ct.MaSanPham).FirstOrDefault();
                        if (sp != null)
                        {
                            sp.SoLuong = sp.SoLuong - ct.SoLuongMua;
                        }
                        db.ChiTietHDs.Add(chiTietHD);
                    }
                    db.SaveChanges();
                    DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var f = new FormPrint(hd2);
                        f.ShowDialog();
                    }

                    DialogResult = DialogResult.OK;
                    this.Dispose();
                }
            }

        }

        private void cbxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selNV = cbxMaNV.SelectedItem as NhanVien;
            if (selNV != null)
            {
                cbxNV.SelectedIndex = cbxMaNV.SelectedIndex;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (hd != null)
            {
                var db = new CoffeDB();

                var obj = db.ChiTietHDs.Where(t => (t.MaSanPham == txtMaSP.Text && t.MaHD == hd.MaHD)).FirstOrDefault();
                if (obj != null)
                {
                    obj.SoLuongMua = (long)numericSL.Value;
                    db.SaveChanges();
                    LoadGridview();
                }
                else
                {
                    var obj2 = new ChiTietHD();
                    obj2.MaSanPham = txtMaSP.Text;
                    obj2.SoLuongMua = (long)numericSL.Value;
                    obj2.MaHD = hd.MaHD;
                    db.ChiTietHDs.Add(obj2);
                    db.SaveChanges();
                    LoadGridview();
                }
            }
            else
            {
                var obj = chiTietHDDTOBindingSource.List.OfType<ChiTietHDDTO>().FirstOrDefault(item => item.MaSanPham == txtMaSP.Text); ;
                if (obj != null)
                {
                    obj.SoLuongMua = (long)numericSL.Value;
                    obj.ThanhTien = obj.SoLuongMua * (long)numbericGia.Value;
                    chiTietHDDTOBindingSource.ResetBindings(false);
                    var tong = long.Parse(label16.Text);
                    tong = tong + (long)numericSL.Value * (long)numbericGia.Value;
                    label16.Text = tong.ToString();
                }
            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (hd != null)
            {
                var db = new CoffeDB();
                var objHD = db.HoaDons.Where(t => t.MaHDS == hd.MaHDS).FirstOrDefault();

                if (objHD != null)
                    objHD.TongTien = long.Parse(label16.Text);
                foreach (ChiTietHDDTO ct in chiTietHDDTOBindingSource)
                {
                    var obj = db.ChiTietHDs.Where(t => (t.MaHD == hd.MaHD && t.MaChiTietHD == ct.MaChiTietHD)).FirstOrDefault();
                    if (obj != null)
                    {
                        obj.SoLuongMua = ct.SoLuongMua;
                    }
                    else
                    {
                        ChiTietHD chiTietHD = new ChiTietHD
                        {
                            MaSanPham = ct.MaSanPham,
                            SoLuongMua = ct.SoLuongMua,
                            MaHD = ct.MaHD,
                            DaMua = 0
                        };
                        db.ChiTietHDs.Add(chiTietHD);
                    }
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                var db = new CoffeDB();
                HoaDon hd = new HoaDon
                {
                    MaHDS = txtMaHD.Text,
                    MaKH = cbxKH.Text,
                    MaNV = cbxMaNV.Text,
                    NgayMua = dtpNgayBan.Value,
                    TongTien = long.Parse(label16.Text),
                    DaMua = 0
                };
                db.HoaDons.Add(hd); db.SaveChanges();
                var id = db.HoaDons.Where(t => t.MaHDS == hd.MaHDS).FirstOrDefault();
                if (id != null)
                {
                    foreach (ChiTietHDDTO ct in chiTietHDDTOBindingSource)
                    {
                        ChiTietHD chiTietHD = new ChiTietHD
                        {
                            MaSanPham = ct.MaSanPham,
                            SoLuongMua = ct.SoLuongMua,
                            MaHD = id.MaHD,
                            DaMua = 0
                        };
                        db.ChiTietHDs.Add(chiTietHD);
                    }
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                    this.Dispose();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new FormKH();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
