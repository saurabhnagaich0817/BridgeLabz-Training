using System;

class OddEven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        if(n>0)
        {
            for(int i = 1;i <= n;i++)
            {
                if(i % 2 == 0)
                    Console.WriteLine(i + " is Even");
                else
                    Console.WriteLine(i + " is Odd");
            }
        }
    }
}
