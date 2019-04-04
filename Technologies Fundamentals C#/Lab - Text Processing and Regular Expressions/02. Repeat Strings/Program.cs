using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();

            foreach (var word in line)
            {
                int lenght = word.Length;
                for (int a = 1; a <= lenght; a++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}
