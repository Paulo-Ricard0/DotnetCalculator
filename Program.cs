namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Addition();
    }

    static void Addition()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float firstOperator = float.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor:");
      float secondOperator = float.Parse(Console.ReadLine());
      Console.Clear();
      float result = firstOperator + secondOperator;
      Console.WriteLine($"O resultado da soma é: {result}");
    }
  }
}
