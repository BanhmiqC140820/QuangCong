using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.DTO
{
    public class CoffeDTO
    {
        public string MaSanPham { get; set; }

        [StringLength(200)]
        public string TenSanPHam { get; set; }

        [StringLength(500)]
        public string? MoTa { get; set; }

        public long? Gia { get; set; }

        public long? SoLuong { get; set; }

        [StringLength(200)]
        public string? XuatXu { get; set; }

        public Image ?image { get; set; }

        public string MaLoai { get; set; }
    }
}
