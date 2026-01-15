using System;

class AddressBookMain
{
    static void Main()
    {
        AddressBookSystem system = new AddressBookSystem();
        system.AddAddressBook("Office");
        system.AddAddressBook("Home");

        Console.WriteLine("1. Search by City");
        Console.WriteLine("2. Search by State");

        int ch = Convert.ToInt32(Console.ReadLine());

        if (ch == 1)
        {
            Console.Write("Enter City: ");
            system.SearchByCityAcrossBooks(Console.ReadLine());
        }
        else if (ch == 2)
        {
            Console.Write("Enter State: ");
            system.SearchByStateAcrossBooks(Console.ReadLine());
        }
    }
}
