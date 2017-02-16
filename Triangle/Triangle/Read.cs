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
        static public List<Triangle> Reading(string filename)
        {
            var lines = File.ReadAllLines(filename);
            List<Triangle> triangles = new List<Triangle>();

            for (int i = 0; i < lines.Length; ++i)
            {
                try
                {
                    string s = lines[i];
                    double[] Coordinates = GetTriangleCoordinates(s);
                    Point p1 = new Point(Coordinates[0], Coordinates[1]);
                    Point p2 = new Point(Coordinates[2], Coordinates[3]);
                    Point p3 = new Point(Coordinates[4], Coordinates[5]);
                    var triangle = TriangleCreator.CreateTriangle(p1, p2, p3);
                    triangles.Add(triangle);
                }

                catch(ArgumentException ae)
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

            return
              new double[]  {
                Convert.ToDouble(countMatches[0].Value),
                Convert.ToDouble(countMatches[1].Value),
                Convert.ToDouble(countMatches[2].Value),
                Convert.ToDouble(countMatches[3].Value),
                Convert.ToDouble(countMatches[4].Value),
                Convert.ToDouble(countMatches[5].Value),
                };
        }
    }
}

