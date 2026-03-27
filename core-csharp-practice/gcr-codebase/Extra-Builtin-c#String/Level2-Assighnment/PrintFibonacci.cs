using System;

class Fibonacci
{
    static void fibo(int n)
    {
        int a = 0, b = 1;

        for(int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
    }

    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = int.Parse(Console.ReadLine());

        fibo(n);
    }
}
