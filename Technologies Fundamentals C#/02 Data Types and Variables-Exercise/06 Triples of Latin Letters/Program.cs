using System;

namespace _06_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                char firstChar = (char)('a' + i);
                for (int x = 0; x < number; x++)
                {
                    char secondChar = (char)('a' + x);
                    for (int y = 0; y < number; y++)
                    {
                        char tirtdChar = (char)('a' + y);
                        Console.WriteLine($"{firstChar}{secondChar}{tirtdChar}");
                    }
                }
            }
        }
        static void Second(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + number; i++)
            {
                for (char j = 'a'; j < 'a' + number; j++)
                {
                    for (char k = 'a'; k < 'a' + number; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
