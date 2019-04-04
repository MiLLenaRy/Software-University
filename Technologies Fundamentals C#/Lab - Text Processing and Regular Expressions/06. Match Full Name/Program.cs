using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+\b)";
            var everyName = Regex.Matches(input, pattern);

            foreach (var item in everyName)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
           
        }
    }
}
