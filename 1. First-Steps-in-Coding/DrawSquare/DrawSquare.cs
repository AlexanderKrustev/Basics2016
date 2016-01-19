using System;

class DrawSquare
{
    static void Main()
    {
        Console.WriteLine("Please enter the number below:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', n));

        for (int i = 0; i <= n-2; i++)
        {
            Console.Write("*");
            Console.Write(new string(' ',n-2));
            Console.Write("*");
            Console.WriteLine();
        }

        Console.WriteLine(new string('*', n));
    }
}
