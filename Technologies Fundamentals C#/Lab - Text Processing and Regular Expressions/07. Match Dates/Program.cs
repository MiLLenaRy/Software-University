using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var pattern = @"\b([0-9]{2})([-.\/])([A-Z][a-z]{2})\2([0-9]{4})\b";
            var matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine($"Day: {item.Groups[1]}, Month: {item.Groups[3]}, Year: {item.Groups[4]}");
            }
        }
    }
}
