using System;

class ChocolateDistribution
{
static void Main(){
        // taking input from user
        Console.Write("Enter number of choc: ");
        // number of choc
        int choc = int.Parse(Console.ReadLine());

        Console.Write("Enter number of child: ");
        int child = int.Parse(Console.ReadLine());
        // calculating choclate each child gets and rem choc

        int eachgets = choc / child;
        int rem = choc % child;

        Console.WriteLine("The number of choc each child gets is " +eachgets + " and the number of rem choc is " +rem);
    }
}
