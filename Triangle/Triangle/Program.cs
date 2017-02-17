using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> polygons = Reader.ReadPolygon("PolygonKit.txt");
            List<Triangle> triangles = Reader.ReadTriangle("TriangleKit.txt");
            double[] average =  Averages.GetAveragesForTriangles(triangles);
            Print.PrintAveragesForTriangle(average);
            Print.PrintAveragesForPolygon(Averages.GetAveragesForPolygones(polygons));
        }
    }
}
