using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split().ToArray();
            string[] secondLine = Console.ReadLine().Split().ToArray();

            List<string> resoult = new List<string>();

            for (int a = 0; a < secondLine.Length; a++)
            {
                for (int b = 0; b < firstLine.Length; b++)
                {
                    if (secondLine[a] == firstLine[b])
                    {
                        resoult.Add(secondLine[a]);
                    }
                }
            }
            Console.WriteLine(string.Join(' ', resoult));
        }
    }
}
