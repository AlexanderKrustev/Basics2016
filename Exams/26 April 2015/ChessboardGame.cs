using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalSize = size*size;
            int blackTeamScore = 0;
            int whiteTeamScore = 0;

            if (input.Length < totalSize)
            {
                input = input + new string('_', totalSize - input.Length);
            }

            for (int i = 0; i < totalSize; i++)
            {
                if (((int) input[i] >= 48 && (int) input[i] <= 58) || ((int) input[i] >= 65 && (int) input[i] <= 90) || ((int) input[i] >= 97 && (int) input[i] <= 122))
                {
                    if (i % 2 == 0)
                    {
                        if (((int) input[i] >= 65 && (int) input[i] <= 90))
                        {
                            whiteTeamScore += (int) input[i];
                        }
                        else
                        {
                            blackTeamScore += (int) input[i];
                        }

                    }
                    else
                    {
                        if (((int) input[i] >= 65 && (int) input[i] <= 90))
                        {
                            blackTeamScore += (int) input[i];
                        }
                        else
                        {
                            whiteTeamScore += (int) input[i];
                        }
                    }
                }
            }
            if (blackTeamScore > whiteTeamScore)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(blackTeamScore-whiteTeamScore);

            }
            else if (blackTeamScore < whiteTeamScore)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(whiteTeamScore-blackTeamScore);
            }
            else if (blackTeamScore == whiteTeamScore)
            {
                Console.WriteLine("Equal result: {0}", blackTeamScore);
            }
        }
    }
}



    

