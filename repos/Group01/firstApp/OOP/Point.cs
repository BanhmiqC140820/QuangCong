using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp.OOP
{
    public class Point
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Member methods
        /// <summary>
        /// Tính khoảng cách từ điểm hiện tại cho tới gốc tọa độ 0(0,0)
        /// </summary>
        /// <returns>Khoảng cách giữa 2 điểm</returns>
        public double Distance()
        {
            return Math.Sqrt((x * x) + (y * y));
        }
        /// <summary>
        /// Tính khoản cách từ điểm hiện tại đến điểm p
        /// </summary>
        /// <param name="p">Điểm tính khoảng cách</param>
        /// <returns>Khoảng cách giữa 2 điểm</returns>
        public double Dístance(Point p)
        {
            return Math.Sqrt(
                Math.Pow(p.x - x, 2) +
                Math.Pow(p.y - y, 2)
                );
        }
        #endregion

        #region Static methods
        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt(
                Math.Pow(a.x - b.x, 2) +
                Math.Pow(a.y - b.y, 2)
                );
        }
        public static Point operator +(Point a, Point b)
        {
            return new Point
            {
                x = a.x + b.x,
                y = a.y + b.y,
            };

        }
        #endregion

        #region override methods
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Point)) 
            {
                Point p=(Point) obj;
                if(x==p.x && y==p.y)
                   return true;
                else 
                   return false;
            }
            else 
                return false;
        }
        public override string ToString()
        {
            return $"Point({x},{y})";
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
