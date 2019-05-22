using System;
using System.Linq;

namespace _4._Matrix_shuffling
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[dimension[0], dimension[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] text = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] array = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string word = array[0];
                if (word == "swap" && array.Length==5)
                {
                    int oldRow = int.Parse(array[1]);
                    int newRow = int.Parse(array[3]);
                    int oldCol = int.Parse(array[2]);
                    int newCol = int.Parse(array[4]);

                    if (matrix.GetLength(0) > newRow && matrix.GetLength(0) > oldRow
                        && matrix.GetLength(1) > newCol && matrix.GetLength(1) > oldCol)
                    {
                        string itemForSwap = matrix[oldRow, oldCol];
                        matrix[oldRow, oldCol] = matrix[newRow, newCol];
                        matrix[newRow, newCol] = itemForSwap;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
