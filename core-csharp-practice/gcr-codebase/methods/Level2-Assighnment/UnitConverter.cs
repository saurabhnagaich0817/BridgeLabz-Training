using System;

class UnitConvertor
{
    public static double ConvertKmToMiles(double km){
        return km * 0.621371;
    }

    public static double ConvertMilesToKm(double miles){
        return miles * 1.60934;
    }

    public static double ConvertMetersToFeet(double meters){
        return meters * 3.28084;
    }

    public static double ConvertFeetToMeters(double feet){
        return feet * 0.3048;
    }

    static void Main()
    {
        Console.WriteLine("Km to Miles: " + ConvertKmToMiles(10));
        Console.WriteLine("Miles to Km: " + ConvertMilesToKm(5));
        Console.WriteLine("Meters to Feet: " + ConvertMetersToFeet(2));
        Console.WriteLine("Feet to Meters: " + ConvertFeetToMeters(6));
    }
}
