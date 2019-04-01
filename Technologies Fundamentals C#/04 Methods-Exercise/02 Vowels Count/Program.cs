using System;

namespace _02_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(VowelsCount(input));
        }

        private static int VowelsCount(string input)
        {
            int count = 0;  //a, i, o, u ,y, e

            string inputToLower = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {

                if (inputToLower[i] == 'a' ||
                    inputToLower[i] == 'i' ||
                    inputToLower[i] == 'o' ||
                    inputToLower[i] == 'u' ||
                    inputToLower[i] == 'y' ||
                    inputToLower[i] == 'e')

                {
                    count++;
                }

            }
            return count;
        }
    }
}
