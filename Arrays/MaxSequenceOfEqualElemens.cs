using System;
using System.Collections.Generic;
using System.Linq;

    class MaxSequenceOfEqualElemens
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            input = Console.ReadLine().
                Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> temp = new List<int>();
            List<int> finalResut=new List<int>();
            temp.Add(input[0]); //initialize the first element on the first subseq
            for (int i = 1; i < input.Count; i++) // iterate over input
            {
                if (input[i] == temp[temp.Count-1]) // if the current element == with the previous one 
                {                                   // we add the current one in temp list
                    temp.Add(input[i]);
                }
                else // if the seq is over start check if it is max seq
                {
                    if (temp.Count > finalResut.Count) //if temp has more items than the final list, opy temp to final
                    {
                        finalResut.Clear(); // clear the old result

                        for (int j = 0; j < temp.Count; j++)
                        {
                           finalResut.Add(temp[j]);  // copy temp to final
                        }
                        temp.Clear(); // clear them we already have temp into the result
                        temp.Add(input[i]); // initialize the next element on temp
                    }
                    else
                    {
                        temp.Clear(); // if the current seq is over and it does not have more elements that the previous checked seq we clear it
                        temp.Add(input[i]); // initialize the next element on temp
                    }
                }
            }
            Console.WriteLine(string.Join(" ",finalResut));
        }
    }

