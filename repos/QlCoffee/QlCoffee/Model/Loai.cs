using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCoffee.Model
{
    [Table("Loai")]
    public class Loai
    {
        public Loai()
        {
            Coffes = new HashSet<Coffe>();
        }

        [Key]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }

        
        public virtual ICollection<Coffe> Coffes { get; set; }
        public static string TaoMaLoai()
        {
            using (var context = new CoffeDB()) 
            {
                var count = context.Loais.Count() + 1;
                return "COFFE" + count.ToString("D2");
            }
        }
    }
}
