using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split('|').ToList();

            int energy = 100;
            int coints = 100;
            int counter = 0;

            for (int a = 0; a < array.Count; a++)
            {
                string[] command = array[a].Split('-').ToArray();
                int cost = int.Parse(command[1]);
                counter++;

                if (energy < 0)
                {
                    energy += 50;
                    Console.WriteLine("You had to rest!");

                }
                else if (command[0] == "rest")
                {
                    if (energy + cost <= 100)
                    {
                        energy += cost;
                        Console.WriteLine($"You gained {cost} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                    else
                    {
                        int toFull = 100 - energy;
                        energy = 100;
                        Console.WriteLine($"You gained {toFull} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (command[0] == "order")
                {
                    if (energy >= 30)
                    {
                        coints += cost;
                        Console.WriteLine($"You earned {cost} coins.");
                        energy -= 30;
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    if (coints > cost)
                    {
                        coints -= cost;
                        Console.WriteLine($"You bought {command[0]}.");

                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command[0]}.");
                        return;
                    }

                }


            }
            if (counter == array.Count)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coints}");
                Console.WriteLine($"Energy: {energy}");
            }


        }
    }
}
