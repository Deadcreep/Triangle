using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Triangle
{
    static class Reader
    {
        static public List<Triangle> ReadTriangle(string filename)
        {
            var lines = File.ReadAllLines(filename);
            List<Triangle> triangles = new List<Triangle>();

            for (int i = 0; i < lines.Length; ++i)
            {
                try
                {
                    string s = lines[i];
                    double[] coordinates = GetTriangleCoordinates(s);
                    Point p1 = new Point(coordinates[0], coordinates[1]);
                    Point p2 = new Point(coordinates[2], coordinates[3]);
                    Point p3 = new Point(coordinates[4], coordinates[5]);
                    var triangle = new Triangle(p1, p2, p3);
                    triangles.Add(triangle);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("Argument exception at line {0} : {1}", i, ae);
                }
            }
            return triangles;
        }

        static private double[] GetTriangleCoordinates(string s)
        {
            MatchCollection countMatches = Regex.Matches(s, @"[0-9]+\,[0-9]+|[0-9]+");
            if (countMatches.Count != 6)
            {
                throw new ArgumentException("Incorrect input" + s);
            }

            return new double[]{
                Convert.ToDouble(countMatches[0].Value),
                Convert.ToDouble(countMatches[1].Value),
                Convert.ToDouble(countMatches[2].Value),
                Convert.ToDouble(countMatches[3].Value),
                Convert.ToDouble(countMatches[4].Value),
                Convert.ToDouble(countMatches[5].Value),
                };
        }

        static public List<Polygon> ReadPolygon(string filename)
        {
            var lines = File.ReadAllLines("PolygonKit.txt");
            List<Polygon> polygones = new List<Polygon>();
            for (int i = 0; i < lines.Length; ++i)
            {
                try
                {
                    string s = lines[i];
                    var coordinates = GetPolygonCoordinates(s);
                    List<Point> points = new List<Point>();
                    for (int j = 0; j < coordinates.Count; j += 2)
                    {
                        Point temp = new Point(coordinates[j], coordinates[j + 1]);
                        points.Add(temp);                        
                    }
                    Polygon polygon = new Polygon(points);
                    polygones.Add(polygon);

                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("Argument exception at line {0} : {1}", i, ae);
                }
            }
            return polygones;
        }

        static private List<double> GetPolygonCoordinates(string s)
        {
            MatchCollection countMatches = Regex.Matches(s, @"[0-9]+\,[0-9]+|[0-9]+");
            if (countMatches.Count < 6 || countMatches.Count % 2 == 1)
            {
                throw new ArgumentException("Incorrect input" + s);
            }
            List<double> coordinates = new List<double>();
            foreach (Match item in countMatches)
            {
                coordinates.Add(Convert.ToDouble(item.Value));
            }

            return coordinates;
        }
    }

}


