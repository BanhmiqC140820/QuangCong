namespace QuanLyCofffee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LichSuMuaHang")]
    public partial class LichSuMuaHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaSanPham { get; set; }

        [StringLength(200)]
        public string TenSanPHam { get; set; }

        public long? SoLuongMua { get; set; }

        public long? DaMua { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }

        public long? Gia { get; set; }

        public long? thanhtien { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaKH { get; set; }

        [StringLength(50)]
        public string LinkAnh { get; set; }
    }
}
