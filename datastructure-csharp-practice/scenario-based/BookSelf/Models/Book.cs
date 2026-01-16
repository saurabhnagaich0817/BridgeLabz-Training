namespace BookSelf.Models
{
  class Book
  {
    private string title;
    private string author;
    public Book (string title,string author)
    {
      this.title=title;
      this.author = author;

    }
    public string GetTitle(){return title;}
    public override string ToString()
    {
      return $"Title:{title},Author : {author}";
    }
  }
}