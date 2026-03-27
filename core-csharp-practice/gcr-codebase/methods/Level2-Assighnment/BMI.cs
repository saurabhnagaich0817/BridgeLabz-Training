using System;

class BMIProgram
{
    static double BMI(double weight, double heightCm)
    {
        double heightM = heightCm / 100;
        return weight / (heightM * heightM);
    }

    static string status(double bmi)
    {
        if (bmi <= 18.4) return "Underweight";
        if (bmi <= 24.9) return "Normal";
        if (bmi <= 39.9) return "Overweight";
        return "Obese";
    }

    static void Main()
    {
        double[,] data = new double[10, 3];
// taking weight and height input
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight (kg): ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm): ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());

            data[i, 2] = BMI(data[i, 0], data[i, 1]);
        }
// displaying BMI and status
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"BMI: {data[i, 2]} Status: {status(data[i, 2])}");
        }
    }
}
