using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfThieves
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < n/2+1; i++)  //first part to middle +1 addiional row
            {
                Console.Write(new string(' ',((n-1) / 2)-i));  //the ammount of the "white" symbols before the symbol
                Console.Write(new string(symbol, i * 2 + 1)); //the ammount of the symbol
                Console.Write(new string(' ', ((n - 1) / 2) - i)); //the ammount of the "white" symbols after the symbol
                Console.WriteLine(); // switch to the new row
            }

            for (int i = n / 2-1 ; i >= 0 ; i--) //second part 
            {
                Console.Write(new string(' ', ((n - 1) / 2) - i)); //same
                Console.Write(new string(symbol, i * 2 + 1));
                Console.Write(new string(' ', ((n - 1) / 2) - i));
                Console.WriteLine();
            }
        }
    }
}
