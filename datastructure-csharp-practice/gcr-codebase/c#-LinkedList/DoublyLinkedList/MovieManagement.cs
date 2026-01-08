using System;

class MovieNode
{
    public string movieTitle;
    public string directorName;
    public int releaseYear;
    public double rating;

    public MovieNode next;
    public MovieNode prev;
}

class MovieManager
{
    MovieNode head;

    // Add movie at beginning
    public void AddAtBeginning(string movieTitle, string directorName, int releaseYear, double rating)
    {
        MovieNode newMovie = new MovieNode();
        newMovie.movieTitle = movieTitle;
        newMovie.directorName = directorName;
        newMovie.releaseYear = releaseYear;
        newMovie.rating = rating;

        newMovie.next = head;
        newMovie.prev = null;

        if (head != null)
            head.prev = newMovie;

        head = newMovie;
    }

    // Add movie at end
    public void AddAtEnd(string movieTitle, string directorName, int releaseYear, double rating)
    {
        MovieNode newMovie = new MovieNode();
        newMovie.movieTitle = movieTitle;
        newMovie.directorName = directorName;
        newMovie.releaseYear = releaseYear;
        newMovie.rating = rating;
        newMovie.next = null;

        if (head == null)
        {
            newMovie.prev = null;
            head = newMovie;
            return;
        }

        MovieNode temp = head;
        while (temp.next != null)
            temp = temp.next;

        temp.next = newMovie;
        newMovie.prev = temp;
    }

    // Add movie at specific position
    public void AddAtPosition(int position, string movieTitle, string directorName, int releaseYear, double rating)
    {
        if (position == 1)
        {
            AddAtBeginning(movieTitle, directorName, releaseYear, rating);
            return;
        }

        MovieNode temp = head;
        for (int i = 1; i < position - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null) return;

        MovieNode newMovie = new MovieNode();
        newMovie.movieTitle = movieTitle;
        newMovie.directorName = directorName;
        newMovie.releaseYear = releaseYear;
        newMovie.rating = rating;

        newMovie.next = temp.next;
        newMovie.prev = temp;

        if (temp.next != null)
            temp.next.prev = newMovie;

        temp.next = newMovie;
    }

    // Remove movie by title
    public void RemoveByTitle(string movieTitle)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.movieTitle == movieTitle)
            {
                if (temp.prev != null)
                    temp.prev.next = temp.next;
                else
                    head = temp.next;

                if (temp.next != null)
                    temp.next.prev = temp.prev;

                return;
            }
            temp = temp.next;
        }
    }

    // Search by director
    public void SearchByDirector(string directorName)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.directorName == directorName)
                DisplayMovie(temp);

            temp = temp.next;
        }
    }

    // Search by rating
    public void SearchByRating(double rating)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.rating == rating)
                DisplayMovie(temp);

            temp = temp.next;
        }
    }

    // Update rating by title
    public void UpdateRating(string movieTitle, double newRating)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.movieTitle == movieTitle)
            {
                temp.rating = newRating;
                return;
            }
            temp = temp.next;
        }
    }

    // Display forward
    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.next;
        }
    }

    // Display reverse
    public void DisplayReverse()
    {
        MovieNode temp = head;
        if (temp == null) return;

        while (temp.next != null)
            temp = temp.next;

        while (temp != null)
        {
            DisplayMovie(temp);
            temp = temp.prev;
        }
    }

    void DisplayMovie(MovieNode movie)
    {
        Console.WriteLine(
            movie.movieTitle + " | " +
            movie.directorName + " | " +
            movie.releaseYear + " | Rating: " +
            movie.rating
        );
    }
}

class Program
{
    static void Main()
    {
        MovieManager manager = new MovieManager();

        manager.AddAtBeginning("Inception", "Nolan", 2010, 8.8);
        manager.AddAtEnd("Interstellar", "Nolan", 2014, 8.6);
        manager.AddAtPosition(2, "Avatar", "Cameron", 2009, 7.8);

        Console.WriteLine("Movies (Forward):");
        manager.DisplayForward();

        Console.WriteLine("Movies (Reverse):");
        manager.DisplayReverse();

        manager.SearchByDirector("Nolan");

        manager.UpdateRating("Avatar", 8.0);
        manager.RemoveByTitle("Inception");

        Console.WriteLine("After Updates:");
        manager.DisplayForward();
    }
}
