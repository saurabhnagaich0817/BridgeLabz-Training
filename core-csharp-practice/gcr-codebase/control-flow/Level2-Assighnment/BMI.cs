using System;

class BMI
{
    static void Main()
    {
      // reading wt and height input from user
        Console.Write("Enter wt (kg): ");
        double wt = double.Parse(Console.ReadLine());
//     reading height input from user
        Console.Write("Enter height (cm): ");
        double htcm = double.Parse(Console.ReadLine());
// Calculating BMI
        double htm = htcm / 100;
        double bmi = wt/(htm * htm);
// Displaying BMI and category
        Console.WriteLine("BMI = " + bmi);
// Checking BMI category
        if (bmi < 18.5)
            Console.WriteLine("Underwt");
        else if (bmi < 25)
            Console.WriteLine("Normal wt");
        else if (bmi < 30)
            Console.WriteLine("Overwt");
        else
            Console.WriteLine("Obese");
    }
}
