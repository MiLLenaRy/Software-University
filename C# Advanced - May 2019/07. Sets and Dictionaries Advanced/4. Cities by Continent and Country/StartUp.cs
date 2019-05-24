using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Cities_by_Continent_and_Country
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string continet = input[0];
                string country = input[1];
                string city = input[2];


                if (!dict.ContainsKey(continet))
                {
                    dict.Add(continet, new Dictionary<string, List<string>>());
                    dict[continet].Add(country, new List<string>());
                    dict[continet][country].Add(city);
                }
                else
                {
                    if (!dict[continet].ContainsKey(country))
                    {
                        dict[continet].Add(country, new List<string>());
                        dict[continet][country].Add(city);
                    }
                    else
                    {
                        dict[continet][country].Add(city);
                    }
                }
            }
            foreach (var continent in dict)
            {
                Console.WriteLine(continent.Key + ":");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine(country.Key + " -> " + string.Join(", ", country.Value));
                }
            }
        }
    }
}
