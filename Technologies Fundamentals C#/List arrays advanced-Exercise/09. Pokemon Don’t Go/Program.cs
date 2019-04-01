using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToList();
            int finalSum = 0;
            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int number = 0;
                if (index < 0)
                {
                    number = input[0];
                    input[0] = input[input.Count - 1];
                }
                else if (index > input.Count - 1)
                {
                    number = input[input.Count - 1];
                    input[input.Count - 1] = input[0];
                }
                else
                {
                    number = input[index];
                    input.RemoveAt(index);
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= number)
                    {
                        input[i] += number;
                    }
                    else
                    {
                        input[i] -= number;
                    }
                }
                finalSum += number;
            }
            Console.WriteLine(finalSum);
        }
    }
}
