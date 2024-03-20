using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.Model
{
    [Table("ChiTietHD")]
    public class ChiTietHD
    {
        [Key]
        public long MaChiTietHD { get; set; }

        [StringLength(10)]

        public string MaSanPham { get; set; }

        public long? SoLuongMua { get; set; }

        public long MaHD { get; set; }

        public long? DaMua { get; set; }
        [ForeignKey(nameof(MaSanPham))]

        public virtual Coffe Coffe { get; set; }
        [ForeignKey(nameof(MaHD))]

        public virtual HoaDon HoaDon { get; set; }
    }
}
