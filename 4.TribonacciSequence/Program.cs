using System;

namespace _4.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printNums(n);
        }
        private static void printNums(int num)
        {
            int sum = 1;
            for (int i = 0; i < num; i++)
            {
                Console.Write(sum + " ");
                sum += i;

            }
        }
    }
}
