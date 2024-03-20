using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public long id {  get; set; }
        [Required]
        [StringLength(50)]
        public String name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdate { get; set; }
        public virtual ICollection<Article> Articles { get; set; }

    }
}
