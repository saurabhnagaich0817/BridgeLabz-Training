using System;

public class AtmConsole
{
    private IATMOperations service = new ATMServiceImpl();

    public void DisplayMenu()
    {
        service.SetupCurrency();

        int option;
        do
        {
            Console.WriteLine("\n--- ATM OPTIONS ---");
            Console.WriteLine("1. Withdraw ₹880");
            Console.WriteLine("2. Disable ₹500 Notes");
            Console.WriteLine("3. Exit");
            Console.Write("Select option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    service.WithdrawCash(880);
                    break;
                case 2:
                    service.DisableFiveHundred();
                    break;
                case 3:
                    Console.WriteLine("Thank you for using ATM");
                    break;
                default:
                    Console.WriteLine("Wrong option selected");
                    break;
            }

        } while (option != 3);
    }
}
