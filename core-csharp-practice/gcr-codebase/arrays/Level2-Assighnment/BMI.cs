using System;

class BMI
{
    static void Main()
    {
      // Enter number of persons
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());
//  Declaring arrays to store wt, ht, BMI and stts
        double[] wt = new double[n];
        double[] ht = new double[n];
        double[] bmi = new double[n];
        string[] stts = new string[n];

        for(int i = 0; i < n; i++)
        {
            Console.Write("wt(kg): ");
            wt[i] = double.Parse(Console.ReadLine());
//   Taking ht input
            Console.Write("ht(m): ");
            ht[i] = double.Parse(Console.ReadLine());
// Calculating BMI and determining status
            bmi[i] = wt[i] /(ht[i] * ht[i]);
// Determining status based on BMI
            if(bmi[i] < 18.5) stts[i] = "Underwt";
            else if(bmi[i] < 25) stts[i] = "Normal";
            else if(bmi[i] < 30) stts[i] = "Overwt";
            else stts[i] = "Obese";
        }
// Displaying BMI and status for each person
        for(int i = 0; i < n; i++)
            Console.WriteLine($"BMI={bmi[i]:F2}, stts={stts[i]}");
    }
}
