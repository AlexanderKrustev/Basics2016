using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalBookPages = int.Parse(Console.ReadLine());
            int campingDaysPerMonth = int.Parse(Console.ReadLine());
            int pagesPerDay = int.Parse(Console.ReadLine());

            int normalDaysPerMonth = 30 - campingDaysPerMonth;
            double pagesPerMonth = normalDaysPerMonth*pagesPerDay;

            if (pagesPerMonth <= 1)
            {
                Console.WriteLine("never");
            }
            else
            {
                double totalMonths = totalBookPages/pagesPerMonth; 
                double years = totalMonths/12.0;
                double months = totalMonths%12.0;

                Console.WriteLine("{0} years {1} months", Math.Floor(years), Math.Ceiling(months));
            }
        }
    }
}
