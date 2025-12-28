using System;

class NumberGuess
{
    static Random rand = new Random();  
    static int getguess(int low, int high)
    {
        return rand.Next(low, high + 1);
    }

    static string GetFeedback()
    {
        Console.Write("Enter feedback (high/low/correct): ");
        return Console.ReadLine().ToLower();
    }

    static void Main()
    {
        int low = 1, high = 100;
        bool guessno = false;

        Console.WriteLine("Think a number between 1 and 100");

        while (!guessno)
        {
            int guess = getguess(low, high);
            Console.WriteLine("Computer guess: " + guess);

            string feedback = GetFeedback();

            if (feedback == "high")
                high = guess - 1;
            else if (feedback == "low")
                low = guess + 1;
            else if (feedback == "correct")
            {
                Console.WriteLine("Computer guessno correctly!");
                guessno = true;
            }
        }
    }
}
