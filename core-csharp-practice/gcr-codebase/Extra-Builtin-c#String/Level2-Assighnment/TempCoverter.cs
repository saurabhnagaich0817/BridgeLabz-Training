using System;

class TempConverter
{
    static double celtofrh(double c)
    {
        return(c * 9 / 5) + 32;
    }

    static double frhtocel(double f)
    {
        return(f - 32) * 5 / 9;
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Choose option: ");
        int choice = int.Parse(Console.ReadLine());
// Perform conversion based on user choice
        if(choice == 1)
            Console.WriteLine("Result: " + celtofrh(temp));
        else
            Console.WriteLine("Result: " + frhtocel(temp));
    }
}
