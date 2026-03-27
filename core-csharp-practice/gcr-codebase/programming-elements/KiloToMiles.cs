using System;
class KiloToMiles
{static void Main(string[] args)
    {
        Console.Write("Enter distance in kilometers: ");
        double km= Convert.ToDouble(Console.ReadLine());
        double m = km*0.621371;
        Console.WriteLine("Distance in miles: " + m);
    }
}
