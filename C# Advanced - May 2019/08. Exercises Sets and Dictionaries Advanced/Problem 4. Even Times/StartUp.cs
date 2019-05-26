using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_4._Even_Times
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = new Dictionary<int, int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }

            foreach (var number in numbers.Where(num => num.Value % 2 == 0))
            {
                Console.WriteLine(number.Key);
            }

        }
    }
}
