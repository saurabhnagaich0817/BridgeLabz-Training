using System;

public class AddressBookUtilityImpl : IAddressBookService
{
    private Contact[] contacts = new Contact[100];
    private int count = 0;

    // ---------- UC1 ----------
    public void AddContact()
    {
        Console.Write("First Name: ");
        string fn = Console.ReadLine();

        Console.Write("Last Name: ");
        string ln = Console.ReadLine();

        if (IsDuplicate(fn, ln))
        {
            Console.WriteLine("Duplicate Contact Not Allowed (UC6)");
            return;
        }

        Contact c = new Contact();
        c.SetFirstName(fn);
        c.SetLastName(ln);

        Console.Write("Address: ");
        c.SetAddress(Console.ReadLine());

        Console.Write("City: ");
        c.SetCity(Console.ReadLine());

        Console.Write("State: ");
        c.SetState(Console.ReadLine());

        Console.Write("Zip: ");
        c.SetZip(Console.ReadLine());

        Console.Write("Phone: ");
        c.SetPhone(Console.ReadLine());

        Console.Write("Email: ");
        c.SetEmail(Console.ReadLine());

        contacts[count] = c;
        count++;

        Console.WriteLine("Contact Added Successfully");
    }

    // ---------- UC2 ----------
    public void EditContact()
    {
        Console.Write("First Name: ");
        string fn = Console.ReadLine();

        Console.Write("Last Name: ");
        string ln = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName() == fn &&
                contacts[i].GetLastName() == ln)
            {
                Console.Write("New City: ");
                contacts[i].SetCity(Console.ReadLine());

                Console.Write("New State: ");
                contacts[i].SetState(Console.ReadLine());

                Console.WriteLine("Contact Updated");
                return;
            }
        }
        Console.WriteLine("Contact Not Found");
    }

    // ---------- UC3 ----------
    public void DeleteContact()
    {
        Console.Write("First Name: ");
        string fn = Console.ReadLine();

        Console.Write("Last Name: ");
        string ln = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName() == fn &&
                contacts[i].GetLastName() == ln)
            {
                for (int j = i; j < count - 1; j++)
                {
                    contacts[j] = contacts[j + 1];
                }
                contacts[count - 1] = null;
                count--;
                Console.WriteLine("Contact Deleted");
                return;
            }
        }
        Console.WriteLine("Contact Not Found");
    }

    // ---------- UC4 ----------
    public void DisplayContacts()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(contacts[i]);
        }
    }

    // ---------- UC6 ----------
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

    // ---------- UC8 ----------
    public void SearchByCity(string city)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetCity() == city)
                Console.WriteLine(contacts[i]);
        }
    }

    public void SearchByState(string state)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetState() == state)
                Console.WriteLine(contacts[i]);
        }
    }
}
