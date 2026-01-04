using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance
{
    class Transport
    {
        public int topSpeed;
        public string energySource;

        public Transport(int topSpeed, string energySource)
        {
            this.topSpeed = topSpeed;
            this.energySource = energySource;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Top Speed is : " + topSpeed);
            Console.WriteLine("Energy Source is : " + energySource);
        }
    }

    class Sedan : Transport
    {
        public int seatCount;

        public Sedan(int topSpeed, string energySource, int seatCount)
            : base(topSpeed, energySource)
        {
            this.seatCount = seatCount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Seats : " + seatCount);
        }
    }

    class Lorry : Transport
    {
        public int loadLimit;

        public Lorry(int topSpeed, string energySource, int loadLimit)
            : base(topSpeed, energySource)
        {
            this.loadLimit = loadLimit;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Load Limit : " + loadLimit);
        }
    }

    class Bike : Transport
    {
        public bool sideCarAvailable;

        public Bike(int topSpeed, string energySource, bool sideCarAvailable)
            : base(topSpeed, energySource)
        {
            this.sideCarAvailable = sideCarAvailable;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Side Car Available : " + sideCarAvailable);
        }
    }

    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sedan details (speed, fuel, seats)");
            int carSpeed = int.Parse(Console.ReadLine());
            string carFuel = Console.ReadLine();
            int carSeats = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter lorry details (speed, fuel, load)");
            int truckSpeed = int.Parse(Console.ReadLine());
            string truckFuel = Console.ReadLine();
            int truckLoad = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter bike details (speed, fuel, sidecar true/false)");
            int bikeSpeed = int.Parse(Console.ReadLine());
            string bikeFuel = Console.ReadLine();
            bool bikeSideCar = bool.Parse(Console.ReadLine());

            Transport[] transportList = new Transport[3];
            transportList[0] = new Sedan(carSpeed, carFuel, carSeats);
            transportList[1] = new Lorry(truckSpeed, truckFuel, truckLoad);
            transportList[2] = new Bike(bikeSpeed, bikeFuel, bikeSideCar);

            Console.WriteLine();
            Console.WriteLine("----- Transport Information -----");

            foreach (Transport item in transportList)
            {
                item.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}