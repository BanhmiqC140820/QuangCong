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


namespace _20T1020084
{
    public partial class FormSanPham : Form
    {
        string fileName = "20T1020084.json";

        // tạo một List dssp chứa các đối tượng SanPham
        List<SanPham> dssp = new List<SanPham>();
        public FormSanPham()
        {
            InitializeComponent();

            // kiểm tra file json tồn tại hay chưa
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName, Encoding.UTF8);
                // chuyển nội dung JSON thành ds cách đối tượng SanPham
                var sanPham = SanPham.FromJson(json);
                // gán danh sách SanPham đc đọc từ JSON vào dssp
                dssp = sanPham;
            }
            LoadData();
        }
        private void RefreshDataGridView()
        {
            // Liên kết DataGridView với danh sách sản phẩm
            tableDssp.DataSource = null;
            tableDssp.DataSource = dssp;

        }
        private void LoadData()
        {
            if (File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName, Encoding.UTF8);
                var sanPham = SanPham.FromJson(json);
                // cập nhật danh sách sp vào bảng datagridview
                sanPhamBindingSource.DataSource = sanPham;
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
            // Kiểm tra mã sản phẩm đã tồn tại hay bằng rỗng 
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

            // Thêm sản phẩm vào danh sách
            dssp.Add(sanPham);
            // Cập nhật DataGridView
            RefreshDataGridView();


            // chuyển đổi dssp thành JSON
            var json = JsonSerializer.Serialize(dssp);
            //var json = SanPham.ListToString(dssp);


            File.WriteAllText("20T1020084.json", json);
            MessageBox.Show("Đã lưu dữ liệu sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void tableDssp_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void tableDssp_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void sanPhamBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var MaSanPham = txtMasanpham.Text;
            for (int i = 0; i < dssp.Count; i++)
            {
                if (MaSanPham == dssp[i].MaSanPham)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // User confirmed the action
                        dssp.Remove(dssp[i]);
                        RefreshDataGridView();

                        //var json = SanPham.ListToString(dssp);
                        var json = JsonSerializer.Serialize(dssp);
                        File.WriteAllText("20T1020084.json", json);
                        MessageBox.Show("đã xóa sản phẩm", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        // User declined the action
                        MessageBox.Show("Action canceled.");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                // tìm xem có sản phẩm cần cập nhật không
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

            // Cập nhật thông tin sản phẩm
            newSanPham.TenSanPham = txtTensanpham.Text;
            newSanPham.NgaySanXuat = dtpNSX.Value;
            newSanPham.NgayHetHan = dtpNHH.Value;
            newSanPham.GiaNhap = long.Parse(txtGianhap.Text);
            newSanPham.GiaBan = long.Parse(txtGiaban.Text);
            newSanPham.SoLuongNhap = long.Parse(txtSoluongnhap.Text);
            newSanPham.HinhDaiDien = picAvt.ImageLocation;

            // chuyển dssp thành json
            //var json = SanPham.ListToString(dssp);
            var json = JsonSerializer.Serialize(dssp);

            RefreshDataGridView();
            File.WriteAllText("20T1020084.json", json);
            MessageBox.Show("Đã cập nhật sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void txtMasanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableDssp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
