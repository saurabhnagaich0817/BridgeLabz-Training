using System;

class UnitConvertor2
{
    public static double ConvertYardsToFeet(double yards){
        return yards * 3;
    }

    public static double ConvertFeetToYards(double feet){
        return feet * 0.333333;
    }

    public static double ConvertMetersToInches(double meters)
    {
        return meters * 39.3701;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        return inches * 0.0254;
    }

    public static double ConvertInchesToCm(double inches)
    {
        return inches * 2.54;
    }

    static void Main()
    {
        Console.WriteLine("Yards to Feet: " + ConvertYardsToFeet(5));
        Console.WriteLine("Feet to Yards: " + ConvertFeetToYards(9));
        Console.WriteLine("Meters to Inches: " + ConvertMetersToInches(2));
        Console.WriteLine("Inches to Meters: " + ConvertInchesToMeters(40));
        Console.WriteLine("Inches to CM: " + ConvertInchesToCm(10));
    }
}
