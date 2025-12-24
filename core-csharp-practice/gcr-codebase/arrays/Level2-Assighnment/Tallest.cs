using System;

class Tallest
{
    static void Main()
    {
      // Declaring arrays for name, ages, and hgts
        string[] name = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        double[] hgt = new double[3];
// Taking input for age and hgt of each friend
        for(int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {name[i]}: ");
            age[i] = int.Parse(Console.ReadLine());
// Taking hgt input
            Console.Write($"Enter hgt of {name[i]}: ");
            hgt[i] = double.Parse(Console.ReadLine());
        }

        int yngidx = 0, tallidxx = 0;
// Finding youngest and tallest friends
        for(int i = 1; i < 3; i++)
        {
            if(age[i] < age[yngidx])
                yngidx = i;

            if(hgt[i] > hgt[tallidxx])
                tallidxx = i;
        }
// Displaying results
        Console.WriteLine("Youngest Friend: " + name[yngidx]);
        Console.WriteLine("Tallest Friend: " + name[tallidxx]);
    }
}
