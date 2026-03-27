using System;
class DoubleOperation
{
    static void Main(){
        // taking input from user
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double res1 = a + b * c;
        double res2 = a * b + c;
        double res3 = c + a / b;
        double res4 = a % b + c;

        Console.WriteLine("The results of Double Operations are " +res1 + ", " + res2 + ", " +res3 + ", " + res4);
    }
}
