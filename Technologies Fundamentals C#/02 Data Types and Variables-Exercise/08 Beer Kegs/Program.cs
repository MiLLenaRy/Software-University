using System;

namespace _08_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beerKegs = int.Parse(Console.ReadLine());

            double bigerKeg = 0;
            string nameOfTheBigerKeg = string.Empty;

            for (int i = 0; i < beerKegs; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());

                double capacity = Math.PI * (r * r) * hight;
                if (bigerKeg < capacity)
                {
                    bigerKeg = capacity;
                    nameOfTheBigerKeg = model;
                }
            }
            Console.WriteLine(nameOfTheBigerKeg);
        }
    }
}
