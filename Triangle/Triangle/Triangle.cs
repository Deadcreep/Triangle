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

            CalculateProperties();
        }


        private void CalculateProperties()
        {
            double ab = Edge.Length(a, b);
            double bc = Edge.Length(b, c);
            double ac = Edge.Length(a, c);

            GetArea(ab, bc, ac);
            GetPerimeter(ab, bc, ac);
            GetIsosceles(ab, bc, ac);
            GetRight(ab, bc, ac);
        }

        private void GetArea(double ab, double bc, double ac)
        {
            double halfPerimeter = (ab + ac + bc) / 2;
            area = Math.Sqrt(halfPerimeter * (halfPerimeter - ab) * (halfPerimeter - ac) * (halfPerimeter - bc));
        }

        private void GetPerimeter(double ab, double bc, double ac)
        {
            perimeter = ab + ac + bc;
        }

        private void GetIsosceles(double ab, double bc, double ac)
        {
            if (ab == ac || ab == bc || bc == ac)
                isosceles = true;
            else
                isosceles = false;
        }

        private void GetRight(double ab, double bc, double ac)
        {
            if (Math.Sqrt(ab * ab + ac * ac) == Math.Sqrt(bc * bc) ||
                Math.Sqrt(ab * ab + bc * bc) == Math.Sqrt(ac * ac) ||
                Math.Sqrt(ac * ac + bc * bc) == Math.Sqrt(ab * ab))
                right = true;
            else
                right = false;
        }

    }
}


        //public static Triangle CreateTriangle(Point first, Point second, Point third)
        //{
        //    double ab = Edge.Length(first, second);
        //    double bc = Edge.Length(second, third);
        //    double ac = Edge.Length(first, third);

        //    
        //    if (ab + bc <= ac || ab + ac <= bc || ac + bc <= ab)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return triangle;
        //    }