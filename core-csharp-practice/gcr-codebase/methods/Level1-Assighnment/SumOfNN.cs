using System;
class SumOfNN
{
  static int Sum(int n){
        int sum = 0;
        for(int i = 1; i <= n; i++)
            sum += i;

        return sum;
    }

    static void Main()
    {
      // taking n as input from user
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum is: " + Sum(n));
    }
}
