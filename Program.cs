namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Division();
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
      Console.WriteLine($"O resultado da subtração é: {result}");
    }

    static void Subtraction()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float firstOperator = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float secondOperator = float.Parse(Console.ReadLine());

      Console.Clear();
      float result = firstOperator - secondOperator;
      Console.WriteLine($"O resultado da soma é: {result}");
      Console.ReadKey();
    }

    static void Division()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float firstOperator = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float secondOperator = float.Parse(Console.ReadLine());

      Console.Clear();
      float result = firstOperator / secondOperator;
      Console.WriteLine($"O resultado da soma é: {result}");
      Console.ReadKey();
    }
  }
}
