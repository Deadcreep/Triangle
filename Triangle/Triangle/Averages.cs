using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    static class Averages
    {
        static public void GetAverages(List<Triangle> triangles)
        {
            double averagesPerimeterRight = 0;
            double averageAreaIsosceles = 0;
            double sumPerimeterRight = 0;
            double sumAreaIsosceles = 0;
            int countRight = 0;
            int countIso = 0;           
            foreach(var triangle in triangles)
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

            averagesPerimeterRight = sumPerimeterRight / countRight;
            averageAreaIsosceles = sumAreaIsosceles / countIso;

            Console.WriteLine("Average perimeter of right-angled triangles = " + Math.Round(averagesPerimeterRight, 2) + Environment.NewLine);
            Console.WriteLine("Average area of isosceles triangles = " + Math.Round(averageAreaIsosceles, 2) + Environment.NewLine);
        }
    }
}
