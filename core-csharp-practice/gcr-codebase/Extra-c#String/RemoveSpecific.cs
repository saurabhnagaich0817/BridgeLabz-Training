using System;

class RemoveSpecific
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string s = Console.ReadLine();

        Console.WriteLine("Enter character to remove:");
        char ch = Console.ReadLine()[0];

        string result = "";
// Remove all occurrences of the specified character
        foreach(char c in s)
            if(c != ch)
                result += c;

        Console.WriteLine("Modified String: " + result);
    }
}
