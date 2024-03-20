using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MathBasic.Models
{
    public class LopHoc
    {
        public long MaLop { get; set; }
        public String TenLopHoc { get; set; }
        public String GiangVien { get; set; }
        public String PhongHoc { get; set; }
        public int TuTiet { get; set; }
        public int DenTiet { get; set; }
        public List<SinhVien> SinhViens { get; set; }
        public static LopHoc GenerateLopHoc()
        {
            LopHoc lopHoc = new LopHoc
            {
                MaLop = 1,
                TenLopHoc = ".NET nhóm 1",
                PhongHoc = "Lab 05",
                GiangVien = "Nguyễn Dũng",
                TuTiet = 6,
                DenTiet = 8,
                SinhViens = new List<SinhVien>()
            };
            lopHoc.SinhViens.Add(new SinhVien
            {
                MaSinhVien = "101",
                ho = "Nguyễn",
                ten = "Quang",
                GIOITINH = GIOITINH.Male,
                NgaySinh = new DateTime(2000, 1, 1),
                NoiSinh = "Huế",
                QueQuan = "Huế",
            });
            lopHoc.SinhViens.Add(new SinhVien
            {
                MaSinhVien = "122",
                ho = "Nguyễn Văn",
                ten = "Sĩ",
                GIOITINH = GIOITINH.Male,
                NgaySinh = new DateTime(2000, 2, 1),
                NoiSinh = "Huế",
                QueQuan = "Hà nội",
            });
            lopHoc.SinhViens.Add(new SinhVien
            {
                MaSinhVien = "122",
                ho = "Trần Văn",
                ten = "Sĩ",
                GIOITINH = GIOITINH.Male,
                NgaySinh = new DateTime(2000, 2, 1),
                NoiSinh = "Huế",
                QueQuan = "Hà nội",
            });
            return lopHoc;
        }
        public override string ToString()
        {
            var js = JsonSerializer.Serialize(this);
            return js;
        }
        public static LopHoc Fromjson(string json)
        {
            var lophoc=JsonSerializer.Deserialize<LopHoc>(json);
            return lophoc;
        }
    }

    }

