using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(x => x)
                .ToArray()));

           // int[] input = Console.ReadLine()
           //     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
           //     .Select(int.Parse)
           //     .Where(n => n % 2 == 0)
           //     .OrderBy(x => x)
           //     .ToArray();
           //
           // Console.WriteLine(string.Join(", ", input));

        }
    }
}
