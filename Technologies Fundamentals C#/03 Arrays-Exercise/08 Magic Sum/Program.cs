using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = int.Parse(Console.ReadLine());

            for (int a = 0; a < numbers.Count; a++)
            {
                int sumNumbers = numbers[a];
                for (int b = a + 1; b < numbers.Count; b++)
                {
                    sumNumbers += numbers[b];
                    if (sumNumbers == sum)
                    {
                        Console.WriteLine($"{numbers[a]} {numbers[b]}");
                        sumNumbers = numbers[a];
                    }
                    else
                    {
                        sumNumbers = numbers[a];
                    }
                }
            }
        }
    }
}
