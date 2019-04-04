using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            string stringToLower = firstLine.ToLower();
            while (secondLine.Contains(stringToLower))
            {
                int startIndex = secondLine.IndexOf(stringToLower);
                secondLine = secondLine.Remove(startIndex, firstLine.Length);
            }
            Console.WriteLine(secondLine);
        }
    }
}
