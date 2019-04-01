using System;

namespace _05_Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sumOfTwoNumbers = SumFirstAndSecondNumber(first, second);
            MinusThurtNumber(sumOfTwoNumbers, third);
            Console.WriteLine(MinusThurtNumber(sumOfTwoNumbers, third));
        }

        private static int MinusThurtNumber(int sumOfTwoNumbers, int thurd)
        {
            return sumOfTwoNumbers - thurd;
        }

        private static int SumFirstAndSecondNumber(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
    }
}
