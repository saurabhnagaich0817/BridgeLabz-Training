using System;

class PoundsTokg
{static void Main()
    {    
      // taking input from the user 
        Console.Write("Enter weight in pounds: ");
        double pound = double.Parse(Console.ReadLine());
      // converting pounds to kg
        double kg = pound/2.2;

        Console.WriteLine("The weight of the person in pounds is " + pound + " and in kg is " + kg);
    }
}
