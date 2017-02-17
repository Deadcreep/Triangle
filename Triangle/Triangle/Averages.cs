using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    static class Averages
    {
        static public double[] GetAveragesForTriangles(List<Triangle> triangles)
        {
            double averagesPerimeterRight = 0;
            double averageAreaIsosceles = 0;
            double sumPerimeterRight = 0;
            double sumAreaIsosceles = 0;
            int countRight = 0;
            int countIso = 0;
            foreach (var triangle in triangles)
            {
                if (triangle == null) continue;
                if (triangle.Isosceles == true)
                {
                    sumAreaIsosceles += triangle.Area;
                    countIso++;
                }

                if (triangle.Right == true)
                {
                    sumPerimeterRight += triangle.Perimeter;
                    countRight++;
                }
            }

            return new double[] {sumPerimeterRight / countRight,
           sumAreaIsosceles / countIso};
        }

        static public double[] GetAveragesForPolygones(List<Polygon> polygones)
        {
            double sumPerimeter = 0;
            double sumArea = 0;
            foreach (var polygon in polygones)
            {

                sumArea += polygon.Area;

                sumPerimeter += polygon.Perimeter;

            }

            return new double[] {sumPerimeter / polygones.Count,
            sumArea / polygones.Count};
        }
    }
}
