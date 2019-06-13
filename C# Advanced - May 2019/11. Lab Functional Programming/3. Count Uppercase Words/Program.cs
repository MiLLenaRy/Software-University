﻿using System;
using System.Linq;

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