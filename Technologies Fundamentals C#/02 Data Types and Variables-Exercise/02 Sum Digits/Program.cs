using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int newNumber = number / 10;
            int lastNumber = number % 10;
            int sumNumber = 0;

            while (newNumber > 0)
            {
                sumNumber += lastNumber;
                lastNumber = newNumber % 10;
                newNumber = newNumber / 10;

            }
            sumNumber += lastNumber;

            Console.WriteLine(sumNumber);
        }
    }
}
