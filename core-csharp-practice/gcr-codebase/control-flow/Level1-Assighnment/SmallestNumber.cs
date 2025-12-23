using System;
class SmallestOfThree
{
    static void Main()
    {
      // taking 3 number as input from user
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());
        // checking smallest number
        bool res = (a<b&&a<c);
        // printing result
        Console.WriteLine($"Is the first number the smallest? {res}");
    }
}
