using System;

class EventApplication
{
    static void Main(string[] args)
    {
        PrizeChecker prizeChecker = new PrizeChecker();

        Console.WriteLine(" Welcome to Festival Lucky Draw 🎉");
        Console.WriteLine("Choose Role:");
        Console.WriteLine("1. Organizer");
        Console.WriteLine("2. Visitor");

        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                ShowOrganizerRules();
                break;

            case 2:
                StartVisitorSession(prizeChecker);
                break;

            default:
                Console.WriteLine("Invalid option selected");
                break;
        }
    }

    static void ShowOrganizerRules()
    {
        Console.WriteLine("\nOrganizer Instructions:");
        Console.WriteLine("- Number divisible by 3 AND 5 wins");
        Console.WriteLine("- Visitor can exit anytime by typing 'exit'");
    }

    static void StartVisitorSession(PrizeChecker prizeChecker)
    {
        while (true)
        {
            Console.Write("\nEnter your lucky number (or type exit): ");

            int enteredNumber;
            bool isValid = UserInputReader.ReadNumber(out enteredNumber);

            if (!isValid && enteredNumber == -1)
            {
                Console.WriteLine("Thanks for visiting the festival!");
                break;
            }

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            if (prizeChecker.CheckWinner(enteredNumber))
            {
                Console.WriteLine(" Congratulations! You won a prize!");
            }
            else
            {
                Console.WriteLine(" Not a winning number. Try again!");
            }
        }
    }
}
