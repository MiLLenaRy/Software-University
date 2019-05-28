using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_6._Wardrobe
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var allClothers = new Dictionary<string, Dictionary<string, int>>();

            List<string> commad;

            for (int i = 0; i < n; i++)
            {
                commad = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string color = commad[0];

                string[] clothers = commad[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!allClothers.ContainsKey(color))
                {
                    allClothers.Add(color, new Dictionary<string, int>());
                    for (int y = 0; y < clothers.Length; y++)
                    {
                        if (!allClothers[color].ContainsKey(clothers[y]))
                        {
                            allClothers[color].Add(clothers[y], 0);
                        }
                        allClothers[color][clothers[y]]++;
                    }
                }
                else
                {
                    for (int y = 0; y < clothers.Length; y++)
                    {
                        if (!allClothers[color].ContainsKey(clothers[y]))
                        {
                            allClothers[color].Add(clothers[y], 0);
                        }
                        allClothers[color][clothers[y]]++;

                    }
                }

            }
            string[] find = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string bestColor = find[0];
            string clother = find[1];

            foreach (var color in allClothers)
            {
                Console.WriteLine(color.Key + " clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == bestColor && item.Key == clother)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }

                }
            }

        }
    }
}

