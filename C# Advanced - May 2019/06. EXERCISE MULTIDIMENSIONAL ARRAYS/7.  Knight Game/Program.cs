using System;

namespace _7.__Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            char[,] board = new char[dimension, dimension];
            int[] indexes = new int[]
            {
                1,2,
                1,-2,
               -1,2,
               -1,-2,
                2,1,
                2,-1,
               -2,1,
               -2,-1,
            };

            for (int row = 0; row < dimension; row++)
            {
                string kinghtMove = Console.ReadLine();
                for (int col = 0; col < dimension; col++)
                {
                    board[row, col] = kinghtMove[col];
                }
            }

            int counter = 0;
            while (true)
            {
                int maxCount = 0;
                int knightsRow = 0;
                int knightsCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int curentCount = 0;
                        if (board[row, col] == 'K')
                        {
                            for (int i = 0; i < indexes.Length; i += 2)
                            {

                                if (IsInsite(board, row + indexes[i], col + indexes[i + 1])
                                    && board[row + indexes[i], col + indexes[i + 1]] == 'K')
                                {
                                    curentCount++;
                                }
                            }


                        }
                        if (curentCount > maxCount)
                        {
                            maxCount = curentCount;
                            knightsRow = row;
                            knightsCol = col;

                        }
                    }
                }
                if (maxCount == 0)
                {
                    break;
                }

                board[knightsRow, knightsCol] = '0';
                counter++;
            }
            Console.WriteLine(counter);
        }

        private static bool IsInsite(char[,] board, int diseredRow, int diseredCol)
        {
            return diseredRow < board.GetLength(0)
                 && diseredRow >= 0
                 && diseredCol < board.GetLength(1)
                 && diseredCol >= 0;
        }
    }
}
