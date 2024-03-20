using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    public partial class FormSP : Form
    {
        List<SanPham> dssp = new List<SanPham>();
        string fileName = "20T1020085.json";
        public FormSP()
        {
            InitializeComponent();


            LoadData();
        }

        private void RefreshDataGridView()
        {

            tableDssp.DataSource = null;
            tableDssp.DataSource = dssp;

        }
        private void LoadData()
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName, Encoding.UTF8);
                var sanPham = SanPham.FromJson(json);

                sanPhamBindingSource.DataSource = sanPham;
                dssp = sanPham;
                RefreshDataGridView();

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var sanPham = new SanPham
            {
                MaSanPham = txtMasanpham.Text,
                TenSanPham = txtTensanpham.Text,
                NgaySanXuat = dtpNSX.Value,
                NgayHetHan = dtpNHH.Value,
                GiaNhap = long.Parse(txtGianhap.Text),
                GiaBan = long.Parse(txtGiaban.Text),
                SoLuongNhap = long.Parse(txtSoluongnhap.Text),
                HinhDaiDien = picAvt.ImageLocation
            };

            var msp = txtMasanpham.Text;
            if (string.IsNullOrEmpty(msp))
            {
                MessageBox.Show("Mã sản phẩm không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dssp.Any(sp => sp.MaSanPham == msp))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dssp.Add(sanPham);
            RefreshDataGridView();

            var json = JsonSerializer.Serialize(dssp);

            File.WriteAllText("20T1020085.json", json);
            MessageBox.Show("Đã lưu dữ liệu sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tableDssp.DataSource = dssp;

        }
        private void picAvt_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog()
            {
                Title = "Chọn hình đại diện",
                Filter = "File ảnh | *.png;*.jpg;*.jpeg",
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var fileDaiDien = openDialog.FileName;
                picAvt.Load(fileDaiDien);
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            // lấy mã sản phẩm ở textbox
            var msp = txtMasanpham.Text;
            // kiểm tra mã sản phẩm có rỗng 
            if (string.IsNullOrEmpty(msp))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // tạo biến newSanPham để lưu trữ sp cập nhật
            SanPham newSanPham = null;
            // duyệt danh sách sản phẩm dssp
            for (int i = 0; i < dssp.Count; i++)
            {
                if (dssp[i].MaSanPham == msp)
                {
                    // gắn sản phẩm tìm thấy vào new SanPham
                    newSanPham = dssp[i];
                    break;
                }
            }

            if (newSanPham == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            newSanPham.TenSanPham = txtTensanpham.Text;
            newSanPham.NgaySanXuat = dtpNSX.Value;
            newSanPham.NgayHetHan = dtpNHH.Value;
            newSanPham.GiaNhap = long.Parse(txtGianhap.Text);
            newSanPham.GiaBan = long.Parse(txtGiaban.Text);
            newSanPham.SoLuongNhap = long.Parse(txtSoluongnhap.Text);
            newSanPham.HinhDaiDien = picAvt.ImageLocation;


            var json = JsonSerializer.Serialize(dssp);

            RefreshDataGridView();
            File.WriteAllText("20T1020085.json", json);
            MessageBox.Show("Đã cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var MaSanPham = txtMasanpham.Text;
            int n = dssp.Count;
            for (int i = 0; i < n; i++)
            {
                if (dssp[i].MaSanPham.Equals(MaSanPham))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // User confirmed the action
                        dssp.Remove(dssp[i]);
                        RefreshDataGridView();

                        //var json = SanPham.ListToString(dssp);
                        var json = JsonSerializer.Serialize(dssp);
                        File.WriteAllText("20T1020085.json", json);
                        MessageBox.Show("đã xóa sản phẩm", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void tableDssp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
                return;
            row = tableDssp.Rows[e.RowIndex];
            SanPham sp = (SanPham)row.DataBoundItem;
            txtMasanpham.Text = sp.MaSanPham;
            txtTensanpham.Text = sp.TenSanPham;
            dtpNSX.Value = sp.NgaySanXuat;
            dtpNHH.Value = sp.NgayHetHan;
            txtGianhap.Text = sp.GiaNhap.ToString();
            txtGiaban.Text = sp.GiaBan.ToString();
            txtSoluongnhap.Text = sp.SoLuongNhap.ToString();
            if (!string.IsNullOrEmpty(sp.HinhDaiDien))
                picAvt.ImageLocation = sp.HinhDaiDien;
            else picAvt.ImageLocation = null;
        }

        private void tableDssp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
                return;
            row = tableDssp.Rows[e.RowIndex];
            SanPham sp = (SanPham)row.DataBoundItem;
            var formInfo = new Form1(sp);
            formInfo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dssp.Count;
            List<SanPham> dstk = new List<SanPham>();
            for (int i = 0; i < n; i++)
            {
                if (dssp[i].TenSanPham.Contains(txtTimKiem.Text) || dssp[i].MaSanPham.Contains(txtTimKiem.Text))
                {
                    dstk.Add(dssp[i]);

                }
            }
            tableDssp.DataSource = dstk;
        }

        private void picAvt_Click_1(object sender, EventArgs e)
        {
            var openfile = new OpenFileDialog
            {
                Title = "Chọn file"
            };
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var SelectedFile = openfile.FileName;
                picAvt.ImageLocation = SelectedFile;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tableDssp.DataSource=dssp;
        }
    }
}
