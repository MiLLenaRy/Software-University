using System;

namespace _09_Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = string.Empty;
            while (flag != "END")
            {
                flag = Console.ReadLine();
                if (flag == "END")
                {
                    break;
                }
                int number = int.Parse(flag);
                Palindrome(number);
            }
        }

        static void Palindrome(int n)
        {
            int newNumber = n;
            int lastDigit;
            int firstDigit;
            bool flag = true;

            while (newNumber != 0 && flag)
            {
                lastDigit = newNumber % 10;
                firstDigit = newNumber;
                while (firstDigit >= 10)
                {
                    firstDigit /= 10;
                }
                if (lastDigit != firstDigit)
                {
                    flag = false;
                }
                newNumber /= 10;
                newNumber %= 10;
            }
            if (flag)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
