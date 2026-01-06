using System;

class RentalApp
{
    static void Main()
    {
        TwoWheeler[] bikeList =
        {
            new TwoWheeler(101, "Yamaha"),
            new TwoWheeler(102, "Honda")
        };

        FourWheeler[] carList =
        {
            new FourWheeler(201, "Hyundai"),
            new FourWheeler(202, "Toyota")
        };

        HeavyVehicle[] truckList =
        {
            new HeavyVehicle(301, "Tata")
        };

        while (true)
        {
            Console.WriteLine("\n=== VEHICLE RENT PORTAL ===");
            Console.WriteLine("1. Bike");
            Console.WriteLine("2. Car");
            Console.WriteLine("3. Truck");
            Console.WriteLine("4. Exit");
            Console.Write("Select option: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 4) break;

            if (choice == 1) ProcessRental(bikeList);
            else if (choice == 2) ProcessRental(carList);
            else if (choice == 3) ProcessRental(truckList);
            else Console.WriteLine("Wrong selection!");
        }
    }

    static void ProcessRental(Transport[] list)
    {
        Console.WriteLine("\nAvailable Vehicles:");
        foreach (var v in list)
        {
            if (v.IsFree)
            {
                Console.WriteLine(
                    $"Code: {v.Code}, Brand: {v.Company}, " +
                    $"Day: ₹{v.PerDayCharge}, Hour: ₹{v.PerHourCharge}"
                );
            }
        }

        Console.Write("\nEnter vehicle code: ");
        int code = int.Parse(Console.ReadLine());

        Transport selected = null;
        foreach (var v in list)
        {
            if (v.Code == code && v.IsFree)
            {
                selected = v;
                break;
            }
        }

        if (selected == null)
        {
            Console.WriteLine("Vehicle not available!");
            return;
        }

        Console.WriteLine("1. Daily Rent");
        Console.WriteLine("2. Hourly Rent");
        Console.Write("Choose mode: ");
        bool hourly = int.Parse(Console.ReadLine()) == 2;

        Console.Write($"Enter {(hourly ? "hours" : "days")}: ");
        int timeValue = int.Parse(Console.ReadLine());

        decimal cost = selected.GetRentCost(timeValue, hourly);
        selected.Book();

        Invoice.Generate(selected, timeValue, hourly, cost);
    }
}
