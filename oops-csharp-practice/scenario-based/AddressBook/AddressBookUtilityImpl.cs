using System;

public class AddressBookUtilityImpl : IAddressBookService
{
    private Contact[] contacts = new Contact[10];
    private int count = 0;

    public void AddContact()
    {
        Console.Write("Enter First Name: ");
        string fn = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string ln = Console.ReadLine();

        if (IsDuplicate(fn, ln))
        {
            Console.WriteLine("Duplicate contact not allowed");
            return;
        }

        Contact c = new Contact();
        c.SetFirstName(fn);
        c.SetLastName(ln);

        Console.Write("Enter Address: ");
        c.SetAddress(Console.ReadLine());

        Console.Write("Enter City: ");
        c.SetCity(Console.ReadLine());

        Console.Write("Enter State: ");
        c.SetState(Console.ReadLine());

        Console.Write("Enter Zip: ");
        c.SetZip(Console.ReadLine());

        Console.Write("Enter Phone: ");
        c.SetPhone(Console.ReadLine());

        Console.Write("Enter Email: ");
        c.SetEmail(Console.ReadLine());

        contacts[count++] = c;
        Console.WriteLine("Contact Added Successfully");
    }

    public void EditContactByName()
    {
        Console.Write("Enter First Name: ");
        string fn = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string ln = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName() == fn &&
                contacts[i].GetLastName() == ln)
            {
                Console.Write("Enter New City: ");
                contacts[i].SetCity(Console.ReadLine());

                Console.Write("Enter New State: ");
                contacts[i].SetState(Console.ReadLine());

                Console.WriteLine("Contact Updated");
                return;
            }
        }
        Console.WriteLine("Contact Not Found");
    }

    public void DeleteContactByName()
    {
        Console.Write("Enter First Name: ");
        string fn = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string ln = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName() == fn &&
                contacts[i].GetLastName() == ln)
            {
                for (int j = i; j < count - 1; j++)
                    contacts[j] = contacts[j + 1];

                count--;
                Console.WriteLine("Contact Deleted");
                return;
            }
        }
        Console.WriteLine("Contact Not Found");
    }

    public void DisplayContacts()
    {
        for (int i = 0; i < count; i++)
            Console.WriteLine(contacts[i]);
    }

    public bool IsDuplicate(string fn, string ln)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName() == fn &&
                contacts[i].GetLastName() == ln)
                return true;
        }
        return false;
    }

    public int CountByState(string state)
    {
        int c = 0;
        for (int i = 0; i < count; i++)
            if (contacts[i].GetState() == state)
                c++;
        return c;
    }

    // ================= UC 8 =================

    public void SearchPersonByCity(string city)
    {
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetCity() == city)
            {
                Console.WriteLine(contacts[i]);
                found = true;
            }
        }
        if (!found)
            Console.WriteLine("No person found in this city");
    }

    public void SearchPersonByState(string state)
    {
        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetState() == state)
            {
                Console.WriteLine(contacts[i]);
                found = true;
            }
        }
        if (!found)
            Console.WriteLine("No person found in this state");
    }
}
