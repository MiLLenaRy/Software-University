using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PringMiddleChars(input);
        }

        private static void PringMiddleChars(string input)
        {
            if (input.Length % 2 == 0)
            {
                //1234
                Console.WriteLine($"{input[input.Length / 2 - 1]}{input[input.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"{input[input.Length / 2]}");
            }
        }
    }
}
