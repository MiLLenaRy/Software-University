using System;
using System.Linq;

namespace _09_Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int sum = 0;
            int arrayNumber = 1;
            int bestDNA = 1;
            int maxSequence = 0;
            int startIndex = 1;
            int[] DNA = new int[length];

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                int[] array = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int sequence = 0;
                for (int index = 0; index < array.Length; index++)
                {
                    bool bestSequence = false;
                    if (array[index] == 1)
                    {
                        sequence++;
                    }
                    else
                    {
                        sequence = 0;
                    }

                    if (maxSequence < sequence)
                    {
                        bestSequence = true;
                    }
                    else if (maxSequence == sequence)
                    {
                        bool minStartIndex = (startIndex > index - sequence + 1);
                        bool sameLengthBiggerSum = (startIndex == index - sequence + 1) && array.Sum() > sum;

                        if (minStartIndex || sameLengthBiggerSum)
                        {
                            bestSequence = true;
                        }
                    }

                    if (bestSequence)
                    {
                        maxSequence = sequence;
                        bestDNA = arrayNumber;
                        startIndex = index - maxSequence + 1;
                        sum = array.Sum();
                        DNA = array;
                    }
                }
                arrayNumber++;
            }

            Console.WriteLine($"Best DNA sample {bestDNA} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}