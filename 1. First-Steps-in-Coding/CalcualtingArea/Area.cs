using System;

class Area
{
    static void Main()
    {
        Console.WriteLine("Please enter the first parametar below:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second parametar below");
        double b = double.Parse(Console.ReadLine());
        double area = a*b;
        Console.WriteLine(area);
    }
}
