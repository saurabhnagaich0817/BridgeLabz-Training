using System;

class ToggleCase
{
    static void Main()
    {
      // 
        Console.WriteLine("Enter string:");
        string s = Console.ReadLine();
        string result = "";

        foreach(char c in s)
        {
            if(c >= 'a' && c <= 'z')
                result +=(char)(c - 32);
            else if(c >= 'A' && c <= 'Z')
                result +=(char)(c + 32);
            else
                result += c;
        }

        Console.WriteLine("Toggled: " + result);
    }
}
