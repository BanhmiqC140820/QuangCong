using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DTO
{
    public class CategoryDTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int AmountArticles { get; set; }
        public string Display
        {
            get {
                return $"{Name} - {AmountArticles}";
            }
        }

    }
}
