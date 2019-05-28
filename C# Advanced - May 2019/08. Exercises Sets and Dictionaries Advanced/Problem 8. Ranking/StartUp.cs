using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_8._Ranking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var allExams = new Dictionary<string, string>();
            string command;

            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] examInfo = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string leson = examInfo[0];
                string passord = examInfo[1];
                if (!allExams.ContainsKey(leson))
                {
                    allExams.Add(leson, passord);
                }

            }

            var resoults = new Dictionary<string, Dictionary<string, int>>();

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] splitCommand = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string leson = splitCommand[0];
                string password = splitCommand[1];
                string username = splitCommand[2];
                int points = int.Parse(splitCommand[3]);

                if (allExams.ContainsKey(leson))
                {
                    if (allExams[leson].Contains(password))
                    {
                        if (!resoults.ContainsKey(username))
                        {
                            resoults.Add(username, new Dictionary<string, int>());
                        }
                        if (!resoults[username].ContainsKey(leson))
                        {
                            resoults[username].Add(leson, points);
                        }

                        int pointsOnThisLeson = resoults[username][leson];
                        if (points > pointsOnThisLeson)
                        {
                            resoults[username][leson] = points;
                        }

                    }
                }

            }

            // Write
            var sortedByName = resoults.OrderBy(name => name.Key);

            int bestPoints = 0;
            string bestName = string.Empty;

            foreach (var item in sortedByName)
            {
                if (item.Value.Values.Sum() > bestPoints)
                {
                    bestPoints = item.Value.Values.Sum();
                    bestName = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestName} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var name in sortedByName)
            {
                Console.WriteLine(name.Key);

                foreach (var item in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
