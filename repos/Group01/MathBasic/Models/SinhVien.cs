using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MathBasic.Models
{
    public class SinhVien
    {
        internal int gioitinh;

        public string ?MaSinhVien { get; set; }
        public string ?ho {  get; set; }
        public string ?ten {  get; set; }
        public DateTime NgaySinh { get; set; }
        public GIOITINH GIOITINH { get; set; }
        public string ?QueQuan { get; set; }
        public string ?NoiSinh {  get; set; }
        public string ?HinhDaiDien { get; set; }
        public override string ToString()
        {
            var json=JsonSerializer.Serialize(this);
            return json;
        }
/*        public static string ListToString(List<SinhVien> list)
        {
            var jSon = JsonSerializer.Serialize(list);
            return jSon;
        }*/
        public static SinhVien FromJson(string json)
        {
            var sinhvien=JsonSerializer.Deserialize<SinhVien>(json);
            return sinhvien;
        }
/*        public static List<SinhVien> FromJsonds(string json)
        {
            var sinhVienList = JsonSerializer.Deserialize<List<SinhVien>>(json);
            return sinhVienList;
        }*/
    }
    public enum GIOITINH
    {
        Male,Female,Others
    }
}
