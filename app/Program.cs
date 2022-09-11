namespace Training
{
  class Program
  {

    public static void Main(string[] args)
    {
      Book book1 = new Book("lord of the rings", "Tolkien", 300, "PG");
      Book book2 = new Book("Hobbit", "Tolkien", 800, "PG-13");
      Book book3 = new Book("Matrix", "Tom", 1500, "HAHA");

      Console.WriteLine(book1.Rating);
      Console.WriteLine(book2.Rating);
      Console.WriteLine(book3.Rating);
    }

  }
}