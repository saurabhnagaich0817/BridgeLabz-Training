using System;

class Mulsixtonine
{
    static void Main()
    {
      // reading input from user
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
//      printing multiplication table from 6 to 9
        for(int i = 6; i <= 9; i++)
        {   
          // taking String interpolation for printing multiplication table  
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
