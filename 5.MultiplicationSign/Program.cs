using System;

namespace _5.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double negatives = negativesCount(num1, num2, num3);
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine(printResult(num1, num2, num3));
            }
            else if (negatives == 0 || negatives == 2)
            {
                Console.WriteLine(printResult("positive"));
            }
            else
            {
                Console.WriteLine(printResult("negative"));
            }
        }

        private static string printResult(string v)
        {
            return v;
        }

        static string printResult(double num1, double num2, double num3)
        {
            string result = "zero";
            return result;
        }

        static double negativesCount(double numOne, double numTwo, double numTree)
        {
            int countNegatives = 0;
            if (numOne < 0)
            {
                countNegatives++;
            }
            if (numTwo < 0)
            {
                countNegatives++;
            }
            if (numTree < 0)
            {
                countNegatives++;
            }
            return countNegatives;
        }
    }
}
