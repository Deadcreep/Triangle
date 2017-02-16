using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    static class Print
    {
        static public void PrintPerimeterArea(Triangle triangle)
        {
            Console.WriteLine(Math.Round(triangle.Perimeter, 2) + Environment.NewLine + Math.Round(triangle.Area, 2) + Environment.NewLine);
        }

        static public void PrintIsosceles( Triangle triangle)
        {
            if (triangle.Isosceles == true) Console.WriteLine("Isosceles triangle");
            else Console.WriteLine("Not isosceles triangle");
        }

        static public void PrintRight(Triangle triangle)
        {
            if (triangle.Right == true) Console.WriteLine("Right-angled triangle");
            else Console.WriteLine("Not right-angled triangle");
        }

        static public void PrintPolygon(Polygon polygon)
        {
            Console.WriteLine(polygon.perimeter + Environment.NewLine + polygon.area);
        }
    }
}
