using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                array.Add(array[0]);
                array.RemoveAt(0);
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
