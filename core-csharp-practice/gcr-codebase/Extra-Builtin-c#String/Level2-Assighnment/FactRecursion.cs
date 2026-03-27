using System;

class FactRecursion
{
    static int Factorial(int n)
    {
        if(n == 0)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
// Calculating factorial using recursion
        Console.WriteLine("Factorial: " + Factorial(num));
    }
}
