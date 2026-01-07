class Program
{
    static void Main(string[] args)
    {
        // Array of vehicles
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car("C001", 2000, "CAR12345");
        vehicles[1] = new Bike("B001", 500, "BIKE12345");
        vehicles[2] = new Truck("T001", 5000, "TRUCK12345");

        int rentalDays = 3;

        Console.WriteLine("----- Vehicle Rental Details -----\n");

        foreach (var vehicle in vehicles)
        {
            decimal rentalCost = vehicle.CalculateRentalCost(rentalDays);
            decimal insurance = 0;

            if (vehicle is IInsurable insurableVehicle)
            {
                insurance = insurableVehicle.CalculateInsurance();
                Console.WriteLine(insurableVehicle.GetInsuranceDetails());
            }
            Console.WriteLine($"Vehicle: {vehicle.Type} ({vehicle.VehicleNumber})");
            Console.WriteLine($"Rental for {rentalDays} days: {rentalCost}");
            Console.WriteLine($"Insurance Cost: {insurance}");
            Console.WriteLine($"Total Cost: {rentalCost + insurance}\n");
        }
    }
}
