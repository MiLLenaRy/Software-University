using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<int> firstLongLine = new List<int>(lines);
            List<int> secondLongLine = new List<int>(lines);

            for (int i = 0; i < lines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 1)
                {
                    firstLongLine.Add(numbers[1]);
                    secondLongLine.Add(numbers[0]);
                }
                else
                {
                    firstLongLine.Add(numbers[0]);
                    secondLongLine.Add(numbers[1]);
                }
            }
            Console.WriteLine(string.Join(' ', firstLongLine));
            Console.WriteLine(string.Join(' ', secondLongLine));
        }
    }
}
