using System;using System.Collections.Generic;using System.IO;using System.IO.Compression;
using System.Linq;using System.Text;using System.Text.RegularExpressions;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.ToCharArray()[0] >= 'A' && x.ToCharArray()[0] <= 'Z')
                .ToArray();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
