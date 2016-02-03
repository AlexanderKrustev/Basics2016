using System;

class BonusScore
{
   static void Main()
   {
       double score = double.Parse(Console.ReadLine());
       double bonus1 = 0;
       double bonus2 = 0;
       if (score <= 100)
       {
           bonus1 += 5;
       }
       else if (score > 1000)
       {
           bonus1 += score*0.1;
       }
       else if (score > 100)
       {
            bonus1 += score * 0.2;
        }

       if (score %2  == 0)
       {
           bonus2 += 1;
       }
       if (score%10 == 5)
       {
            bonus2 += 2;
        }

       Console.WriteLine("Bonus score: {0}", bonus1+bonus2);
       Console.WriteLine("Total score: {0}", bonus1 + bonus2+score);
   }
}

