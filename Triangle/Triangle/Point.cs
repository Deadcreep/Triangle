using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static double GetDistance(Point first, Point second)
        {
           return Math.Sqrt((second.X - first.X) * (second.X - first.X) + (second.Y - first.Y) * (second.Y - first.Y));
        }
    }
}
