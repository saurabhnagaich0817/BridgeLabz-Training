using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== INTERMEDIATE CSV OPERATIONS STARTED =====\n");

        FilterStudents();
        Console.WriteLine();

        SearchEmployeeByName("Neha");
        Console.WriteLine();

        UpdateITDepartmentSalary();
        Console.WriteLine();

        SortEmployeesBySalary();
        Console.WriteLine();

        Console.WriteLine("===== INTERMEDIATE CSV OPERATIONS COMPLETED =====");
    }

    // Filter students with marks > 80
    static void FilterStudents()
    {
        Console.WriteLine(">>> Problem 4: Filter Students (Marks > 80)");

        string filePath = "students.csv";
        var lines = File.ReadAllLines(filePath).Skip(1);

        foreach (var line in lines)
        {
            var data = line.Split(',');
            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine($"{data[1]} | Marks: {marks}");
            }
        }
    }

    //  Search employee by name
    static void SearchEmployeeByName(string name)
    {
        Console.WriteLine(">>> Problem 5: Search Employee by Name");

        string filePath = "employees.csv";
        var lines = File.ReadAllLines(filePath).Skip(1);

        foreach (var line in lines)
        {
            var data = line.Split(',');

            if (data[1].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Name       : {data[1]}");
                Console.WriteLine($"Department : {data[2]}");
                Console.WriteLine($"Salary     : {data[3]}");
                return;
            }
        }

        Console.WriteLine("Employee not found!");
    }

    // Increase IT salary by 10% and save to new file
    static void UpdateITDepartmentSalary()
    {
        Console.WriteLine(">>> Problem 6: Update IT Department Salary");

        string inputFile = "employees.csv";
        string outputFile = "employees_updated.csv";

        var lines = File.ReadAllLines(inputFile);
        using StreamWriter sw = new StreamWriter(outputFile);

        sw.WriteLine(lines[0]); // header

        for (int i = 1; i < lines.Length; i++)
        {
            var data = lines[i].Split(',');
            double salary = double.Parse(data[3]);

            if (data[2] == "IT")
            {
                salary += salary * 0.10;
            }

            sw.WriteLine($"{data[0]},{data[1]},{data[2]},{salary}");
        }

        Console.WriteLine(" IT salaries updated (10%) → employees_updated.csv");
    }

    // Sort employees by salary (DESC) and print top 5
    static void SortEmployeesBySalary()
    {
        Console.WriteLine(">>> Problem 7: Top 5 Highest Paid Employees");

        string filePath = "employees.csv";

        var employees = File.ReadAllLines(filePath)
            .Skip(1)
            .Select(line =>
            {
                var data = line.Split(',');
                return new
                {
                    Name = data[1],
                    Department = data[2],
                    Salary = double.Parse(data[3])
                };
            })
            .OrderByDescending(e => e.Salary)
            .Take(5);

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.Name} | {emp.Department} | {emp.Salary}");
        }
    }
}
