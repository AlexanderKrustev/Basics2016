using System;

class MetricConverter
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string fromMetric = Console.ReadLine();
            string toMetric = Console.ReadLine();
            

            switch (fromMetric)
            {
            case "m":
                    break;
            case "mm":
                    number = number/1000d;
                    break;
            case "cm":
                    number = number/100d;
                    break;
            case "mi":
                    number = number/0.000621371192;
                    break;
            case "in":
                    number = number/39.3700787;
                    break;
            case "km":
                number = number / 0.001;
                break;
            case "ft":
                number = number / 3.2808399;
                break;
            case "yd":
                number = number / 1.0936133;
                break;
            default:
                    break;

            }

        switch (toMetric)
        {
            case "m":
                break;
            case "mm":
                number = number *1000d;
                break;
            case "cm":
                number = number *100d;
                break;
            case "mi":
                number = number * 0.000621371192;
                break;
            case "in":
                number = number * 39.3700787;
                break;
            case "km":
                number = number * 0.001;
                break;
            case "ft":
                number = number * 3.2808399;
                break;
            case "yd":
                number = number * 1.0936133;
                break;
            default:
                break;

        }
            Console.WriteLine("{0} {1}",number,toMetric);
        
    }
    }

