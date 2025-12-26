using System;

class WordSplitLength
{
    static int GetLength(string word)
    {
        int count = 0;
        foreach(char c in word)
            count++;
        return count;
    }

    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        string word = "";
        string[,] res = new string[20, 2];
        int index = 0;

        for(int i = 0; i <= text.Length; i++)
        {
            if(i == text.Length || text[i] == ' ')
            {
                if(word != "")
                {
                    res[index, 0] = word;
                    res[index, 1] = GetLength(word).ToString();
                    index++;
                    word = "";
                }
            }
            else
            {
                word += text[i];
            }
        }

        Console.WriteLine("Word\tLength");
        for(int i = 0; i < index; i++)
        {
            Console.WriteLine(res[i, 0] + "\t" + res[i, 1]);
        }
    }
}
