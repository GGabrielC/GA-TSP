using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Dependencies
{
    public static class ExtensionMethodsPoint
    {
        public static Decimal DistanceTo(this Point p1, Point p2)
        {
            Decimal distance = (Decimal)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            return distance;
        }
        
    }
}
