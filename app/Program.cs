namespace Training
{
  class Program
  {

    static void Main(string[] args)
    {


      Console.WriteLine("---");
      Console.WriteLine("Whats your name? ");
      string name = Console.ReadLine();

      Console.WriteLine("How old are you? ");
      int age = Convert.ToInt32(Console.ReadLine());

      Bibico(name, age);

      Console.WriteLine("---");
    }
    static void Bibico(string name, int age)
    {
      Console.WriteLine("Hello " + name + " you are " + age + "years old");
    }
  }
}