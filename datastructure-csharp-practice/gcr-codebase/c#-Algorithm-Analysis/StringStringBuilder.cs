using System;
using System.Diagnostics;
using System.Text;

class Test
{
    static void Main()
    {
        int N = 10000;

        Stopwatch sw = new Stopwatch();

        // Using string
        string s = "";
        sw.Start();
        for (int i = 0; i < N; i++)
            s += "a";
        sw.Stop();
        Console.WriteLine("string time: " + sw.ElapsedMilliseconds + " ms");

        // Using StringBuilder
        StringBuilder sb = new StringBuilder();
        sw.Restart();
        for (int i = 0; i < N; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + " ms");
    }
}
