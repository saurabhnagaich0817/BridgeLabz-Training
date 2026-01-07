// Car class
public class Car : Vehicle, IGPS
{
    private string currentLocation;

    public Car(string id, string driver, double rate) : base(id, driver, rate)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        // Fare = distance * rate
        return distance * RatePerKm;
    }

    public string GetCurrentLocation() => currentLocation;

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
        Console.WriteLine($"Car location updated to: {currentLocation}");
    }
}

// Bike class
public class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public Bike(string id, string driver, double rate) : base(id, driver, rate)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        // Bikes have 10% cheaper fare
        return distance * RatePerKm * 0.9;
    }

    public string GetCurrentLocation() => currentLocation;

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
        Console.WriteLine($"Bike location updated to: {currentLocation}");
    }
}

// Auto class
public class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public Auto(string id, string driver, double rate) : base(id, driver, rate)
    {
        currentLocation = "Unknown";
    }

    public override double CalculateFare(double distance)
    {
        // Autos have 20% cheaper fare
        return distance * RatePerKm * 0.8;
    }

    public string GetCurrentLocation() => currentLocation;

    public void UpdateLocation(string newLocation)
    {
        currentLocation = newLocation;
        Console.WriteLine($"Auto location updated to: {currentLocation}");
    }
}
