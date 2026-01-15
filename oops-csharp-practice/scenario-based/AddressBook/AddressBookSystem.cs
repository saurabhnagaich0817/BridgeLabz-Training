using System;

public class AddressBookSystem
{
    private string[] names = new string[5];
    private AddressBookUtilityImpl[] books = new AddressBookUtilityImpl[5];
    private int count = 0;

    public void AddAddressBook(string name)
    {
        names[count] = name;
        books[count] = new AddressBookUtilityImpl();
        count++;
    }

    public AddressBookUtilityImpl GetBook(string name)
    {
        for (int i = 0; i < count; i++)
            if (names[i] == name)
                return books[i];
        return null;
    }

   

    public void SearchByCityAcrossBooks(string city)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nAddressBook: " + names[i]);
            books[i].SearchPersonByCity(city);
        }
    }

    public void SearchByStateAcrossBooks(string state)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nAddressBook: " + names[i]);
            books[i].SearchPersonByState(state);
        }
    }
}
