class Program
{
    static void Main(string[] args)
    {
        // Create vehicles
        Vehicle car1 = new Car("C001", "Alice", 15);    
        Vehicle bike1 = new Bike("B001", "Bob", 10);    
        Vehicle auto1 = new Auto("A001", "Charlie", 8); 

        // Array of vehicles
        Vehicle[] vehicles = { car1, bike1, auto1 };

        double distance = 12.5; // in km

        Console.WriteLine("----- Ride Fare Details -----\n");

        foreach (var vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine($"Distance: {distance} km");
            double fare = vehicle.CalculateFare(distance);
            Console.WriteLine($"Calculated Fare: {fare}");

            // Update and show GPS location
            if (vehicle is IGPS gpsVehicle)
            {
                gpsVehicle.UpdateLocation("Downtown");
                Console.WriteLine($"Current Location: {gpsVehicle.GetCurrentLocation()}");
            }

            Console.WriteLine();
        }
    }
}
