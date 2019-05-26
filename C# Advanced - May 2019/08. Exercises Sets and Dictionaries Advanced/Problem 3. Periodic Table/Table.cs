using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3._Periodic_Table
{
    public class Tabke
    {
        public static void Main(string[] args)
        {
            var elements =new SortedSet<string>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var element in input)
                {
                    elements.Add(element);
                }
            }
            foreach (var item in elements)
            {
                Console.Write(item+" ");
            }
        }
    }
}
