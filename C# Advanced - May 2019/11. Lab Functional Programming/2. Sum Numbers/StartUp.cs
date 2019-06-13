using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    public class StartUp
    {
        class Delegates
        {
            public delegate string BinaryOperator(int x, int y);

            public static void Main(string[] args)
            {
                int[] input = Console.ReadLine()
                    .Split("," +
                    "", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Console.WriteLine(input.Count());
                Console.WriteLine(input.Sum());
            }


        }
    }
}
