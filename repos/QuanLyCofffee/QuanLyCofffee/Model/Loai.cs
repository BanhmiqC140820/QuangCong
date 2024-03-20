namespace QuanLyCofffee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Loai")]
    public partial class Loai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loai()
        {
            Coffes = new HashSet<Coffe>();
        }

        [Key]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coffe> Coffes { get; set; }
    }
}
