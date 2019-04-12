using System;


namespace Problem_1._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            double flourPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int freePackages = 0;

            for (int a = 1; a <= students; a++)
            {
                if (a % 5 == 0)
                {
                    freePackages++;
                }
            }


            double finalPriceEggs = 10 * (eggsPrice * students);
            double finalPriceApron = Math.Ceiling(students * 1.2) * apronPrice;
            double finalPriceFlour = flourPrice * (students - freePackages);


            double finalPriceOfAllProdict = Math.Ceiling(finalPriceApron + finalPriceEggs + finalPriceFlour);
            double moreMoneyNeed = finalPriceOfAllProdict - budge;

            if (budge >= finalPriceOfAllProdict)
            {
                Console.WriteLine($"Items purchased for {finalPriceOfAllProdict:F2}$.");
            }

            else
            {
                Console.WriteLine($"{moreMoneyNeed:F2}$ more needed.");
            }

        }
    }
}
