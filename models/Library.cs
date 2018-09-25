using System.Collections.Generic;
using System;

namespace Console_Library.models
{
  public class Library
  {
    public string Name { get; private set; }

    private List<Book> Books = new List<Book>();
    private List<Movie> Movies = new List<Movie>();

    private List<String> MenuOptions = new List<string>();


    public void ViewMainMenu()
    {
      Console.WriteLine("\nMAIN MENU: Please select one of the options below (Enter Number)");
      for (int i = 0; i < MenuOptions.Count; i++)
      {
        Console.WriteLine($"{i + 1} - {MenuOptions[i]}");
      }
    }

    //BOOK METHODS
    public void AddBook(Book book)
    {
      Books.Add(book);
    }

    private void ViewBooks()
    {
      int count = 1;
      Books.ForEach(book =>
      {
        string availableText = (book.Available ? "Available" : "Not Available");
        Console.WriteLine($"{count} - {book.Title} {availableText}");
        count++;
      });
    }

    public void CheckOutBook()
    {
      bool checkingOutBook = true;
      while (checkingOutBook)
      {
        Console.WriteLine("\nPlease select which book you would like to check out (Enter number)");
        ViewBooks();
        Console.WriteLine($"{Books.Count + 1} - Back to main menu");
        Book book = getBookFromUserInput();
        if (book == null)//invalid selection
        {
          checkingOutBook = false;
        }
        else if (book.Available)//available book chosen
        {
          book.Available = false;
          Console.WriteLine($"\nYou have checked out {book.Title}.");
          Console.WriteLine("Would you like to check out another book (Y/N)?");
          string response = Console.ReadLine().ToUpper();
          if (response != "Y")
          {
            checkingOutBook = false;
          }
        }
        else //book not available
        {
          Console.WriteLine("\nTITLE NOT AVAILABLE.");
          continue;
        }

      }

    }

    public void ReturnBook()
    {
      bool returningBook = true;
      while (returningBook)
      {
        Console.WriteLine("\nPlease select which book you are returning (Enter number)");
        ViewBooks();
        Console.WriteLine($"{Books.Count + 1} - Back to main menu");
        Book book = getBookFromUserInput();
        if (book == null)//invalid selection
        {
          returningBook = false;
        }
        else if (!book.Available)//valid book chosen
        {
          book.Available = true;
          Console.WriteLine($"\nYou have returned {book.Title}.");
          Console.WriteLine("Would you like to return another book (Y/N)?");
          string response = Console.ReadLine().ToUpper();
          if (response != "Y")
          {
            returningBook = false;
          }
        }
        else //book not checked out
        {
          Console.WriteLine("\nTITLE NOT CHECKED OUT.");
        }
      }

    }

    private Book getBookFromUserInput()
    {
      if (Int32.TryParse(Console.ReadLine(), out int choice))
      {
        int index = choice - 1;

        if (index < 0 || index >= Books.Count)
        {
          return null;
        }
        return Books[index];
      }
      return null;
    }



    //MOVIE METHODS
    public void AddMovie(Movie movie)
    {
      Movies.Add(movie);
    }

    private void ViewMovies()
    {
      int count = 1;
      Movies.ForEach(movie =>
      {
        string availableText = (movie.Available ? "Available" : "Not Available");
        Console.WriteLine($"{count} - {movie.Title} {availableText}");
        count++;
      });
    }

    public void CheckOutMovie()
    {
      bool checkingOutMovie = true;
      while (checkingOutMovie)
      {
        Console.WriteLine("\nPlease select which book you would like to check out (Enter number)");
        ViewMovies();
        Console.WriteLine($"{Movies.Count + 1} - Back to main menu");
        Movie movie = getMovieFromUserInput();
        if (movie == null)//invalid selection
        {
          checkingOutMovie = false;
        }
        else if (movie.Available)//available movie chosen
        {
          movie.Available = false;
          Console.WriteLine($"\nYou have checked out {movie.Title}.");
          Console.WriteLine("Would you like to check out another movie (Y/N)?");
          string response = Console.ReadLine().ToUpper();
          if (response != "Y")
          {
            checkingOutMovie = false;
          }
        }
        else //movie not available
        {
          Console.WriteLine("\nTITLE NOT AVAILABLE.");
          continue;
        }

      }

    }

    public void ReturnMovie()
    {
      bool returningMovie = true;
      while (returningMovie)
      {
        Console.WriteLine("\nPlease select which book you are returning (Enter number)");
        ViewMovies();
        Console.WriteLine($"{Movies.Count + 1} - Back to main menu");
        Movie movie = getMovieFromUserInput();
        if (movie == null)//invalid selection
        {
          returningMovie = false;
        }
        else if (!movie.Available)//valid movie chosen
        {
          movie.Available = true;
          Console.WriteLine($"\nYou have returned {movie.Title}.");
          Console.WriteLine("Would you like to return another movie (Y/N)?");
          string response = Console.ReadLine().ToUpper();
          if (response != "Y")
          {
            returningMovie = false;
          }
        }
        else //movie not checked out
        {
          Console.WriteLine("\nTITLE NOT CHECKED OUT.");
        }
      }

    }

    private Movie getMovieFromUserInput()
    {
      if (Int32.TryParse(Console.ReadLine(), out int choice))
      {
        int index = choice - 1;

        if (index < 0 || index >= Books.Count)
        {
          return null;
        }
        return Movies[index];
      }
      return null;
    }



    public Library(string name)
    {
      Name = name;
      MenuOptions.Add("Exit the Library");
      MenuOptions.Add("Checkout a Book");
      MenuOptions.Add("Return a book");
      MenuOptions.Add("Check out a movie");
      MenuOptions.Add("Return a movie");

      //Add new options here


    }

  }
}