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
    public class ObserverMulti : ObserverAPI
    {
        Dictionary<StateChanged, LinkedList<Action<Observable>>> triggers = new Dictionary<StateChanged, LinkedList<Action<Observable>>>();

        public ObserverMulti(API_GA_Solver<CircularPath> subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void AddTrigger(StateChanged change, Action<Observable> trigger)
        {
            LinkedList<Action<Observable>> listValue;

            if (!this.triggers.ContainsKey(change))
            {
                listValue = new LinkedList<Action<Observable>>();
                triggers[change] = listValue;
            }
            else listValue = triggers[change];

            listValue.AddLast(trigger);
        }

        public override void Update(StateChanged change)
        {
            if (!this.triggers.ContainsKey(change))
                return;

            var listTriggers = this.triggers[change];
            if (listTriggers == null)
                return;

            foreach (var trigger in listTriggers)
                trigger(subject);
        }
    }
}
