using System;

class SumOfNNW
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
//      // checking number is natural number
        if(n > 0)
        {
            int sumWhile = 0;
            int i=1;
            while(i <= n){
                sumWhile += i;
                i++;
            }
        int sf = n *(n + 1) / 2;
//    // printing results
            Console.WriteLine("Sum using while loop: " + sumWhile);
            Console.WriteLine("Sum using formula: " + sf);
        }
        else
        {
            Console.WriteLine("Not a natural number");
        }
    }
}
