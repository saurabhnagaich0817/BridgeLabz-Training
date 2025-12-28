using System;

class CheckPalindrome
{
    static bool IsPalindrome(string s)
    {
        string rev = "";
        for(int i = s.Length - 1; i >= 0; i--)
            rev += s[i];

        return s.Equals(rev, StringComparison.OrdinalIgnoreCase);
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        if(IsPalindrome(s))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
