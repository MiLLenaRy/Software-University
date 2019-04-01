using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guest = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                //Allie is going!
                if (tokens.Length == 3)
                {
                    if (!guest.Contains(tokens[0]))
                    {
                        guest.Add(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                }
                //else
                //John is not going!
                else if (tokens.Length == 4)
                {
                    if (guest.Contains(tokens[0]))
                    {
                        guest.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
            }
            foreach (var person in guest)
            {
                Console.WriteLine(person);
            }
        }
    }
}
