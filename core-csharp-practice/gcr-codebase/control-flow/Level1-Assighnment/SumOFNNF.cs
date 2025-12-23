using System;

class SumOFNNF
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
         if(n > 0)
        {  
          // checking number is natural number

            int sf = 0;

            for(int i = 1; i <= n; i++)
                sf += i;

            int sfmula = n *(n + 1) / 2;

            Console.WriteLine("Sum using for loop: " + sf);
            Console.WriteLine("Sum using formula: " + sfmula);
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
