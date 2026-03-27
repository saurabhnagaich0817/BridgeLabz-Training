using System;

class MaxNo
{
    static int maxx(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    static void Main()
    {
      // Taking three numbers as input from user
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Maximum number is: " + maxx(a, b, c));
    }
}
