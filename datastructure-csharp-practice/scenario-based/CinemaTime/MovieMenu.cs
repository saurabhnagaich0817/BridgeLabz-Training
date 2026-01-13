using System;

public class MovieMenu
{
    private IMovieService service;

    public MovieMenu()
    {
        service = new MovieUtility();
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
                    Console.Write("Enter movie title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter show time: ");
                    string time = Console.ReadLine();

                    service.AddMovie(title, time);
                    Console.WriteLine("Movie added successfully");
                    break;

                case 2:
                   service.ViewAllMovies();  
                   break;

                case 3:
                  Console.Write("Enter keyword: ");
                  string keyword = Console.ReadLine();
                  service.SearchMovie(keyword);   
                  break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 4);
    }
}
