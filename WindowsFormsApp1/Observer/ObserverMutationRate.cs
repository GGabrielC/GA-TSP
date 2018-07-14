using GA_Travelling_Salesman;
using GA_Travelling_Salesman.Observer;
using GA_Travelling_Salesman.Travelling_Salesman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Observers
{
    public class ObserverMutationRate : Observer<CircularPath>
    {
        Action trigger;

        public ObserverMutationRate(GA_TravellingSalesman subject, Action trigger)
        {
            this.subject = subject;
            this.subject.Attach(this);
            this.trigger = trigger;
        }

        public override void Update(StateChanged change)
        {
            if (change == StateChanged.newGeneration)
                trigger();
        }
    }
}
