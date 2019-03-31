using System;

namespace _09_Padawa
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double freeBelts = students / 6;
            double finalPrice = priceOfLightsaber * Math.Ceiling(students * 1.10) + (priceOfRobe * students) + priceOfBelts * (students - Math.Ceiling(freeBelts));

            if (finalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {finalPrice - money:F2}lv more.");
            }
        }
    }
}
