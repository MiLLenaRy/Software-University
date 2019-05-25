using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _6._Parking_Lot
{
    public class StartIn
    {
        public static void Main(string[] args)
        {
            string command;
            var parking = new HashSet<string>();

            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string move = input[0];
                string carNumber = input[1];

                if (move == "OUT")
                {
                    parking.Remove(carNumber);
                }
                else
                {
                    parking.Add(carNumber);
                }
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
