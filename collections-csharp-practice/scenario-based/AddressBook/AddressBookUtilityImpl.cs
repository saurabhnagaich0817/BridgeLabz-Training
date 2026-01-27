using System;
using System.Collections.Generic;

class AddressBookUtilityImpl : IAddressBook
{
    private Dictionary<string, List<Contact>> bookCollection =
        new Dictionary<string, List<Contact>>();

    private string currentBook = "Default";
    private bool isDataLoaded = false;

    private bool IsBookPresent(string bookKey)
    {
        return bookCollection.ContainsKey(bookKey);
    }

    private bool IsPersonDuplicate(string fName, string lName)
    {
        if (!bookCollection.ContainsKey(currentBook))
            return false;

        List<Contact> contactList = bookCollection[currentBook];

        for (int idx = 0; idx < contactList.Count; idx++)
        {
            if (contactList[idx].GetFirstName() == fName &&
                contactList[idx].GetLastName() == lName)
            {
                return true;
            }
        }
        return false;
    }

    public void LoadPredefinedContacts()
    {
        if (isDataLoaded) return;

        bookCollection["Default"] = new List<Contact>();
        bookCollection["Family"] = new List<Contact>();
        bookCollection["Office"] = new List<Contact>();

        currentBook = "Default";

        Contact defaultUser1 = new Contact();
        defaultUser1.SetFirstName("Rahul");
        defaultUser1.SetLastName("Sharma");
        defaultUser1.SetAddress("12, MG Road");
        defaultUser1.SetCity("Bengaluru");
        defaultUser1.SetState("Karnataka");
        defaultUser1.SetZip("560001");
        defaultUser1.SetPhoneNumber("9876543210");
        defaultUser1.SetEmail("rahul.sharma@gmail.com");
        AddBook(defaultUser1);

        currentBook = "Family";
        Contact familyUser = new Contact();
        familyUser.SetFirstName("Ananya");
        familyUser.SetLastName("Verma");
        familyUser.SetCity("New Delhi");
        familyUser.SetState("Delhi");
        AddBook(familyUser);

        currentBook = "Default";
        isDataLoaded = true;
    }

    public void AddBook(Contact person)
    {
        if (person == null) return;
        if (!bookCollection.ContainsKey(currentBook)) return;

        bookCollection[currentBook].Add(person);
    }

    public Contact CreateContact()
    {
        Contact newContact = new Contact();

        Console.Write("Enter First Name: ");
        string fName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lName = Console.ReadLine();

        if (IsPersonDuplicate(fName, lName))
        {
            Console.WriteLine("Contact already exists.");
            return null;
        }

        newContact.SetFirstName(fName);
        newContact.SetLastName(lName);

        Console.Write("Enter City: ");
        newContact.SetCity(Console.ReadLine());

        Console.Write("Enter State: ");
        newContact.SetState(Console.ReadLine());

        return newContact;
    }

    public void DisplayContacts()
    {
        foreach (var bookEntry in bookCollection)
        {
            Console.WriteLine("Address Book: " + bookEntry.Key);

            foreach (Contact c in bookEntry.Value)
            {
                Console.WriteLine(c);
                Console.WriteLine();
            }
        }
    }

    public void EditContact() { }
    public void DeleteContact() { }
    public void AddMultipleContacts() { }
    public void SearchPersonByCity() { }
    public void SearchPersonByState() { }
    public void CountContactsByCity() { }
    public void CountContactsByState() { }
    public void SortContactsByName() { }
}
