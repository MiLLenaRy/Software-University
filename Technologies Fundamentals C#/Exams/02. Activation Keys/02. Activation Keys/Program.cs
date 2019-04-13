using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('&');

            string decript = @"[A-Za-z-0-9]{16,25}";
            var newCode = new StringBuilder();

            List<string> passwords = new List<string>();



            for (int a = 0; a < input.Length; a++)
            {
                Match cheker = Regex.Match(input[a], decript);

                if (input[a].Length == cheker.Length)
                {
                    passwords.Add(input[a]);
                }
            }

            for (int x = 0; x < passwords.Count; x++)
            {
                string word = passwords[x].ToUpper();

                for (int y = 0; y < word.Length; y++)
                {
                    if (word.Length == 16)
                    {
                        if (y % 4 == 0 && y != 0)
                        {
                            newCode.Append('-');
                        }
                        if (char.IsDigit(word[y]))
                        {
                            int number = word[y] - 48;
                            number = 9 - number;
                            newCode.Append(number);
                        }
                        else
                        {
                            newCode.Append(word[y]);
                        }
                    }
                    if (word.Length == 25)
                    {
                        if (y % 5 == 0 && y != 0)
                        {
                            newCode.Append('-');
                        }
                        if (char.IsDigit(word[y]))
                        {
                            int number = word[y] - 48;
                            number = 9 - number;
                            newCode.Append(number);
                        }
                        else
                        {
                            newCode.Append(word[y]);
                        }
                    }

                }
                if (passwords.Count - 1 != x)
                {
                    newCode.Append(", ");

                }
            }
            Console.WriteLine(newCode);
        }

    }
}

