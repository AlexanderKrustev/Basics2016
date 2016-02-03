using System;

class Program
{
   static void Main()
   {
       int number = int.Parse(Console.ReadLine());

       if (number%2 == 0)  //check if the inputed number can be divided by 2 without remaining
       {
           Console.WriteLine("even");
       }
       else
       {
            Console.WriteLine("odd");
        }
   }
}

