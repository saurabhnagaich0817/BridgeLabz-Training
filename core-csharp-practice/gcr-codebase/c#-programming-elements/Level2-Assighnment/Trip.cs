using System;

class Trip
{static void Main(){
    // taking input from user
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("From City: ");
        string fromcty = Console.ReadLine();

        Console.Write("Via City: ");
        string viacty = Console.ReadLine();

        Console.Write("To City: ");
        string tocty = Console.ReadLine();

        Console.Write("Distance From-To-Via (miles): ");
        double via = double.Parse(Console.ReadLine());

        Console.Write("Distance Via-To-Final (miles): ");
        double viafinal = double.Parse(Console.ReadLine());

        Console.Write("Time Taken (hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = via + viafinal;
        double speed = totalDistance / timeTaken;

        Console.WriteLine("The results of the trip are: " +totalDistance + " miles, " + timeTaken + " hours, " +speed + " miles/hour");
    }
}
