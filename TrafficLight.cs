using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightSystem
{
    class TrafficLight
    {
        public int Start(int timeRemaining, int lightRunTime)
        {
            if (timeRemaining < lightRunTime)
            {
                ShowCountDown(timeRemaining);
                return 0;
            }
            else
            {
                ShowCountDown(lightRunTime);
                return timeRemaining - lightRunTime;
            }
        }

        public void ShowCountDown(int time)
        {
            for (int i = time; i > 0; i--)
            {
                Console.WriteLine($"Time Remaining : {i}");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
