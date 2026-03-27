using System;
class celtofer
{static void Main(string[] args){
        Console.Write("Enter temperature in Celsius:");
        double c= Convert.ToDouble(Console.ReadLine());
        double fah= (c*9/5)+32;
        Console.WriteLine("Temperature in Fahrenheit: " + fah);
    }
}
