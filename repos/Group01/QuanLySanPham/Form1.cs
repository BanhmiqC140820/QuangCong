using Model;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        public Form1(SanPham sp)
        {
            InitializeComponent();
            if (sp != null)
            {
                lbTenSanPham.Text = sp.TenSanPham;
                lbGiasNhap.Text = sp.GiaNhap.ToString();
                lbNgayHetHan.Text = sp.NgayHetHan.ToString();
                lbNgayNhap.Text = sp.NgaySanXuat.ToString();
                LbGiaBan.Text = sp.GiaBan.ToString();
                pictureBox1.ImageLocation = sp.HinhDaiDien;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}