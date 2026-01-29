using System.IO;
using System.Linq;
using System;

class CsvMerger
{
    public static void MergeStudents()
    {
        Console.WriteLine(">>> Merging students1.csv & students2.csv");

        var s1 = File.ReadAllLines("students1.csv")
            .Skip(1).Select(l => l.Split(','))
            .ToDictionary(d => d[0]);

        var s2 = File.ReadAllLines("students2.csv")
            .Skip(1).Select(l => l.Split(','))
            .ToDictionary(d => d[0]);

        using StreamWriter sw = new("merged_students.csv");
        sw.WriteLine("ID,Name,Age,Marks,Grade");

        foreach (var id in s1.Keys)
        {
            var a = s1[id];
            var b = s2[id];
            sw.WriteLine($"{id},{a[1]},{a[2]},{b[1]},{b[2]}");
        }
    }
}
