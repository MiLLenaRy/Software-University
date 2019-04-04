using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var pattern = @"\+359[ 2 ]{3}[0-9]{3}[ ][0-9]{4}|\+359[-2-]{3}[0-9]{3}[-][0-9]{4}\b";

            var matches = Regex.Matches(input, pattern);
            List<string> result = new List<string>();
            foreach (Match item in matches)
            {
                result.Add(item.Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
