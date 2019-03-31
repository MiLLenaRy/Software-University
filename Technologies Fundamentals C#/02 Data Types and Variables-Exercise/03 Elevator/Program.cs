using System;

namespace _03_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = people / capacity;

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
