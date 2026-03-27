using System;

class LexoGraphical
{
    static void Main()
    {
        Console.WriteLine("Enter string 1:");
        string s1 = Console.ReadLine();
        // This program compares two strings lexicographically.
        Console.WriteLine("Enter string 2:");
        string s2 = Console.ReadLine();

        int min = s1.Length < s2.Length ? s1.Length : s2.Length;

        for(int i = 0; i < min; i++)
        {
            if(s1[i] < s2[i])
            {
                Console.WriteLine(s1 + " comes before " + s2);
                return;
            }
            else if(s1[i] > s2[i])
            {
                Console.WriteLine(s2 + " comes before " + s1);
                return;
            }
        }
        // If all characters are the same in the prefix, the shorter string comes first.
        if(s1.Length < s2.Length)
            Console.WriteLine(s1 + " comes before " + s2);
        else
            Console.WriteLine(s2 + " comes before " + s1);
    }
}
