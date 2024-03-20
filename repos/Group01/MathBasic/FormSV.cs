using MathBasic.Models;
using System.Drawing;

namespace MathBasic
{
    public partial class FormSV : Form
    {
        public SinhVien sinhvien { get; set; }
        public FormSV(SinhVien sinhVien)
        {
            InitializeComponent();
            this.sinhvien = sinhVien;
            if (sinhvien != null)
            {
                txtMaSV.Text = sinhvien.MaSinhVien;
                txtHo.Text = sinhvien.ho;
                txtTen.Text = sinhvien.ten;
                dtpNgaySinh.Value = sinhvien.NgaySinh;
                txtNoiSinh.Text = sinhvien.NoiSinh;
                txtQueQuan.Text = sinhvien.QueQuan;
                pictureBox1.ImageLocation = sinhvien.HinhDaiDien;
                cbbGioitinh.SelectedIndex = (int)sinhvien.gioitinh;
            }
        }
        void LoadSinhVien()
        {
            var json = File.ReadAllText(filename);
            var sinvien = SinhVien.FromJson(json);

        }
        string filename = "sinhvien.json";
        private void btn_Dangky_Click(object sender, EventArgs e)
        {
            /*            var sinhvien = new SinhVien
                        {
                            MaSinhVien = txtMaSV.Text,
                            ho = txtHo.Text,
                            ten = txtTen.Text,
                            NoiSinh = txtNoiSinh.Text,
                            QueQuan = txtQueQuan.Text,
                            HinhDaiDien = pictureBox1.ImageLocation,
                            NgaySinh = dtpNgaySinh.Value,
                            gioitinh = (int)cbbGioitinh.SelectedIndex,
                        };
                        var json = sinhvien.ToString();
                        File.WriteAllText(filename, json);*/
            if(sinhvien != null) {
                sinhvien.ho = txtHo.Text;
                sinhvien.ten = txtTen.Text;
                sinhvien.NoiSinh = txtNoiSinh.Text;
                sinhvien.QueQuan = txtQueQuan.Text;
                sinhvien.HinhDaiDien = pictureBox1.ImageLocation;
                sinhvien.NgaySinh = dtpNgaySinh.Value;
                sinhvien.gioitinh = (int)cbbGioitinh.SelectedIndex;
                DialogResult = DialogResult.OK;
                MessageBox.Show("Bạn Đã lưu trữ dữ liệu thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sinhvien=new SinhVien();
                sinhvien.MaSinhVien=txtMaSV.Text;
                sinhvien.ho = txtHo.Text;
                sinhvien.ten = txtTen.Text;
                sinhvien.NoiSinh = txtNoiSinh.Text;
                sinhvien.QueQuan = txtQueQuan.Text;
                sinhvien.HinhDaiDien = pictureBox1.ImageLocation;
                sinhvien.NgaySinh = dtpNgaySinh.Value;
                sinhvien.gioitinh = (int)cbbGioitinh.SelectedIndex;
                DialogResult = DialogResult.OK;
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var openfile = new OpenFileDialog
            {
                Title = "Chọn file"
            };
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                var SelectedFile = openfile.FileName;
                pictureBox1.ImageLocation = SelectedFile;
            }
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {

        }
    }
}
