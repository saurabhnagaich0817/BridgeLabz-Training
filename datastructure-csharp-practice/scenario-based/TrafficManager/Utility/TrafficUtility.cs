using System;
using TrafficManager.Interfaces;
using TrafficManager.Models;
using TrafficManager.DataStructures;

namespace TrafficManager.Utility
{
    class TrafficUtility : ITrafficService
    {
        private CircularLinkedList roundabout;
        private VehicleQueue queue;

        public TrafficUtility()
        {
            roundabout = new CircularLinkedList();
            queue = new VehicleQueue(5);
        }

        public void AddVehicleToQueue()
        {
            Console.Write("Enter Vehicle Number: ");
            string number = Console.ReadLine();

            Console.Write("Enter Driver Name: ");
            string driver = Console.ReadLine();

            Vehicle vehicle = new Vehicle(number, driver);
            queue.Enqueue(vehicle);
        }

        public void EnterRoundabout()
        {
            Vehicle vehicle = queue.Dequeue();

            if (vehicle != null)
            {
                roundabout.Add(vehicle);
                Console.WriteLine("Vehicle entered roundabout");
            }
        }

        public void ExitRoundabout()
        {
            roundabout.Remove();
        }

        public void DisplayRoundabout()
        {
            roundabout.Display();
        }

        public void DisplayQueue()
        {
            queue.Display();
        }
    }
}
