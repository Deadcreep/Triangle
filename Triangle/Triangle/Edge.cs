using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        public readonly Point first;
        public readonly Point second;        
           
        public Edge(Point f, Point s)       // Construct
        {
            first = f;
            second = s;
        }

        public static double Length( Point first, Point second)
        {
              return Math.Sqrt((second.X - first.X) * (second.X - first.X) + (second.Y - first.Y) * (second.Y - first.Y));
        }
       
    }
}
