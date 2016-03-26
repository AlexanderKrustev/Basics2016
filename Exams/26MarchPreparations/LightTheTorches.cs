using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main()
        {
            int numberRooms = int.Parse(Console.ReadLine());
            string stateOfRooms = Console.ReadLine();
            string[] roomsArray = new string[numberRooms];
            for (int i = 0; i < roomsArray.Length; i++)
            {
               
                roomsArray[i] = stateOfRooms[i%stateOfRooms.Length].ToString();
              
            }
            string command = Console.ReadLine();
            int currentPossition = roomsArray.Length/2;
            while (command != "END")
            {
                string[] agrs = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int step = int.Parse(agrs[1]) + 1;

                if (command.Contains("LEFT"))
                {
                    if (currentPossition == 0)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    currentPossition -= step;
                    if (currentPossition < 0)
                    {
                        currentPossition = 0;
                    }
                }
                else
                {
                    if (currentPossition == roomsArray.Length-1)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    currentPossition += step;

                    if (currentPossition > roomsArray.Length-1)
                    {
                        currentPossition = roomsArray.Length-1;
                        
                    }
                }

                if (roomsArray[currentPossition] == "D")
                {
                    roomsArray[currentPossition] = "L";
                }
                else
                {
                    roomsArray[currentPossition] = "D";
                }
                command = Console.ReadLine();
            }

           // Console.WriteLine(string.Join(" ", roomsArray));
            int counter = 0;
            for (int i = 0; i < roomsArray.Length; i++)
            {
                if (roomsArray[i] == "D")
                {
                    counter++;
                }
            }

            int count = roomsArray.Count(c => c == "D");
            Console.WriteLine(counter*68);
           

        }
    }
}
