using System;

class UserInputReader
{
    public static bool ReadNumber(out int value)
    {
        string input = Console.ReadLine();

        if (input.ToLower() == "exit")
        {
            value = -1;
            return false;
        }

        return int.TryParse(input, out value);
    }
}
