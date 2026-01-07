using System;

// Abstract Vehicle class
public abstract class Vehicle
{
    private string vehicleId;
    private string driverName;
    private double ratePerKm;

    // Encapsulated properties
    public string VehicleId { get { return vehicleId; } set { vehicleId = value; } }
    public string DriverName { get { return driverName; } set { driverName = value; } }
    public double RatePerKm { get { return ratePerKm; } set { ratePerKm = (value > 0) ? value : 0; } }

    public Vehicle(string id, string driver, double rate)
    {
        VehicleId = id;
        DriverName = driver;
        RatePerKm = rate;
    }

    // Abstract method to calculate fare
    public abstract double CalculateFare(double distance);

    // Concrete method to display vehicle details
    public void GetVehicleDetails()
    {
        Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate per Km: {RatePerKm}");
    }
}

// Interface for GPS functionality
public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}
