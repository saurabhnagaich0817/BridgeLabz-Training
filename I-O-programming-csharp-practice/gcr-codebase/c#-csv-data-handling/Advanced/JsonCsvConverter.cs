using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System;

class JsonCsvConverter
{
    public static void JsonToCsv()
    {
        Console.WriteLine(">>> JSON to CSV");

        var json = File.ReadAllText("students.json");
        var students = JsonSerializer.Deserialize<List<Student>>(json);

        using StreamWriter sw = new("students_from_json.csv");
        sw.WriteLine("Id,Name,Age");

        foreach (var s in students)
            sw.WriteLine($"{s.Id},{s.Name},{s.Age}");
    }

    public static void CsvToJson()
    {
        Console.WriteLine(">>> CSV to JSON");

        var lines = File.ReadAllLines("students_from_json.csv").Skip(1);
        var list = new List<Student>();

        foreach (var l in lines)
        {
            var d = l.Split(',');
            list.Add(new Student
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2])
            });
        }

        File.WriteAllText("students_back.json",
            JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true }));
    }
}
