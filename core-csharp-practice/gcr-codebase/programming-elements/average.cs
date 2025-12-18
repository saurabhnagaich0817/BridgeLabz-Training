using System;
class Average
{
  static void Main()
    {
        Console.Write("Enter first number: ");
        double a =Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double avg =(a+b)/2;
        Console.WriteLine("Average = " + avg);
    }
}