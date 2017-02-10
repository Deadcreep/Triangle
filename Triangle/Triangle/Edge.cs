using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        Point first;
        Point second;
        double length;

        public double Length
        {
            get { return length; }
            private set { length = value; }
        }

        public Edge(Point f, Point s)       // Construct
        {
            first = f;
            second = s;

            calculateLength();
        }

        public void calculateLength()      // Method
        {
            var l = Math.Sqrt((second.X - first.X) * (second.X - first.X) + (second.Y - first.Y) * (second.Y - first.Y));
            Length = l;
        }
    }
}
