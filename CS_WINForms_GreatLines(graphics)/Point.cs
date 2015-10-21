using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_WINForms_GreatLines_graphics_
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(Point tmp)
        {
            X = tmp.X;
            Y = tmp.Y;
        }
    }
}
