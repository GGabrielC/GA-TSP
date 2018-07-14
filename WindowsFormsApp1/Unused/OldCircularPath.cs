using CloneBehave;
using CloneExtensions;
using GA_Travelling_Salesman.Dependencies;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GA_Travelling_Salesman
{
    /* * /
    public class OldCircularPath
    {
        List<Coordinates> path;
        Decimal distance;

        public Decimal Distance { get => distance; }
        public Coordinates this[int key] { get => this.path[key]; private set => this.path[key] = value; }
        public int Count { get => path.Count; }
        public Coordinates First { get => path.First(); }
        public Coordinates Last { get => path.Last(); }

        public OldCircularPath(ICollection<Coordinates> path)
        {
            this.distance = 0;

            this.path = new List<Coordinates>(path.Count);
            Coordinates previousCoord = path.Last();
            foreach (var coord in path)
            {
                this.path.Add(coord);
                this.distance += previousCoord.DistanceTo(coord);
                previousCoord = coord;
            }
        }

        delegate void RefreshPanel();

        public void draw(Panel targetPanel, bool scaleToPanel = false)
        {
            if (targetPanel.InvokeRequired)
            {
                RefreshPanel d = new RefreshPanel(() =>
                {
                    targetPanel.Refresh();
                });
                targetPanel.Invoke(d, new object[] { });
            }
            else targetPanel.Refresh();

            System.Drawing.Graphics graphicsObj = targetPanel.CreateGraphics();

            var pen = new Pen(System.Drawing.Color.Blue, 2);
            foreach (var coord in path)
                graphicsObj.DrawEllipse(pen, coord.X - 3, coord.Y - 3, 6, 6);

            pen = new Pen(System.Drawing.Color.Green, 1);
            var prevCoord = path.Last();
            foreach (var coord in path)
            {
                graphicsObj.DrawLine(pen, coord.X, coord.Y, prevCoord.X, prevCoord.Y);
                prevCoord = coord;
            }
        }

        public void SwapByIndexes(int index1, int index2)
        {
            var coord1 = this[index1];
            var coord2 = this[index2];

            ReplaceAtIndex(index1, coord2);
            ReplaceAtIndex(index2, coord1);
        }

        void ReplaceAtIndex(int index, Coordinates newCoord)
        {
            var oldCoord = this[index];

            var prevCoord = (index == 0) ? Last : this[index - 1];
            var nextCoord = (index == Count - 1) ? First : this[index + 1];

            this.distance -= prevCoord.DistanceTo(oldCoord);
            this.distance -= nextCoord.DistanceTo(oldCoord);

            this.distance += prevCoord.DistanceTo(newCoord);
            this.distance += nextCoord.DistanceTo(newCoord);

            this[index] = newCoord;
        }

        public override string ToString()
        {
            return "Distance = " + this.distance + "; \nCount = " + this.Count
                    + this.path.MyToString();
        }

    }
    //*/
}
