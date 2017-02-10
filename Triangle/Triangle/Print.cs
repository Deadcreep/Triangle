using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Print
    {
        Triangle tt;
        public Print(Triangle tr) 
        {
            tt = tr;
        }

        public void PrintPerimeterArea(Triangle tt)
        {
            Console.WriteLine(Math.Round(tt.Perimeter, 2) + "\n" + Math.Round(tt.Area, 2) + "\n");
        }

        public void PrintIsosceles( Triangle tt)
        {
            if (tt.CheckIsosceles()) Console.WriteLine("Isosceles triangle");
            else Console.WriteLine("Not isosceles triangle");
        }

        public void PrintRight(Triangle tt)
        {
            if (tt.CheckRight()) Console.WriteLine("Right-angled triangle");
            else Console.WriteLine("Not right-angled triangle");
        }
    }
}
