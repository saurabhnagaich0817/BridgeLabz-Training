using System;

public class DealMenu
{
    private IDealService service;

    public DealMenu()
    {
        service = new DealManagerImpl();
    }

    public void Launch()
    {
        int option;

        do
        {
            Console.WriteLine("\n===== Deal Zone Menu =====");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Sort By Discount");
            Console.WriteLine("3. View Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch (option)
            {
                case 1:
                    service.AddNewItem();
                    break;

                case 2:
                    service.SortByOffer();
                    break;

                case 3:
                    service.ShowItems();
                    break;

                case 4:
                    Console.WriteLine("Application closed.");
                    break;

                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }

        } while (option != 4);
    }
}
