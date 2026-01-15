using System;

public class AddressBookUtility : IAddressBookService
{
    private string addressBookName;
    private Contact[] contacts = new Contact[100];
    private int count = 0;

    public AddressBookUtility(string name)
    {
        addressBookName = name;
        Console.WriteLine("AddressBook Created: " + addressBookName);
    }

    // UC1
    public void AddContact()
    {
        Console.Write("First Name: ");
        string fn = Console.ReadLine();
        Console.Write("Last Name: ");
        string ln = Console.ReadLine();

        if (IsDuplicate(fn, ln))
        {
            Console.WriteLine("Duplicate Contact Not Allowed");
            return;
        }

        Contact c = new Contact();
        c.SetFirstName(fn);
        c.SetLastName(ln);

        Console.Write("Address: "); c.SetAddress(Console.ReadLine());
        Console.Write("City: "); c.SetCity(Console.ReadLine());
        Console.Write("State: "); c.SetState(Console.ReadLine());
        Console.Write("Zip: "); c.SetZip(Console.ReadLine());
        Console.Write("Phone: "); c.SetPhone(Console.ReadLine());
        Console.Write("Email: "); c.SetEmail(Console.ReadLine());

        contacts[count++] = c;
        Console.WriteLine("Contact Added");
    }

    // UC2
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

    // UC3
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
                    contacts[j] = contacts[j + 1];

                contacts[--count] = null;
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
            if (contacts[i].GetFirstName() == fn &&
                contacts[i].GetLastName() == ln)
                return true;
        return false;
    }

    public void SearchByCity(string city)
    {
        for (int i = 0; i < count; i++)
            if (contacts[i].GetCity() == city)
                Console.WriteLine(contacts[i]);
    }

    public void SearchByState(string state)
    {
        for (int i = 0; i < count; i++)
            if (contacts[i].GetState() == state)
                Console.WriteLine(contacts[i]);
    }

    public void ViewPersonsByCity() => CountAndPrint(true);
    public void ViewPersonsByState() => CountAndPrint(false);

    private void CountAndPrint(bool byCity)
    {
        string[] keys = new string[100];
        int[] values = new int[100];
        int size = 0;

        for (int i = 0; i < count; i++)
        {
            string key = byCity ? contacts[i].GetCity() : contacts[i].GetState();
            int index = -1;

            for (int j = 0; j < size; j++)
                if (keys[j] == key) index = j;

            if (index == -1)
            {
                keys[size] = key;
                values[size++] = 1;
            }
            else values[index]++;
        }

        for (int i = 0; i < size; i++)
            Console.WriteLine(keys[i] + " -> " + values[i]);
    }

    public int CountByCity(string city)
    {
        int total = 0;
        for (int i = 0; i < count; i++)
            if (contacts[i].GetCity() == city) total++;
        return total;
    }

    public int CountByState(string state)
    {
        int total = 0;
        for (int i = 0; i < count; i++)
            if (contacts[i].GetState() == state) total++;
        return total;
    }

    // UC11
    public void SortByPersonName()
    {
        for (int i = 0; i < count - 1; i++)
            for (int j = i + 1; j < count; j++)
                if (string.Compare(
                    contacts[i].GetFirstName() + contacts[i].GetLastName(),
                    contacts[j].GetFirstName() + contacts[j].GetLastName()) > 0)
                {
                    Contact t = contacts[i];
                    contacts[i] = contacts[j];
                    contacts[j] = t;
                }

        DisplayContacts();
    }
}
