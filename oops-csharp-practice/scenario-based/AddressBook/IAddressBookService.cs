public interface IAddressBookService
{
    void AddContact();        // UC1
    void EditContact();       // UC2
    void DeleteContact();     // UC3
    void DisplayContacts();   // UC4
    bool IsDuplicate(string fn, string ln); // UC6
    void SearchByCity(string city);   // UC8
    void SearchByState(string state); // UC8
}
