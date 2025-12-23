using System;

class LargestNumber
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
        Console.WriteLine($"Is the first number the largest? {a>b&&a>c}");
        Console.WriteLine($"Is the second number the largest? {b>a&&b>c}");
        Console.WriteLine($"Is the third number the largest? {c >a&&c>b}");
    }
}
