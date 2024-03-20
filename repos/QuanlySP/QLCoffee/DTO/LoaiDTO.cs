using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QLCoffee.DTO
{
    public class LoaiDTO
    {
        public string MaLoai {  get; set; }
        public string TenLoai {  get; set; }
        public int SoLuongSP {  get; set; }
        public string Display
        {
            get
            {
                return $"{TenLoai} - {SoLuongSP}";
            }
        }
    }
}
