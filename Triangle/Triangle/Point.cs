using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Point
    {
        public readonly double X;
        public readonly double Y;


        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static bool operator ==(Point first, Point second)
        {
            return first.X == second.X && first.Y == second.Y;
        }
        public static bool operator !=(Point first, Point second)
        {
            return first.X != second.X || first.Y != second.Y;
        }
    }
}
