using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bigerRow = 1;
            int numberHolder = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                int counter = 1;
                for (int b = i + 1; b < numbers.Count; b++)
                {
                    if (numbers[i] == numbers[b])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                    if (counter > bigerRow)
                    {
                        bigerRow = counter;
                        numberHolder = numbers[i];
                    }

                }
            }
            int[] bestRow = new int[bigerRow];
            for (int max = 0; max < bigerRow; max++)
            {
                bestRow[max] = numberHolder;
            }
            Console.WriteLine(string.Join(' ', bestRow));
        }
    }
}
