using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Dependencies
{
    public static class Helper
    {
        public static HashSet<Point> GenerateRandomPoints(int count, int minValue, int maxValue, Random random, bool unique=true)
        {
            var upperBound = maxValue + 1;
            var points = new HashSet<Point>();

            while (points.Count != count)
                points.Add(new Point(
                    random.Next(minValue, upperBound),
                    random.Next(minValue, upperBound)
                ));

            return points;
        }

    }
}
