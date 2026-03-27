using System;

class SI
{
    static void Main()
    {

        //  input from user
        Console.Write("Enter p: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Enter rat: ");
        double rat = double.Parse(Console.ReadLine());

        Console.Write("Enter t: ");
        double t = double.Parse(Console.ReadLine());

        double si = (p *rat*t) / 100;
//    displaying interest   
        Console.WriteLine("The Simple Interest is " + si + " for p " + p + ", rat of Interest " + rat +" and t " + t);
    }
}
