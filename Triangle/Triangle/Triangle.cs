using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        Point a;
        Point b;
        Point c;

        Edge ab;
        Edge ac;
        Edge bc;

        double perimeter;
        double area;

        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        public Triangle(Point first, Point second, Point third)
        {
            a = first;
            b = second;
            c = third;

            ab = new Edge(first, second);
            ac = new Edge(first, third);
            bc = new Edge(second, third);

            GetPerimeter();
            GetArea();
            CheckIsosceles();
            CheckRight();
        }


        public void GetArea()
        {
            double halfPerimeter = (ab.Length + ac.Length + bc.Length) / 2;
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - ab.Length) * (halfPerimeter - ac.Length) * (halfPerimeter - bc.Length));
        }

        public void GetPerimeter()
        {
            perimeter = ab.Length + ac.Length + bc.Length;
        }

        public bool CheckIsosceles()
        {
            if (ab.Length == ac.Length || ab.Length == bc.Length || bc.Length == ac.Length)
                return true;
            else
                return false;
        }

        public bool CheckRight()
        {
            if (Math.Sqrt(ab.Length * ab.Length + ac.Length * ac.Length) == Math.Sqrt(bc.Length * bc.Length) ||
                Math.Sqrt(ab.Length * ab.Length + bc.Length * bc.Length) == Math.Sqrt(ac.Length * ac.Length) ||
                Math.Sqrt(ac.Length * ac.Length + bc.Length * bc.Length) == Math.Sqrt(ab.Length * ab.Length))
                return true;
            else
                return false;
        }

    }

}
