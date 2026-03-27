using System;

class EmployeeBonus
{
    static void Main()
    {
      // reading input from user
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());
//      reading input from user
        Console.Write("Enter years of service: ");
        int years = int.Parse(Console.ReadLine());
//     checking if years of service is greater than 5
        if(years > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine("Bonus amount is " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus");
        }
    }
}
