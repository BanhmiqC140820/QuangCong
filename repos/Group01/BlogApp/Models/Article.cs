using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    [Table("Article")]
    public class Article
    {
        [Key] public long Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        public string Content { get; set; }
        [StringLength(50)]
        public string? Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdate { get; set; }
        public long IdCategory { get; set; }
        [ForeignKey(nameof(IdCategory))]
        public virtual Category Category { get; set; }
    }
}
