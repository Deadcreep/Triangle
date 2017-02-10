using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Triangle
{
    class Reader
    {
        public Triangle[] Read(string filename)
        {
            var lines = File.ReadAllLines(filename);
            Triangle[] triangles = new Triangle[lines.Length];

            for (int i = 0; i < lines.Length; ++i)
            {
                Point p1 = new Point(0, 0);
                Point p2 = new Point(0, 0);
                Point p3 = new Point(0, 0);
                string s = lines[i];
                MatchCollection countMatches = Regex.Matches(s, "[0-9]+");
                if (countMatches.Count != 6) continue;
                p1.X = int.Parse(countMatches[0].Value);
                p1.Y = int.Parse(countMatches[1].Value);
                p2.X = int.Parse(countMatches[2].Value);
                p2.Y = int.Parse(countMatches[3].Value);
                p3.X = int.Parse(countMatches[4].Value);
                p3.Y = int.Parse(countMatches[5].Value);
                
                Triangle temp = new Triangle(p1, p2, p3);
                triangles[i] = temp;
            }
            return triangles;
        }

    }
}