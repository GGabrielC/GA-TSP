using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Travelling_Salesman.Observer
{
    public interface Observable
    {
        void Attach(ObserverAPI observer);
    }
}
