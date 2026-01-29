using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== CSV FILE HANDLING PROGRAM STARTED =====\n");

        CreateEmployeeCSV();
        Console.WriteLine();

        ReadStudentCSV();
        Console.WriteLine();

        CountStudentRecords();
        Console.WriteLine();

        Console.WriteLine("===== PROGRAM EXECUTION COMPLETED =====");
    }

    // PROBLEM 2: Write Data to CSV
    static void CreateEmployeeCSV()
    {
        Console.WriteLine(">>> Executing Problem 2: Write Data to CSV");

        string filePath = "employees.csv";

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            sw.WriteLine("ID,Name,Department,Salary");
            sw.WriteLine("1,Ramesh,HR,35000");
            sw.WriteLine("2,Suresh,IT,55000");
            sw.WriteLine("3,Pooja,Finance,48000");
            sw.WriteLine("4,Amit,Marketing,42000");
            sw.WriteLine("5,Neha,IT,60000");
        }

        Console.WriteLine(" employees.csv created successfully");
    }

    // PROBLEM 1: Read CSV and Print Data
    static void ReadStudentCSV()
    {
        Console.WriteLine(">>> Executing Problem 1: Read CSV & Print Data");

        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("students.csv not found!");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine("\n--- Student Details ---");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            Console.WriteLine($"ID    : {data[0]}");
            Console.WriteLine($"Name  : {data[1]}");
            Console.WriteLine($"Age   : {data[2]}");
            Console.WriteLine($"Marks : {data[3]}");
            Console.WriteLine("-----------------------");
        }
    }

    // PROBLEM 3: Count Records
    static void CountStudentRecords()
    {
        Console.WriteLine(">>> Executing Problem 3: Count CSV Records");

        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine(" students.csv not found!");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        int count = lines.Length - 1;

        Console.WriteLine($" Total student records (excluding header): {count}");
    }
}
