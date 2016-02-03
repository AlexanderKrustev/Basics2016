using System;
class SumSeconds
{
  static void Main()
  {
      int second1 = int.Parse(Console.ReadLine());
      int second2 = int.Parse(Console.ReadLine());
      int second3 = int.Parse(Console.ReadLine());
      int sumOfSeconds = second3 + second1 + second2;
      if (sumOfSeconds%60 < 10)
      {
          Console.WriteLine("{0}:0{1}", sumOfSeconds/60, sumOfSeconds%60);
      }
      else
      {
         Console.WriteLine("{0}:{1}", sumOfSeconds / 60, sumOfSeconds % 60);
      }

  }
}

