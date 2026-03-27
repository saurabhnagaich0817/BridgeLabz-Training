using System;

class PowTen
{
    static void Main()
    {
      // Read  no and  pow input from user
        Console.Write("Enter  no: ");
        int  no = int.Parse(Console.ReadLine());
        Console.Write("Enter  pow: ");
        int  pow = int.Parse(Console.ReadLine());
        int  res = 1;
        for (int i = 1; i <=  pow; i++)
        {
             res =res* no;
        }

        Console.WriteLine(" res = " +res);
    }
}
