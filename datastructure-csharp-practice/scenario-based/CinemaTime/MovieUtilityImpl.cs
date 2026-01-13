public class MovieUtilityImpl : IMovieService
{
    private MovieLinkedList movieList;

    public MovieUtilityImpl()
    {
        movieList = new MovieLinkedList();
    }

    public void AddMovie()
    {
        Console.Write("Enter movie title: ");
        string title = Console.ReadLine();

        Console.Write("Enter show time: ");
        string time = Console.ReadLine();

        Movie movie = new Movie(title, time);
        movieList.Add(movie);

        Console.WriteLine("Movie added successfully");
    }

    public void ViewAllMovies()
    {
        movieList.Display();
    }

    public void SearchMovie()
    {
        Console.Write("Enter keyword: ");
        string keyword = Console.ReadLine();

        movieList.Search(keyword);
    }
}
