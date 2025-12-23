using System;

class MulTable
{
    static void Main()
    {
      // Taking input from user
        Console.Write("Enter no: ");
        int no = int.Parse(Console.ReadLine());
// Creating an array to store multiplication ress
        int[] res = new int[4];
// Calculating multiplication from 6 to 9
        int idxx = 0;
        for (int i = 6; i <= 9; i++)
        {
            res[idxx] = no * i;
            Console.WriteLine(no + " * " + i + " = " + res[idxx]);
            idxx++;
        }
    }
}
