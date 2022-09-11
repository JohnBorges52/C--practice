using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Training
{

  class Book
  {
    public string title;
    public string author;
    public int pages;

    private string rating;


    public Book(string aTitle, string aAuthor, int aPages, string aRating)
    {
      title = aTitle;
      author = aAuthor;
      pages = aPages;
      Rating = aRating;
    }

    public bool Isbig()
    {
      if (pages > 500)
      {
        return true;
      }
      return false;
    }
    public string Rating
    {
      get { return rating; }
      set
      {
        if (value == "PG" || value == "PG-13")
        {
          rating = value;
        }
        else
        {
          rating = "NOT RATED";
        }
      }
    }




  }

}