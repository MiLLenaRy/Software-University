using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> allNumber = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int counter = i + 1;
                int bigerNumber = numbers[i];
                if (counter == numbers.Count)
                {
                    allNumber.Add(numbers[i]);
                }
                for (int a = i + 1; a < numbers.Count; a++)
                {
                    if (counter == numbers.Count)
                    {
                        allNumber.Add(numbers[i]);
                    }
                    else if (bigerNumber > numbers[a])
                    {
                        counter++;
                    }
                    if (counter == numbers.Count)
                    {
                        allNumber.Add(numbers[i]);
                    }

                }
            }


            Console.WriteLine(string.Join(' ', allNumber));
        }
    }
}
