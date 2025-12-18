using System;
class Si
{
  static void Main(string[] args)
    {
        double p =1000.0; // Principal amount
        double r = 5.0;    // Rate of interest
        double t = 3.0;    // Time in years

        double si = (p * r * t) / 100;
        Console.WriteLine("The Simple Interest is: " + si);
    }
}