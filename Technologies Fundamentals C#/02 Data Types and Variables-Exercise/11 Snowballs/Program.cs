using System;
using System.Numerics;

namespace _11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsNumber = int.Parse(Console.ReadLine());

            BigInteger bigerSnowballValue = 0;
            int bigerSnowballQuality = 0;
            int bigerSnowballTime = 0;
            int bigerSnowballSnow = 0;
            for (int a = 1; a <= snowballsNumber; a++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int timeAndSnow = (snowballSnow / snowballTime);
                BigInteger snowballValue = timeAndSnow;
                for (int i = 1; i < snowballQuality; i++)
                {
                    snowballValue *= timeAndSnow;
                }
                if (bigerSnowballValue < snowballValue)
                {
                    bigerSnowballValue = snowballValue;
                    bigerSnowballTime = snowballTime;
                    bigerSnowballSnow = snowballSnow;
                    bigerSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bigerSnowballSnow} : {bigerSnowballTime} = {bigerSnowballValue} ({bigerSnowballQuality})");

        }

    }
}
