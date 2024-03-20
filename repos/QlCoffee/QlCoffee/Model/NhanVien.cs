using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.Model
{
    [Table("NhanVien")]
    public class NhanVien
    {

        [Key]
        public String MaNV { get; set; }

        [StringLength(50)]
        public string Hovaten { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string? SDT { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }
        public DateTime? Ngaysinh { get; set; }

        [StringLength(50)]
        public string ?TenDN { get; set; }

        [StringLength(50)]
        public string ?Pass { get; set; }

        public virtual ICollection<HoaDon> ?HoaDons { get; set; }
        public static string TaoMaNV()
        {
            using (var context = new CoffeDB())
            {
                var count = context.NhanViens.Count() + 1;
                return "NV" + count.ToString("D2");
            }
        }

    }
}

