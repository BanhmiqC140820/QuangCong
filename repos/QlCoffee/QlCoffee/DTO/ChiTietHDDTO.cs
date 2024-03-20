using QLCoffee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.DTO
{
    public class ChiTietHDDTO
    {

        public long MaChiTietHD { get; set; }

        [StringLength(10)]
        public string MaSanPham { get; set; }

        public string Tensanpham { get; set; }

        public long? SoLuongMua { get; set; }

        public long? DonGia { get; set; }

        public long? ThanhTien { get; set; }

        public long MaHD { get; set; }

        public long? DaMua { get; set; }
    }
}

