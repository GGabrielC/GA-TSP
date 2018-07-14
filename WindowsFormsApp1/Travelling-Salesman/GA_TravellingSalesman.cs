using CloneBehave;
using CloneExtensions;
using GA_Travelling_Salesman.Dependencies;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GA_Travelling_Salesman.Travelling_Salesman
{
    public class GA_TravellingSalesman : API_GA_Solver<CircularPath>
    {
        List<Point> destinations;

        public GA_TravellingSalesman(ICollection<Point> destinations)
        {
            this.destinations = new List<Point>(destinations.Count);
            foreach (var coord in destinations)
                this.destinations.Add(coord);
        }
        
        protected override CircularPath Mutate(CircularPath path, float mutationRate)
        {
            var numberOfMutations = Math.Max(1, (int)(mutationRate * path.Count) );
            while (numberOfMutations-- > 0)
            {
                if (GlobalRandom.Instance.Next(0, 2) % 2 == 0)
                    path.SwapDestinationRandomly(GlobalRandom.Instance);
                else path.MoveDestinationRandomly(GlobalRandom.Instance);
            }
            return path;
        }

        protected override CircularPath CrossOver(CircularPath path1, CircularPath path2)
        {
            var slice = path1.SliceRandom(GlobalRandom.Instance);
            var usedPoints = new HashSet<Point>(slice);
            var otherPoints = path2.ToList().FindAll((el) => !usedPoints.Contains(el));
            slice.AddRange(otherPoints);
            return new CircularPath(slice);
        }

        protected override Decimal GetFitness(CircularPath specimen)
        {
            if (specimen == null)
                return Decimal.MinValue;
            return -specimen.Distance;
        }

        protected override CircularPath Best(ICollection<CircularPath> paths)
        {
            CircularPath bestPath = null;
            foreach (var path in paths)
                bestPath = Best(bestPath, path);
            return bestPath;

        }
        protected override CircularPath Best(CircularPath path1, CircularPath path2)
        {
            if (path1 == null)
                return path2;
            if (path2 == null)
                return path1;

            if (GetFitness(path2).CompareTo(GetFitness(path1)) > 0)
                return path2;
            return path1;
        }

        protected override List<CircularPath> CreateFirstGeneration(int populationSize)
        {
            var population = new List<CircularPath>(populationSize);
            for (var i = 0; i < populationSize; i++)
            {
                destinations.Shuffle(GlobalRandom.Instance);
                population.Add( new CircularPath(destinations) );
            }
            return population;
        }
        
    }
}
