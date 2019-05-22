using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Diagonal_Difference
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[,] matrix = new int[number, number];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int count = 0;
                int[] tokens = Console.ReadLine()
                    .Split().Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = tokens[count];
                    count++;
                }
            }

            int firstSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        firstSum += matrix[row, col];
                        break;
                    }
                }
            }
            int secondSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == number - 1 && col == 0)
                    {
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            secondSum += matrix[i, number - 1];
                            number -= 1;
                        }
                        break;
                    }
                }
            }
            if (secondSum > firstSum)
            {
                Console.WriteLine(secondSum - firstSum);
            }
            else
            {
                Console.WriteLine(firstSum - secondSum);
            }
        }
    }
}
