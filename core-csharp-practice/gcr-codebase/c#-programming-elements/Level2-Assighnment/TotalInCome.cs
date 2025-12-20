using System;

class TotalIncome
{
    static void Main()

    {
        // taking input from user
        Console.Write("Enter Salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter Bonus: ");
        double bonus = double.Parse(Console.ReadLine());
        // calculating total income
        double income = salary + bonus;
        // displaying total income
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + income);
    }
}
