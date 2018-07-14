using GA_Travelling_Salesman;
using GA_Travelling_Salesman.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    /* * /
    class UT_RandIndex
    {
        static void checkEachRandIndex()
        {
            var list = new List<float>() { 0.3f, 0.1f, 0.4f, 0.2f };
            var r1 = new RandomIndex_BinarySearch(list);
            var r2 = new RandomIndex_Iterative(list);
            var r3 = new RandomIndex_Random(list);
            Console.WriteLine(list.MyToString());
            var timesToPick = 1000000;
            checkRandIndex(timesToPick, r1);
            checkRandIndex(timesToPick, r2);
            checkRandIndex(timesToPick, r3);
        }

        static void checkRandIndex(int timesPick, RandIndex randIndex)
        {
            var counter = new List<int>(randIndex.PoolCount);
            for (int i = 0; i < counter.Capacity; i++)
                counter.Add(0);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            while (timesPick-- > 0)
            {
                var index = randIndex.NextIndex();
                counter[index]++;
            }
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(counter.MyToString() + " " + elapsedMs);

        }

    }

    public interface RandIndex
    {
        int NextIndex();
        int PoolCount { get; }
    }

    public class RandomIndex_BinarySearch : RandIndex // O(logn)
    {
        List<float> cumulativeSum;
        public int PoolCount { get => cumulativeSum.Count; }

        public RandomIndex_BinarySearch(ICollection<float> probabilitiesToPick)
            => this.cumulativeSum = Helper.getCumulativeSumList(probabilitiesToPick).ToList();

        public int NextIndex()
        {
            var rand = (float)GlobalRandom.Instance.NextDouble();
            var index = cumulativeSum.BinarySearchIndexInterval(rand);
            return index;
        }

    }

    public class RandomIndex_Random : RandIndex // O(n)
    {
        List<float> probabilitiesToPick;
        public int PoolCount { get => probabilitiesToPick.Count; }

        public RandomIndex_Random(ICollection<float> probabilitiesToPick)
            => this.probabilitiesToPick = probabilitiesToPick.ToList();

        public int NextIndex()
        {
            int maybePickIndex;
            float p;
            do
            {
                maybePickIndex = GlobalRandom.Instance.Next(0, PoolCount);
                p = (float)GlobalRandom.Instance.NextDouble();
            } while (p > probabilitiesToPick[maybePickIndex]);
            return maybePickIndex;
        }
    }

    public class RandomIndex_Iterative : RandIndex // O(n)
    {
        List<float> cumulativeSum;
        public int PoolCount { get => cumulativeSum.Count; }

        public RandomIndex_Iterative(ICollection<float> probabilitiesToPick)
            => this.cumulativeSum = Helper.getCumulativeSumList(probabilitiesToPick).ToList();

        public int NextIndex()
        {
            var rand = (float)GlobalRandom.Instance.NextDouble();
            int i = 0;
            while (i < PoolCount)
                if (rand <= cumulativeSum[i])
                    return i;
                else i++;
            return i;
        }
    }
    //*/
}
   
