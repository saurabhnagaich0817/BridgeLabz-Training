using System;
using TrafficManager.Utility;

namespace TrafficManager
{
    class Menu
    {
        public static void Show()
        {
            TrafficUtility service = new TrafficUtility();
            int choice;

            do
            {
                Console.WriteLine("\n1 Add Vehicle to Queue");
                Console.WriteLine("2 Enter Roundabout");
                Console.WriteLine("3 Exit Roundabout");
                Console.WriteLine("4 Display Roundabout");
                Console.WriteLine("5 Display Queue");
                Console.WriteLine("0 Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddVehicleToQueue();
                        break;

                    case 2:
                        service.EnterRoundabout();
                        break;

                    case 3:
                        service.ExitRoundabout();
                        break;

                    case 4:
                        service.DisplayRoundabout();
                        break;

                    case 5:
                        service.DisplayQueue();
                        break;
                }

            } while (choice != 0);
        }
    }
}
