using System;

class SentenceFormatterrr
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n===== STRING MENU =====");
            Console.WriteLine("1. Sentence Formatter(Problem 1)");
            Console.WriteLine("2. Text Analysis(Problem 2)");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    SentenceFormatter();
                    break;

                case 2:
                    TextAnalysis();
                    break;

                case 3:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while(choice != 3);
    }

    // ================= PROBLEM 1 =================
    static void SentenceFormatter()
    {
        Console.WriteLine("\nEnter sentence:");
        string sentence = Console.ReadLine();
        if(sentence == null) sentence = "";

        char[] res = new char[sentence.Length + 10];
        int indx = 0;
        bool Capital = true;

        for(int i = 0; i < sentence.Length; i++)
        {
            char c = sentence[i];

            // letter
            if((c >= 'a' && c <= 'z') ||(c >= 'A' && c <= 'Z'))
            {
                if(Capital && c >= 'a' && c <= 'z')
                {
                    c =(char)(c - 32);
                }
                Capital = false;
                res[indx++] = c;
            }
            // space
            else if(c == ' ')
            {
                if(indx > 0 && res[indx - 1] != ' ')
                {
                    res[indx++] = ' ';
                }
            }
            // punctuation
            else if(c == '.' || c == '?' || c == '!')
            {
                res[indx++] = c;

                if(indx > 0 && res[indx - 1] != ' ')
                {
                    res[indx++] = ' ';
                }
                Capital = true;
            }
        }

        Console.Write("Formatted Output: ");
        for(int i = 0; i < indx; i++)
        {
            Console.Write(res[i]);
        }
        Console.WriteLine();
    }

    // ================= PROBLEM 2 =================
    static void TextAnalysis()
    {
        Console.WriteLine("\nEnter paragraph:");
        string text = Console.ReadLine();
// check for empty input
        if(IsEmpty(text))
        {
            Console.WriteLine("No text provided.");
            return;
        }
// check for word count
        Console.WriteLine("Word Count: " + CountWords(text));
        FindLongestWord(text);

        Console.Write("\nEnter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        ReplaceWord(text, oldWord, newWord);
    }
// check for empty string
    static bool IsEmpty(string text)
    {
        if(text == null) return true;

        for(int i = 0; i < text.Length; i++)
        {
            if(text[i] != ' ')
                return false;
        }
        return true;
    }
    static int CountWords(string text)
    {
        int count = 0;
        bool inWord = false;

        for(int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if((c >= 'a' && c <= 'z') ||(c >= 'A' && c <= 'Z'))
            {
                if(!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }
        return count;
    }
static void FindLongestWord(string text)
    {
        int maxLen = 0, currLen = 0, endIndex = 0;
// traverse the text
        for(int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if((c >= 'a' && c <= 'z') ||(c >= 'A' && c <= 'Z'))
            {
                currLen++;
                if(currLen > maxLen)
                {
                    maxLen = currLen;
                    endIndex = i;
                }
            }
            else
            {
                currLen = 0;
            }
        }
// print longest word
        Console.Write("Longest Word: ");
        for(int i = endIndex - maxLen + 1; i <= endIndex; i++)
        {
            Console.Write(text[i]);
        }
        Console.WriteLine();
    }

    static void ReplaceWord(string text, string oldWord, string newWord)
    {
        char[] result = new char[500];
        int idx = 0;
// traverse the text
        for(int i = 0; i < text.Length;)
        {
            bool match = true;

            for(int j = 0; j < oldWord.Length; j++)
            {
                if(i + j >= text.Length)
                {
                    match = false;
                    break;
                }
// compare characters
                char t = text[i + j];
                char o = oldWord[j];

                if(t >= 'A' && t <= 'Z') t =(char)(t + 32);
                if(o >= 'A' && o <= 'Z') o =(char)(o + 32);

                if(t != o)
                {
                    match = false;
                    break;
                }
            }
// check for match
            if(match)
            {
                for(int k = 0; k < newWord.Length; k++)
                {
                    result[idx++] = newWord[k];
                }
                i += oldWord.Length;
            }
            else
            {
                result[idx++] = text[i];
                i++;
            }
        }
// print replaced text
        Console.Write("After Replacement: ");
        for(int i = 0; i < idx; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
