using System;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] allNumber = new int[number];
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int newLine = int.Parse(Console.ReadLine());
                allNumber[i] = newLine;
                sum += newLine;
            }
            Console.WriteLine(string.Join(' ', allNumber));
            Console.WriteLine(sum);
        }
    }
}
