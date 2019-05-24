using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1._Count_Same_Values_in_Array
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var dict = new Dictionary<double, double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    dict.Add(numbers[i], 1);
                }
                else
                {
                    dict[numbers[i]]++;
                    
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " - " + item.Value + " times");
            }
        }
    }
}
