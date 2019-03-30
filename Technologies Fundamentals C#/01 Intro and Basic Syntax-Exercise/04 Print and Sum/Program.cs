using System;

namespace _04_Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int a = firstNumber; a <= lastNumber; a++)
            {
                Console.Write(a + " ");
                sum += a;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
