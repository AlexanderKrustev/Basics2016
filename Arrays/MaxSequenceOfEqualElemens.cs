using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElemens
{
    class Program
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
            temp.Add(input[0]);
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == temp[temp.Count-1])
                {
                    temp.Add(input[i]);
                }
                else
                {
                    if (temp.Count > finalResut.Count)
                    {
                        finalResut.Clear();
                        for (int j = 0; j < temp.Count; j++)
                        {
                           finalResut.Add(temp[j]); 
                        }
                        temp.Clear();
                        temp.Add(input[i]);
                    }
                    else
                    {
                        temp.Clear();
                        temp.Add(input[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",finalResut));
        }
    }
}
