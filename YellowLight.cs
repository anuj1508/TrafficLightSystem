using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightSystem
{
    class YellowLight : TrafficLight, ITrafficLight
    {
        private readonly int Runtime;

        public YellowLight(int runTime)
        {
            this.Runtime = runTime;
        }

        public YellowLight()
        {
            this.Runtime = 2;
        }

        public int Start(int timeRemaining)
        {
            Status();
            return base.Start(timeRemaining, this.Runtime);
        }

        public void Status()
        {
            Console.WriteLine();
            Console.WriteLine("Yellow Light");
            Console.WriteLine();
        }

        public int GetRunTime()
        {
            return this.Runtime;
        }
    }
}