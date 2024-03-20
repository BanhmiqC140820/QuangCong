using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.Model
{
    [Table("Coffe")]
    public class Coffe
    {
        public Coffe()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaSanPham { get; set; }

        [StringLength(200)]
        public string TenSanPHam { get; set; }

        [StringLength(500)]
        public string? MoTa { get; set; }

        public long? Gia { get; set; }

        public long? SoLuong { get; set; }

        [StringLength(200)]
        public string? XuatXu { get; set; }

        public string MaLoai { get; set; }


        [StringLength(50)]
        public string? LinkAnh { get; set; }

        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        [ForeignKey(nameof(MaLoai))]

        public virtual Loai Loai { get; set; }
        public static string TaoMaSanPham()
        {
            using (var context = new CoffeDB()) 
            {
                var count = context.Coffes.Count() + 1;
                return "CS" + count.ToString("D5");
            }
        }
    }
}
