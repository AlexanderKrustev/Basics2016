using System;
class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            double a = 0;
            double b = 0;
            double r = 0;
            double h = 0;
            double area = 0;
            if (typeOfFigure == "square")
            {
                a = double.Parse(Console.ReadLine());
                area = a*a;

            }
            else if (typeOfFigure == "rectangle")
            {
                 a = double.Parse(Console.ReadLine());
                 b = double.Parse(Console.ReadLine());
                 area = a * b;
            }
            else if (typeOfFigure == "circle")
            {
                 r = double.Parse(Console.ReadLine());
                 area = Math.PI*r*r;
            }
            else if (typeOfFigure == "triangle")
            {
               a = double.Parse(Console.ReadLine());
               h = double.Parse(Console.ReadLine());
               area = (a * h)/2.0;
            }
            Console.WriteLine("{0:f3}",Math.Round(area,3));
        }
    }
