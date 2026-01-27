using System;

public class AddressBookMenu
{
    private AddressBookUtilityImpl serviceHandler = new AddressBookUtilityImpl();

    public void Start()
    {
        serviceHandler.LoadPredefinedContacts();

        bool appRunning = true;

        while (appRunning)
        {
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Create New Address Book + Add Multiple Contacts");
            Console.WriteLine("6. Search Person By City");
            Console.WriteLine("7. Search Person By State");
            Console.WriteLine("8. Count Contacts By City");
            Console.WriteLine("9. Count Contacts By State");
            Console.WriteLine("10. Sort Contacts By Name");
            Console.WriteLine("11. Exit");
            Console.Write("Enter choice: ");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    serviceHandler.AddBook(serviceHandler.CreateContact());
                    break;
                case "2":
                    serviceHandler.DisplayContacts();
                    break;
                case "3":
                    serviceHandler.EditContact();
                    break;
                case "4":
                    serviceHandler.DeleteContact();
                    break;
                case "5":
                    serviceHandler.AddMultipleContacts();
                    break;
                case "6":
                    serviceHandler.SearchPersonByCity();
                    break;
                case "7":
                    serviceHandler.SearchPersonByState();
                    break;
                case "8":
                    serviceHandler.CountContactsByCity();
                    break;
                case "9":
                    serviceHandler.CountContactsByState();
                    break;
                case "10":
                    serviceHandler.SortContactsByName();
                    break;
                case "11":
                    appRunning = false;
                    break;
            }

            Console.WriteLine();
        }
    }
}
