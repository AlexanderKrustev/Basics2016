    using System;
    using System.Linq;

public class Program
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] inputArr=new int[input.Length];
            inputArr = input.Select(int.Parse).ToArray();
            int countOfRotates = int.Parse(Console.ReadLine());
            int[] result = new int[inputArr.Length];
            int[] rotatedTemp = new int[inputArr.Length];
            if (countOfRotates == 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                rotatedTemp = Rotate(inputArr);
                result = rotatedTemp;
              //  Console.WriteLine(string.Join(" ", result));
                for (int i = 1; i < countOfRotates; i++)
                {
                    rotatedTemp = Rotate(rotatedTemp);
                    result = Sum(result,rotatedTemp);
                   
                }
            Console.WriteLine(string.Join(" ", result));
        }
           // Console.WriteLine("-********Result********-");
            
        }

        public static int[] Rotate(int[] arr)
        {
            int[] rotatedArr = new int[arr.Length];

            rotatedArr[0] = arr[arr.Length - 1];

            for (int i = 1; i < arr.Length; i++)
            {
                rotatedArr[i] = arr[i-1];
            }

            return rotatedArr;
        }

        public static int[] Sum(int[] arr1, int[] arr2)
        {
        int[] sumArr = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                sumArr[i] = arr1[i] + arr2[i];
            }

            return sumArr;
        }
    }

