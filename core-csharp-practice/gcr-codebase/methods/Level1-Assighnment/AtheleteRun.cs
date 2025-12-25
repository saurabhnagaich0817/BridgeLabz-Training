using System;

class AthleteRun
{
static double Round(double a, double b, double c)
    {
        double perimeter = a + b + c;
        return 5000 / perimeter;
    }

    static void Main()
    {
      // taking side 1 as input from user
        Console.Write("Enter side 1: ");
        double a = Convert.ToDouble(Console.ReadLine());
// taking side 2 as input from user
        Console.Write("Enter side 2: ");
        double b = Convert.ToDouble(Console.ReadLine());
// taking side 3 as input from user
        Console.Write("Enter side 3: ");
        double c = Convert.ToDouble(Console.ReadLine());
// calculating rounds
        double rounds = Round(a, b, c);
        Console.WriteLine("Number of rounds needed: " + rounds);
    }
}
