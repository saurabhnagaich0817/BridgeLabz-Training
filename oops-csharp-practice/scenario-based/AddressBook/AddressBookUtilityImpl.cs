using System;

public class AddressBookUtilityImpl : IAddressBookService
{
    private Contact[] contacts = new Contact[100];
    private int count = 0;

    
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

        contacts[count++] = c;
        Console.WriteLine("Contact Added Successfully");
    }

   
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
        {
            if (contacts[i].GetFirstName() == fn &&
                contacts[i].GetLastName() == ln)
                return true;
        }
        return false;
    }

 
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

    
   
    public void ViewPersonsByCity()
    {
        string[] cities = new string[100];
        int[] cityCount = new int[100];
        int citySize = 0;

        for (int i = 0; i < count; i++)
        {
            string city = contacts[i].GetCity();
            int index = -1;

            for (int j = 0; j < citySize; j++)
            {
                if (cities[j] == city)
                {
                    index = j;
                    break;
                }
            }

            if (index == -1)
            {
                cities[citySize] = city;
                cityCount[citySize] = 1;
                citySize++;
            }
            else
            {
                cityCount[index]++;
            }
        }

        for (int i = 0; i < citySize; i++)
            Console.WriteLine(cities[i] + " = " + cityCount[i]);
    }

    // View Persons by State with Count
    public void ViewPersonsByState()
    {
        string[] states = new string[100];
        int[] stateCount = new int[100];
        int stateSize = 0;

        for (int i = 0; i < count; i++)
        {
            string state = contacts[i].GetState();
            int index = -1;

            for (int j = 0; j < stateSize; j++)
            {
                if (states[j] == state)
                {
                    index = j;
                    break;
                }
            }

            if (index == -1)
            {
                states[stateSize] = state;
                stateCount[stateSize] = 1;
                stateSize++;
            }
            else
            {
                stateCount[index]++;
            }
        }

        for (int i = 0; i < stateSize; i++)
            Console.WriteLine(states[i] + " = " + stateCount[i]);
    }
}
