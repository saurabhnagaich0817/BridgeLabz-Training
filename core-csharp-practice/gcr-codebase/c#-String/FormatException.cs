using System;
class FormatExceptionDemo
{static void Main()
    {
        try{
            int num = int.Parse("ABC");
        }
        catch(FormatException s)
        {
            Console.WriteLine("Exception Caught: " + s.Message);
        }
    }
}
