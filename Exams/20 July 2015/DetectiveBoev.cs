using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveBoev // code 
    //  c o d e -> int stoinost na char +
{
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string cryptedMessage = Console.ReadLine();
            int mask = 100;
            int tempMask = 0;
            string result = "";
            // result=result+"our string" == our string, result=null; -- result=result+ "our string" --- null !!
            bool isDevidedWihoutReminder = true;

            for (int i = 0; i < secretWord.Length; i++)
            {
                tempMask = tempMask + (int) secretWord[i];
            }

            while (mask >= 10)
            {
                mask = 0;
                while (tempMask > 0)
                {
                    mask = mask + tempMask%10; // 441 ->1 .. 44->4 .. 4
                    tempMask = tempMask/10; //44 .. 4 .0  0 -> 12 3


                }
                if (mask >= 10 && tempMask == 0)
                {
                    tempMask = mask;
                }
            }

            int newCharValue = 0;

            for (int i = cryptedMessage.Length - 1; i >= 0; i--)
            {  
                if ((int)(cryptedMessage[i]) % mask == 0)
                {    
                    newCharValue = (int) cryptedMessage[i] + mask;

                    result = result + (char) newCharValue;
                }
                else
                {
                    newCharValue = (int) cryptedMessage[i] - mask;

                    result = result + (char) newCharValue;
                }

                newCharValue = 0;
            }
            Console.WriteLine(result);
        }
    }
}


        
    
