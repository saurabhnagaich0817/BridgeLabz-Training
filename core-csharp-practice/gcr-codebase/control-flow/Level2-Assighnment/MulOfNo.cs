using System;

class MultOfNo
{
    static void Main()
    {
        Console.Write("Enter  no: ");
        int  no = int.Parse(Console.ReadLine());
// Finding multiples of the  no from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            if (i % no == 0)
                Console.WriteLine(i);
        }
    }
}
