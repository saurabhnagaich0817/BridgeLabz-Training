using System;
using BankSystem;

class BankManager
{
    static Bank bank = new Bank();
    static User currentUser;

    static void Main()
    {
        User admin = new User(1, "SystemAdmin", "Admin");
        User customer = new User(2, "Rahul", "Customer");

        Console.WriteLine("1. Admin Login");
        Console.WriteLine("2. Customer Login");
        int choice = Convert.ToInt32(Console.ReadLine());

        if(choice == 1)
        {
            currentUser = admin;
            AdminMenu();
        }
        else
        {
            currentUser = customer;
            CustomerMenu();
        }
    }

    static void AdminMenu()
    {
        int ch;
        do
        {
            Console.WriteLine("\n--- ADMIN MENU ---");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. View Account");
            Console.WriteLine("3. Exit");

            ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    Console.Write("Account No: ");
                    string acc = Console.ReadLine();
                    Console.Write("Balance: ");
                    double bal = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Min Balance: ");
                    double min = Convert.ToDouble(Console.ReadLine());

                    bank.CreateAccount(acc, bal, min);
                    break;

                case 2:
                    Console.Write("Account No: ");
                    bank.ShowAccount(Console.ReadLine());
                    break;
            }
        } while(ch != 3);
    }

    static void CustomerMenu()
    {
        Console.Write("Enter your Account No: ");
        currentUser.AssignAccount(Console.ReadLine());

        int ch;
        do
        {
            Console.WriteLine("\n--- CUSTOMER MENU ---");
            Console.WriteLine("1. Profile");
            Console.WriteLine("2. View Account");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Exit");

            ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    currentUser.ShowUser();
                    break;

                case 2:
                    bank.ShowAccount(currentUser.AccountNo);
                    break;

                case 3:
                    Console.Write("Amount: ");
                    bank.Deposit(currentUser.AccountNo,
                        Convert.ToDouble(Console.ReadLine()));
                    break;

                case 4:
                    Console.Write("Amount: ");
                    bank.Withdraw(currentUser.AccountNo,
                        Convert.ToDouble(Console.ReadLine()));
                    break;
            }
        } while(ch != 5);
    }
}
