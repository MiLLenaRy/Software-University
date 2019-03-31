using System;
using System.Collections.Generic;

namespace _1._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            List<int> allNumbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                allNumbers.Add(numbers);
            }
            allNumbers.Sort();
            allNumbers.Reverse();
            foreach (var item in allNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
