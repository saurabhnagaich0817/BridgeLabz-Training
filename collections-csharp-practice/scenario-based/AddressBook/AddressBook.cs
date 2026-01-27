using System;

public class AddressBook
{
    private string bookTitle;
    private UniversalLinkedList contactList = new UniversalLinkedList();

    public string GetName()
    {
        return bookTitle;
    }

    public void SetName(string bookTitle)
    {
        this.bookTitle = bookTitle;
    }

    public UniversalLinkedList GetContacts()
    {
        return contactList;
    }
}
