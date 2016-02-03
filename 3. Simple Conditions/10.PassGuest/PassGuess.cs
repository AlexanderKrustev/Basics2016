using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PassGuest
{
    class PassGuess
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            string hardCodedPass = "s3cr3t!P@ssw0rd";

            if (pass == hardCodedPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
