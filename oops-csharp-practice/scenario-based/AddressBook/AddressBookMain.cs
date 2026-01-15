using System;

class AddressBookMain
{
    static void Main()
    {
        AddressBookSystem system = new AddressBookSystem();

        Console.Write("Enter AddressBook Name: ");
        string name = Console.ReadLine();

        IAddressBookService service =
            system.GetAddressBook(name);

        int choice;
        do
        {
            Console.WriteLine("\n1 Add");
            Console.WriteLine("2 Edit");
            Console.WriteLine("3 Delete");
            Console.WriteLine("4 Display");
            Console.WriteLine("5 Search By City");
            Console.WriteLine("6 Search By State");
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
            }
        } while (choice != 0);
    }
}
