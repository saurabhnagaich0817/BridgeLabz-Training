using System;

class FactorOFNO
{
    static void Main()
    {
      // Read  num input from user
        Console.Write("Enter  num: ");
        int  num = int.Parse(Console.ReadLine());
// Finding factors of the  num
        Console.WriteLine("Factors are:");
// Looping from 1 to  num-1 to find factors
        for (int i = 1; i <  num; i++)
        {
            if ( num % i == 0)
                Console.WriteLine(i);
        }
    }
}
