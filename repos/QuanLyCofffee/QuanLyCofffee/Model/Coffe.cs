namespace QuanLyCofffee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Coffe")]
    public partial class Coffe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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
        public string MoTa { get; set; }

        public long? Gia { get; set; }

        public long? SoLuong { get; set; }

        [StringLength(200)]
        public string XuatXu { get; set; }

        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string LinkAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        public virtual Loai Loai { get; set; }
    }
}
