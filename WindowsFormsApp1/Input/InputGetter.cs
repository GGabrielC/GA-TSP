using GA_Travelling_Salesman;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dependencies;

namespace WindowsFormsApp1.Input
{
    public class InputGetter
    {
        public static ICollection<Point> MakeValid(ICollection<Point> points) => new HashSet<Point>(points);

        public static ICollection<Point> getInputByFile()
        {
            var inputPoints = new LinkedList<Point>();

            OpenFileDialog openFileDialogInputFile = new System.Windows.Forms.OpenFileDialog();
            DialogResult result = openFileDialogInputFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialogInputFile.FileName;
                using (TextReader reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var x = int.Parse(line);
                        var y = int.Parse(reader.ReadLine());
                        inputPoints.AddLast(new Point(x, y));
                    }
                }
            }
            return MakeValid(inputPoints);
        }

        public static ICollection<Point> getInputByRandom(Random random)
        {
            ICollection<Point> input = new HashSet<Point>();
            new FormInput("Set number of Points", 10, (numPoints) =>
            {
                input = Helper.GenerateRandomPoints(numPoints, 0, 400, random);
            }, 4).ShowDialog();
            return input;
        }
    }
}
