using System;

namespace _04_Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());

            int sumChars = 0;

            for (int i = 1; i <= counts; i++)
            {
                char sum = char.Parse(Console.ReadLine());
                sumChars += sum;
            }
            Console.WriteLine($"The sum equals: {sumChars}");
        }
    }
}
