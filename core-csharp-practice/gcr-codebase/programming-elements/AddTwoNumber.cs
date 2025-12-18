using System;
class AddTwoNumber
{
  static void Main(string [] args){
        Console.Write("Enter 1st number: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        int t  = int.Parse(Console.ReadLine());
        int sum = s+t;
        Console.WriteLine("Sum = " + sum);
    }
}
