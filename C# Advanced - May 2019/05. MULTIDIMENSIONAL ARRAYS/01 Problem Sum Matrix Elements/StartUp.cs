using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01_Problem_Sum_Matrix_Elements
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] array = new int[dim[0], dim[1]];
            int sum = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = tokens[col];
                    sum += tokens[col];
                }
            }

            Console.WriteLine(array.GetLength(0));
            Console.WriteLine(array.GetLength(1));
            

            Console.WriteLine(sum);


        }
    }
}
