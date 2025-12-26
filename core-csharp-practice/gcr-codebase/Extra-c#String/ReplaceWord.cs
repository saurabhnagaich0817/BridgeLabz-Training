using System;

class ReplaceWord
{
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string s = Console.ReadLine();
// Replace all occurrences of a specified word with a new word
        Console.WriteLine("Word to replace:");
        string oldWord = Console.ReadLine();
        // Replace all occurrences of the old word with the new word
        Console.WriteLine("New word:");
        string newWord = Console.ReadLine();
// Perform the replacement
        string result = s.Replace(oldWord, newWord);
        Console.WriteLine("Result: " + result);
    }
}
