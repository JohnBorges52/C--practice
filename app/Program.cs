namespace Training
{
  class Program
  {

    static void Main(string[] args)
    {
      Console.Write("Enter a number: ");
      double numberOne = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter a second number: ");
      double numberTwo = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("---");
      Console.WriteLine(numberOne + numberTwo);


      Console.WriteLine("---");
    }
  }
}