using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string other = string.Empty;

            for (int a = 0; a < line.Length; a++)
            {
                char toChar = line[a];
                if (char.IsDigit(toChar))
                {
                    digits += toChar;
                }
                else if (char.IsLetter(toChar))
                {
                    letters += toChar;
                }
                else
                {
                    other += toChar;
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
