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
        double perimeter = 0;
          double area = 0;

        public Polygon(List<Point> points)
        {
            nodes = new List<Point>(points);
            CalculatePerimeter();
            CalculateArea();
            
        }
        public double Perimeter 
        {
            get { return perimeter; }
        }
        public double Area
        {
            get { return area; }
        }

        private void CalculatePerimeter()
        {
            for (int i = 0; i < nodes.Count-1; i++)
            {
                perimeter += Edge.Length(nodes[i], nodes[i + 1]);
            }
            perimeter += Edge.Length(nodes[nodes.Count - 1], nodes[0]);            
        }

        private void CalculateArea()
        {
            double temp = 0;
            for (int i = 0; i < nodes.Count-1; i++)
            {
                temp += (nodes[i + 1].X - nodes[i].X) * (nodes[i + 1].Y + nodes[i].Y);
            }
            temp += (nodes.First().X - nodes.Last().X) * (nodes.First().Y + nodes.Last().Y);
            area = Math.Abs(temp / 2);
        }
    }
}
