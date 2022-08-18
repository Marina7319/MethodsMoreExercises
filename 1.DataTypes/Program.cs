using System;

namespace _1.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int numberInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(printResult(numberInt));
                    break;
                case "real":
                    double numberDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(printResult(numberDouble));
                    break;
                case "string":
                    string inputText = Console.ReadLine();
                    Console.WriteLine(printResult(inputText));
                    break;
            }
        }
        static int printResult(int numberInt)
        {
            int sumInt = numberInt * 2;
            return sumInt;
        }
        static string printResult(double numberDouble)
        {
            double sumDouble = numberDouble * 1.5;
            string result = $"{sumDouble:f2}";
            return result;
        }
        static string printResult(string inputText)
        {
            string result = $"${inputText}$";
            return result;
        }
    }
}
