using System;

public class CrackerMenu
{
    private CrackerUtilityImpl crackerService;

    public CrackerMenu(CrackerUtilityImpl crackerService)
    {
        this.crackerService = crackerService;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n1. Crack user given password");
            Console.WriteLine("2. Generate random password and crack");
            Console.WriteLine("3. Exit");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.Write("Enter password (use a,b,c,1,2 only): ");
                    string inputPassword = Console.ReadLine();
                    crackerService.CrackUserPassword(inputPassword);
                    break;

                case 2:
                    Console.Write("Enter password length: ");
                    int passwordLength = int.Parse(Console.ReadLine());
                    crackerService.CrackRandomPassword(passwordLength);
                    break;

                case 3:
                    return;
            }
        }
    }
}
