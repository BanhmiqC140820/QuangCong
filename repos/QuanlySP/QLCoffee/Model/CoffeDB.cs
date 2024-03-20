using Microsoft.EntityFrameworkCore;
using QLCoffee.DTO;

namespace QLCoffee.Model
{
    public class CoffeDB : DbContext
    {
        public DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public DbSet<Coffe> Coffes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<UserAdmin> UserAdmins { get; set; }

        public string DbName = "Coffe.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Application.StartupPath, DbName);
            optionsBuilder.UseSqlite($"Data source={path}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loai>().HasData(
                new Loai { MaLoai = "COFFE01", TenLoai = "Cà phê phin giấy" },
                new Loai { MaLoai = "COFFE02", TenLoai = "Cà phê Rang xay" }
                );
            modelBuilder.Entity<Coffe>().HasData(
                new Coffe
                {
                    MaSanPham = "CS00001",
                    TenSanPHam = "CÀ PHÊ CON SÓC ĐEN (HỘP ĐÔI)",
                    MoTa = "Cà phê phin lọc giấy con sóc đen, hộp đôi 20 phin lọc giấy + 20 đường que Khối lượng tịnh: 200gr Cafe + 120gr đường",
                    Gia = 125000,
                    SoLuong = 100,
                    XuatXu = "Doanh Nghiệp TNX Trường Sơn",
                    MaLoai = "COFFE01",
                    LinkAnh = "image_product/CS00001.jpg"
                },
                 new Coffe
                 {
                     MaSanPham = "CS00002",
                     TenSanPHam = "CÀ PHÊ CON SÓC NÂU BỘT HỘP 500 GR",
                     MoTa = "CÀ PHÊ CON SÓC NÂU BỘT HỘP 500 gram 99,99% Arabica và Hazelut tổng hợp Khối lượng tịnh: 500gr Dạng thành phẩm: bao nhôm màu đen. Đặc tính: hạt cà phê nhỏ, mịn, màu nâu, mùi thơm nồng, vị nhẹ. Chỉ tiêu chất lượng: Độ ẩm <= 5% Chất tan trong nước >= 25% Cafein >= 1 %",
                     Gia = 158000,
                     SoLuong = 100,
                     XuatXu = "TNX CN Trường Sơn",
                     MaLoai = "COFFE01",
                     LinkAnh = "image_product/CS00002.jpg"
                 },
                                                new Coffe
                                                {
                                                    MaSanPham = "CS00003",
                                                    TenSanPHam = "Cà Phê Con Sóc Nâu Hộp Đôi",
                                                    MoTa = "Cà Phê Con Sóc Nâu Hộp Đôi có hương vị cân bằng giữa đậm đà và hương thơm thanh,dịu với thành phần: Arabica 49,95% Robusta 49,95% Hương hazelut tổng hợp 0,01% 20 phin lọc giấy + 20 đường que Khối lượng tịnh: 200gr Cafe + 120gr đường Sản phẩm phù hợp để làm quà biếu tặng",
                                                    Gia = 125000,
                                                    SoLuong = 100,
                                                    XuatXu = "Doanh Nghiệp TNX Trường Sơn",
                                                    MaLoai = "COFFE01",
                                                    LinkAnh = "image_product/CS00003.jpg"
                                                });
        }
    }
}
