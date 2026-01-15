public interface IAddressBookService
{
    void AddContact();
    void EditContactByName();
    void DeleteContactByName();
    void DisplayContacts();
    bool IsDuplicate(string firstName, string lastName);
    int CountByState(string state);
    void SearchPersonByCity(string city);
    void SearchPersonByState(string state);
}
