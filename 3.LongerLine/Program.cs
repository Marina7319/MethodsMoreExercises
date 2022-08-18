using System;

namespace _3.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double c1 = printClosestPoint(x1, y1);
            double c2 = printClosestPoint(x2, y2);
            double c3 = printClosestPoint(x3, y3);
            double c4 = printClosestPoint(x4, y4);
            double resultOne = 0;
            double resultTwo = 0;
            if (c1 >= c2)
            {
                resultOne = printClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                resultOne = printClosestPoint(x2, y2, x1, y1);
            }
            if (c3 >= c4)
            {
                resultTwo = printClosestPoint(x3, y3, x4, y4);
            }
            else
            {
                resultTwo = printClosestPoint(x4, y4, x3, y3);
            }
            if (resultOne > resultTwo)
            {
                if (c1 <= c2)
                {
                    Console.WriteLine(printResult(x1, y1, x2, y2));
                }
                else
                {
                    Console.WriteLine(printResult(x2, y2, x1, y1));
                }
            }
            else
            {
                if (c3 <= c4)
                {
                    Console.WriteLine(printResult(x3, y3, x4, y4));
                }
                else
                {
                    Console.WriteLine(printResult(x4, y4, x3, y3));
                }
            }
        }
        static string printResult(double num1, double num2, double num3, double num4)
        {
            string result = $"({num1}, {num2})({num3}, {num4})";
            return result;
        }
        private static double printClosestPoint(double numOne, double numTwo)
        {
            double result = Math.Sqrt(numOne * numOne + numTwo * numTwo);
            return result;
        }
        static double printClosestPoint(double numOne, double numTwo, double numTree, double numFour)
        {
            double width = numOne - numTree;
            double hight = numTwo - numFour;
            double len = Math.Sqrt(width * width + hight * hight);
            double resultOne = len;
            return resultOne;
        }
    }
}

