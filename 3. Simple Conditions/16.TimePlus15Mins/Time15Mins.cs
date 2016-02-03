using System;

    class Time15Mins
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            int addtionalMins = 15;
            if (mins + addtionalMins > 59)
            {
                hours++;
                mins += addtionalMins;
                mins = mins - 60;
                if (hours >= 24)
                {
                    hours = 0;
                }
            }
            else
            {
                mins = mins + addtionalMins;
            }
            Console.WriteLine("{0}:{1:d2}",hours,mins);
        }
    }

