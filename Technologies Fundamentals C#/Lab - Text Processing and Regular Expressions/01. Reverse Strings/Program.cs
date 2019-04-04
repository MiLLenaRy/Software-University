using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word!="end")
            {
                string revesedWord = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)              
                {
                    revesedWord += word[i];
                }
                Console.WriteLine($"{word} = {revesedWord}");
                word = Console.ReadLine();
            }
        }
    }
}
