public class MovieUtility : IMovieService
{
    private MovieLinkedList movieList;

    public MovieUtility()
    {
        movieList = new MovieLinkedList();
    }

    public void AddMovie(string title, string time)
    {
        Movie movie = new Movie(title, time);
        movieList.Add(movie);
    }

    public void ViewAllMovies()     
    {
        movieList.Display();
    }

    public void SearchMovie(string keyword)   
    {
        movieList.Search(keyword);
    }
}
