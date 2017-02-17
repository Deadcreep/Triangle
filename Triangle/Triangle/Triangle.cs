using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public Point a;
        public Point b;
        public Point c;
        public Edge ab;
        public Edge bc;
        public Edge ac;

        double perimeter;
        double area;
        bool isosceles;
        bool right;

        public double Perimeter { get { return perimeter; } }
        public double Area { get { return area; } }

        public bool Isosceles { get { return isosceles; } }
        public bool Right { get { return right; } }


        public Triangle(Point first, Point second, Point third)   // Constructor
        {
            a = first;
            b = second;
            c = third;
            double e1 = Edge.Length(a, b);
            double e2 = Edge.Length(b, c);
            double e3 = Edge.Length(a, c);
            if (e1 + e2 <= e3 || e1 + e3 <= e2 || e3 + e2 <= e1)
            {
                throw new ArgumentException("incorrect coordinates");
            }
            Edge ab = new Edge(first, second);
            Edge bc = new Edge(second, third);
            Edge ac = new Edge(first, third);
            CalculateArea(e1, e2, e3);
            CalculatePerimeter(e1, e2, e3);
            CalculateIsosceles(e1, e2, e3);
            CalculateRight(e1, e2, e3);
        }

        private void CalculateArea(double ab, double bc, double ac)
        {
            double halfPerimeter = (ab + ac + bc) / 2;
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - ab) * (halfPerimeter - ac) * (halfPerimeter - bc));
        }

        private void CalculatePerimeter(double ab, double bc, double ac)
        {
            perimeter = ab + ac + bc;
        }

        private void CalculateIsosceles(double ab, double bc, double ac)
        {
            if (ab == ac || ab == bc || bc == ac)
                isosceles = true;
            else
                isosceles = false;
        }

        private void CalculateRight(double ab, double bc, double ac)
        {
            if (Math.Sqrt(ab * ab + ac * ac) == Math.Sqrt(bc * bc) ||
                Math.Sqrt(ab * ab + bc * bc) == Math.Sqrt(ac * ac) ||
                Math.Sqrt(ac * ac + bc * bc) == Math.Sqrt(ab * ab))
                right = true;
            else
                right = false;
        }

        public static bool operator ==(Triangle a, Triangle b)
        {
            return a.ab == b.ab && a.bc == b.bc ||
                   a.ab == b.bc && a.bc == b.ab ||
                   a.ac == b.ac && a.bc == b.bc ||
                   a.ac == b.bc && a.bc == b.ac ||
                   a.ab == b.ab && a.ac == b.ac ||
                   a.ab == b.ac && a.ac == b.ab;
        }
        public static bool operator !=(Triangle a, Triangle b)
        {
            return !(a == b);
        }

    }
}

