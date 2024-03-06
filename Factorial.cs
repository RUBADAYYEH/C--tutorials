using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Try again with adding an argument int");
            }
            else
            {
                int num;
                bool test = int.TryParse(args[0], out num);
                if (!test)
                {
                    Console.WriteLine("Please enter a numeric argument.");
                    Console.WriteLine("Usage: Factorial <num>");
                }
                else
                {

                    long result = GetFactorial(num);
                    if (result == -1)
                    {
                        Console.WriteLine("Input must be >= 0 and <= 20.");

                    }
                    Console.WriteLine($"The Factorial of {num} is {result}.");
                }
            }
        }

        private static long GetFactorial(int num)
        {
            if (num < 0 || num > 20)
            {
                return -1;
            }
            else
            {
                long result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
                return result;
            }

        }
    }
}
