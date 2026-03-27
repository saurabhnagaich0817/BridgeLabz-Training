using System;

class NumberChecker5
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.WriteLine("\nFactors of the number:");
        foreach(int f in factors)
        {
            Console.Write(f + " ");
        }

        Console.WriteLine("\n\nGreatest Factor: " + FindGreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + FindSumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + FindProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + FindProductOfCubeOfFactors(factors));
        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number, factors));
    }

    // a. Find factors and return as array(2 for-loops)
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop – count factors
        for(int i = 1; i <= number; i++)
        {
            if(number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // Second loop – store factors
        for(int i = 1; i <= number; i++)
        {
            if(number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    // b. Greatest factor
    public static int FindGreatestFactor(int[] factors)
    {
        int max = factors[0];
        foreach(int f in factors)
        {
            if(f > max)
                max = f;
        }
        return max;
    }

    // c. Sum of factors
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach(int f in factors)
        {
            sum += f;
        }
        return sum;
    }

    // d. Product of factors
    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach(int f in factors)
        {
            product *= f;
        }
        return product;
    }

    // e. Product of cube of factors
    public static double FindProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach(int f in factors)
        {
            product *= Math.Pow(f, 3);
        }
        return product;
    }

    // f. Perfect number check
    public static bool IsPerfectNumber(int number, int[] factors)
    {
        int sum = 0;
        foreach(int f in factors)
        {
            if(f != number) // proper divisors
                sum += f;
        }
        return sum == number;
    }
}
