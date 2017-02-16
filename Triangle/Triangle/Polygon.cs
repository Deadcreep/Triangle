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
        public  double perimeter;
        public  double area;

        public Polygon(List<Point> points)
        {
            nodes = new List<Point>(points);
            CalculatePerimeter();
            perimeter = 0;
        }

        private double CalculatePerimeter()
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                perimeter += Edge.Length(nodes[i], nodes[i + 1]);
            }
            perimeter += Edge.Length(nodes[nodes.Count - 1], nodes[0]);

            return perimeter;
        }
    }
}
