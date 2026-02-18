using AddressBook.Models;
using AddressBook.Repository;

namespace AddressBook.Services
{
    public class ContactService
    {
        ContactRepository repo = new ContactRepository();

        Contact Input()
        {
            Contact c = new Contact();
            Console.Write("First Name: "); c.FirstName = Console.ReadLine();
            Console.Write("Last Name: "); c.LastName = Console.ReadLine();
            Console.Write("Address: "); c.Address = Console.ReadLine();
            Console.Write("City: "); c.City = Console.ReadLine();
            Console.Write("State: "); c.State = Console.ReadLine();
            Console.Write("Zip: "); c.Zip = Console.ReadLine();
            Console.Write("Phone: "); c.Phone = Console.ReadLine();
            Console.Write("Email: "); c.Email = Console.ReadLine();
            return c;
        }

        public void Add() => repo.Add(Input());

        public void Update()
        {
            Contact c = Input();
            Console.Write("Contact Id: ");
            c.ContactId = int.Parse(Console.ReadLine());
            repo.Update(c);
        }

        public void Delete()
        {
            Console.Write("Enter Id: ");
            repo.Delete(int.Parse(Console.ReadLine()));
        }

        public void ViewAll() => repo.ViewAll();
        public void SearchCity()
        {
            Console.Write("City: ");
            repo.SearchCity(Console.ReadLine());
        }

        public void SearchState()
        {
            Console.Write("State: ");
            repo.SearchState(Console.ReadLine());
        }

        public void SortName() => repo.SortName();
        public void SortCity() => repo.SortCity();
        public void SortState() => repo.SortState();

       public void CountCity()
{
    Console.Write("City: ");
    string city = Console.ReadLine();
    repo.CountCity(city);
}


        public void CountState()
        {
            Console.Write("State: ");
            repo.CountState(Console.ReadLine());
        }
    }
}
