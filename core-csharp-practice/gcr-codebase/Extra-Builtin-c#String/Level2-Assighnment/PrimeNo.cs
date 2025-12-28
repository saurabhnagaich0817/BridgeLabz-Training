using System;

class PrimeChecker
{
    static bool IsPrime(int n)
    {
        if(n <= 1) return false;
        for(int i = 2; i <= Math.Sqrt(n); i++)
            if(n % i == 0)
                return false;
          return true;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        if(IsPrime(num))
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }
}
