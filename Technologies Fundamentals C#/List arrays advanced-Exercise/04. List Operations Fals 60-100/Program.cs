using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations_Fals_60_100
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                AllTimeOfCommands(allNumbers, command);
            }
            Console.WriteLine(string.Join(' ', allNumbers));
        }

        private static void AllTimeOfCommands(List<int> allNumbers, string command)
        {
            string[] oneCommand = command.Split().ToArray();

            if (oneCommand[0] == "Add")
            {
                int toNumber = int.Parse(oneCommand[1]);

                allNumbers.Add(toNumber);
            }
            else if (oneCommand[0] == "Remove")
            {
                int toNumber = int.Parse(oneCommand[1]);
                if (toNumber >= 0 && toNumber < allNumbers.Count)
                {
                    allNumbers.RemoveAt(toNumber);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (oneCommand[0] == "Insert")
            {
                int toNumber = int.Parse(oneCommand[1]);
                int toIndex = int.Parse(oneCommand[2]);
                if (toIndex < allNumbers.Count && toIndex >= 0)
                {
                    allNumbers.Insert(toIndex, toNumber);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (oneCommand[0] == "Shift")
            {
                int toNumber = int.Parse(oneCommand[2]);

                if (oneCommand[1] == "left")
                {
                    for (int i = 0; i < toNumber; i++)
                    {
                        allNumbers.Add(allNumbers[0]);
                        allNumbers.RemoveAt(0);
                    }
                }
                else
                {
                    for (int i = 0; i < toNumber; i++)
                    {
                        int lastElement = allNumbers[allNumbers.Count - 1];
                        allNumbers.RemoveAt(allNumbers.Count - 1);
                        allNumbers.Insert(0, lastElement);
                    }
                }
            }
        }
    }
}
