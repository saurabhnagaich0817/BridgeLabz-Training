using System;

class Calculator
{
    static double Add(double a, double b) => a + b;
    static double Sub(double a, double b) => a - b;
    static double Mul(double a, double b) => a * b;
    static double Div(double a, double b) => a / b;

    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
//    taking second number as input from user
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("1.Add  2.Sub  3.Mul  4.Div");
        Console.Write("Choose operation: ");
        int ch = int.Parse(Console.ReadLine());
        if(ch == 1) Console.WriteLine(Add(a, b));
        else if(ch == 2) Console.WriteLine(Sub(a, b));
        else if(ch == 3) Console.WriteLine(Mul(a, b));
        else if(ch == 4) Console.WriteLine(Div(a, b));
    }
}
