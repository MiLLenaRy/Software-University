using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int a = username.Length - 1; a >= 0; a--)
            {
                password += username[a];
            }

            string input;
            int counter = 0;
            while ((input = Console.ReadLine()) != password)
            {
                counter++;
                if (counter < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
