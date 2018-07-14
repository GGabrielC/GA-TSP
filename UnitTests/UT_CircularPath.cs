using System.Collections.Generic;
using System.Linq;
using GA_Travelling_Salesman;
using GA_Travelling_Salesman.Dependencies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTEST_CircularPath
    {
        static float getExpectedDistance(CircularPath path)
        {
            var pathList = path.ToList();
            var distance = 0.0f;
            var before = pathList.Last();
            foreach (var coord in pathList)
            {
                distance += before.DistanceTo(coord);
                before = coord;
            }
            
            return distance;
        }

        static void checkSwap(CircularPath path)
        {
            path.SwapDestinationRandomly();
            float actual = path.Distance;
            float expected = getExpectedDistance(path);
            var distancesAreEqual = actual.EEquals(expected);
            Assert.IsTrue(distancesAreEqual);
        }

        static void checkMove(CircularPath path)
        {
            path.MoveDestinationRandomly();
            float actual = path.Distance;
            float expected = getExpectedDistance(path);
            var distancesAreEqual = actual.EEquals(expected);
            Assert.IsTrue(distancesAreEqual);
        }

        [TestMethod]
        public void Test_Distance()
        {
            int testTimes = 2500;
            int times = testTimes;
             while (times-- > 0)
            {
                var coords = new List<Point>();
                var count = 4;
                var path = new CircularPath(Point.GenerateRandom(count, 0, 100));
                var lastIndex = path.Count - 1;

                var times2 = testTimes;
                while (times2-- > 0)
                {
                    //checkSwap(path);
                    checkMove(path);
                }
            }
            
        }
        
    }
}
