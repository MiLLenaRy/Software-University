using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Vapor_Winter_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split(", ").ToList();

            var gameAndPrice = new Dictionary<string,double>();
            var gameAndDLC = new Dictionary<string, string>();

            for (int a = 0; a < command.Count; a++)
            {
                if (command[a].Contains(':'))
                {
                    string[] split = command[a].Split(':');
                    string nameOfGame = split[0];
                    string DLC = split[1];
                    if (gameAndPrice.ContainsKey(nameOfGame))
                    {
                        gameAndDLC.Add(nameOfGame,DLC);

                        double increasedPrice = gameAndPrice[nameOfGame] *1.2;
                        //if decimal 1.20m
                        gameAndPrice[nameOfGame] = increasedPrice;
                        
                    }
                }
                else
                {
                    string[] split = command[a].Split('-');
                    string nameOfGame = split[0];
                    double price = double.Parse(split[1]);
                    if (!gameAndPrice.ContainsKey(nameOfGame))
                    {
                        gameAndPrice.Add(nameOfGame, price);
                    }
                }      
            }
            var gamesAndLowerPriceWithoutDlc = new Dictionary<string, double>();
            var gamesAndLowerPriceWithDlc = new Dictionary<string, double>();

            foreach (var game in gameAndPrice)
            {
                string gameName = game.Key;
                double price = game.Value;

                if (!gameAndDLC.ContainsKey(gameName))
                {
                    double lowerPrice = price - (price * 0.2);
                    gamesAndLowerPriceWithoutDlc.Add(gameName, lowerPrice);
                }
                else
                {
                    double lowerPrice = price - (price * 0.5);
                    gamesAndLowerPriceWithDlc.Add(gameName, lowerPrice);
                }
            }
            foreach (var kvp in gamesAndLowerPriceWithDlc.OrderBy(x=>x.Value))
            {
                string name = kvp.Key;
                double price = kvp.Value;
                Console.WriteLine($"{name} - {gameAndDLC[kvp.Key]} - {price:f2}");
            }
            foreach (var kvp in gamesAndLowerPriceWithoutDlc.OrderByDescending(x=>x.Value))
            {
                string name = kvp.Key;
                double price = kvp.Value;
                Console.WriteLine($"{name} - {price:F2}");
            }

        }
    }
}
