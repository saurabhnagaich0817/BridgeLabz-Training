public class MovieMenu
{
    private IMovieService service;

    public MovieMenu()
    {
        service = new MovieUtilityImpl();
    }

    public void ShowMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n=== CinemaTime Menu ===");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. View Movies");
            Console.WriteLine("3. Search Movie");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddMovie();       
                    break;

                case 2:
                    service.ViewAllMovies();
                    break;

                case 3:
                    service.SearchMovie();    
                    break;

                case 4:
                    Console.WriteLine("Exiting");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 4);
    }
}
