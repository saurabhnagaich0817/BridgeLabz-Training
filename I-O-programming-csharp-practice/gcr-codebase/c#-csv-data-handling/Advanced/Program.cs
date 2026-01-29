using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ADVANCED CSV PROJECT START =====\n");

        CsvValidator.ValidateUsers();
        Console.WriteLine();

        CsvMerger.MergeStudents();
        Console.WriteLine();

        LargeFileReader.ReadBigFile();
        Console.WriteLine();

        JsonCsvConverter.JsonToCsv();
        Console.WriteLine();

        JsonCsvConverter.CsvToJson();
        Console.WriteLine();

        DuplicateChecker.FindDuplicates();
        Console.WriteLine();

        Console.WriteLine("===== PROJECT COMPLETED =====");
    }
}
