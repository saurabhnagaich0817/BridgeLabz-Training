using System;

public class AddressBookUtilityImpl : IAddressBook
{
    private Contact[] contacts = new Contact[10];
    private int count = 0;

 
    public void AddContact()
    {
        AddMultipleContacts();
    }

    public void DisplayContact()
    {
        DisplayContacts();
    }

  
    public void AddMultipleContacts()
    {
        Console.Write("How many contacts you want to add: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < n; i++)
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is Full");
                return;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

          
            if (IsDuplicate(firstName, lastName))
            {
                Console.WriteLine("Duplicate Contact Found. Not Added.\n");
                continue;
            }

            Contact contact = new Contact();
            contact.SetFirstName(firstName);
            contact.SetLastName(lastName);

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

            contacts[count] = contact;
            count++;

            Console.WriteLine("Contact Added Successfully\n");
        }
    }

   
    private bool IsDuplicate(string firstName, string lastName)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName() == firstName &&
                contacts[i].GetLastName() == lastName)
            {
                return true;
            }
        }
        return false;
    }

    public void DisplayContacts()
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts available");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Contact " + (i + 1));
            Console.WriteLine(contacts[i].ToString());
            Console.WriteLine();
        }
    }

    public void EditContactByName()
    {
        Console.Write("Enter First Name to Edit: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name to Edit: ");
        string lastName = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName() == firstName &&
                contacts[i].GetLastName() == lastName)
            {
                Console.Write("Enter New Address: ");
                contacts[i].SetAddress(Console.ReadLine());

                Console.Write("Enter New City: ");
                contacts[i].SetCity(Console.ReadLine());

                Console.Write("Enter New State: ");
                contacts[i].SetState(Console.ReadLine());

                Console.Write("Enter New Zip: ");
                contacts[i].SetZip(Console.ReadLine());

                Console.Write("Enter New Phone: ");
                contacts[i].SetPhone(Console.ReadLine());

                Console.Write("Enter New Email: ");
                contacts[i].SetEmail(Console.ReadLine());

                Console.WriteLine("Contact Updated Successfully");
                return;
            }
        }

        Console.WriteLine("Contact Not Found");
    }
}
