using System;

class WindChill
{
    public static double windchill(double temp, double speed)
    {
        // formula to calculate wind chill
        return 35.74 + 0.6215 * temp +
               (0.4275 * temp - 35.75) * Math.Pow(speed, 0.16);
    }

    static void Main()
    {
    // taking temp and wind speed as input from user
        Console.Write("Enter temp: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed: ");
        double speed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wind Chill: " + windchill(temp, speed));
    }
}
