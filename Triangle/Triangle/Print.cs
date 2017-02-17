using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    static class Print
    {
        static public void PrintAveragesForTriangle(double[] array)
        {
            Console.WriteLine("Average perimeter of right-angled triangles = " + Math.Round(array.First(), 2) + Environment.NewLine);
            Console.WriteLine("Average area of isosceles triangles = " + Math.Round(array.Last(), 2) + Environment.NewLine);
        }
        static public void PrintAveragesForPolygon(double[] array)
        {
            Console.WriteLine("Average perimeter of polygones = " + Math.Round(array.First(), 2) + Environment.NewLine);
            Console.WriteLine("Average area of polygones = " + Math.Round(array.Last(), 2) + Environment.NewLine);
        }
                     
    }
}
