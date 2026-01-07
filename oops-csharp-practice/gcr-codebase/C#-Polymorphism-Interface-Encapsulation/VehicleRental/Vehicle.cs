using System;

// Abstract Vehicle class
public abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private decimal rentalRate;

    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set { vehicleNumber = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public decimal RentalRate
    {
        get { return rentalRate; }
        set
        {
            if (value >= 0)
                rentalRate = value;
            else
                Console.WriteLine("Rental rate cannot be negative.");
        }
    }

    public Vehicle(string number, string type, decimal rate)
    {
        VehicleNumber = number;
        Type = type;
        RentalRate = rate;
    }

    // Abstract method
    public abstract decimal CalculateRentalCost(int days);
}

// Interface for Insurable vehicles
public interface IInsurable
{
    decimal CalculateInsurance();
    string GetInsuranceDetails();
}
