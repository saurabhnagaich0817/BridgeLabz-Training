using System;
class SubstringCount
{
    static void Main()
    {
      // Count occurrences of a substring in a string
        Console.WriteLine("Enter string:");
        string s = Console.ReadLine();

        Console.WriteLine("Enter substring:");
        string sub = Console.ReadLine();

        int count = 0;

        for(int i = 0; i <= s.Length - sub.Length; i++)
        {
            if(s.Substring(i, sub.Length) == sub)
                count++;
        }

        Console.WriteLine("Occurrences: " + count);
    }
}
 