public interface IAddressBookService
{
    void AddContact();
    void EditContact();
    void DeleteContact();
    void DisplayContacts();

    bool IsDuplicate(string fn, string ln);

    void SearchByCity(string city);
    void SearchByState(string state);

    void ViewPersonsByCity();
    void ViewPersonsByState();

    int CountByCity(string city);
    int CountByState(string state);

    void SortByPersonName();
}
