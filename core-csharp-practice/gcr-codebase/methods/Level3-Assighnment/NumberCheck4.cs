using System;

class NumberChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Is Prime Number: " + IsPrime(number));
        Console.WriteLine("Is Neon Number: " + IsNeon(number));
        Console.WriteLine("Is Spy Number: " + IsSpy(number));
        Console.WriteLine("Is Automorphic Number: " + IsAutomorphic(number));
        Console.WriteLine("Is Buzz Number: " + IsBuzz(number));
    }

    // a. Prime number check
    public static bool IsPrime(int number)
    {
        if(number <= 1)
            return false;

        for(int i = 2; i <= Math.Sqrt(number); i++)
        {
            if(number % i == 0)
                return false;
        }
        return true;
    }

    // b. Neon number check
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sum = 0;

        while(square > 0)
        {
            sum += square % 10;
            square /= 10;
        }

        return sum == number;
    }

    // c. Spy number check
    public static bool IsSpy(int number)
    {
        int sum = 0;
        int product = 1;
        int temp = number;

        while(temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }

        return sum == product;
    }

    // d. Automorphic number check
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        return square.ToString().EndsWith(number.ToString());
    }

    // e. Buzz number check
    public static bool IsBuzz(int number)
    {
        return(number % 7 == 0 || number % 10 == 7);
    }
}
