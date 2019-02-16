using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CloneBehave;
using GA_Travelling_Salesman.Dependencies;
using GA_Travelling_Salesman.Observer;

namespace GA_Travelling_Salesman
{
    public abstract class API_GA_Solver<Specimen>: Observable
    {
        private LinkedList<ObserverAPI> observers = new LinkedList<ObserverAPI>();

        public static readonly int DEFAULT_GENERATION_COUNT = 10000;
        public static readonly int DEFAULT_POPULATION_COUNT = 50;
        public static readonly float DEFAULT_MUTATION_RATE = 0.01f;
        public static readonly float DEFAULT_FITNESS_DISCRIMINATION = 4.0f;
        public static readonly float MIN_FITNESS_DISCRIMINATION = 2.0f;
        public static readonly bool DEFAULT_ADD_BEST_SOLUTION_TO_POPULATION = false;


        volatile bool expectedExecutionStatus = false;
        volatile bool expectedAddBestSolutionToPopulation = DEFAULT_ADD_BEST_SOLUTION_TO_POPULATION;
        volatile int expectedGenerationCount = DEFAULT_GENERATION_COUNT;
        volatile int expectedPopulationCount = DEFAULT_POPULATION_COUNT;
        volatile float expectedMutationRate = DEFAULT_MUTATION_RATE;
        volatile float expectedFitnessDiscrimination = DEFAULT_FITNESS_DISCRIMINATION;

        volatile int currentGeneration = 0;
        volatile List<Specimen> population = null;
        Specimen bestSolution = default(Specimen);
        Specimen lastGenerationBestFitter = default(Specimen);
        protected Thread threadAlgorithm;
        
        public Decimal LastGenerationBestFitness { get => GetFitness(LastGenerationBestFitter); }
        public Decimal BestFitness { get => GetFitness(BestSolution); }
        public Decimal PopulationCount { get => Population.Count; }
        
        public bool Started { get => CurrentGeneration > 0; }
        public bool ThreadAlive { get => threadAlgorithm != null && threadAlgorithm.IsAlive; }
        public bool IsExecuting { get => ExpectedExecutionStatus; }
        public bool IsPaused { get => CurrentGeneration > 0 && !IsExecuting; }

        public bool ExpectedExecutionStatus {
            get => expectedExecutionStatus;
            private set
            {
                expectedExecutionStatus = value;
                notifyAllObservers(StateChanged.ExpectedExecutionStatus);
            }
        }
        public int ExpectedGenerationCount
        {
            get => expectedGenerationCount;
            set
            {
                expectedGenerationCount = value;
                notifyAllObservers(StateChanged.ExpectedGenerationCount);
            }
        }
        public int ExpectedPopulationCount
        {
            get => expectedPopulationCount;
            set
            {
                expectedPopulationCount = value;
                notifyAllObservers(StateChanged.ExpectedPopulationCount);
            }
        }
        public float ExpectedMutationRate
        {
            get => expectedMutationRate;
            set
            {
                expectedMutationRate = value;
                notifyAllObservers(StateChanged.ExepectedMutationRate);
            }
        }
        public float ExpectedFitnessDiscrimination
        {
            get => expectedFitnessDiscrimination;
            set
            {
                expectedFitnessDiscrimination = Math.Max(value, MIN_FITNESS_DISCRIMINATION);
                notifyAllObservers(StateChanged.ExpectedFitnessDiscrimination);
            }
        }

        public bool ExpectedAddBestSolutionToPopulation
        {
            get => expectedAddBestSolutionToPopulation;
            set
            {
                expectedAddBestSolutionToPopulation = value;
                notifyAllObservers(StateChanged.expectedAddBestSolutionToPopulation);
            }
        }

        protected List<Specimen> Population
        {
            get => population;
            set
            {
                var previousPopulation = Population;
                population = value;
                if (previousPopulation == Population)
                    return;
                if(previousPopulation == null || previousPopulation.Count != Population.Count)
                    notifyAllObservers(StateChanged.populationCount);
                
                LastGenerationBestFitter = Best(Population);
                UpdateBestSolution(LastGenerationBestFitter);
                CurrentGeneration++;
            }
        }

        public int CurrentGeneration
        {
            get => currentGeneration;
            protected set
            {
                currentGeneration = value;
                notifyAllObservers(StateChanged.newGeneration);
                if (CurrentGeneration >= ExpectedGenerationCount)
                    ExpectedExecutionStatus = false;
            }
        }

        public Specimen BestSolution
        {
            get => bestSolution;
            private set
            {
                if (value == null) return;
                bestSolution = value.Clone();
                notifyAllObservers(StateChanged.BestSolution);
            }
        }

        public Specimen LastGenerationBestFitter
        {
            get => lastGenerationBestFitter;
            protected set
            {
                lastGenerationBestFitter = value;
                notifyAllObservers(StateChanged.LastGenerationBestFitter);
            }
        }
        
        protected abstract List<Specimen> CreateFirstGeneration(int populationSize);
        protected abstract Specimen Mutate( Specimen specimen, float mutationRate);
        protected abstract Specimen Best( Specimen specimen1, Specimen specimen2);
        protected abstract Specimen Best( ICollection<Specimen> specimens);
        protected abstract Decimal GetFitness( Specimen specimen);
        protected abstract Specimen CrossOver(Specimen specimen1, Specimen specimen2);


        public void Attach(ObserverAPI observer) => observers.AddLast(observer);
        public void StopExecution() => ExpectedExecutionStatus = false;
        void UpdateBestSolution(List<Specimen> population) => BestSolution = Best(population);
        
        public void Execute()
        {
            ExpectedExecutionStatus = true;
            if (threadAlgorithm != null && threadAlgorithm.IsAlive)
                return;
            threadAlgorithm = new Thread(new ThreadStart(() =>
            {
                //List<int> x = new List<int>() { 1,10,50,100,200,300,400,500,750,1000,1500, 2000, 2500, 3000};
                while (ExpectedExecutionStatus)
                {
                    //if (x.Contains(CurrentGeneration))
                        //Console.WriteLine("{1}", CurrentGeneration, ((int)-BestFitness)/10);
                    Population = CreateNextGeneration(Population, ExpectedPopulationCount, ExpectedMutationRate);
                }
            }));
            threadAlgorithm.Start();
        }
        
        void UpdateBestSolution(dynamic solution)
        {
            if (solution == Best(BestSolution, solution))
                BestSolution = solution;
        }

        void notifyAllObservers(StateChanged change)
        {
            foreach(var observer in this.observers)
                observer.Update(change);
        }
        
        List<Specimen> CreateNextGeneration( List<Specimen> oldGeneration, int count, float mutationRate )
        {
            if (oldGeneration == null)
                return CreateFirstGeneration(count);
            if(expectedAddBestSolutionToPopulation)
                oldGeneration.Add(BestSolution.Clone());
            var combined = CrossOverBy2(Population, count);
            return combined.Select(el => Mutate(el, mutationRate)).ToList();
        }
        List<Specimen> CrossOverBy2( ICollection<Specimen> population, int count)
        {
            var picks1 = Selection(Population, count);
            var picks2 = Selection(Population, count);

            var combined = picks1.Zip(picks2, (specimen1, specimen2) =>
            {
                return CrossOver(specimen1, specimen2);
            });
            return combined.ToList();
        }
        List<Specimen> Selection(List<Specimen> population, int timesToPick )
        {
            var probabilitiesToPick = GetProbabilitiesToPick(population);
            var rIndex = new RandomIndex(probabilitiesToPick, GlobalRandom.Instance);
            var selected = new List<Specimen>(population.Count);
            while (timesToPick-- > 0)
                selected.Add(population[rIndex.NextIndex()]);
            return selected;
        }

        ICollection<float> GetProbabilitiesToPick(ICollection<Specimen> population)
        {
            var fitnessList = new List<float>();
            foreach (Specimen specimen in population)
            {
                var fitness = GetFitness(specimen);
                fitnessList.Add((float)fitness);
            }
            var probs1 = fitnessList.GetProbabilitiesToPickExponential(ExpectedFitnessDiscrimination);
            var probs2 = fitnessList.GetProbabilitiesToPickProportional();
            return probs1;
            //return probs2;
        }
    }
}
