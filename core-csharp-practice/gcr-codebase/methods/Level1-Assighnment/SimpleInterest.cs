using System;
class SimpleInterest
{
    static void Main()
    {

        Console.WriteLine("Enter principal:");
        double principal = Convert.ToDouble(Console.ReadLine());
        // Find the simple interest
        Console.WriteLine("Enter Rate :");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter time:");
        double time =Convert.ToDouble(Console.ReadLine());

        double si = findsi(principal, rate, time);

    Console.WriteLine($"The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");


    }
    static double findsi(double principal, double rate, double time)
    {
        return (principal * rate *time)/100;
    }
}