using System;

class BusApplication
{
    public static void Main(string[] args)
    {
        RouteManager routeManager = new RouteManager();

        Console.WriteLine(" Bus Distance Tracking System");
        Console.WriteLine("1. Driver");
        Console.WriteLine("2. Passenger");

        int userType = Convert.ToInt32(Console.ReadLine());

        if (userType == 1)
        {
            StartDriver(routeManager);
        }
        else if (userType == 2)
        {
            StartPassenger(routeManager);
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }

    static void StartDriver(RouteManager routeManager)
    {
        Console.WriteLine("\nDriver started the journey");
        TrackStops(routeManager);
    }

    static void StartPassenger(RouteManager routeManager)
    {
        Console.WriteLine("\nPassenger boarded the bus");
        TrackStops(routeManager);
    }

    static void TrackStops(RouteManager routeManager)
    {
        //  MUST BE STRING, NOT CHAR
        string choice = "no";

        while (choice != "yes")
        {
            routeManager.AddDistanceForStop();

            Console.WriteLine("\nBus reached next stop");
            Console.WriteLine("Distance covered: " 
                              + routeManager.FetchTotalDistance() + " km");

            Console.Write("Do you want to get off? (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }

        Console.WriteLine("\nPassenger got off");
        Console.WriteLine("Total distance travelled: " 
                          + routeManager.FetchTotalDistance() + " km");
    }
}
