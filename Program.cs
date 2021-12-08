using System;

namespace TrafficLightSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TrafficSignal trafficSignal = new TrafficSignal();
            trafficSignal.RunTrafficLight(21);

            //TrafficSignal trafficSignal1 = new TrafficSignal(1,2,3);
            //trafficSignal1.RunTrafficLight(30);
        }
    }
}
