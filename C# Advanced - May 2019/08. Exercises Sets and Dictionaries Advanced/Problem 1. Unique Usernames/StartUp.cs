using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_1._Unique_Usernames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                usernames.Add(command);
            }
            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
