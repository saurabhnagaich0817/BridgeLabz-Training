using System;

public class AddressBookUtilityImpl
{
    private Contact contact = new Contact();
    private bool isContactAdded = false;

    public void AddContact()
    {
        Console.Write("Enter First Name: ");
        contact.SetFirstName(Console.ReadLine());

        Console.Write("Enter Last Name: ");
        contact.SetLastName(Console.ReadLine());

        Console.Write("Enter Address: ");
        contact.SetAddress(Console.ReadLine());

        Console.Write("Enter City: ");
        contact.SetCity(Console.ReadLine());

        Console.Write("Enter State: ");
        contact.SetState(Console.ReadLine());

        Console.Write("Enter Zip: ");
        contact.SetZip(Console.ReadLine());

        Console.Write("Enter Phone: ");
        contact.SetPhone(Console.ReadLine());

        Console.Write("Enter Email: ");
        contact.SetEmail(Console.ReadLine());

        isContactAdded = true;
    }

    public void EditContactByName()
    {
        if (!isContactAdded)
        {
            Console.WriteLine("No contact available to edit");
            return;
        }

        Console.Write("Enter First Name to Edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Edit: ");
        string lastName = Console.ReadLine();

        if (contact.GetFirstName() == firstName &&
            contact.GetLastName() == lastName)
        {
            Console.Write("Enter New Address: ");
            contact.SetAddress(Console.ReadLine());

            Console.Write("Enter New City: ");
            contact.SetCity(Console.ReadLine());

            Console.Write("Enter New State: ");
            contact.SetState(Console.ReadLine());

            Console.Write("Enter New Zip: ");
            contact.SetZip(Console.ReadLine());

            Console.Write("Enter New Phone: ");
            contact.SetPhone(Console.ReadLine());

            Console.Write("Enter New Email: ");
            contact.SetEmail(Console.ReadLine());

            Console.WriteLine("Contact updated successfully");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }

    public void DisplayContact()
    {
        if (!isContactAdded)
        {
            Console.WriteLine("No contact to display");
            return;
        }

        Console.WriteLine("\nContact Details:");
        Console.WriteLine(contact.ToString());
    }
}
