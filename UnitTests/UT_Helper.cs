using GA_Travelling_Salesman;
using GA_Travelling_Salesman.Dependencies;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Dependencies;

namespace UnitTests
{
    [TestClass]
    public class UnitTEST_Helper
    {
        [TestMethod]
        public void Test_GetProbabilitiesToPick(Random random)
        {
            var count = 20;
            var fitnessList = new List<float>(count);
            for (int i = 0; i < count; i++)
                fitnessList.Add( (float)random.NextDouble());
            var probabilities = fitnessList.GetProbabilitiesToPick();

            var sum = probabilities.Sum();
            Assert.IsTrue( sum.EEquals(1) );
        }
        
        /*
        static long getElapsedTimeRandIndex(int timesPick, RandIndex randIndex)
        {
            var counter = new List<int>(randIndex.PoolCount);
            for (int i = 0; i < counter.Count; i++)
                counter.Add(0);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (timesPick-- > 0)
            {
                var index = randIndex.NextIndex();
                counter[index]++;
            }
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }
        */

    }
}
