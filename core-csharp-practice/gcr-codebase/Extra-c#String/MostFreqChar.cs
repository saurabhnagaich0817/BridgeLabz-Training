using System;

class MostFrequentChar
{
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string s = Console.ReadLine();
        int max = 0;
        char result = s[0];
        // Find the most frequent character in the string
        for(int i = 0; i < s.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < s.Length; j++)
                if(s[i] == s[j]) count++;
            // Update max and result if current character's count is greater
            if(count > max)
            {
                max = count;
                result = s[i];
            }
        }

        Console.WriteLine("Most Frequent Character: " + result);
    }
}
