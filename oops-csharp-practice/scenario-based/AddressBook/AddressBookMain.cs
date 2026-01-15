using System;

class AddressBookMain
{
    static void Main()
    {
        AddressBookSystem system = new AddressBookSystem();

        Console.Write("Enter AddressBook Name: ");
        string name = Console.ReadLine();

        IAddressBookService service = system.GetAddressBook(name);

        int choice;
        do
        {
            Console.WriteLine("\n1 Add");
            Console.WriteLine("2 Edit");
            Console.WriteLine("3 Delete");
            Console.WriteLine("4 Display");
            Console.WriteLine("5 Search By City");
            Console.WriteLine("6 Search By State");
            Console.WriteLine("7 View Persons By City (UC9)");
            Console.WriteLine("8 View Persons By State (UC9)");
            Console.WriteLine("9 Count By City (UC10)");
            Console.WriteLine("10 Count By State (UC10)");
            Console.WriteLine("0 Exit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: service.AddContact(); break;
                case 2: service.EditContact(); break;
                case 3: service.DeleteContact(); break;
                case 4: service.DisplayContacts(); break;

                case 5:
                    Console.Write("City: ");
                    service.SearchByCity(Console.ReadLine());
                    break;

                case 6:
                    Console.Write("State: ");
                    service.SearchByState(Console.ReadLine());
                    break;

                case 7:
                    service.ViewPersonsByCity();
                    break;

                case 8:
                    service.ViewPersonsByState();
                    break;

                case 9:
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.WriteLine("Total Contacts: " + service.CountByCity(city));
                    break;

                case 10:
                    Console.Write("State: ");
                    string state = Console.ReadLine();
                    Console.WriteLine("Total Contacts: " + service.CountByState(state));
                    break;
            }
        } while (choice != 0);
    }
}
