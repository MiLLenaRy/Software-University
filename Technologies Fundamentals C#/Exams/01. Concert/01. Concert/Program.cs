using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            var dict = new Dictionary<string, List<string>>();
            var groupAndTime = new Dictionary<string, int>();

            while ((command = Console.ReadLine()) != "start of concert")
            {
                string[] array = command.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (array[0] == "Play")
                {
                    string bandName = array[1];
                    int time = int.Parse(array[2]);
                    if (!groupAndTime.ContainsKey(bandName))
                    {
                        groupAndTime.Add(bandName, time);
                    }
                    else
                    {
                        groupAndTime[bandName] += time;
                    }
                    if (!dict.ContainsKey(bandName))
                    {
                        dict.Add(bandName, new List<string>());
                    }
                }
                else if (array[0] == "Add")
                {
                    string bandName = array[1];
                    List<string> allArtists = array[2].Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

                    for (int i = 0; i < allArtists.Count; i++)
                    {
                        if (!dict.ContainsKey(bandName))
                        {
                            dict.Add(bandName, new List<string>());
                        }
                        if (!dict[bandName].Contains(allArtists[i]))
                        {
                            dict[bandName].Add(allArtists[i]);
                        }
                    }
                }
            }
            string theBestGroup = Console.ReadLine();

            //all time
            BigInteger allTime = 0;
            foreach (var item in groupAndTime)
            {
                allTime += item.Value;
            }
            Console.WriteLine($"Total time: {allTime}");
            // all groups and time
            foreach (var item in groupAndTime.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine(theBestGroup);
            foreach (var item in dict[theBestGroup])
            {
                Console.WriteLine($"=> {item}");
            }
        }
    }
}
