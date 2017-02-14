using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Averages
    {
        public void GetAverages()
        {
            double averagesPerimeterRight = 0;
            double averageAreaIsosceles = 0;
            double sumPerimeterRight = 0;
            double sumAreaIsosceles = 0;
            int countRight = 0;
            int countIso = 0;
            Reader reader = new Reader();
            Triangle[] triangles = reader.Read("TriangleKit.txt");
            for (int i = 0; i < triangles.Length; i++)
            {
                if (triangles[i].Isosceles == true)
                {
                    sumAreaIsosceles += triangles[i].Area;
                    countIso++;
                }

                if (triangles[i].Right == true)
                {
                    sumPerimeterRight += triangles[i].Perimeter;
                    countRight++;
                }
            }

            averagesPerimeterRight = sumPerimeterRight / countRight;
            averageAreaIsosceles = sumAreaIsosceles / countIso;

            Console.WriteLine("Average perimeter of right-angled triangles = " + Math.Round(averagesPerimeterRight, 2) + "\n");
            Console.WriteLine("Average area of isosceles triangles = " + Math.Round(averageAreaIsosceles, 2) + "\n");
        }
    }
}
