using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    static class PolygonCreator
    {
        static public Triangle CreateTriangle (Point first, Point second, Point third)
        {
            double ab = Edge.Length(first, second);
            double bc = Edge.Length(second, third);
            double ac = Edge.Length(first, third);
            
            if (ab + bc <= ac || ab + ac <= bc || ac + bc <= ab)
            {
                throw new ArgumentException("incorrect coordinates");
            }
            else
            {
                return new Triangle(first, second, third);
            }
        }

        static public Polygon CreatePolygon(List <Point> points)
        {
            if (points.Count < 3)
            {
                throw new ArgumentException("Incorrect coordinates");
            }
            else
            {
                Polygon polygon = new Polygon(points);
                return polygon; 
            }
        }
    }
}
