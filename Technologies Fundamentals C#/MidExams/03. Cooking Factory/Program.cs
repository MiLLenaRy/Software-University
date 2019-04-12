using System;
using System.Collections.Generic;
using System.Linq;

namespace _03CookingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<int> theBestRecype = Console.ReadLine().Split('#').Select(int.Parse).ToList();



            while ((command = Console.ReadLine()) != "Bake It!")
            {
                List<int> array = command.Split("#").Select(int.Parse).ToList();

                if (array.Sum() > theBestRecype.Sum())
                {
                    theBestRecype = array;
                }
                if (array.Count() < theBestRecype.Count() && array.Sum() == theBestRecype.Sum())
                {
                    theBestRecype = array;
                }


            }
            Console.WriteLine($"Best Batch quality: {theBestRecype.Sum()}");
            Console.WriteLine(string.Join(' ', theBestRecype));
        }
    }
}