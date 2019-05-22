using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._2x2_Squares_in_Matrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[dim[0], dim[1]];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] line = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    string item = matrix[row, col];
                    if (item == matrix[row + 1, col]
                        && item == matrix[row, col + 1]
                        && item == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
