using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.Model
{
    [Table("HoaDon")]
    public class HoaDon
    {
        public HoaDon()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
        }
        [Key]
        public long MaHD { get; set; }

        public string MaHDS {  get; set; }

        public String MaKH { get; set; }
        public String MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }

        public long TongTien { get; set; }

        public long? DaMua { get; set; }

        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }
        [ForeignKey(nameof(MaKH))]

        public virtual Customer Customer { get; set; }
        [ForeignKey(nameof(MaNV))]
        public virtual NhanVien nhanvien { get; set; }

        public static string TaoMaHD()
        {
            using (var context = new CoffeDB())
            {
                var count = context.HoaDons.Count() + 1;
                return "HD" + count.ToString("D5");
            }
        }
    }
}
