using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp.OOP
{
    public class Rectangle : IShape
    {
        public int Height {  get; set; }
        public int Width { get; set; }

        public double Area()
        {
            return Height*Width;
        }

        public double Perimeter()
        {
            return (Height+Width)*2;
        }
    }
}
