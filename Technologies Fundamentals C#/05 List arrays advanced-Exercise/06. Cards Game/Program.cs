using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayer.Count != 0 || secondPlayer.Count != 0)
            {
                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    break;
                }
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                }
                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }
            int firstPlayerPoints = AllPointsFirstPlayer(firstPlayer);
            int secondPlayersPoints = AllPOintsSecondPlayer(secondPlayer);
            if (firstPlayerPoints > secondPlayersPoints)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerPoints}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayersPoints}");

            }
        }

        private static int AllPOintsSecondPlayer(List<int> secondPlayer)
        {
            int points = 0;
            foreach (var item in secondPlayer)
            {
                points += item;
            }
            return points;
        }

        private static int AllPointsFirstPlayer(List<int> firstPlayer)
        {
            int points = 0;
            foreach (var item in firstPlayer)
            {
                points += item;
            }
            return points;
        }
    }
}
