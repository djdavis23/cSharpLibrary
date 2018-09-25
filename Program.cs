using System;
using Console_Library.models;

namespace Console_Library
{
  class Program
  {
    static void Main(string[] args)
    {
      //Build library;
      Library library = new Library("Don's Library");
      library.AddBook(new Book("The Hunt for Red October", "Tom Clancy", "1756748-985632", "1984", false));
      library.AddBook(new Book("The Firm", "John Grisham", "8773456-142846", "1991"));
      library.AddBook(new Book("Absolute Power", "David Baldacci", "0987345-173452", "1996"));
      library.AddBook(new Book("Never Go Back", "Lee Child", "8752956-142846", "1997"));

      library.AddMovie(new Movie("The Avengers", "Josh Whedon", "2012", "PG-13"));
      library.AddMovie(new Movie("The Incredibles", "Brad Bird", "2004", "PG", false));
      library.AddMovie(new Movie("Ant-Man", "Peyton Reed", "2015", "PG-13"));
      library.AddMovie(new Movie("Lone Survivor", "Peter Berg", "2013", "R"));



      //Enter the library
      Console.Clear();
      Console.WriteLine($"Welcome to {library.Name}!");
      bool inTheLibrary = true;
      while (inTheLibrary)
      {
        library.ViewMainMenu();
        string choice = Console.ReadLine();
        //update switch statement as new options added to library.MenuOptions
        switch (choice)
        {
          case "1"://quit
            inTheLibrary = false;
            break;
          case "2"://checkout a book
            library.CheckOutBook();
            break;
          case "3"://return a book
            library.ReturnBook();
            break;
          case "4":
            library.CheckOutMovie();
            break;
          case "5":
            library.ReturnMovie();
            break;

          //ADD NEW MENU OPTIONS HERE

          default://invalid input
            Console.WriteLine("\nInvalid input, please select again.");
            continue;
        }
      }

      //Exit the library
      Console.WriteLine($"Thanks for visiting.  Have a great day!");
    }
  }
}
