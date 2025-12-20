using System;
class AthleteRound
{
    static void Main()
    {    // taking input from user
      Console.Write("Enter side1: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter side2: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter side3: ");
        double side3 = double.Parse(Console.ReadLine());
        // calculating perimeter and rounds
        double perimeter = side1 + side2 + side3;
        // 5 km = 5000 meters
        double distance = 5000; 
       double rounds = distance / perimeter;
              Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
    }
}
