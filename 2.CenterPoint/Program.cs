using System;

namespace _2.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double c1 = pointCordinates(x1, y1);
            double c2 = pointCordinates(x2, y2);
            if (c1 <= c2)
            {
                printResult(x1, y1);
            }
            else
            {
                printResult(x2, y2);
            }
        }
        private static void printResult(double numOne, double numTwo)
        {
            Console.WriteLine($"({numOne}, {numTwo})");
        }
        private static double pointCordinates(double numberOne, double numberTwo)
        {
            double result = Math.Sqrt(numberOne * numberOne + numberTwo * numberTwo);
            return result;
        }
    }
}
