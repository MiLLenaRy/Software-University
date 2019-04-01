using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
            int bombIndex = -1;

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] == bomb)
                {
                    bombIndex = j;
                    for (int i = 1; i <= power; i++)
                    {
                        if (bombIndex > 0)
                        {
                            numbers.RemoveAt(bombIndex - 1);
                            bombIndex -= 1;
                        }
                        if (numbers.Count - 1 >= bombIndex + 1)
                        {
                            numbers.RemoveAt(bombIndex + 1);
                        }
                    }
                    numbers.RemoveAt(bombIndex);
                }
                bombIndex = -1;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    numbers.RemoveAt(i);
                }
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
