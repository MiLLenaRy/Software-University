using System;
using System.Linq;

namespace _02_Problem_Sum_Matrix_Columns
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
            
            for (int row = 0; row < array.GetLength(0); row++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = tokens[col];
                }
            }
            
            for (int col = 0; col < array.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    sum += array[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
