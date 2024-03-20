using QLCoffee.DTO;
using QLCoffee.Model;

namespace QLCoffee
{
    public partial class FormCoffe : Form
    {
        CoffeDTO? coffe;
        public FormCoffe(CoffeDTO? coffe = null)
        {
            InitializeComponent();
            this.coffe = coffe;
            LoadData();

        }
        void LoadData()
        {
            var db = new CoffeDB();
            var ls = db.Loais.Select(e => new Loai
            {
                MaLoai = e.MaLoai,
                TenLoai = e.TenLoai,
            }).ToList();
            cbbLoai.DataSource = ls;
            cbbLoai.DisplayMember = "TenLoai";
            if (coffe != null)
            {
                var imagePath = db.Coffes.Where(t => t.MaSanPham == coffe.MaSanPham).Select(e => e.LinkAnh).FirstOrDefault() ?? "";
                label7.Text = "Câp nhật sản phẩm";
                txtTenSP.Text = coffe.TenSanPHam;
                txtXuatXu.Text = coffe.XuatXu;
                txtMota.Text = coffe.MoTa;
                foreach (Loai loai in cbbLoai.Items)
                {
                    if (loai.MaLoai == coffe.MaLoai)
                    {
                        cbbLoai.SelectedItem = loai;
                        break;
                    }
                }

                nupGia.Value = (long)coffe.Gia;
                nupSL.Value = (long)coffe.SoLuong;
                pbxSP.ImageLocation = imagePath;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (coffe != null)
            {
                var db = new CoffeDB();
                var obj = db.Coffes.Where(t => t.MaSanPham == coffe.MaSanPham).FirstOrDefault();
                if (obj != null)
                {
                    var selLoai = cbbLoai.SelectedItem as Loai;
                    obj.TenSanPHam = txtTenSP.Text;
                    obj.Gia = (long?)nupGia.Value;
                    obj.SoLuong = (long?)nupSL.Value;
                    obj.XuatXu = txtXuatXu.Text;
                    obj.MoTa = txtMota.Text;
                    obj.LinkAnh = pbxSP.ImageLocation;
                    obj.MaLoai = selLoai.MaLoai;
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtTenSP.Text))
                {
                    var selLoai = cbbLoai.SelectedItem as Loai;
                    if (selLoai != null)
                    {
                        var obj = new Coffe
                        {
                            MaSanPham = Coffe.TaoMaSanPham(),
                            TenSanPHam = txtTenSP.Text,
                            Gia = (long?)nupGia.Value,
                            SoLuong = (long?)nupSL.Value,
                            XuatXu = txtXuatXu.Text,
                            MoTa = txtMota.Text,
                            LinkAnh = pbxSP.ImageLocation,
                            MaLoai = selLoai.MaLoai,
                        };
                        var db = new CoffeDB();
                        db.Coffes.Add(obj);
                        db.SaveChanges();
                        MessageBox.Show("đã thêm sản phẩm", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(selLoai.TenLoai);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin");
                }
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
                pbxSP.ImageLocation = SelectedFile;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}