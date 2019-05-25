using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _5._Record_Unique_Names
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (int i = 0; i < rows; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
