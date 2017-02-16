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

           List<Triangle> triangles =  Reader.ReadTriangle("TriangleKit.txt");
           Averages.GetAverages(triangles);
        }
    }
}
