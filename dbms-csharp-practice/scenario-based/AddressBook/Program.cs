using AddressBook.Services;

class Program
{
    static void Main()
    {
        ContactService s = new ContactService();
        int ch;

        do
        {
            Console.WriteLine("\n1 Add\n2 Update\n3 Delete\n4 View\n5 Search City\n6 Count City\n7 Search State\n8 Sort Name\n9 Sort City\n10 Sort State\n11 Count State\n0 Exit");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: s.Add(); break;
                case 2: s.Update(); break;
                case 3: s.Delete(); break;
                case 4: s.ViewAll(); break;
                case 5: s.SearchCity(); break;
                case 6: s.CountCity(); break;
                case 7: s.SearchState(); break;
                case 8: s.SortName(); break;
                case 9: s.SortCity(); break;
                case 10: s.SortState(); break;
                case 11: s.CountState(); break;
            }
        } while (ch != 0);
    }
}
