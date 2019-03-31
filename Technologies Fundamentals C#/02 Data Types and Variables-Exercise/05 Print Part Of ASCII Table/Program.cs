using System;

namespace _05_Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int a = start; a <= end; a++)
            {
                Console.Write((char)a + " ");
            }
            Console.WriteLine();
        }
    }
}
