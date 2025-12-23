using System;
class HeightFP
{
    static void Main()
    {
      // Taking height input of 11 players
        double[] hgt = new double[11];
        double ans = 0;
// Calculating ans of hgt
        for (int i = 0; i < hgt.Length; i++)
        {
            Console.Write("Enter height of player " + (i + 1) + ": ");
            hgt[i] = double.Parse(Console.ReadLine());
            ans += hgt[i];
        }

        double mn = ans / 11;
        Console.WriteLine("mean height of football team = " + mn);
    }
}
