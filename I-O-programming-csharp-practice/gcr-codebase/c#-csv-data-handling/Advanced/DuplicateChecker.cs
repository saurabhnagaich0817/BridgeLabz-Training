using System.IO;
using System.Collections.Generic;
using System;

class DuplicateChecker
{
    public static void FindDuplicates()
    {
        Console.WriteLine(">>> Checking duplicates in students1.csv");

        HashSet<string> ids = new HashSet<string>();
        var lines = File.ReadAllLines("students1.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            var id = lines[i].Split(',')[0];

            if (!ids.Add(id))
                Console.WriteLine("Duplicate: " + lines[i]);
        }
    }
}
