using System;
class CelToFrh{
    static void Main(){
      // taking input from user
        Console.Write("Enter temperature in cel: ");
        double cel = double.Parse(Console.ReadLine());
      // calculating fahrenheit
        double fahrenheit = (cel * 9 / 5) + 32;
      // printing fahrenheit
        Console.WriteLine("The " + cel + " cel is " +fahrenheit + " Fahrenheit");
    }
}
