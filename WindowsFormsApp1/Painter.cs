using GA_Travelling_Salesman;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Painter
    {
        Panel targetPanel;
        Graphics graphicsObj;
        Pen penPoint = new Pen(System.Drawing.Color.Blue, 2);
        Pen penLine = new Pen(System.Drawing.Color.Green, 1);
        int radius = 3;

        public Painter(Panel targetPanel)
        {
            this.targetPanel = targetPanel;
            this.graphicsObj = targetPanel.CreateGraphics();
        }

        public void DrawPoints(ICollection<Point> points)
        {
            foreach (var point in points)
                graphicsObj.DrawEllipse(penPoint, point.X - radius/2, point.Y - radius/2, radius, radius);
        }

        public void DrawCircularPath(CircularPath path)
        {
            var points = path.ToArray();
            graphicsObj.DrawPolygon(penLine, points);
            DrawPoints(points);
        }

        public void DrawPoints(CircularPath path)
        {
            DrawPoints(path.ToArray());
        }

    }
}
