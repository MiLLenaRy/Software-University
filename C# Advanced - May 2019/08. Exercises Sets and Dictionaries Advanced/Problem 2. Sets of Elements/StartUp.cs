using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2._Sets_of_Elements
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firstNumber = new HashSet<int>();
            var secondNumber = new HashSet<int>();

            int number;

            int[] count = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < count[0]; i++)
            {
                number = int.Parse(Console.ReadLine());
                firstNumber.Add(number);
            }
            for (int i = 0; i < count[1]; i++)
            {
                number = int.Parse(Console.ReadLine());
                secondNumber.Add(number);
            }

            foreach (var num in firstNumber)
            {
                if (secondNumber.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
