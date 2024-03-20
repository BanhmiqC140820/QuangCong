using System.Text.Json;

namespace Model
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime NgayHetHan { get; set; }
        public long GiaNhap { get; set; }
        public long GiaBan { get; set; }
        public long SoLuongNhap { get; set; }
        public string HinhDaiDien { get; set; }

        public static string ListToString(List<SanPham> list)
        {
            var jSon = JsonSerializer.Serialize(list);
            return jSon;
        }

        public static List<SanPham> FromJson(string json)
        {
            var sanPham = JsonSerializer.Deserialize<List<SanPham>>(json);
            return sanPham;
        }
    }
}