using System;
using System.Linq;

namespace _03_Problem_Square_with_Maximum_Sum
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
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = tokens[col];
                }
            }

            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 1; col++)
                {
                    int sum = array[row, col] + array[row, col + 1]
                            + array[row + 1, col] + array[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }
            }

            Console.WriteLine($"{array[selectedRow,selectedCol]} {array[selectedRow,selectedCol+1]}\n{array[selectedRow+1,selectedCol]}" +
                              $" {array[selectedRow+1,selectedCol+1]}\n{maxSum}");
        }
    }
}

