using System;

namespace _10_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distans = int.Parse(Console.ReadLine());
            int factor = int.Parse(Console.ReadLine());

            int targetsCount = 0;
            int powerLeft = power;

            while (powerLeft >= distans)
            {
                powerLeft -= distans;
                targetsCount++;
                if (powerLeft == power / 2)
                {
                    if (factor != 0)
                    {
                        powerLeft /= factor;
                    }
                }
            }
            Console.WriteLine(powerLeft);
            Console.WriteLine(targetsCount);
        }
    }
}
