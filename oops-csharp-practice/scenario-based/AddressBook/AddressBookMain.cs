using System;

public class AddressBookMain
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        AddressBookUtilityImpl utility = new AddressBookUtilityImpl();

        utility.AddContact();
        utility.DisplayContact();

        Console.WriteLine("\nDo you want to edit contact? (yes/no)");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            utility.EditContactByName();
            utility.DisplayContact();
        }
    }
}
