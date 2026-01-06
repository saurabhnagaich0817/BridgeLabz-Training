using System;

class Program
{
    static void Main()
    {
        CallLogManager manager = new CallLogManager(20);
        int choice;

        do
        {
            Console.WriteLine("\nCustomer Service Call Log Manager");
            Console.WriteLine("1. Add Call Log");
            Console.WriteLine("2. Search by Keyword");
            Console.WriteLine("3. Filter by Time");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    manager.AddCallLog();
                    break;

                case 2:
                    manager.SearchByKeyword();
                    break;

                case 3:
                    manager.FilterByTime();
                    break;

                case 4:
                    Console.WriteLine("Program exited.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}
