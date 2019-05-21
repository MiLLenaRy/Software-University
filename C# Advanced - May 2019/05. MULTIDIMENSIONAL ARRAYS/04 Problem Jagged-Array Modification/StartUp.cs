using System;
using System.Linq;

namespace _04_Problem_Jagged_Array_Modification
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rowSize][];

            for (int row = 0; row < rowSize; row++)
            {
                int[] col = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = col;
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens =command
                    .Split()
                    .ToArray();
                string operation = tokens[0].ToLower();
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0
                    || row >= rowSize
                    || col < 0
                    || col >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (operation)
                {
                    case "add":
                        matrix[row][col] += value;
                        break;
                    case "subtract":
                        matrix[row][col] -= value;
                        break;
                    default:
                        break;

                }
                
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}
