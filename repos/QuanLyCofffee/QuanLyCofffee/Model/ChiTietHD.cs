namespace QuanLyCofffee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        public long MaChiTietHD { get; set; }

        [StringLength(10)]
        public string MaSanPham { get; set; }

        public long? SoLuongMua { get; set; }

        public long? MaHD { get; set; }

        public long? DaMua { get; set; }

        public virtual Coffe Coffe { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
