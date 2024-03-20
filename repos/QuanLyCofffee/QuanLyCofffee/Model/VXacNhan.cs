namespace QuanLyCofffee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("VXacNhan")]
    public partial class VXacNhan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaKH { get; set; }

        [StringLength(50)]
        public string Hovaten { get; set; }

        [StringLength(200)]
        public string TenSanPHam { get; set; }

        public long? Gia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }

        public long? SoLuongMua { get; set; }

        public long? DaMua { get; set; }

        public long? thanhtien { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaChiTietHD { get; set; }
    }
}
