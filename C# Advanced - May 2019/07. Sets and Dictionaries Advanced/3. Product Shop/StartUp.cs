using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3._Product_Shop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command;
            var dict = new Dictionary<string, Dictionary<string, double>>();

            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] magazinsInfo = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = magazinsInfo[0];
                string product = magazinsInfo[1];
                double price = double.Parse(magazinsInfo[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<string, double>());
                    dict[name].Add(product, price);
                }
                else
                {
                    dict[name].Add(product, price);
                }
            }
            foreach (var shop in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine(shop.Key + "->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }





            }
        }
    }
}
