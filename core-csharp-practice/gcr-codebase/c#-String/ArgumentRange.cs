using System;

class ArgumentRange
{
    static void Main()
    {
        string text = "hello guys welcome to gcr";

        try
        {
            Console.WriteLine(text.Substring(8, 15));
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception Caught: " + e.Message);
        }
    }
}
