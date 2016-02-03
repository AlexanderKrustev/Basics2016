using System;

class GreaterNumber
{
  static void Main()
  {
      Console.WriteLine("Enter two numbers");
      double number1 = double.Parse(Console.ReadLine());
      double number2 = double.Parse(Console.ReadLine());

      if (number1 > number2)
      {
          Console.WriteLine(number1);
      }
      else
      {
          Console.WriteLine(number2);
      }
    }
}

