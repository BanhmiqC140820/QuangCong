using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.Model
{
    public class Customer
    {
        public Customer()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public String MaKH { get; set; }

        [StringLength(50)]
        public string Hovaten { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string? SDT { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string TenDN { get; set; }

        [StringLength(50)]
        public string Pass { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public static string TaoMaKH()
        {
            using (var context = new CoffeDB())
            {
                var count = context.NhanViens.Count() + 1;
                return "KH" + count.ToString("D2");
            }
        }
    }
}
