using System;
using System.Collections.Generic;
using System.Linq;

namespace GA_Travelling_Salesman.Dependencies
{
    public class RandomIndex
    {
        private Random random;
        private List<float> cumulativeSum;
        private List<float> probabilitiesToPick;

        public int PoolCount { get => cumulativeSum.Count; }

        public RandomIndex(ICollection<float> probabilitiesToPick, Random random)
        {
            this.random = random;
            this.probabilitiesToPick = probabilitiesToPick.ToList();
            this.cumulativeSum = this.probabilitiesToPick.getCumulativeSumList();
        }

        public int NextIndex()
        {
            if (PoolCount > 16)
                return NextIndexBinarySearch();
            return NextIndexIterative();
        }

        private int NextIndexBinarySearch() // O(logn)
        {
            var rand = (float)this.random.NextDouble();
            var index = cumulativeSum.BinarySearchIndexInterval(rand);
            return index;
        }

        private int NextIndexIterative() // O(n)
        {
            var rand = (float)this.random.NextDouble();
            int i = 0;
            while (i < PoolCount)
                if (rand <= cumulativeSum[i])
                    return i;
                else i++;
            return i;
        }

        private int NextIndexRandom() // O(n)
        {
            int maybePickIndex;
            float p;
            do
            {
                maybePickIndex = random.Next(0, PoolCount);
                p = (float)this.random.NextDouble();
            } while (p > probabilitiesToPick[maybePickIndex]);
            return maybePickIndex;
        }

    }
}
