using System;

namespace _06_Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalNumber = int.Parse(Console.ReadLine());
            int number = originalNumber;
            int sumNumber = 0; ;
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                int currentNumber = 1;

                for (int i = 2; i <= lastDigit; i++)
                {
                    currentNumber *= i;
                }
                sumNumber += currentNumber;
            }
            if (originalNumber == sumNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
