using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07__Truck_Tour
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int[] petrolPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                petrolPumps.Enqueue(petrolPump);
            }
            int index = 0;


            while (true)
            {
                int totralFuel = 0;

                foreach (var petrolPump in petrolPumps)
                {
                    int petrolAmount = petrolPump[0];
                    int distance = petrolPump[1];

                    totralFuel += petrolAmount - distance;

                    if (totralFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }
                if (totralFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
