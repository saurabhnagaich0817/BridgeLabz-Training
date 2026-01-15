public interface IAddressBookService
{
    void AddContact();          // UC1
    void EditContactByName();   // UC2
    void DisplayContacts();     // UC3
    void DeleteContact();       // UC4
    void AddMultipleContacts(); // UC5
    void SearchByCity();        // UC6
    void CountByState();        // UC7
}
