using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightSystem
{
    class GreenLight : TrafficLight, ITrafficLight
    {
        private readonly int Runtime;

        public GreenLight(int runTime)
        {
            this.Runtime = runTime;
        }

        public GreenLight()
        {
            this.Runtime = 8;
        }

        public int Start(int timeRemaining)
        {
            Status();
            return base.Start(timeRemaining, this.Runtime);
        }

        public void Status()
        {
            Console.WriteLine();
            Console.WriteLine("Green Light");
            Console.WriteLine();
        }

        public int GetRunTime()
        {
            return this.Runtime;
        }
    }
}