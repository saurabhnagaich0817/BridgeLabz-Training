public class AddressBookSystem
{
    private string[] names = new string[10];
    private AddressBookUtilityImpl[] books =
        new AddressBookUtilityImpl[10];
    private int count = 0;

    public AddressBookUtilityImpl GetAddressBook(string name)
    {
        for (int i = 0; i < count; i++)
        {
            if (names[i] == name)
                return books[i];
        }

        names[count] = name;
        books[count] = new AddressBookUtilityImpl();
        count++;

        return books[count - 1];
    }
}
