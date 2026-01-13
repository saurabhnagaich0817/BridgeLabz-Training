public interface IMovieService
{
    void AddMovie(string title, string time);
    void ViewAllMovies();        
    void SearchMovie(string keyword);  
}
