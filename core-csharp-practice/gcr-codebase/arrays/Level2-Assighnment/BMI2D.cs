using System;

class BMI2D
{
    static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());

        double[][] d = new double[n][];
        string[] stts = new string[n];
            for(int i = 0; i < n; i++)
        {
            d[i] = new double[3];

            Console.Write("Weight: ");
            d[i][0] = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            d[i][1] = double.Parse(Console.ReadLine());

  d[i][2] = d[i][0] /(d[i][1] * d[i][1]);
           if(d[i][2] < 18.5) stts[i] = "Underweight";
            else if(d[i][2] < 25) stts[i] = "Normal";
            else if(d[i][2] < 30) stts[i] = "Overweight";
            else stts[i] = "Obese";
        }

        for(int i = 0; i < n; i++)
            Console.WriteLine($"BMI={d[i][2]:F2}, status={stts[i]}");
    }
}
