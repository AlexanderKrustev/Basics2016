using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line
{
    using System.Net.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            String command = Console.ReadLine();
            int countOfPurchases = 0;
            while(command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    decimal price = 0;

                    if (char.IsLower(command[i]))
                    {
                        price = command[i]*0.3m;
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        countOfPurchases++;
                    }
                    else if (char.IsUpper(command[i]))
                    {
                        price = command[i] * 0.5m;
                        if (money < price)
                        {
                           continue;
                        }
                        money -= price;
                        countOfPurchases++;
                    }
                    else if (command[i] == '%')
                    {
                        if (money <= 0)
                        {
                            continue;
                        }
                        money = money/2m;
                        countOfPurchases++;
                    }
                    else if (command[i] == '*')
                    {
                        money += 10;
                    }

                    else
                    {
                        price = command[i];
                        if (money < price)
                        {
                            continue;
                        }
                        money -= price;
                        countOfPurchases++;
                    }
                }
                command = Console.ReadLine();
            }
            if (countOfPurchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", countOfPurchases, money);
            }

        }
    }
}
