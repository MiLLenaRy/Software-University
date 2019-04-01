using System;

namespace _08_Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());

            long firstNUmberFactorial = GetFactorial(firstNumber);
            long secondNUmberFactorial = GetFactorial(secondNumber);

            double finalResult = (double)firstNUmberFactorial / secondNUmberFactorial;
            Console.WriteLine($"{ finalResult:F2}");
        }

        private static long GetFactorial(long number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
