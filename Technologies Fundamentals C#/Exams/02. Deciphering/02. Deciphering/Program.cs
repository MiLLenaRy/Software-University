using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string decript = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ').ToArray();

            StringBuilder resoult = new StringBuilder();
            for (int a = 0; a < decript.Length; a++)
            {
                if (decript[a]>='d' && decript[a]<'~' || decript[a] == '#')
                {
                    resoult.Append((char)(decript[a] - 3));
                }
                else
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
            }
            resoult.Replace(words[0], words[1]);
            Console.WriteLine(resoult);
        }
    }
}
