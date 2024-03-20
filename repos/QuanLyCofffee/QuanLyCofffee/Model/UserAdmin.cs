namespace QuanLyCofffee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("UserAdmin")]
    public partial class UserAdmin
    {
        [Key]
        [StringLength(50)]
        public string TenDN { get; set; }

        [Required]
        [StringLength(50)]
        public string Pass { get; set; }

        public bool? Quyen { get; set; }
    }
}
