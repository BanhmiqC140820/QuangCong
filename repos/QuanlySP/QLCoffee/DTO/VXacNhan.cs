using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.DTO
{
    [Table("VXacNhan")]
    public class VXacNhan
    {
        public long MaKH { get; set; }

        public string Hovaten { get; set; }

        public string TenSanPHam { get; set; }

        public long? Gia { get; set; }

        public DateTime? NgayMua { get; set; }

        public long? SoLuongMua { get; set; }

        public long? DaMua { get; set; }

        public long? thanhtien { get; set; }

        public long MaChiTietHD { get; set; }
    }
}
