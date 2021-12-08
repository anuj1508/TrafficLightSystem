using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightSystem
{
    class TrafficSignal
    {
        private Queue<ITrafficLight> trafficLightQueue;

        public TrafficSignal()
        {
            SetUpQueue();
        }

        public TrafficSignal(int redLightTime, int yellowLightTime, int greenLightTime)
        {
            SetUpQueue(redLightTime, yellowLightTime, greenLightTime);
        }

        public void RunTrafficLight(int totalTime)
        {
            while(totalTime > 0)
            {
                var light = trafficLightQueue.Dequeue();
                totalTime = light.Start(totalTime);
                trafficLightQueue.Enqueue(light);
            }
        }

        private void SetUpQueue()
        {
            trafficLightQueue = new Queue<ITrafficLight>();
            trafficLightQueue.Enqueue(new RedLight());
            trafficLightQueue.Enqueue(new GreenLight());
            trafficLightQueue.Enqueue(new YellowLight());
        }

        private void SetUpQueue(int redLightTime, int yellowLightTime, int greenLightTime)
        {
            trafficLightQueue = new Queue<ITrafficLight>();
            trafficLightQueue.Enqueue(new RedLight(redLightTime));
            trafficLightQueue.Enqueue(new GreenLight(yellowLightTime));
            trafficLightQueue.Enqueue(new YellowLight(greenLightTime));
        }
    }
}
