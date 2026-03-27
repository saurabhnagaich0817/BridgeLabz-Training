// ZaraBonus: Generates random employee salary and years of service, calculates bonus and new salary, and prints a summary table.
using System;

class ZaraBonus
{
    static void GenerateEmployeeData(int[,] employees)
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            employees[i, 0] = random.Next(10000, 100000);
            employees[i, 1] = random.Next(1, 11);
        }
    }

    static void CalculateBonusAndSalary(int[,] employees, double[,] results)
    {
        for (int i = 0; i < 10; i++)
        {
            int salary = employees[i, 0];
            int years = employees[i, 1];
            double bonus = years > 5 ? salary * 0.05 : salary * 0.02;
            double newSalary = salary + bonus;
            results[i, 0] = newSalary;
            results[i, 1] = bonus;
        }
    }

    static void PrintTable(int[,] employees, double[,] results)
    {
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\t\tNewSalary");
        // Console.WriteLine("--------------------------------------------------");

        for (int i = 0; i < 10; i++)
        {
            int oldSalary = employees[i, 0];
            int years = employees[i, 1];
            double bonus = results[i, 1];
            double newSalary = results[i, 0];

            totalOldSalary += oldSalary;
            totalBonus += bonus;
            totalNewSalary += newSalary;

            Console.WriteLine($"{i + 1}\t{oldSalary}\t\t{years}\t{bonus:F2}\t\t{newSalary:F2}");
        }

        // Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Total\t{totalOldSalary}\t\t\t{totalBonus:F2}\t\t{totalNewSalary:F2}");
    }

    static void Main()
    {
        int[,] employees = new int[10, 2];
        double[,] results = new double[10, 2];
        GenerateEmployeeData(employees);
        CalculateBonusAndSalary(employees, results);
        PrintTable(employees, results);
    }
}
