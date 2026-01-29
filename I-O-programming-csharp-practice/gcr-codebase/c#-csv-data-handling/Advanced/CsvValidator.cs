using System.IO;
using System.Text.RegularExpressions;
using System;

class CsvValidator
{
    public static void ValidateUsers()
    {
        Console.WriteLine(">>> Validating users.csv");

        var lines = File.ReadAllLines("users.csv");

        Regex emailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phoneRegex = new(@"^\d{10}$");

        for (int i = 1; i < lines.Length; i++)
        {
            var d = lines[i].Split(',');

            if (!emailRegex.IsMatch(d[2]) || !phoneRegex.IsMatch(d[3]))
            {
                Console.WriteLine("Invalid Row: " + lines[i]);
            }
        }
    }
}
