using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Travelling_Salesman.Observer
{
    public enum StateChanged {
        BestSolution,
        newGeneration,
        generationCount,
        populationCount,
        ExpectedExecutionStatus,
        ExpectedGenerationCount,
        ExpectedPopulationCount,
        ExepectedMutationRate,
        ExpectedFitnessDiscrimination,
        LastGenerationBestFitter,
        expectedAddBestSolutionToPopulation,
    };

    public abstract class ObserverAPI
    {
        protected Observable subject;
        public abstract void Update(StateChanged state);
    }
}
