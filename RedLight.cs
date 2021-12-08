using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightSystem
{
    class RedLight : TrafficLight, ITrafficLight
    {
        private readonly int Runtime;

        public RedLight(int runTime)
        {
            this.Runtime = runTime;
        }

        public RedLight()
        {
            this.Runtime = 5;
        }

        public int Start(int timeRemaining)
        {
            Status();
            return base.Start(timeRemaining, this.Runtime);
        }

        public void Status()
        {
            Console.WriteLine();
            Console.WriteLine("Red Light");
            Console.WriteLine();
        }

        public int GetRunTime()
        {
            return this.Runtime;
        }
    }
}
