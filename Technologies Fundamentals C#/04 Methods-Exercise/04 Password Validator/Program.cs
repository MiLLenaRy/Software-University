using System;

namespace _04_Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            bool isBetweenSixAndTenChars = StringLenghChecker(inputPassword);
            bool isOnlyLetterAndDigits = StringCharsChecker(inputPassword);
            bool haveAtLastTwoDigits = DigitsChecker(inputPassword);

            if (!isBetweenSixAndTenChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLetterAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!haveAtLastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isOnlyLetterAndDigits &&
                isBetweenSixAndTenChars &&
                haveAtLastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool DigitsChecker(string inputPassword)
        {
            int counter = 0;
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (char.IsDigit(inputPassword[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool StringCharsChecker(string inputPassword)
        {
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (!char.IsLetterOrDigit(inputPassword[i]))
                {
                    return false;
                }
            }
            return true;

        }

        private static bool StringLenghChecker(string inputPassword)
        {
            if (inputPassword.Length >= 6 && inputPassword.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
