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

           Triangle[] triangles =  Reader.Reading("TriangleKit.txt");
           Averages.GetAverages(triangles);
        }
    }
}
