
namespace Console_Library.models
{
  public class Movie
  {
    public string Title { get; private set; }
    public string Director { get; private set; }
    public string Released { get; private set; }
    public string Rating { get; private set; }
    public bool Available { get; set; }




    public Movie(string title, string director, string released, string rating, bool available = true)
    {
      Title = title;
      Director = director;
      Released = released;
      Rating = rating;
      Available = available;
    }
  }
}