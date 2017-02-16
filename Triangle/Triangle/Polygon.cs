using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Polygon
    {
        List<Point> nodes;

        public Polygon(List<Point> points)
        {
            nodes = new List<Point>(points);
        }
    }
}
