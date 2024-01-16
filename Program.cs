namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("\n-----------------\n");
      Console.WriteLine("Selecione uma opção: ");
      short userOption = short.Parse(Console.ReadLine());

      switch (userOption)
      {
        case 1:
          Addition();
          break;
        case 2:
          Subtraction();
          break;
        case 3:
          Division();
          break;
        case 4:
          Multiplication();
          break;
        case 5:
          System.Environment.Exit(0);
          break;
        default:
          Menu();
          break;
      }
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
      Console.ReadKey();
      Menu();
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
      Console.WriteLine($"O resultado da subtração é: {result}");
      Console.ReadKey();
      Menu();
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
      Console.WriteLine($"O resultado da divisão é: {result}");
      Console.ReadKey();
      Menu();
    }

    static void Multiplication()
    {
      Console.Clear();
      Console.WriteLine("Primeiro Valor:");
      float firstOperator = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor:");
      float secondOperator = float.Parse(Console.ReadLine());

      Console.Clear();
      float result = firstOperator * secondOperator;
      Console.WriteLine($"O resultado da multiplicação é: {result}");
      Console.ReadKey();
      Menu();
    }
  }
}
