using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp.OOP
{
    public class Circle : IShape
    {
        public Point Center {  get; set; }
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return Math.PI*Radius * 2;
        }
    }
}
