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
        bool isosceles;
        bool right;

        public double Perimeter { get { return perimeter; } }
        public double Area { get { return area; } }

        public bool Isosceles { get { return isosceles; } }
        public bool Right { get { return right; } }


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
            GetIsosceles();
            GetRight();
        }


        private void GetArea()
        {
            double halfPerimeter = (ab.Length + ac.Length + bc.Length) / 2;
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - ab.Length) * (halfPerimeter - ac.Length) * (halfPerimeter - bc.Length));
        }

        private void GetPerimeter()
        {
            perimeter = ab.Length + ac.Length + bc.Length;
        }

        private void GetIsosceles()
        {
            if (ab.Length == ac.Length || ab.Length == bc.Length || bc.Length == ac.Length)
                isosceles =  true;
            else
                isosceles = false;
        }

        private void GetRight()
        {
            if (Math.Sqrt(ab.Length * ab.Length + ac.Length * ac.Length) == Math.Sqrt(bc.Length * bc.Length) ||
                Math.Sqrt(ab.Length * ab.Length + bc.Length * bc.Length) == Math.Sqrt(ac.Length * ac.Length) ||
                Math.Sqrt(ac.Length * ac.Length + bc.Length * bc.Length) == Math.Sqrt(ab.Length * ab.Length))
                right = true;
            else
                right = false;
        }

    }

}
