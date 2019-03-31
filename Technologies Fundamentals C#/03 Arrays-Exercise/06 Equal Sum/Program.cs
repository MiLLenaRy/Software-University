using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int a = 0; a < i; a++)
                {
                    leftSum += numbers[a];
                }
                for (int b = i + 1; b < numbers.Count; b++)
                {
                    rightSum += numbers[b];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
