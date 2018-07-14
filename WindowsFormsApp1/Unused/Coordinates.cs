using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Travelling_Salesman
{
    /* * /
    public class Coordinates
    {
        int x;
        int y;

        public int X { get => x; }
        public int Y { get => y; }

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }

        public Decimal DistanceTo(Coordinates p)
        {
            Decimal distance = (Decimal) Math.Sqrt(Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2));
            return distance;
        }

        public static List<Coordinates> GenerateRandom(int times, int minValue, int maxValue) // TODO Better
        {
            var coords = new List<Coordinates>(times);

            while (times-- > 0)
            {
                var x = GlobalRandom.Instance.Next(minValue, maxValue + 1);
                var y = GlobalRandom.Instance.Next(minValue, maxValue + 1);
                coords.Add(new Coordinates(x, y));
            }

            return coords;
        }
    }
    //*/
}
