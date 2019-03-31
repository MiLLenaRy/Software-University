using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            for (int i = command.Length - 1; i >= 0; i--)
            {
                Console.Write(command[i]);
            }
            Console.WriteLine();
        }
    }
}
