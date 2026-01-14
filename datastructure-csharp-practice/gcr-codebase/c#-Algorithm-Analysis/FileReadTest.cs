using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadTest
{
    static void Main()
    {
        string path = "largefile.txt"; 

        Stopwatch sw = new Stopwatch();

        // -------- StreamReader --------
        sw.Start();
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.ReadLine() != null) { }
        }
        sw.Stop();
        Console.WriteLine("StreamReader Time: " + sw.ElapsedMilliseconds + " ms");

        // -------- FileStream --------
        sw.Restart();
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        sw.Stop();
        Console.WriteLine("FileStream Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
