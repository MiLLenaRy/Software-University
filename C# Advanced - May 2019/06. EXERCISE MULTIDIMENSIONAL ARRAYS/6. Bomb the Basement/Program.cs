using System;
using System.Linq;

namespace _6._Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            int[][] basament = new int[rows][];

            for (int i = 0; i < basament.Length; i++)
            {
                basament[i] = new int[cols];
            }

            int[] coordinates = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = coordinates[0];
            int tardgetCol = coordinates[1];
            int radius = coordinates[2];

            for (int row = 0; row < basament.Length; row++)
            {
                for (int col = 0; col < basament[row].Length; col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - tardgetCol, 2) <= Math.Pow(radius, 2);
                    if (isInRadius)
                    {
                        basament[row][col] = 1;
                    }
                }
            }

            int counter = 0;
            int countOfNum = 0;
            for (int row = 0; row < basament.Length; row++)
            {
                if (basament[row][counter] == 1)
                {
                    countOfNum++;
                }
            }
        }
    }
}
