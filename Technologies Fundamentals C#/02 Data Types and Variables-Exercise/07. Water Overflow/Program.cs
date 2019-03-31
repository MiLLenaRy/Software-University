using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int waterNow = 0;

            for (int i = 0; i < n; i++)
            {
                int putWater = int.Parse(Console.ReadLine());
                waterNow += putWater;
                if (putWater <= 255 && waterNow <= capacity)
                {

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterNow -= putWater;
                }
            }
            Console.WriteLine(waterNow);
        }
        static void Second(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int waterNow = 0;

            for (int i = 0; i < n; i++)
            {
                int putWater = int.Parse(Console.ReadLine());

                if (waterNow + putWater <= capacity)
                {
                    waterNow += putWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(waterNow);
        }
    }
}
