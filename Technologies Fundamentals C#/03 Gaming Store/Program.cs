using System;
using System.Collections.Generic;

namespace _3._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double allMoney = money;
            string command;

            List<string> allGames = new List<string> { "OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition" };
            double[] allGamePrice = { 39.99, 15.99, 19.99, 59.99, 29.99, 39.99 };

            while ((command = Console.ReadLine()) != "Game Time")
            {
                int count = 0;
                for (int a = 0; a < allGames.Count; a++)
                {
                    if (command == allGames[a])
                    {
                        if (money >= allGamePrice[a])
                        {
                            money -= allGamePrice[a];
                            Console.WriteLine($"Bought {allGames[a]}");
                            if (money == 0)
                            {
                                Console.WriteLine("Out of money!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                    }
                    else
                    {

                        if (allGames[a] != command)
                        {
                            count++;
                            if (count == allGames.Count)
                            {
                                Console.WriteLine("Not Found");
                            }
                        }

                    }
                }
            }
            if (money != 0)
            {
                Console.WriteLine($"Total spent: ${allMoney - money:F2}. Remaining: ${money:F2}");
            }

        }
    }
}
