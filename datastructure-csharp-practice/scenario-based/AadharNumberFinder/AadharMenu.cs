using System;

public class AadharMenu
{
    private AadharUtilityImpl service;

    public AadharMenu(AadharUtilityImpl utility)
    {
        service = utility;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n1. Display All Aadhar Records");
            Console.WriteLine("2. Sort Aadhar Records (Radix Sort)");
            Console.WriteLine("3. Search Aadhar Record");
            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    service.DisplayAll();
                    break;

                case 2:
                    service.SortAadhar();
                    break;

                case 3:
                    Console.Write("Enter Aadhar number: ");
                    long searchKey = long.Parse(Console.ReadLine());
                    service.SearchAadhar(searchKey);
                    break;

                case 4:
                    return;
            }
        }
    }
}
