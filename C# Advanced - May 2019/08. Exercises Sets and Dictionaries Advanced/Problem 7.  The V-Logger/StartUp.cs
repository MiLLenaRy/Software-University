using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_7.__The_V_Logger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command;

            var vLoggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] input = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string vlogerName = input[0];
                string reson = input[1];

                if (reson == "joined")
                {
                    if (!vLoggers.ContainsKey(vlogerName))
                    {
                        vLoggers.Add(vlogerName, new Dictionary<string, HashSet<string>>());
                        vLoggers[vlogerName].Add("following", new HashSet<string>());
                        vLoggers[vlogerName].Add("followers", new HashSet<string>());
                    }
                }
                else
                {
                    string folowUsername = input[2];
                    if (vlogerName != folowUsername
                        && vLoggers.ContainsKey(vlogerName)
                        && vLoggers.ContainsKey(folowUsername))
                    {
                        vLoggers[folowUsername]["followers"].Add(vlogerName);
                        vLoggers[vlogerName]["following"].Add(folowUsername);

                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vLoggers.Keys.Count} vloggers in its logs.");

            int counter = 0;

            var sortedVlogers = vLoggers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count)
                .ToDictionary(k => k.Key, y => y.Value);

            foreach (var (username, value) in sortedVlogers)
            {
                counter++;
                int followersCount = sortedVlogers[username]["followers"].Count;
                int followingsCount = sortedVlogers[username]["following"].Count;

                Console.WriteLine($"{counter}. {username} : {followersCount} followers, {followingsCount} following");
                if (counter == 1)
                {
                    var followersCollection = value["followers"].OrderBy(x => x).ToList();

                    foreach (var followerName in followersCollection)
                    {
                        Console.WriteLine("*  " + followerName);
                    }
                }
            }
        }
    }
}

