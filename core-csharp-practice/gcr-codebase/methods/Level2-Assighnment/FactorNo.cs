using System;

class FactorNo
{
  // Function to find factors of a number
    static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0) count++;
// storing factors in an array
        int[] factors = new int[count];
        int index = 0;
// finding factors
        for (int i = 1; i <= number; i++)
            if (number % i == 0)
                factors[index++] = i;

        return factors;
    }
    static int Sum(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr) sum += x;
        return sum;
    }
static double SumOfSquares(int[] arr){
        double sum = 0;
        foreach (int x in arr)
            sum += Math.Pow(x, 2);
        return sum;
    }
static long Product(int[] arr)
    {
        long product = 1;
        foreach (int x in arr) product *= x;
        return product;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
// finding factors
        int[] factors = FindFactors(number);
// displaying factors, sum, sum of squares and product
        Console.WriteLine("Factors:");
        foreach (int f in factors) Console.Write(f + " ");
// 
        Console.WriteLine("\nSum: " + Sum(factors));
        Console.WriteLine("Sum of Squares: " + SumOfSquares(factors));
        Console.WriteLine("Product: " + Product(factors));
    }
}
