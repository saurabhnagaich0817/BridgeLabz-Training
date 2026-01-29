using System.IO;
using System;

class LargeFileReader
{
    public static void ReadBigFile()
    {
        Console.WriteLine(">>> Reading bigdata.csv (100 lines batch)");

        int count = 0;

        using StreamReader sr = new("bigdata.csv");
        while (sr.ReadLine() != null)
        {
            count++;
            if (count % 100 == 0)
                Console.WriteLine($"Processed {count} lines");
        }
    }
}
