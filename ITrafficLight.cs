using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightSystem
{
    interface ITrafficLight
    {
        int GetRunTime();
        int Start(int timeRemaining);
        void Status();
    }
}
