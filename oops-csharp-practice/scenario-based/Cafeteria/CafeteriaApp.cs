using System;

// This class manages application execution and role menus
class CafeteriaApp
{
    // Program execution starts here
    static void Main(string[] args)
    {
        // Object creation for cafeteria operations
        Cafeteria cafeteriaObj = new Cafeteria();

        // Role options
        Console.WriteLine("Choose User Type:");
        Console.WriteLine("1. Owner");
        Console.WriteLine("2. Customer");

        int userType = Convert.ToInt32(Console.ReadLine());

        // Role-based decision
        switch (userType)
        {
            case 1:
                ShowAdminPanel(cafeteriaObj);
                break;

            case 2:
                ShowStudentPanel(cafeteriaObj);
                break;

            default:
                Console.WriteLine("Wrong selection");
                break;
        }
    }

    // Admin panel – view only
    static void ShowAdminPanel(Cafeteria cafeteriaObj)
    {
        Console.WriteLine("\n--- ADMIN PANEL ---");
        cafeteriaObj.PrintMenu();
        Console.WriteLine("Admin access is read-only.");
    }

    // Student panel – menu driven
    static void ShowStudentPanel(Cafeteria cafeteriaObj)
    {
        int studentChoice;

        do
        {
            Console.WriteLine("\n--- STUDENT PANEL ---");
            Console.WriteLine("1. Display Menu");
            Console.WriteLine("2. Order Food");
            Console.WriteLine("3. Exit");

            studentChoice = Convert.ToInt32(Console.ReadLine());

            switch (studentChoice)
            {
                case 1:
                    cafeteriaObj.PrintMenu();
                    break;

                case 2:
                    Console.Write("Enter item number: ");
                    int selectedNo = Convert.ToInt32(Console.ReadLine());

                    string selectedFood =
                        cafeteriaObj.FetchItemByNumber(selectedNo);

                    Console.WriteLine("You ordered: " + selectedFood);
                    break;

                case 3:
                    Console.WriteLine("Exiting student panel...");
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        } while (studentChoice != 3);
    }
}
