using System;

class Anagram
{
    static void Main()
    {
        Console.WriteLine("Enter first string:");
        string s1 = Console.ReadLine().ToLower();

        Console.WriteLine("Enter second string:");
        string s2 = Console.ReadLine().ToLower();

        if(s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }
// Count frequency of each character
        int[] count = new int[26];
//      for each character in s1, increment its count
        foreach(char c in s1) count[c - 'a']++;
        foreach(char c in s2) count[c - 'a']--;

        foreach(int c in count)
        {
            if(c != 0)
            {
                Console.WriteLine("Not Anagrams");
                return;
            }
        }
// If all counts are zero, they are anagrams
        Console.WriteLine("Anagrams");
    }
}
